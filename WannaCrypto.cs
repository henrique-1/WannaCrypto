using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace WannaCrypto
{
    public partial class WannaCrypto : Form
    {
        public static byte[] defaultSalt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public string[] trashList;
        private static string salty = "SomethingReallySaltyByNarinaIndustries";

        OpenFileDialog fs = null;

        public WannaCrypto()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();

        private void PnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void WannaCrypto_Load(object sender, EventArgs e)
        {
            trashList = new string[0];
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            lblFileSelected.Text = "Nenhum arquivo foi selecionado";
            fs = new OpenFileDialog();
            DialogResult dr = fs.ShowDialog();
            if (fs.FileName.Length > 0)
            {
                lblFileSelected.Text = fs.FileName;
            }
        }

        private void TxtPassword1_Enter(object sender, EventArgs e)
        {
            if (txtPassword1.Text != "Password 1")
            {
                txtPassword1.ForeColor = Color.Black;
            }

            if (txtPassword1.Text == "Password 1")
            {
                txtPassword1.ForeColor = Color.Black;
                txtPassword1.Text = "";
            }
        }

        private void TxtPassword1_Leave(object sender, EventArgs e)
        {
            if (txtPassword1.Text == "")
            {
                txtPassword1.Text = "Password 1";
                txtPassword1.ForeColor = Color.DarkGray;
            }
        }

        private void TxtPassword2_Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text != "Password 2")
            {

            }

            if (txtPassword2.Text == "Password 2")
            {
                txtPassword2.ForeColor = Color.Black;
                txtPassword2.Text = "";
            }
        }

        private void TxtPassword2_Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "")
            {
                txtPassword2.Text = "Password 2";
                txtPassword2.ForeColor = Color.DarkGray;
            }
        }

        private void TxtPassword3_Enter(object sender, EventArgs e)
        {
            if (txtPassword3.Text != "Password 3")
            {

            }

            if (txtPassword3.Text == "Password 3")
            {
                txtPassword3.ForeColor = Color.Black;
                txtPassword3.Text = "";
            }
        }

        private void TxtPassword3_Leave(object sender, EventArgs e)
        {
            if (txtPassword3.Text == "")
            {
                txtPassword3.Text = "Password 3";
                txtPassword3.ForeColor = Color.DarkGray;
            }
        }

        private void TxtPassword4_Enter(object sender, EventArgs e)
        {
            if (txtPassword4.Text != "Password 4")
            {

            }

            if (txtPassword4.Text == "Password 4")
            {
                txtPassword4.ForeColor = Color.Black;
                txtPassword4.Text = "";
            }
        }

        private void TxtPassword4_Leave(object sender, EventArgs e)
        {
            if (txtPassword4.Text == "")
            {
                txtPassword4.Text = "Password 4";
                txtPassword4.ForeColor = Color.DarkGray;
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (fs == null)
            {
                string text = "Você não selecionou um arquivo, por favor selecione";
                string About = "Selecione um arquivo";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fs = new OpenFileDialog();
                DialogResult dr = fs.ShowDialog();
            }
            else if (fs.FileName.Length <= 0)
            {
                string text = "Você não selecionou um arquivo, por favor selecione";
                string About = "Selecione um arquivo";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fs = new OpenFileDialog();
                DialogResult dr = fs.ShowDialog();
            }
            else if (txtPassword1.Text == "Password 1")
            {
                string text = "Sua senha não pode ser Password 1";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword2.Text == "Password 2")
            {
                string text = "Sua senha não pode ser Password 2";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword3.Text == "Password 3")
            {
                string text = "Sua senha não pode ser Password 3";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword4.Text == "Password 4")
            {
                string text = "Sua senha não pode ser Password 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword1.Text == txtPassword2.Text)
            {
                string text = "A Senha 1 não pode ser igual a Senha 2";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword1.Text == txtPassword3.Text)
            {
                string text = "A Senha 1 não pode ser igual a Senha 3";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword1.Text == txtPassword4.Text)
            {
                string text = "A Senha 1 não pode ser igual a Senha 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword2.Text == txtPassword3.Text)
            {
                string text = "A Senha 2 não pode ser igual a Senha 3";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword2.Text == txtPassword4.Text)
            {
                string text = "A Senha 2 não pode ser igual a Senha 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword3.Text == txtPassword4.Text)
            {
                string text = "A Senha 3 não pode ser igual a Senha 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string files;
                files = fs.FileName.ToString();
                Thread thread = new Thread(() => Encrypt(files));
                thread.Start();
                //Encrypt();
                string text = "Seu arquivo está sendo Encriptado. Aguarde que as Threads estão trabalhando nisso!";
                string About = "Sucesso";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Encrypt(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);

            string pass = txtPassword1.Text;

            pass = Hash(Hash(Hash(Hash(pass) + Hash(txtPassword2.Text)) + Hash(txtPassword3.Text) + Hash(txtPassword4.Text) + Hash(salty)));

            string[] tempFile = file.Split(new string[] { "\\" }, StringSplitOptions.None);
            string fn = tempFile[tempFile.Length - 1];


            fn = Crypto.EncryptStringAES(fn, pass);

            fn = Base64Encode(fn);

            File.WriteAllBytes(file + ".temp", bytes);
            string finalFile = file.Remove(file.Length - tempFile[tempFile.Length - 1].Length) + fn + ".WannaCrypto";
            AES_Encrypt(file + ".temp", finalFile, Encoding.ASCII.GetBytes(pass));
            File.Delete(file + ".temp");
            File.Delete(file);
            string text = "Seu arquivo foi Encriptado com Sucesso!";
            string About = "Sucesso";
            MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private static void AES_Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
        {
            //TODO: Set your own salt bytes.
            byte[] saltBytes = new byte[] { 7, 2, 8, 1, 3, 0, 4, 3 };

            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);


            fsIn.Close();
            cs.Close();
            fsCrypt.Close();

        }

        private void BtnDectypt_Click(object sender, EventArgs e)
        {
            if (fs == null)
            {
                string text = "Você não selecionou um arquivo, por favor selecione";
                string About = "Selecione um arquivo";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fs = new OpenFileDialog();
                DialogResult dr = fs.ShowDialog();
            }
            else if (fs.FileName.Length <= 0)
            {
                string text = "Você não selecionou um arquivo, por favor selecione";
                string About = "Selecione um arquivo";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fs = new OpenFileDialog();
                DialogResult dr = fs.ShowDialog();
            }
            else if (txtPassword1.Text == "Password 1")
            {
                string text = "Sua senha não pode ser Password 1";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword2.Text == "Password 2")
            {
                string text = "Sua senha não pode ser Password 2";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword3.Text == "Password 3")
            {
                string text = "Sua senha não pode ser Password 3";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword4.Text == "Password 4")
            {
                string text = "Sua senha não pode ser Password 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword1.Text == txtPassword2.Text)
            {
                string text = "A Senha 1 não pode ser igual a Senha 2";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword1.Text == txtPassword3.Text)
            {
                string text = "A Senha 1 não pode ser igual a Senha 3";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword1.Text == txtPassword4.Text)
            {
                string text = "A Senha 1 não pode ser igual a Senha 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword2.Text == txtPassword3.Text)
            {
                string text = "A Senha 2 não pode ser igual a Senha 3";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword2.Text == txtPassword4.Text)
            {
                string text = "A Senha 2 não pode ser igual a Senha 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword3.Text == txtPassword4.Text)
            {
                string text = "A Senha 3 não pode ser igual a Senha 4";
                string About = "Senha";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string files;
                files = fs.FileName.ToString();
                Thread thread = new Thread(() => Decrypt(files));
                thread.Start();
                //Decrypt();
                string text = "Seu arquivo está sendo Decriptado. Aguarde que as Threads estão trabalhando nisso!";
                string About = "Sucesso";
                MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Decrypt(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);

            string pass = txtPassword1.Text;

            pass = Hash(Hash(Hash(Hash(pass) + Hash(txtPassword2.Text)) + Hash(txtPassword3.Text) + Hash(txtPassword4.Text) + Hash(salty)));

            string[] tempFile = file.Split(new string[] { "\\" }, StringSplitOptions.None);
            string fn = tempFile[tempFile.Length - 1];
            fn = fn.Remove(fn.Length - ".WannaCrypto".Length);

            fn = Base64Decode(fn);

            fn = Crypto.DecryptStringAES(fn, pass);


            File.WriteAllBytes(file + ".temp", bytes);
            AES_Decrypt(file + ".temp", file.Remove(file.Length - tempFile[tempFile.Length - 1].Length) + fn, Encoding.ASCII.GetBytes(pass));
            File.Delete(file + ".temp");
            File.Delete(file);
            string text = "Seu arquivo foi Decriptado com Sucesso!";
            string About = "Sucesso";
            MessageBox.Show(text, About, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private static void AES_Decrypt(string inputFile, string outputFile, byte[] passwordBytes)
        {
            //TODO: Set your own salt bytes.
            byte[] saltBytes = new byte[] { 7, 2, 8, 1, 3, 0, 4, 3 };
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;


            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.Zeros;

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt,
                AES.CreateDecryptor(),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();

        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        public string Reverse(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public void AddToTrashList(string value)
        {
            Array.Resize(ref trashList, trashList.Length + 1);
            trashList[trashList.Length - 1] = value;
        }

        private void BtnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
