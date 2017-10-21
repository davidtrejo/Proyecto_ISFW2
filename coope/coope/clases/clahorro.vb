Public Class clahorro

#Region "Declaraciones"

    Private _idAhorro As Integer
    Public Property IdAhorro() As Integer
        Get
            Return _idAhorro
        End Get
        Set(ByVal value As Integer)
            _idAhorro = value
        End Set
    End Property

    Private _idProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Private _IdPersona As Integer
    Public Property IdPErsona() As Integer
        Get
            Return _IdPersona
        End Get
        Set(ByVal value As Integer)
            _IdPersona = value
        End Set
    End Property



#End Region


    Dim strSql As String = ""
    Dim conn As New conexion
    Dim c = ","


    Public Function ObtenerAhorros(msjError As String) As DataTable

        strSql = " select * from vis_ahorros"
        Dim tabla As DataTable = New DataTable

        Try
            tabla = conn.ObtenerTabla(strSql, msjError)
            Return tabla

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try


    End Function


    Public Function ObtenerAhorrosMovimientos(msjError As String) As DataTable

        strSql = " select * from vis_ahorros"
        Dim tabla As DataTable = New DataTable

        Try
            tabla = conn.ObtenerTabla(strSql, msjError)
            Return tabla

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try


    End Function

    Public Function ObtenerAhorrosMovimientos(idpersona As Integer, msjError As String) As DataTable

        strSql = " select * from vis_ahorrosMovimientos where idpersona =" & idpersona
        Dim tabla As DataTable = New DataTable

        Try
            tabla = conn.ObtenerTabla(strSql, msjError)
            Return tabla

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try


    End Function


    Public Function ObtenerAhorrosPersona(idpersona As Integer, msjError As String) As DataTable

        strSql = " select '' as idahorro,'' as nombreproducto union  select  idahorro,nombreproducto from  vis_productosPersona  where idpersona =" & idpersona
        Dim tabla As DataTable = New DataTable

        Try
            tabla = conn.ObtenerTabla(strSql, msjError)
            Return tabla

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try


    End Function


    Public Function GuardarAbono(idahorro As Integer, monto As Double, descripcion As String, ByRef msjError As String)

        Try

            strSql = " Insert into ahorrosPersonaMovimientos (idahorro,valormovimiento,descripcion,fechamovimiento) values ("
            strSql &= idahorro & c
            strSql &= monto & c
            strSql &= "'" & descripcion & "',"
            strSql &= " getdate() )"

            conn.EjecutarSql(strSql, msjError)


        Catch ex As Exception

        End Try

    End Function




    Public Function ObtenerAhorrosMovimientos(idpersona As Integer, idahorro As Integer, msjError As String) As DataTable

        strSql = " select * from vis_ahorrosMovimientos where idpersona =" & idpersona & " and idahorro =" & idahorro
        strSql &= " order by  idmovimiento desc"
        Dim tabla As DataTable = New DataTable

        Try
            tabla = conn.ObtenerTabla(strSql, msjError)
            Return tabla

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try
    End Function


    Public Sub GuardarAhorro(tipoproducto As Integer, idpersona As Integer, fechainicio As String, ByRef msjError As String)


        Try
            strSql = " Insert into ahorrosPersona (idproducto,idpersona) values ( "
            strSql &= tipoproducto & c
            strSql &= idpersona & c
            strSql &= "'" & fechainicio & "' )"

            conn.EjecutarSql(strSql, msjError)

        Catch ex As Exception
            msjError = ex.Message
        End Try

    End Sub
End Class
