using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Repositories;

namespace GerenciamentoClubesEsportivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberController controller = new MemberController(new MemberRepository());


        }
    }
}