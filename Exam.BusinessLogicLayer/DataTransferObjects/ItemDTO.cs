using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BusinessLogicLayer.DataTransferObjects
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryDTO Category { get; set; }
        public double PurchasePrice { get; set; }
        public double RealizationPrice { get; set; }

        public ItemDTO()
        {

        }
    }
}
