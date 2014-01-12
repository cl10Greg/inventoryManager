Public Class mainFrm

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program 
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

            'Prompt the newDB for columns
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dbPath As String

        'Prompt for the db file

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Save the current db (if one is open)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Open the save as prompt

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Format and print what the current information is in the inventory

    End Sub

    Private Sub AddComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddComponentToolStripMenuItem.Click
        'Add a component to the database
    End Sub

    Private Sub EditComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditComponentToolStripMenuItem.Click
        'Edit the selected component

    End Sub

    Private Sub DeleteComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteComponentToolStripMenuItem.Click
        'Delete the selected component

    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        'Create a new project
        'This is used to manage and create BOM for a project

    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        'Open a project that was previously created

    End Sub

    Private Sub BrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        'Browse for items in the database

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Search for items in the database

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        'Display the help prompt
    End Sub
End Class
