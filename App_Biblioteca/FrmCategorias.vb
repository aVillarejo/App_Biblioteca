Public Class FrmCategorias

    Private Sub FrmCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_CATEGORIAS' Puede moverla o quitarla según sea necesario.
        Me.TBL_CATEGORIASTableAdapter.Connection = Conexion
        Me.TBL_CATEGORIASTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_CATEGORIAS)
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
End Class