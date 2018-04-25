Public Class Form1
    Private Sub KayakTypesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KayakTypesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KayaksDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet.KayakTypes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
