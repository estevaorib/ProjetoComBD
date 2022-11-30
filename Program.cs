using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEFTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica p1 = new PessoaFisica();
            p1.Cpf = 55221745891;
            p1.Nome = "Ítalo";
            p1.Id = 2;

            PessoaFisicaRepository.Save(p1);
        }
    }
}