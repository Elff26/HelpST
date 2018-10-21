<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUser
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
		Me.btnChamados = New MetroFramework.Controls.MetroTile()
		Me.btnChamadosExcluidos = New MetroFramework.Controls.MetroTile()
		Me.btnChamadosResolvidos = New MetroFramework.Controls.MetroTile()
		Me.btnMeusChamados = New MetroFramework.Controls.MetroTile()
		Me.btnNovoChamado = New MetroFramework.Controls.MetroTile()
		Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
		Me.MetroTile7 = New MetroFramework.Controls.MetroTile()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
		Me.MetroPanel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnChamados
		'
		Me.btnChamados.ActiveControl = Nothing
		Me.btnChamados.BackColor = System.Drawing.Color.Purple
		Me.btnChamados.Location = New System.Drawing.Point(5, 123)
		Me.btnChamados.Name = "btnChamados"
		Me.btnChamados.Size = New System.Drawing.Size(216, 131)
		Me.btnChamados.TabIndex = 0
		Me.btnChamados.Text = "Chamados"
		Me.btnChamados.UseCustomBackColor = True
		Me.btnChamados.UseSelectable = True
		'
		'btnChamadosExcluidos
		'
		Me.btnChamadosExcluidos.ActiveControl = Nothing
		Me.btnChamadosExcluidos.BackColor = System.Drawing.Color.Purple
		Me.btnChamadosExcluidos.Location = New System.Drawing.Point(5, 326)
		Me.btnChamadosExcluidos.Name = "btnChamadosExcluidos"
		Me.btnChamadosExcluidos.Size = New System.Drawing.Size(147, 150)
		Me.btnChamadosExcluidos.TabIndex = 1
		Me.btnChamadosExcluidos.Text = "Chamados Excluidos"
		Me.btnChamadosExcluidos.UseCustomBackColor = True
		Me.btnChamadosExcluidos.UseSelectable = True
		'
		'btnChamadosResolvidos
		'
		Me.btnChamadosResolvidos.ActiveControl = Nothing
		Me.btnChamadosResolvidos.BackColor = System.Drawing.Color.Purple
		Me.btnChamadosResolvidos.Location = New System.Drawing.Point(158, 326)
		Me.btnChamadosResolvidos.Name = "btnChamadosResolvidos"
		Me.btnChamadosResolvidos.Size = New System.Drawing.Size(191, 150)
		Me.btnChamadosResolvidos.TabIndex = 2
		Me.btnChamadosResolvidos.Text = "Chamados Finalizados"
		Me.btnChamadosResolvidos.UseCustomBackColor = True
		Me.btnChamadosResolvidos.UseSelectable = True
		'
		'btnMeusChamados
		'
		Me.btnMeusChamados.ActiveControl = Nothing
		Me.btnMeusChamados.BackColor = System.Drawing.Color.Purple
		Me.btnMeusChamados.Location = New System.Drawing.Point(5, 260)
		Me.btnMeusChamados.Name = "btnMeusChamados"
		Me.btnMeusChamados.Size = New System.Drawing.Size(344, 60)
		Me.btnMeusChamados.TabIndex = 3
		Me.btnMeusChamados.Text = "Meus Chamados"
		Me.btnMeusChamados.UseCustomBackColor = True
		Me.btnMeusChamados.UseSelectable = True
		'
		'btnNovoChamado
		'
		Me.btnNovoChamado.ActiveControl = Nothing
		Me.btnNovoChamado.BackColor = System.Drawing.Color.Purple
		Me.btnNovoChamado.Location = New System.Drawing.Point(227, 123)
		Me.btnNovoChamado.Name = "btnNovoChamado"
		Me.btnNovoChamado.Size = New System.Drawing.Size(122, 131)
		Me.btnNovoChamado.TabIndex = 4
		Me.btnNovoChamado.Text = "Novo Chamado"
		Me.btnNovoChamado.UseCustomBackColor = True
		Me.btnNovoChamado.UseSelectable = True
		'
		'MetroTile6
		'
		Me.MetroTile6.ActiveControl = Nothing
		Me.MetroTile6.Location = New System.Drawing.Point(451, 10)
		Me.MetroTile6.Name = "MetroTile6"
		Me.MetroTile6.Size = New System.Drawing.Size(90, 100)
		Me.MetroTile6.TabIndex = 5
		Me.MetroTile6.Text = "MetroTile6"
		Me.MetroTile6.UseSelectable = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(364, 10)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
		Me.MetroLabel1.TabIndex = 7
		Me.MetroLabel1.Text = "MetroLabel1"
		'
		'MetroLink1
		'
		Me.MetroLink1.Location = New System.Drawing.Point(370, 43)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(75, 23)
		Me.MetroLink1.TabIndex = 8
		Me.MetroLink1.Text = "Sair"
		Me.MetroLink1.UseSelectable = True
		'
		'MetroPanel2
		'
		Me.MetroPanel2.BackColor = System.Drawing.Color.Purple
		Me.MetroPanel2.Controls.Add(Me.MetroTile7)
		Me.MetroPanel2.Controls.Add(Me.Label1)
		Me.MetroPanel2.Controls.Add(Me.MetroPanel1)
		Me.MetroPanel2.HorizontalScrollbarBarColor = True
		Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroPanel2.HorizontalScrollbarSize = 10
		Me.MetroPanel2.Location = New System.Drawing.Point(5, 10)
		Me.MetroPanel2.Name = "MetroPanel2"
		Me.MetroPanel2.Size = New System.Drawing.Size(234, 107)
		Me.MetroPanel2.TabIndex = 9
		Me.MetroPanel2.UseCustomBackColor = True
		Me.MetroPanel2.VerticalScrollbarBarColor = True
		Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
		Me.MetroPanel2.VerticalScrollbarSize = 10
		'
		'MetroTile7
		'
		Me.MetroTile7.ActiveControl = Nothing
		Me.MetroTile7.Location = New System.Drawing.Point(4, 4)
		Me.MetroTile7.Name = "MetroTile7"
		Me.MetroTile7.Size = New System.Drawing.Size(90, 99)
		Me.MetroTile7.TabIndex = 9
		Me.MetroTile7.Text = "MetroTile7"
		Me.MetroTile7.UseSelectable = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Label1.Location = New System.Drawing.Point(91, 61)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(143, 42)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "HelpST"
		'
		'MetroPanel1
		'
		Me.MetroPanel1.HorizontalScrollbarBarColor = True
		Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroPanel1.HorizontalScrollbarSize = 10
		Me.MetroPanel1.Location = New System.Drawing.Point(240, 0)
		Me.MetroPanel1.Name = "MetroPanel1"
		Me.MetroPanel1.Size = New System.Drawing.Size(727, 103)
		Me.MetroPanel1.TabIndex = 7
		Me.MetroPanel1.VerticalScrollbarBarColor = True
		Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
		Me.MetroPanel1.VerticalScrollbarSize = 10
		'
		'MenuUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(652, 492)
		Me.Controls.Add(Me.MetroPanel2)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.MetroTile6)
		Me.Controls.Add(Me.btnNovoChamado)
		Me.Controls.Add(Me.btnMeusChamados)
		Me.Controls.Add(Me.btnChamadosResolvidos)
		Me.Controls.Add(Me.btnChamadosExcluidos)
		Me.Controls.Add(Me.btnChamados)
		Me.Name = "MenuUser"
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.MetroPanel2.ResumeLayout(False)
		Me.MetroPanel2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnChamados As MetroFramework.Controls.MetroTile
	Friend WithEvents btnChamadosExcluidos As MetroFramework.Controls.MetroTile
	Friend WithEvents btnChamadosResolvidos As MetroFramework.Controls.MetroTile
	Friend WithEvents btnMeusChamados As MetroFramework.Controls.MetroTile
	Friend WithEvents btnNovoChamado As MetroFramework.Controls.MetroTile
	Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
	Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
	Friend WithEvents MetroTile7 As MetroFramework.Controls.MetroTile
	Friend WithEvents Label1 As Label
	Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
End Class
