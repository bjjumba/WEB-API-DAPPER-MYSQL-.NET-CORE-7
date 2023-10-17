using SONDA.Models.Data;
using SONDA.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
/*Register DB Context*/
builder.Services.AddTransient<DapperDBContext>();
/* user repositoty and interface*/
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IBranchRespository, BranchRespository>();
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