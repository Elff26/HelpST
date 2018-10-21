<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovaSala
	Inherits MetroFramework.Forms.MetroForm

	'Descartar substituições de formulário para limpar a lista de componentes.
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

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
		Me.txtData = New MetroFramework.Controls.MetroTextBox()
		Me.txtComponentes = New MetroFramework.Controls.MetroTextBox()
		Me.txtNomeAmbiente = New MetroFramework.Controls.MetroTextBox()
		Me.btnEnviar = New MetroFramework.Controls.MetroButton()
		Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(23, 87)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(96, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Nome da Sala:"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(23, 146)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(94, 19)
		Me.MetroLabel2.TabIndex = 1
		Me.MetroLabel2.Text = "Componentes:"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(12, 202)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(107, 19)
		Me.MetroLabel3.TabIndex = 2
		Me.MetroLabel3.Text = "Data de Criaçao:"
		'
		'MetroDateTime1
		'
		Me.MetroDateTime1.Location = New System.Drawing.Point(125, 202)
		Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
		Me.MetroDateTime1.Name = "MetroDateTime1"
		Me.MetroDateTime1.Size = New System.Drawing.Size(241, 29)
		Me.MetroDateTime1.TabIndex = 3
		'
		'txtData
		'
		'
		'
		'
		Me.txtData.CustomButton.Image = Nothing
		Me.txtData.CustomButton.Location = New System.Drawing.Point(153, 1)
		Me.txtData.CustomButton.Name = ""
		Me.txtData.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtData.CustomButton.TabIndex = 1
		Me.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtData.CustomButton.UseSelectable = True
		Me.txtData.CustomButton.Visible = False
		Me.txtData.Lines = New String(-1) {}
		Me.txtData.Location = New System.Drawing.Point(372, 208)
		Me.txtData.MaxLength = 32767
		Me.txtData.Name = "txtData"
		Me.txtData.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtData.SelectedText = ""
		Me.txtData.SelectionLength = 0
		Me.txtData.SelectionStart = 0
		Me.txtData.ShortcutsEnabled = True
		Me.txtData.Size = New System.Drawing.Size(175, 23)
		Me.txtData.TabIndex = 4
		Me.txtData.UseSelectable = True
		Me.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtData.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtComponentes
		'
		'
		'
		'
		Me.txtComponentes.CustomButton.Image = Nothing
		Me.txtComponentes.CustomButton.Location = New System.Drawing.Point(76, 1)
		Me.txtComponentes.CustomButton.Name = ""
		Me.txtComponentes.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtComponentes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtComponentes.CustomButton.TabIndex = 1
		Me.txtComponentes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtComponentes.CustomButton.UseSelectable = True
		Me.txtComponentes.CustomButton.Visible = False
		Me.txtComponentes.Lines = New String(-1) {}
		Me.txtComponentes.Location = New System.Drawing.Point(123, 142)
		Me.txtComponentes.MaxLength = 32767
		Me.txtComponentes.Name = "txtComponentes"
		Me.txtComponentes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtComponentes.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtComponentes.SelectedText = ""
		Me.txtComponentes.SelectionLength = 0
		Me.txtComponentes.SelectionStart = 0
		Me.txtComponentes.ShortcutsEnabled = True
		Me.txtComponentes.Size = New System.Drawing.Size(98, 23)
		Me.txtComponentes.TabIndex = 5
		Me.txtComponentes.UseSelectable = True
		Me.txtComponentes.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtComponentes.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNomeAmbiente
		'
		'
		'
		'
		Me.txtNomeAmbiente.CustomButton.Image = Nothing
		Me.txtNomeAmbiente.CustomButton.Location = New System.Drawing.Point(172, 1)
		Me.txtNomeAmbiente.CustomButton.Name = ""
		Me.txtNomeAmbiente.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtNomeAmbiente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNomeAmbiente.CustomButton.TabIndex = 1
		Me.txtNomeAmbiente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNomeAmbiente.CustomButton.UseSelectable = True
		Me.txtNomeAmbiente.CustomButton.Visible = False
		Me.txtNomeAmbiente.Lines = New String(-1) {}
		Me.txtNomeAmbiente.Location = New System.Drawing.Point(125, 83)
		Me.txtNomeAmbiente.MaxLength = 32767
		Me.txtNomeAmbiente.Name = "txtNomeAmbiente"
		Me.txtNomeAmbiente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNomeAmbiente.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNomeAmbiente.SelectedText = ""
		Me.txtNomeAmbiente.SelectionLength = 0
		Me.txtNomeAmbiente.SelectionStart = 0
		Me.txtNomeAmbiente.ShortcutsEnabled = True
		Me.txtNomeAmbiente.Size = New System.Drawing.Size(194, 23)
		Me.txtNomeAmbiente.TabIndex = 6
		Me.txtNomeAmbiente.UseSelectable = True
		Me.txtNomeAmbiente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtNomeAmbiente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnEnviar
		'
		Me.btnEnviar.Location = New System.Drawing.Point(553, 114)
		Me.btnEnviar.Name = "btnEnviar"
		Me.btnEnviar.Size = New System.Drawing.Size(224, 120)
		Me.btnEnviar.TabIndex = 7
		Me.btnEnviar.Text = "Enviar"
		Me.btnEnviar.UseSelectable = True
		'
		'MetroTile1
		'
		Me.MetroTile1.ActiveControl = Nothing
		Me.MetroTile1.Location = New System.Drawing.Point(642, 11)
		Me.MetroTile1.Name = "MetroTile1"
		Me.MetroTile1.Size = New System.Drawing.Size(75, 70)
		Me.MetroTile1.TabIndex = 8
		Me.MetroTile1.Text = "MetroTile1"
		Me.MetroTile1.UseSelectable = True
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = True
		Me.MetroLabel4.Location = New System.Drawing.Point(553, 11)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(83, 19)
		Me.MetroLabel4.TabIndex = 9
		Me.MetroLabel4.Text = "MetroLabel4"
		'
		'MetroLink1
		'
		Me.MetroLink1.Image = Global.HelpST.My.Resources.Resources.Voltar
		Me.MetroLink1.ImageSize = 34
		Me.MetroLink1.Location = New System.Drawing.Point(2, 20)
		Me.MetroLink1.Name = "MetroLink1"
		Me.MetroLink1.Size = New System.Drawing.Size(50, 41)
		Me.MetroLink1.TabIndex = 16
		Me.MetroLink1.UseSelectable = True
		'
		'NovaSala
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 257)
		Me.Controls.Add(Me.MetroLink1)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroTile1)
		Me.Controls.Add(Me.btnEnviar)
		Me.Controls.Add(Me.txtNomeAmbiente)
		Me.Controls.Add(Me.txtComponentes)
		Me.Controls.Add(Me.txtData)
		Me.Controls.Add(Me.MetroDateTime1)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Name = "NovaSala"
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "    NovaSala"
		Me.Theme = MetroFramework.MetroThemeStyle.[Default]
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
	Friend WithEvents txtData As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtComponentes As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtNomeAmbiente As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
End Class
