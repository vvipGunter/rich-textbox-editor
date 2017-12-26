namespace gunterRichTextBoxEditor
{
    partial class Home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBackSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSettingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSettingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroudColorSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.underLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSlopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.lookAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripComboBox1,
            this.lookAndReplaceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "guntermenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000043;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000001;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem.Text = "NewBuild";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000003;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.baocuen1;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.baocuen;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveAsToolStripMenuItem.Text = "SaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000102;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._20060905030551649;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._20060905030524841;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000065;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._000000021;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000029;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000154;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000052;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.selectAllToolStripMenuItem.Text = "SelectAll";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoBackSpaceToolStripMenuItem});
            this.formatToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000115;
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // autoBackSpaceToolStripMenuItem
            // 
            this.autoBackSpaceToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000077;
            this.autoBackSpaceToolStripMenuItem.Name = "autoBackSpaceToolStripMenuItem";
            this.autoBackSpaceToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.autoBackSpaceToolStripMenuItem.Text = "AutoBackSpace";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSettingToolStripMenuItem1,
            this.colorSettingToolStripMenuItem1,
            this.backGroudColorSettingToolStripMenuItem,
            this.toolStripSeparator4,
            this.underLineToolStripMenuItem,
            this.fontSlopeToolStripMenuItem,
            this.boldToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.setting;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.viewToolStripMenuItem.Text = "Setting";
            // 
            // fontSettingToolStripMenuItem1
            // 
            this.fontSettingToolStripMenuItem1.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000109;
            this.fontSettingToolStripMenuItem1.Name = "fontSettingToolStripMenuItem1";
            this.fontSettingToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.fontSettingToolStripMenuItem1.Text = "FontSetting";
            this.fontSettingToolStripMenuItem1.Click += new System.EventHandler(this.fontSettingToolStripMenuItem1_Click);
            // 
            // colorSettingToolStripMenuItem1
            // 
            this.colorSettingToolStripMenuItem1.Image = global::gunterRichTextBoxEditor.Properties.Resources._000000431;
            this.colorSettingToolStripMenuItem1.Name = "colorSettingToolStripMenuItem1";
            this.colorSettingToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.colorSettingToolStripMenuItem1.Text = "ColorSetting";
            this.colorSettingToolStripMenuItem1.Click += new System.EventHandler(this.colorSettingToolStripMenuItem1_Click);
            // 
            // backGroudColorSettingToolStripMenuItem
            // 
            this.backGroudColorSettingToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000091;
            this.backGroudColorSettingToolStripMenuItem.Name = "backGroudColorSettingToolStripMenuItem";
            this.backGroudColorSettingToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.backGroudColorSettingToolStripMenuItem.Text = "BackGroudColorSetting";
            this.backGroudColorSettingToolStripMenuItem.Click += new System.EventHandler(this.backGroudColorSettingToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // underLineToolStripMenuItem
            // 
            this.underLineToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._20060915;
            this.underLineToolStripMenuItem.Name = "underLineToolStripMenuItem";
            this.underLineToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.underLineToolStripMenuItem.Text = "UnderLine";
            this.underLineToolStripMenuItem.Click += new System.EventHandler(this.underLineToolStripMenuItem_Click);
            // 
            // fontSlopeToolStripMenuItem
            // 
            this.fontSlopeToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000048;
            this.fontSlopeToolStripMenuItem.Name = "fontSlopeToolStripMenuItem";
            this.fontSlopeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fontSlopeToolStripMenuItem.Text = "FontSlope";
            this.fontSlopeToolStripMenuItem.Click += new System.EventHandler(this.fontSlopeToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000072;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 20);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // lookAndReplaceToolStripMenuItem
            // 
            this.lookAndReplaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.lookAndReplaceToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._2006090D;
            this.lookAndReplaceToolStripMenuItem.Name = "lookAndReplaceToolStripMenuItem";
            this.lookAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.lookAndReplaceToolStripMenuItem.Text = "LookAndReplace";
            // 
            // lookToolStripMenuItem
            // 
            this.lookToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.search3;
            this.lookToolStripMenuItem.Name = "lookToolStripMenuItem";
            this.lookToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.lookToolStripMenuItem.Text = "Look";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources._00000134;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEditorToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.question2;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutEditorToolStripMenuItem
            // 
            this.aboutEditorToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.question3;
            this.aboutEditorToolStripMenuItem.Name = "aboutEditorToolStripMenuItem";
            this.aboutEditorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutEditorToolStripMenuItem.Text = "AboutEditor";
            this.aboutEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutEditorToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Image = global::gunterRichTextBoxEditor.Properties.Resources.question6;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // myRichTextBox
            // 
            this.myRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myRichTextBox.HideSelection = false;
            this.myRichTextBox.Location = new System.Drawing.Point(0, 24);
            this.myRichTextBox.Name = "myRichTextBox";
            this.myRichTextBox.Size = new System.Drawing.Size(1016, 712);
            this.myRichTextBox.TabIndex = 1;
            this.myRichTextBox.Text = "";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 736);
            this.Controls.Add(this.myRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSettingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorSettingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backGroudColorSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSlopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem lookAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoBackSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.RichTextBox myRichTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
    }
}

