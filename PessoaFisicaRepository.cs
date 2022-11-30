using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEFTests
{
    internal class PessoaFisicaRepository
    {
        public static void Save(PessoaFisica pessoa)
        {
            using (Repository repository = new Repository(Repository.GetConnection(), false))
            {
                repository.Pessoas.Add(pessoa);
                repository.SaveChanges();
            }
        }
    }
}
