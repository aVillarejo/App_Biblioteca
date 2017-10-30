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
        Me.ID_NUMLECTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APATERNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMATERNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXISTEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBLLECTORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSet = New App_Biblioteca.BDDBIBLIOTECADataSet()
        Me.TBL_LECTORESTableAdapter = New App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_LECTORESTableAdapter()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
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
        Me.DTLectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_NUMLECTOR, Me.NOMBREDataGridViewTextBoxColumn, Me.APATERNODataGridViewTextBoxColumn, Me.AMATERNODataGridViewTextBoxColumn, Me.DIRECCCIONDataGridViewTextBoxColumn, Me.TELDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.EXISTEDataGridViewCheckBoxColumn})
        Me.DTLectores.DataSource = Me.TBLLECTORESBindingSource
        Me.DTLectores.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTLectores.Location = New System.Drawing.Point(0, 0)
        Me.DTLectores.Name = "DTLectores"
        Me.DTLectores.ReadOnly = True
        Me.DTLectores.Size = New System.Drawing.Size(1259, 407)
        Me.DTLectores.TabIndex = 0
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
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APATERNODataGridViewTextBoxColumn
        '
        Me.APATERNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.APATERNODataGridViewTextBoxColumn.DataPropertyName = "A_PATERNO"
        Me.APATERNODataGridViewTextBoxColumn.HeaderText = "Apellido Paterno"
        Me.APATERNODataGridViewTextBoxColumn.Name = "APATERNODataGridViewTextBoxColumn"
        Me.APATERNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'AMATERNODataGridViewTextBoxColumn
        '
        Me.AMATERNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AMATERNODataGridViewTextBoxColumn.DataPropertyName = "A_MATERNO"
        Me.AMATERNODataGridViewTextBoxColumn.HeaderText = "Apellido Materno"
        Me.AMATERNODataGridViewTextBoxColumn.Name = "AMATERNODataGridViewTextBoxColumn"
        Me.AMATERNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'DIRECCCIONDataGridViewTextBoxColumn
        '
        Me.DIRECCCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DIRECCCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCCION"
        Me.DIRECCCIONDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DIRECCCIONDataGridViewTextBoxColumn.Name = "DIRECCCIONDataGridViewTextBoxColumn"
        Me.DIRECCCIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELDataGridViewTextBoxColumn
        '
        Me.TELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TELDataGridViewTextBoxColumn.DataPropertyName = "TEL"
        Me.TELDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TELDataGridViewTextBoxColumn.Name = "TELDataGridViewTextBoxColumn"
        Me.TELDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EXISTEDataGridViewCheckBoxColumn
        '
        Me.EXISTEDataGridViewCheckBoxColumn.DataPropertyName = "EXISTE"
        Me.EXISTEDataGridViewCheckBoxColumn.HeaderText = "EXISTE"
        Me.EXISTEDataGridViewCheckBoxColumn.Name = "EXISTEDataGridViewCheckBoxColumn"
        Me.EXISTEDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EXISTEDataGridViewCheckBoxColumn.Visible = False
        '
        'TBLLECTORESBindingSource
        '
        Me.TBLLECTORESBindingSource.DataMember = "TBL_LECTORES"
        Me.TBLLECTORESBindingSource.DataSource = Me.BDDBIBLIOTECADataSetBindingSource
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
        Me.btnEliminar.Location = New System.Drawing.Point(722, 502)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 43)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
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
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APATERNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMATERNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXISTEDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
