namespace CC01.WinForms
{
    partial class frmCreerEtudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLieuNaiss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Photo 4x4";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(313, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(313, 398);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(267, 26);
            this.textBoxEmail.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "E-mail";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(313, 313);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(267, 26);
            this.textBoxContact.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contact";
            // 
            // textBoxLieuNaiss
            // 
            this.textBoxLieuNaiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLieuNaiss.Location = new System.Drawing.Point(12, 398);
            this.textBoxLieuNaiss.Name = "textBoxLieuNaiss";
            this.textBoxLieuNaiss.Size = new System.Drawing.Size(259, 26);
            this.textBoxLieuNaiss.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lieu de Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date de Naissance";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(12, 138);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(258, 26);
            this.textBoxNom.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(12, 243);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(258, 26);
            this.textBoxPrenom.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prenom";
            // 
            // textBoxMatricule
            // 
            this.textBoxMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatricule.Location = new System.Drawing.Point(12, 37);
            this.textBoxMatricule.Name = "textBoxMatricule";
            this.textBoxMatricule.Size = new System.Drawing.Size(258, 26);
            this.textBoxMatricule.TabIndex = 18;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(8, 14);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(73, 20);
            this.lblMatricule.TabIndex = 17;
            this.lblMatricule.Text = "Matricule";
            // 
            // brnCancel
            // 
            this.brnCancel.BackColor = System.Drawing.Color.Gold;
            this.brnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCancel.ForeColor = System.Drawing.Color.White;
            this.brnCancel.Location = new System.Drawing.Point(313, 452);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(267, 51);
            this.brnCancel.TabIndex = 34;
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
            this.btnSave.Location = new System.Drawing.Point(13, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 51);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCreerEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 515);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLieuNaiss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Name = "frmCreerEtudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCreerEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLieuNaiss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMatricule;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}