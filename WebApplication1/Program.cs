using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Interfaces;
using WebApplication1.Repositories;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// получаем строку подключения из файла конфигурации
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPeopleService, PeopleService>();
builder.Services.AddScoped<IIPhoneService, IPhoneService>();
builder.Services.AddScoped<IAnimalsService, AnimalsService>();

builder.Services.AddTransient<IPeopleRepository, PeopleRepository>();
builder.Services.AddTransient<IIPhoneRepository, IPhoneRepository>();
builder.Services.AddTransient<IAnimalsRepository, AnimalsRepository>();

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
