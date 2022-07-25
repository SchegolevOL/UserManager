using System.Collections.Generic;
using UserManager.Models.Table;
using Xunit;
using UserManager.Models.Item;
using UserManager.Models.TableBase;
namespace UserManager.Moduls.Test
{
    public class TableUserTest
    {

        [Fact]
        public void GetTable_Test()
        {
            var expected = new List<User>
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
            var tableUser = new TableUser();
            var actual = tableUser.GetTable();
            Assert.Equal(expected, actual);
        }
    }
}