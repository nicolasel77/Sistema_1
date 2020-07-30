<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.grdProductos = New Grilla2.SpeedGrilla()
        Me.txtTecla = New System.Windows.Forms.TextBox()
        Me.lblTecla = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grdProductos
        '
        Me.grdProductos.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdProductos.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProductos.AutoResize = False
        Me.grdProductos.bColor = System.Drawing.SystemColors.Window
        Me.grdProductos.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdProductos.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdProductos.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdProductos.Col = 0
        Me.grdProductos.Cols = 10
        Me.grdProductos.DataMember = ""
        Me.grdProductos.DataSource = Nothing
        Me.grdProductos.EnableEdicion = True
        Me.grdProductos.Encabezado = ""
        Me.grdProductos.fColor = System.Drawing.SystemColors.Control
        Me.grdProductos.FixCols = 0
        Me.grdProductos.FixRows = 0
        Me.grdProductos.FuenteEncabezado = Nothing
        Me.grdProductos.FuentePieDePagina = Nothing
        Me.grdProductos.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdProductos.Location = New System.Drawing.Point(12, 12)
        Me.grdProductos.MenuActivado = False
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdProductos.PintarFilaSel = True
        Me.grdProductos.Redraw = True
        Me.grdProductos.Row = 0
        Me.grdProductos.Rows = 50
        Me.grdProductos.Size = New System.Drawing.Size(885, 571)
        Me.grdProductos.TabIndex = 0
        '
        'txtTecla
        '
        Me.txtTecla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTecla.Location = New System.Drawing.Point(12, 589)
        Me.txtTecla.Name = "txtTecla"
        Me.txtTecla.Size = New System.Drawing.Size(100, 20)
        Me.txtTecla.TabIndex = 1
        '
        'lblTecla
        '
        Me.lblTecla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTecla.AutoSize = True
        Me.lblTecla.Location = New System.Drawing.Point(118, 592)
        Me.lblTecla.Name = "lblTecla"
        Me.lblTecla.Size = New System.Drawing.Size(39, 13)
        Me.lblTecla.TabIndex = 2
        Me.lblTecla.Text = "Label1"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 621)
        Me.Controls.Add(Me.lblTecla)
        Me.Controls.Add(Me.txtTecla)
        Me.Controls.Add(Me.grdProductos)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents grdProductos As Grilla2.SpeedGrilla
    Friend WithEvents txtTecla As TextBox
    Friend WithEvents lblTecla As Label
End Class
