Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class PROt09_producto
    <Key>
    Public Property id_producto As Long

    <StringLength(50)>
    Public Property cod_producto As String

    <StringLength(50)>
    Public Property cod_producto2 As String

    <StringLength(20)>
    Public Property cod_barra As String

    <StringLength(350)>
    Public Property txt_desc As String

    Public Property id_um As Integer?

    Public Property id_modelo As Integer?

    Public Property por_impto As Decimal

    Public Property id_tipo_moneda As Integer?

    Public Property mto_pvpu_con_tax As Decimal?

    Public Property mto_pvmi_con_tax As Decimal?

    Public Property mto_pvma_con_tax As Decimal?

    Public Property mto_pvpu_sin_tax As Decimal?

    Public Property mto_pvmi_sin_tax As Decimal?

    Public Property mto_pvma_sin_tax As Decimal?

    Public Property costo_prod As Decimal?

    Public Property tax_por01 As Decimal

    Public Property tax_por02 As Decimal

    Public Property tax_por03 As Decimal

    Public Property tax_por04 As Decimal

    Public Property tax_por05 As Decimal

    Public Property tax_por06 As Decimal

    Public Property tax_por07 As Decimal

    Public Property tax_por08 As Decimal

    Public Property tax_mto01 As Decimal

    Public Property tax_mto02 As Decimal

    Public Property tax_mto03 As Decimal

    Public Property tax_mto04 As Decimal

    Public Property tax_mto05 As Decimal

    Public Property tax_mto06 As Decimal

    Public Property tax_mto07 As Decimal

    Public Property tax_mto08 As Decimal

    <StringLength(10)>
    Public Property peso_prod As String

    <StringLength(10)>
    Public Property largo_prod As String

    <StringLength(10)>
    Public Property ancho_prod As String

    <StringLength(10)>
    Public Property altura_prod As String

    <StringLength(10)>
    Public Property diametro_prod As String

    <StringLength(300)>
    Public Property url_img_prod As String

    <StringLength(300)>
    Public Property txt_referencia As String

    Public Property sn_combo As Integer?

    Public Property id_tipo_existencia As Integer?

    Public Property id_subfamilia As Integer?

    Public Property id_tipo_prod As Integer?

    Public Property id_clase_prod As Integer?

    Public Property id_receta As Long?

    Public Property sn_exento As Integer?

    Public Property sn_inafecto As Integer?

    Public Property sn_venta As Integer?

    Public Property sn_compra As Integer?

    Public Property sn_receta As Integer?

    Public Property id_estado As Integer?

    <StringLength(20)>
    Public Property txt_estado As String

    Public Property id_impuesto As Integer?

    Public Property id_combo As Long?

    Public Property sn_incluye_impto As Integer

    Public Overridable Property PROt02_modelo As PROt02_modelo
End Class
