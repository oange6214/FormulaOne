using FormulaOne.Entities.DbSet;

namespace FormulaOne.DataService.Repositories.Interfaces;

public interface IAchievementsRepository : IGenericRepository<Achievement>
{
    Task<Achievement?> GetDriverAchievementAsync(Guid driverId);
}
