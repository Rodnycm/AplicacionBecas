<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlListarYBuscarUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UctrlListarYBuscarUsuario))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Identificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PbUsuarios = New System.Windows.Forms.PictureBox()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(31, 158)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 29)
        Me.txtBuscar.TabIndex = 20
        Me.txtBuscar.Text = "Buscar:"
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackgroundImage = CType(resources.GetObject("btnCrearUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.btnCrearUsuario.Location = New System.Drawing.Point(783, 108)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearUsuario.TabIndex = 21
        Me.btnCrearUsuario.Text = "Crear Usuario"
        Me.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearUsuario.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificación, Me.Nombre, Me.RolAsignado, Me.opciones})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgUsuarios.GridColor = System.Drawing.Color.White
        Me.dgUsuarios.Location = New System.Drawing.Point(30, 234)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgUsuarios.RowHeadersVisible = False
        Me.dgUsuarios.Size = New System.Drawing.Size(947, 271)
        Me.dgUsuarios.TabIndex = 22
        '
        'Identificación
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Identificación.DefaultCellStyle = DataGridViewCellStyle9
        Me.Identificación.FillWeight = 101.7639!
        Me.Identificación.HeaderText = "Identificación"
        Me.Identificación.Name = "Identificación"
        '
        'Nombre
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle10
        Me.Nombre.FillWeight = 271.8829!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'RolAsignado
        '
        Me.RolAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RolAsignado.DefaultCellStyle = DataGridViewCellStyle11
        Me.RolAsignado.HeaderText = "Rol Asignado"
        Me.RolAsignado.Name = "RolAsignado"
        Me.RolAsignado.Width = 99
        '
        'opciones
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opciones.DefaultCellStyle = DataGridViewCellStyle12
        Me.opciones.FillWeight = 126.3532!
        Me.opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opciones.HeaderText = "Opciones"
        Me.opciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.opciones.Name = "opciones"
        Me.opciones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.opciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PbUsuarios
        '
        Me.PbUsuarios.BackgroundImage = CType(resources.GetObject("PbUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.PbUsuarios.ErrorImage = CType(resources.GetObject("PbUsuarios.ErrorImage"), System.Drawing.Image)
        Me.PbUsuarios.Image = CType(resources.GetObject("PbUsuarios.Image"), System.Drawing.Image)
        Me.PbUsuarios.Location = New System.Drawing.Point(30, 202)
        Me.PbUsuarios.Name = "PbUsuarios"
        Me.PbUsuarios.Size = New System.Drawing.Size(975, 321)
        Me.PbUsuarios.TabIndex = 23
        Me.PbUsuarios.TabStop = False
        '
        'UctrlListarYBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PbUsuarios)
        Me.Name = "UctrlListarYBuscarUsuario"
        Me.Size = New System.Drawing.Size(1032, 642)
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnCrearUsuario As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Identificación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PbUsuarios As System.Windows.Forms.PictureBox

End Class
