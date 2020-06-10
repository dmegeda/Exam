using Exam.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Entities
{
    public class ItemRepository : IRepository<Item>
    {
        private DatabaseContext db;

        public ItemRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Item> GetAll() => db.Items;

        public Item Get(int id) => db.Items.Find(id);

        public void Create(Item item)
        {
            db.Items.Add(item);
        }

        public void Update(Item item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Item item = db.Items.Find(id);
            if (item != null)
                db.Items.Remove(item);
        }
    }
}
