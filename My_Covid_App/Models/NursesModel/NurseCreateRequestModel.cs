﻿using System.ComponentModel.DataAnnotations;

namespace My_Covid_App.Models.NursesModel
{
    public class NurseCreateRequestModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Identification { get; set; }
        [Required]
        public int EmployeeNumber { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
