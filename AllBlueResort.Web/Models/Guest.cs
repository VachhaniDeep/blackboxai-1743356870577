using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllBlueResort.Web.Models
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        [StringLength(50)]
        public string? City { get; set; }

        [StringLength(50)]
        public string? Country { get; set; }

        [StringLength(500)]
        public string? AdditionalNotes { get; set; }

        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}