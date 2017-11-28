Public Class FrmLectores

    Private Sub DTLectores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTLectores.CellContentClick

    End Sub

    Private Sub FrmLectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_LECTORES' Puede moverla o quitarla según sea necesario.
        Me.TBL_LECTORESTableAdapter.Connection = Conexion
        Me.TBL_LECTORESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LECTORES)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'Dim venMM As New MM_FrmLectores
        'venMM.ShowDialog()
        Dim venMM As New MM_FrmLectores
        IDBUSQUEDA = 0
        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_LECTORESTableAdapter.Connection = Conexion
            Me.TBL_LECTORESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LECTORES)
        End If

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Dim venMM As New MM_FrmLectores
        'venMM.ShowDialog()
        Dim venMM As New MM_FrmLectores


        IDBUSQUEDA = Me.DTLectores.CurrentRow.Cells("ID_NUMLECTOR").Value
        venMM.txtNombre.Text = Me.DTLectores.CurrentRow.Cells("NOMBRE").Value
        venMM.txtApePat.Text = Me.DTLectores.CurrentRow.Cells("A_PATERNO").Value
        venMM.txtApeMat.Text = Me.DTLectores.CurrentRow.Cells("A_MATERNO").Value
        venMM.txtDir.Text = Me.DTLectores.CurrentRow.Cells("DIRECCCION").Value
        venMM.txtEmail.Text = Me.DTLectores.CurrentRow.Cells("EMAIL").Value
        venMM.txtTel.Text = Me.DTLectores.CurrentRow.Cells("TEL").Value

        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_LECTORESTableAdapter.Connection = Conexion
            Me.TBL_LECTORESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LECTORES)
        End If


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If DTLectores.RowCount > 0 Then
            Dim r As String
            r = MsgBox("Esta Seguro de Eliminar El Cliente Seleccionado", MsgBoxStyle.YesNo, "Advertencia")
            If r = "6" Then
                StrSQL = "ProEliminarLector"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@ID_NUMLECTOR", SqlDbType.BigInt).Value = Me.DTLectores.CurrentRow.Cells("ID_NUMLECTOR").Value

                If Conectar() = True Then
                    MsgBox("La Operacion Se Realizo Correctamente", MsgBoxStyle.OkOnly, "")
                    Me.TBL_LECTORESTableAdapter.Connection = Conexion
                    Me.TBL_LECTORESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LECTORES)
                Else
                    MsgBox("Error Al Realizar La Operacion", MsgBoxStyle.Critical, "")
                End If
            End If
        End If
    End Sub
End Class