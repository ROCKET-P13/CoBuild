using CoBuildAPI.Entities;
using CoBuildAPI.Factories.UserFactory.DTOs;
using CoBuildAPI.Factories.UserFactory.Interfaces;

namespace CoBuildAPI.Factories.UserFactory;

public class UserFactory : IUserFactory
{
	public User FromDto(UserFactoryDTO dto)
	{
		return new User
		{
			Id = Guid.NewGuid(),
			AuthProvider = dto.AuthProvider,
			AuthProviderId = dto.AuthProviderId,
			Email = dto.Email,
			FirstName = dto.FirstName,
			LastName = dto.LastName,
			CreatedAt = DateTimeOffset.UtcNow,
		};
	}
}
