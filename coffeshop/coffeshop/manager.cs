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
    public partial class manager : Form
    {
        Form1 form1;
        string fixstateid = String.Empty;
        public manager()
        {
            InitializeComponent();
        }
        private void 홈화면ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            Hide();
            form1.ShowDialog();
            Close();
        }

        private void 로그인기록ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select uid as '유저아이디', attendance as '로그인 시간', absent as '로그아웃 시간' from coffeelogin");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void userdatesell_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select co.uid as '사용자', pricedate as '판매일', sum(price) as '판매액', count(price) as '판매량' from coffeeorders co, coffeemenu cm where co.coffeename=cm.name group by co.uid, co.pricedate");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void coffeedatesell_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select co.coffeename as '커피품목', co.pricedate as '판매일',sum(cm.price) as '판매액', count(cm.price) as '판매량' from coffeemenu cm, coffeeorders co where co.coffeename=cm.name group by co.coffeename, co.pricedate order by co.coffeename, co.pricedate");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void coffeemonthsell_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select co.coffeename as '커피품목', month(co.pricedate) as '판매월',sum(cm.price) as '판매액', count(cm.price) as '판매량' from coffeemenu cm, coffeeorders co where co.coffeename=cm.name group by co.coffeename, month(co.pricedate) order by co.coffeename, month(co.pricedate)");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void 메뉴변경이력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select user as '사용자', beforemenu as '변경 전 메뉴', beforeprice as '변경 전 가격', aftermenu as '변경 후 메뉴', afterprice as '변경 후 가격', fixdate as '변경 시간' from coffeemenurecord");
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void 로그인승인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fixstateid != String.Empty)
            {
                DBManager.getInstance().update("update coffeecasher set state=1 where uid='" + fixstateid + "'");
                MessageBox.Show("로그인을 승인 하였습니다.");
            }
        }

        private void 로그인제한ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fixstateid != String.Empty)
            {
                DBManager.getInstance().update("update coffeecasher set state=2 where uid='" + fixstateid + "'");
                MessageBox.Show("로그인을 제한 하였습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e) //로그인 표시
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            DataTable datesell = DBManager.getInstance().select("select uid as '아이디', state as '로그인 상태' from coffeecasher where admin=1"); //자기는 로그인 제한 안걸게 하기 위해
            dataGridView1.DataSource = datesell;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fixstateid = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            MessageBox.Show("선택 되었습니다.");
        }
    }
}
