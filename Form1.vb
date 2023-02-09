' ESPINOSA, Derick James M. 
' BSIT-S-T-1A
' Machine Problem 2
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRes1.Enabled = False

        txtCost2.Enabled = False
        txtTax2.Enabled = False
        txtTotal2.Enabled = False

        txtDiscAmt3.Enabled = False
        txtAmt3.Enabled = False

    End Sub
    ' NUMBER 1 - Computing Inventory Value
    Private Sub btnComp1_Click(sender As Object, e As EventArgs) Handles btnComp1.Click
        Dim iQuant As Integer
        Dim fCost, fTotal As Double
        Dim strDesc As String
        If (Not IsNumeric(txtCost1.Text)) OrElse (Not IsNumeric(txtQuant1.Text)) Then
            MsgBox("Please enter a valid amount!", MessageBoxIcon.Warning, "Invalid Input!")
            Return
        End If

        strDesc = txtDesc1.Text
        fCost = Convert.ToDouble(txtCost1.Text)
        iQuant = Convert.ToInt64(txtQuant1.Text)
        fTotal = Convert.ToDouble(fCost * iQuant)

        txtRes1.Text = strDesc & vbCrLf & "Total Value: " & fTotal

    End Sub

    ' NUMBER 2 - Computing Sales Tax
    Private Sub btnComp2_Click(sender As Object, e As EventArgs) Handles btnComp2.Click
        Const TAX_RATE As Double = 0.05
        Dim iCost, iTaxDue, iTotal, iPrice As Double
        Dim iQuant As Integer

        If (Not IsNumeric(txtPrice2.Text)) OrElse (Not IsNumeric(txtQuant2.Text)) Then
            MsgBox("Please enter a valid amount!", MessageBoxIcon.Warning, "Invalid Input!")
            Return
        End If

        iQuant = Convert.ToInt64(txtQuant2.Text)
        iPrice = Convert.ToDouble(txtPrice2.Text)

        iCost = iPrice * iQuant
        iTaxDue = iCost * TAX_RATE
        iTotal = iCost + iTaxDue

        txtCost2.Text = iCost
        txtTax2.Text = iTaxDue
        txtTotal2.Text = iTotal

    End Sub

    ' NUMBER 3 - Computing a Discount
    Private Sub btnComp3_Click(sender As Object, e As EventArgs) Handles btnComp3.Click
        Const DISCOUNT As Double = 0.2
        Dim iPrice, iAmt, iDiscAmt As Decimal
        Dim strDesc As String

        If (Not IsNumeric(txtPrice3.Text)) Then
            MsgBox("Please enter a valid amount!", MessageBoxIcon.Warning, "Invalid Input!")
            Return
        End If

        strDesc = txtDesc3.Text
        iPrice = Convert.ToDouble(txtPrice3.Text)
        iDiscAmt = iPrice * DISCOUNT
        iAmt = iPrice - iDiscAmt

        txtDiscAmt3.Text = iDiscAmt
        txtAmt3.Text = iAmt

    End Sub

    ' CLEAR FORM
    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        Dim m As Integer = MessageBox.Show("Are you sure you want to clear the form?", "Form Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If m = 7 Then
            Return
        End If
        txtCost1.Text = ""
        txtQuant1.Text = ""
        txtDesc1.Text = ""
        txtRes1.Text = ""
    End Sub
    Private Sub btnClear2Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Dim m As Integer = MessageBox.Show("Are you sure you want to clear the form?", "Form Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If m = 7 Then
            Return
        End If
        txtPrice2.Text = ""
        txtTax2.Text = ""
        txtTotal2.Text = ""
        txtCost2.Text = ""
        txtQuant2.Text = ""
    End Sub
    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
        Dim m As Integer = MessageBox.Show("Are you sure you want to clear the form?", "Form Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If m = 7 Then
            Return
        End If
        txtDesc3.Text = ""
        txtAmt3.Text = ""
        txtDiscAmt3.Text = ""
        txtPrice3.Text = ""
    End Sub

    ' EXIT / HIDE FORM
    Private Sub btnExit1_Click(sender As Object, e As EventArgs) Handles btnExit1.Click
        If box1.Visible Then
            btnExit1.Text = "" 'Icon Down
        Else
            btnExit1.Text = "" 'Icon Up
        End If
        box1.Visible = Not box1.Visible
        card1.Height -= box1.Height
    End Sub
    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        If box2.Visible Then
            btnExit2.Text = "" 'Icon Down
        Else
            btnExit2.Text = "" 'Icon Up
        End If
        box2.Visible = Not box2.Visible
        card2.Height -= box2.Height
    End Sub
    Private Sub btnExit3_Click(sender As Object, e As EventArgs) Handles btnExit3.Click
        If box3.Visible Then
            btnExit3.Text = "" 'Icon Down
        Else
            btnExit3.Text = "" 'Icon Up
        End If
        box3.Visible = Not box3.Visible
        card3.Height -= box3.Height
    End Sub


End Class
