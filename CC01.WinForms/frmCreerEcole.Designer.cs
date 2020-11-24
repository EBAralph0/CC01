namespace CC01.WinForms
{
    partial class frmCreerEcole
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
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEcomail = new System.Windows.Forms.TextBox();
            this.lblEcomail = new System.Windows.Forms.Label();
            this.textBoxIntitule = new System.Windows.Forms.TextBox();
            this.lblIntitule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // brnCancel
            // 
            this.brnCancel.BackColor = System.Drawing.Color.Gold;
            this.brnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCancel.ForeColor = System.Drawing.Color.White;
            this.brnCancel.Location = new System.Drawing.Point(316, 278);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(267, 51);
            this.brnCancel.TabIndex = 52;
            this.brnCancel.Text = "Cancel";
            this.brnCancel.UseVisualStyleBackColor = false;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(16, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(263, 51);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Logo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(316, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 221);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(12, 221);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(267, 26);
            this.textBoxTelephone.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Téléphone";
            // 
            // textBoxEcomail
            // 
            this.textBoxEcomail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEcomail.Location = new System.Drawing.Point(12, 129);
            this.textBoxEcomail.Name = "textBoxEcomail";
            this.textBoxEcomail.Size = new System.Drawing.Size(258, 26);
            this.textBoxEcomail.TabIndex = 40;
            // 
            // lblEcomail
            // 
            this.lblEcomail.AutoSize = true;
            this.lblEcomail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcomail.Location = new System.Drawing.Point(8, 106);
            this.lblEcomail.Name = "lblEcomail";
            this.lblEcomail.Size = new System.Drawing.Size(48, 20);
            this.lblEcomail.TabIndex = 39;
            this.lblEcomail.Text = "Email";
            // 
            // textBoxIntitule
            // 
            this.textBoxIntitule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIntitule.Location = new System.Drawing.Point(12, 39);
            this.textBoxIntitule.Name = "textBoxIntitule";
            this.textBoxIntitule.Size = new System.Drawing.Size(258, 26);
            this.textBoxIntitule.TabIndex = 36;
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntitule.Location = new System.Drawing.Point(8, 16);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(57, 20);
            this.lblIntitule.TabIndex = 35;
            this.lblIntitule.Text = "Intitulé";
            // 
            // frmCreerEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 365);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEcomail);
            this.Controls.Add(this.lblEcomail);
            this.Controls.Add(this.textBoxIntitule);
            this.Controls.Add(this.lblIntitule);
            this.Name = "frmCreerEcole";
            this.Text = "frmCreerEcole";
            this.Load += new System.EventHandler(this.frmCreerEcole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEcomail;
        private System.Windows.Forms.Label lblEcomail;
        private System.Windows.Forms.TextBox textBoxIntitule;
        private System.Windows.Forms.Label lblIntitule;
    }
}