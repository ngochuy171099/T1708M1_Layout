using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T1708M1_New.Models
{
    public class Student
    {
        [Key]
        [Display (Name ="Roll Number")]

        public string RollNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Gender Gender1 { get; set; }

        public DateTime BirthDay { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public StudentStatus Status { get; set; }

        public Student()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Gender1 = Gender.Male;
            this.Status = StudentStatus.Activated;
        }

        public enum Gender
        {
            Male= 1,
            FaMale = 0,
            Orther = 2

        }

        public enum StudentStatus
        {
            Activated = 1,
            Disactivated = 2

        }
    }
}
