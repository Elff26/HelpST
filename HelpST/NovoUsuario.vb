Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class NovoUsuario
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    Public dtb As New DataTable
	Public adp As New SqlDataAdapter
	Public dtbUser As New DataTable
	Public dtbCargo As New DataTable
	Private Sub NovoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AtualizaGrid()
		gridUser.DataSource = dtbUser

		con.Open()
		Dim sql As String
		sql = "select * from Usuario "
		Dim cmd As New SqlCommand(sql, con)
		adp.SelectCommand = cmd
		dtbCargo.Clear()
		adp.Fill(dtbCargo)

		cbHierarquia.DataSource = dtbCargo
		cbHierarquia.DisplayMember = "Hierarquia"
		cbHierarquia.ValueMember = "Cod_User"
		con.Close()
	End Sub
	Private Sub AtualizaGrid()
		con.Open()
		Dim adp As New SqlDataAdapter("Select  Login_User,Nome,Senha,Hierarquia,Matricula from Usuario", con)
		dtbUser.Clear()
		adp.Fill(dtbUser)
		con.Close()
	End Sub
	Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
		con.Open()
		Dim cmd As New SqlCommand("INSERT INTO Usuario values ( '" & txtLogin.Text & "','" & txtNome.Text & "', '" & txtSenha.Text & "', '" & txtCargo.Text & "', '" & MetroDateTime1.Text & "')", con)
		cmd.ExecuteNonQuery()
		con.Close()
		AtualizaGrid()
	End Sub

	Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
		con.Open()
		Dim cmd1 As New SqlCommand("UPDATE Usuario set Login_User = '" & txtLogin.Text & "',Nome = '" & txtNome.Text & "',Senha = '" & txtSenha.Text & "',Hierarquia = '" & txtCargo.Text & "',Matricula = '" & txtData.Text & "' where Nome = '" & txtNome.Text & "'", con)
		cmd1.ExecuteNonQuery()
		con.Close()
		AtualizaGrid()
	End Sub

	Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		'dtb.Rows.RemoveAt(gridUser.CurrentRow.Index)
		con.Open()
		Dim cmd2 As New SqlCommand(" Delete from Usuario where  Login_User = '" & txtLogin.Text & "'", con)
		cmd2.ExecuteNonQuery()
		con.Close()
		AtualizaGrid()
	End Sub

	Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
		MenuAdmin.Show()
		Me.Close()
	End Sub

	Private Sub gridUser_Click(sender As Object, e As EventArgs) Handles gridUser.Click
		txtLogin.Text = dtb.Rows(gridUser.CurrentRow.Index).Item("Login_User")
		txtNome.Text = dtb.Rows(gridUser.CurrentRow.Index).Item("Nome")
		txtSenha.Text = dtb.Rows(gridUser.CurrentRow.Index).Item("Senha")
		txtCargo.Text = dtb.Rows(gridUser.CurrentRow.Index).Item("Hierarquia")
		txtData.Text = dtb.Rows(gridUser.CurrentRow.Index).Item("Matricula")
	End Sub
End Class