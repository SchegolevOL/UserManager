using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Models.TableBase
{
    public interface IGetTable<T>
    {
        public List<T> GetTable();

    }
}
