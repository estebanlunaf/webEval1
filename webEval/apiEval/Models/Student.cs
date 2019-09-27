
using System.ComponentModel.DataAnnotations;
namespace apiEval.Models
{
    public enum TypeStudent
    {
        name,
        sex,
        birthday
    }
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeStudent Type { get; set; }
        [Required]
        [Display(Description ="Student")]
        public string StudentValue { get; set; }
    }
}