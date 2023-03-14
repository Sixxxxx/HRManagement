using System.Reflection;
using HRManagementSystem.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabaseConnection();
//Add automapper
builder.Services.AddAutoMapper(Assembly.Load("HRManagementSystem.Models"));
builder.Services.RegisterServices();
builder.Services.AddHttpContextAccessor();


builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
{
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
}));
var app = builder.Build();
//var context = app.Services.CreateScope().ServiceProvider.GetService<ApplicationDBContext>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("AllowAll");
//app.ConfigureException(builder.Environment);
//await context.RunPendingMigrationsAsync();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.UseStaticFiles();



app.Run();
