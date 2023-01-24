using eKino.Services.Database;
using eKino.Services.Interfaces;
using eKino.Services.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<iMoviesService, MoviesService>();
builder.Services.AddTransient<iUserService, UserService>();
builder.Services.AddTransient<iDirectorService, DirectorService>();

builder.Services.AddAutoMapper(typeof(iUserService));
builder.Services.AddAutoMapper(typeof(iMoviesService));
builder.Services.AddAutoMapper(typeof(iDirectorService));
//builder.Services.AddSingleton<iMoviesService, MoviesService>();

builder.Services.AddDbContext<eKinoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
  
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
