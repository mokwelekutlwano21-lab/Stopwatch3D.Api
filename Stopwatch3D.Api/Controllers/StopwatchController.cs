using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

[ApiController]
[Route("api/stopwatch")]
public class StopwatchController : ControllerBase
{
    private static Stopwatch stopwatch = new Stopwatch();

    [HttpPost("start")]
    public IActionResult Start()
    {
        stopwatch.Start();
        return Ok("Started");
    }

    [HttpPost("stop")]
    public IActionResult Stop()
    {
        stopwatch.Stop();
        return Ok("Stopped");
    }

    [HttpPost("reset")]
    public IActionResult Reset()
    {
        stopwatch.Reset();
        return Ok("Reset");
    }

    [HttpGet("time")]
    public IActionResult GetTime(double speed)
    {
        double distance = speed * stopwatch.Elapsed.TotalHours;

        return Ok(new
        {
            time = stopwatch.Elapsed.ToString(@"hh\:mm\:ss"),
            distance = Math.Round(distance, 2)
        });
    }
}
