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
            this.output_box = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_descrip = new System.Windows.Forms.TextBox();
            this.input_price = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.input_cal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.only_name = new System.Windows.Forms.Button();
            this.allSchema = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.pathLabel);
            this.groupBox1.Controls.Add(this.output_box);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(36, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "output";
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
            this.output_box.TextChanged += new System.EventHandler(this.output_box_TextChanged);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(13, 14);
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
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(137, 445);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(233, 20);
            this.input_name.TabIndex = 2;
            this.input_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_descrip
            // 
            this.input_descrip.Location = new System.Drawing.Point(137, 468);
            this.input_descrip.Name = "input_descrip";
            this.input_descrip.Size = new System.Drawing.Size(233, 20);
            this.input_descrip.TabIndex = 3;
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(425, 445);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(87, 20);
            this.input_price.TabIndex = 4;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Coral;
            this.add.Location = new System.Drawing.Point(518, 442);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(237, 45);
            this.add.TabIndex = 5;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // input_cal
            // 
            this.input_cal.Location = new System.Drawing.Point(425, 471);
            this.input_cal.Name = "input_cal";
            this.input_cal.Size = new System.Drawing.Size(87, 20);
            this.input_cal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "description";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Pink;
            this.save.Location = new System.Drawing.Point(606, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(149, 33);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // only_name
            // 
            this.only_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.only_name.Location = new System.Drawing.Point(265, 12);
            this.only_name.Name = "only_name";
            this.only_name.Size = new System.Drawing.Size(134, 33);
            this.only_name.TabIndex = 11;
            this.only_name.Text = "Only Food Name";
            this.only_name.UseVisualStyleBackColor = false;
            this.only_name.Click += new System.EventHandler(this.only_name_Click);
            // 
            // allSchema
            // 
            this.allSchema.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.allSchema.Location = new System.Drawing.Point(405, 12);
            this.allSchema.Name = "allSchema";
            this.allSchema.Size = new System.Drawing.Size(134, 33);
            this.allSchema.TabIndex = 12;
            this.allSchema.Text = "show all";
            this.allSchema.UseVisualStyleBackColor = false;
            this.allSchema.Click += new System.EventHandler(this.allSchema_Click);
            // 
            // XML_PARSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 499);
            this.Controls.Add(this.allSchema);
            this.Controls.Add(this.only_name);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_cal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.input_descrip);
            this.Controls.Add(this.input_name);
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
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_descrip;
        private System.Windows.Forms.TextBox input_price;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox input_cal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button only_name;
        private System.Windows.Forms.Button allSchema;
    }
}

