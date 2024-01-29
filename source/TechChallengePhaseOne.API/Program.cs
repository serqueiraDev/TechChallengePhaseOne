using Microsoft.EntityFrameworkCore;
using TechChallengePhaseOne.Application;
using TechChallengePhaseOne.Application.Interface;
using TechChallengePhaseOne.Application.Mapper;
using TechChallengePhaseOne.Application.Mapper.Interface;
using TechChallengePhaseOne.Data;
using TechChallengePhaseOne.Data.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Repository;
using TechChallengePhaseOne.Domain.Core.Interface.Service;
using TechChallengePhaseOne.Domain.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IApplicationServiceAcao, ApplicationServiceAcao>();
builder.Services.AddScoped<IApplicationServiceContaInvestimento, ApplicationServiceContaInvestimento>();

builder.Services.AddScoped<IServiceAcao, ServiceAcao>();
builder.Services.AddScoped<IServiceContaInvestimento, ServiceContaInvestimento>();

builder.Services.AddScoped<IRepositoryAcao, RepositoryAcao>();
builder.Services.AddScoped<IRepositoryContaInvestimento, RepositoryContaInvestimento>();

builder.Services.AddScoped<IMapperAcao, MapperAcao>();
builder.Services.AddScoped<IMapperContaInvestimento, MapperContaInvestimento>();

builder.Services.AddDbContext<SqlContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionString")));


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