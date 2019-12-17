using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeToque.Models
{
    public class Roupa{

        public enum Tipo { Camisa, Tenis, meia, calça, oculos}
        public int RoupaId { get; set; }

        [Required(ErrorMessage = "Informe o tipo da roupa")]
        [Display(Name = "Tipo da roupa")]
        public Tipo Tipos { get; set; }

        [Required(ErrorMessage = "Informe a quantidade disponível")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
     
    }
}
