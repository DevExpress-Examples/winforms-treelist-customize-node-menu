Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace NodeContextMenu
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			' load some sample data
			Dim TempXViews As DevExpress.XtraTreeList.Design.XViews = New DevExpress.XtraTreeList.Design.XViews(treeList1)
			For i As Integer = 1 To treeList1.Columns.Count - 1
				treeList1.Columns(i).VisibleIndex = -1
			Next i
		End Sub

		Private SavedFocused As TreeListNode
		Private NeedRestoreFocused As Boolean

		Private Sub treeList1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeList1.MouseUp
			Dim tree As TreeList = TryCast(sender, TreeList)
			If e.Button = MouseButtons.Right AndAlso ModifierKeys = Keys.None AndAlso tree.State = TreeListState.Regular Then
				Dim pt As Point = tree.PointToClient(MousePosition)
				Dim info As TreeListHitInfo = tree.CalcHitInfo(pt)
				If info.HitInfoType = HitInfoType.Cell Then
					SavedFocused = tree.FocusedNode
					Dim SavedTopIndex As Integer = tree.TopVisibleNodeIndex
					tree.FocusedNode = info.Node
					NeedRestoreFocused = True
					popupMenuNodes.ShowPopup(MousePosition)
				End If
			End If
		End Sub

		Private Sub popupMenuNodes_CloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupMenuNodes.CloseUp
			If NeedRestoreFocused Then
				treeList1.FocusedNode = SavedFocused
			End If
		End Sub

		Private Sub bbEdit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbEdit.ItemClick
			NeedRestoreFocused = False
			treeList1.OptionsBehavior.Editable = Not treeList1.OptionsBehavior.Editable
			treeList1.ShowEditor()
		End Sub

		Private Sub bbAddChild_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbAddChild.ItemClick
			NeedRestoreFocused = False
			Dim newNode As TreeListNode = treeList1.AppendNode(Nothing, treeList1.FocusedNode)
			newNode.SetValue(0, "New Node")
			treeList1.FocusedNode = newNode
			treeList1.OptionsBehavior.Editable = Not treeList1.OptionsBehavior.Editable
			treeList1.ShowEditor()
		End Sub

		Private Sub bbDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbDelete.ItemClick
			NeedRestoreFocused = True
			treeList1.DeleteNode(treeList1.FocusedNode)
		End Sub

		Private Sub treeList1_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.HiddenEditor
			treeList1.OptionsBehavior.Editable = False
		End Sub
	End Class
End Namespace