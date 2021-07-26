namespace caps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.로그인 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dataGridView_jong = new System.Windows.Forms.DataGridView();
            this.종목조회_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목조회_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_jong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_j_e = new System.Windows.Forms.Label();
            this.label_j_d = new System.Windows.Forms.Label();
            this.label1_j_c = new System.Windows.Forms.Label();
            this.label_j_b = new System.Windows.Forms.Label();
            this.label_j_a = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_ac = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매수범위 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.익절 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.손절 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주식_수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox_test = new System.Windows.Forms.CheckBox();
            this.label_test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(531, 555);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(30, 46);
            this.axKHOpenAPI1.TabIndex = 0;
            this.axKHOpenAPI1.Visible = false;
            // 
            // 로그인
            // 
            this.로그인.Location = new System.Drawing.Point(397, 9);
            this.로그인.Name = "로그인";
            this.로그인.Size = new System.Drawing.Size(75, 23);
            this.로그인.TabIndex = 1;
            this.로그인.Text = "로그인";
            this.로그인.UseVisualStyleBackColor = true;
            this.로그인.Click += new System.EventHandler(this.로그인_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "이  름";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(83, 9);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 21);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(262, 9);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 5;
            // 
            // dataGridView_jong
            // 
            this.dataGridView_jong.AllowUserToAddRows = false;
            this.dataGridView_jong.AllowUserToDeleteRows = false;
            this.dataGridView_jong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_jong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목조회_종목코드,
            this.종목조회_종목명});
            this.dataGridView_jong.Location = new System.Drawing.Point(14, 110);
            this.dataGridView_jong.Name = "dataGridView_jong";
            this.dataGridView_jong.RowHeadersVisible = false;
            this.dataGridView_jong.RowTemplate.Height = 23;
            this.dataGridView_jong.Size = new System.Drawing.Size(220, 163);
            this.dataGridView_jong.TabIndex = 6;
            // 
            // 종목조회_종목코드
            // 
            this.종목조회_종목코드.HeaderText = "종목코드";
            this.종목조회_종목코드.Name = "종목조회_종목코드";
            this.종목조회_종목코드.ReadOnly = true;
            this.종목조회_종목코드.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.종목조회_종목코드.Width = 108;
            // 
            // 종목조회_종목명
            // 
            this.종목조회_종목명.HeaderText = "종목명";
            this.종목조회_종목명.Name = "종목조회_종목명";
            this.종목조회_종목명.ReadOnly = true;
            this.종목조회_종목명.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.종목조회_종목명.Width = 108;
            // 
            // textBox_jong
            // 
            this.textBox_jong.Location = new System.Drawing.Point(276, 83);
            this.textBox_jong.Name = "textBox_jong";
            this.textBox_jong.Size = new System.Drawing.Size(100, 21);
            this.textBox_jong.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "종목 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_j_e, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_j_d, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1_j_c, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_j_b, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_j_a, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(240, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 161);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label_j_e
            // 
            this.label_j_e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_j_e.AutoSize = true;
            this.label_j_e.Location = new System.Drawing.Point(240, 138);
            this.label_j_e.Name = "label_j_e";
            this.label_j_e.Size = new System.Drawing.Size(0, 12);
            this.label_j_e.TabIndex = 23;
            // 
            // label_j_d
            // 
            this.label_j_d.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_j_d.AutoSize = true;
            this.label_j_d.Location = new System.Drawing.Point(240, 106);
            this.label_j_d.Name = "label_j_d";
            this.label_j_d.Size = new System.Drawing.Size(0, 12);
            this.label_j_d.TabIndex = 22;
            // 
            // label1_j_c
            // 
            this.label1_j_c.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_j_c.AutoSize = true;
            this.label1_j_c.Location = new System.Drawing.Point(240, 74);
            this.label1_j_c.Name = "label1_j_c";
            this.label1_j_c.Size = new System.Drawing.Size(0, 12);
            this.label1_j_c.TabIndex = 21;
            // 
            // label_j_b
            // 
            this.label_j_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_j_b.AutoSize = true;
            this.label_j_b.Location = new System.Drawing.Point(240, 42);
            this.label_j_b.Name = "label_j_b";
            this.label_j_b.Size = new System.Drawing.Size(0, 12);
            this.label_j_b.TabIndex = 20;
            // 
            // label_j_a
            // 
            this.label_j_a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_j_a.AutoSize = true;
            this.label_j_a.Location = new System.Drawing.Point(240, 10);
            this.label_j_a.Name = "label_j_a";
            this.label_j_a.Size = new System.Drawing.Size(0, 12);
            this.label_j_a.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "종목이름";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "현재가";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "전일대비";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "거래량";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "등락율";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "계좌번호";
            // 
            // comboBox_ac
            // 
            this.comboBox_ac.FormattingEnabled = true;
            this.comboBox_ac.Location = new System.Drawing.Point(83, 45);
            this.comboBox_ac.Name = "comboBox_ac";
            this.comboBox_ac.Size = new System.Drawing.Size(121, 20);
            this.comboBox_ac.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종목코드,
            this.종목명,
            this.매수범위,
            this.가격,
            this.익절,
            this.손절,
            this.주식_수량});
            this.dataGridView1.Location = new System.Drawing.Point(64, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 203);
            this.dataGridView1.TabIndex = 14;
            // 
            // 종목코드
            // 
            this.종목코드.HeaderText = "종목코드";
            this.종목코드.Name = "종목코드";
            // 
            // 종목명
            // 
            this.종목명.HeaderText = "종목명";
            this.종목명.Name = "종목명";
            // 
            // 매수범위
            // 
            this.매수범위.HeaderText = "기준가";
            this.매수범위.Name = "매수범위";
            // 
            // 가격
            // 
            this.가격.HeaderText = "보유 여부";
            this.가격.Name = "가격";
            // 
            // 익절
            // 
            this.익절.HeaderText = "익절 %";
            this.익절.Name = "익절";
            // 
            // 손절
            // 
            this.손절.HeaderText = "손절%";
            this.손절.Name = "손절";
            // 
            // 주식_수량
            // 
            this.주식_수량.HeaderText = "수량";
            this.주식_수량.Name = "주식_수량";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "시작";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "중지";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "추가";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "제거";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "평가 금액";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "비밀번호";
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(276, 44);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(100, 21);
            this.textBox_pw.TabIndex = 21;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox_account
            // 
            this.textBox_account.Location = new System.Drawing.Point(452, 44);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(100, 21);
            this.textBox_account.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(589, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 172);
            this.listBox1.TabIndex = 25;
            // 
            // checkBox_test
            // 
            this.checkBox_test.AutoSize = true;
            this.checkBox_test.Location = new System.Drawing.Point(707, 29);
            this.checkBox_test.Name = "checkBox_test";
            this.checkBox_test.Size = new System.Drawing.Size(60, 16);
            this.checkBox_test.TabIndex = 26;
            this.checkBox_test.Text = "테스트";
            this.checkBox_test.UseVisualStyleBackColor = true;
            this.checkBox_test.CheckedChanged += new System.EventHandler(this.checkBox_test_CheckedChanged);
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Location = new System.Drawing.Point(695, 68);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(85, 12);
            this.label_test.TabIndex = 27;
            this.label_test.Text = "테스트 대기 중";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 613);
            this.Controls.Add(this.label_test);
            this.Controls.Add(this.checkBox_test);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_ac);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_jong);
            this.Controls.Add(this.dataGridView_jong);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.로그인);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "AUTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_jong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button 로그인;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.DataGridView dataGridView_jong;
        private System.Windows.Forms.TextBox textBox_jong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_j_e;
        private System.Windows.Forms.Label label_j_d;
        private System.Windows.Forms.Label label1_j_c;
        private System.Windows.Forms.Label label_j_b;
        private System.Windows.Forms.Label label_j_a;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_ac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox_test;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목조회_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목조회_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매수범위;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 익절;
        private System.Windows.Forms.DataGridViewTextBoxColumn 손절;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주식_수량;
    }
}

