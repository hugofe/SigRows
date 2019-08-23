using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigRows.Models
{
    public class User
    {
        public int usuario_Id { get; set; }
        public string Name { get; set; }
        public string Senha { get; set; }
        public bool Key { get; set; }
    }
}
