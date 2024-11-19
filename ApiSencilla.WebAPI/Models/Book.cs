using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSencilla.WebAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Title")]
        [Required(ErrorMessage = "El titulo es requerido")]
        public string Title { get; set; }
        [Display(Name = "Author")]
        [Required(ErrorMessage = "El Author es requerido")]
        public string Author { get; set; }
        [Display(Name = "Pages")]
        public int? Pages { get; set; }
    }
}
