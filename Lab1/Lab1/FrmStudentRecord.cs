using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FrmStudentRecord : Form
    {

        private FrmRegistration registrationForm;
        FrmRegistration frmRegistration = new FrmRegistration();

        public FrmStudentRecord(FrmRegistration registrationForm)
        {
            InitializeComponent();

            this.registrationForm = registrationForm;

            this.FormClosed += FrmStudentRecord_FormClosed;
        }

        private void FrmStudentRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (registrationForm != null && !registrationForm.IsDisposed)
            {
                registrationForm.Close();
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration.Show();

            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lvShowText.Items.Clear();
        }
    }
}
