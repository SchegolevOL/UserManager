using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sqlite;//Sqlite

namespace UserManager.Models
{
    public class UsersDb
    {
        
        public List<Role> TableRoles { get; set; }
        public List<Account> TableAccount { get; set; }
        public List<User> TableUser { get; set; }

        public UsersDb()
        {
            TableRoles = GetTableRole();
            TableAccount = GetTableAccount();
            TableUser = GetTableUser();
        }

        
        public List<Role> GetTableRole()
        {
            var list = new List<Role>();
            var sql = "SELECT * FROM table_role";
            SqliteConnection db;
            var result = Query(sql, out db);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    list.Add(new Role
                    {
                        Id = result.GetInt32("role_id"),
                        Name = result.GetString("role_name"),
                    });
                }
            }
            db.Close();
            return list;
        }
        public List<Account> GetTableAccount()
        {
            var list = new List<Account>();
            var sql = "SELECT * FROM table_account";
            
            var result = Query(sql, out var db);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    list.Add(new Account
                    {
                        Id = result.GetInt32("account_id"),
                        Login = result.GetString("account_login"),
                        Password = result.GetString("account_password"),
                        RoleId = result.GetInt32("role_id"),
                        IsActive = result.GetBoolean("is_active")
                    });
                }
            }
            db.Close();
            return list;
        }
        public List<User> GetTableUser()
        {
            var list = new List<User>();
            var sql = "SELECT * FROM table_user";
            var result = Query(sql, out var db);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    list.Add(new User
                    {
                        Id = result.GetInt32("user_id"),
                        FirstName = result.GetString("first_name"),
                        LastName = result.GetString("last_name"),
                        Email = result.GetString("email"),
                        PhotoUrl = result.GetString("photo")
                    });
                }
            }
            db.Close();
            return list;
        }
        public void AddToTableAccount(Account account)
        {
            var sql = $"INSERT INTO table_account (login, password, role_id) VALUES ('{account.Login}', '{account.Password}', {account.RoleId})";
            NonQuery(sql);
        }
        public void AddToTableUser(User user)
        {
            var sql = $"INSERT INTO table_account (first_name, last_name, email, photo) VALUES ('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.PhotoUrl}')";
            NonQuery(sql);
        }
    }
}
