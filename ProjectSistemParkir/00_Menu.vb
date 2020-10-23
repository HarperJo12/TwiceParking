Public Class FrontMenu
    Private Sub ButtonClickExit(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'HideForm.HideAsyc(Me, True)
        Application.Exit()
    End Sub

    Private Sub ButtonClickIOTrans(sender As Object, e As EventArgs) Handles ButtonTransaction.Click
        InOutTransactionTab11.hideButton()

        If DatabaseTab1.Visible = True Then
            DatabaseTab1.HideAnimation()
            DatabaseTab1.Visible = False
        End If
        If ReportTab1.Visible = True Then
            ReportTab1.hideAnimation()
            ReportTab1.Visible = False
        End If
        InOutTransactionTab11.Visible = True
        InOutTransactionTab11.showAnimation()

    End Sub

    Private Sub ButtonClickDatabase(sender As Object, e As EventArgs) Handles ButtonDatabase.Click
        DatabaseTab1.HideButton()

        If InOutTransactionTab11.Visible = True Then
            InOutTransactionTab11.hideAnimation()
            InOutTransactionTab11.Visible = False
        End If

        If ReportTab1.Visible = True Then
            ReportTab1.hideAnimation()
            ReportTab1.Visible = False
        End If

        DatabaseTab1.Visible = True
        DatabaseTab1.ShowAnimation()

    End Sub

    Private Sub ButtonClickReport(sender As Object, e As EventArgs) Handles ButtonReport.Click
        ReportTab1.hideButton()

        If InOutTransactionTab11.Visible = True Then
            InOutTransactionTab11.hideAnimation()
            InOutTransactionTab11.Visible = False
        End If

        If DatabaseTab1.Visible = True Then
            DatabaseTab1.HideAnimation()
            DatabaseTab1.Visible = False
        End If

        ReportTab1.Visible = True
        ReportTab1.showAnimation()

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowForm.ShowAsyc(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonTopUp_Click(sender As Object, e As EventArgs) Handles ButtonTopUp.Click
        TransactionTopUp.Show()
    End Sub

    Private Sub ButtonNewMember_Click(sender As Object, e As EventArgs) Handles ButtonNewMember.Click
        ManageDatabase.Show()
        ManageDatabase.MemberClick()
        ManageDatabase.ButtonMember.selected = True
    End Sub
End Class
