var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}");

//app.MapGet("/", () => "Hello World!");

app.Run();
