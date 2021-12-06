namespace coffeshop
{
    partial class manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coffeemonthsell = new System.Windows.Forms.Button();
            this.coffeedatesell = new System.Windows.Forms.Button();
            this.userdatesell = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리자모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인기록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴변경이력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.홈화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인제한ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인승인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeemonthsell
            // 
            this.coffeemonthsell.Location = new System.Drawing.Point(383, 52);
            this.coffeemonthsell.Name = "coffeemonthsell";
            this.coffeemonthsell.Size = new System.Drawing.Size(135, 50);
            this.coffeemonthsell.TabIndex = 14;
            this.coffeemonthsell.Text = "커피별 월별 판매정보";
            this.coffeemonthsell.UseVisualStyleBackColor = true;
            this.coffeemonthsell.Click += new System.EventHandler(this.coffeemonthsell_Click_1);
            // 
            // coffeedatesell
            // 
            this.coffeedatesell.Location = new System.Drawing.Point(247, 52);
            this.coffeedatesell.Name = "coffeedatesell";
            this.coffeedatesell.Size = new System.Drawing.Size(130, 50);
            this.coffeedatesell.TabIndex = 15;
            this.coffeedatesell.Text = "커피별 일일 판매정보";
            this.coffeedatesell.UseVisualStyleBackColor = true;
            this.coffeedatesell.Click += new System.EventHandler(this.coffeedatesell_Click_1);
            // 
            // userdatesell
            // 
            this.userdatesell.Location = new System.Drawing.Point(96, 52);
            this.userdatesell.Name = "userdatesell";
            this.userdatesell.Size = new System.Drawing.Size(145, 50);
            this.userdatesell.TabIndex = 16;
            this.userdatesell.Text = "사용자별 일일 판매정보";
            this.userdatesell.UseVisualStyleBackColor = true;
            this.userdatesell.Click += new System.EventHandler(this.userdatesell_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자모드ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리자모드ToolStripMenuItem
            // 
            this.관리자모드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인기록ToolStripMenuItem,
            this.메뉴변경이력ToolStripMenuItem,
            this.로그인승인ToolStripMenuItem,
            this.로그인제한ToolStripMenuItem,
            this.홈화면ToolStripMenuItem});
            this.관리자모드ToolStripMenuItem.Name = "관리자모드ToolStripMenuItem";
            this.관리자모드ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.관리자모드ToolStripMenuItem.Text = "관리자 모드";
            // 
            // 로그인기록ToolStripMenuItem
            // 
            this.로그인기록ToolStripMenuItem.Name = "로그인기록ToolStripMenuItem";
            this.로그인기록ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그인기록ToolStripMenuItem.Text = "로그인 기록";
            this.로그인기록ToolStripMenuItem.Click += new System.EventHandler(this.로그인기록ToolStripMenuItem_Click_1);
            // 
            // 메뉴변경이력ToolStripMenuItem
            // 
            this.메뉴변경이력ToolStripMenuItem.Name = "메뉴변경이력ToolStripMenuItem";
            this.메뉴변경이력ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.메뉴변경이력ToolStripMenuItem.Text = "메뉴 변경 이력";
            this.메뉴변경이력ToolStripMenuItem.Click += new System.EventHandler(this.메뉴변경이력ToolStripMenuItem_Click);
            // 
            // 홈화면ToolStripMenuItem
            // 
            this.홈화면ToolStripMenuItem.Name = "홈화면ToolStripMenuItem";
            this.홈화면ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.홈화면ToolStripMenuItem.Text = "홈 화면";
            this.홈화면ToolStripMenuItem.Click += new System.EventHandler(this.홈화면ToolStripMenuItem_Click);
            // 
            // 로그인제한ToolStripMenuItem
            // 
            this.로그인제한ToolStripMenuItem.Name = "로그인제한ToolStripMenuItem";
            this.로그인제한ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그인제한ToolStripMenuItem.Text = "로그인 제한";
            this.로그인제한ToolStripMenuItem.Click += new System.EventHandler(this.로그인제한ToolStripMenuItem_Click);
            // 
            // 로그인승인ToolStripMenuItem
            // 
            this.로그인승인ToolStripMenuItem.Name = "로그인승인ToolStripMenuItem";
            this.로그인승인ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그인승인ToolStripMenuItem.Text = "로그인 승인";
            this.로그인승인ToolStripMenuItem.Click += new System.EventHandler(this.로그인승인ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "유저 로그인 관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 295);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coffeemonthsell);
            this.Controls.Add(this.coffeedatesell);
            this.Controls.Add(this.userdatesell);
            this.Controls.Add(this.dataGridView1);
            this.Name = "manager";
            this.Text = "manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coffeemonthsell;
        private System.Windows.Forms.Button coffeedatesell;
        private System.Windows.Forms.Button userdatesell;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리자모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인기록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 홈화면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴변경이력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인승인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인제한ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}