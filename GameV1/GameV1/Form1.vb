Public Class UltimatePenguinSimulation
    Dim yoffset As Integer
    Public Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.W
                Move(Penguin, 0, -10)
            Case Keys.S
                Move(Penguin, 0, +10)
            Case Keys.A
                Move(Penguin, -10, 0)
            Case Keys.D
                Move(Penguin, +10, 0)
            Case Keys.Space
                Bullet.Location = Penguin.Location
                Bullet.Visible = True
                BulletMovement.Enabled = True
            Case Else

        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles BossMovement.Tick
        follow(Cannonball)
    End Sub
    Sub Move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(Penguin.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > Penguin.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < Penguin.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub

    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "Penguin" And Collision(p, "Cannonball") Then
            If PenguinHealth.Value = (0) Then
                HealthDamage.Enabled = False
                GameOver.Visible = True
            Else
                HealthDamage.Enabled = True
                Return
            End If
        End If

        If p.Name = "Bullet" And Collision(p, "Rick") Then
            If BossHealth.Value = (0) Then
                BossDamage.Enabled = False
                Rick.Visible = False
            Else
                BossDamage.Enabled = True
                Return
            End If
        End If

        If p.Name = "Penguin" And Collision(p, "WIN") Then
            If WIN.Visible = False Then
                WinScreen.Visible = False
            Else
                WinScreen.Visible = True
            End If
        End If

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles BulletMovement.Tick
        MoveTo(Bullet, 14, 0)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles StarMovement.Tick
        WIN.Location = Rick.Location
    End Sub

    Private Sub BossDamage_Tick(sender As Object, e As EventArgs) Handles BossDamage.Tick
        BossHealth.Value = (BossHealth.Value - 10)
        BossDamage.Enabled = False
    End Sub

    Public Sub HealthDamage_Tick(sender As Object, e As EventArgs) Handles HealthDamage.Tick
        PenguinHealth.Value = (PenguinHealth.Value - 3)
        HealthDamage.Enabled = False
    End Sub

    Private Sub Gravity_Tick(sender As Object, e As EventArgs) Handles Gravity.Tick
        MoveTo(Penguin, 0, 5 - yoffset)
        If yoffset > 0 Then
            yoffset = yoffset - 2
        End If
    End Sub

    Private Sub StarThingy_Tick(sender As Object, e As EventArgs) Handles StarThingy.Tick
        If BossHealth.Value = (0) Then
            WIN.Visible = True
        Else
            WIN.Visible = False
        End If
    End Sub
End Class