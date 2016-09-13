using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dental_White.DAL.Entity.Login
{
    public class EntityLoginUsuario
    {
        public int IdLogin { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Perfil { get; set; }
        public string TipoPerfil { get; set; }
    }
}