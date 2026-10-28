using CoBuildAPI.Data.UnitOfWork.Interfaces;

namespace CoBuildAPI.Data.UnitOfWork;

public sealed class UnitOfWork(AppDatabaseContext databaseContext) : IUnitOfWork
{
	private readonly AppDatabaseContext _databaseContext = databaseContext;

	public async Task SaveChanges()
	{
		await _databaseContext.SaveChangesAsync();
	}
}