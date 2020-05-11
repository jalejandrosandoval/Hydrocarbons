using System;
using System.ComponentModel.DataAnnotations;

namespace Bussiness_Logic.Models
{
    [Serializable]
    public class Line_Hydrocarbon
    {
        [Key]
        public int Id_LineHydrocarbon { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name_Line { get; set; }

        [Required]
        
        public decimal Length_Line { get; set; }

        [Required]
        public decimal Diameter_Line { get; set; }


        [Required]
        [DataType(DataType.Date)]

        public DateTime InstalationDate { get; set; }

    }
}
