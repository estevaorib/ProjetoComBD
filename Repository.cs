using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEFTests
{
    internal class Repository : DbContext
    {
        private static MySqlConnection _dbConnection;

        public DbSet<PessoaFisica> Pessoas { get; set; }

        public Repository() : base()
        {
            Database.CreateIfNotExists();
        }

        public Repository(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
            Database.CreateIfNotExists();
        }

        public static MySqlConnection GetConnection()
        {
            if(_dbConnection == null)
            {
                String strConnection;
                strConnection = ConfigurationManager.ConnectionStrings["ProgVisConnectionString"].ConnectionString;
                _dbConnection = new MySqlConnection(strConnection);
            }
            return _dbConnection;
        }
    }
}
