Public Class ProductoDA

    Public Function ObtenerProductos() As IEnumerable(Of PROt09_producto)
        Using ctx = New EagleContext
            Return ctx.PROt09_producto.AsNoTracking().ToList()
        End Using
    End Function

    Public Function ObtenerProductosPorMarca(idMarca As Integer) As IEnumerable(Of PROt09_producto)
        Using ctx = New EagleContext
            Return ctx.PROt09_producto.AsNoTracking().Where(Function(p) p.PROt02_modelo.id_marca = idMarca).ToList
        End Using
    End Function

    Public Function ObtenerMarcas() As IEnumerable(Of PROt01_marca)
        Using ctx = New EagleContext
            Return ctx.PROt01_marca.AsNoTracking().ToList()
        End Using
    End Function


End Class
