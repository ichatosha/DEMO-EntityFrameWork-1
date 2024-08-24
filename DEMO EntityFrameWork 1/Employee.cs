using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_EntityFrameWork_1
{
    internal class Employee
    {
        [Key]
        public int Id  { get; set; }

        public string? Name { get; set; }

        public int  Salary { get; set; }
        
    }
}
