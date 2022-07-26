<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="WebApplication.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>


    <asp:Button ID="Button1" runat="server" Text="Ver profesores" OnClick="Button1_Click" />
    <h1>Tabla de profesores </h1>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    <br />
    <br />
    <h1>Crear profesores</h1>
    <div class="mb-3">
        <label for="Registro Empleado" class="form-label">Registro Empleado</label>
        <asp:TextBox ID="RegistroEmpleado" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Nombre" class="form-label">Nombre</label>
        <asp:TextBox ID="Nombre" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Registro Ap_pat" class="form-label">Ap_pat</label>
        <asp:TextBox ID="Ap_pat" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Ap_Mat" class="form-label">Ap_Mat</label>
        <asp:TextBox ID="Ap_Mat" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Genero" class="form-label">Genero</label>
        <asp:TextBox ID="Genero" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Categoria" class="form-label">Categoria</label>
        <asp:TextBox ID="Categoria" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Correo" class="form-label">Correo</label>
        <asp:TextBox ID="Correo" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="Celular" class="form-label">Celular</label>
        <asp:TextBox ID="Celular" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="F_EdoCivil" class="form-label">F_EdoCivil</label>
        <asp:DropDownList ID="F_EdoCivil" CssClass="form-control" runat="server">
            <asp:ListItem Text="Solteor" Value="1"></asp:ListItem>
            <asp:ListItem Text="Casado" Value="2"></asp:ListItem>
            <asp:ListItem Text="Divorsiado" Value="4"></asp:ListItem>
            <asp:ListItem Text="Union Libre" Value="5"></asp:ListItem>
            <asp:ListItem Text="viudo" Value="6"></asp:ListItem>
            <asp:ListItem Text="raro" Value="12"></asp:ListItem>
        </asp:DropDownList>
    </div>

    <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Crear Profesor" OnClick="Button2_Click" />
    <div class="mb-3">
        <label for="idEditar" class="form-label">Id Profesor</label>
        <asp:TextBox ID="idEditar" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="Button4" runat="server" CssClass="btn btn-primary" Text="Editar Profesor" OnClick="Button4_Click" />

    <br />
    <br />
    <h1>Borrar Profesores</h1>

    <div class="mb-3">
        <label for="idEliminar" class="form-label">Id Profesor</label>
        <asp:TextBox ID="idEliminar" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="Button3" runat="server" Text="Borrar Profesor" CssClass="btn btn-primary" OnClick="Button3_Click" />

    <br />


</asp:Content>
