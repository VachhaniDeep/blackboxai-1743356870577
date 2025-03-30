using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllBlueResort.Web.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [Required]
        [StringLength(10)]
        public string RoomNumber { get; set; }

        [Required]
        [ForeignKey("RoomType")]
        public int RoomTypeID { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Available";

        [StringLength(500)]
        public string Notes { get; set; }

        // Navigation properties
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        public Room()
        {
            Bookings = new HashSet<Booking>();
        }
    }
}
