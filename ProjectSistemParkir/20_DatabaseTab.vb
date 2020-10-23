Public Class DatabaseTab
    Public Sub ShowAnimation()
        BunifuTransition1.ShowSync(ButtonMember, True)
        BunifuTransition1.ShowSync(ButtonCard, True)
        BunifuTransition1.ShowSync(ButtonParking, True)
    End Sub

    Public Sub HideAnimation()
        BunifuTransition1.HideSync(ButtonMember, True)
        BunifuTransition1.HideSync(ButtonCard, True)
        BunifuTransition1.HideSync(ButtonParking, True)
    End Sub

    Public Sub HideButton()
        ButtonMember.Visible = False
        ButtonCard.Visible = False
        ButtonParking.Visible = False
    End Sub

    Private Sub ButtonMember_Click(sender As Object, e As EventArgs) Handles ButtonMember.Click
        ManageDatabase.Show()
        ManageDatabase.MemberClick()
        ManageDatabase.ButtonMember.selected = True

    End Sub

    Private Sub ButtonCard_Click(sender As Object, e As EventArgs) Handles ButtonCard.Click
        ManageDatabase.Show()
        ManageDatabase.CardClick()
        ManageDatabase.ButtonCard.selected = True
    End Sub

    Private Sub ButtonParking_Click(sender As Object, e As EventArgs) Handles ButtonParking.Click
        ManageDatabase.Show()
        ManageDatabase.ParkingClick()
        ManageDatabase.ButtonParking.selected = True
    End Sub
End Class
