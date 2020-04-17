using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dojoSurveyWithValidations.Models
{

    public class User
    {
        [Required]
        [MinLength(2)]
        public string Name {get; set;}

        [Required]
        public string Location {get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(10)]
        public string Language {get; set; }

        [MaxLength(20)]
        public string Comment {get; set;} 
    }
}