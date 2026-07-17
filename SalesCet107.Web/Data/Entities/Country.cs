using System.ComponentModel.DataAnnotations;

namespace SalesCet107.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        //DataAnnotations
        [Display(Name="Pais")]
        [MaxLength(50, ErrorMessage ="O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Name { get; set; }
    }
}
