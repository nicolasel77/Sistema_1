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
        Me.tabSeleccion = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstSemanas = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstMes = New System.Windows.Forms.ListBox()
        Me.lstAñoMes = New System.Windows.Forms.ListBox()
        Me.lstAño = New System.Windows.Forms.ListBox()
        Me.tabSeleccion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
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
        Me.mntFecha.Location = New System.Drawing.Point(0, -1)
        Me.mntFecha.Name = "mntFecha"
        Me.mntFecha.TabIndex = 2
        '
        'tabSeleccion
        '
        Me.tabSeleccion.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabSeleccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSeleccion.Controls.Add(Me.TabPage1)
        Me.tabSeleccion.Controls.Add(Me.TabPage2)
        Me.tabSeleccion.Controls.Add(Me.TabPage3)
        Me.tabSeleccion.Controls.Add(Me.TabPage4)
        Me.tabSeleccion.Controls.Add(Me.TabPage5)
        Me.tabSeleccion.Location = New System.Drawing.Point(6, 23)
        Me.tabSeleccion.Multiline = True
        Me.tabSeleccion.Name = "tabSeleccion"
        Me.tabSeleccion.SelectedIndex = 0
        Me.tabSeleccion.Size = New System.Drawing.Size(234, 192)
        Me.tabSeleccion.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.mntFecha)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(226, 166)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fecha"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.lstSemanas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(229, 166)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Semana"
        '
        'lstSemanas
        '
        Me.lstSemanas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSemanas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSemanas.FormattingEnabled = True
        Me.lstSemanas.Location = New System.Drawing.Point(3, 3)
        Me.lstSemanas.Name = "lstSemanas"
        Me.lstSemanas.Size = New System.Drawing.Size(223, 160)
        Me.lstSemanas.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstAñoMes)
        Me.TabPage3.Controls.Add(Me.lstMes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(226, 166)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lstAño)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(226, 166)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Año"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.dtHasta)
        Me.TabPage5.Controls.Add(Me.dtDesde)
        Me.TabPage5.Location = New System.Drawing.Point(4, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(229, 166)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "D-H"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(6, 16)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(110, 20)
        Me.dtDesde.TabIndex = 0
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(6, 55)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(110, 20)
        Me.dtHasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        '
        'lstMes
        '
        Me.lstMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstMes.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstMes.FormattingEnabled = True
        Me.lstMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.lstMes.Location = New System.Drawing.Point(0, 0)
        Me.lstMes.Name = "lstMes"
        Me.lstMes.Size = New System.Drawing.Size(106, 166)
        Me.lstMes.TabIndex = 1
        '
        'lstAñoMes
        '
        Me.lstAñoMes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAñoMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAñoMes.FormattingEnabled = True
        Me.lstAñoMes.Location = New System.Drawing.Point(112, 0)
        Me.lstAñoMes.Name = "lstAñoMes"
        Me.lstAñoMes.Size = New System.Drawing.Size(106, 156)
        Me.lstAñoMes.TabIndex = 1
        '
        'lstAño
        '
        Me.lstAño.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAño.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAño.FormattingEnabled = True
        Me.lstAño.Location = New System.Drawing.Point(0, 0)
        Me.lstAño.Name = "lstAño"
        Me.lstAño.Size = New System.Drawing.Size(226, 166)
        Me.lstAño.TabIndex = 2
        '
        'ucFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabSeleccion)
        Me.Controls.Add(Me.chDevolver)
        Me.Controls.Add(Me.lblSeleccion)
        Me.Name = "ucFecha"
        Me.Size = New System.Drawing.Size(243, 215)
        Me.tabSeleccion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeleccion As Label
    Friend WithEvents chDevolver As CheckBox
    Friend WithEvents mntFecha As MonthCalendar
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstSemanas As ListBox
    Private WithEvents tabSeleccion As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtHasta As DateTimePicker
    Friend WithEvents dtDesde As DateTimePicker
    Friend WithEvents lstAñoMes As ListBox
    Friend WithEvents lstMes As ListBox
    Friend WithEvents lstAño As ListBox
End Class
