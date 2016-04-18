using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BaoMatCSDL
{
    public partial class frmDanhSachSinhVien : Form
    {
        public frmDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLSVDataSet);

        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.LOP' table. You can move, or remove it, as needed.
          //  this.lOPTableAdapter.Fill(this.qLSVDataSet.LOP);
          

        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            using (var db = new QLSVEntities())
            {

                string mANV = textBox1.Text;
                string hOTEN = textBox4.Text;
                string eMAIL = textBox2.Text;
                byte[] Key = CreateKey("1112072");
                byte[] e_LUONG = EncryptStringToBytes_Aes("900000", Key);
                string tENDN = textBox3.Text;           
                byte[] e_mATKHAU =SHA1.Create().ComputeHash(UnicodeEncoding.Unicode.GetBytes(textBox6.Text));        
                db.SP_INS_ENCRYPT_NHANVIEN(mANV,  hOTEN,eMAIL, e_LUONG,  tENDN, e_mATKHAU); // <Model>.Context.cs
                MessageBox("Da Them Thanh Cong 1 Nhan Vien");

            

               
            }
        }

        private void MessageBox(string p)
        {
            throw new NotImplementedException();
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key)
        {
           
            // Check arguments. 
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
         
            byte[] encrypted;
            // Create an Aes object 
            // with the specified key and IV. 
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 6, 3, 3, 0,5, 1, 3};
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption. 
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            
            // Return the encrypted bytes from the memory stream. 
            return encrypted;

        }
        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }
        private static readonly byte[] Salt =  new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        private void but_Loadtable_Click(object sender, EventArgs e)
        {
            var db = new QLSVEntities();
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = (from r in db.NHANVIENs
                                         select r).ToList();

           
            dataGridView1.DataSource = bindingSource1;
        }

    }
       

}
