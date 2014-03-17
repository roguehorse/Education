namespace sdubois_wk2_indiv
{
    partial class Form1
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDie2 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblDie1Result = new System.Windows.Forms.Label();
            this.txtDie1 = new System.Windows.Forms.TextBox();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotalsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(329, 32);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "The following program will roll 2 dice 100 times\r\nthen write the values to a file" +
                ".";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1.Location = new System.Drawing.Point(123, 114);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(44, 16);
            this.lblDie1.TabIndex = 1;
            this.lblDie1.Text = "Die 1";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie2.Location = new System.Drawing.Point(123, 153);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(44, 16);
            this.lblDie2.TabIndex = 2;
            this.lblDie2.Text = "Die 2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(123, 198);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtDie2
            // 
            this.txtDie2.BackColor = System.Drawing.Color.White;
            this.txtDie2.Enabled = false;
            this.txtDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDie2.ForeColor = System.Drawing.Color.Black;
            this.txtDie2.Location = new System.Drawing.Point(173, 152);
            this.txtDie2.Name = "txtDie2";
            this.txtDie2.Size = new System.Drawing.Size(47, 20);
            this.txtDie2.TabIndex = 5;
            this.txtDie2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(173, 197);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(47, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(83, 243);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(84, 23);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Write Values";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(192, 243);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(83, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read Values";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblDie1Result
            // 
            this.lblDie1Result.AutoSize = true;
            this.lblDie1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie1Result.Location = new System.Drawing.Point(175, 97);
            this.lblDie1Result.Name = "lblDie1Result";
            this.lblDie1Result.Size = new System.Drawing.Size(0, 16);
            this.lblDie1Result.TabIndex = 10;
            // 
            // txtDie1
            // 
            this.txtDie1.BackColor = System.Drawing.Color.White;
            this.txtDie1.Enabled = false;
            this.txtDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDie1.ForeColor = System.Drawing.Color.Black;
            this.txtDie1.Location = new System.Drawing.Point(173, 113);
            this.txtDie1.Name = "txtDie1";
            this.txtDie1.Size = new System.Drawing.Size(47, 20);
            this.txtDie1.TabIndex = 11;
            this.txtDie1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(3, 51);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(350, 16);
            this.lblDescription2.TabIndex = 13;
            this.lblDescription2.Text = "Click Read Values to view the output file contents.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 13);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(372, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 212);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTotalsOutput
            // 
            this.lblTotalsOutput.AutoSize = true;
            this.lblTotalsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalsOutput.Location = new System.Drawing.Point(386, 9);
            this.lblTotalsOutput.Name = "lblTotalsOutput";
            this.lblTotalsOutput.Size = new System.Drawing.Size(132, 16);
            this.lblTotalsOutput.TabIndex = 16;
            this.lblTotalsOutput.Text = "Roll Totals Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 280);
            this.Controls.Add(this.lblTotalsOutput);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.txtDie1);
            this.Controls.Add(this.lblDie1Result);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDie2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.lblDescription);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sdubois_wk2_indiv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDie2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblDie1Result;
        private System.Windows.Forms.TextBox txtDie1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTotalsOutput;
    }
}

