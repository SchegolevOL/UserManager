using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sqlite;//Sqlite

namespace UserManager.Models.TableBase
{
    public abstract class Db
    {
        private const string Conn = @"Data Source=users.db;";
        protected readonly SqliteCommand _comand;
        protected readonly SqliteConnection _db;
        protected SqliteDataReader _result;
        protected Db()
        {
            _db = new SqliteConnection(Conn);
            _comand = new SqliteCommand
            {
                Connection = _db
            };
        }
        protected void Query(string sql)
        {
            _db.Open();
            _comand.CommandText=sql;
            _result = _comand.ExecuteReader();
        }
        protected void NonQuery(string sql)
        {
            _db.Open();
            _comand.ExecuteNonQuery();
            _db.Close();
        }

    }
}
