using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BackendAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BackendAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BackendAPIContext") ?? throw new InvalidOperationException("Connection string 'BackendAPIContext' not found.")));


// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});






// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
// set appication to use cors policy sn
app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
