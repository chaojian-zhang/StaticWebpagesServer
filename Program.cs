namespace StaticWebpagesServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseStaticFiles();
            app.MapGet("/", () => "This is a static file server!");

            app.Run();
        }
    }
}
