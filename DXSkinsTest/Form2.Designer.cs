namespace DXSkinsTest
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.resourcesPopupCheckedListBoxControl1 = new DevExpress.XtraScheduler.UI.ResourcesPopupCheckedListBoxControl();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesPopupCheckedListBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(166, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(225, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(147, 121);
            this.checkedListBoxControl1.TabIndex = 1;
            // 
            // treeList1
            // 
            this.treeList1.Location = new System.Drawing.Point(12, 139);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(147, 154);
            this.treeList1.TabIndex = 2;
            // 
            // resourcesPopupCheckedListBoxControl1
            // 
            this.resourcesPopupCheckedListBoxControl1.Location = new System.Drawing.Point(166, 40);
            this.resourcesPopupCheckedListBoxControl1.Name = "resourcesPopupCheckedListBoxControl1";
            this.resourcesPopupCheckedListBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl.Name = "";
            this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl.TabIndex = 0;
            this.resourcesPopupCheckedListBoxControl1.Size = new System.Drawing.Size(225, 20);
            this.resourcesPopupCheckedListBoxControl1.TabIndex = 3;
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(166, 66);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(225, 227);
            this.calendarControl1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.resourcesPopupCheckedListBoxControl1);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.checkedListBoxControl1);
            this.Controls.Add(this.textEdit1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesPopupCheckedListBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesPopupCheckedListBoxControl1.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraScheduler.UI.ResourcesPopupCheckedListBoxControl resourcesPopupCheckedListBoxControl1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
    }
}