using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Queue
    {
        [Key]
        public int Id { get; set; }
        public DateTime RegDate { get; set; }
        public int ChildId { get; set; }
        public Child Child { get; set; } = null!;
        //public int GroupId { get; set; }
        public Group Group { get; set; } = null!;
    }
}