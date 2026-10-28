using CoBuildAPI.Entities;

namespace CoBuildAPI.Repositories.UserRepository.Interfaces;

public interface IUserRepository
{
	public void Upsert(User user);
}
