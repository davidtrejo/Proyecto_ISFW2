﻿Imports System.Data.SqlClient


Public Class conexion

    Public Sub New()
        Dim msjError As String = ""
        Conectar(msjError)
    End Sub

    Public conn As SqlConnection

    Public Sub Conectar(msjError As String)
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=DESKTOP-RG9QC1P; Initial Catalog=cooperativa1; user=cooperativa; password=12345; Integrated Security=SSPI;"

        'conn.ConnectionString = "Data Source=sql5031.smarterasp.net; Initial Catalog=DB_A2BDCF_coopeprueba; user=DB_A2BDCF_coopeprueba_admin; password=Abc12345; persist security info=False;"

        conn.Open()

    End Sub

    Public Function ObtenerTabla(strCadena As String, ByRef msjError As String) As DataTable



        Dim da As SqlDataAdapter
        Dim ds As DataSet = New DataSet

        Try

            da = New SqlDataAdapter(strCadena, conn)
            da.Fill(ds)

            Return ds.Tables(0)

        Catch ex As Exception
            msjError = ex.Message
            Return Nothing
        End Try



    End Function

    Public Sub EjecutarSql(strCadena As String, ByRef msjError As String)



        Dim cmd As New SqlCommand

        Try
            cmd = New SqlCommand(strCadena, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            msjError = ex.Message
        End Try

    End Sub


End Class
