<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Me.DTUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ID_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_PATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A_MATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOGIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUTIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXISTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBLUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDDBIBLIOTECADataSet = New App_Biblioteca.BDDBIBLIOTECADataSet()
        Me.TBL_USUARIOSTableAdapter = New App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_USUARIOSTableAdapter()
        CType(Me.DTUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTUsuarios
        '
        Me.DTUsuarios.AutoGenerateColumns = False
        Me.DTUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_USUARIO, Me.NOMBRE, Me.A_PATERNO, Me.A_MATERNO, Me.DIRECCCION, Me.TEL, Me.EMAIL, Me.LOGIN, Me.PASSWORD, Me.USUTIPO, Me.EXISTE})
        Me.DTUsuarios.DataSource = Me.TBLUSUARIOSBindingSource
        Me.DTUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.DTUsuarios.Name = "DTUsuarios"
        Me.DTUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTUsuarios.Size = New System.Drawing.Size(1247, 287)
        Me.DTUsuarios.TabIndex = 0
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(337, 501)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(455, 501)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(699, 501)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(582, 501)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ID_USUARIO
        '
        Me.ID_USUARIO.DataPropertyName = "ID_USUARIO"
        Me.ID_USUARIO.HeaderText = "ID_USUARIO"
        Me.ID_USUARIO.Name = "ID_USUARIO"
        Me.ID_USUARIO.ReadOnly = True
        Me.ID_USUARIO.Visible = False
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'A_PATERNO
        '
        Me.A_PATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.A_PATERNO.DataPropertyName = "A_PATERNO"
        Me.A_PATERNO.HeaderText = "A_PATERNO"
        Me.A_PATERNO.Name = "A_PATERNO"
        '
        'A_MATERNO
        '
        Me.A_MATERNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.A_MATERNO.DataPropertyName = "A_MATERNO"
        Me.A_MATERNO.HeaderText = "A_MATERNO"
        Me.A_MATERNO.Name = "A_MATERNO"
        '
        'DIRECCCION
        '
        Me.DIRECCCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DIRECCCION.DataPropertyName = "DIRECCCION"
        Me.DIRECCCION.HeaderText = "DIRECCCION"
        Me.DIRECCCION.Name = "DIRECCCION"
        '
        'TEL
        '
        Me.TEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TEL.DataPropertyName = "TEL"
        Me.TEL.HeaderText = "TEL"
        Me.TEL.Name = "TEL"
        '
        'EMAIL
        '
        Me.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EMAIL.DataPropertyName = "EMAIL"
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.Name = "EMAIL"
        '
        'LOGIN
        '
        Me.LOGIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LOGIN.DataPropertyName = "LOGIN"
        Me.LOGIN.HeaderText = "LOGIN"
        Me.LOGIN.Name = "LOGIN"
        '
        'PASSWORD
        '
        Me.PASSWORD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PASSWORD.DataPropertyName = "PASSWORD"
        Me.PASSWORD.HeaderText = "PASSWORD"
        Me.PASSWORD.Name = "PASSWORD"
        '
        'USUTIPO
        '
        Me.USUTIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.USUTIPO.DataPropertyName = "USUTIPO"
        Me.USUTIPO.HeaderText = "USUTIPO"
        Me.USUTIPO.Name = "USUTIPO"
        '
        'EXISTE
        '
        Me.EXISTE.DataPropertyName = "EXISTE"
        Me.EXISTE.HeaderText = "EXISTE"
        Me.EXISTE.Name = "EXISTE"
        Me.EXISTE.Visible = False
        '
        'TBLUSUARIOSBindingSource
        '
        Me.TBLUSUARIOSBindingSource.DataMember = "TBL_USUARIOS"
        Me.TBLUSUARIOSBindingSource.DataSource = Me.BDDBIBLIOTECADataSet
        '
        'BDDBIBLIOTECADataSet
        '
        Me.BDDBIBLIOTECADataSet.DataSetName = "BDDBIBLIOTECADataSet"
        Me.BDDBIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_USUARIOSTableAdapter
        '
        Me.TBL_USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 627)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DTUsuarios)
        Me.Name = "FrmUsuarios"
        Me.ShowInTaskbar = False
        Me.Text = "FrmUsuarios"
        CType(Me.DTUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDDBIBLIOTECADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents BDDBIBLIOTECADataSet As App_Biblioteca.BDDBIBLIOTECADataSet
    Friend WithEvents TBLUSUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_USUARIOSTableAdapter As App_Biblioteca.BDDBIBLIOTECADataSetTableAdapters.TBL_USUARIOSTableAdapter
    Friend WithEvents ID_USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_PATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_MATERNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOGIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSWORD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUTIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXISTE As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
