Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add a column to the DataGridView
        DataGridView1.Columns.Add("Column1", "Data")
    End Sub

    ' Button1 click event to add data from TextBox1 to DataGridView1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the TextBox is not empty
        If TextBox1.Text <> "" Then
            ' Add the text from TextBox1 as a new row in DataGridView1
            DataGridView1.Rows.Add(TextBox1.Text)
            ' Clear the TextBox after adding the data
            TextBox1.Clear()
        Else
            ' Show a message box if the TextBox is empty
            MessageBox.Show("Please enter some text.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
