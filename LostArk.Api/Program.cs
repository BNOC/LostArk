using LostArk.Api.Data;
using LostArk.Api.Repositories;
using LostArk.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<LostArkDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LostArk"))
);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICharacterTaskRepository, CharacterTaskRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Allow use
app.UseCors(policy =>
    policy.WithOrigins("http://localhost:7063", "https://localhost:7063")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
