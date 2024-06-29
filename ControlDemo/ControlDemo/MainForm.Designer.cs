namespace ControlDemo
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOptions = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lstLayer = new System.Windows.Forms.ListBox();
            this.lstLineType = new System.Windows.Forms.ListBox();
            this.lstTextStyle = new System.Windows.Forms.ListBox();
            this.lbLayerCount = new System.Windows.Forms.Label();
            this.lbLineTypeCount = new System.Windows.Forms.Label();
            this.lbTextStyleCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdLayer = new System.Windows.Forms.RadioButton();
            this.rdLineType = new System.Windows.Forms.RadioButton();
            this.rdTextStyle = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbLayer = new System.Windows.Forms.CheckBox();
            this.chbLineType = new System.Windows.Forms.CheckBox();
            this.chbTextstyle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.cboOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option Container";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTextStyleCount);
            this.groupBox2.Controls.Add(this.lbLineTypeCount);
            this.groupBox2.Controls.Add(this.lbLayerCount);
            this.groupBox2.Controls.Add(this.lstTextStyle);
            this.groupBox2.Controls.Add(this.lstLineType);
            this.groupBox2.Controls.Add(this.lstLayer);
            this.groupBox2.Location = new System.Drawing.Point(362, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Container";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item to display:";
            // 
            // cboOptions
            // 
            this.cboOptions.FormattingEnabled = true;
            this.cboOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "Linetype",
            "Textstyle"});
            this.cboOptions.Location = new System.Drawing.Point(153, 31);
            this.cboOptions.Name = "cboOptions";
            this.cboOptions.Size = new System.Drawing.Size(147, 21);
            this.cboOptions.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(29, 361);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Show Items";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(171, 361);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(115, 23);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lstLayer
            // 
            this.lstLayer.FormattingEnabled = true;
            this.lstLayer.Location = new System.Drawing.Point(15, 31);
            this.lstLayer.Name = "lstLayer";
            this.lstLayer.Size = new System.Drawing.Size(130, 251);
            this.lstLayer.TabIndex = 0;
            // 
            // lstLineType
            // 
            this.lstLineType.FormattingEnabled = true;
            this.lstLineType.Location = new System.Drawing.Point(159, 31);
            this.lstLineType.Name = "lstLineType";
            this.lstLineType.Size = new System.Drawing.Size(108, 251);
            this.lstLineType.TabIndex = 1;
            // 
            // lstTextStyle
            // 
            this.lstTextStyle.FormattingEnabled = true;
            this.lstTextStyle.Location = new System.Drawing.Point(283, 31);
            this.lstTextStyle.Name = "lstTextStyle";
            this.lstTextStyle.Size = new System.Drawing.Size(131, 251);
            this.lstTextStyle.TabIndex = 2;
            // 
            // lbLayerCount
            // 
            this.lbLayerCount.AutoSize = true;
            this.lbLayerCount.Location = new System.Drawing.Point(34, 309);
            this.lbLayerCount.Name = "lbLayerCount";
            this.lbLayerCount.Size = new System.Drawing.Size(42, 13);
            this.lbLayerCount.TabIndex = 3;
            this.lbLayerCount.Text = "0 Layer";
            // 
            // lbLineTypeCount
            // 
            this.lbLineTypeCount.AutoSize = true;
            this.lbLineTypeCount.Location = new System.Drawing.Point(159, 309);
            this.lbLineTypeCount.Name = "lbLineTypeCount";
            this.lbLineTypeCount.Size = new System.Drawing.Size(56, 13);
            this.lbLineTypeCount.TabIndex = 4;
            this.lbLineTypeCount.Text = "0 lineType";
            // 
            // lbTextStyleCount
            // 
            this.lbTextStyleCount.AutoSize = true;
            this.lbTextStyleCount.Location = new System.Drawing.Point(283, 309);
            this.lbTextStyleCount.Name = "lbTextStyleCount";
            this.lbTextStyleCount.Size = new System.Drawing.Size(60, 13);
            this.lbTextStyleCount.TabIndex = 5;
            this.lbTextStyleCount.Text = "0 TextStyle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Item to display";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(171, 77);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTextStyle);
            this.groupBox3.Controls.Add(this.rdLineType);
            this.groupBox3.Controls.Add(this.rdLayer);
            this.groupBox3.Location = new System.Drawing.Point(32, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 88);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RadioButton";
            // 
            // rdLayer
            // 
            this.rdLayer.AutoSize = true;
            this.rdLayer.Location = new System.Drawing.Point(7, 34);
            this.rdLayer.Name = "rdLayer";
            this.rdLayer.Size = new System.Drawing.Size(51, 17);
            this.rdLayer.TabIndex = 0;
            this.rdLayer.TabStop = true;
            this.rdLayer.Text = "Layer";
            this.rdLayer.UseVisualStyleBackColor = true;
            // 
            // rdLineType
            // 
            this.rdLineType.AutoSize = true;
            this.rdLineType.Location = new System.Drawing.Point(75, 34);
            this.rdLineType.Name = "rdLineType";
            this.rdLineType.Size = new System.Drawing.Size(65, 17);
            this.rdLineType.TabIndex = 0;
            this.rdLineType.TabStop = true;
            this.rdLineType.Text = "Linetype";
            this.rdLineType.UseVisualStyleBackColor = true;
            // 
            // rdTextStyle
            // 
            this.rdTextStyle.AutoSize = true;
            this.rdTextStyle.Location = new System.Drawing.Point(147, 34);
            this.rdTextStyle.Name = "rdTextStyle";
            this.rdTextStyle.Size = new System.Drawing.Size(67, 17);
            this.rdTextStyle.TabIndex = 0;
            this.rdTextStyle.TabStop = true;
            this.rdTextStyle.Text = "Textstyle";
            this.rdTextStyle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbTextstyle);
            this.groupBox4.Controls.Add(this.chbLineType);
            this.groupBox4.Controls.Add(this.chbLayer);
            this.groupBox4.Location = new System.Drawing.Point(32, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 93);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Checkboxes";
            // 
            // chbLayer
            // 
            this.chbLayer.AutoSize = true;
            this.chbLayer.Location = new System.Drawing.Point(13, 41);
            this.chbLayer.Name = "chbLayer";
            this.chbLayer.Size = new System.Drawing.Size(52, 17);
            this.chbLayer.TabIndex = 0;
            this.chbLayer.Text = "Layer";
            this.chbLayer.UseVisualStyleBackColor = true;
            // 
            // chbLineType
            // 
            this.chbLineType.AutoSize = true;
            this.chbLineType.Location = new System.Drawing.Point(84, 41);
            this.chbLineType.Name = "chbLineType";
            this.chbLineType.Size = new System.Drawing.Size(66, 17);
            this.chbLineType.TabIndex = 0;
            this.chbLineType.Text = "Linetype";
            this.chbLineType.UseVisualStyleBackColor = true;
            // 
            // chbTextstyle
            // 
            this.chbTextstyle.AutoSize = true;
            this.chbTextstyle.Location = new System.Drawing.Point(152, 41);
            this.chbTextstyle.Name = "chbTextstyle";
            this.chbTextstyle.Size = new System.Drawing.Size(68, 17);
            this.chbTextstyle.TabIndex = 0;
            this.chbTextstyle.Text = "Textstyle";
            this.chbTextstyle.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lstLayer;
        private System.Windows.Forms.Label lbTextStyleCount;
        private System.Windows.Forms.Label lbLineTypeCount;
        private System.Windows.Forms.Label lbLayerCount;
        private System.Windows.Forms.ListBox lstTextStyle;
        private System.Windows.Forms.ListBox lstLineType;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdTextStyle;
        private System.Windows.Forms.RadioButton rdLineType;
        private System.Windows.Forms.RadioButton rdLayer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chbTextstyle;
        private System.Windows.Forms.CheckBox chbLineType;
        private System.Windows.Forms.CheckBox chbLayer;
    }
}