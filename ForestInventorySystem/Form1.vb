Public Class Form1
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Try
        '    If LoginToolStripMenuItem.Text = "Login" Then

        '        With LoginForm1
        '            .Show() '
        '            .Focus()

        '        End With
        '    Else
        '        LoginToolStripMenuItem.Text = "Login"
        '    End If
        'Catch ex As Exception

        'End Try
        Me.Close()

    End Sub

    Private Sub frmListResults_Load(sender As Object, e As EventArgs) Handles BtnLoadData.Click
        frmMaxMinSize(Me, 905, 520)
        query = "SELECT INVYR as [INVYR], PRCP AS [PRCP],TAVG AS [TAVG], TMAX AS [TMAX],TMIN AS [TMIN] 
                ,SPGRPCD AS [SPGRPCD] ,DBH AS [DBH] ,DRYBIO_BOLE AS [DRYBIO_BOLE] ,DRYBIO_TOP AS [DRYBIO_TOP] 
                ,DRYBIO_STUMP AS [DRYBIO_STUMP] ,DRYBIO_BG AS [DRYBIO_BG] ,CARBON_AG AS [CARBON_AG]
                ,CARBON_BG AS [CARBON_BG] 
                FROM  tblDataset"
        retrieve(query, DATALIST)
        'DATALIST.Columns(0).Visible = False
        '   DATALIST.SelectionMode = False
        MaximizeBox = False
    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        With frmProducts
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListOfProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfProductsToolStripMenuItem.Click
        With frmListProducts
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListOfDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Me.Click, btnRefresh.Click
        With frmListProducts
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        With frmStockIn
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ReceiveProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveProductsToolStripMenuItem.Click
        With frmListStockin
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub SoldProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoldProductToolStripMenuItem.Click
        With frmStockOut
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ListOfSoldProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfSoldProductsToolStripMenuItem.Click
        With frmListStockout
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        With frmReport
            .Show()
            .Show()
        End With
    End Sub

    Public Sub visibleMenu()
        ProductToolStripMenuItem.Enabled = False
        TransactionToolStripMenuItem.Enabled = False
        ManageUsersToolStripMenuItem.Enabled = False
        ReportsToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmProducts.Close()
        frmStockIn.Close()
        frmStockOut.Close()
        frmReport.Close()
        frmEditProduct.Close()
        frmListStockin.Close()
        frmListProducts.Close()
        frmListStockout.Close()
        frmUser.Close()
        'frmPrintPreview.Close()
        With LoginForm1
            .Show()
            .Focus()
            .UsernameTextBox.Clear()
            .PasswordTextBox.Clear()
            .UsernameTextBox.Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click

    End Sub

    Private Sub DATALIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATALIST.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnLoadData_Click(sender As Object, e As EventArgs) Handles BtnLoadData.Click

    End Sub
End Class
