using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dental_White.DAL.Entity.RG
{
    public class EntityRG
    {
        public int IdRG { get; set; }
        public Int64 Numero { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime DataEmissao { get; set; }
    }
}