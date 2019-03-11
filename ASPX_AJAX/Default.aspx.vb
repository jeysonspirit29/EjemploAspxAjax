Imports System.Web.Script.Services
Imports System.Web.Services

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If (Not IsPostBack) Then

        End If

    End Sub

    <WebMethod>
    <ScriptMethod(UseHttpGet:=True)>
    Public Shared Function ObtenerProductos() As ICollection(Of PROt09_producto)
        Return New ProductoDA().ObtenerProductos()
    End Function

    <WebMethod>
    Public Shared Function ObtenerProductosPorMarca(idMarca As Integer) As ICollection(Of PROt09_producto)
        Return If(idMarca = 0,
            New ProductoDA().ObtenerProductos(),
            New ProductoDA().ObtenerProductosPorMarca(idMarca))
    End Function

    <WebMethod>
    <ScriptMethod(UseHttpGet:=True)>
    Public Shared Function ObtenerMarcas() As ICollection(Of PROt01_marca)
        Dim marcas = New ProductoDA().ObtenerMarcas().ToList()
        If marcas IsNot Nothing Then
            marcas.Insert(0,
                New PROt01_marca With {
                .id_marca = 0,
                .txt_desc = "-- Todos --"
                }
            )
        End If
        Return marcas
    End Function

End Class