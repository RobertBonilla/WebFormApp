<%@ Page Title="Master-Lista" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Front._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h1 class="display-4">Lista</h1>
        <asp:Button ID="btnConsult" runat="server" Text="Consultar" OnClick="ConsultarLista" CssClass="btn btn-primary"/>
    </div>
    <div>
        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th scope="col">Creacion</th>
                    <th scope="col">Actualizacion</th>
                    <th scope="col">Detalle</th>
                    <th scope="col"></th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater runat="server" ID="tblLista" ItemType="WebApp.Front.Models.Domain.Lista">
                    <ItemTemplate>
                        <tr>
                            <td> <%# Item.FechaCreacion %></td>
                            <td> <%# Item.FechaUpdate %></td>
                            <td> <%# Item.Descripcion %></td>
                            <td> 
                                <asp:Button ID="btnEdit" runat="server" Text="Editar" CssClass="btn btn-success"/>
                                <asp:Button ID="brnView" runat="server" Text="Ver" CssClass="btn btn-info"/>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>

</asp:Content>
