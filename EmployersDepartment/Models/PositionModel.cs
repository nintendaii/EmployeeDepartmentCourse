using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployersDepartment.Models
{
    public class PositionModel
    {
        [Display(Name = "Position Title")]
        [Required(ErrorMessage = "This field is required!")]
        public string PositionName { get; set; }
        [Display(Name = "Salary")]
        [Required(ErrorMessage = "This field is required!")]
        public double PositionSalary { get; set; }
    }
}