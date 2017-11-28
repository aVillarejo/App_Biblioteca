<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategorias
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
        Me.DTCategorias = New System.Windows.Forms.DataGridView()
        Me.TBLCATEGORIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSet = New App_Biblioteca.BDDBIBLIOTECADataSet()
        Me.TBL_CATEGORIASTableAdapter = New App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_CATEGORIASTableAdapter()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ID_CATEGORIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExisteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DTCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTCategorias
        '
        Me.DTCategorias.AutoGenerateColumns = False
        Me.DTCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_CATEGORIA, Me.NOMBRE, Me.DESCRIPCION, Me.ExisteDataGridViewCheckBoxColumn})
        Me.DTCategorias.DataSource = Me.TBLCATEGORIASBindingSource
        Me.DTCategorias.Location = New System.Drawing.Point(44, 38)
        Me.DTCategorias.Name = "DTCategorias"
        Me.DTCategorias.RowHeadersVisible = False
        Me.DTCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTCategorias.Size = New System.Drawing.Size(1135, 244)
        Me.DTCategorias.TabIndex = 0
        '
        'TBLCATEGORIASBindingSource
        '
        Me.TBLCATEGORIASBindingSource.DataMember = "TBL_CATEGORIAS"
        Me.TBLCATEGORIASBindingSource.DataSource = Me.BDDBIBLIOTECADataSet
        '
        'BDDBIBLIOTECADataSet
        '
        Me.BDDBIBLIOTECADataSet.DataSetName = "BDDBIBLIOTECADataSet"
        Me.BDDBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_CATEGORIASTableAdapter
        '
        Me.TBL_CATEGORIASTableAdapter.ClearBeforeFill = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(398, 412)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(95, 43)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(532, 412)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 43)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(796, 412)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 43)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(662, 412)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 43)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ID_CATEGORIA
        '
        Me.ID_CATEGORIA.DataPropertyName = "ID_CATEGORIA"
        Me.ID_CATEGORIA.HeaderText = "ID_CATEGORIA"
        Me.ID_CATEGORIA.Name = "ID_CATEGORIA"
        Me.ID_CATEGORIA.ReadOnly = True
        Me.ID_CATEGORIA.Visible = False
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE.DataPropertyName = "Nombre"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESCRIPCION.DataPropertyName = "Descripcion"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'ExisteDataGridViewCheckBoxColumn
        '
        Me.ExisteDataGridViewCheckBoxColumn.DataPropertyName = "Existe"
        Me.ExisteDataGridViewCheckBoxColumn.HeaderText = "Existe"
        Me.ExisteDataGridViewCheckBoxColumn.Name = "ExisteDataGridViewCheckBoxColumn"
        Me.ExisteDataGridViewCheckBoxColumn.Visible = False
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 627)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DTCategorias)
        Me.Name = "FrmCategorias"
        Me.Text = "FrmCategorias"
        CType(Me.DTCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCATEGORIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents BDDBIBLIOTECADataSet As App_Biblioteca.BDDBIBLIOTECADataSet
    Friend WithEvents TBLCATEGORIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_CATEGORIASTableAdapter As App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_CATEGORIASTableAdapter
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents ID_CATEGORIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExisteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
