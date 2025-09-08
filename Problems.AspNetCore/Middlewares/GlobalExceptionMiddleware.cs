namespace Problems.AspNetCore.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly RequestDelegate _next;
        public GlobalExceptionMiddleware(RequestDelegate next,ILogger<GlobalExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;

        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
               await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,$"An error occurred:{ex.Message}");
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";
                var payload = new { error = "An error occurred",details = ex.Message};
                await context.Response.WriteAsJsonAsync(payload);
            }

        }
    }
}
