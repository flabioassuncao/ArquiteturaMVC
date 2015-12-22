using Dapper;
using FA.ArquiteturaMVC.Domain.Entities;
using FA.ArquiteturaMVC.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.ArquiteturaMVC.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        //Exemplo usando Dapper
        public override Cliente ObterPorIdReadOnly(Guid id)
        {
            var sql = @"SELECT * FROM Clientes c " +
                        "INNER JOIN Enderecos e "+
                        "ON c.ClienteId = e.ClienteId "+
                       "WHERE c.ClienteId = @sid";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();

                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) => 
                    {
                        c.Enderecos.Add(e);
                        return c;
                    }, new {sid = id }, splitOn:"ClienteId, EnderecoId ");

                return cliente.FirstOrDefault();
            }
        }

        public override IEnumerable<Cliente> ObterTodos()
        {
            var sql = @"SELECT * FROM Clientes c ";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();

                var cliente = cn.Query<Cliente>(sql);

                return cliente;
            }
        }
    }
}
