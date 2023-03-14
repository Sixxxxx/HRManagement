using HRManagementSystem.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly ITriangleService _triangleService;
        private readonly IRectangleService _rectangleService;
        private readonly ICircleService _circleService;

        public ShapeController(ITriangleService triangleService,IRectangleService rectangleService, ICircleService circleService)
        {
            _triangleService = triangleService;
            _rectangleService = rectangleService;
            _circleService = circleService;
        }

        [HttpGet("area-of-circle")]
        public async Task<IActionResult> GetAreaOfCircle(double radius)
        {
            double response = _circleService.CalculateArea(radius);
            return Ok(response);
        }

         [HttpGet("area-of-rectangle")]
        public async Task<IActionResult> GetAreaOfRectangle(double basee, double height)
        {
            double response = _rectangleService.CalculateArea(basee, height);
            return Ok(response);
        }

         [HttpGet("area-of-circle")]
        public async Task<IActionResult> GetAreaOfTriangle(double basee, double height)
        {
            double response = _triangleService.CalculateArea(basee, height);
            return Ok(response);
        }
    }
}
