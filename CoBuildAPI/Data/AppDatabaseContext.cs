using CoBuildAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoBuildAPI.Data;

public class AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : DbContext(options)
{
	public DbSet<Project> Projects { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Project>(entity =>
		{
			entity.ToTable("Projects");
			entity.Property(entity => entity.Id).HasColumnName("id");
			entity.Property(entity => entity.OwnerId).HasColumnName("owner_id");
			entity.Property(entity => entity.Name).HasColumnName("name");
			entity.Property(entity => entity.Description).HasColumnName("description");
			entity.Property(entity => entity.Status).HasColumnName("status");
			entity.Property(entity => entity.CreatedAt).HasColumnName("created_at");
			entity.Property(entity => entity.UpdatedAt).HasColumnName("updated_at");
		});

		modelBuilder.Entity<User>(entity =>
		{
			entity.ToTable("Users");
			entity.Property(entity => entity.Id).HasColumnName("id");
			entity.Property(entity => entity.AuthProvider).HasColumnName("auth_provider");
			entity.Property(entity => entity.AuthProviderId).HasColumnName("auth_provider_id");
			entity.Property(entity => entity.Email).HasColumnName("email");
			entity.Property(entity => entity.FirstName).HasColumnName("first_name");
			entity.Property(entity => entity.LastName).HasColumnName("last_name");
			entity.Property(entity => entity.CreatedAt).HasColumnName("created_at");
		});

		modelBuilder.Entity<ProjectContributorApplication>(entity =>
		{
			entity.ToTable("ProjectContributorApplication");
			entity.Property(entity => entity.Id).HasColumnName("id");
			entity.Property(entity => entity.ProjectId).HasColumnName("project_id");
			entity.Property(entity => entity.UserId).HasColumnName("user_id");
			entity.Property(entity => entity.Status).HasColumnName("status");
			entity.Property(entity => entity.Message).HasColumnName("message");
			entity.Property(entity => entity.CreatedAt).HasColumnName("created_at");
			entity.Property(entity => entity.DecidedAt).HasColumnName("decided_at");
		});
	}
}
