namespace StaticWebpagesServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplication app = WebApplication.CreateBuilder(new WebApplicationOptions()
            {
                WebRootPath = args.First(),
                Args = args.Skip(1).ToArray()
            }).Build();

            app.UseStaticFiles();
            app.MapGet("/", () => "This is a static file server!");

            app.Run();
        }
    }
}
