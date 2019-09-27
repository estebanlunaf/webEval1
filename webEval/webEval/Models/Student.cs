using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webEval.Models
{
    using System.ComponentModel.DataAnnotations;

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
        [Display(Description = "Student")]
        public string StudentValue { get; set; }
    }
}