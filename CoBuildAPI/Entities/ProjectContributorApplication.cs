using CoBuildAPI.Enums;

namespace CoBuildAPI.Entities;

public class ProjectContributorApplication
{
	public Guid Id { get; set; }

	public Guid ProjectId { get; set; }
	public Project Project { get; set; } = null!;

	public Guid UserId { get; set; }
	public User User { get; set; } = null!;

	public ProjectContributorApplicationStatus Status { get; set; }
	public string? Message { get; set; }

	public DateTimeOffset CreatedAt { get; set; }
	public DateTimeOffset? DecidedAt { get; set; }
}
