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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ucFecha = New Sistema_1.ucFecha()
        Me.cmdFiltro = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblRegistros = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdStock
        '
        Me.grdStock.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdStock.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdStock.AutoResize = False
        Me.grdStock.bColor = System.Drawing.SystemColors.Window
        Me.grdStock.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdStock.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdStock.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdStock.Col = 0
        Me.grdStock.Cols = 10
        Me.grdStock.DataMember = ""
        Me.grdStock.DataSource = Nothing
        Me.grdStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdStock.EnableEdicion = True
        Me.grdStock.Encabezado = ""
        Me.grdStock.fColor = System.Drawing.SystemColors.Control
        Me.grdStock.FixCols = 0
        Me.grdStock.FixRows = 0
        Me.grdStock.FuenteEncabezado = Nothing
        Me.grdStock.FuentePieDePagina = Nothing
        Me.grdStock.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdStock.Location = New System.Drawing.Point(0, 0)
        Me.grdStock.MenuActivado = False
        Me.grdStock.Name = "grdStock"
        Me.grdStock.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdStock.PintarFilaSel = True
        Me.grdStock.Redraw = True
        Me.grdStock.Row = 0
        Me.grdStock.Rows = 50
        Me.grdStock.Size = New System.Drawing.Size(618, 637)
        Me.grdStock.TabIndex = 0
        '
        'txtBuscador
        '
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscador.Location = New System.Drawing.Point(108, 228)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(93, 13)
        Me.txtBuscador.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscador general:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdStock)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.ucFecha)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdFiltro)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBuscador)
        Me.SplitContainer1.Size = New System.Drawing.Size(902, 639)
        Me.SplitContainer1.SplitterDistance = 620
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 4
        '
        'ucFecha
        '
        Me.ucFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucFecha.Location = New System.Drawing.Point(3, 3)
        Me.ucFecha.Name = "ucFecha"
        Me.ucFecha.Size = New System.Drawing.Size(266, 219)
        Me.ucFecha.TabIndex = 6
        '
        'cmdFiltro
        '
        Me.cmdFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFiltro.Location = New System.Drawing.Point(9, 247)
        Me.cmdFiltro.Name = "cmdFiltro"
        Me.cmdFiltro.Size = New System.Drawing.Size(192, 23)
        Me.cmdFiltro.TabIndex = 5
        Me.cmdFiltro.Text = "Filtrar"
        Me.cmdFiltro.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblRegistros})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 654)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(926, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblRegistros
        '
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(55, 17)
        Me.lblRegistros.Text = "Registros"
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 676)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents grdStock As Grilla2.SpeedGrilla
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblRegistros As ToolStripStatusLabel
    Friend WithEvents cmdFiltro As Button
    Friend WithEvents ucFecha As ucFecha
End Class
