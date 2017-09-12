﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/admin/admin.Master" CodeBehind="abonos.aspx.vb" Inherits="coope.abonos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery-1.8.3.min.js"></script>
    <script src="../js/jquery.maskedinput.js"></script>
    <script type="text/javascript">
        $(function () {
            $.mask.definitions['~'] = "[+-]";
            $("#date").mask("99/99/9999", { completed: function () { alert("completed!"); } });
            $("#phone").mask("(999) 999-9999");
            $("#phoneExt").mask("(999) 999-9999? x99999");
            $("#iphone").mask("+33 999 999 999");
            $("#tin").mask("99-9999999");
            $("#ssn").mask("999-99-9999");
            $("#product").mask("a*-999-a999", { placeholder: " " });
            $("#eyescript").mask("~9.99 ~9.99 999");
            $("#po").mask("PO: aaa-999-***");
            $("#pct").mask("99%");
            $("#txtMonto").mask("$99.99");
            $("input").blur(function () {
                $("#info").html("Unmasked value: " + $(this).mask());
            }).dblclick(function () {
                $(this).unmask();
            });
        });

</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div id="main-header" class="page-header">
      <span class="titular1 block linea1bottom"> <asp:Label runat="server" ID="lbltitulo" Text ="Ingresar Abono"></asp:Label><br></span>
    </div>  
    
    <div id="main-content">       
        </div>
           <div class="row-fluid">
               <div class="span12 widget">
                    <div class="widget-header">
                        <span class="title"></span>
					</div>

                   	<div class="widget-content form-container">
                          <table class="table table-striped table-detail-view">
                                 <tbody> 
                                      <tr>
                                                   <th>Socio:</th>
                                                    <td>                                                        
                                                        <asp:DropDownList ID="cmbSocio" runat="server"  CssClass="span6" AutoPostBack="True"></asp:DropDownList>
                                                     </td>
                                              </tr> 
                                        <tr>
                                                   <th>Producto:</th>
                                                    <td>
                                                         <asp:DropDownList ID="cmbProducto" runat="server"  CssClass="span6" AutoPostBack="True"></asp:DropDownList>
                                                     
                                                     </td>
                                              </tr> 
                                              <tr>
                                                    <th>Monto:</th>
                                                    <td>
                                                        <asp:TextBox ID="txtMonto" textmode="Number"    runat="server" CssClass="span6"  ></asp:TextBox> 
                                                      
                                                     </td>
                                              </tr> 
                                     
                                              <tr>
                                                   <th>Descripci&oacute;n:</th>
                                                    <td>
                                                        <asp:TextBox ID="txtDescripcion" TextMode ="MultiLine" runat="server" CssClass="span6"></asp:TextBox>
                                                     
                                                     </td>
                                              </tr>
                                             
                                              <tr>
                                                    <th></th>
                                                    <td>
                                                    &nbsp;
                                                       
                                                    <asp:Button ID="btnguardar" runat="server" Text="Abonar" CssClass="btn" />
                                                     
                                                     
                                                     </td>
                                              </tr>
                                              <tr><td>
                                                  <asp:Label ForeColor ="Red" ID="lblErrror" runat="server" Text=""></asp:Label></td></tr>
                                                                                            
                                 </tbody> 
                        </table> 
                    </div>
                </div> 
            </div>
    
    <div class="widget-content form-container">
        <asp:GridView Width ="100%" ID="grid" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="idmovimiento" HeaderText="idmovimiento" Visible="False">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="fechamovimiento" HeaderText="Fecha Movimiento">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="descripcion" HeaderText="Descripción">
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="valormovimiento" HeaderText="Valor Movimiento">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>

</asp:Content>
