using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BusinessLogicLayer.DataTransferObjects
{
    public class ShopDepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryDTO AvailableCategory { get; set; }
    }
}
