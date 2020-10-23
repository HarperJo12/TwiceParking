Public Class ReportTab
    Public Sub showAnimation()
        BunifuTransition1.ShowSync(ButtonParkingTrans, True)
        BunifuTransition1.ShowSync(ButtonTopUpTrans, True)
        BunifuTransition1.ShowSync(ButtonDashboard, True)
    End Sub

    Public Sub hideAnimation()
        BunifuTransition1.HideSync(ButtonParkingTrans, True)
        BunifuTransition1.HideSync(ButtonTopUpTrans, True)
        BunifuTransition1.HideSync(ButtonDashboard, True)
    End Sub

    Public Sub hideButton()
        ButtonParkingTrans.Visible = False
        ButtonTopUpTrans.Visible = False
        ButtonDashboard.Visible = False
    End Sub
End Class
