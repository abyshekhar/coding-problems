using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Problems.AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("throw-exception")]
        public IActionResult ThrowException()
        {
            _logger.LogInformation("Attempting to throw an exception...");

            try
            {
                throw new InvalidOperationException("This is a deliberate handled exception from the controller for demonstration.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred in {MethodName}.", nameof(ThrowException));
                return StatusCode(500, "An internal server error occurred.");
            }
        }

        [HttpGet("throw-global-exception")]
        public IActionResult ThrowGlobalException()
        {
            _logger.LogInformation("Attempting to throw an exception...");
            throw new InvalidOperationException("This is a deliberate unhandled exception from the controller for demonstration.");
        }
    }
}
