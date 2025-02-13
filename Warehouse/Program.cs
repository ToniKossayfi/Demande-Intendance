using BlazorDownloadFile;
using OfficeOpenXml;
using Warehouse.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
BlazorDownloadFile.ServiceCollectionExtensions.AddBlazorDownloadFile(builder.Services);


// Set the license context
ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // or LicenseContext.Commercial

using (var package = new ExcelPackage())
{
    // Your code here
}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts(); // The default HSTS value is 30 days. For production scenarios, consider adjusting this value.
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
