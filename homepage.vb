Public Class homepage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim p As New Process
        p.StartInfo.Arguments = TextBox1.Text
        p.StartInfo.FileName = "spam_mail_detect1.ipynb" '"script.py" must be in the debug folder'
        p.Start()
    End Sub
End Class