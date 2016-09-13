using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.CoberturaPlanoOdontologico;
using Dental_White.DAL.Entity.TipoPlanoOdontologico;

namespace Dental_White.DAL.Entity.PlanoOdontologico
{
    public class EntityPlanoOdontologico
    {
        public int IdPlano { get; set; }
        public long CodigoIdentificacao { get; set; }
        public long CodigoPlanoANS { get; set; }
        public string NomePlano { get; set; }
        public int Produto { get; set; }
        public string Empresa { get; set; }
        public bool CoParticipacao { get; set; }
        public bool Carencia { get; set; }
        public int TempoCarenciaDias { get; set; }
        public string Cobertura { get; set; }
        public string TipoPlanoOdontologico { get; set; }
    }
}