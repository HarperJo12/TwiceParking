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
End Class
