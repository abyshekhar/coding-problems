namespace Problems.AspNetCore.Middlewares
{
    public interface IMiddleware
    {
        Task InvokeAsync(HttpContext context);
    }
}
