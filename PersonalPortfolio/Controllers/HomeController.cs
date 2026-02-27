using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Models;
using PersonalPortfolio.Services;

namespace PersonalPortfolio.Controllers;

public class HomeController(
    IProjectService projectService,
    ISkillService skillService,
    ILogger<HomeController> logger) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index(CancellationToken ct)
    {
        var projects = await projectService.GetAllAsync(ct);
        var skills = await skillService.GetAllAsync(ct);

        logger.LogInformation(
            "Home page requested. Projects={ProjectCount} Skills={SkillCount}",
            projects.Count, skills.Count);

        var model = new HomeIndexViewModel
        {
            Projects = ProjectCardMapper.ToViewModels(projects),
            Skills = skills
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() =>
        View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
}
