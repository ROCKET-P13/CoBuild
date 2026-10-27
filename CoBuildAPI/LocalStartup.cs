namespace CoBuildAPI;

public class LocalStartup(IConfiguration configuration)
{
	public IConfiguration Configuration { get; } = configuration;

	public void ConfigureServices(IServiceCollection services)
	{
		services.AddControllers();
		services.AddApplicationServices();
		services.AddDatabase(Configuration);
		services.AddEndpointsApiExplorer();
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			Console.WriteLine("Development");
		}

		app.UseHttpsRedirection();
		app.UseRouting();

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapControllers();
		});
	}
}
