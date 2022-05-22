using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class Employee
    {
        
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be minium 3 characters and of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18, 99, ErrorMessage = "Age should be above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}