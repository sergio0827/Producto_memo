<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cuatrimestre.aspx.cs" Inherits="WebApplication.Cuatrimestre" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>


    <asp:Button ID="Button1" runat="server" Text="Ver Cuatrimestre" OnClick="Button1_Click" />
    <h1>Tabla de Cuatrimestre </h1>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    <br />
    <br />
    <h1>Crear Cuatrimestre </h1>
    <div class="mb-3">
        <label for="Registro Empleado" class="form-label">Periodo</label>
        <asp:TextBox ID="periodo" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Registro Empleado" class="form-label">Añio</label>
        <asp:TextBox ID="annio" type="number" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Registro Empleado" class="form-label">Inicio</label>
        <asp:TextBox ID="Anicio" CssClass="form-control" type="date" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Registro Empleado" class="form-label">Fin</label>
        <asp:TextBox ID="Fin" CssClass="form-control" type="date" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Registro Empleado" class="form-label">Extra</label>
        <asp:TextBox ID="Extra" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Crear Cuatrimestre" OnClick="Button2_Click" />

    <div class="mb-3">
        <asp:DropDownList ID="DropDownListCuatri" runat="server"></asp:DropDownList>
    </div>
    <asp:Button ID="Button4" runat="server" CssClass="btn btn-primary" Text="Editar Profesor" OnClick="Button4_Click" />

    <br />
    <br />
    <h1>Borrar Cuatrimestre</h1>

    <div class="mb-3">
        <label for="idEliminar" class="form-label">
            Periodo
        </label>
        <asp:TextBox ID="idEliminar" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="Button3" runat="server" Text="Borrar Cuatrimestre" CssClass="btn btn-primary" OnClick="Button3_Click" />
    <br />

</asp:Content>
