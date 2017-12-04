Imports Microsoft.Xna
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Content

Public Class frmGameSetup

    Friend P1Team As Integer
    Friend P2Team As Integer
    Friend P3Team As Integer
    Friend P4Team As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click

        Me.Hide()
        frmOptions.Show()

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Me.Hide()
        frmMidship.Show()
    End Sub

    Private Sub frmGameSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)

        picPlayer1Connected.Image = My.Resources.RedTeam2Big
        picPlayer2Connected.Image = My.Resources.BlueTeam2Big
        picPlayer3Connected.Image = My.Resources.GreenTeam2Big
        picPlayer4Connected.Image = My.Resources.BlackTeam2Big

        P1Team = 0

    End Sub

    Private Sub timController1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP1Connect.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)

        If currentState.IsConnected Then

            picPlayer1Connected.Show()
            picPlayer1Disconnected.Hide()

        End If

        If currentState.IsConnected = False Then

            picPlayer1Disconnected.Show()
            picPlayer1Connected.Hide()

        End If

    End Sub

    Private Sub timController2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP2Connect.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Two)

        If currentState.IsConnected Then

            picPlayer2Connected.Show()
            picPlayer2Disconnected.Hide()

        End If

        If currentState.IsConnected = False Then

            picPlayer2Disconnected.Show()
            picPlayer2Connected.Hide()

        End If

    End Sub

    Private Sub timController3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP3Connect.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Three)

        If currentState.IsConnected Then

            picPlayer3Connected.Show()
            picPlayer3Disconnected.Hide()

        End If

        If currentState.IsConnected = False Then

            picPlayer3Disconnected.Show()
            picPlayer3Connected.Hide()

        End If

    End Sub

    Private Sub timController4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP4Connect.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Four)

        If currentState.IsConnected Then

            picPlayer4Connected.Show()
            picPlayer4Disconnected.Hide()

        End If

        If currentState.IsConnected = False Then

            picPlayer4Disconnected.Show()
            picPlayer4Connected.Hide()

        End If

    End Sub

    Private Sub timP1Team_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP1Team.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)


        If frmMidship.Visible = False Then

            If currentState.Buttons.RightShoulder = ButtonState.Pressed Then

                P1Team += 1

                If P1Team = 1 Then

                    picPlayer1Connected.Image = My.Resources.RedTeam2Big

                End If

                If P1Team = 2 Then

                    picPlayer1Connected.Image = My.Resources.BlueTeam2Big

                End If

                If P1Team = 3 Then

                    picPlayer1Connected.Image = My.Resources.GreenTeam2Big

                End If

                If P1Team = 4 Then

                    picPlayer1Connected.Image = My.Resources.BlackTeam2Big

                End If

            End If

        End If

        If P1Team > 4 Then

            P1Team = 0

        End If

    End Sub

    Private Sub timP2Team_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP2Team.Tick
        
        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Two)


        If frmMidship.Visible = False Then

            If currentState.Buttons.RightShoulder = ButtonState.Pressed Then

                P2Team += 1

                If P2Team = 1 Then

                    picPlayer2Connected.Image = My.Resources.RedTeam2Big

                End If

                If P2Team = 2 Then

                    picPlayer2Connected.Image = My.Resources.BlueTeam2Big

                End If

                If P2Team = 3 Then

                    picPlayer2Connected.Image = My.Resources.GreenTeam2Big

                End If

                If P2Team = 4 Then

                    picPlayer2Connected.Image = My.Resources.BlackTeam2Big

                End If

            End If

        End If

        If P2Team > 4 Then

            P2Team = 0

        End If

    End Sub

    Private Sub timP3Team_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP3Team.Tick
        
        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Three)


        If frmMidship.Visible = False Then

            If currentState.Buttons.RightShoulder = ButtonState.Pressed Then

                P3Team += 1

                If P3Team = 1 Then

                    picPlayer3Connected.Image = My.Resources.RedTeam2Big

                End If

                If P3Team = 2 Then

                    picPlayer3Connected.Image = My.Resources.BlueTeam2Big

                End If

                If P3Team = 3 Then

                    picPlayer3Connected.Image = My.Resources.GreenTeam2Big

                End If

                If P3Team = 4 Then

                    picPlayer3Connected.Image = My.Resources.BlackTeam2Big

                End If

            End If

        End If

        If P3Team > 4 Then

            P3Team = 0

        End If

    End Sub

    Private Sub timP4Team_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timP4Team.Tick
        
        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Four)


        If frmMidship.Visible = False Then

            If currentState.Buttons.RightShoulder = ButtonState.Pressed Then

                P4Team += 1

                If P4Team = 1 Then

                    picPlayer4Connected.Image = My.Resources.RedTeam2Big

                End If

                If P4Team = 2 Then

                    picPlayer4Connected.Image = My.Resources.BlueTeam2Big

                End If

                If P4Team = 3 Then

                    picPlayer4Connected.Image = My.Resources.GreenTeam2Big

                End If

                If P4Team = 4 Then

                    picPlayer4Connected.Image = My.Resources.BlackTeam2Big

                End If

            End If

        End If

        If P4Team > 4 Then

            P4Team = 0

        End If

    End Sub

End Class