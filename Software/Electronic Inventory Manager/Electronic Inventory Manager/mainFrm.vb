Public Class mainFrm

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'End 
        End

        'Prompt for saving any unsaved information
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'Name the new database
        Dim dbName As String
        dbName = InputBox("Enter the name for the database.", "New Database", "newDB")

        'Check for the valid name
        If dbName = "newDB" Or dbName = "" Then
            MsgBox("Error, please enter a valid name.")
        Else
            MsgBox("Create the DB")
            'Make a new newDB with the correct name

        End If
    End Sub
End Class
