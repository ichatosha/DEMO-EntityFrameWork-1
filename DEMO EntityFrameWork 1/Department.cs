using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_EntityFrameWork_1
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
    }
}
