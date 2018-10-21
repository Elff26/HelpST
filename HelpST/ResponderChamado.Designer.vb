<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResponderChamado
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnEnviar = New MetroFramework.Controls.MetroButton()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.RichTextBox1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(13, 64)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(638, 335)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Responder"
		'
		'btnEnviar
		'
		Me.btnEnviar.Location = New System.Drawing.Point(23, 417)
		Me.btnEnviar.Name = "btnEnviar"
		Me.btnEnviar.Size = New System.Drawing.Size(621, 57)
		Me.btnEnviar.TabIndex = 1
		Me.btnEnviar.Text = "Enviar"
		Me.btnEnviar.UseSelectable = True
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(11, 20)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(620, 309)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = ""
		'
		'ResponderChamado
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(667, 490)
		Me.Controls.Add(Me.btnEnviar)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "ResponderChamado"
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "ResponderChamado"
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnEnviar As MetroFramework.Controls.MetroButton
	Friend WithEvents RichTextBox1 As RichTextBox
End Class
