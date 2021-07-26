using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime;
using System.Threading;

namespace caps
{


    public partial class Form1 : Form
    {
        bool auto=false;

        int C;
        int test_score = 0;
        public Form1()
        {
            InitializeComponent();
            axKHOpenAPI1.OnEventConnect += login_info;
            axKHOpenAPI1.OnEventConnect += list_info;
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
            axKHOpenAPI1.OnReceiveRealData += onReceiveRealData;
        }
        public void onReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            int stocks = dataGridView1.Rows.Count;

            if (auto)
            {

                for (int i = 0; i < stocks; i++)
                {
                    double profit = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].FormattedValue.ToString()) * 0.01;
                    double loss = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].FormattedValue.ToString()) * 0.01;

                    string code = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();

                    double bought = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());


                    axKHOpenAPI1.SetInputValue("종목코드", code);
                    axKHOpenAPI1.CommRqData("거래", "opt10001", 0, "6557");

                    Delay(1000);

                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "있음")
                    {
                        if (C >= (int)(bought + bought * profit))
                        {
                            if (checkBox_test.Checked)
                            {
                                test_score += (int)(bought* profit);
                                label_test.Text = test_score.ToString();
                                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + "을(를) 익절로 매각");
                                dataGridView1.Rows[i].Cells[3].Value = "없음";
                            }
                            else
                            {
                                string s_code = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                                int s_count = Int32.Parse(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString());
                                axKHOpenAPI1.SendOrder("익절매각", "2348", comboBox_ac.Text, 2, s_code, s_count , 0, "03", "");
                                dataGridView1.Rows[i].Cells[3].Value = "없음";
                                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + "을(를) 익절로 매각");
                            }
                        }

                        else if (C <= (int)(bought - bought * profit))
                        {
                            if (checkBox_test.Checked)
                            {
                                test_score -= (int)(bought * loss);
                                label_test.Text = test_score.ToString();
                                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + "을(를) 손절로 매각");
                                dataGridView1.Rows[i].Cells[3].Value = "없음";
                            }
                            else
                            {
                                string s_code = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                                int s_count = Int32.Parse(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString());

                                axKHOpenAPI1.SendOrder("손절매각", "5618", comboBox_ac.Text, 2, s_code, s_count, 0, "03", "");

                                dataGridView1.Rows[i].Cells[3].Value = "없음";
                                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + "을(를) 손절로 매각");
                            }
                        }
                    }
                    else
                    {
                        if (C == bought)
                        {
                            if (checkBox_test.Checked)
                            {
                                dataGridView1.Rows[i].Cells[3].Value = "있음";
                                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + "을(를) 재구매");

                            }
                            else
                            {
                                string s_code = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                                int s_count = Int32.Parse(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString());

                                axKHOpenAPI1.SendOrder("", "9642", comboBox_ac.Text, 1, s_code, s_count, 0, "03", "");
                                dataGridView1.Rows[i].Cells[3].Value = "있음";

                                listBox1.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString() + "을(를) 재구매");
                            }
                        }
                    }
                    
                }
            
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 로그인_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.CommConnect();
        }
        public void login_info (object sender,AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if(e.nErrCode==0)
            {
                string 계좌목록 = axKHOpenAPI1.GetLoginInfo("ACCLIST").Trim();
                string[] 사용자계좌 = 계좌목록.Split(';');

                for (int i = 0; i < 사용자계좌.Length-1; i++)
                    comboBox_ac.Items.Add(사용자계좌[i]);
                textBox_id.Text = axKHOpenAPI1.GetLoginInfo("USER_ID");
                textBox_name.Text = axKHOpenAPI1.GetLoginInfo("USER_NAME");
  
            }
        }
        public void list_info(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                string list = axKHOpenAPI1.GetCodeListByMarket("0");
                string[] code = list.Split(';');
                for(int i=0;i<code.Length;i++)
                {
                    dataGridView_jong.Rows.Add();
                    dataGridView_jong["종목조회_종목코드", i].Value = code[i];
                    dataGridView_jong["종목조회_종목명", i].Value = axKHOpenAPI1.GetMasterCodeName(code[i]);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string 종목코드 = textBox_jong.Text;
            if (textBox_jong.Text.Length > 0)
            {
                axKHOpenAPI1.SetInputValue("종목코드", 종목코드);
                axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");
            }
 
        }

        public void onReceiveTrData (object sender,AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if(e.sRQName=="종목정보요청")
            {
                string 종목이름 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                string 현재가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim();
                string 전일대비 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim();
                string 거래량 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim();
                string 등락율 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();

                label_j_a.Text = 종목이름;
                label_j_b.Text = 현재가.Substring(1);
                label1_j_c.Text = 전일대비;
                label_j_d.Text = 거래량;
                label_j_e.Text = 등락율;
            }
            else if(e.sRQName== "계좌평가잔고내역요청")
            {
                long totalEstimatedAmount = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총평가금액"));
                
                textBox_account.Text = totalEstimatedAmount.ToString();
            }
            else if(e.sRQName=="거래")
            {
                string 현재가 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim();
                C = int.Parse(현재가);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
                Form2 add = new Form2(this);
                add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다");
            }
            else if(dataGridView1.Rows.Count > 10)
            {
                MessageBox.Show("10개 이하로 선택해 주세요");
            }
            else if(auto == true)
            {
                MessageBox.Show("이미 실행 중 입니다");
            }
            else
            {
                auto = true;

                int stocks = dataGridView1.Rows.Count;

                if (!checkBox_test.Checked)
                    for (int i = 0; i < stocks; i++)
                    {
                        string code = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                        int count = int.Parse(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString());


                        axKHOpenAPI1.SendOrder("최초주문", "5149", comboBox_ac.Text, 1, code, count, 0, "03", "");
                        dataGridView1.Rows[i].Cells[3].Value = "있음";

                    }
                else
                    for (int i = 0; i < stocks; i++)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "있음";
                        label_test.Text = test_score.ToString();
                    }

                listBox1.Items.Add("자동매매 시작");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (auto == false)
            {
                MessageBox.Show("실행 중이 아닙니다");
            }
            else
            {
                auto = false;

                int stocks = dataGridView1.Rows.Count;

                if (!checkBox_test.Checked)
                {

                    for (int i = 0; i < stocks; i++)
                    {
                        string code = dataGridView1.Rows[i].Cells[0].FormattedValue.ToString();
                        int count = Int32.Parse(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString());

                        axKHOpenAPI1.SendOrder("전체매각", "5678", comboBox_ac.Text, 2, code, count, 0, "03", "");
                        dataGridView1.Rows[i].Cells[3].Value = "없음";
                    }
                }
                else
                {
                    MessageBox.Show("테스트 결과 : " + test_score);
                    label_test.Text = "테스트 대기 중";

                    for (int i = 0; i < stocks; i++)
                        dataGridView1.Rows[i].Cells[3].Value = "없음";

                    test_score = 0;

                }

                dataGridView1.Rows.Clear();
                listBox1.Items.Add("자동매매 중지");
            }
        }

        private void order_buy(String 종목코드,int 수량)
        {
       
        }
        private void order_sell(String 종목코드, int 수량)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string accountNumber = comboBox_ac.Text;
            string password = textBox_pw.Text;

            axKHOpenAPI1.SetInputValue("계좌번호", accountNumber);
            axKHOpenAPI1.SetInputValue("비밀번호", password);
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "1");

            axKHOpenAPI1.CommRqData("계좌평가잔고내역요청", "opw00018", 0, "8100");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            }
        }

        private void checkBox_test_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_test.Checked)
            {
                if (auto)
                {
                    MessageBox.Show("자동 거래 실행 중");
                    checkBox_test.Checked = true;
                }
                else
                {
                    MessageBox.Show("테스트 중지");
                    test_score = 0;
                    label_test.Text = "테스트 대기 중";
                }            
            }
            else
            {
                if (auto)
                {
                    MessageBox.Show("자동 거래 실행 중");
                    checkBox_test.Checked = false;
                }
                else
                    MessageBox.Show("테스트 시작");
            }
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
    }
}
