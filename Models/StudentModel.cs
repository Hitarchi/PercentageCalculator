using System.ComponentModel.DataAnnotations;

namespace StudentMarks.Models
{
    public class StudentModel
    {
        [Required]
        public string name { get; set; }

        [Required]
        [Range(0, 100)]
        public int maths { get; set; }

        [Required]
        [Range(0, 100)]
        public int physics { get; set; }

        [Required]
        [Range(0, 100)]
        public int chemistry { get; set; }

        [Required]
        [Range(0, 100)]
        public int hindi { get; set; }

        [Required]
        [Range(0, 100)]
        public int english { get; set; }

        [Key]
        public int id { get; set; }
    }
}
