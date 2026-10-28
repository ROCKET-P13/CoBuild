namespace CoBuildAPI.Entities;

public class User
{
	public Guid Id { get; set; }
	public required string AuthProvider { get; set; }
	public required string AuthProviderId { get; set; }
	public required string Email { get; set; }
	public required string FirstName { get; set; }
	public required string LastName { get; set; }
	public required DateTimeOffset CreatedAt { get; set; }
}
