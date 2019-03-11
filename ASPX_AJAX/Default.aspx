<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ASPX_AJAX._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top:25px;">
        <label>Marca </label>
        <select id="cbo-marca" class="form-control">
        </select>
        <input type="text" id="Text1"  runat="server"/>
        <input type="date" id="Nombre"  runat="server"/>
    </div>
    <br />
    <div class="table table-responsive">
        <table class="table table-condensed table-hover table-bordered">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Descripión</th>
                    <th>Precio</th>
                    <th>Acción</th>
                </tr>
            </thead>
            <tbody id="cuerpo-tabla-prod">
            </tbody>
        </table>
    </div>

    <table id="Tabla" runat="server">

    </table>

    <script src="Public/producto.js"></script>
</asp:Content>
