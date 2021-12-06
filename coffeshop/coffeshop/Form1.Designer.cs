namespace coffeshop
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.logout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modified_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.fixcoffeename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.up_price_tb = new System.Windows.Forms.TextBox();
            this.menuprice_tb = new System.Windows.Forms.TextBox();
            this.up_name_tb = new System.Windows.Forms.TextBox();
            this.menuname_tb = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(367, 37);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 6;
            this.logout.Text = "로그아웃";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd-HH-mm-ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 28, 14, 29, 23, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자모드ToolStripMenuItem,
            this.메뉴추가ToolStripMenuItem,
            this.메뉴변경ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 관리자모드ToolStripMenuItem
            // 
            this.관리자모드ToolStripMenuItem.Name = "관리자모드ToolStripMenuItem";
            this.관리자모드ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.관리자모드ToolStripMenuItem.Text = "관리자모드";
            this.관리자모드ToolStripMenuItem.Click += new System.EventHandler(this.관리자모드ToolStripMenuItem_Click);
            // 
            // 메뉴추가ToolStripMenuItem
            // 
            this.메뉴추가ToolStripMenuItem.Name = "메뉴추가ToolStripMenuItem";
            this.메뉴추가ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.메뉴추가ToolStripMenuItem.Text = "메뉴 추가";
            this.메뉴추가ToolStripMenuItem.Click += new System.EventHandler(this.메뉴추가ToolStripMenuItem_Click);
            // 
            // 메뉴변경ToolStripMenuItem
            // 
            this.메뉴변경ToolStripMenuItem.Name = "메뉴변경ToolStripMenuItem";
            this.메뉴변경ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.메뉴변경ToolStripMenuItem.Text = "메뉴 변경";
            this.메뉴변경ToolStripMenuItem.Click += new System.EventHandler(this.메뉴변경ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "시간은 입력 안할 시 현재 시간으로 입력됩니다.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(507, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // modified_btn
            // 
            this.modified_btn.Location = new System.Drawing.Point(881, 81);
            this.modified_btn.Name = "modified_btn";
            this.modified_btn.Size = new System.Drawing.Size(75, 23);
            this.modified_btn.TabIndex = 18;
            this.modified_btn.Text = "주문 수정";
            this.modified_btn.UseVisualStyleBackColor = true;
            this.modified_btn.Click += new System.EventHandler(this.modified_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(881, 112);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 18;
            this.cancel_btn.Text = "주문 취소";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(881, 12);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 19;
            this.search_btn.Text = "주문 조회";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // fixcoffeename
            // 
            this.fixcoffeename.Location = new System.Drawing.Point(870, 42);
            this.fixcoffeename.Name = "fixcoffeename";
            this.fixcoffeename.Size = new System.Drawing.Size(100, 21);
            this.fixcoffeename.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "수정할 커피 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "추가할 가격이나 수정을 위해 검색할 메뉴의 가격을 입력하세요";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "변경할 가격을 입력하세요.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "변경할 이름을 입력하세요.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "추가할 이름이나 수정을 위해 검색할 메뉴의 이름을 입력하세요";
            // 
            // up_price_tb
            // 
            this.up_price_tb.Location = new System.Drawing.Point(507, 262);
            this.up_price_tb.Name = "up_price_tb";
            this.up_price_tb.Size = new System.Drawing.Size(100, 21);
            this.up_price_tb.TabIndex = 22;
            // 
            // menuprice_tb
            // 
            this.menuprice_tb.Location = new System.Drawing.Point(507, 208);
            this.menuprice_tb.Name = "menuprice_tb";
            this.menuprice_tb.Size = new System.Drawing.Size(100, 21);
            this.menuprice_tb.TabIndex = 23;
            // 
            // up_name_tb
            // 
            this.up_name_tb.Location = new System.Drawing.Point(507, 235);
            this.up_name_tb.Name = "up_name_tb";
            this.up_name_tb.Size = new System.Drawing.Size(100, 21);
            this.up_name_tb.TabIndex = 24;
            // 
            // menuname_tb
            // 
            this.menuname_tb.Location = new System.Drawing.Point(507, 181);
            this.menuname_tb.Name = "menuname_tb";
            this.menuname_tb.Size = new System.Drawing.Size(100, 21);
            this.menuname_tb.TabIndex = 25;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(367, 66);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 30;
            this.reset_btn.Text = "새로고침";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 454);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.up_price_tb);
            this.Controls.Add(this.menuprice_tb);
            this.Controls.Add(this.up_name_tb);
            this.Controls.Add(this.menuname_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fixcoffeename);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.modified_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자모드ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button modified_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox fixcoffeename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox up_price_tb;
        private System.Windows.Forms.TextBox menuprice_tb;
        private System.Windows.Forms.TextBox up_name_tb;
        private System.Windows.Forms.TextBox menuname_tb;
        private System.Windows.Forms.ToolStripMenuItem 메뉴추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴변경ToolStripMenuItem;
        private System.Windows.Forms.Button reset_btn;
    }
}

