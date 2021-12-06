using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeshop
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_tb.Text == "" || pa_tb.Text == "")
            {
                MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");
            }
            else
            {
                DBManager.getInstance().insert("insert into coffeecasher values('" + pa_tb.Text + "',1 ,'" + id_tb.Text + "',0)");
                MessageBox.Show("회원 가입 신청이 완료 되었습니다. 관리자가 승인 할 때 까지 기다리세요~");
                Login login = new Login();
                Hide();
                login.ShowDialog();
                Close();
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Close();
        }
    }
}
