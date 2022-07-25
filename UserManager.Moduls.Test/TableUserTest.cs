using System.Collections.Generic;
using UserManager.Models.Table;
using Xunit;
using UserManager.Models.Item;
using UserManager.Models.TableBase;
namespace UserManager.Moduls.Test
{
    public class TableUserTest
    {
        private List<User> _expected;
        private TableUser _tableUser;
        public TableUserTest()
        {
            _tableUser = new TableUser();
            _expected = new List<User>
            {
                new User()
                {
                    Id = 1,
                    FirstName = "anonim",
                    LastName ="anonimus",
                    Email = "add@admin.ru",
                    PhotoUrl = "url"

                },
                new User()
                {
                    Id = 2,
                    FirstName = "user",
                    LastName ="anonimus",
                    Email = "user@admin.ru",
                    PhotoUrl = "url"
                }
            };
        }

        [Fact]
        public void GetTable_Test()
        {            
            var actual = _tableUser.GetTable();
            Assert.Equal(_expected, actual);
        }

        [Fact]
        public void AddToTableTest()
        {
            var user = new User
            {
                FirstName = "user",
                LastName = "ananim",
                Email = "user@admin.ru",
                PhotoUrl= "url"
            };
            _expected.Add(user);
            _tableUser.AddToTable(user);
            var actual = _tableUser.GetTable();
            Assert.Equal(_expected, actual);
        }
    }
}