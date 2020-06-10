using Exam.DataAccessLayer.Entities;
using Exam.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private ItemRepository ItemRepository;
        private ShopDepartmentRepository DepartmentRepository;

        public UnitOfWork(string connectionString)
        {
            db = new DatabaseContext(connectionString);
        }

        public IRepository<Item> Items
        {
            get
            {
                if (ItemRepository == null)
                    ItemRepository = new ItemRepository(db);
                return ItemRepository;
            }
        }

        public IRepository<ShopDepartment> Departments
        {
            get
            {
                if (DepartmentRepository == null)
                    DepartmentRepository = new ShopDepartmentRepository(db);
                return DepartmentRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
