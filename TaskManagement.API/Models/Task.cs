using System.ComponentModel.DataAnnotations;
using TaskManagement.API.Enums;
using TaskStatus = TaskManagement.API.Enums.TaskStatus;

namespace TaskManagement.API.Models
{
    public class TaskItem : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Description { get; set; }

        public TaskStatus Status { get; set; }

        public PriorityLevel Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? CompletedAt { get; set; }

        public string? AssignedTo { get; set; }
    }
} 