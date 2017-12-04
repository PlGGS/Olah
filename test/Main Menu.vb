Imports Microsoft.Xna
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.GamerServices
Imports Microsoft.Xna.Framework.Content

Public Class frmMainMenu

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click

        Me.Hide()
        frmInstructions.Show()

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Olah_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click

        Me.Hide()
        frmGameSetup.Show()


    End Sub

    Private Sub timController1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController1.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.One)

        If currentState.IsConnected Then

            picPlayer1Disconnected.Hide()
            picPlayer1Connected.Image = My.Resources.RedTeam2Big

            If currentState.Buttons.Start Or currentState.Buttons.A = ButtonState.Pressed Then

                lblOlah.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah.TextAlign = ContentAlignment.TopLeft
                lblOlah.Font = New Font("halo", 70)

                btnPlay.Show()

                btnPlay.Visible = True

                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer1Connected.Show()

            End If

        End If

        If currentState.IsConnected And btnPlay.Visible = True Then

            picPlayer1Connected.Show()

        End If

        If currentState.IsConnected = False And btnPlay.Visible = True Then

            picPlayer1Disconnected.Show()
            picPlayer1Connected.Hide()

        End If

    End Sub

    Private Sub timController2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController2.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Two)

        If currentState.IsConnected Then

            picPlayer2Disconnected.Hide()
            picPlayer2Connected.Image = My.Resources.BlueTeam2Big

            If currentState.Buttons.Start Or currentState.Buttons.A = ButtonState.Pressed Then

                lblOlah.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah.TextAlign = ContentAlignment.TopLeft
                lblOlah.Font = New Font("halo", 70)

                btnPlay.Show()

                btnPlay.Visible = True

                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer2Connected.Show()

            End If

        End If

        If currentState.IsConnected And btnPlay.Visible = True Then

            picPlayer2Connected.Show()

        End If

        If currentState.IsConnected = False And btnPlay.Visible = True Then

            picPlayer2Disconnected.Show()
            picPlayer2Connected.Hide()

        End If

    End Sub

    Private Sub timController3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController3.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Three)

        If currentState.IsConnected Then

            picPlayer3Disconnected.Hide()
            picPlayer3Connected.Image = My.Resources.GreenTeam2Big

            If currentState.Buttons.Start Or currentState.Buttons.A = ButtonState.Pressed Then

                lblOlah.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah.TextAlign = ContentAlignment.TopLeft
                lblOlah.Font = New Font("halo", 70)

                btnPlay.Show()

                btnPlay.Visible = True

                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer3Connected.Show()

            End If

        End If

        If currentState.IsConnected And btnPlay.Visible = True Then

            picPlayer3Connected.Show()

        End If

        If currentState.IsConnected = False And btnPlay.Visible = True Then

            picPlayer3Disconnected.Show()
            picPlayer3Connected.Hide()

        End If

    End Sub

    Private Sub timController4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timController4.Tick

        Dim currentState As GamePadState = GamePad.GetState(PlayerIndex.Four)

        If currentState.IsConnected Then

            picPlayer4Disconnected.Hide()
            picPlayer4Connected.Image = My.Resources.BlackTeam2Big

            If currentState.Buttons.Start Or currentState.Buttons.A = ButtonState.Pressed Then

                lblOlah.Text = vbNewLine & vbNewLine & "   Main Menu"
                lblOlah.TextAlign = ContentAlignment.TopLeft
                lblOlah.Font = New Font("halo", 70)

                btnPlay.Show()

                btnPlay.Visible = True

                btnInstructions.Show()
                btnFairUse.Show()
                btnExit.Show()

                picPlayer4Connected.Show()

            End If

        End If

        If currentState.IsConnected And btnPlay.Visible = True Then

            picPlayer4Connected.Show()

        End If

        If currentState.IsConnected = False And btnPlay.Visible = True Then

            picPlayer4Disconnected.Show()
            picPlayer4Connected.Hide()

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFairUse.Click

        Me.Hide()
        frmFairUse.Show()

    End Sub
End Class
