Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(100, Color.Transparent)
        Panel3.BackColor = Color.FromArgb(100, Color.Transparent)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private result
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vetor(10) As String
        Dim contador As Integer

        If CheckBox1.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox1.Text
            ' ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox2.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox2.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox3.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox3.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox4.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox4.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox5.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox5.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox6.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox6.Text
            '   ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox7.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox7.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox8.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox8.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox9.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox9.Text
            '  ReDim vetor(vetor.Count + 1)
        End If

        If CheckBox10.Checked Then
            contador += 1
            vetor(contador - 1) = CheckBox10.Text
            '   ReDim vetor(vetor.Count + 1)
        End If

        MessageBox.Show(contador * 1.3)
        For index = 0 To vetor.Count - 1
            If vetor(index) <> vbNullString Then
                MessageBox.Show(vetor(index))


            End If

        Next

        Const message As String = "Sorvete sabor(es):     asdasd    "
        Const caption As String = "Atenção"
        result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)


    End Sub


End Class
