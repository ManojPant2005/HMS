using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HMS.Model.DatabaseModel
{
    [Table("Login")]
    public class Login
    {
        [Key]

        public string Id { get; set; }

        [Required]

        public string HashPassword { get; set; }

        [Required]

        public string SaltPassword { get; set; }


        public bool IsActive { get; set; }

        [Required]
        public string LoginType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
