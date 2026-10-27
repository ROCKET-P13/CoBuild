using Microsoft.EntityFrameworkCore;

namespace CoBuildAPI;

public static class DependencyInjection
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		return services;
	}

	public static IServiceCollection AddDatabase(
		this IServiceCollection services,
		IConfiguration configuration
	)
	{
		// services.AddDbContext<AppDatabaseContext>(options =>
		// 	options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
		// );

		return services;
	}
}
