using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using UserManager.Models.TableBase;
using UserManager.Models.Item;

namespace UserManager.Models.Table
{
    public class TableRole : Db, IGetTable<Role>
    {
        public TableRole() : base()
        {

        }
        public List<Role> GetTable()
        {
            var list = new List<Role>();
            var sql = "SELECT * FROM table_role";
            Query(sql);
            if (_result.HasRows)
            {
                while (_result.Read())
                {
                    list.Add(new Role
                    {
                        Id = _result.GetInt32("role_id"),
                        Name = _result.GetString("role_name"),
                    });
                }
            }
            _db.Close();
            return list;
        }
    }
}
