using leave_managment.Contrct;
using leave_managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Repositories
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {

        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveType entity)
        {
            //throw new NotImplementedException();
            _db.LeaveTypes.Add(entity);
            //save
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            //throw new NotImplementedException();
            _db.LeaveTypes.Remove(entity);
            //save
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
           return _db.LeaveTypes.ToList();
            //throw new NotImplementedException();
        }

        public LeaveType FindById(int id)
        {
            // throw new NotImplementedException();
            var leaveType = _db.LeaveTypes.Find(id);
            return leaveType;
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            //throw new NotImplementedException();
            return changes > 0;
        }

        public bool Update(LeaveType entity)
        {
            //throw new NotImplementedException();
            _db.LeaveTypes.Update(entity);
            //save
            return Save();
        }
    }
}
