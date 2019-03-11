$(function () {

    var _tabla = $("#cuerpo-tabla-prod")
    var _cboMarca = $("#cbo-marca")
    var _msjCargando = '<tr><td colspan="4" class="text-center"> <b>Cargando la información...</b> </tr>'
    var _msjVacio = '<tr><td colspan="4" class="text-center"> <b>Tabla sin contenido...</b> </tr>'

    limpiarProductos(_msjVacio)

    listarMarcas()
    listarProductos()

    //PRODUCTO
    function listarProductos() {
        limpiarProductos(_msjCargando)

        $.ajax({
            type: "GET",
            url: 'Default.aspx/ObtenerProductos',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: llenarProductos,
            error: function (e) {
                limpiarProductos(_msjVacio)
                console.log(e)
            }
        })
    }

    function listarProductosPorMarca(idMarca) {
        limpiarProductos(_msjCargando)

        $.ajax({
            type: "POST",
            url: 'Default.aspx/ObtenerProductosPorMarca',
            data: JSON.stringify({'idMarca': idMarca }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: llenarProductos,
            error: function (e) {
                limpiarProductos(_msjVacio)
                console.log(e)
            }
        })
    }

    function llenarProductos(data) {
        limpiarProductos("");

        var productos = data.d;
        if (productos != null && productos != undefined && productos.length > 0) {
            var fila = ""
            $.each(productos, function (i, p) {
                fila = `<tr>
                            <td>`+ p.id_producto + `</td>
                            <td>`+ p.txt_desc + `</td>
                            <td>`+ p.mto_pvpu_con_tax + `</td>
                            <td><a href="#"> Ver </a></td>
                        </tr>`
                _tabla.append(fila)
            })
        }
        else limpiarProductos(_msjVacio)
    }

    function limpiarProductos(msj) {
        _tabla.html(msj)
    }

    //MARCA

    _cboMarca.change(function () {
        listarProductosPorMarca($(this).val())
    })

    function listarMarcas() {
        $.ajax({
            type: "GET",
            url: 'Default.aspx/ObtenerMarcas',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: llenarMarcas,
            error: function (e) {
                console.log(e)
            }
        })
    }

    function llenarMarcas(data) {
        var marcas = data.d;
        if (marcas != null && marcas != undefined && marcas.length > 0) {
            var fila = ""
            $.each(marcas, function (i, m) {
                fila = '<option value="' + m.id_marca + '">' + m.txt_desc + '</option>'
                _cboMarca.append(fila)
            })
        }
    }


})