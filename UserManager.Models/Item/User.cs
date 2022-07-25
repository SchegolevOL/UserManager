using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models.Item
{
    public class User: IEquatable<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   FirstName == user.FirstName &&
                   LastName == user.LastName &&
                   Email == user.Email &&
                   PhotoUrl == user.PhotoUrl;
        }

        bool IEquatable<User>.Equals(User? other)
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
                FirstName == other.FirstName &&
                LastName == other.LastName &&
                Email == other.Email && 
                PhotoUrl == other.PhotoUrl;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, Email, PhotoUrl);
        }

       
    }
}
