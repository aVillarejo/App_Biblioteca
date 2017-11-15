<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLectores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DTLectores = New System.Windows.Forms.DataGridView()
        Me.TBLLECTORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ID_NUMLECTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_PATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_MATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXISTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BDDBIBLIOTECADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSet = New App_Biblioteca.BDDBIBLIOTECADataSet()
        Me.TBL_LECTORESTableAdapter = New App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_LECTORESTableAdapter()
        CType(Me.DTLectores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLLECTORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDBIBLIOTECADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTLectores
        '
        Me.DTLectores.AllowUserToAddRows = False
        Me.DTLectores.AllowUserToDeleteRows = False
        Me.DTLectores.AllowUserToOrderColumns = True
        Me.DTLectores.AutoGenerateColumns = False
        Me.DTLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTLectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_NUMLECTOR, Me.NOMBRE, Me.A_PATERNO, Me.A_MATERNO, Me.DIRECCCION, Me.TEL, Me.EMAIL, Me.EXISTE})
        Me.DTLectores.DataSource = Me.TBLLECTORESBindingSource
        Me.DTLectores.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTLectores.Location = New System.Drawing.Point(0, 0)
        Me.DTLectores.Name = "DTLectores"
        Me.DTLectores.ReadOnly = True
        Me.DTLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTLectores.Size = New System.Drawing.Size(1259, 407)
        Me.DTLectores.TabIndex = 0
        '
        'TBLLECTORESBindingSource
        '
        Me.TBLLECTORESBindingSource.DataMember = "TBL_LECTORES"
        Me.TBLLECTORESBindingSource.DataSource = Me.BDDBIBLIOTECADataSetBindingSource
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(471, 502)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(95, 43)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(595, 502)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 43)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(713, 502)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 43)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ID_NUMLECTOR
        '
        Me.ID_NUMLECTOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID_NUMLECTOR.DataPropertyName = "ID_NUMLECTOR"
        Me.ID_NUMLECTOR.HeaderText = "ID_NUMLECTOR"
        Me.ID_NUMLECTOR.Name = "ID_NUMLECTOR"
        Me.ID_NUMLECTOR.ReadOnly = True
        Me.ID_NUMLECTOR.Visible = False
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'A_PATERNO
        '
        Me.A_PATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.A_PATERNO.DataPropertyName = "A_PATERNO"
        Me.A_PATERNO.HeaderText = "Apellido Paterno"
        Me.A_PATERNO.Name = "A_PATERNO"
        Me.A_PATERNO.ReadOnly = True
        '
        'A_MATERNO
        '
        Me.A_MATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.A_MATERNO.DataPropertyName = "A_MATERNO"
        Me.A_MATERNO.HeaderText = "Apellido Materno"
        Me.A_MATERNO.Name = "A_MATERNO"
        Me.A_MATERNO.ReadOnly = True
        '
        'DIRECCCION
        '
        Me.DIRECCCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DIRECCCION.DataPropertyName = "DIRECCCION"
        Me.DIRECCCION.HeaderText = "Direccion"
        Me.DIRECCCION.Name = "DIRECCCION"
        Me.DIRECCCION.ReadOnly = True
        '
        'TEL
        '
        Me.TEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TEL.DataPropertyName = "TEL"
        Me.TEL.HeaderText = "Telefono"
        Me.TEL.Name = "TEL"
        Me.TEL.ReadOnly = True
        '
        'EMAIL
        '
        Me.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "Email"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'EXISTE
        '
        Me.EXISTE.DataPropertyName = "EXISTE"
        Me.EXISTE.HeaderText = "EXISTE"
        Me.EXISTE.Name = "EXISTE"
        Me.EXISTE.ReadOnly = True
        Me.EXISTE.Visible = False
        '
        'BDDBIBLIOTECADataSetBindingSource
        '
        Me.BDDBIBLIOTECADataSetBindingSource.DataSource = Me.BDDBIBLIOTECADataSet
        Me.BDDBIBLIOTECADataSetBindingSource.Position = 0
        '
        'BDDBIBLIOTECADataSet
        '
        Me.BDDBIBLIOTECADataSet.DataSetName = "BDDBIBLIOTECADataSet"
        Me.BDDBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_LECTORESTableAdapter
        '
        Me.TBL_LECTORESTableAdapter.ClearBeforeFill = True
        '
        'FrmLectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 627)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DTLectores)
        Me.Name = "FrmLectores"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLectores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DTLectores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLLECTORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDBIBLIOTECADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTLectores As System.Windows.Forms.DataGridView
    Friend WithEvents BDDBIBLIOTECADataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDDBIBLIOTECADataSet As App_Biblioteca.BDDBIBLIOTECADataSet
    Friend WithEvents TBLLECTORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_LECTORESTableAdapter As App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_LECTORESTableAdapter
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents ID_NUMLECTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_PATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_MATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXISTE As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
