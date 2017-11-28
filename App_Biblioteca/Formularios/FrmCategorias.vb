Public Class FrmCategorias

    Private Sub FrmCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_CATEGORIAS' Puede moverla o quitarla según sea necesario.
        Me.TBL_CATEGORIASTableAdapter.Connection = Conexion
        Me.TBL_CATEGORIASTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_CATEGORIAS)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim venMM As New MM_FrmCategorias
        IDBUSQUEDA = 0
        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_CATEGORIASTableAdapter.Connection = Conexion
            Me.TBL_CATEGORIASTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_CATEGORIAS)
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim venMM As New MM_FrmCategorias

        IDBUSQUEDA = Me.DTCategorias.CurrentRow.Cells("ID_CATEGORIA").Value
        venMM.txtNombre.Text = Me.DTCategorias.CurrentRow.Cells("NOMBRE").Value
        venMM.txtDescripcion.Text = Me.DTCategorias.CurrentRow.Cells("DESCRIPCION").Value

        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_CATEGORIASTableAdapter.Connection = Conexion
            Me.TBL_CATEGORIASTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_CATEGORIAS)
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If DTCategorias.RowCount > 0 Then
            Dim r As String
            r = MsgBox("Esta Seguro de Eliminar la Categoria Seleccionado", MsgBoxStyle.YesNo, "Advertencia")
            If r = "6" Then
                StrSQL = "ProEliminarCategoria"
                comando = New SqlClient.SqlCommand(StrSQL, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@ID_CATEGORIA", SqlDbType.BigInt).Value = Me.DTCategorias.CurrentRow.Cells("ID_CATEGORIA").Value

                If Conectar() = True Then
                    MsgBox("La Operacion Se Realizo Correctamente", MsgBoxStyle.OkOnly, "")
                    Me.TBL_CATEGORIASTableAdapter.Connection = Conexion
                    Me.TBL_CATEGORIASTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_CATEGORIAS)
                Else
                    MsgBox("Error Al Realizar La Operacion", MsgBoxStyle.Critical, "")
                End If
            End If
        End If
    End Sub
End Class
