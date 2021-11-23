var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.UseHttpsRedirection();

app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
