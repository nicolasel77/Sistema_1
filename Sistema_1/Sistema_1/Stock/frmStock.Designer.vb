<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.grdStock = New Grilla2.SpeedGrilla()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UcFecha1 = New Sistema_1.ucFecha()
        Me.SuspendLayout()
        '
        'grdStock
        '
        Me.grdStock.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdStock.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStock.AutoResize = False
        Me.grdStock.bColor = System.Drawing.SystemColors.Window
        Me.grdStock.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdStock.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdStock.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdStock.Col = 0
        Me.grdStock.Cols = 10
        Me.grdStock.DataMember = ""
        Me.grdStock.DataSource = Nothing
        Me.grdStock.EnableEdicion = True
        Me.grdStock.Encabezado = ""
        Me.grdStock.fColor = System.Drawing.SystemColors.Control
        Me.grdStock.FixCols = 0
        Me.grdStock.FixRows = 0
        Me.grdStock.FuenteEncabezado = Nothing
        Me.grdStock.FuentePieDePagina = Nothing
        Me.grdStock.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdStock.Location = New System.Drawing.Point(12, 12)
        Me.grdStock.MenuActivado = False
        Me.grdStock.Name = "grdStock"
        Me.grdStock.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdStock.PintarFilaSel = True
        Me.grdStock.Redraw = True
        Me.grdStock.Row = 0
        Me.grdStock.Rows = 50
        Me.grdStock.Size = New System.Drawing.Size(604, 597)
        Me.grdStock.TabIndex = 0
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscador.Location = New System.Drawing.Point(736, 596)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(161, 13)
        Me.txtBuscador.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(637, 596)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscador general:"
        '
        'UcFecha1
        '
        Me.UcFecha1.Location = New System.Drawing.Point(761, 21)
        Me.UcFecha1.Name = "UcFecha1"
        Me.UcFecha1.Size = New System.Drawing.Size(136, 124)
        Me.UcFecha1.TabIndex = 3
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 621)
        Me.Controls.Add(Me.UcFecha1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.grdStock)
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents grdStock As Grilla2.SpeedGrilla
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UcFecha1 As ucFecha
End Class
