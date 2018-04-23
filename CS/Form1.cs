using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Menu;

namespace NodeContextMenu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitTreeList();
        }

        void InitTreeList() {
            new DevExpress.XtraTreeList.Design.XViews(treeList1);
            for(int i = 1; i < treeList1.Columns.Count; i++)
                treeList1.Columns[i].Visible = false;
        }

        private void bbEdit_ItemClick(object sender, EventArgs e) {
            treeList1.OptionsBehavior.Editable = !treeList1.OptionsBehavior.Editable;
            treeList1.ShowEditor();
        }

        private void bbAddChild_ItemClick(object sender, EventArgs e) {
            TreeListNode newNode = treeList1.AppendNode(null, treeList1.FocusedNode);
            newNode.SetValue(0, "New Node");
            treeList1.OptionsBehavior.Editable = !treeList1.OptionsBehavior.Editable;
            treeList1.ShowEditor();
        }

        private void bbDelete_ItemClick(object sender, EventArgs e) {
            treeList1.DeleteNode(treeList1.FocusedNode);
        }

        private void treeList1_HiddenEditor(object sender, System.EventArgs e) {
            treeList1.OptionsBehavior.Editable = false;
        }

        private void treeList1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.Menu is TreeListNodeMenu) {
                treeList1.FocusedNode = ((TreeListNodeMenu)e.Menu).Node;
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Edit", bbEdit_ItemClick));
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Add child", bbAddChild_ItemClick));
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete", bbDelete_ItemClick));
            }
        }
    }
}