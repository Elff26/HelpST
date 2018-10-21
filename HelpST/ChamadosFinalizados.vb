Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class ChamadosFinalizados
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    Dim dtbAmbiente As New DataTable
	Dim dtbChamadosFinalizados As New DataTable
	Private Sub ChamadosFinalizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AtualizaGrid()
		gridChamadosFinalizados.DataSource = dtbChamadosFinalizados

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

		con.Close()

	End Sub
	Private Sub AtualizaGrid()
		con.Open()
		Dim cmd As New SqlCommand("Select Cod_Chamado,Cod_User,Titulo,Descricao,Dia,Hora from Chamados where Cod_User = 1 and Andamento = 'n'", con)
		Dim adp As New SqlDataAdapter()
		adp.SelectCommand = cmd
		dtbChamadosFinalizados.Clear()
		adp.Fill(dtbChamadosFinalizados)
		con.Close()
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