using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Model
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int userId { get; set; }
        public string userName { get; set; }
        public string userPhone { get; set; }
        public string userAdress { get; set; }
        public int userProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
