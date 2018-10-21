Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class Chamados
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    Dim dtbAmbiente As New DataTable
	Dim dtbChamados As New DataTable
	Private Sub Chamados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AtualizaGrid()
		gridChamados.DataSource = dtbChamados

		con.Open()
		Dim sql As String
		sql = "select * from Ambiente "
		Dim cmd As New SqlCommand(sql, con)
		adp.SelectCommand = cmd
		dtbAmbiente.Clear()
		adp.Fill(dtbAmbiente)

		cbSalas.DataSource = dtbAmbiente
		cbSalas.DisplayMember = "Ambiente"
		cbSalas.ValueMember = "Cod_Ambiente"

		cbPc.DataSource = dtbAmbiente
		cbPc.DisplayMember = "Componente"


		con.Close()


	End Sub

	Private Sub AtualizaGrid()
		con.Open()
		Dim cmd As New SqlCommand("Select Cod_Chamado,Cod_User,Titulo,Descricao,Andamento,Dia,Hora from Chamados where Andamento = 's'", con)
		Dim adp As New SqlDataAdapter()
		adp.SelectCommand = cmd
		dtbChamados.Clear()
		adp.Fill(dtbChamados)
		con.Close()
	End Sub

	Private Sub gridChamados_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridChamados.CellMouseClick
		Chamado.ShowDialog()

		'Dim Login As String = TelaLogin.txtLogin.Text
		'Dim Senha As String = TelaLogin.txtSenha.Text


		'con.Open()

		'Dim sql As String
		'sql = "select login_user, Hierarquia  from usuario where login_user = @user and senha = @senha"
		'Dim cmd As New SqlCommand(sql, con)

		'cmd.Parameters.AddWithValue("@user", Login)
		'cmd.Parameters.AddWithValue("@senha", Senha)
		'adp.SelectCommand = cmd
		'dtb.Clear()
		'adp.Fill(dtb)
		'If (dtb.Rows.Count > 0) Then
		'	Select Case dtb.Rows(0).Item(1).ToString()
		'		Case "Administrador"
		'			Chamado.ShowDialog()
		'		Case "Usuario"
		'	End Select
		'	con.Close()
		'End If
	End Sub

	Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
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
					MenuAdmin.Show()
				Case "Usuario"
					MenuUser.Show()
			End Select
			Me.Close()
			con.Close()
		End If
	End Sub
End Class