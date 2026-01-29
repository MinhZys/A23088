using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_image.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Column("Id")]
        [Required]
        [StringLength(20)]
        public string Id { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Fullname { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        // bit (true/false). Bạn có thể hiểu: true=Male, false=Female (tùy bạn quy ước)
        [Required]
        public bool Gender { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Address { get; set; } = string.Empty;

        // ====== THÊM IMAGE ======
        // Lưu đường dẫn/filename ảnh (vd: "uploads/students/C12345.jpg")
        [StringLength(255)]
        public string? ImagePath { get; set; }
    }
}
