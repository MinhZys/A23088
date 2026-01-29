using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_image.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength(32)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Fullname { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [StringLength(1000)]
        public string? Avatar { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Address { get; set; } = string.Empty;
    }
}
