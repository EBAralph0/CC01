using CC01.BO;
using CC01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CC01.WinForms
{
    public partial class frmCreerEtudiant : Form
    {
        private Action callBack;
        private Etudiant oldEtudiant;

        public frmCreerEtudiant(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public frmCreerEtudiant(Etudiant etudiant, Action callBack) : this(callBack)
        {
            this.oldEtudiant = etudiant;
            textBoxNom.Text = etudiant.Nom;
            textBoxPrenom.Text = etudiant.Prenom;
            textBoxMatricule.Text = etudiant.Matricule;
            dateTimePicker1.Text = etudiant.DateNaissance.ToString();
            textBoxLieuNaiss.Text = etudiant.LieuNaissance;
            textBoxContact.Text = etudiant.Contact.ToString();
            textBoxEmail.Text = etudiant.Email;
            if (etudiant.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(etudiant.Photo));
        }
        public frmCreerEtudiant()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            checkForm();
            string filename = null;
            Etudiant e1 = new Etudiant(
                textBoxNom.Text,
                textBoxPrenom.Text,
                dateTimePicker1.Text,
                textBoxLieuNaiss.Text,
                textBoxMatricule.Text.ToUpper(),
                long.Parse(textBoxContact.Text),
                textBoxEmail.Text,
                !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEtudiant?.Photo
                );
            EtudiantBLO pblo = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            pblo.CreateProduct(e1);
            MessageBox.Show(
                "Save done !",
                 "Confirm",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                );
            textBoxMatricule.Clear();
            textBoxNom.Clear();
            textBoxContact.Clear();
            textBoxEmail.Clear();
            textBoxLieuNaiss.Clear();
            textBoxPrenom.Focus();
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {

        }

        private void checkForm()
        {
            string text = string.Empty;
            textBoxMatricule.BackColor = Color.White;
            textBoxNom.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(textBoxMatricule.Text))
            {
                text += "- Please enter the reference ! \n";
                textBoxMatricule.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(textBoxNom.Text))
            {
                text += "- Please enter the name ! \n";
                textBoxNom.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }
    }
}
