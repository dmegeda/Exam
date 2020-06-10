using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Entities
{
    public class ShopDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category_Id { get; set; }
    }
}
