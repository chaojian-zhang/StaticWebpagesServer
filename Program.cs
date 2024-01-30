namespace StaticWebpagesServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplication app = WebApplication.CreateBuilder(new WebApplicationOptions()
            {
                WebRootPath = args.First()
            }).Build();

            app.UseStaticFiles();
            app.MapGet("/", () => "This is a static file server!");

            app.Run();
        }
    }
}
