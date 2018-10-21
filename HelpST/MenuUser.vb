Imports System.Data.SqlClient

Public Class MenuUser
    Private con As New SqlConnection("server=DESKTOP-0227TL1\SQLEXPRESS;Initial Catalog=Teste2;Integrated Security=SSPI")
    Private Sub btnChamados_Click(sender As Object, e As EventArgs) Handles btnChamados.Click
        Chamados.Show()
    End Sub

    Private Sub btnNovoChamado_Click(sender As Object, e As EventArgs) Handles btnNovoChamado.Click
        NovoChamado.Show()
    End Sub

    Private Sub btnMeusChamados_Click(sender As Object, e As EventArgs) Handles btnMeusChamados.Click
        MeusChamados.Show()

    End Sub
    Private Sub btnChamadosResolvidos_Click(sender As Object, e As EventArgs) Handles btnChamadosResolvidos.Click
        ChamadosFinalizados.Show()

    End Sub

    Private Sub btnChamadosExcluidos_Click(sender As Object, e As EventArgs) Handles btnChamadosExcluidos.Click
        ChamadosExcluidos.Show()
    End Sub

    Private Sub MenuUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TelaLogin.txtLogin.Text = MetroLabel1.Text
    End Sub
End Class