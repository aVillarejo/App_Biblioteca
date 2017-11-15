Public Class MM_FrmLectores
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.txtNombre.Text = "" Or Me.txtApePat.Text = "" Or Me.txtApeMat.Text = "" Or Me.txtDir.Text = "" Or
           Me.txtEmail.Text = "" Or Me.txtTel.Text = "" Then
            MsgBox("Llenar Todos Los Campos", MsgBoxStyle.Information)
        Else
            If IDBUSQUEDA = 0 Then
                StrSQL = "ProAltaLector"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                StrSQL = "ProEditarLector"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@ID_NUMLECTOR", SqlDbType.BigInt).Value = IDBUSQUEDA
            End If

            comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 45).Value = Me.txtNombre.Text
            comando.Parameters.Add("@A_PATERNO", SqlDbType.VarChar, 45).Value = Me.txtApePat.Text
            comando.Parameters.Add("@A_MATERNO", SqlDbType.VarChar, 45).Value = Me.txtApeMat.Text
            comando.Parameters.Add("@DIRECCCION", SqlDbType.VarChar, 45).Value = Me.txtDir.Text
            comando.Parameters.Add("@TEL", SqlDbType.VarChar, 45).Value = Me.txtTel.Text
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar, 45).Value = Me.txtEmail.Text
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class