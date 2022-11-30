using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEFTests
{
    internal class PessoaFisica
    {
        public Int64 Cpf { get; set; }
        [Required][StringLength(45)] public string Nome { get; set; }

        public Int16 Id { get; set; }
    }
}
