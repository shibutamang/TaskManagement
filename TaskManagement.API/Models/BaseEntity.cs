using System.ComponentModel.DataAnnotations;

namespace TaskManagement.API.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        public Guid? LastModifiedBy { get; set; }
    }
} 