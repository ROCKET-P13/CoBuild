using CoBuildAPI.Entities;
using CoBuildAPI.Factories.UserFactory.DTOs;

namespace CoBuildAPI.Factories.UserFactory.Interfaces;

public interface IUserFactory
{
	public User FromDto(UserFactoryDTO dto);
}