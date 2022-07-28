using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Test5exe
{
    public partial class Main : Form
    {
        [DllImport(@"CPW.dll", CharSet = CharSet.Ansi, 
            CallingConvention = CallingConvention.Cdecl, EntryPoint = "CPW")]
        private static extern void CPW(double t, double h, double er, double aw, double[] s,
            ref double dC, ref double dL, ref double em, ref double dZ0);
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label14.Text = null;
            label15.Text = null;
            label17.Text = null;
            label32.Text = null;
            var t = Convert.ToDouble(textBox2.Text);
            var h = Convert.ToDouble(textBox3.Text);
            var er = Convert.ToDouble(textBox4.Text);
            double[] s = new double[2];
            var aw = Convert.ToDouble(textBox5.Text);
            s[0] = Convert.ToDouble(textBox8.Text);
            s[1] = Convert.ToDouble(textBox9.Text);
 
            double dC=0, dL=0, em=0, dZ0=0;
            CPW(t, h, er, aw, s, ref dC, ref dL, ref em, ref dZ0);
            label14.Text += Math.Round(dL, 4).ToString("0.0000");
            label15.Text += Math.Round(dC, 4).ToString("0.0000");
            label17.Text += Math.Round(em, 4).ToString("0.0000");
            label32.Text += Math.Round(dZ0, 4).ToString("0.0000");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
