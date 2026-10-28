using CoBuildAPI.Data;
using CoBuildAPI.Data.UnitOfWork;
using CoBuildAPI.Data.UnitOfWork.Interfaces;
using CoBuildAPI.Factories.UserFactory;
using CoBuildAPI.Factories.UserFactory.Interfaces;
using CoBuildAPI.Repositories.UserRepository;
using CoBuildAPI.Repositories.UserRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoBuildAPI;

public static class DependencyInjection
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddScoped<IUnitOfWork, UnitOfWork>();
		services.AddScoped<IUserFactory, UserFactory>();
		services.AddScoped<IUserRepository, UserRepository>();

		return services;
	}

	public static IServiceCollection AddDatabase(
		this IServiceCollection services,
		IConfiguration configuration
	)
	{
		services.AddDbContext<AppDatabaseContext>(options =>
			options.UseNpgsql(
				configuration.GetConnectionString("DefaultConnection"),
				npgsqlOptions =>
				{
					npgsqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
				}
			)
		);

		return services;
	}
}
