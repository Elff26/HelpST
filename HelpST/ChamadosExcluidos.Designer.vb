﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChamadosExcluidos
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
		Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.cbPc = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.cbSalas = New MetroFramework.Controls.MetroComboBox()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.gridChamadosExcluidos = New MetroFramework.Controls.MetroGrid()
		Me.GroupBox1.SuspendLayout()
		CType(Me.gridChamadosExcluidos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.MetroComboBox3)
		Me.GroupBox1.Controls.Add(Me.MetroLabel3)
		Me.GroupBox1.Controls.Add(Me.cbPc)
		Me.GroupBox1.Controls.Add(Me.MetroLabel2)
		Me.GroupBox1.Controls.Add(Me.cbSalas)
		Me.GroupBox1.Controls.Add(Me.MetroLabel1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.GroupBox1.Location = New System.Drawing.Point(0, 78)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1079, 57)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Selecione:"
		'
		'MetroComboBox3
		'
		Me.MetroComboBox3.FormattingEnabled = True
		Me.MetroComboBox3.ItemHeight = 23
		Me.MetroComboBox3.Location = New System.Drawing.Point(400, 22)
		Me.MetroComboBox3.Name = "MetroComboBox3"
		Me.MetroComboBox3.Size = New System.Drawing.Size(121, 29)
		Me.MetroComboBox3.TabIndex = 5
		Me.MetroComboBox3.UseSelectable = True
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(338, 32)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(56, 19)
		Me.MetroLabel3.TabIndex = 4
		Me.MetroLabel3.Text = "Usuario:"
		'
		'cbPc
		'
		Me.cbPc.FormattingEnabled = True
		Me.cbPc.ItemHeight = 23
		Me.cbPc.Location = New System.Drawing.Point(211, 22)
		Me.cbPc.Name = "cbPc"
		Me.cbPc.Size = New System.Drawing.Size(121, 29)
		Me.cbPc.TabIndex = 3
		Me.cbPc.UseSelectable = True
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(176, 32)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(29, 19)
		Me.MetroLabel2.TabIndex = 2
		Me.MetroLabel2.Text = "PC:"
		'
		'cbSalas
		'
		Me.cbSalas.FormattingEnabled = True
		Me.cbSalas.ItemHeight = 23
		Me.cbSalas.Location = New System.Drawing.Point(49, 22)
		Me.cbSalas.Name = "cbSalas"
		Me.cbSalas.Size = New System.Drawing.Size(121, 29)
		Me.cbSalas.TabIndex = 1
		Me.cbSalas.UseSelectable = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(7, 32)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(36, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Sala:"
		'
		'MetroTile2
		'
		Me.MetroTile2.ActiveControl = Nothing
		Me.MetroTile2.Location = New System.Drawing.Point(884, 13)
		Me.MetroTile2.Name = "MetroTile2"
		Me.MetroTile2.Size = New System.Drawing.Size(75, 67)
		Me.MetroTile2.TabIndex = 4
		Me.MetroTile2.Text = "MetroTile2"
		Me.MetroTile2.UseSelectable = True
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(795, 13)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(83, 19)
		Me.MetroLabel4.TabIndex = 5
		Me.MetroLabel4.Text = "MetroLabel4"
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(0, 13)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(44, 48)
		Me.MetroLink1.TabIndex = 7
		Me.MetroLink1.UseSelectable = True
		'
		'gridChamadosExcluidos
		'
		Me.gridChamadosExcluidos.AllowUserToResizeRows = False
		Me.gridChamadosExcluidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gridChamadosExcluidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamadosExcluidos.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.gridChamadosExcluidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.gridChamadosExcluidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamadosExcluidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.gridChamadosExcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.gridChamadosExcluidos.DefaultCellStyle = DataGridViewCellStyle2
		Me.gridChamadosExcluidos.EnableHeadersVisualStyles = False
		Me.gridChamadosExcluidos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.gridChamadosExcluidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.gridChamadosExcluidos.Location = New System.Drawing.Point(7, 141)
		Me.gridChamadosExcluidos.Name = "gridChamadosExcluidos"
		Me.gridChamadosExcluidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.gridChamadosExcluidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.gridChamadosExcluidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.gridChamadosExcluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridChamadosExcluidos.Size = New System.Drawing.Size(1059, 452)
		Me.gridChamadosExcluidos.TabIndex = 8
		'
		'ChamadosExcluidos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1083, 624)
		Me.Controls.Add(Me.gridChamadosExcluidos)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroTile2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "ChamadosExcluidos"
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "   ChamadosExcluidos"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.gridChamadosExcluidos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbPc As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbSalas As MetroFramework.Controls.MetroComboBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
	Friend WithEvents gridChamadosExcluidos As MetroFramework.Controls.MetroGrid
End Class
