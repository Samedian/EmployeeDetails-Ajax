using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class Students
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string studentName { get; set; }


        [Required]
        public string studentAddress { get; set; }
    }
}