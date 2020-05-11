using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APP_WEB.Models
{
    
    public class LineHydrocarbonsModelView
    {

        [Key]
        public int Id_LineHydrocarbon { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "* Nombres de la Línea Requerido...")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Nombre de la Línea", Description = "Nombre de la Línea...", Prompt = "Nombre de la Línea...")]
        public string Name_Line { get; set; }

        [Required(ErrorMessage = "* Longitud de la Línea Requerido...")]
        [Display(Name = "Longitud de la Línea", Description = "Longitud de la Línea...", Prompt = "Longitud de la Línea...")]
        public decimal Length_Line { get; set; }

        [Required(ErrorMessage = "* Diámetro de la Línea Requerido...")]
        [Display(Name = "Diámetro de la Línea", Description = "Diámetro de la Línea...", Prompt = "Diámetro de la Línea...")]
        public decimal Diameter_Line { get; set; }


        [Required(ErrorMessage = "* Fecha de Instalación Requerida...")]
        [DataType(DataType.Date)]

        public DateTime InstalationDate { get; set; }

    }
}
