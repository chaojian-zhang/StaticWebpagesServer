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

            app.Use(async (context, next) =>
            {
                // Per: https://github.com/godotengine/godot-proposals/issues/6616
                context.Response.Headers.Append("Cross-Origin-Opener-Policy", "same-origin");
                context.Response.Headers.Append("Cross-Origin-Embedder-Policy", "require-corp");
                await next.Invoke();
            });
            app.UseStaticFiles();
            app.MapGet("/", () => "This is a static file server!");

            app.Run();
        }
    }
}
