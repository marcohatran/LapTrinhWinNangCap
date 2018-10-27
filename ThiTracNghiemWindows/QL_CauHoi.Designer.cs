namespace ThiTracNghiemWindows
{
    partial class QL_CauHoi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_CauHoi));
            this.qLThiBangLai = new ThiTracNghiemWindows.QLThiBangLai();
            this.cauHoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cauHoiTableAdapter = new ThiTracNghiemWindows.QLThiBangLaiTableAdapters.CauHoiTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemWindows.QLThiBangLaiTableAdapters.TableAdapterManager();
            this.cauHoiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cauHoiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cauHoiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLThiBangLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingNavigator)).BeginInit();
            this.cauHoiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLThiBangLai
            // 
            this.qLThiBangLai.DataSetName = "QLThiBangLai";
            this.qLThiBangLai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cauHoiBindingSource
            // 
            this.cauHoiBindingSource.DataMember = "CauHoi";
            this.cauHoiBindingSource.DataSource = this.qLThiBangLai;
            // 
            // cauHoiTableAdapter
            // 
            this.cauHoiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoDeTableAdapter = null;
            this.tableAdapterManager.CauHoiTableAdapter = this.cauHoiTableAdapter;
            this.tableAdapterManager.ChiTietBoDeTableAdapter = null;
            this.tableAdapterManager.ChiTietKetQuaTableAdapter = null;
            this.tableAdapterManager.DangKiTableAdapter = null;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.LoaiCauHoiTableAdapter = null;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NguoiDungManHinhTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = null;
            this.tableAdapterManager.ThongTinNguoiDungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemWindows.QLThiBangLaiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cauHoiBindingNavigator
            // 
            this.cauHoiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cauHoiBindingNavigator.BindingSource = this.cauHoiBindingSource;
            this.cauHoiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cauHoiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cauHoiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cauHoiBindingNavigatorSaveItem});
            this.cauHoiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cauHoiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cauHoiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cauHoiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cauHoiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cauHoiBindingNavigator.Name = "cauHoiBindingNavigator";
            this.cauHoiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cauHoiBindingNavigator.Size = new System.Drawing.Size(1113, 25);
            this.cauHoiBindingNavigator.TabIndex = 0;
            this.cauHoiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cauHoiBindingNavigatorSaveItem
            // 
            this.cauHoiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cauHoiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cauHoiBindingNavigatorSaveItem.Image")));
            this.cauHoiBindingNavigatorSaveItem.Name = "cauHoiBindingNavigatorSaveItem";
            this.cauHoiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cauHoiBindingNavigatorSaveItem.Text = "Save Data";
            this.cauHoiBindingNavigatorSaveItem.Click += new System.EventHandler(this.cauHoiBindingNavigatorSaveItem_Click);
            // 
            // cauHoiGridControl
            // 
            this.cauHoiGridControl.DataSource = this.cauHoiBindingSource;
            this.cauHoiGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cauHoiGridControl.Location = new System.Drawing.Point(0, 25);
            this.cauHoiGridControl.MainView = this.gridView1;
            this.cauHoiGridControl.Name = "cauHoiGridControl";
            this.cauHoiGridControl.Size = new System.Drawing.Size(1113, 505);
            this.cauHoiGridControl.TabIndex = 1;
            this.cauHoiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.cauHoiGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // QL_CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cauHoiGridControl);
            this.Controls.Add(this.cauHoiBindingNavigator);
            this.Name = "QL_CauHoi";
            this.Size = new System.Drawing.Size(1113, 530);
            this.Load += new System.EventHandler(this.QL_CauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLThiBangLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiBindingNavigator)).EndInit();
            this.cauHoiBindingNavigator.ResumeLayout(false);
            this.cauHoiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLThiBangLai qLThiBangLai;
        private System.Windows.Forms.BindingSource cauHoiBindingSource;
        private QLThiBangLaiTableAdapters.CauHoiTableAdapter cauHoiTableAdapter;
        private QLThiBangLaiTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cauHoiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cauHoiBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl cauHoiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

    }
}
