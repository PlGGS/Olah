Public Class frmPostGameStats

    Private Sub btnBackToMenu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMenu1.Click

        Application.Exit()

    End Sub

    Private Sub btnBackToMenu2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMenu2.Click

        Application.Exit()

    End Sub

    Private Sub btnBackToMenu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMenu3.Click

        Application.Exit()

    End Sub

    Private Sub btnBackToMenu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMenu4.Click

        Application.Exit()

    End Sub

    Private Sub frmPostGameStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.Visible = True Then
            frmMidship.lblCountdown.Visible = True
        End If

        lblP1Kills2.Text = frmMidship.lblP1Kills.Text
        lblP2Kills2.Text = frmMidship.lblP2Kills.Text
        lblP3Kills2.Text = frmMidship.lblP3Kills.Text
        lblP4Kills2.Text = frmMidship.lblP4Kills.Text

        lblP1Deaths2.Text = frmMidship.lblP1Deaths.Text
        lblP2Deaths2.Text = frmMidship.lblP2Deaths.Text
        lblP3Deaths2.Text = frmMidship.lblP3Deaths.Text
        lblP4Deaths2.Text = frmMidship.lblP4Deaths.Text

        If frmMidship.lblP1Deaths.Text = "Deaths: 0" Then

            lblP1Deaths2.Text = "Deaths: 0"

        End If

        If frmMidship.lblP2Deaths.Text = "Deaths: 0" Then

            lblP2Deaths2.Text = "Deaths: 0"

        End If

        If frmMidship.lblP3Deaths.Text = "Deaths: 0" Then

            lblP3Deaths2.Text = "Deaths: 0"

        End If

        If frmMidship.lblP3Deaths.Text = "Deaths: 0" Then

            lblP3Deaths2.Text = vbNewLine & "Deaths: 0"

        End If

        If frmMidship.p1kills > frmMidship.p2kills And frmMidship.p1kills > frmMidship.p3kills And frmMidship.p1kills > frmMidship.p4kills Then
            lblPostGameWinner.Text = vbNewLine & "Player 1 Wins!"
        End If

        If frmMidship.p2kills > frmMidship.p1kills And frmMidship.p2kills > frmMidship.p3kills And frmMidship.p2kills > frmMidship.p4kills Then
            lblPostGameWinner.Text = vbNewLine & "Player 2 Wins!"
        End If

        If frmMidship.p3kills > frmMidship.p1kills And frmMidship.p3kills > frmMidship.p2kills And frmMidship.p3kills > frmMidship.p4kills Then
            lblPostGameWinner.Text = vbNewLine & "Player 3 Wins!"
        End If

        If frmMidship.p4kills > frmMidship.p1kills And frmMidship.p4kills > frmMidship.p2kills And frmMidship.p4kills > frmMidship.p3kills Then
            lblPostGameWinner.Text = vbNewLine & "Player 4 Wins!"
        End If

    End Sub

End Class