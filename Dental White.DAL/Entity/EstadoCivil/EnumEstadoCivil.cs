using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Dental_White.DAL.Entity.EstadoCivil
{
    public enum EnumEstadoCivil
    {
        [DescriptionAttribute("Solteiro")]
        Solteiro = 1,
        [DescriptionAttribute("Casado")]
        Casado = 2,
        [DescriptionAttribute("Divorciado")]
        Divorciado = 3,
        [DescriptionAttribute("Viúvo")]
        Viuvo = 4
    }
}