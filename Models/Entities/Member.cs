using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Entities
{
    internal class Member : User
    {
        private string? email;
        private string? phoneNumber;
        private string? cep;
        private DateTime membershipDate;

        [Required]
        [EmailAddress]
        public string Email { get => email!; set => email = value; }

        [Phone]
        public string PhoneNumber { get => phoneNumber!; set => phoneNumber = value; }

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato XXXXX-XXX.")]
        public string CEP { get => cep!; set => cep = value; }

        public DateTime MembershipDate { get => membershipDate; set => membershipDate = value; }
    }
}
