using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccessLayer.Entities
{
    public class Spoil_Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category_Id { get; set; }
        public double PurchasePrice { get; set; }
        public double RealizationPrice { get; set; }
        public DateTime ManufacturerDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
