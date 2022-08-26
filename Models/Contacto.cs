using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using formulario.Models;

namespace formulario.Models
{
    public class Contacto
    {
        
        [Required]
        [Display (Name = "First Name" ,Prompt ="Enter firts name")]
        public string? Name {get;set;}

        [Required]
        [Display (Name = "Last Name" ,Prompt ="Enter last name")]
        public string? LastName {get;set;}

        [Required]
        [Display (Name = "Job title" ,Prompt ="Enter your job title")]
        public string? JobTitle {get;set;}

        [Required]
        [Display(Name ="Years of experience")]
        public string? num {get;set;}


        [Required]
        [DataType(DataType.Date)]
        [Display (Name = "Date" ,Prompt ="mm/dd/yyyy")]
        public DateTime? Fecha {get;set;}



        [Required]
        [Display(Name="Sexo")]
        public string? Sex { get; set; }

        [Display(Name="Highest level of education")]
        public string? radios{get;set;}
        


        
   
    }
}