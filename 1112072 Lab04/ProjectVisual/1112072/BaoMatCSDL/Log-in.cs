using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // For MD5 & SHA 

namespace BaoMatCSDL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void but_LogIn_Click(object sender, EventArgs e)
        {
              if (checkUserData(txt_ID.Text, txt_PWD.Text))
            {
                  MessageBox.Show("Login success!");
                  frmDanhSachSinhVien frmDanhSachSinhVien = new frmDanhSachSinhVien();
                  frmDanhSachSinhVien.ShowDialog();
            }                
            else
            {
                MessageBox.Show("Login Failed! Please Check Your ID and PWD");
            }
                
        }

        Boolean checkUserData(String userName, String Pass)
        {

            using (var db = new QLSVEntities())
            {
                byte[] _p = MD5.Create().ComputeHash(UnicodeEncoding.Unicode.GetBytes(Pass));

                Boolean a = db.SINHVIENs.Any(u => u.MASV == userName && u.MATKHAU == _p);
                if (!a)
                {
                    _p = SHA1.Create().ComputeHash(UnicodeEncoding.Unicode.GetBytes(Pass));
                    a = db.NHANVIENs.Any(u => u.MANV == userName && u.MATKHAU == _p);
                }
                return a;
            }
        }
        
    }
}
