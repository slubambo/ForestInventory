Public Class frmProducts
    Dim maxrow As Integer
    Dim tblfields As String
    Dim proid As Integer
    Private Sub clearNew()
        clear(Me)
        frmMaxMinSize(Me, 608, 480)
    End Sub
    Private Sub BTNSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSAVE.Click


        If TXTPRONAME.Text = "" Then
            MsgBox("Empty fields are required inorder to save!", MsgBoxStyle.Exclamation, "Required")

        Else


            query = "SELECT * FROM tblProductInfo WHERE PROCODE='" & TXTPRONAME.Text & "'"
            retrieveSingleResult(query)


            If dt.Rows.Count > 0 Then

                msgfalse = "Error to update Bread."
                msgtrue = "Bread Has Been Updated."

                query = "UPDATE  tblProductInfo  SET PRONAME='" & "  WHERE PROCODE='" & County.Text & "'"
                cudfunction(query)

            Else

                msgtrue = "Query Successful."
                msgfalse = "Error to Query Summary."

                tblfields = "PROCODE,PRONAME"
                query = "INSERT INTO tblProductInfo (" & tblfields & ")" _
                & " VALUES ( '" & TXTPRONAME.Text & "', '" & TXTPRONAME.Text & "','" & County.Text & "',0)"
                cudfunction(query)

                updateAutoNumber(2)
            End If

            clearNew()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        clearNew()

    End Sub


    Private Sub FRMITEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearNew()

    End Sub

    Private Sub TXTPRICE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then e.Handled = False '
                ElseIf County.Text.Contains(".") Then
                    MessageBox.Show("Only one decimal point allowed")
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTPRICE_KeyUp")
            MsgBox(ex.Message & " at TXTPRICE_KeyUp")
        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TXTPRONAME_TextChanged(sender As Object, e As EventArgs) Handles TXTPRONAME.TextChanged, County.TextChanged, TextBox2.TextChanged

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListOfResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryButton.Click
        With frmListProducts
            .Show()
            .Focus()
        End With
    End Sub

End Class