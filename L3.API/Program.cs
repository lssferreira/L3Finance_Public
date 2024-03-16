using L3.API.EndPoints;
using Shared.Data;
using Shared.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddDbContext<L3FContext>();
builder.Services.AddTransient<DAL<ContaPagar>>();
builder.Services.AddTransient<DAL<RegrasContasPagar>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.MapContasPagarEndPoints();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(builder =>
            builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());

app.Run();
