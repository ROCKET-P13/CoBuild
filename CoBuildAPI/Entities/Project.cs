using CoBuildAPI.Enums;

namespace CoBuildAPI.Entities;

public class Project
{
	public Guid Id { get; set; }
	public Guid OwnerId { get; set; }
	public User Owner { get; set; } = null!;

	public required string Name { get; set; }
	public required string Description { get; set; }

	public ProjectStatus Status { get; private set; }

	public required DateTimeOffset CreatedAt { get; set; }
	public DateTimeOffset UpdatedAt { get; set; }
}
