namespace WEBAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container
            builder.Services.AddControllers();



            var app = builder.Build();

            // Configuration the Http Request Pipeline
            app.UseRouting();
            app.MapControllers();




            //  app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}