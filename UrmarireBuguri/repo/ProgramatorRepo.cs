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
    public class ProgramatorRepo
    {
        public void delete(string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("delete from Programator where username=@username and password=@password", new { username, password });
        }

        public void add(int id, string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("insert into Programator (id, username, password) values (@id, @username, @password)", new { id, username, password });
        }

        public Programator findOne(string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            Programator result = connection.Query<Programator>(
                    @"SELECT id, username, password
                    FROM Programator
                    WHERE username = @username and password = @password", new { username, password }).FirstOrDefault();
            return result;
        }

        public IEnumerable<Programator> findAll()
        {
            IDbConnection connection = DBUtils.getConnection();
            IList<Programator> programatorList = new List<Programator>();
            programatorList = connection.Query<Programator>("SELECT id, username, password from Programator").ToList();
            return programatorList;
        }

        public void update(int id, string username, string password)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("update Programator set username=@username, password=@password where id=@id", new { username, password, id });
        }
    }
}
