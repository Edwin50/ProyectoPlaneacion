//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planeacion.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class HtGrupoOcupacional
    {
        public HtGrupoOcupacional()
        {
            this.HtDetalleTotales = new HashSet<HtDetalleTotales>();
        }
    
        public int HtIdGrupoOcupacional { get; set; }
        public string HtDescripGrupoOcupacional { get; set; }
    
        public virtual ICollection<HtDetalleTotales> HtDetalleTotales { get; set; }
    }
}
