using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models.Item
{
    public class Account: IEquatable<Account>
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Account? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Id == other.Id &&
                Login == other.Login &&
                Password == other.Password &&
                RoleId == other.RoleId &&
                IsActive == other.IsActive;               
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Login, Password, RoleId, IsActive);
        }

        
    }
}
