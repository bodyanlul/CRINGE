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
            AvgCount.Text = Convert.ToString(Line.Nobsl);
            Chance.Text = Convert.ToString(Line.Nobsl / (Line.Nobsl + Line.Neobsl) * 100);
            AvgLoadM.Text = Convert.ToString(time - Line.Tpr);
            AvgTime.Text = Convert.ToString(Line.TIME/Line.Nobsl);
            AvgLoadP.Text = Convert.ToString(100 - (Line.Tpr/time)*100);
        }
    }
}
