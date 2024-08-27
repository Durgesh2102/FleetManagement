using Fleetmanagement_new.Service;
using Fleetmanagement_new.Services;
using Fleets.Services;
using FM.Services;
using FM_DotNet.Repositories;
using FM_DotNet.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<IStates,StateService>();
builder.Services.AddTransient<ICity,CityServices>();
builder.Services.AddTransient<IHub,hubServices>();
builder.Services.AddTransient<ICarService,CarService>();
builder.Services.AddTransient<ICarTypeService,CarTypeService>();
builder.Services.AddTransient<IAddOnService,AddOnService>();
builder.Services.AddTransient<IAirportService,AirportService>();
builder.Services.AddTransient<IBookingService,BookingService>();
builder.Services.AddTransient<IBookingDetailService,BookingDetailService>();
builder.Services.AddTransient<ICustomerService,CustomerService>();
builder.Services.AddTransient<IInvoiceDetailService,InvoiceDetailService>();
builder.Services.AddTransient<IInvoiceService,InvoiceService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FMContext>(o => o.UseMySQL(builder.Configuration.GetConnectionString("Default")));
//builder.Services.AddCors(o => o.AddDefaultPolicy(p => p.AllowAnyHeader().WithOrigins("*").AllowAnyMethod)));
builder.Services.AddCors((p)=> p.AddDefaultPolicy(policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors();
app.MapControllers();
app.Run();
