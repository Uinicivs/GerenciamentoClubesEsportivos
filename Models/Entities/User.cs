using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Entities
{
    public abstract class User
    {
        private int id;
        private string? name;
        private string? cpf;

        public int Id { get => id; set => id = value; }

        [Required]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        public string Name { get => name!; set => name = value; }

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato XXX.XXX.XXX-XX.")]
        public string CPF { get => cpf!; set => cpf = value; }
    }
}
