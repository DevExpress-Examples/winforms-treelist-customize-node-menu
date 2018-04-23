namespace NodeContextMenu {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbAddChild = new DevExpress.XtraBars.BarButtonItem();
            this.bbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuNodes = new DevExpress.XtraBars.PopupMenu(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbEdit,
            this.bbAddChild,
            this.bbDelete});
            this.barManager1.MaxItemId = 3;
            // 
            // bbEdit
            // 
            this.bbEdit.Caption = "Edit";
            this.bbEdit.Id = 0;
            this.bbEdit.Name = "bbEdit";
            this.bbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbEdit_ItemClick);
            // 
            // bbAddChild
            // 
            this.bbAddChild.Caption = "Add child";
            this.bbAddChild.Id = 1;
            this.bbAddChild.Name = "bbAddChild";
            this.bbAddChild.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAddChild_ItemClick);
            // 
            // bbDelete
            // 
            this.bbDelete.Caption = "Delete";
            this.bbDelete.Id = 2;
            this.bbDelete.Name = "bbDelete";
            this.bbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbDelete_ItemClick);
            // 
            // popupMenuNodes
            // 
            this.popupMenuNodes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbAddChild),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbDelete)});
            this.popupMenuNodes.Manager = this.barManager1;
            this.popupMenuNodes.Name = "popupMenuNodes";
            this.popupMenuNodes.CloseUp += new System.EventHandler(this.popupMenuNodes_CloseUp);
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(573, 393);
            this.treeList1.TabIndex = 4;
            this.treeList1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseUp);
            this.treeList1.HiddenEditor += new System.EventHandler(this.treeList1_HiddenEditor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 393);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbEdit;
        private DevExpress.XtraBars.BarButtonItem bbAddChild;
        private DevExpress.XtraBars.BarButtonItem bbDelete;
        private DevExpress.XtraBars.PopupMenu popupMenuNodes;
        private DevExpress.XtraTreeList.TreeList treeList1;
    }
}

