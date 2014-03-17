namespace sdubois_wk1_indiv
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
            this.btnGetPet = new System.Windows.Forms.Button();
            this.lblPetName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetPet
            // 
            this.btnGetPet.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetPet.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnGetPet.FlatAppearance.BorderSize = 4;
            this.btnGetPet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPet.Location = new System.Drawing.Point(66, 112);
            this.btnGetPet.Name = "btnGetPet";
            this.btnGetPet.Size = new System.Drawing.Size(111, 39);
            this.btnGetPet.TabIndex = 0;
            this.btnGetPet.Text = "Pet\'s Name";
            this.btnGetPet.UseVisualStyleBackColor = false;
            this.btnGetPet.Click += new System.EventHandler(this.btnGetPet_Click);
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPetName.Location = new System.Drawing.Point(12, 24);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(230, 62);
            this.lblPetName.TabIndex = 1;
            this.lblPetName.Text = "Godzilla";
            this.lblPetName.Visible = false;
            this.lblPetName.Click += new System.EventHandler(this.lblPetName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 163);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.btnGetPet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDuBois_wk1_Indiv";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPet;
        private System.Windows.Forms.Label lblPetName;

    }
}

