using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilfredo01.NEGOCIO;
namespace Wilfredo01.DOMINIO
{
    class LOG_IN
    {
        private String usuario;
        private String password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
    }
}
