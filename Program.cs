using GBastos.Ordena_livros.Repositories;
using GBastos.Ordena_livros.Repositories.Interfaces;
using GBastos.Ordena_livros.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<ILivroRepository, LivroRepositoryInMemory>();
builder.Services.AddScoped<LivroService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();