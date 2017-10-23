﻿Public Class clahorro

#Region "Declaraciones"

#Region "Enumeraciones"

    Private Enum TiposMovimientosAhorro
        Abono = 1
        Retiro = 2
        Capitalizacion = 3
    End Enum
#End Region

    Private _idAhorro As Integer
    Public Property IdAhorro() As Integer
        Get
            Return _idAhorro
        End Get
        Set(ByVal value As Integer)
            _idAhorro = value
        End Set
    End Property

    Private _idHistoricoAhorro As Integer
    Public Property IdHistoricoAhorro() As Integer
        Get
            Return _idHistoricoAhorro
        End Get
        Set(ByVal value As Integer)
            _idHistoricoAhorro = value
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

    Private _totalAhorro As Double
    Public Property TotalAhorro() As Double
        Get
            Return _totalAhorro
        End Get
        Set(ByVal value As Double)
            _totalAhorro = value
        End Set
    End Property

    Private _fechaInicioAhorro As Date
    Public Property FechaInicio() As Date
        Get
            Return _fechaInicioAhorro
        End Get
        Set(ByVal value As Date)
            _fechaInicioAhorro = value
        End Set
    End Property

    '' propiedad para definir en que cuenta se guardaran los intereses ganados
    Private _idAhorroDepostio As Integer
    Public Property IdAhorroDeposito() As Integer
        Get
            Return _idAhorroDepostio
        End Get
        Set(ByVal value As Integer)
            _idAhorroDepostio = value
        End Set
    End Property

    Private _idtasaHistorico As Integer
    Public Property idTasahistorico() As Integer
        Get
            Return _idtasaHistorico
        End Get
        Set(ByVal value As Integer)
            _idtasaHistorico = value
        End Set
    End Property

    Private _fechaVencimiento As Date
    Public Property FechaVencimiento() As Date
        Get
            Return _fechaVencimiento
        End Get
        Set(ByVal value As Date)
            _fechaVencimiento = value
        End Set
    End Property

    Private _fechaCancelacion As String
    Public Property FechaCancelacion() As String
        Get
            Return _fechaCancelacion
        End Get
        Set(ByVal value As String)
            _fechaCancelacion = value
        End Set
    End Property

    Private _UltimaFechaCap As Date
    Public Property UltimaFechaCap() As Date
        Get
            Return _UltimaFechaCap
        End Get
        Set(ByVal value As Date)
            _UltimaFechaCap = value
        End Set
    End Property

    Private _idCuentaAnterior As Integer
    Public Property IdCuentaAnterior() As Integer
        Get
            Return _idCuentaAnterior
        End Get
        Set(ByVal value As Integer)
            _idCuentaAnterior = value
        End Set
    End Property

    Private _tienePrestamo As Boolean
    Public Property NewProperty() As Boolean
        Get
            Return _tienePrestamo
        End Get
        Set(ByVal value As Boolean)
            _tienePrestamo = value
        End Set
    End Property

    ''Si tiene prestamo puede ocupar una cuenta de ahorro o depósito como garantia
    '' El sistema de préstamo tendrá una interfaz hacia este sistema de ahorro
    Private _numPrestamo As Integer
    Public Property Prestamo() As Integer
        Get
            Return _numPrestamo
        End Get
        Set(ByVal value As Integer)
            _numPrestamo = value
        End Set
    End Property

    ''Variable para el monto cubierto como garantia de prestamo
    Private _montoCubiertoPres As Double
    Public Property MontoCubiertoPres() As Double
        Get
            Return _montoCubiertoPres
        End Get
        Set(ByVal value As Double)
            _montoCubiertoPres = value
        End Set
    End Property

    Private _idEstadoAhorro As Integer
    Public Property IdEstado() As Integer
        Get
            Return _idEstadoAhorro
        End Get
        Set(ByVal value As Integer)
            _idEstadoAhorro = value
        End Set
    End Property

    Private _uFechaProvAhorro As Date
    Public Property uFechaProvAhorro() As Date
        Get
            Return _uFechaProvAhorro
        End Get
        Set(ByVal value As Date)
            _uFechaProvAhorro = value
        End Set
    End Property

    '' ************ variables para movimientos de la cuenta de ahorros **********************
    Private _idmovimiento As Integer
    Public Property IdMovimiento() As Integer
        Get
            Return _idmovimiento
        End Get
        Set(ByVal value As Integer)
            _idmovimiento = value
        End Set
    End Property

    Private _DescripcionMov As String
    Public Property DescrpcionMov() As String
        Get
            Return _DescripcionMov
        End Get
        Set(ByVal value As String)
            _DescripcionMov = value
        End Set
    End Property

    Private _valorMov As Double
    Public Property ValorMov As Double
        Get
            Return _valorMov
        End Get
        Set(ByVal value As Double)
            _valorMov = value
        End Set
    End Property

    Private _fechaMov As Date
    Public Property FechaMov() As Date
        Get
            Return _fechaMov
        End Get
        Set(ByVal value As Date)
            _fechaMov = value
        End Set
    End Property

    Private _IdCapMOv As Integer
    Public Property IdCapMov() As Integer
        Get
            Return _IdCapMOv
        End Get
        Set(ByVal value As Integer)
            _IdCapMOv = value
        End Set
    End Property

    Private _fechaCapMov As String
    Public Property FechaCapMov() As String
        Get
            Return _fechaCapMov
        End Get
        Set(ByVal value As String)
            _fechaCapMov = value
        End Set
    End Property

    Private _idTipoMOv As Integer
    Public Property IdTipoMov() As Integer
        Get
            Return _idTipoMOv
        End Get
        Set(ByVal value As Integer)
            _idTipoMOv = value
        End Set
    End Property



    Enum EstadosAhorro
        Ninguno = 0
        Activo = 1
        Inactivo = 2

    End Enum



    ''******************** variables para la provisión de Interes **********************************

    Private _fechaProv As Date
    Public Property FechaProv() As Date
        Get
            Return _fechaProv
        End Get
        Set(ByVal value As Date)
            _fechaProv = value
        End Set
    End Property

    Private _idProv As Integer
    Public Property IdProv() As Integer
        Get
            Return _idProv
        End Get
        Set(ByVal value As Integer)
            _idProv = value
        End Set
    End Property


    Private _valorProv As Double
    Public Property ValorProv() As Double
        Get
            Return _valorProv
        End Get
        Set(ByVal value As Double)
            _valorProv = value
        End Set
    End Property




    Private _tasaInteres As Decimal
    Public Property tasaInteres() As Decimal
        Get
            Return _tasaInteres
        End Get
        Set(ByVal value As Decimal)
            _tasaInteres = value
        End Set
    End Property

    Private _idTasa As Decimal
    Public Property IdTasa() As Decimal
        Get
            Return _idTasa
        End Get
        Set(ByVal value As Decimal)
            _idTasa = value
        End Set
    End Property

    Private _fechaDesdeTasa As Date
    Public Property FechaDesdeTasa() As Date
        Get
            Return _fechaDesdeTasa
        End Get
        Set(ByVal value As Date)
            _fechaDesdeTasa = value
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

    Public Function ObtenerTblAhorros(ByRef msjError As String, Estado As EstadosAhorro, Optional idproducto As Integer = 0, Optional idpersona As Integer = 0, Optional idAhorro As Integer = 0) As DataTable

        strSql = " select * from ahorrosPersona "


        Dim Condicion As String = ""

        If Estado <> 0 Then
            Condicion &= " Where IDEstado =  '" & Estado & "'"
        End If

        If idproducto <> 0 Then
            If Condicion = "" Then
                Condicion = " Where idproducto = " & idproducto
            Else
                Condicion &= " and idproducto = " & idproducto

            End If

        End If

        If idpersona <> 0 Then
            If Condicion = "" Then
                Condicion = " Where idPersona = " & idpersona
            Else
                Condicion &= " and idproducto = " & idpersona

            End If
        End If


        If idAhorro <> 0 Then
            If Condicion = "" Then
                Condicion = " Where idAhorro = " & idAhorro
            Else
                Condicion &= " and idAhorro = " & idAhorro

            End If
        End If

        strSql = strSql & Condicion

        Dim tabla As DataTable = New DataTable




        Try
            tabla = conn.ObtenerTabla(strSql, msjError)
            Return tabla

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try


    End Function

    Public Function ObtenerHistoricoActual(idAhorro As Integer, ByRef msj As String) As Integer

        strSql = " select max(idhistorico) as IdHistorico from AhorroHistorico  where idahorro = " & idAhorro

        Return conn.ObtenerTabla(strSql, msj).Rows(0).Item("IdHistorico")

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

#Region "Capitalizacion"

    Public Function obtenerUltimaFechaCapitalizacion(ByRef msj As String, Optional idahorro As Integer = 0) As Date


        Dim UFechaCapitalizacion As Date

        strSql = " select max(FechaCapitalizacion) as FechaCapitalizacion from [dbo].[ProvisionInteres] as a "
        strSql &= " inner join capitalizaciones as b on a.idcapitalizacion = b.idcapitalizacion"

        Try
            Dim tabla As DataTable
            tabla = conn.ObtenerTabla(strSql, msj)

            If Not IsDBNull(tabla.Rows(0).Item("FechaCapitalizacion")) Then
                UFechaCapitalizacion = tabla.Rows(0).Item("FechaCapitalizacion")
            End If


        Catch ex As Exception
            msj = ex.Message
        End Try


        Return UFechaCapitalizacion

    End Function

    Public Function obtenerUltimaFechaProvision(ByRef msj As String, Optional idahorro As Integer = 0) As Date


        Dim UFechaProvision As Date

        strSql = " select max(fechaprovision) as fechaprovision from [dbo].[ProvisionInteres] as a "


        Dim condicion As String = ""
        If idahorro <> 0 Then
            condicion = " Where idahorro =  " & idahorro
        End If

        strSql &= condicion

        Try
            Dim tabla As DataTable
            tabla = conn.ObtenerTabla(strSql, msj)

            If Not IsDBNull(tabla.Rows(0).Item("fechaprovision")) Then
                UFechaProvision = tabla.Rows(0).Item("fechaprovision")
            End If


        Catch ex As Exception
            msj = ex.Message
        End Try

        Return UFechaProvision

    End Function

    Public Sub leerAhorroPersona(idAhorro As Integer, ByRef msj As String)

        strSql = " select * from ahorrosPersona where idahorro = " & idAhorro

        Dim ahorro As DataRow = conn.ObtenerTabla(strSql, msj).Rows(0)

        _idProducto = ahorro("IdProducto")
        _IdPersona = ahorro("Idpersona")
        _idCuentaAnterior = IsNull(ahorro("idcuentaanterior"), 0)
        _tienePrestamo = IsNull(ahorro("tieneprestamo"), False)
        _montoCubiertoPres = IsNull(ahorro("montocubiertoenprestamo"), 0)
        _idEstadoAhorro = IsNull(ahorro("idestado"), 1)

        '' ahora leemos la información del historico
        _idHistoricoAhorro = ObtenerHistoricoActual(_idAhorro, msj)
        leerHistoricoAhorro(_idtasaHistorico, msj)

        _uFechaProvAhorro = obtenerUltimaFechaProvision(msj, idAhorro)







    End Sub

    Public Sub leerHistoricoAhorro(idHistorico As Integer, ByRef msj As String)

        strSql = " select * from AhorroHistorico where idHistorico =" & idHistorico

        Dim row As DataRow = conn.ObtenerTabla(strSql, msj).Rows(0)

        _fechaInicioAhorro = row("fechainicio")
        _idAhorroDepostio = IsNull(row("idahorrodeposito"), 0)
        _idtasaHistorico = IsNull(row("idtasa"), 0)

        If Not IsDBNull(row("fechavencimiento")) Then
            _fechaVencimiento = row("fechavencimiento")
        End If

        If Not IsDBNull(row("fechacancelacion")) Then
            _fechaCancelacion = row("fechacancelacion")
        End If





    End Sub

    Public Sub Provisionar1(ByRef Msj As String, fechaProvision As Date, Optional IdProducto As Integer = 0, Optional idSocio As Integer = 0, Optional IdAhorro As Integer = 0)

        ''Obtener la UltimaFechaPrivision
        Dim MaxFechaProvision As Date = obtenerUltimaFechaProvision(Msj)
        Dim DiasProvision As Integer = DateDiff(DateInterval.Day, uFechaProvAhorro, fechaProvision)

        Dim fecha As Date = MaxFechaProvision ''  fecha que ire recorriendo



        For i As Integer = 0 To DiasProvision



            '' Obtengo todos los ahorros que voy a provisionar
            '' Primero Correr proceso sobre cuentas que depositen el interes en otras cuentas
            Dim tblAhorro As DataTable

            strSql = " select a.idahorro  from ahorrosPersona  as a inner join productos  as p on p.idproducto = a.idproducto "
            strSql &= " where p.idtipoproducto <> 1 and " '' idtipoproducto son aportaciones
            strSql &= " idahorro = (select top 1 idahorroDeposito  from AhorroHistorico as b where a.idahorro = b.idahorro order by IdHistorico desc )"

            tblAhorro = conn.ObtenerTabla(strSql, Msj)


            For Each row As DataRow In tblAhorro.Rows


                _idAhorro = row("IdAhorro")
                leerAhorroPersona(_idAhorro, Msj)



                Dim ValorProvision As Double = CalcularProvision(Msj, fecha, _idAhorro)

                If ValorProvision <> 0 Then
                    GuardarProvision(Msj, fecha, _idAhorro, ValorProvision)
                End If

                If fecha.Day = 28 Then
                    ''Hay que capitalizar la cuenta
                End If

                fecha = DateAdd("d", 1, fecha)






            Next




        Next



    End Sub


    Public Sub provisionar(ByRef Msj As String, fechaProvision As Date, Optional IdProducto As Integer = 0, Optional idSocio As Integer = 0, Optional IdAhorro As Integer = 0)

        Dim tblAhorro As DataTable

        ''Obtener la UltimaFechaCapitalizacion
        Dim FechaCapitalizacion As Date = obtenerUltimaFechaCapitalizacion(Msj)

        '' Obtengo todos los ahorros que voy a provisionar
        tblAhorro = ObtenerTblAhorros(Msj, EstadosAhorro.Activo, IdProducto, idSocio)


        For Each row As DataRow In tblAhorro.Rows
            _idAhorro = row("IdAhorro")

            leerAhorroPersona(_idAhorro, Msj)

            '' si es primera vez que se provisionara la cuenta de ahorro se tomara la fecha de Inicio de la cuenta
            If uFechaProvAhorro = Date.MinValue Then
                uFechaProvAhorro = ObtenerFechaInicioAhorro(Msj, _idAhorro)
            End If


            Dim Numdias As Integer  '' Dias a provisionar

            Numdias = DateDiff(DateInterval.Day, uFechaProvAhorro, fechaProvision)

            If Numdias > 0 Then

                If uFechaProvAhorro <> fechaProvision Then '' Para evitar que repita el insert del mismo dia dos veces

                    Dim contadorDias As Integer = 0
                    Dim fecha As DateTime = uFechaProvAhorro  '' fecha a recorrer

                    For i As Integer = 0 To Numdias

                        Dim ValorProvision As Double = CalcularProvision(Msj, fecha, _idAhorro)

                        If ValorProvision <> 0 Then
                            GuardarProvision(Msj, fecha, _idAhorro, ValorProvision)
                        End If

                        If fecha.Day = 28 Then
                            ''Hay que capitalizar la cuenta
                        End If

                        fecha = DateAdd("d", 1, fecha)

                    Next
                End If

            End If
        Next



    End Sub


    Private Function CalcularProvision(ByRef msj As String, Fecha As DateTime, idahorro As Integer) As Double

        Dim valorProvision As Double
        Dim MontoAhorrado As Double

        Try
            strSql = " select isnull( sum(valorMovimiento),0) as MontoAhorrado from [dbo].[ahorrosPersonaMovimientos] "
            strSql &= " where idahorro = " & idahorro & " and fechaMovimiento <= " & sef2(Fecha)
            MontoAhorrado = conn.ObtenerTabla(strSql, msj).Rows(0).Item("MontoAhorrado")


            If MontoAhorrado <> 0 Then
                _tasaInteres = obtenertasa(msj, idahorro, Fecha)
                valorProvision = System.Math.Round(MontoAhorrado * _tasaInteres / 365, 2)
            End If

        Catch ex As Exception

        End Try

        Return valorProvision

    End Function

    Private Function obtenertasa(ByRef msj As String, idahorro As Integer, fecha As Date) As Decimal

        Try
            strSql = "  select top 1 tasa from tasasInteres where idproducto = (select idproducto from ahorrosPersona where idahorro = " & idahorro & " )"
            strSql &= " And fechaDesde <=" & sef2(fecha)
            strSql &= "  order by idtasa desc"

            Return conn.ObtenerTabla(strSql, msj).Rows(0).Item("tasa")

        Catch ex As Exception

        End Try
    End Function

    Private Sub GuardarProvision(ByRef msj As String, fechaProvision As Date, idahorro As Integer, valor As Double)

        Try

            strSql = " insert into  [dbo].[ProvisionInteres] (fechaprovision,idahorro,valor) values ("
            strSql &= sef2(fechaProvision) & "," & idahorro & "," & valor & ")"

            conn.EjecutarSql(strSql, msj)

        Catch ex As Exception
            msj = ex.Message
        End Try

    End Sub

    Public Function ObtenerFechaInicioAhorro(ByRef msj As String, idahorro As Integer) As Date

        Try
            strSql = "select fechaInicio from AhorroHistorico where idahorro = " & idahorro

            Dim fecha As Date = CDate(conn.ObtenerTabla(strSql, msj).Rows(0).Item("fechaInicio"))

            Return fecha
        Catch ex As Exception
            msj = ex.Message
            Return Date.MinValue
        End Try

    End Function

    Private Function ObtenerIdCapitalizacion(fecha As Date, ByRef msj As String) As Integer
        Try

            strSql = " Insert into Capitalizaciones (fechacapitalizacion )"
            strSql &= " OUTPUT INSERTED.idcapitalizacion "
            strSql &= "values (" & sef2(fecha) & ")"

            Return conn.ObtenerTabla(strSql, msj).Rows(0).Item("idcapitalizacion")

        Catch ex As Exception
            msj = ex.Message
            Return Nothing
        End Try

    End Function

    Private Sub capitalizarAhorro(idahorro As Integer, idcapitalizacion As Integer, ByRef msj As String)


        Try
            '' obtengo el monto de las provisiones de la cuenta
            strSql = " select isnull(sum(valor ),0) as valor from ProvisionInteres  "
            strSql &= " where idahorro = " & idahorro & " and idcapitalizacion is null"

            Dim valor As Double = conn.ObtenerTabla(strSql, msj).Rows(0).Item("valor")

            If valor <> 0 Then
                ''  guardo la capitalizacion de la cuenta  








            End If



        Catch ex As Exception

        End Try


    End Sub




#End Region





End Class
