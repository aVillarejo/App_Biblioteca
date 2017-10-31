Module BdDatos
    Public Conexion As SqlClient.SqlConnection
    Public StrSQL As String
    Public comando As SqlClient.SqlCommand
    Public dts As New DataSet
    Public IDBUSQUEDA As Long


    Public Sub INICIO()
        Conexion = New SqlClient.SqlConnection("Server=MACBOOKPRO-PC\SQLEXPRESS; database=BDDBIBLIOTECA; uid=sa; pwd=12345;")
        'prueba de codigo
    End Sub

    Public Function Conectar() As Boolean
        Dim ret As Boolean
        Try
            comando.Connection.Open()
            comando.ExecuteNonQuery()
            ret = True
        Catch ex As Exception
            ret = False
            MsgBox("SE A PRODUCIDO EL SIGUIENTE ERROR :" & ex.Message & "", MsgBoxStyle.Critical, "")
        End Try
        comando.Connection.Close()
        Return ret
    End Function
End Module
