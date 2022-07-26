﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models.Item
{
    public class Role : IEquatable<Role>
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public bool Equals(Role? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Id == other.Id && Name == other.Name;
        }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Role)obj);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }


    }
}
