using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BLL.Abstract
{
    interface IRepository<T>
    {
        List<T> List();
        void Insert(T deger);
        void Delete(int id);
        void Update(T deger);
        void Save();
        T FindGetById(int id);
    }
}
