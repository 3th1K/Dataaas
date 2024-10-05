using Dataaas.Web.Components;
using Dataaas.Web.Services.Animals.CatFacts;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// custom services
builder.Services.AddSingleton<ICatFactsService, CatFactsService>();

//clients
builder.Services.AddHttpClient<ICatFactsService, CatFactsService>(options =>
{
    options.BaseAddress = new Uri("https://cat-fact.herokuapp.com");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();