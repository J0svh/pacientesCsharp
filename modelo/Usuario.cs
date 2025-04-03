using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacientesCsharp.modelo
{
    class Usuario
    {
        private int id;
        private String nombrecompleto, user, pass;

        public Usuario(string nombrecompleto, string user, string pass)
        {
            this.Nombrecompleto = nombrecompleto;
            this.User = user;
            this.Pass = pass;
        }

        public Usuario(int id, string nombrecompleto, string user, string pass)
        {
            this.Id = id;
            this.Nombrecompleto = nombrecompleto;
            this.User = user;
            this.Pass = pass;
        }

        public int Id { get => id; set => id = value; }
        public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
