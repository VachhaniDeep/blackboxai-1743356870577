using AllBlueResort.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace AllBlueResort.Web.Models
{
    public class AdminDashboardViewModel
    {
        public int UserCount { get; set; }
        public int AvailableRooms { get; set; }
        public List<Booking> RecentBookings { get; set; }
    }

    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }

    public class RoleViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}