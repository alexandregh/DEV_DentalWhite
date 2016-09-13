using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.PlanoOdontologico;
using Dental_White.DAL.Entity.GrauParentesco;

namespace Dental_White.DAL.Entity.Dependente
{
    public class EntityDependente
    {
        public int IdDependente { get; set; }
        public long CPF { get; set; }
        public EntityRG RG { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Login { get; set; }
        public string UrlFoto { get; set; }
        public EntityTelefone Telefone { get; set; }
        public EnumSexo Sexo { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
        public EntityEndereco Endereco { get; set; }
        public EntityPlanoOdontologico PlanoOdontologico { get; set; }
        public EntityGrauParentesco GrauParentesco { get; set; }
        public int IdPaciente { get; set; }
    }
}