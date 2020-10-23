Public Class DatabaseTab
    Public Sub showAnimation()
        BunifuTransition1.ShowSync(ButtonMember, True)
        BunifuTransition1.ShowSync(ButtonCard, True)
        BunifuTransition1.ShowSync(ButtonParking, True)
    End Sub

    Public Sub hideAnimation()
        BunifuTransition1.HideSync(ButtonMember, True)
        BunifuTransition1.HideSync(ButtonCard, True)
        BunifuTransition1.HideSync(ButtonParking, True)
    End Sub

    Public Sub hideButton()
        ButtonMember.Visible = False
        ButtonCard.Visible = False
        ButtonParking.Visible = False
    End Sub
End Class
