using System.Windows.Forms;

namespace Lab1
{
    class Program
    {
        static int openFormsCount = 1;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            Form reg = new FrmRegistration();
            reg.FormClosed += OnFormClosed;
            reg.Show();

            Application.Run(reg);
        }
        static void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            openFormsCount--;
            if (openFormsCount == 0)
            {
                Application.Exit();
            }
        }
    }
}