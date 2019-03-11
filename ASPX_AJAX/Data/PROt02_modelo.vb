Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class PROt02_modelo
    Public Sub New()
        PROt09_producto = New HashSet(Of PROt09_producto)()
    End Sub

    <Key>
    Public Property id_modelo As Integer

    <StringLength(10)>
    Public Property cod_modelo As String

    <Required>
    <StringLength(250)>
    Public Property txt_desc As String

    Public Property id_estado As Integer?

    <StringLength(20)>
    Public Property txt_estado As String

    Public Property id_marca As Integer

    Public Overridable Property PROt01_marca As PROt01_marca

    Public Overridable Property PROt09_producto As ICollection(Of PROt09_producto)
End Class
