using Service.ReportService;

namespace StajVbtReport
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();     
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IReportService, ReportService>();
            builder.Services.AddControllersWithViews()
                .AddNewtonsoftJson(opts => opts.UseMemberCasing())
                .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);


            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(); 
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.Use(async (context, next) =>
            {
                if (context.Request.Method == "POST" &&
                    context.Request.Path.Value.Contains("/api/report/GetStajReport") &&
                    string.IsNullOrEmpty(context.Request.ContentType))
                {
                    context.Request.ContentType = "application/json";
                }

                await next();
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

            app.Run();
        }
    }
}
