using Exam.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Item> Items { get; }
        IRepository<ShopDepartment> Departments { get; }
        IRepository<Spoil_Item> SpoilItems { get; }
        IRepository<Category> Categories { get; }
        void Save();
    }
}
