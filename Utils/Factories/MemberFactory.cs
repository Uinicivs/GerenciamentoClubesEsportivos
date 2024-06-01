using GerenciamentoClubesEsportivos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Utils.Factories
{
    internal static class MemberFactory
    {
        public static Member Build(string name, string cpf, string email, string phoneNumber, string cep, DateTime membershipDate)
        {
            return new Member
            {
                Name = name.ToUpper(),
                CPF = cpf,
                Email = email,
                PhoneNumber = phoneNumber,
                CEP = cep,
                MembershipDate = membershipDate,
            };
        }
    }
}
