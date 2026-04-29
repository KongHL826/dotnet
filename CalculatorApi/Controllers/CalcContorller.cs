using Microsoft.AspNetCore.Mvc;
namespace CalculatorApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CalcController : ControllerBase
{
    [HttpPost("Add/{a}/{b}")]
    public IActionResult Add(int a, int b) => Ok(a + b);
    [HttpGet("Subtract/{a}/{b}")]
    public IActionResult Subtract(int a, int b) => Ok(a - b);
    [HttpGet("Multiply/{a}/{b}")]
    public IActionResult Multiply(int a, int b) => Ok(a * b); [HttpGet("Divide/{a}/{b}")]
    public IActionResult Divide(int a, int b)
    {
        if (b == 0) return BadRequest("除数不能为0");
        return Ok((double)a / b);
    }
    [HttpGet("Leap/{year}")]
    public IActionResult IsLeapYear(int year)
    {
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        return Ok(new { Year = year, IsLeapYear = isLeap });
    }
}