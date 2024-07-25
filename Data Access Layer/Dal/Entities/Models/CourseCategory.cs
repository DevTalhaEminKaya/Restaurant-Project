using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities.Models
{
    public class CourseCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
