using Exam.BusinessLogicLayer.DataTransferObjects;
using Exam.BusinessLogicLayer.Interfaces;
using Exam.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BusinessLogicLayer.Services
{
    public class ControlItemService : IControlItemService
    {
        IUnitOfWork DB { get; set; }

        public ControlItemService(IUnitOfWork unit)
        {
            DB = unit;
        }

        void AddItem(ItemDTO itemDTO)
        {
            //code will be here
        }
        void DeleteItem(int? id)
        {
            //code will be here
        }
        void UpdateGenre(ItemDTO itemDTO)
        {
            //code will be here
        }
        ItemDTO GetItem(int? id)
        {
            ItemDTO item = new ItemDTO();
            return item;
        }
        IEnumerable<ItemDTO> GetItems()
        {
            //code will be here
        }
        void Dispose()
        {
            DB.Dispose;
        }
    }
}
