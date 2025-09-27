using SyncedAPI.Data;
using SyncedAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddSingleton<MongoDBContext>();
builder.Services.AddSingleton<ScoreRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();


app.UseAuthorization();
app.MapControllers();

app.Run();
