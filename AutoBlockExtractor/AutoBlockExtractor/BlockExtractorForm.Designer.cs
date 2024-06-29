namespace AutoBlockExtractor
{
    partial class BlockExtractorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowerFolder = new System.Windows.Forms.Button();
            this.chkLstDwgs = new System.Windows.Forms.CheckedListBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlockname = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnExtractBlocks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelectAll);
            this.groupBox1.Controls.Add(this.chkLstDwgs);
            this.groupBox1.Controls.Add(this.btnBrowerFolder);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drawing Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(96, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(271, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\Users\\BIM INTL_81\\Desktop";
            // 
            // btnBrowerFolder
            // 
            this.btnBrowerFolder.Location = new System.Drawing.Point(378, 31);
            this.btnBrowerFolder.Name = "btnBrowerFolder";
            this.btnBrowerFolder.Size = new System.Drawing.Size(85, 20);
            this.btnBrowerFolder.TabIndex = 2;
            this.btnBrowerFolder.Text = "Brower...";
            this.btnBrowerFolder.UseVisualStyleBackColor = true;
            this.btnBrowerFolder.Click += new System.EventHandler(this.btnBrowerFolder_Click);
            // 
            // chkLstDwgs
            // 
            this.chkLstDwgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chkLstDwgs.FormattingEnabled = true;
            this.chkLstDwgs.Location = new System.Drawing.Point(19, 73);
            this.chkLstDwgs.Name = "chkLstDwgs";
            this.chkLstDwgs.Size = new System.Drawing.Size(444, 154);
            this.chkLstDwgs.TabIndex = 3;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(19, 247);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBlockname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(30, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the Blockname";
            // 
            // txtBlockname
            // 
            this.txtBlockname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBlockname.Location = new System.Drawing.Point(147, 20);
            this.txtBlockname.Name = "txtBlockname";
            this.txtBlockname.Size = new System.Drawing.Size(316, 20);
            this.txtBlockname.TabIndex = 1;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(30, 407);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(74, 13);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Process info...";
            // 
            // btnExtractBlocks
            // 
            this.btnExtractBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtractBlocks.Location = new System.Drawing.Point(30, 433);
            this.btnExtractBlocks.Name = "btnExtractBlocks";
            this.btnExtractBlocks.Size = new System.Drawing.Size(137, 23);
            this.btnExtractBlocks.TabIndex = 3;
            this.btnExtractBlocks.Text = "Process Block Extraction";
            this.btnExtractBlocks.UseVisualStyleBackColor = true;
            this.btnExtractBlocks.Click += new System.EventHandler(this.btnExtractBlocks_Click);
            // 
            // BlockExtractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 478);
            this.Controls.Add(this.btnExtractBlocks);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BlockExtractorForm";
            this.Text = "Block Extractor Form";
            this.Load += new System.EventHandler(this.BlockExtractorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.CheckedListBox chkLstDwgs;
        private System.Windows.Forms.Button btnBrowerFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBlockname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnExtractBlocks;
    }
}