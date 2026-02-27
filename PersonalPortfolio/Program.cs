using PersonalPortfolio.Middleware;
using PersonalPortfolio.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<IProjectService, ProjectService>();
builder.Services.AddSingleton<ISkillService, SkillService>();

builder.Services.AddHealthChecks();

var app = builder.Build();

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSecurityHeaders();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapBlazorHub();
app.MapHealthChecks("/health");

app.Run();