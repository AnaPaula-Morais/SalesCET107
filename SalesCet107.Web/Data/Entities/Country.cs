using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesCet107.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        //DataAnnotations
        [Display(Name = "Country")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Name { get; set; }

        public ICollection<State> States { get; set; }

        public int StatesNumber => States == null ? 0 : States.Count;

        public int GetStatesNumber()
        {
            return States == null ? 0 : States.Count;
        }

    }
}
