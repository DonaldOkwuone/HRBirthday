using HRBirthday.Entity;
using HRBirthday.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRBirthday.Repository
{
    public class StaffRepo : IStaffRepo
    {
        private readonly StaffDbContext _dbContext;
        public StaffRepo(StaffDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Add(Staff entity)
        {
            _dbContext.Add(entity);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Staff>> GetAll()
        {
            var result = await _dbContext.Hrstaff.ToListAsync();
            return result;
        }

        public Staff GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Staff entity)
        {
            throw new NotImplementedException();
        }
    }
}
