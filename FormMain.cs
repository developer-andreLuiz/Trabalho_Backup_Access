using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace SistemaBackupAccess
{
    public partial class FormMain : Form
    {
        bool a = true;
       
        //string localOriginal = @"C:\Arquivos Sistema Valendo\Banco_Dados\Soft.mdb";
        //string localCopia= @"C:\Users\MAINSERVIDOR\Google Drive\Banco de Dados\Soft.mdb";
        string localOriginal = @"C:\Users\devel\Desktop\t1\Soft.mdb";
        string localCopia = @"C:\Users\devel\Desktop\t2\Soft.mdb";

        public FormMain()
        {
            InitializeComponent();
           
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {

            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                reg.SetValue("Sistema Backup Access", Application.ExecutablePath.ToString());
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
           


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            if (lblHora.Text.Equals("06:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("08:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("09:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("12:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("15:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("18:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("20:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("21:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
            if (lblHora.Text.Equals("23:00:00"))
            {
                try
                {
                    File.Copy(localOriginal, localCopia, true);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }

            }
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a == true)
            {
                this.Hide();
                a = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                File.Copy(localOriginal, localCopia, true);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.Copy(localOriginal, localCopia, true);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
