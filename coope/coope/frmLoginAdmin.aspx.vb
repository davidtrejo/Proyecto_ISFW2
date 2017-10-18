Public Class frmLoginAdmin
    Inherits System.Web.UI.Page
    Dim usuario As clusuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then


            If Not Request.Cookies("UsuarioCoope") Is Nothing Then
                Me.txtUsuario.Text = Request.Cookies("UsuarioCoope").Item("User").ToString.Trim
                Me.checkrecordar.Checked = True

            End If


            Dim cookie As HttpCookie = Request.Cookies("UsuarioCoope")

            'si existe la cookie entonces la leemos .
            If Not cookie Is Nothing Then
                Dim Usuario As String = cookie("User")
                Dim Pass As String = cookie("Password")


                'autologon-
                If Usuario.Length > 0 And Pass.Length > 0 Then

                    Me.txtUsuario.Text = Usuario
                    Me.txtPassword.Text = Pass



                End If
            End If




        End If

        Me.txtUsuario.Text = "1123-180592-102-5"
        Me.txtPassword.Text = "12345"

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        usuario = New clusuario
        Dim msjError As String = ""








        If usuario.login(Me.txtUsuario.Text, Me.txtPassword.Text, msjError) Then
            Me.lblError.Visible = False



            ' dattoslogin()
            Dim fecha As Date = Date.Now
            Dim cookieUsuario As HttpCookie = New HttpCookie("UsuarioCoope")
            If Me.checkrecordar.Checked = True Then

                fecha = fecha.AddDays(365)

                cookieUsuario.Values.Add("User", Me.txtUsuario.Text)
                cookieUsuario.Values.Add("Password", Me.txtPassword.Text)

                cookieUsuario.Expires = fecha
                Response.Cookies.Add(cookieUsuario)
            Else
                fecha = Date.Now
                cookieUsuario.Expires = fecha
                Response.Cookies.Add(cookieUsuario)
            End If




            Response.Redirect("admin/inicio.aspx")




        Else
            Me.lblError.Visible = True
        End If


    End Sub
End Class