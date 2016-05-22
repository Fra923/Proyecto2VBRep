Public Class Form1

    Private Sub SalesOrderDetailBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesOrderDetailBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesOrderDetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdventureWorks2008_DataDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AdventureWorks2008_DataDataSet.SalesOrderDetail' Puede moverla o quitarla según sea necesario.
        Me.SalesOrderDetailTableAdapter.Fill(Me.AdventureWorks2008_DataDataSet.SalesOrderDetail)

    End Sub

    Private Sub SalesOrderDetailBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles SalesOrderDetailBindingNavigator.RefreshItems

    End Sub
End Class
