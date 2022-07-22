using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models.TableBase
{
    internal interface IAddToTable<T>
    {
        public void AddToTable(T obj);
    }
}
