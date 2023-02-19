using Cakupi.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cakupi.Controllers;

[ApiController]
[Route("/api/v1/reporter")]
public class ReporterController : ControllerBase {
    private readonly ICoverageReporter _coverageReporter;

    public ReporterController(ICoverageReporter coverageReporter) {
        _coverageReporter = coverageReporter;
    }

    [HttpPost]
    public IActionResult CreateReport() {
        return Ok();
    }
}
