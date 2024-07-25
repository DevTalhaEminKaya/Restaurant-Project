using Dal.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities.Models
{
    public class EmployeeOffDay
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public List<OffDays> OffDays { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
