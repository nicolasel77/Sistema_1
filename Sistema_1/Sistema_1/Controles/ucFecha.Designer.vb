<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFecha
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
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.chDevolver = New System.Windows.Forms.CheckBox()
        Me.mntFecha = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'lblSeleccion
        '
        Me.lblSeleccion.AutoSize = True
        Me.lblSeleccion.Location = New System.Drawing.Point(3, 191)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(0, 13)
        Me.lblSeleccion.TabIndex = 0
        '
        'chDevolver
        '
        Me.chDevolver.AutoSize = True
        Me.chDevolver.Checked = True
        Me.chDevolver.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chDevolver.Location = New System.Drawing.Point(3, 0)
        Me.chDevolver.Name = "chDevolver"
        Me.chDevolver.Size = New System.Drawing.Size(54, 17)
        Me.chDevolver.TabIndex = 1
        Me.chDevolver.Text = "Fecha"
        Me.chDevolver.UseVisualStyleBackColor = True
        '
        'mntFecha
        '
        Me.mntFecha.Location = New System.Drawing.Point(3, 20)
        Me.mntFecha.Name = "mntFecha"
        Me.mntFecha.TabIndex = 2
        '
        'ucFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mntFecha)
        Me.Controls.Add(Me.chDevolver)
        Me.Controls.Add(Me.lblSeleccion)
        Me.Name = "ucFecha"
        Me.Size = New System.Drawing.Size(201, 215)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeleccion As Label
    Friend WithEvents chDevolver As CheckBox
    Friend WithEvents mntFecha As MonthCalendar
End Class
