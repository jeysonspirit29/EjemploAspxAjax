Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class PROt01_marca
    Public Sub New()
        PROt02_modelo = New HashSet(Of PROt02_modelo)()
    End Sub

    <Key>
    Public Property id_marca As Integer

    <StringLength(10)>
    Public Property cod_marca As String

    <Required>
    <StringLength(250)>
    Public Property txt_desc As String

    Public Property id_estado As Integer?

    <StringLength(20)>
    Public Property txt_estado As String

    Public Overridable Property PROt02_modelo As ICollection(Of PROt02_modelo)
End Class
