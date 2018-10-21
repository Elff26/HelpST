Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class NovaSala
    'Private con As New SqlConnection("server=MARTE;Initial Catalog=HelpST;UID=2016lais;PWD=123")
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    Private Sub NovaSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
		con.Open()
		Dim cmd As New SqlCommand("INSERT INTO Ambiente (Ambiente,Data_de_Criacao,Componente) values (" & txtNomeAmbiente.Text & ",'" & txtData.Text & "', '" & txtComponentes.Text & "')", con)
		cmd.ExecuteNonQuery()
		con.Close()
	End Sub

	Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
		MenuAdmin.Show()
		Me.Close()
	End Sub
End Class