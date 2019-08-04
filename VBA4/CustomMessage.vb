Public Class CustomMessage
    Private label As Label = New Label()

    'конструктор
    Sub New(text As String)
        label.AutoSize = True
        label.BackColor = Color.SteelBlue
        label.BorderStyle = BorderStyle.FixedSingle
        label.ForeColor = Color.White
        label.Padding = New Padding(10, 10, 10, 10)
        label.Text = text
        label.TextAlign = ContentAlignment.MiddleCenter
        label.Visible = False

        Form1.Controls.Add(label)
    End Sub

    Sub Show()
        label.Top = (Form1.ClientSize.Height / 2) - (label.Height / 2)
        label.Left = (Form1.ClientSize.Width / 2) - (label.Width / 2)
        label.BringToFront()
        label.Visible = True
    End Sub

    Sub Hide()
        label.Visible = False
    End Sub
End Class
