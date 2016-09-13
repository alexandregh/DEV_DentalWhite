using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.Logradouro;

namespace Dental_White.DAL.Entity.Endereco
{
    public class EntityEndereco
    {
        public int IdEndereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public Int32 CEP { get; set; }
        public EntityLogradouro Logradouro { get; set; }
    }
}