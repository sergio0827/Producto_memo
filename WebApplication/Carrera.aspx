<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrera.aspx.cs" Inherits="WebApplication.Carrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <div>
    </div>

    <asp:Button ID="Button1" runat="server" Text="Ver" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    <asp:Button ID="Button4" runat="server" Text="Crear" OnClick="Button4_Click" />

    <asp:Button ID="Button2" runat="server" Text="Editar" OnClick="Button2_Click" />

    <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />



</asp:Content>
