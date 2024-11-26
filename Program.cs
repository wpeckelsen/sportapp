using Microsoft.EntityFrameworkCore;
using Npgsql;

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// Add other services (e.g., controllers, etc.)
builder.Services.AddControllers();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();     // Redirects HTTP to HTTPS (near the beginning)
app.UseRouting();              // Adds routing functionality
app.UseAuthentication();       // Handles authentication (user login)
app.UseAuthorization();        // Handles authorization (permissions/roles)
app.MapControllers();          // Maps API controllers (or endpoints)


app.Run();


