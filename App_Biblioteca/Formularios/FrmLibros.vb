Public Class FrmLibros

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim venMM As New MM_FrmLibros
        IDBUSQUEDA = 0
        If venMM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TBL_LIBROSTableAdapter.Connection = Conexion
            Me.TBL_LIBROSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LIBROS)
        End If

    End Sub

    Private Sub TBL_LIBROSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TBL_LIBROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDDBIBLIOTECADataSet)

    End Sub

    Private Sub FrmLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDBIBLIOTECADataSet.TBL_LIBROS' Puede moverla o quitarla según sea necesario.
        Me.TBL_LIBROSTableAdapter.Connection = Conexion
        Me.TBL_LIBROSTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LIBROS)
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class