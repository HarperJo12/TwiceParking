Public Class InOutTransactionTab

    Public Sub showAnimation()
        BunifuTransition1.ShowSync(ButtonIn, True)
        BunifuTransition1.ShowSync(ButtonOut, True)
        BunifuTransition1.ShowSync(ButtonTopUp, True)
    End Sub

    Public Sub hideAnimation()
        BunifuTransition1.HideSync(ButtonIn, True)
        BunifuTransition1.HideSync(ButtonOut, True)
        BunifuTransition1.HideSync(ButtonTopUp, True)
    End Sub

    Public Sub hideButton()
        ButtonIn.Visible = False
        ButtonOut.Visible = False
        ButtonTopUp.Visible = False
    End Sub

    Private Sub ButtonIn_Click(sender As Object, e As EventArgs) Handles ButtonIn.Click
        ScanIn.Show()
        'FrontMenu.Close()
    End Sub

    Private Sub ButtonOut_Click(sender As Object, e As EventArgs) Handles ButtonOut.Click
        ScanOut.Show()
        'FrontMenu.Close()
    End Sub

    Private Sub ButtonTopUp_Click(sender As Object, e As EventArgs) Handles ButtonTopUp.Click
        TransactionTopUp.Show()
        'FrontMenu.Close()
    End Sub
End Class
