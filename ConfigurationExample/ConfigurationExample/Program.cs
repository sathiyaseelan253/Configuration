using ConfigurationExample.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//Supply an object of AP
builder.Services.Configure<ConfigurationSettings>(builder.Configuration.GetSection("APIKeys"));

//Load configuration from Custom JSON file
builder.Configuration.AddJsonFile("MyOwnJson.json",optional:true,reloadOnChange:true);



var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


app.Run();
