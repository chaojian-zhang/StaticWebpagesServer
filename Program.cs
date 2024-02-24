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

            app.Use(async (context, next) =>
            {
                // Per: https://github.com/godotengine/godot-proposals/issues/6616
                context.Response.Headers.Append("Cross-Origin-Opener-Policy", "same-origin");
                context.Response.Headers.Append("Cross-Origin-Embedder-Policy", "require-corp");
                await next.Invoke();
            });
            app.UseDefaultFiles(); // Must do this before UseStaticFiles
            app.UseStaticFiles(new StaticFileOptions
            {
                ServeUnknownFileTypes = true,
            });

            app.Run();
        }
    }
}
