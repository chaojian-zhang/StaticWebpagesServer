namespace StaticWebpagesServer
{
    public class Program
    {
        private static readonly string _policyName = "CorsPolicy";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
            {
                WebRootPath = args.First()
            });
            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
            WebApplication app = builder.Build();

            app.UseCors(_policyName);
            app.UseStaticFiles();
            app.MapGet("/", () => "This is a static file server!");

            app.Run();
        }
    }
}
