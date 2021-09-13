<%@ Page Title="Detail-Lista" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="WebApp.Front.Detail" %>

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
            <asp:TextBox runat="server" ID="txtDescripcion" Text="" CssClass="form-control" ReadOnly="true"/>
        </div>
        <div class="input-group">
            <asp:Button ID="btnReturn" runat="server" Text="Regresar" OnClick="Regresar" CssClass="btn btn-info"/>
        </div>
    <div>
        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th scope="col">Producto</th>
                    <th scope="col">Precio Unitario</th>
                    <th scope="col">Cantidad</th>
                    <th scope="col">Sub Total</th>
                    <th scope="col"></th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="tblListaDetail" ItemType="WebApp.Front.Models.DTO.DetListaProducto">
                    <ItemTemplate>
                        <tr>
                            <td> <%# Item.Producto.Nombre %></td>
                            <td> <%# Item.detLista.ValorUnitario %></td>
                            <td> <%# Item.detLista.Cantidad %></td>
                            <td> <%# Item.detLista.SubTotal %></td>
                            <td> 
                                <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="Eliminar" CommandArgument='<%# Item.detLista.DetListaId%>' CssClass="btn btn-danger" OnClientClick="return confirm('Seguro que desea Eliminar?');" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</div>

</asp:Content>