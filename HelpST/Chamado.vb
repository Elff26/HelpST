Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class Chamado
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    Private Sub Chamado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim Login As String = TelaLogin.txtLogin.Text
		Dim Senha As String = TelaLogin.txtSenha.Text


		con.Open()

		Dim sql As String
		sql = "select login_user, Hierarquia  from usuario where login_user = @user and senha = @senha"
		Dim cmd As New SqlCommand(sql, con)

		cmd.Parameters.AddWithValue("@user", Login)
		cmd.Parameters.AddWithValue("@senha", Senha)
		adp.SelectCommand = cmd
		dtb.Clear()
		adp.Fill(dtb)
		If (dtb.Rows.Count > 0) Then
			Select Case dtb.Rows(0).Item(1).ToString()
				Case "Administrador"

				Case "Usuario"
					btnResponder.Hide()
			End Select
			con.Close()
		End If
	End Sub

	Private Sub btnResponder_Click(sender As Object, e As EventArgs) Handles btnResponder.Click
		ResponderChamado.ShowDialog()
	End Sub
End Class