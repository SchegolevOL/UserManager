using System.Collections.Generic;
using UserManager.Models.Table;
using Xunit;
using UserManager.Models.Item;
using UserManager.Models.TableBase;
namespace UserManager.Moduls.Test
{
    public class TableRoleTest
    {

        [Fact]
        public void GetTable_Test()
        {
            var expected = new List<Models.Item.Role>
            {
                new Role()
                {
                    Name = "admin",
                    Id = 1           
                },
                new Role()
                {
                    Id = 2,
                    Name ="user"
                }
            };
            var tableRole = new TableRole();
            var actual = tableRole.GetTable();
            Assert.Equal(expected, actual);
        }
    }
}