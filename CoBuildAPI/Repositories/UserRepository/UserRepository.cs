using CoBuildAPI.Data;
using CoBuildAPI.Entities;
using CoBuildAPI.Repositories.UserRepository.Interfaces;

namespace CoBuildAPI.Repositories.UserRepository;

public class UserRepository(AppDatabaseContext databaseContext) : IUserRepository
{
	private readonly AppDatabaseContext _databaseContext = databaseContext;

	public async void Upsert(User user)
	{
		await _databaseContext.AddAsync(user);
	}
}
