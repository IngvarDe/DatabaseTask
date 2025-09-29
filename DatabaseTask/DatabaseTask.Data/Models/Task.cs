using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data.Models;

public partial class Task
{
    [Key]
    public int TaskId { get; set; }

    [StringLength(200)]
    public string TaskName { get; set; } = null!;

    [StringLength(500)]
    public string? Description { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime? DueDate { get; set; }

    public int? ProjectId { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("Tasks")]
    public virtual Project? Project { get; set; }
}
