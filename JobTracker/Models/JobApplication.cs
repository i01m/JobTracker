using System;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Company { get; set; }

        [Required, StringLength(100)]
        public string Position { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateApplied { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string Status { get; set; } = "Applied"; // Applied, Interviewing, Offer, Rejected

        [StringLength(250)]
        public string Notes { get; set; }
    }
}

