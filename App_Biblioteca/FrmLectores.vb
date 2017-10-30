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
            Me.TBL_LECTORESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LECTORES)
        End If

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'Dim venMM As New MM_FrmLectores
        'venMM.ShowDialog()
        Dim venMM As New MM_FrmLectores



        'IDBUSQUEDA = Me.TBL_LECTORES.CurrentRow.Cells("USUID").Value
        'venMM.TextNombre.Text = Me.TBL_LECTORES.CurrentRow.Cells("USUNOMBRE").Value
        'venMM.TxtLogin.Text = Me.TBL_LECTORES.CurrentRow.Cells("USULOGIN").Value
        'venMM.TxtClave.Text = Me.TBL_LECTORES.CurrentRow.Cells("USUCLAVE").Value

        'If Me.TblEmpleados.CurrentRow.Cells("USUTIPO").Value = True Then
        '    venMM.CbTipo.Text = "Administrador"
        'Else
        '    venMM.CbTipo.Text = "Operador"
        'End If

        'If venMM.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Me.TBL_LECTORESTableAdapter.Fill(Me.BDDBIBLIOTECADataSet.TBL_LECTORES)
        'End If



    End Sub
End Class