Public Class Form1

    Dim p1, p2, p3, p4, p5, p6, p7, p8 As Integer
    Dim subj, gpa, total As Double


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim p1, p2, p3, p4, p5, p6, p7, p8 As Integer
        Dim subj, gpa, total As Double

        p1 = Val(Me.txtInputP1.Text) 'Get input 
        p2 = Val(Me.txtInputP2.Text) 'Get input 
        p3 = Val(Me.txtInputP3.Text)  'Get input 
        p4 = Val(Me.txtInputP4.Text)  'Get input 
        p5 = Val(Me.txtInputP5.Text) 'Get input 
        p6 = Val(Me.txtInputP6.Text) 'Get input 
        p7 = Val(Me.txtInputP7.Text) 'Get input 
        p8 = Val(Me.txtInputP8.Text) 'Get input 

        subj = 8

        If p1 <= 100 And p1 >= 90 Then
            total = total + 4
        ElseIf p1 <= 90 And p1 >= 80 Then
            total = total + 3
        ElseIf p1 <= 80 And p1 >= 70 Then
            total = total + 2
        ElseIf p1 <= 70 And p1 >= 60 Then
            total = total + 1
        End If

        If p2 <= 100 And p2 >= 90 Then
            total = total + 4
        ElseIf p2 <= 90 And p2 >= 80 Then
            total = total + 3
        ElseIf p2 <= 80 And p2 >= 70 Then
            total = total + 2
        ElseIf p2 <= 70 And p2 >= 60 Then
            total = total + 1
        End If

        If p3 <= 100 And p3 >= 90 Then
            total = total + 4
        ElseIf p3 <= 90 And p3 >= 80 Then
            total = total + 3
        ElseIf p3 <= 80 And p3 >= 70 Then
            total = total + 2
        ElseIf p3 <= 70 And p3 >= 60 Then
            total = total + 1
        End If

        If p4 < 100 And p4 > 90 Then
            total = total + 4
        ElseIf p4 <= 90 And p4 >= 80 Then
            total = total + 3
        ElseIf p4 <= 80 And p4 >= 70 Then
            total = total + 2
        ElseIf p4 <= 70 And p4 >= 60 Then
            total = total + 1
        End If

        If p5 <= 100 And p5 >= 90 Then
            total = total + 4
        ElseIf p5 <= 90 And p5 >= 80 Then
            total = total + 3
        ElseIf p5 <= 80 And p5 >= 70 Then
            total = total + 2
        ElseIf p5 <= 70 And p5 >= 60 Then
            total = total + 1
        End If

        If p6 <= 100 And p6 >= 90 Then
            total = total + 4
        ElseIf p6 <= 90 And p6 >= 80 Then
            total = total + 3
        ElseIf p6 <= 80 And p6 >= 70 Then
            total = total + 2
        ElseIf p6 <= 70 And p6 >= 60 Then
            total = total + 1
        End If

        If p7 <= 100 And p7 >= 90 Then
            total = total + 4
        ElseIf p7 <= 90 And p7 >= 80 Then
            total = total + 3
        ElseIf p7 <= 80 And p7 >= 70 Then
            total = total + 2
        ElseIf p7 <= 70 And p7 >= 60 Then
            total = total + 1
        End If

        If p8 <= 100 And p8 >= 90 Then
            total = total + 4
        ElseIf p8 <= 90 And p8 >= 80 Then
            total = total + 3
        ElseIf p8 <= 80 And p8 >= 70 Then
            total = total + 2
        ElseIf p8 <= 70 And p8 >= 60 Then
            total = total + 1
        End If



        If radHonors1.Checked = True Then
            total = total + 1
        End If

        If radHonors2.Checked = True Then
            total = total + 1
        End If

        If radHonors3.Checked = True Then
            total = total + 1
        End If

        If radHonors4.Checked = True Then
            total = total + 1
        End If

        If radHonors5.Checked = True Then
            total = total + 1
        End If

        If radHonors6.Checked = True Then
            total = total + 1
        End If

        If radHonors7.Checked = True Then
            total = total + 1
        End If

        If radHonors8.Checked = True Then
            total = total + 1
        End If



        If chkIncluded1.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded2.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded3.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded4.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded5.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded6.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded7.Checked = True Then
            subj = subj - 1
        End If

        If chkIncluded8.Checked = True Then
            subj = subj - 1
        End If

        gpa = total / subj

        Me.lblAnswer.Text = "GPA:" & gpa

        If gpa >= 3.25 And gpa <= 3.69 Then
            Me.lblHonorsAns.Text = "Honor Roll"
        End If


        If gpa >= 3.7 And gpa <= 3.99 Then
            Me.lblHonorsAns.Text = "Principles List"
        End If


        If gpa >= 4.0 Then
            Me.lblHonorsAns.Text = "With distinction"
        End If



    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        txtInputP1.Text = Nothing
        txtInputP2.Text = Nothing
        txtInputP3.Text = Nothing
        txtInputP4.Text = Nothing
        txtInputP5.Text = Nothing
        txtInputP6.Text = Nothing
        txtInputP7.Text = Nothing
        txtInputP8.Text = Nothing

        txtInputSub1.Text = Nothing
        txtInputSub2.Text = Nothing
        txtInputSub3.Text = Nothing
        txtInputSub4.Text = Nothing
        txtInputSub5.Text = Nothing
        txtInputSub6.Text = Nothing
        txtInputSub7.Text = Nothing
        txtInputSub8.Text = Nothing

        chkIncluded1.Checked = False
        chkIncluded2.Checked = False
        chkIncluded3.Checked = False
        chkIncluded4.Checked = False
        chkIncluded5.Checked = False
        chkIncluded6.Checked = False
        chkIncluded7.Checked = False
        chkIncluded8.Checked = False

        radHonors1.Checked = False
        radHonors2.Checked = False
        radHonors3.Checked = False
        radHonors4.Checked = False
        radHonors5.Checked = False
        radHonors6.Checked = False
        radHonors7.Checked = False
        radHonors8.Checked = False

        radReg1.Checked = False
        radReg2.Checked = False
        radReg3.Checked = False
        radReg4.Checked = False
        radReg5.Checked = False
        radReg6.Checked = False
        radReg7.Checked = False
        radReg8.Checked = False


    End Sub





End Class
