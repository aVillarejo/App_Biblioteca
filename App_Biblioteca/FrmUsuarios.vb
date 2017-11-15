Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_USUARIOS' Puede moverla o quitarla según sea necesario.
        Me.TBL_USUARIOSTableAdapter.Connection = Conexion
        Me.TBL_USUARIOSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_USUARIOS)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim venMM As New MM_FrmUsuarios
        IDBUSQUEDA = 0
        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_USUARIOSTableAdapter.Connection = Conexion
            Me.TBL_USUARIOSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_USUARIOS)
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim venMM As New MM_FrmUsuarios


        IDBUSQUEDA = Me.DTUsuarios.CurrentRow.Cells("ID_USUARIO").Value
        venMM.txtNombre.Text = Me.DTUsuarios.CurrentRow.Cells("NOMBRE").Value
        venMM.txtApePat.Text = Me.DTUsuarios.CurrentRow.Cells("A_PATERNO").Value
        venMM.txtApeMat.Text = Me.DTUsuarios.CurrentRow.Cells("A_MATERNO").Value
        venMM.txtDir.Text = Me.DTUsuarios.CurrentRow.Cells("DIRECCCION").Value
        venMM.txtEmail.Text = Me.DTUsuarios.CurrentRow.Cells("EMAIL").Value
        venMM.txtTel.Text = Me.DTUsuarios.CurrentRow.Cells("TEL").Value
        venMM.txtLogin.Text = Me.DTUsuarios.CurrentRow.Cells("LOGIN").Value
        venMM.txtPassword.Text = Me.DTUsuarios.CurrentRow.Cells("PASSWORD").Value
        venMM.cbTipo.Text = Me.DTUsuarios.CurrentRow.Cells("USUTIPO").Value

        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_USUARIOSTableAdapter.Connection = Conexion
            Me.TBL_USUARIOSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_USUARIOS)
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If DTUsuarios.RowCount > 0 Then
            Dim r As String
            r = MsgBox("Esta Seguro de Eliminar El Cliente Seleccionado", MsgBoxStyle.YesNo, "Advertencia")
            If r = "6" Then
                StrSQL = "ProEliminarUsuario"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@ID_USUARIO", SqlDbType.BigInt).Value = Me.DTUsuarios.CurrentRow.Cells("ID_USUARIO").Value

                If Conectar() = True Then
                    MsgBox("La Operacion Se Realizo Correctamente", MsgBoxStyle.OkOnly, "")
                    Me.TBL_USUARIOSTableAdapter.Connection = Conexion
                    Me.TBL_USUARIOSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_USUARIOS)
                Else
                    MsgBox("Error Al Realizar La Operacion", MsgBoxStyle.Critical, "")
                End If
            End If
        End If
    End Sub
End Class