<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeusChamados
	Inherits MetroFramework.Forms.MetroForm

	'Descartar substituições de formulário para limpar a lista de componentes.
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

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.gridChamadosAbertos = New MetroFramework.Controls.MetroGrid()
		Me.btnAlterar = New MetroFramework.Controls.MetroButton()
		Me.btnExcluir = New MetroFramework.Controls.MetroButton()
		Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.GroupBox1.SuspendLayout()
		CType(Me.gridChamadosAbertos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.gridChamadosAbertos)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.GroupBox1.Location = New System.Drawing.Point(6, 63)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(802, 502)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Chamados Abertos"
		'
		'gridChamadosAbertos
		'
		Me.gridChamadosAbertos.AllowUserToResizeRows = False
		Me.gridChamadosAbertos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamadosAbertos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.gridChamadosAbertos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.gridChamadosAbertos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamadosAbertos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.gridChamadosAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.gridChamadosAbertos.DefaultCellStyle = DataGridViewCellStyle2
		Me.gridChamadosAbertos.EnableHeadersVisualStyles = False
		Me.gridChamadosAbertos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.gridChamadosAbertos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamadosAbertos.Location = New System.Drawing.Point(7, 19)
		Me.gridChamadosAbertos.Name = "gridChamadosAbertos"
		Me.gridChamadosAbertos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamadosAbertos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.gridChamadosAbertos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.gridChamadosAbertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridChamadosAbertos.Size = New System.Drawing.Size(789, 466)
		Me.gridChamadosAbertos.TabIndex = 0
		'
		'btnAlterar
		'
		Me.btnAlterar.Location = New System.Drawing.Point(815, 112)
		Me.btnAlterar.Name = "btnAlterar"
		Me.btnAlterar.Size = New System.Drawing.Size(247, 79)
		Me.btnAlterar.TabIndex = 1
		Me.btnAlterar.Text = "Alterar"
		Me.btnAlterar.UseSelectable = True
		'
		'btnExcluir
		'
		Me.btnExcluir.Location = New System.Drawing.Point(815, 229)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(247, 79)
		Me.btnExcluir.TabIndex = 2
		Me.btnExcluir.Text = "Excluir"
		Me.btnExcluir.UseSelectable = True
		'
		'MetroTile1
		'
		Me.MetroTile1.ActiveControl = Nothing
		Me.MetroTile1.Location = New System.Drawing.Point(888, 7)
		Me.MetroTile1.Name = "MetroTile1"
		Me.MetroTile1.Size = New System.Drawing.Size(75, 73)
		Me.MetroTile1.TabIndex = 3
		Me.MetroTile1.Text = "MetroTile1"
		Me.MetroTile1.UseSelectable = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(801, 7)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
		Me.MetroLabel1.TabIndex = 5
		Me.MetroLabel1.Text = "MetroLabel1"
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(6, 18)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(53, 39)
		Me.MetroLink1.TabIndex = 16
		Me.MetroLink1.UseSelectable = True
		'
		'MeusChamados
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1073, 571)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.MetroTile1)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.btnAlterar)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "MeusChamados"
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "     MeusChamados"
		Me.Theme = MetroFramework.MetroThemeStyle.[Default]
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.gridChamadosAbertos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents gridChamadosAbertos As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnAlterar As MetroFramework.Controls.MetroButton
	Friend WithEvents btnExcluir As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
End Class
