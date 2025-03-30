using System.ComponentModel.DataAnnotations;

namespace AllBlueResort.Web.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal BasePrice { get; set; }

        [Required]
        public int Capacity { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        // Navigation property
        public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
