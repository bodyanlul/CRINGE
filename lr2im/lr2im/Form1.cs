using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2im
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double time;
            time = Convert.ToDouble(textBox1.Text)*60;
            Line.Modeling(time);
            AvgCount.Text = Convert.ToString(Line.Nobsl/2);
            Count1.Text = Convert.ToString(Math.Round((Line.Nobsl * 2 / 7), 0));
            Count2.Text = Convert.ToString(Math.Round((Line.Nobsl * 5 / 7),0));

            Chance.Text = Convert.ToString(Line.Nobsl / (Line.Nobsl + Line.Neobsl) * 100);
            Chance1.Text = Convert.ToString(Convert.ToDouble(Count1.Text) / (Line.Neobsl + Convert.ToDouble(Count1.Text)) * 100);
            Chance2.Text = Convert.ToString(Convert.ToDouble(Count2.Text) / (Line.Neobsl + Convert.ToDouble(Count2.Text)) * 100);

            AvgLoadM.Text = Convert.ToString(time - Line.Tpr);
            AvgLoadP.Text = Convert.ToString(100 - (Line.Tpr / time) * 100);

            AvgTime.Text = Convert.ToString(Line.TIME/Line.Nobsl);
            Time1.Text = Convert.ToString(Line.TIME / Line.Nobsl * 10 / 7);
            Time2.Text = Convert.ToString(Line.TIME / Line.Nobsl * 4 / 7);
        }
    }
}
// 5/7 2/7