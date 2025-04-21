using System;
using System.ComponentModel.DataAnnotations;
using static LeadProject_API.Enum.EnumLead;

namespace LeadManagementAPI.Models
{
    public class LeadBO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Suburb { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }


        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public LeadStatus Status { get; set; } = LeadStatus.Invited;
    }
}
