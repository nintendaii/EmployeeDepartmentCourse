using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployersDepartment.Models
{
    public class SpecialityModel
    {
        [Display(Name = "Speciality Name")]
        [Required(ErrorMessage = "This field is required!")]
        public string SpecialityName { get; set; }
        [Display(Name = "Education")]
        [Required(ErrorMessage = "This field is required!")]
        public string SpecialityEducation { get; set; }
    }
}