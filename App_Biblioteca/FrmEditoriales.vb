Public Class FrmEditoriales

    Private Sub MM_FrmEditoriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_EDITORIALES' Puede moverla o quitarla según sea necesario.
        Me.TBL_EDITORIALESTableAdapter.Connection = Conexion
        Me.TBL_EDITORIALESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_EDITORIALES)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim venMM As New MM_FrmEditoriales
        IDBUSQUEDA = 0
        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_EDITORIALESTableAdapter.Connection = Conexion
            Me.TBL_EDITORIALESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_EDITORIALES)
        End If
    End Sub
End Class