using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.BusinessLogicLayer.DataTransferObjects
{
    class SpoilItemDTO : ItemDTO
    {
        public DateTime ManufacturerDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public SpoilItemDTO(DateTime manufacturerDate, DateTime expirationDate) : base()
        {

        }
    }
}
