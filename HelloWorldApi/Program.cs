var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

//Serve Static Files
app.UseDefaultFiles();
app.UseStaticFiles();

//API Endpoints
app.MapControllers(); 

app.Run("http://localhost:5001");
