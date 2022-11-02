using System.Text;
using Covid.DAL.Repositories;
using Covid.Entities.Patient;
using Covid.Services.Patients;
//using Covid.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add Database Service.
//builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services
    .AddControllers()
    .AddFluentValidation(x =>
{
    x.ImplicitlyValidateChildProperties = true;
});

//Register FluentValidation 
builder.Services.AddTransient<IValidator<Patient>, PatientValidation>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IPatientData, PatientData>();

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
