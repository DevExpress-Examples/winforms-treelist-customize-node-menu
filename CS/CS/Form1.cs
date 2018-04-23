using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace NodeContextMenu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            // load some sample data
            new DevExpress.XtraTreeList.Design.XViews(treeList1);
            for(int i = 1; i < treeList1.Columns.Count; i++)
                treeList1.Columns[i].VisibleIndex = -1;
        }

        TreeListNode SavedFocused;
        bool NeedRestoreFocused;

        private void treeList1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
            TreeList tree = sender as TreeList;
            if(e.Button == MouseButtons.Right && ModifierKeys == Keys.None && tree.State == TreeListState.Regular) {
                Point pt = tree.PointToClient(MousePosition);
                TreeListHitInfo info = tree.CalcHitInfo(pt);
                if(info.HitInfoType == HitInfoType.Cell) {
                    SavedFocused = tree.FocusedNode;
                    int SavedTopIndex = tree.TopVisibleNodeIndex;
                    tree.FocusedNode = info.Node;
                    NeedRestoreFocused = true;
                    popupMenuNodes.ShowPopup(MousePosition);
                }
            }
        }

        private void popupMenuNodes_CloseUp(object sender, System.EventArgs e) {
            if(NeedRestoreFocused)
                treeList1.FocusedNode = SavedFocused;
        }

        private void bbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            NeedRestoreFocused = false;
            treeList1.OptionsBehavior.Editable = !treeList1.OptionsBehavior.Editable;
            treeList1.ShowEditor();
        }

        private void bbAddChild_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            NeedRestoreFocused = false;
            TreeListNode newNode = treeList1.AppendNode(null, treeList1.FocusedNode);
            newNode.SetValue(0, "New Node");
            treeList1.FocusedNode = newNode;
            treeList1.OptionsBehavior.Editable = !treeList1.OptionsBehavior.Editable;
            treeList1.ShowEditor();
        }

        private void bbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            NeedRestoreFocused = true;
            treeList1.DeleteNode(treeList1.FocusedNode);
        }

        private void treeList1_HiddenEditor(object sender, System.EventArgs e) {
            treeList1.OptionsBehavior.Editable = false;
        }
    }
}