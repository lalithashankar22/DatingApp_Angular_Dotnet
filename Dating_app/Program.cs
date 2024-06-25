using Dating_app.DB_Context;
using Microsoft.EntityFrameworkCore;


///dotnet new globaljson
///dotnet new gitignore
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



builder.Services.AddDbContext<DA_DBContextClass>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("datingapp")));
var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
