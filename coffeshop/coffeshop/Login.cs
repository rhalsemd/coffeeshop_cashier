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
    public partial class Login : Form
    {
        Form1 form1;
        public static string startdate;
        public static string id;
        public Login()
        {
            InitializeComponent();
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            form1= new Form1();
            string password = null;
            id = id_tb.Text;
            password = pa_tb.Text;
            string str = null;
            int state = -1;
            if (id == "" || password == "")
            {
                MessageBox.Show("아이디 혹은 비밀번호를 입력하세요.");
            }
            else
            {
                DataTable dt = DBManager.getInstance().select("SELECT admin,state FROM coffeecasher WHERE uid='" + id + "'AND password='" + password + "'");
                foreach (DataRow row in dt.Rows)
                {
                    str = string.Format("{0}", row["admin"]);
                    state = Convert.ToInt32(string.Format("{0}", row["state"]));
                }
                if (str == null)
                {
                    MessageBox.Show("아이디 혹은 비밀번호가 틀렸습니다.");
                }
                else if(state == 0)
                {
                    MessageBox.Show("가입 대기 중 입니다. 관리자가 승인 할 때 까지 기다리세요~");
                }
                else if (state == 2)
                {
                    MessageBox.Show("로그인이 제한 되었습니다.");
                }
                else
                {
                    int admin = Convert.ToInt32(str);
                    if (admin == 0)
                    {
                        Form1.cus = true;
                        Form1.adm = true;
                    }
                    else if (admin == 1)
                    {
                        Form1.cus = true;
                        Form1.adm = false;
                    }
                    form1.label3.Text = id + "님이 로그인 하셨습니다.";
                    form1.label4.Text = "구매하고 싶은 날짜를 고르세요.";
                    startdate= DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                    int ca = DBManager.getInstance().insert("insert into coffeelogin(uid, attendance, absent) values('"+id+"','"+ startdate+ "', 0)");
                    Hide();
                    form1.ShowDialog();
                    Close();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e) //회원가입
        {
            signup signup = new signup();
            Hide();
            signup.ShowDialog();
            Close();
        }
    }
}
