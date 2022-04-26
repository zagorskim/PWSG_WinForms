using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_pkt
{
    public partial class SizeInput : Form
    {
        public Bloq parent;
        //public event EventHandler BitmapCreated(EventArgs e);
        public delegate void BitmapCreated();
        public event BitmapCreated OnBitmapCreated;

        public SizeInput(int w, int h)
        {
            InitializeComponent();
            textBox1.Text = w.ToString();
            textBox2.Text = h.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(this.textBox1.Text) < 500 || int.Parse(this.textBox1.Text) > 10000 || int.Parse(this.textBox2.Text) < 500 || int.Parse(this.textBox2.Text) > 10000)
                this.button1.Enabled = false;
            else this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var da = new Bitmap(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            parent.drawArea = da;
            using (Graphics g = Graphics.FromImage(parent.drawArea))
            {
                g.Clear(Color.White);
            }
            parent.objects.Clear();
            parent.lines.Clear();
            parent.nodes.Clear();
            OnBitmapCreated.Invoke();
            this.Close();
        }
    }
}
