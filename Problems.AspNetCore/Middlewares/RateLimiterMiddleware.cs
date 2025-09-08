using System.Collections.Concurrent;

namespace Problems.AspNetCore.Middlewares
{
    public class RateLimiterMiddleware:IMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ConcurrentDictionary<string,(int Count,DateTime WindowStart)> _store = new();
        private readonly int _limit = 2;
        private readonly TimeSpan _window = TimeSpan.FromMinutes(1);
        public RateLimiterMiddleware(RequestDelegate next)=>_next = next;


        public async Task InvokeAsync(HttpContext context)
        {
            string ip = context.Connection.RemoteIpAddress?.ToString()??"unknown";
            var now = DateTime.UtcNow;

            _store.AddOrUpdate(ip,
                _ => (1, now),
                (_, state) =>
                {
                    if (now - state.WindowStart > _window) return (1, now);
                    return (state.Count + 1, state.WindowStart);
                });

            var stateNow = _store[ip];
            if (stateNow.Count > _limit)
            {
                context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                await context.Response.WriteAsync("Rate limit exceeded. Try again later.");
                return;
            }
            await _next(context);
        }
    }
}
