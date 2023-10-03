using LetterShifterService.Interface;
using LetterShifterService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Using DI for accesing the Services
builder.Services.AddScoped<ITranslateString, TranslateString>();


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
