﻿Public Class calcularinteres
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '   Me.Calendar1.Visible = False
        'txtFechaHasta.Date = "30/01/2017"
    End Sub

    'Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
    '    ' Me.Calendar1.Visible = True
    'End Sub

    'Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
    '    ' Me.txtFecha.Value = Calendar1.SelectedDate
    '    '  Me.Calendar1.Visible = False
    'End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim ahorro As New clahorro

        Dim msj As String = ""

        ahorro.provisionar(msj, txtFechaHasta.Value)



    End Sub


End Class