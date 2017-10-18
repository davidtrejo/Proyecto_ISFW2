<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin/admin.Master" CodeBehind="listapersonas.aspx.vb" Inherits="coope.listapersonas" %>
<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="main-header" class="page-header">
      <span class="titular1 block linea1bottom">Buscar Personas <asp:Label runat="server" ID="lbltitulo" Text =""></asp:Label><br></span>
    </div>  
    
    <div id="main-content">   
        

        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        

        </div>
    
    <div class="widget-content form-container">
        <dx:ASPxGridView ID="ASPxGridView1" runat="server">
        </dx:ASPxGridView>
    </div>
</asp:Content>
