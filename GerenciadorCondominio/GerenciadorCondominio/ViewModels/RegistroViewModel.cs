﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominio.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40,ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Telefone { get; set; }        
        public string Foto { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage ="Use menos caracteres")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme senha")]
        [Compare("Senha", ErrorMessage = "Senha não coincide")]
        public string SenhaConfirmada { get; set; }
    }
}
