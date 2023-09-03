Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Menu

Namespace NodeContextMenu

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            InitTreeList()
        End Sub

        Private Sub InitTreeList()
            Dim tmp_XViews = New Design.XViews(treeList1)
            For i As Integer = 1 To treeList1.Columns.Count - 1
                treeList1.Columns(i).Visible = False
            Next
        End Sub

        Private Sub bbEdit_ItemClick(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.OptionsBehavior.Editable = Not treeList1.OptionsBehavior.Editable
            treeList1.ShowEditor()
        End Sub

        Private Sub bbAddChild_ItemClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim newNode As TreeListNode = treeList1.AppendNode(Nothing, treeList1.FocusedNode)
            newNode.SetValue(0, "New Node")
            treeList1.OptionsBehavior.Editable = Not treeList1.OptionsBehavior.Editable
            treeList1.ShowEditor()
        End Sub

        Private Sub bbDelete_ItemClick(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.DeleteNode(treeList1.FocusedNode)
        End Sub

        Private Sub treeList1_HiddenEditor(ByVal sender As Object, ByVal e As EventArgs)
            treeList1.OptionsBehavior.Editable = False
        End Sub

        Private Sub treeList1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If TypeOf e.Menu Is TreeListNodeMenu Then
                treeList1.FocusedNode = CType(e.Menu, TreeListNodeMenu).Node
                e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Edit", AddressOf bbEdit_ItemClick))
                e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Add child", AddressOf bbAddChild_ItemClick))
                e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Delete", AddressOf bbDelete_ItemClick))
            End If
        End Sub
    End Class
End Namespace
