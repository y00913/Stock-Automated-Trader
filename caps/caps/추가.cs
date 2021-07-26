using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace caps
{
    public partial class Form2 : Form
    {
        Form1 f1;
        string[] b;

        public Form2(Form1 a)
        {
            
            InitializeComponent();
            f1 = a;
            f1.axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
        }
        
        ~Form2()
        {
            f1.axKHOpenAPI1.OnReceiveTrData -= onReceiveTrData;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            f1.axKHOpenAPI1.SetInputValue("종목코드", textBox5.Text);
            f1.axKHOpenAPI1.CommRqData("그리드추가", "opt10001", 0, "5003");
            
        }
        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "그리드추가")
            {
                string 종목이름 = f1.axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                string 현재가 = f1.axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim();

                int a = int.Parse(현재가);
                현재가 = a.ToString();

                string[] row = { textBox5.Text,종목이름, 현재가 , "없음", textBox_i.Text, textBox_s.Text,  textBox_c.Text };
                b = row;

                f1.dataGridView1.Rows.Add(b);
                this.Close();
                f1.axKHOpenAPI1.OnReceiveTrData -= onReceiveTrData;
            }
        }

    }
}
