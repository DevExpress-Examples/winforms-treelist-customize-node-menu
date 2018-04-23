Imports Microsoft.VisualBasic
Imports System
Namespace NodeContextMenu
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.bbEdit = New DevExpress.XtraBars.BarButtonItem()
			Me.bbAddChild = New DevExpress.XtraBars.BarButtonItem()
			Me.bbDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenuNodes = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenuNodes, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbEdit, Me.bbAddChild, Me.bbDelete})
			Me.barManager1.MaxItemId = 3
			' 
			' bbEdit
			' 
			Me.bbEdit.Caption = "Edit"
			Me.bbEdit.Id = 0
			Me.bbEdit.Name = "bbEdit"
'			Me.bbEdit.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbEdit_ItemClick);
			' 
			' bbAddChild
			' 
			Me.bbAddChild.Caption = "Add child"
			Me.bbAddChild.Id = 1
			Me.bbAddChild.Name = "bbAddChild"
'			Me.bbAddChild.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbAddChild_ItemClick);
			' 
			' bbDelete
			' 
			Me.bbDelete.Caption = "Delete"
			Me.bbDelete.Id = 2
			Me.bbDelete.Name = "bbDelete"
'			Me.bbDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbDelete_ItemClick);
			' 
			' popupMenuNodes
			' 
			Me.popupMenuNodes.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.bbDelete)})
			Me.popupMenuNodes.Manager = Me.barManager1
			Me.popupMenuNodes.Name = "popupMenuNodes"
'			Me.popupMenuNodes.CloseUp += New System.EventHandler(Me.popupMenuNodes_CloseUp);
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(573, 393)
			Me.treeList1.TabIndex = 4
'			Me.treeList1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseUp);
'			Me.treeList1.HiddenEditor += New System.EventHandler(Me.treeList1_HiddenEditor);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(573, 393)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenuNodes, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents bbEdit As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbAddChild As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbDelete As DevExpress.XtraBars.BarButtonItem
		Private WithEvents popupMenuNodes As DevExpress.XtraBars.PopupMenu
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
	End Class
End Namespace

