using Exam.BusinessLogicLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BusinessLogicLayer.Interfaces
{
    public interface IControlDepartmentService
    {
        void AddDepartment(ShopDepartmentDTO departmentDTO);
        void DeleteDepartment(int? id);
        void UpdateDepartment(ShopDepartmentDTO departmentDTO);
        ShopDepartmentDTO GetDepartment(int? id);
        IEnumerable<ShopDepartmentDTO> GetItems();
        void AddItemsToDepartment(ShopDepartmentDTO dep, ItemDTO item);
        bool CheckAvailableCategory(ShopDepartmentDTO dep, ItemDTO item);
        void Dispose();
    }
}
