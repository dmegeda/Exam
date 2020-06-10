using Exam.BusinessLogicLayer.DataTransferObjects;
using Exam.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.DataAccessLayer;
using Exam.DataAccessLayer.Interfaces;

namespace Exam.BusinessLogicLayer.Services
{
    public class ControlDepartmentService : IControlDepartmentService
    {
        IUnitOfWork DB { get; set; }

        public ControlDepartmentService(IUnitOfWork unit)
        {
            DB = unit;
        }
        void AddDepartment(ShopDepartmentDTO departmentDTO)
        {
            //code will be here
        }
        void DeleteDepartment(int? id)
        {
            //code will be here
        }
        void UpdateDepartment(ShopDepartmentDTO departmentDTO)
        {
            //code will be here
        }
        ShopDepartmentDTO GetDepartment(int? id)
        {
            //code will be here
            ShopDepartmentDTO d = new ShopDepartmentDTO();
            return d;
        }
        IEnumerable<ShopDepartmentDTO> GetItems()
        {
            //code will be here
        }

        void AddItemToDepartment(ShopDepartmentDTO dep, ItemDTO item)
        {
            if(CheckAvailbaleCategory(dep, item))
            {
                //code will be here
            }
        }

        bool CheckAvailbaleCategory(ShopDepartmentDTO dep, ItemDTO item)
        {
            bool result = false;
            if(dep.AvailableCategory == item.Category)
            {
                result = true;
            }
            return result;
        }
        void Dispose()
        {
            DB.Dispose();
        }
    }
}
