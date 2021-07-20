using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Init()
        {
            this.cbxType.SelectedIndex = 0;
            this.cbxType2.SelectedIndex = 0;
            this.kextuka.Text = "";
        }

        private void kynseru_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void tukaikata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxType.SelectedIndex == 0)
            {
                this.cbxType2.Items.Clear();
                this.cbxType2.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                this.cbxType2.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                this.cbxType2.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                this.cbxType2.Items.Add("501-600");
                this.cbxType2.Items.Add("601-1200");
                this.cbxType2.Items.Add("1201-1800");
                this.cbxType2.Items.Add("1801或以上");
                this.cbxType2.SelectedIndex = 0;
            }

            if (this.cbxType.SelectedIndex == 1)
            {
                this.cbxType2.Items.Clear();
                this.cbxType2.Items.Add("500以下");
                this.cbxType2.Items.Add("501-600");
                this.cbxType2.Items.Add("601-1200");
                this.cbxType2.Items.Add("1201-1800");
                this.cbxType2.Items.Add("1801-2400");
                this.cbxType2.Items.Add("2401-3000 / 138HP以下(140.1PS以下");
                this.cbxType2.Items.Add("3001-3600");
                this.cbxType2.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS");
                this.cbxType2.Items.Add("4201-4800");
                this.cbxType2.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS");
                this.cbxType2.Items.Add("5401-6000");
                this.cbxType2.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS");
                this.cbxType2.Items.Add("6601-7200");
                this.cbxType2.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS");
                this.cbxType2.Items.Add("7801-8400");
                this.cbxType2.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS");
                this.cbxType2.Items.Add("9001-9600");
                this.cbxType2.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.cbxType2.Items.Add("10201以上");
                this.cbxType2.SelectedIndex = 0;

            }

            if (this.cbxType.SelectedIndex == 2)
            {
                this.cbxType2.Items.Clear();
                this.cbxType2.Items.Add("600以下");
                this.cbxType2.Items.Add("601-1200");
                this.cbxType2.Items.Add("1201-1800");
                this.cbxType2.Items.Add("1801-2400");
                this.cbxType2.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.cbxType2.Items.Add("3001-3600");
                this.cbxType2.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS");
                this.cbxType2.Items.Add("4201-4800");
                this.cbxType2.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.cbxType2.Items.Add("5401-6000");
                this.cbxType2.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS");
                this.cbxType2.Items.Add("6601-7200");
                this.cbxType2.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS");
                this.cbxType2.Items.Add("7801-8400");
                this.cbxType2.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.cbxType2.Items.Add("9001-9600");
                this.cbxType2.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.cbxType2.Items.Add("10201以上");
                this.cbxType2.SelectedIndex = 0;
            }

            if (this.cbxType.SelectedIndex == 3)
            {
                this.cbxType2.Items.Clear();
                this.cbxType2.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.cbxType2.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.cbxType2.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS");
                this.cbxType2.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS");
                this.cbxType2.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS");
                this.cbxType2.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS");
                this.cbxType2.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                this.cbxType2.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS");
                this.cbxType2.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS");
                this.cbxType2.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.cbxType2.Items.Add("7801以上");
                this.cbxType2.SelectedIndex = 0;
            }

            if (this.cbxType.SelectedIndex == 4)
            {
                this.cbxType2.Items.Clear();
                this.cbxType2.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.cbxType2.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.cbxType2.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.cbxType2.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.cbxType2.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.cbxType2.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.cbxType2.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                this.cbxType2.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.cbxType2.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.cbxType2.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.cbxType2.Items.Add("7801以上");
                this.cbxType2.SelectedIndex = 0;
            }
        }

        private void kikan_CheckedChanged(object sender, EventArgs e)
        {
            if (kikan.Checked == true)
            {
                this.kikan3.Visible = true;
                this.kiakn2.Visible = true;
                this.label7.Visible = true;
                this.label6.Visible = true;

            }

            if (kikan.Checked == false)
            {
                this.kiakn2.Visible = false;
                this.kikan3.Visible = false;
                this.label6.Visible = false;
                this.label7.Visible = false;
            }


        }
        void geku(string a, string b, int c)
        {
            DateTime date1 = kiakn2.Value;
            DateTime date2 = kikan3.Value;
            int ryoukin;
            int nen;
            int niti;
            string nenkextuka;

            var twCalendar = new System.Globalization.TaiwanCalendar();
            string yearTW = twCalendar.GetYear(DateTime.Now).ToString();

            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                nen = 366;
            }
            else
            {
                nen = 365;
            }

            if (kikan.Checked == true)
            {
                TimeSpan span = date2 - date1;
                niti = span.Days + 1;
                nenkextuka = (kiakn2.Value.Year - 1911).ToString() + kiakn2.Value.ToString("-MM-dd") + "~" + (kikan3.Value.Year - 1911).ToString() + kikan3.Value.ToString("-MM-dd");
            }

            else
            {
                niti = nen;
                nenkextuka = (kiakn2.Value.Year - 1911).ToString() + "-01-01" + "~" + (kikan3.Value.Year - 1911).ToString() + "-12-31";
            }

            ryoukin = c * niti / nen;

            if (niti < 0 || kiakn2.Value.Year < 1911)
            {
                this.kextuka.Text = "日期設定錯誤";
            }

            else
            {
                this.kextuka.Text =
                "使用期間:" + nenkextuka + "\r\n" +
                "計算天數:" + niti.ToString() + "天" + "\r\n" +
                "汽缸CC數:" + a + "\r\n" +
                "用途:" + b + "\r\n" +
                "計算公式:" + c.ToString() + "*" + niti.ToString() + " / " + nen.ToString() + "= " + ryoukin.ToString() + "元" +
                "應納稅額: 共" + ryoukin.ToString() + "元";
            }
        }

        private void kakutei_Click(object sender, EventArgs e)
        {
            DateTime date1 = kiakn2.Value;
            DateTime date2 = kikan3.Value;
            int niti;
            int ryoukin;

            if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 0)
            {
                geku("150以下 / 12HP以下(12.2PS以下)", "機車", 0);
            }
            else if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 1)
            {
                geku("151-250 / 12.1-20HP(12.3-20.3PS)", "機車", 800);
            }
            else if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 2)
            {
                geku("251-500 / 20.1HP以上(20.4PS以上)", "機車", 1620);
            }
            else if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 3)
            {
                geku("501-600", "機車", 2160);
            }
            else if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 4)
            {
                geku("601-1200", "機車", 4320);
            }
            else if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 5)
            {
                geku("1201-1800", "機車", 7120);
            }
            else if (this.cbxType.SelectedIndex == 0 && this.cbxType2.SelectedIndex == 6)
            {
                geku("1801或以上", "機車", 11230);
            }

            if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 0)
            {
                geku("500以下", "貨車", 900);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 1)
            {
                geku("501-600", "貨車", 1080);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 2)
            {
                geku("601-1200", "貨車", 1800);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 3)
            {
                geku("1201-1800", "貨車", 2700);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 4)
            {
                geku("1801-2400", "貨車", 3600);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 5)
            {
                geku("2401-3000 / 138HP以下(140.1PS以下)", "貨車", 4500);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 6)
            {
                geku("3001-3600", "貨車", 5400);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 7)
            {
                geku("3601-4200 / 138.1-200HP(140.2-203.0PS", "貨車", 6300);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 8)
            {
                geku("4201-4800", "貨車", 7200);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 9)
            {
                geku("4801-5400 / 200.1-247HP(203.1-250.7PS", "貨車", 8100);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 10)
            {
                geku("5401-6000", "貨車", 9000);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 11)
            {
                geku("6001-6600 / 247.1-286HP(250.8-290.3PS", "貨車", 9900);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 12)
            {
                geku("6601-7200", "貨車", 10800);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 13)
            {
                geku("7201-7800 / 286.1-336HP(290.4-341.0PS", "貨車", 11700);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 14)
            {
                geku("7801-8400", "貨車", 12600);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 15)
            {
                geku("8401-9000 / 336.1-361HP(341.1-366.4PS", "貨車", 13500);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 16)
            {
                geku("9001-9600", "貨車", 14400);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 17)
            {
                geku("9601-10200 / 361.1HP以上(366.5PS以上)", "貨車", 15300);
            }
            else if (this.cbxType.SelectedIndex == 1 && this.cbxType2.SelectedIndex == 18)
            {
                geku("10201以上", "貨車", 16200);
            }

            if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 0)
            {
                geku("600以下", "大客車", 1080);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 1)
            {
                geku("601-1200", "大客車", 1800);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 2)
            {
                geku("1201-1800", "大客車", 2700);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 3)
            {
                geku("1801-2400", "大客車", 3600);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 4)
            {
                geku("2401-3000 / 138HP以下(140.1PS以下)", "大客車", 4500);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 5)
            {
                geku("3001-3600", "大客車", 5400);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 6)
            {
                geku("3601-4200 / 138.1-200HP(140.2-203.0PS", "大客車", 6300);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 7)
            {
                geku("4201-4800", "大客車", 7200);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 8)
            {
                geku("4801-5400 / 200.1-247HP(203.1-250.7PS)", "大客車", 8100);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 9)
            {
                geku("5401-6000", "大客車", 9000);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 10)
            {
                geku("6001-6600 / 247.1-286HP(250.8-290.3PS", "大客車", 9900);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 11)
            {
                geku("6601-7200", "大客車", 10800);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 12)
            {
                geku("7201-7800 / 286.1-336HP(290.4-341.0PS", "大客車", 11700);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 13)
            {
                geku("7801-8400", "大客車", 12600);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 14)
            {
                geku("8401-9000 / 336.1-361HP(341.1-366.4PS)", "大客車", 13500);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 15)
            {
                geku("9001-9600", "大客車", 14400);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 16)
            {
                geku("9601-10200 / 361.1HP以上(366.5PS以上)", "大客車", 15300);
            }
            else if (this.cbxType.SelectedIndex == 2 && this.cbxType2.SelectedIndex == 17)
            {
                geku("10201以上", "大客車", 16200);
            }

            if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 0)
            {
                geku("500以下 / 38HP以下(38.6PS以下)", "自用小客車", 1620);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 1)
            {
                geku("501~600 / 38.1-56HP(38.7-56.8PS)", "自用小客車", 2160);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 2)
            {
                geku("601~1200 / 56.1-83HP(56.9-84.2PS", "自用小客車", 4320);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 3)
            {
                geku("1201~1800 / 83.1-182HP(84.3-184.7PS", "自用小客車", 7120);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 4)
            {
                geku("1801~2400 / 182.1-262HP(184.8-265.9PS", "自用小客車", 11230);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 5)
            {
                geku("2401~3000 / 262.1-322HP(266-326.8PS", "自用小客車", 15210);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 6)
            {
                geku("3001-4200 / 322.1-414HP(326.9-420.2PS", "自用小客車", 28220);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 7)
            {
                geku("4201-5400 / 414.1-469HP(420.3-476.0PS", "自用小客車", 46170);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 8)
            {
                geku("5401-6600 / 469.1-509HP(476.1-516.6PS", "自用小客車", 69690);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 9)
            {
                geku("6601-7800 / 509.1HP以上(516.7PS以上)", "自用小客車", 117000);
            }
            else if (this.cbxType.SelectedIndex == 3 && this.cbxType2.SelectedIndex == 10)
            {
                geku("7801以上", "自用小客車", 151200);
            }

            if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 0)
            {
                geku("500以下 / 38HP以下(38.6PS以下)", "營業用小客車", 900);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 1)
            {
                geku("501~600 / 38.1-56HP(38.7-56.8PS)", "營業用小客車", 1260);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 2)
            {
                geku("601~1200 / 56.1-83HP(56.9-84.2PS)", "營業用小客車", 2160);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 3)
            {
                geku("1201~1800 / 83.1-182HP(84.3-184.7PS)", "營業用小客車", 3060);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 4)
            {
                geku("1801~2400 / 182.1-262HP(184.8-265.9PS)", "營業用小客車", 6480);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 5)
            {
                geku("2401~3000 / 262.1-322HP(266-326.8PS)", "營業用小客車", 9900);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 6)
            {
                geku("3001-4200 / 322.1-414HP(326.9-420.2PS)", "營業用小客車", 16380);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 7)
            {
                geku("4201-5400 / 414.1-469HP(420.3-476.0PS)", "營業用小客車", 24300);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 8)
            {
                geku("5401-6600 / 469.1-509HP(476.1-516.6PS)", "營業用小客車", 33660);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 9)
            {
                geku("6601-7800 / 509.1HP以上(516.7PS以上)", "營業用小客車", 44460);
            }
            else if (this.cbxType.SelectedIndex == 4 && this.cbxType2.SelectedIndex == 10)
            {
                geku("7801以上", "營業用小客車", 56700);
            }
        }
    }
}
