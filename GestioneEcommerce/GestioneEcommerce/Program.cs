using GestioneEcommerce.dbSet;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region impostare il dbContext
string StringaConnessione = "mettere la stringa di connessione al db";
StringaConnessione =
builder.Configuration.GetSection("ConnectionStrings").Value.ToString();
builder.Services.AddDbContext<DB_Ecommerce>(
 options => options.UseSqlServer(StringaConnessione
 )
 );
#endregion
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
