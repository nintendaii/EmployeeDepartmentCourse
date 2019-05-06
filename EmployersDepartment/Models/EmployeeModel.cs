using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployersDepartment.Models
{
    public class EmployeeModel
    {
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="This field is required!")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "This field is required!")]
        public string LastName { get; set; }
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Speciality")]
        [Required(ErrorMessage = "This field is required!")]
        public int SpecialityId { get; set; }

        [Display(Name = "Position")]
        [Required(ErrorMessage = "This field is required!")]
        public int PositionId { get; set; }

    }
}