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
    public class BugRepo
    {
        public void delete(int id)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("delete from Bug where id=@id", new { id });
        }

        public void add(int id, string denumire, string descriere)
        {
            IDbConnection connection = DBUtils.getConnection();
            connection.Execute("insert into Bug (id, denumire, descriere) values (@id, @denumire, @descriere)", new { id, denumire, descriere });
        }

        public IEnumerable<Bug> findAll()
        {
            IDbConnection connection = DBUtils.getConnection();
            IList<Bug> bugList = new List<Bug>();
            bugList = connection.Query<Bug>("SELECT id, denumire, descriere from Bug").ToList();
            return bugList;
        }

        public Bug findOne(int id)
        {
            IDbConnection connection = DBUtils.getConnection();
            Bug result = connection.Query<Bug>(
                    @"SELECT id, denumire, descriere
                    FROM Bug
                    WHERE id=@id", new { id }).FirstOrDefault();
            return result;
        }
    }
}
