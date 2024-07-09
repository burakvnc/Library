using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Shared.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime MembershipDate { get; set; }
    }
}
