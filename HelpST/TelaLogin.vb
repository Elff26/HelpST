Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class TelaLogin
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
		Dim Login As String = txtLogin.Text
		Dim Senha As String = txtSenha.Text

		con.Open()

		Dim sql As String
        sql = "select login, Hierarquia  from Usuario where login = @user and senha = @senha"
        Dim cmd As New SqlCommand(sql, con)

		cmd.Parameters.AddWithValue("@user", Login)
		cmd.Parameters.AddWithValue("@senha", Senha)
		adp.SelectCommand = cmd
		dtb.Clear()
		adp.Fill(dtb)

        If (dtb.Rows.Count > 0) Then
            MsgBox("Sucesso ao Logar")

            Select Case dtb.Rows(0).Item(1).ToString()
                Case "Administrador"
                    MenuAdmin.Show()
                Case "Usuario"
                    MenuUser.Show()
            End Select

            con.Close()
            Me.Hide()

        Else
            MsgBox("Login ou senha incorretas")

            con.Close()
            Me.Show()
        End If
    End Sub

	Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Me.Close()
	End Sub
	Private Sub txtLogin_Enter(sender As Object, e As EventArgs) Handles txtLogin.Enter
		If (txtLogin.Text = "LOGIN") Then
			txtLogin.Text = ""
			txtLogin.ForeColor = Color.Black
		End If
	End Sub

	Private Sub txtLogin_Leave(sender As Object, e As EventArgs) Handles txtLogin.Leave
		If (txtLogin.Text = "") Then
			txtLogin.Text = "LOGIN"
			txtLogin.ForeColor = Color.Black
		End If
	End Sub

	Private Sub txtSenha_Enter(sender As Object, e As EventArgs) Handles txtSenha.Enter
		If (txtSenha.Text = "SENHA") Then
			txtSenha.Text = ""
			txtSenha.ForeColor = Color.Black
			txtSenha.UseSystemPasswordChar = True
		End If
	End Sub

	Private Sub txtSenha_Leave(sender As Object, e As EventArgs) Handles txtSenha.Leave
		If (txtSenha.Text = "") Then
			txtSenha.Text = "SENHA"
			txtSenha.ForeColor = Color.Black
			txtSenha.UseSystemPasswordChar = False
		End If
	End Sub

	Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

	End Sub

	Private Sub TelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
