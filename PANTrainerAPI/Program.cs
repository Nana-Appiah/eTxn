using PANTrainerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

var CorsPolicy = @"CorsPolicy";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
         .SetCompatibilityVersion(CompatibilityVersion.Latest)
         .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy,
                builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetPreflightMaxAge(TimeSpan.FromSeconds(5000))
                .SetIsOriginAllowed(x => true)
    );
});


builder.Services.AddDbContext<PantrainerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PanamString"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//added useRouting
app.UseRouting();

//useCors
app.UseCors(CorsPolicy);
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

app.UseAuthorization();

app.MapControllers();

app.Run();
