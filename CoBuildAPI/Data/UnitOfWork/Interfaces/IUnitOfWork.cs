namespace CoBuildAPI.Data.UnitOfWork.Interfaces;

public interface IUnitOfWork
{
	Task SaveChanges();
}
