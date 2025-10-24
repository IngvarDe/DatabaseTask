using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
        public class JobTitle
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int EmployeeId { get; set; }
            public Employee Employee { get; set; } = null!;
        }
    }
