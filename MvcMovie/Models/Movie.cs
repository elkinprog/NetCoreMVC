using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }



        [DataType(DataType.Text)]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Titulo")]
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Title { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "La fecha es requerida")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



        [StringLength(30)]
        [Display(Name = "Genero")]
        [Required(ErrorMessage = "El genero es requerido")]
        public string Genre { get; set; }


        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio es requerido")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [StringLength(5)]
        [Display(Name = "Clasificación")]
        [Required(ErrorMessage = "La clasificacion es requerida")]
        public string Rating { get; set; }
    }
}


