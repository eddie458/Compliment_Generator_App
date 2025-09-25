Public Class Form1
    Private Sub buttonGenerate_Click(sender As Object, e As EventArgs) Handles buttonGenerate.Click

        ' Remember that you can just put the name of your file in the path if it is where the .exe is generated
        ' Variable used to store the MS Access database file path
        Dim dbPath As String = "ComplimentDB.accdb"

        ' Variable that stores the database provider version and the dbPath
        ' Remember to download AccessDatabaseEngine_X64.exe from the web here: Download Microsoft Access Database Engine 2016 Redistributable
        Dim connDBString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};"

        ' Variable for storing the name of the current user
        Dim nameUser As String = textbox_Name.Text

        Dim selectedCategory As String = listboxCategories.SelectedItem

        Using connDB As New OleDbConnection(connDBString)
            Try
                ' Open a connection to the database
                connDB.Open()
                ' MessageBox.Show("Connected to Access Database!") ' You can also use this command: MsgBox("Connected to Access Database!")

                ' SQL query used for selecting 1 random compliment from the Compliments table
                ' SELECT TOP # gets the number of records specified from the Compliments table, and orders it randomly
                Dim sqlQuery1 As String

                If (selectedCategory = "Confidence-Boosting") Then
                    sqlQuery1 = "SELECT TOP 1 ComplimentText FROM Compliments WHERE CategoryID = 1 ORDER BY Rnd(-Timer() * ComplimentID)"
                ElseIf (selectedCategory = "Gentle Encouragement") Then
                    sqlQuery1 = "SELECT TOP 1 ComplimentText FROM Compliments WHERE CategoryID = 2 ORDER BY Rnd(-Timer() * ComplimentID)"
                ElseIf (selectedCategory = "Fun & Silly") Then
                    sqlQuery1 = "SELECT TOP 1 ComplimentText FROM Compliments WHERE CategoryID = 3 ORDER BY Rnd(-Timer() * ComplimentID)"
                Else
                    sqlQuery1 = "SELECT TOP 1 ComplimentText FROM Compliments ORDER BY Rnd(-Timer() * ComplimentID)" '"SELECT TOP 1 ComplimentText FROM Compliments ORDER BY Rnd(-Timer() * ComplimentID)"
                End If

                ' Create a db command with the connection object and the sql query
                Using cmd1 As New OleDbCommand(sqlQuery1, connDB)

                    ' Executes the sql query command and returns the result
                    Dim compliment As Object = cmd1.ExecuteScalar()

                    If compliment IsNot Nothing Then

                        ' Variable used for storing replaced name compliment
                        Dim complimentTextReplaced As String

                        ' Convert compliment to string and the replace [Name] with the actual name of the user
                        complimentTextReplaced = compliment.ToString().Replace("[Name]", $"{nameUser}")

                        MessageBox.Show("Your compliment of the day is: " & Environment.NewLine & complimentTextReplaced)

                    Else
                        MessageBox.Show("No compliments found in database.")
                    End If

                End Using

                If connDB.State = ConnectionState.Open Then connDB.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

        End Using
        ' Example comment for GIT reference

    End Sub
End Class
