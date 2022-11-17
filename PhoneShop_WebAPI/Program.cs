using BussinesLogic.Interfaces;
using BussinesLogic.Services;
using Data.Data;
using Data.Models;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connStr = builder.Configuration.GetConnectionString("LocalDb");

builder.Services.AddControllers();

builder.Services.AddDbContext<PhoneShopDbContext>(options => options.UseSqlServer(connStr));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<PhoneShopDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IPhoneService, PhoneService>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
