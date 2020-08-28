<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProductos
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lstProds = New System.Windows.Forms.ListBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdNinguno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(69, 16)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Productos"
        '
        'lstProds
        '
        Me.lstProds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstProds.FormattingEnabled = True
        Me.lstProds.Location = New System.Drawing.Point(6, 19)
        Me.lstProds.Name = "lstProds"
        Me.lstProds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstProds.Size = New System.Drawing.Size(358, 364)
        Me.lstProds.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar.Location = New System.Drawing.Point(52, 405)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(208, 13)
        Me.txtBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'cmdNinguno
        '
        Me.cmdNinguno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNinguno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNinguno.Location = New System.Drawing.Point(311, 394)
        Me.cmdNinguno.Name = "cmdNinguno"
        Me.cmdNinguno.Size = New System.Drawing.Size(53, 24)
        Me.cmdNinguno.TabIndex = 4
        Me.cmdNinguno.Text = "Limpiar"
        Me.cmdNinguno.UseVisualStyleBackColor = True
        '
        'ucProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdNinguno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lstProds)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "ucProductos"
        Me.Size = New System.Drawing.Size(367, 421)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lstProds As ListBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdNinguno As Button
End Class
