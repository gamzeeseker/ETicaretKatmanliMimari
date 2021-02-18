using ETicaret.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BLL
{
    public class CreateDb
    {
        public CreateDb()
        {
            DataContext context = new DataContext();
            context.Database.CreateIfNotExists();
        }
    }
}
