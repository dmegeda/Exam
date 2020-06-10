using Exam.BusinessLogicLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BusinessLogicLayer.Interfaces
{
    public interface IControlItemService
    {
        void AddItem(ItemDTO itemDTO);
        void DeleteItem(int? id);
        void UpdateGenre(ItemDTO itemDTO);
        ItemDTO GetItem(int? id);
        IEnumerable<ItemDTO> GetItems();
        void Dispose();
    }
}
