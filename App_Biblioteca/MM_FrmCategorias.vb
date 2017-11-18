Public Class MM_FrmCategorias

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtNombre.Text = "" Or Me.txtDescripcion.Text = "" Then
            MsgBox("Llenar Todos Los Campos", MsgBoxStyle.Information)
        Else
            If IDBUSQUEDA = 0 Then
                StrSQL = "ProAltaCategoria"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                StrSQL = "ProEditarCategoria"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@ID_CATEGORIA", SqlDbType.BigInt).Value = IDBUSQUEDA
            End If

            comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 30).Value = Me.txtNombre.Text
            comando.Parameters.Add("@DESCRIPCION", SqlDbType.Text).Value = Me.txtDescripcion.Text()
            comando.Parameters.Add("@RETORNO", SqlDbType.Int).Direction = ParameterDirection.Output

            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = 1 Then
                    MsgBox("El Lector ya existe", MsgBoxStyle.Critical, "ERROR")
                Else
                    DialogResult = Windows.Forms.DialogResult.OK
                    MsgBox("La Operacion Se Realizo Correctamente", MsgBoxStyle.OkOnly, " ")
                End If
            Else
                MsgBox("Error En La Coneccion", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class