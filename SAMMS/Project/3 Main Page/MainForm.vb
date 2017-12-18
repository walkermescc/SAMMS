Public Class MainForm
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me.TreeKB.Nodes
            .Item(0).Tag = New Action(Sub() Me.ShowChildForm(AddKB))
        End With
    End Sub

    Private Sub TreeKB_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeKB.NodeMouseDoubleClick
        DirectCast(e.Node.Tag, Action).Invoke()
    End Sub

    Private Sub ShowChildForm(ByVal child As Form)
        With child
            .Show()
            .Activate()
        End With
    End Sub

End Class