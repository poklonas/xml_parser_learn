namespace xml_parser_test
{
    partial class XML_PARSER
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.openFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.output_box = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFiles
            // 
            this.openFiles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.openFiles.ForeColor = System.Drawing.Color.Black;
            this.helpProvider1.SetHelpNavigator(this.openFiles, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.openFiles.Location = new System.Drawing.Point(36, 12);
            this.openFiles.Name = "openFiles";
            this.helpProvider1.SetShowHelp(this.openFiles, true);
            this.openFiles.Size = new System.Drawing.Size(223, 33);
            this.openFiles.TabIndex = 1;
            this.openFiles.Text = "Select XML file";
            this.openFiles.UseVisualStyleBackColor = false;
            this.openFiles.Click += new System.EventHandler(this.openFiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.output_box);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(36, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "output";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(299, 22);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Path";
            // 
            // selectFile
            // 
            this.selectFile.FileName = "selectFile";
            this.selectFile.Filter = "XML|*xml";
            // 
            // output_box
            // 
            this.output_box.BackColor = System.Drawing.Color.PaleGreen;
            this.output_box.Location = new System.Drawing.Point(16, 30);
            this.output_box.Multiline = true;
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_box.Size = new System.Drawing.Size(683, 331);
            this.output_box.TabIndex = 0;
            // 
            // XML_PARSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.openFiles);
            this.Controls.Add(this.groupBox1);
            this.Name = "XML_PARSER";
            this.Text = "XML PARSER";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openFiles;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.OpenFileDialog selectFile;
        private System.Windows.Forms.TextBox output_box;
    }
}

