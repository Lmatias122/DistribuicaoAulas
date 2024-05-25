using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuição_de_aulas.dbConnection
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DbConnection()
        {
            var connectionString = "Server=localhost;Port=5432;Database=GerenciamentoSalas;User Id=postgres;Password=1234;";

            Connection = new NpgsqlConnection(connectionString);
            Connection.Open();

        }

        public void Dispose()
        {
           Connection.Dispose();
        }
    }
}
