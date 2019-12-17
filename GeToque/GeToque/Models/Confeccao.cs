using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeToque.Models
{
    public class Confeccao
    {

        public int ConfeccaoId { get; set; }

        [Display(Name = "Nome da Roupa")]
        public int RoupaId { get; set; }

        [Required(ErrorMessage = "Informe a roupa", AllowEmptyStrings = false)]
        [Display(Name = "Nome da Roupa")]
        public Roupa Roupa { get; set; }

        [Required(ErrorMessage = "Informe um horário", AllowEmptyStrings = false)]
        [Display(Name = "Horário")]
        public DateTime Horario { get; set; }

    }
}
