
<%@ Page Title="Master-Lista" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditList.aspx.cs" Inherits="WebApp.Front.EditList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h1 class="display-4">Editar Lista</h1>
    </div>
<div>
        <div class="input-group">
            <label for="txtCodigo" class="form-label">Codigo</label>
            <asp:TextBox runat="server" ID="txtCodigo" Text="" ReadOnly="true" CssClass="form-control"/>
        </div>
        <div class="input-group">
            <label for="txtFechaCreacion" class="form-label">Creacion</label>
            <asp:TextBox runat="server" ID="txtFechaCreacion" Text="" ReadOnly="true" CssClass="form-control"/>
        </div>
        <div class="input-group">
            <label for="txtFechaUpdate" class="form-label">Modificacion</label>
            <asp:TextBox runat="server" ID="txtFechaUpdate" Text="" ReadOnly="true" CssClass="form-control"/>
        </div>
        <div class="input-group">
            <label for="txtDescripcion" class="form-label">Descripcion</label>
            <asp:TextBox runat="server" ID="txtDescripcion" Text="" CssClass="form-control"/>
        </div>
        <div class="input-group">
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Guardar" OnClick="Modificar" AutoPostBack="false" CssClass="btn btn-primary" OnClientClick="return confirm('Seguro que desea Modificar?');"/>
            <asp:Button ID="btnReturn" runat="server" Text="Regresar" OnClick="Regresar" CssClass="btn btn-info"/>
        </div>
</div>

</asp:Content>
