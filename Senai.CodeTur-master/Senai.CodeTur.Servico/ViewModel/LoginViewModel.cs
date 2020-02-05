using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Senai.CodeTur.Servico.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string Senha { get; set; }
    }
}
