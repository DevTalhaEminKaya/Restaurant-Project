using Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities.Models
{
    public class EmployeeOffDayHistory
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public List<OffDays> OldData { get; set; }
        public List<OffDays> NewData { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
