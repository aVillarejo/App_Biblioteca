Public Class FrmEditoriales

    Private Sub MM_FrmEditoriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_EDITORIALES' Puede moverla o quitarla según sea necesario.
        Me.TBL_EDITORIALESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_EDITORIALES)

    End Sub
End Class