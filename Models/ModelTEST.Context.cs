﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_A56C50_admin759Entities : DbContext
    {
        public DB_A56C50_admin759Entities()
            : base("name=DB_A56C50_admin759Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CIUDAD> CIUDAD { get; set; }
        public virtual DbSet<VENDEDOR> VENDEDOR { get; set; }
    
        public virtual int sp_create_VENDEDOR(string nOMBRE, string aPELLIDO, Nullable<int> nUMERO_IDENTIFICACION, Nullable<int> cODIGO_CIUDAD)
        {
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDOParameter = aPELLIDO != null ?
                new ObjectParameter("APELLIDO", aPELLIDO) :
                new ObjectParameter("APELLIDO", typeof(string));
    
            var nUMERO_IDENTIFICACIONParameter = nUMERO_IDENTIFICACION.HasValue ?
                new ObjectParameter("NUMERO_IDENTIFICACION", nUMERO_IDENTIFICACION) :
                new ObjectParameter("NUMERO_IDENTIFICACION", typeof(int));
    
            var cODIGO_CIUDADParameter = cODIGO_CIUDAD.HasValue ?
                new ObjectParameter("CODIGO_CIUDAD", cODIGO_CIUDAD) :
                new ObjectParameter("CODIGO_CIUDAD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_create_VENDEDOR", nOMBREParameter, aPELLIDOParameter, nUMERO_IDENTIFICACIONParameter, cODIGO_CIUDADParameter);
        }
    
        public virtual int sp_delete_VENDEDOR(Nullable<int> cODIGO)
        {
            var cODIGOParameter = cODIGO.HasValue ?
                new ObjectParameter("CODIGO", cODIGO) :
                new ObjectParameter("CODIGO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_VENDEDOR", cODIGOParameter);
        }
    
        public virtual ObjectResult<sp_selectAll_VENDEDOR_Result> sp_selectAll_VENDEDOR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_selectAll_VENDEDOR_Result>("sp_selectAll_VENDEDOR");
        }
    
        public virtual int sp_update_VENDEDOR(Nullable<int> cODIGO, string nOMBRE, string aPELLIDO, Nullable<int> nUMERO_IDENTIFICACION, Nullable<int> cODIGO_CIUDAD)
        {
            var cODIGOParameter = cODIGO.HasValue ?
                new ObjectParameter("CODIGO", cODIGO) :
                new ObjectParameter("CODIGO", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDOParameter = aPELLIDO != null ?
                new ObjectParameter("APELLIDO", aPELLIDO) :
                new ObjectParameter("APELLIDO", typeof(string));
    
            var nUMERO_IDENTIFICACIONParameter = nUMERO_IDENTIFICACION.HasValue ?
                new ObjectParameter("NUMERO_IDENTIFICACION", nUMERO_IDENTIFICACION) :
                new ObjectParameter("NUMERO_IDENTIFICACION", typeof(int));
    
            var cODIGO_CIUDADParameter = cODIGO_CIUDAD.HasValue ?
                new ObjectParameter("CODIGO_CIUDAD", cODIGO_CIUDAD) :
                new ObjectParameter("CODIGO_CIUDAD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_VENDEDOR", cODIGOParameter, nOMBREParameter, aPELLIDOParameter, nUMERO_IDENTIFICACIONParameter, cODIGO_CIUDADParameter);
        }
    }
}