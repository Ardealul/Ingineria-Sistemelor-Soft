using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrmarireBuguri.domain;

namespace UrmarireBuguri.repo
{
    public class VerificatorRepo
    {
        public void delete(string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("delete from Verificator where username=@username and password=@password", new { username, password });
        }

        public void add(int id, string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("insert into Verificator (id, username, password) values (@id, @username, @password)", new { id, username, password });
        }

        public Verificator findOne(string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            Verificator result = connection.Query<Verificator>(
                    @"SELECT id, username, password
                    FROM Verificator
                    WHERE username = @username and password = @password", new { username, password }).FirstOrDefault();
            return result;
        }

        public IEnumerable<Verificator> findAll()
        {
            IDbConnection connection = DBUtils.getConnection();
            IList<Verificator> verificatorList = new List<Verificator>();
            verificatorList = connection.Query<Verificator>("SELECT id, username, password from Verificator").ToList();
            return verificatorList;
        }

        public void update(int id, string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("update Verificator set username=@username, password=@password where id=@id", new { username, password, id });
        }
    }
}
