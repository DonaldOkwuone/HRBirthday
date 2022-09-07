using HRBirthday.Entity;

namespace HRBirthday.Interfaces
{
    public interface IStaffRepo
    {
        public Task<IEnumerable<Staff>> GetAll();

        public Staff GetById(int id);

        public Task<bool> Update(Staff entity);

        public Task<bool> Delete(int id);

        public Task<bool> Add(Staff entity);

    }
}
