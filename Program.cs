using Microsoft.EntityFrameworkCore;
using ShiftAPI.Models;

HttpClientHandler clientHandler = new HttpClientHandler();
clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

// // Pass the handler to httpclient(from you are calling api)
using(var httpClient = new HttpClient(clientHandler))
{
    var builder = WebApplication.CreateBuilder(args);
    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddDbContext<ShiftContext>(opt =>
        opt.UseInMemoryDatabase("ShiftList"));

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (builder.Environment.IsDevelopment())
        app.UseDeveloperExceptionPage();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
