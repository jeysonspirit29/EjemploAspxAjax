Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class EagleContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=EagleContext")
        Configuration.LazyLoadingEnabled = False
        Configuration.ProxyCreationEnabled = False
    End Sub

    Public Overridable Property PROt01_marca As DbSet(Of PROt01_marca)
    Public Overridable Property PROt02_modelo As DbSet(Of PROt02_modelo)
    Public Overridable Property PROt09_producto As DbSet(Of PROt09_producto)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of PROt01_marca)() _
            .Property(Function(e) e.cod_marca) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt01_marca)() _
            .Property(Function(e) e.txt_desc) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt01_marca)() _
            .Property(Function(e) e.txt_estado) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt01_marca)() _
            .HasMany(Function(e) e.PROt02_modelo) _
            .WithRequired(Function(e) e.PROt01_marca) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of PROt02_modelo)() _
            .Property(Function(e) e.cod_modelo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt02_modelo)() _
            .Property(Function(e) e.txt_desc) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt02_modelo)() _
            .Property(Function(e) e.txt_estado) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.cod_producto) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.cod_producto2) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.cod_barra) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.txt_desc) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.por_impto) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.mto_pvpu_con_tax) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.mto_pvmi_con_tax) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.mto_pvma_con_tax) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.mto_pvpu_sin_tax) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.mto_pvmi_sin_tax) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.mto_pvma_sin_tax) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.costo_prod) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por01) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por02) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por03) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por04) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por05) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por06) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por07) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_por08) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto01) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto02) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto03) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto04) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto05) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto06) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto07) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.tax_mto08) _
            .HasPrecision(18, 8)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.peso_prod) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.largo_prod) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.ancho_prod) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.altura_prod) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.diametro_prod) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.url_img_prod) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.txt_referencia) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PROt09_producto)() _
            .Property(Function(e) e.txt_estado) _
            .IsUnicode(False)
    End Sub
End Class
