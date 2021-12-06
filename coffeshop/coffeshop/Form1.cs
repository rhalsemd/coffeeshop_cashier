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
    public partial class Form1 : Form
    {

        public static bool cus = false;
        public static bool adm = false;
        public string date = null;

        public string fixname=null;
        public string fixdate=null;
        public int fixid = 0;
        Login login;
        manager managers;

        string[] nameArray;
        int menucount = 0;

        public Form1()
        {   
            InitializeComponent();
            label3.Text = Login.id + "님이 로그인 하셨습니다.";

            date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            DataTable dtcount = DBManager.getInstance().select("select count(*) from coffeemenu");
            foreach (DataRow row in dtcount.Rows)
            {
                int numcounts = Convert.ToInt32(string.Format("{0}", row["count(*)"]));
                nameArray = new string[numcounts];
                menucount = numcounts;
            }

            DataTable dt = DBManager.getInstance().select("select * from coffeemenu");

            string name = null;
            int price = 0;

            foreach (DataRow row in dt.Rows)
            {
                name = string.Format("{0}", row["name"]);
                price = Convert.ToInt32(string.Format("{0}", row["price"]));
                if (name != null && price != 0)
                {
                    menuadd(name, price);
                }        
            }
        }
        
        private void logout_Click(object sender, EventArgs e)
        {
            login = new Login();
            cus = false;
            adm = false;
            label4.Text = "";
            MessageBox.Show("로그아웃 되었습니다.");
            string dates = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            int ca = DBManager.getInstance().update("update coffeelogin set absent='"+dates+"' where uid ='" + Login.id + "'and attendance='"+ Login.startdate + "'");
            Hide();
            login.ShowDialog();
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cus == true)
            {
                DateTime dt1 = dateTimePicker1.Value;
                date = dt1.ToString("yyyy-MM-dd-HH-mm-ss");
            }
            else
            {
                MessageBox.Show("로그인 하세요.");
            }
        }

        private void 관리자모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adm == true)
            {
                managers = new manager();
                Hide();
                managers.ShowDialog();
                Close();
            }
            else if (cus == true)
            {
                MessageBox.Show("관리자만 사용 가능합니다.");
            }
        }
        private void button_Coffee_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            Button thisBtn = (Button)sender;
            int ca = DBManager.getInstance().insert("INSERT INTO coffeeorders (pricedate, uid, coffeename) VALUES('" + date + "','" + Login.id + "',(select name from coffeemenu where id=" + thisBtn.Tag+"))");
            MessageBox.Show("구매 하셨습니다.");
        }
        int line_number = 1;
        int lines = 0;
        int num_buttons = 1;
        private void menuadd(string name, int price)
        {
            if (line_number % 6 == 0)
            {
                line_number = 1;
                lines+=50;
            }
            Button btn = new Button();
            btn.Location = new System.Drawing.Point((line_number * 95) - 90, lines+181);
            btn.Name = name;
            btn.Size = new System.Drawing.Size(80, 50);
            btn.TabIndex = 1;
            btn.Text = name + "\n"+price.ToString();
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.button_Coffee_Click);
            btn.Parent = this;
            btn.Tag = num_buttons;
            nameArray[num_buttons-1] = name + "\n" + price.ToString();
            this.Controls.Add(btn);
            num_buttons++;
            line_number++;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select id as '판매번호',pricedate as '판매시간', coffeename as '커피 이름' from coffeeorders where uid='" + Login.id+"'");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void modified_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            if (fixcoffeename.Text == "")
            {
                MessageBox.Show("수정할 메뉴를 선택하세요.");
            }
            else
            {
                string fixdates = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                int de = DBManager.getInstance().update("update coffeeorders set coffeename='"+fixcoffeename.Text+"', coffee where id="+fixid);
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
            }
            DataTable datesell = DBManager.getInstance().select("select id as '판매번호',pricedate as '판매시간', coffeename as '커피 이름' from coffeeorders where uid='" + Login.id + "'");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (fixid==0)
            {
                MessageBox.Show("수정할 메뉴를 선택하세요.");
            }
            else
            {
                int de = DBManager.getInstance().delete("delete from coffeeorders where id="+fixid);
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                DataTable datesell = DBManager.getInstance().select("select id as '판매번호', pricedate as '판매시간', coffeename as '커피 이름' from coffeeorders where uid='" + Login.id + "'");
                dataGridView1.DataSource = datesell;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fixid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

            MessageBox.Show("선택 되었습니다.");
        }

        private void 메뉴추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dates = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            if (menuprice_tb.Text == "" || menuname_tb.Text == "")
            {
                MessageBox.Show("메뉴 이름 혹은 가격을 입력하세요.");
            }
            else
            {
                int ca = DBManager.getInstance().insert("insert into coffeemenu(name, price) values('" + menuname_tb.Text + "','" + Convert.ToInt32(menuprice_tb.Text) + "')");
                MessageBox.Show("메뉴가 추가되었습니다.");
                int ba = DBManager.getInstance().insert("insert into coffeemenurecord(user, beforemenu, beforeprice, aftermenu, afterprice, fixdate) values('"+Login.id+ "','추가', 0,'" + menuname_tb.Text + "','" + Convert.ToInt32(menuprice_tb.Text) + "','"+dates+"')");
            }
        }

        private void 메뉴변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int updateprice = 0;
            int price = 0;
            string dates = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            if (up_price_tb.Text != "")
            {
                updateprice = Convert.ToInt32(up_price_tb.Text);
            }
            if (menuprice_tb.Text != "")
            {
                price = Convert.ToInt32(menuprice_tb.Text);
            }

            if (price == 0 || menuname_tb.Text == "" || up_name_tb.Text == "" || updateprice == 0)
            {
                MessageBox.Show("검색하거나 변경내용의 메뉴 이름 혹은 가격을 입력하세요.");
            }
            else
            {
                int ca = DBManager.getInstance().update("update coffeemenu set name='" + up_name_tb.Text + "', price=" + updateprice + " where name='" + menuname_tb.Text + "'and price=" + price + "");
                MessageBox.Show("메뉴가 수정되었습니다.");
                int ba = DBManager.getInstance().insert("insert into coffeemenurecord(user, beforemenu, beforeprice, aftermenu, afterprice, fixdate) values('" + Login.id + "','" + menuname_tb.Text + "', '" + Convert.ToInt32(menuprice_tb.Text) + "','" + up_name_tb.Text + "','" + updateprice + "','" + dates + "')");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            string[] deletename = new string[num_buttons];
            foreach(Control c in Controls)
            {
                for(int i=0; i<menucount; i++)
                {
                    if (c.Text == nameArray[i])
                    {
                        deletename[i] = c.Name;
                    }
                }
            }
            for (int i = 0; i < menucount; i++)
            {
                this.Controls.RemoveByKey(deletename[i]);
            }
            DataTable dt = DBManager.getInstance().select("select * from coffeemenu");

            string name = null;
            int price = 0;

            num_buttons = 1;
            lines = 0;
            line_number = 1;

            foreach (DataRow row in dt.Rows)
            {
                name = string.Format("{0}", row["name"]);
                price = Convert.ToInt32(string.Format("{0}", row["price"]));
                if (name != null && price != 0)
                {
                    menuadd(name, price);
                }
            }
            
        }
    }
}
