﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planeacion.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Planeacion.Entidades;
    
    public partial class HtBase2Entities : DbContext
    {
        public HtBase2Entities()
            : base("name=HtBase2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HtDetalleTotales> HtDetalleTotales { get; set; }
        public virtual DbSet<HtGenero> HtGenero { get; set; }
        public virtual DbSet<HtGrupoOcupacional> HtGrupoOcupacional { get; set; }
        public virtual DbSet<HtRubro> HtRubro { get; set; }
        public virtual DbSet<HtTipoContrato> HtTipoContrato { get; set; }
    }
}
