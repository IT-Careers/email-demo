using DemoEmail.App.Models.Configuration;
using DemoEmail.App.Services;

var builder = WebApplication.CreateBuilder(args);

// Email Configuration
var emailConfig = builder.Configuration
    .GetSection("GmailConfiguration")
    .Get<GmailConfiguration>();

builder.Services.AddSingleton(emailConfig);

builder.Services.AddTransient<IEmailService, EmailService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
