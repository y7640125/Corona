using BL.Interfaces;
using BL;
using DAL.Interfaces;
using DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IMemberBL, MemberBL>();
builder.Services.AddScoped<IMemberDAL, MemberDAL>();
builder.Services.AddScoped<IVaccinationBL, VaccinationBL>();
builder.Services.AddScoped<IVaccinationDAL, VaccinationDAL>();
builder.Services.AddScoped<IManufacturerBL, ManufacturerBL>();
builder.Services.AddScoped<IManufacturerDAL, ManufacturerDAL>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policyBuilder => policyBuilder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
