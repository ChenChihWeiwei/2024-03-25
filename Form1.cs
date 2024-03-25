using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtCM_KeyUp(object sender, EventArgs e)
        {
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text; // 將txtM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douM / 0.01);
                txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
                txtIn.Text = string.Format("{0:0.##########}", douM / 0.0254);
                txtFt.Text = string.Format("{0:0.##########}", douM / 0.3048);
                txtYard.Text = string.Format("{0:0.##########}", douM / 0.9144);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
            {
                strInput = txtKM.Text; 

                // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
                if (double.TryParse(strInput, out douOutput) == true)
                {
                    txtCM.Text = string.Format("{0:0.##########}", douKM / 0.00001);
                    txtM.Text = string.Format("{0:0.##########}", douKM / 0.001);
                    txtIn.Text = string.Format("{0:0.##########}", douKM / 0.0000254);
                    txtFt.Text = string.Format("{0:0.##########}", douKM / 0.0003048);
                    txtYard.Text = string.Format("{0:0.##########}", douKM / 0.0009144);
                }
                else
                {
                    // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                    txtInfo.Text = "請輸入數字";
                    txtKM.Text = "";


                }
            }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);
                txtKM.Text = string.Format("{0:0.##########}", douIn / 39370.1);
                txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
                txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
                txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);
                txtKM.Text = string.Format("{0:0.##########}", douFt / 3280.84);
                txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
                txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }

        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douYard * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);
                txtKM.Text = string.Format("{0:0.##########}", douYard * 0.0009144);
                txtIn.Text = string.Format("{0:0.##########}", douYard * 36);
                txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtM文字框清除
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }


        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
