using System;
using System.ComponentModel.DataAnnotations;

namespace AllBlueResort.Web.Models
{
    public class Resort
    {
        [Key]
        public int ResortID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public string Description { get; set; }

        public TimeSpan CheckInTime { get; set; } = new TimeSpan(14, 0, 0);

        public TimeSpan CheckOutTime { get; set; } = new TimeSpan(12, 0, 0);
    }
}