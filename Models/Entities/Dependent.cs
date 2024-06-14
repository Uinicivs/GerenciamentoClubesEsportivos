using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoClubesEsportivos.Models.Entities
{
    public class Dependent : User
    {
        private string Kindship {  get; set; }
        private int MemberID { get; set; }
    }
}
