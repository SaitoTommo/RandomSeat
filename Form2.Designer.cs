namespace MainNameSpace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Generate = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplyMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.AddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCell = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearCell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.压力测试勿随意使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MapDialog = new System.Windows.Forms.OpenFileDialog();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBox1 = new System.Windows.Forms.TextBox();
            this.TBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.Box2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBox1
            // 
            resources.ApplyResources(this.LBox1, "LBox1");
            this.LBox1.FormattingEnabled = true;
            this.LBox1.Name = "LBox1";
            this.LBox1.SelectedIndexChanged += new System.EventHandler(this.LBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Save,
            this.toolStripMenuItem2,
            this.Generate,
            this.Clear,
            this.ApplyMap,
            this.toolStripMenuItem3,
            this.AddRow,
            this.AddColumn,
            this.DeleteRow,
            this.EditCell,
            this.ClearCell,
            this.toolStripMenuItem4,
            this.Help,
            this.关于ToolStripMenuItem,
            this.压力测试勿随意使用ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // Open
            // 
            this.Open.Name = "Open";
            resources.ApplyResources(this.Open, "Open");
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            resources.ApplyResources(this.Save, "Save");
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // Generate
            // 
            this.Generate.Name = "Generate";
            resources.ApplyResources(this.Generate, "Generate");
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Clear
            // 
            this.Clear.Name = "Clear";
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ApplyMap
            // 
            this.ApplyMap.Name = "ApplyMap";
            resources.ApplyResources(this.ApplyMap, "ApplyMap");
            this.ApplyMap.Click += new System.EventHandler(this.ApplyMap_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // AddRow
            // 
            this.AddRow.Name = "AddRow";
            resources.ApplyResources(this.AddRow, "AddRow");
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Name = "AddColumn";
            resources.ApplyResources(this.AddColumn, "AddColumn");
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Name = "DeleteRow";
            resources.ApplyResources(this.DeleteRow, "DeleteRow");
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // EditCell
            // 
            this.EditCell.Name = "EditCell";
            resources.ApplyResources(this.EditCell, "EditCell");
            this.EditCell.Click += new System.EventHandler(this.EditCell_Click);
            // 
            // ClearCell
            // 
            this.ClearCell.Name = "ClearCell";
            resources.ApplyResources(this.ClearCell, "ClearCell");
            this.ClearCell.Click += new System.EventHandler(this.ClearCell_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // Help
            // 
            this.Help.Name = "Help";
            resources.ApplyResources(this.Help, "Help");
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            resources.ApplyResources(this.关于ToolStripMenuItem, "关于ToolStripMenuItem");
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 压力测试勿随意使用ToolStripMenuItem
            // 
            this.压力测试勿随意使用ToolStripMenuItem.Name = "压力测试勿随意使用ToolStripMenuItem";
            resources.ApplyResources(this.压力测试勿随意使用ToolStripMenuItem, "压力测试勿随意使用ToolStripMenuItem");
            this.压力测试勿随意使用ToolStripMenuItem.Click += new System.EventHandler(this.压力测试勿随意使用ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MapDialog
            // 
            this.MapDialog.FileName = "openFileDialog2";
            resources.ApplyResources(this.MapDialog, "MapDialog");
            // 
            // Box2
            // 
            this.Box2.Controls.Add(this.button7);
            this.Box2.Controls.Add(this.button6);
            this.Box2.Controls.Add(this.statusStrip1);
            this.Box2.Controls.Add(this.panel1);
            this.Box2.Controls.Add(this.button5);
            this.Box2.Controls.Add(this.button4);
            this.Box2.Controls.Add(this.button3);
            this.Box2.Controls.Add(this.button2);
            this.Box2.Controls.Add(this.button1);
            resources.ApplyResources(this.Box2, "Box2");
            this.Box2.Name = "Box2";
            this.Box2.TabStop = false;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ProgressBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBox1);
            this.panel1.Controls.Add(this.TBox2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TBox1
            // 
            resources.ApplyResources(this.TBox1, "TBox1");
            this.TBox1.Name = "TBox1";
            // 
            // TBox2
            // 
            resources.ApplyResources(this.TBox2, "TBox2");
            this.TBox2.Name = "TBox2";
            this.TBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Table1
            // 
            this.Table1.AllowDrop = true;
            this.Table1.AllowUserToAddRows = false;
            this.Table1.AllowUserToDeleteRows = false;
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Table1, "Table1");
            this.Table1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.Table1.Name = "Table1";
            this.Table1.RowTemplate.Height = 23;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LBox1);
            this.panel2.Controls.Add(this.Box2);
            this.panel2.Name = "panel2";
            this.panel2.Tag = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Table1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Box2.ResumeLayout(false);
            this.Box2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Clear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem AddRow;
        private System.Windows.Forms.ToolStripMenuItem AddColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem Generate;
        private System.Windows.Forms.ToolStripMenuItem DeleteRow;
        private System.Windows.Forms.ToolStripMenuItem ClearCell;
        private System.Windows.Forms.ToolStripMenuItem EditCell;
        private System.Windows.Forms.ToolStripMenuItem 压力测试勿随意使用ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem ApplyMap;
        private System.Windows.Forms.OpenFileDialog MapDialog;
        public System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBox1;
        private System.Windows.Forms.TextBox TBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}