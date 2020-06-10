using Exam.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Entities
{
    public class ShopDepartmentRepository : IRepository<ShopDepartment>
    {
        private DatabaseContext db;

        public ShopDepartmentRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<ShopDepartment> GetAll() => db.Departments;

        public ShopDepartment Get(int id) => db.Departments.Find(id);

        public void Create(ShopDepartment department)
        {
            db.Departments.Add(department);
        }

        public void Update(ShopDepartment department)
        {
            db.Entry(department).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            ShopDepartment department = db.Departments.Find(id);
            if (department != null)
                db.Departments.Remove(department);
        }
    }
}
