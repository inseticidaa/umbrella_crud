using Repository.Dapper;
using Repository.Dapper.Repository;
using Domain.Interfaces;
using Domain.Adapters;
using Domain.Services;
using Application.Services;
using Application;

var builder = WebApplication.CreateBuilder(args);

#region [Services]

builder.Services.AddScoped<DbContext>();
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
builder.Services.AddSingleton<IConfiguration>(configuration);

// Repositories
builder.Services.AddTransient<IUsersRepository, UserRespository>();

// Services
builder.Services.AddTransient<IAuthService, AuthService>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion [Services]

#region [App]

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

#endregion [App]