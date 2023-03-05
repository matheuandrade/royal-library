using RoyalLibrary.Application;
using RoyalLibrary.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{           
    builder.Services
            .AddInfrastructure()
            .AddApplication();

    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();

    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.Run();   
}
