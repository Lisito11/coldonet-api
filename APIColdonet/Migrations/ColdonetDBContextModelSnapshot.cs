﻿// <auto-generated />
using System;
using APIColdonet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

namespace APIColdonet.Migrations
{
    [DbContext(typeof(ColdonetDBContext))]
    partial class ColdonetDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("APIColdonet.Entities.Categorium", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CodigoCategoria")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DescripcionCategoria")
                        .HasColumnType("text");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdCategoria")
                        .HasName("PK__Categori__A3C02A1045E3740B");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("APIColdonet.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("Abono")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("DeudaTotal")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("Estatus")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdCliente")
                        .HasName("PK__Cliente__D59466429DAF6FDD");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("APIColdonet.Entities.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EstatusCompra")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCompra")
                        .HasColumnType("date");

                    b.Property<int?>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompra")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<decimal?>("PorPagar")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("TotalCompra")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdCompra")
                        .HasName("PK__Compra__0A5CDB5C352E4AF5");

                    b.HasIndex("IdProveedor");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("APIColdonet.Entities.DetalleCompra", b =>
                {
                    b.Property<int>("IdDetalleCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadProductoDc")
                        .HasColumnType("int")
                        .HasColumnName("CantidadProductoDC");

                    b.Property<decimal?>("CostoUnidad")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("IdCompra")
                        .HasColumnType("int");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdDetalleCompra")
                        .HasName("PK__DetalleC__E046CCBB74185F11");

                    b.HasIndex("IdCompra");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdUsuario");

                    b.ToTable("DetalleCompra");
                });

            modelBuilder.Entity("APIColdonet.Entities.DetalleVentum", b =>
                {
                    b.Property<int>("IdDetalleVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CantidadProductoDv")
                        .HasColumnType("int")
                        .HasColumnName("CantidadProductoDV");

                    b.Property<decimal?>("CostoProductoDv")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("CostoProductoDV");

                    b.Property<int?>("EstatusDetalleVenta")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDetalleVenta")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("IdVenta")
                        .HasColumnType("int");

                    b.Property<decimal?>("PrecioProductoDv")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("PrecioProductoDV");

                    b.HasKey("IdDetalleVenta")
                        .HasName("PK__DetalleV__AAA5CEC284321B5D");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("IdVenta");

                    b.ToTable("DetalleVenta");
                });

            modelBuilder.Entity("APIColdonet.Entities.DeudaCliente", b =>
                {
                    b.Property<int>("IdDeudaCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("ClienteDebe")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("EstatusDeudaCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdDetalleVenta")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("ProductoCliente")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdDeudaCliente")
                        .HasName("PK__DeudaCli__51C9453FFDB3D8A8");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdDetalleVenta");

                    b.HasIndex("IdUsuario");

                    b.ToTable("DeudaCliente");
                });

            modelBuilder.Entity("APIColdonet.Entities.Direccion", b =>
                {
                    b.Property<int>("IdDireccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Calle")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Ciudad")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Sector")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<Geometry>("Ubicacion")
                        .HasColumnType("geography");

                    b.HasKey("IdDireccion")
                        .HasName("PK__Direccio__1F8E0C761AC67455");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("APIColdonet.Entities.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CantidadProducto")
                        .HasColumnType("int");

                    b.Property<string>("CodigoProducto")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal?>("CostoProducto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("EstatusProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdSubCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("Pesado")
                        .HasColumnType("int");

                    b.Property<decimal?>("PrecioProdcuto")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdProducto")
                        .HasName("PK__Producto__098892105010AF9D");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdSubCategoria");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("APIColdonet.Entities.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IdDireccion")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TelefonoProveedor")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdProveedor")
                        .HasName("PK__Proveedo__E8B631AF2197D2E2");

                    b.HasIndex("IdDireccion");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("APIColdonet.Entities.SubCategorium", b =>
                {
                    b.Property<int>("IdSubCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CodigoSubCategoria")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DescripcionSubCategoria")
                        .HasColumnType("text");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NombreSubCategoria")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdSubCategoria")
                        .HasName("PK__SubCateg__0A1EFFE50FCDCA62");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdUsuario");

                    b.ToTable("SubCategoria");
                });

            modelBuilder.Entity("APIColdonet.Entities.SubUsuario", b =>
                {
                    b.Property<int>("IdSubUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido1")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Celular")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<int?>("EstatusSubUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdSubUsuario")
                        .HasName("PK__SubUsuar__268A5A4499303A5F");

                    b.HasIndex("IdUsuario");

                    b.ToTable("SubUsuario");
                });

            modelBuilder.Entity("APIColdonet.Entities.TipoComercio", b =>
                {
                    b.Property<int>("IdTipoComercio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("IdTipoComercio")
                        .HasName("PK__TipoCome__6D8B1B6EF81A8DB1");

                    b.ToTable("TipoComercio");
                });

            modelBuilder.Entity("APIColdonet.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)");

                    b.Property<int?>("Delivery")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<int?>("EstatusUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<int?>("IdDireccion")
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoComercio")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF97130DF27C");

                    b.HasIndex("IdDireccion");

                    b.HasIndex("IdTipoComercio");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("APIColdonet.Entities.Ventum", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("CostoVenta")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("EstatusVenta")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaVenta")
                        .HasColumnType("date");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalVenta")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdVenta")
                        .HasName("PK__Venta__BC1240BDB483FFE9");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("APIColdonet.Entities.Categorium", b =>
                {
                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Categoria")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_categoria_usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Cliente", b =>
                {
                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_cliente_usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Compra", b =>
                {
                    b.HasOne("APIColdonet.Entities.Proveedor", "IdProveedorNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdProveedor")
                        .HasConstraintName("fk_compra_proveedor");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_compra_usuario");

                    b.Navigation("IdProveedorNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.DetalleCompra", b =>
                {
                    b.HasOne("APIColdonet.Entities.Compra", "IdCompraNavigation")
                        .WithMany("DetalleCompras")
                        .HasForeignKey("IdCompra")
                        .HasConstraintName("fk_detallecompra_compra");

                    b.HasOne("APIColdonet.Entities.Producto", "IdProductoNavigation")
                        .WithMany("DetalleCompras")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("fk_detallecompra_producto");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("DetalleCompras")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_detallecompra_usuario");

                    b.Navigation("IdCompraNavigation");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.DetalleVentum", b =>
                {
                    b.HasOne("APIColdonet.Entities.Cliente", "IdClienteNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("fk_detalleventa_cliente");

                    b.HasOne("APIColdonet.Entities.Producto", "IdProductoNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdProducto")
                        .HasConstraintName("fk_detalleventa_producto");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_detalleventa_usuario");

                    b.HasOne("APIColdonet.Entities.Ventum", "IdVentaNavigation")
                        .WithMany("DetalleVenta")
                        .HasForeignKey("IdVenta")
                        .HasConstraintName("fk_detalleventa_venta");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdProductoNavigation");

                    b.Navigation("IdUsuarioNavigation");

                    b.Navigation("IdVentaNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.DeudaCliente", b =>
                {
                    b.HasOne("APIColdonet.Entities.Cliente", "IdClienteNavigation")
                        .WithMany("DeudaClientes")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("fk_deudacliente_cliente");

                    b.HasOne("APIColdonet.Entities.DetalleVentum", "IdDetalleVentaNavigation")
                        .WithMany("DeudaClientes")
                        .HasForeignKey("IdDetalleVenta")
                        .HasConstraintName("fk_deudacliente_detalleventa");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("DeudaClientes")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_deudacliente_usuario");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdDetalleVentaNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Producto", b =>
                {
                    b.HasOne("APIColdonet.Entities.Categorium", "IdCategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("fk_categoria_producto");

                    b.HasOne("APIColdonet.Entities.SubCategorium", "IdSubCategoriaNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdSubCategoria")
                        .HasConstraintName("fk_subcategoria_producto");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_producto_usuario");

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdSubCategoriaNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Proveedor", b =>
                {
                    b.HasOne("APIColdonet.Entities.Direccion", "IdDireccionNavigation")
                        .WithMany("Proveedors")
                        .HasForeignKey("IdDireccion")
                        .HasConstraintName("fk_proveedor_direccion");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Proveedors")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_proveedor_usuario");

                    b.Navigation("IdDireccionNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.SubCategorium", b =>
                {
                    b.HasOne("APIColdonet.Entities.Categorium", "IdCategoriaNavigation")
                        .WithMany("SubCategoria")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("fk_subcategoria_categoria");

                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("SubCategoria")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_subcategoria_usuario");

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.SubUsuario", b =>
                {
                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("SubUsuarios")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_subusuario_usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Usuario", b =>
                {
                    b.HasOne("APIColdonet.Entities.Direccion", "IdDireccionNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdDireccion")
                        .HasConstraintName("fk_usuario_direccion");

                    b.HasOne("APIColdonet.Entities.TipoComercio", "IdTipoComercioNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTipoComercio")
                        .HasConstraintName("fk_usuario_tipocomercio");

                    b.Navigation("IdDireccionNavigation");

                    b.Navigation("IdTipoComercioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Ventum", b =>
                {
                    b.HasOne("APIColdonet.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Venta")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("fk_venta_usuario");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("APIColdonet.Entities.Categorium", b =>
                {
                    b.Navigation("Productos");

                    b.Navigation("SubCategoria");
                });

            modelBuilder.Entity("APIColdonet.Entities.Cliente", b =>
                {
                    b.Navigation("DetalleVenta");

                    b.Navigation("DeudaClientes");
                });

            modelBuilder.Entity("APIColdonet.Entities.Compra", b =>
                {
                    b.Navigation("DetalleCompras");
                });

            modelBuilder.Entity("APIColdonet.Entities.DetalleVentum", b =>
                {
                    b.Navigation("DeudaClientes");
                });

            modelBuilder.Entity("APIColdonet.Entities.Direccion", b =>
                {
                    b.Navigation("Proveedors");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("APIColdonet.Entities.Producto", b =>
                {
                    b.Navigation("DetalleCompras");

                    b.Navigation("DetalleVenta");
                });

            modelBuilder.Entity("APIColdonet.Entities.Proveedor", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("APIColdonet.Entities.SubCategorium", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("APIColdonet.Entities.TipoComercio", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("APIColdonet.Entities.Usuario", b =>
                {
                    b.Navigation("Categoria");

                    b.Navigation("Clientes");

                    b.Navigation("Compras");

                    b.Navigation("DetalleCompras");

                    b.Navigation("DetalleVenta");

                    b.Navigation("DeudaClientes");

                    b.Navigation("Productos");

                    b.Navigation("Proveedors");

                    b.Navigation("SubCategoria");

                    b.Navigation("SubUsuarios");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("APIColdonet.Entities.Ventum", b =>
                {
                    b.Navigation("DetalleVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
