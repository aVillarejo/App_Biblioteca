<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditoriales
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
        Me.DTEditoriales = New System.Windows.Forms.DataGridView()
        Me.IDEDITORIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existe = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBLEDITORIALESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSet = New App_Biblioteca.BDDBIBLIOTECADataSet()
        Me.TBL_EDITORIALESTableAdapter = New App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_EDITORIALESTableAdapter()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.DTEditoriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLEDITORIALESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTEditoriales
        '
        Me.DTEditoriales.AllowUserToAddRows = False
        Me.DTEditoriales.AllowUserToDeleteRows = False
        Me.DTEditoriales.AllowUserToOrderColumns = True
        Me.DTEditoriales.AutoGenerateColumns = False
        Me.DTEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTEditoriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDEDITORIALDataGridViewTextBoxColumn, Me.Nombre, Me.Direccion, Me.Email, Me.Telefono, Me.Existe})
        Me.DTEditoriales.DataSource = Me.TBLEDITORIALESBindingSource
        Me.DTEditoriales.Location = New System.Drawing.Point(12, 12)
        Me.DTEditoriales.Name = "DTEditoriales"
        Me.DTEditoriales.ReadOnly = True
        Me.DTEditoriales.Size = New System.Drawing.Size(1074, 394)
        Me.DTEditoriales.TabIndex = 0
        '
        'IDEDITORIALDataGridViewTextBoxColumn
        '
        Me.IDEDITORIALDataGridViewTextBoxColumn.DataPropertyName = "ID_EDITORIAL"
        Me.IDEDITORIALDataGridViewTextBoxColumn.HeaderText = "ID_EDITORIAL"
        Me.IDEDITORIALDataGridViewTextBoxColumn.Name = "IDEDITORIALDataGridViewTextBoxColumn"
        Me.IDEDITORIALDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDEDITORIALDataGridViewTextBoxColumn.Visible = False
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Tel"
        Me.Telefono.HeaderText = "Tel"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Existe
        '
        Me.Existe.DataPropertyName = "Existe"
        Me.Existe.HeaderText = "Existe"
        Me.Existe.Name = "Existe"
        Me.Existe.ReadOnly = True
        Me.Existe.Visible = False
        '
        'TBLEDITORIALESBindingSource
        '
        Me.TBLEDITORIALESBindingSource.DataMember = "TBL_EDITORIALES"
        Me.TBLEDITORIALESBindingSource.DataSource = Me.BDDBIBLIOTECADataSet
        '
        'BDDBIBLIOTECADataSet
        '
        Me.BDDBIBLIOTECADataSet.DataSetName = "BDDBIBLIOTECADataSet"
        Me.BDDBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_EDITORIALESTableAdapter
        '
        Me.TBL_EDITORIALESTableAdapter.ClearBeforeFill = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(551, 476)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 43)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(433, 476)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 43)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(309, 476)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(95, 43)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'FrmEditoriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 624)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DTEditoriales)
        Me.Name = "FrmEditoriales"
        Me.Text = "FrmEditoriales"
        CType(Me.DTEditoriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLEDITORIALESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTEditoriales As System.Windows.Forms.DataGridView
    Friend WithEvents BDDBIBLIOTECADataSet As App_Biblioteca.BDDBIBLIOTECADataSet
    Friend WithEvents TBLEDITORIALESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_EDITORIALESTableAdapter As App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_EDITORIALESTableAdapter
    Friend WithEvents IDEDITORIALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existe As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
