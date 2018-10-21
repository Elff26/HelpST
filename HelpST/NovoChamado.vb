Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class NovoChamado
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")

    Dim caminho As String
	Dim dtbAmbiente As New DataTable
	Dim dtb As New DataTable
    Public adp As New SqlDataAdapter
    Private Function Conexao() As SqlConnection
        Return New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim con = Conexao()
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO Chamados values ('" & txtTitulo.Text & "','" & txtDescriçao.Text & "'", con)
		cmd.ExecuteNonQuery()
		con.Close()


	End Sub

	Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
		OpenFileDialog1.ShowDialog()
		caminho = OpenFileDialog1.FileName
		PictureBox1.Load(caminho)
	End Sub

	Private Sub NovoChamado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = Conexao()
        con.Open()
        Dim sql As String
		sql = "select * from Ambiente "
		Dim cmd As New SqlCommand(sql, con)
		adp.SelectCommand = cmd
		dtbAmbiente.Clear()
		adp.Fill(dtbAmbiente)
        con.Close()

        cbSalas.DataSource = dtbAmbiente
        cbSalas.DisplayMember = "Ambiente"
        cbSalas.ValueMember = "Cod_Ambiente"

    End Sub

    Private Sub cbSalas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSalas.SelectedIndexChanged
        Dim dtbSalas As New DataTable
        Dim con = Conexao()
        con.Open()
        Dim sql As String
        sql = "select * from Componente where Cod_Ambiente = @ambiente"
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@ambiente", cbSalas.SelectedValue)
        adp.SelectCommand = cmd
        dtbSalas.Clear()
        adp.Fill(dtbSalas)
        con.Close()

        cbPc.DataSource = dtbSalas
        cbPc.DisplayMember = "Nome"
        cbPc.ValueMember = "Cod_Componente"

    End Sub
End Class