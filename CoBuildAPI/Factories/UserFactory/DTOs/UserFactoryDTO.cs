namespace CoBuildAPI.Factories.UserFactory.DTOs;

public class UserFactoryDTO
{
	public required string AuthProvider { get; set; }
	public required string AuthProviderId { get; set; }
	public required string Email { get; set; }
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
}
