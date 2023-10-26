namespace RoundPartitionCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkSource = new LinkLabel();
            label1 = new Label();
            txtTbValue = new TextBox();
            groupBox1 = new GroupBox();
            btnCopyTb = new Button();
            label5 = new Label();
            txtTbOverhead = new TextBox();
            label4 = new Label();
            txtTbConvertToMib = new TextBox();
            label3 = new Label();
            txtTbConvertToMb = new TextBox();
            lblError = new Label();
            groupBox2 = new GroupBox();
            btnCopyGb = new Button();
            label6 = new Label();
            txtGbOverhead = new TextBox();
            label7 = new Label();
            txtGbConvertToMib = new TextBox();
            label8 = new Label();
            txtGbConvertToMb = new TextBox();
            label10 = new Label();
            txtGbValue = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // linkSource
            // 
            linkSource.AutoSize = true;
            linkSource.Location = new Point(26, 330);
            linkSource.Name = "linkSource";
            linkSource.Size = new Size(147, 15);
            linkSource.TabIndex = 0;
            linkSource.TabStop = true;
            linkSource.Text = "Source: ErikN - Spiceworks";
            linkSource.LinkClicked += linkSource_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "TB";
            label1.Click += label1_Click;
            // 
            // txtTbValue
            // 
            txtTbValue.Location = new Point(16, 65);
            txtTbValue.Name = "txtTbValue";
            txtTbValue.Size = new Size(100, 23);
            txtTbValue.TabIndex = 3;
            txtTbValue.KeyUp += txtTbValue_KeyUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopyTb);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTbOverhead);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTbConvertToMib);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTbConvertToMb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTbValue);
            groupBox1.Location = new Point(24, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(548, 110);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convert using TB";
            // 
            // btnCopyTb
            // 
            btnCopyTb.Enabled = false;
            btnCopyTb.Location = new Point(456, 64);
            btnCopyTb.Name = "btnCopyTb";
            btnCopyTb.Size = new Size(75, 23);
            btnCopyTb.TabIndex = 13;
            btnCopyTb.Text = "Copy";
            btnCopyTb.UseVisualStyleBackColor = true;
            btnCopyTb.Click += btnCopyTb_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 47);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 11;
            label5.Text = "Add Overhead";
            // 
            // txtTbOverhead
            // 
            txtTbOverhead.Location = new Point(334, 65);
            txtTbOverhead.Name = "txtTbOverhead";
            txtTbOverhead.ReadOnly = true;
            txtTbOverhead.Size = new Size(100, 23);
            txtTbOverhead.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 47);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 9;
            label4.Text = "Convert to MiB";
            // 
            // txtTbConvertToMib
            // 
            txtTbConvertToMib.Location = new Point(228, 65);
            txtTbConvertToMib.Name = "txtTbConvertToMib";
            txtTbConvertToMib.ReadOnly = true;
            txtTbConvertToMib.Size = new Size(100, 23);
            txtTbConvertToMib.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 47);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "Convert to MB";
            // 
            // txtTbConvertToMb
            // 
            txtTbConvertToMb.Location = new Point(122, 65);
            txtTbConvertToMb.Name = "txtTbConvertToMb";
            txtTbConvertToMb.ReadOnly = true;
            txtTbConvertToMb.Size = new Size(100, 23);
            txtTbConvertToMb.TabIndex = 8;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(26, 306);
            lblError.Name = "lblError";
            lblError.Size = new Size(40, 15);
            lblError.TabIndex = 7;
            lblError.Text = "Errors:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCopyGb);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtGbOverhead);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtGbConvertToMib);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtGbConvertToMb);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtGbValue);
            groupBox2.Location = new Point(24, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(548, 109);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Convert using GB";
            // 
            // btnCopyGb
            // 
            btnCopyGb.Enabled = false;
            btnCopyGb.Location = new Point(456, 64);
            btnCopyGb.Name = "btnCopyGb";
            btnCopyGb.Size = new Size(75, 23);
            btnCopyGb.TabIndex = 13;
            btnCopyGb.Text = "Copy";
            btnCopyGb.UseVisualStyleBackColor = true;
            btnCopyGb.Click += btnCopyGb_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 47);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 11;
            label6.Text = "Add Overhead";
            // 
            // txtGbOverhead
            // 
            txtGbOverhead.Location = new Point(334, 65);
            txtGbOverhead.Name = "txtGbOverhead";
            txtGbOverhead.ReadOnly = true;
            txtGbOverhead.Size = new Size(100, 23);
            txtGbOverhead.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 47);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 9;
            label7.Text = "Convert to MiB";
            // 
            // txtGbConvertToMib
            // 
            txtGbConvertToMib.Location = new Point(228, 65);
            txtGbConvertToMib.Name = "txtGbConvertToMib";
            txtGbConvertToMib.ReadOnly = true;
            txtGbConvertToMib.Size = new Size(100, 23);
            txtGbConvertToMib.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(122, 47);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 7;
            label8.Text = "Convert to MB";
            // 
            // txtGbConvertToMb
            // 
            txtGbConvertToMb.Location = new Point(122, 65);
            txtGbConvertToMb.Name = "txtGbConvertToMb";
            txtGbConvertToMb.ReadOnly = true;
            txtGbConvertToMb.Size = new Size(100, 23);
            txtGbConvertToMb.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 47);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 1;
            label10.Text = "GB";
            // 
            // txtGbValue
            // 
            txtGbValue.Location = new Point(16, 65);
            txtGbValue.Name = "txtGbValue";
            txtGbValue.Size = new Size(100, 23);
            txtGbValue.TabIndex = 3;
            txtGbValue.KeyUp += txtGbValue_KeyUp;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 281);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 6;
            label9.Text = "Feel free to use decimals";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 365);
            Controls.Add(groupBox2);
            Controls.Add(lblError);
            Controls.Add(groupBox1);
            Controls.Add(linkSource);
            Controls.Add(label9);
            Name = "Form1";
            Text = "Windows Round Partition Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkSource;
        private Label label1;
        private TextBox txtTbValue;
        private GroupBox groupBox1;
        private Button btnCopyTb;
        private Label label5;
        private TextBox txtTbOverhead;
        private Label label4;
        private TextBox txtTbConvertToMib;
        private Label label3;
        private TextBox txtTbConvertToMb;
        private Label lblError;
        private GroupBox groupBox2;
        private Button btnCopyGb;
        private Label label6;
        private TextBox txtGbOverhead;
        private Label label7;
        private TextBox txtGbConvertToMib;
        private Label label8;
        private TextBox txtGbConvertToMb;
        private Label label10;
        private TextBox txtGbValue;
        private Label label9;
    }
}