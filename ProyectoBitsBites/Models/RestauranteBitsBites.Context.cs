﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBitsBites.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestauranteBitsBitesEntities1 : DbContext
    {
        public RestauranteBitsBitesEntities1()
            : base("name=RestauranteBitsBitesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetallesPedido> DetallesPedido { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
