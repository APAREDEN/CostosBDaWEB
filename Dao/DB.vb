Imports System.Data.SqlClient
Public Class DB
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = ""
        connectionString = "Data Source=apn-pc\i2012;Initial Catalog=costosbd;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function
    Public Shared Function ActTablasComunes(ByVal fecha As String) As String
        Dim connection As SqlConnection = GetConnection()
        Dim executeStatement As String = "EXEC TECNICA.dbo.Tecnica_Act_General_Local @fecha,@rpt OUTPUT;" 'truncate table upd_actualizacion.dbo.insumo;truncate table upd_actualizacion.dbo.Proveedor"
        Dim executeCommand As New SqlCommand(executeStatement, connection)
        executeCommand.CommandType = CommandType.Text
        executeCommand.Parameters.AddWithValue("@fecha", fecha)
        executeCommand.Parameters.Add("@rpt", System.Data.SqlDbType.VarChar, -1)
        executeCommand.Parameters("@rpt").Direction = ParameterDirection.Output '--

        Try
            connection.Open()
            Dim count As Integer = executeCommand.ExecuteNonQuery()
            If count > 0 Then
                Dim rp = executeCommand.Parameters("@rpt").Value
                Return rp
            Else
                Return "ERROR->ActTablasComunes : No procesó nada"
            End If
        Catch ex As SqlException
            Return "ERROR->ActTablasComunes : " & ex.Message
        Finally
            connection.Close()

        End Try

    End Function
    Public Shared Function ActACTComun() As String
        Dim connection As SqlConnection = GetConnection()
        Dim executeStatement As String = "EXEC TECNICA.dbo.Tecnica_Act_General_Local2ACTcomun @rpt OUTPUT"
        Dim executeCommand As New SqlCommand(executeStatement, connection)
        executeCommand.CommandType = CommandType.Text
        executeCommand.Parameters.Add("@rpt", System.Data.SqlDbType.VarChar, -1)
        executeCommand.Parameters("@rpt").Direction = ParameterDirection.Output
        executeCommand.CommandTimeout = 0

        Try
            connection.Open()
            Dim count As Integer = executeCommand.ExecuteNonQuery()
            If count > 0 Then
                Dim rp = executeCommand.Parameters("@rpt").Value
                Return rp
            Else
                Return "ERROR->ActACTComun : No procesó nada"
            End If
        Catch ex As SqlException
            Return "ERROR->ActACTComun : " & ex.Message
        Finally
            connection.Close()
        End Try
        Return ""
    End Function
    Public Shared Function ActCostosDesdeACTComun() As String
        Dim connection As SqlConnection = GetConnection()
        Dim executeStatement As String = "EXEC LNKDESA.ACTcomun.dbo.Tecnica_ACTcomun2Costos @rpt OUTPUT"
        Dim executeCommand As New SqlCommand(executeStatement, connection)
        executeCommand.CommandType = CommandType.Text
        executeCommand.Parameters.Add("@rpt", System.Data.SqlDbType.VarChar, 300)
        executeCommand.Parameters("@rpt").Direction = ParameterDirection.Output

        Try
            connection.Open()
            Dim count As Integer = executeCommand.ExecuteNonQuery()
            If count > 0 Then
                Dim rp = executeCommand.Parameters("@rpt").Value
                Return rp
            Else
                Return "ERROR->ActCostosDesdeACTComun : No procesó nada"
            End If
        Catch ex As SqlException
            Return "ERROR->ActCostosDesdeACTComun : " & ex.Message
        Finally
            connection.Close()
        End Try
        Return ""
    End Function
    Public Shared Function GetFechaUltmActCostosBD() As DateTime


        Dim connection As SqlConnection = GetConnection()

        Dim selectStatement As String = "SELECT max(ActualizacionFecha - 5) as FechaActualizacion FROM costosbd.dbo.Identificador"

        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.CommandType = CommandType.Text
        Dim Rpt As DateTime
        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()

            reader.Read()

            Rpt = System.Convert.ToDateTime(reader("FechaActualizacion"))

            reader.Close()
        Catch ex As SqlException
            If connection.State = ConnectionState.Open Then connection.Close()
            Throw ex
            Return Nothing
        Finally
            connection.Close()

        End Try
        Return rpt
    End Function
End Class
