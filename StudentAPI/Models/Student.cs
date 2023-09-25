using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Name { get; set; } = "";

        public string ContactNumber { get; set; }
        public int Age { get; set; }
    }
}
