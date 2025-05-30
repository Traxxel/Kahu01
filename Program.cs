using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Kahu01;
using DevExpress.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDevExpressBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<Kahu01.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
