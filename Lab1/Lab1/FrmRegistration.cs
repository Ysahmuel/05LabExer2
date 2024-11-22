using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FrmRegistration : Form
    {

        private static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SetFileName = txtStudNo.Text;

            string getStudNo = txtStudNo.Text;
            string getFullName = txtLName.Text + ", " + txtFName.Text + ", " + txtMI.Text;
            string getProgram = cbProgram.Text;
            string getGender = cbGender.Text;
            string getAge = txtAge.Text;
            string getBirthday = dtBirthday.Value.ToString("yyyy-MM-dd");
            string getCNo = txtCNo.Text;

            try
            {
                string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
                SetFileName)))
                {
                    outputFile.WriteLine("Student No.: " + getStudNo +
                    "\nFull Name: " + getFullName +
                    "\nProgram: " + getProgram +
                    "\nGender: " + getGender +
                    "\nAge: " + getAge +
                    "\nBirthday: " + getBirthday +
                    "\nContact No.: " + getCNo);

                    Console.WriteLine("Student No.: " + getStudNo +
                    "\nFull Name: " + getFullName +
                    "\nProgram: " + getProgram +
                    "\nGender: " + getGender +
                    "\nAge: " + getAge +
                    "\nBirthday: " + getBirthday +
                    "\nContact No.: " + getCNo);
                }

                void ClearAll()
                {
                    txtStudNo.Text = "";
                    txtLName.Text = "";
                    txtFName.Text = "";
                    txtMI.Text = "";
                    txtAge.Text = "";
                    txtCNo.Text = "";
                }

                MessageBox.Show("Registered Successfully!");
                ClearAll();
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "String Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Currency Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }

        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord(this);
            record.Show();
            this.Hide();

        }
    }
}
