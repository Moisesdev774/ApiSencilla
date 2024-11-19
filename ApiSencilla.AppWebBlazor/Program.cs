using ApiSencilla.AppWebBlazor.Books; // Asegúrate de que este namespace sea correcto
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Configura el HttpClient con la URL base de tu API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7270/") });

// Registra el servicio BookService para la inyección de dependencias
builder.Services.AddScoped<BookService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
