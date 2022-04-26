using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_pkt
{
    public class Block
    {
        private (int, int) position;
        public string text;
        public bool marked = false;
        public int x
        {
            get { return position.Item1; }
            set { position.Item1 = value; }
        }
        public int y
        {
            get { return position.Item2; }
            set { position.Item2 = value; }
        }
        public Pen pen;
        public SolidBrush captioncolor = new SolidBrush(Color.Khaki);
        public Font f = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
        public StringFormat sf = new StringFormat();
        public Block(int x, int y)
        {
            position.Item1 = x;
            position.Item2 = y;
            pen = new Pen(Brushes.Black, 1);
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
        }
        public virtual void Draw(Bitmap drawArea) { }
        public virtual bool IsInside(int x, int y) { return false; }
        public virtual void Mark() { }
    }

    public class Ellipse : Block
    {
        public int x_radius = 60;
        public int y_radius = 30;
        public Ellipse(int x, int y) : base(x, y) { }
        public override bool IsInside(int x, int y)
        {
            if (Math.Sqrt(Math.Pow(this.x - x, 2) + 2 * Math.Pow(this.y - y, 2)) < 60) return true;
            return false;
        }
    }
    public class Start : Ellipse
    {
        public Node down_exit;
        public Start(int x, int y) : base(x, y)
        {
            down_exit = new Node(x, y + 30, true);
            text = new string("START");
        }
        public override void Draw(Bitmap drawArea)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                var p = new System.Drawing.Pen(Brushes.Green, 2);
                if (marked == true)
                    p.DashPattern = new float[] { 10, 5 };
                g.FillEllipse(Brushes.White, x - x_radius, y - y_radius, 2 * x_radius, 2 * y_radius);
                g.DrawEllipse(p, x - x_radius, y - y_radius, 2 * x_radius, 2 * y_radius);
                down_exit.Draw(drawArea);
                using (Graphics gr = Graphics.FromImage(drawArea))
                {
                    gr.DrawString(text, f, Brushes.Black, x, y, sf);
                }
            }
        }
        public override void Mark()
        {
            
        }
    }
    public class Stop : Ellipse
    {
        public Node up_entrance;
        public Stop(int x, int y) : base(x, y) 
        {
            up_entrance = new Node(x, y - 30, false);
            text = new string("STOP");
        }
        public override void Draw(Bitmap drawArea)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                var p = new System.Drawing.Pen(Brushes.Red, 2);
                if (marked == true)
                    p.DashPattern = new float[] { 10, 5 };
                g.FillEllipse(Brushes.White, x - x_radius, y - y_radius, 2 * x_radius, 2 * y_radius);
                g.DrawEllipse(p, x - x_radius, y - y_radius, 2 * x_radius, 2 * y_radius);
                up_entrance.Draw(drawArea);
                using (Graphics gr = Graphics.FromImage(drawArea))
                {
                    gr.DrawString(text, f, Brushes.Black, x, y, sf);
                }
            }
        }
        public override void Mark()
        {

        }
    }
    public class BlokOperacyjny : Block
    {
        public Node down_exit;
        public Node up_entrance;
        public BlokOperacyjny(int x, int y) : base(x, y) 
        {
            down_exit = new Node(x, y + 30, true);
            up_entrance = new Node(x, y - 30, false);
            text = new string("Blok Operacyjny");
        }
        public override bool IsInside(int x, int y)
        {
            if (x > this.x - 60 && x < this.x + 60 && y > this.y - 30 && y < this.y + 30) return true;
            return false;
        }
        public override void Draw(System.Drawing.Bitmap drawArea)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                var p = new System.Drawing.Pen(Brushes.Black, 2);
                if (marked == true)
                    p.DashPattern = new float[] { 10, 5 };
                g.FillRectangle(Brushes.White, x - 60, y - 30, 120, 60);
                g.DrawRectangle(p, x - 60, y - 30, 120, 60);
                down_exit.Draw(drawArea);
                up_entrance.Draw(drawArea);
                using (Graphics gr = Graphics.FromImage(drawArea))
                {
                    gr.DrawString(text, f, Brushes.Black, x, y, sf);
                }
            }
        }
        public override void Mark()
        {

        }
    }
    public class BlokDecyzyjny : Block
    {

        public Node left_exit;
        public Node right_exit;
        public Node up_entrance;

        public BlokDecyzyjny(int x, int y) : base(x, y) 
        {
            left_exit = new Node(x - 60, y, true);
            right_exit = new Node(x + 60, y, true);
            up_entrance = new Node(x, y - 30, false);
            text = new string("Blok Decyzyjny");

        }
        public override bool IsInside(int x, int y)
        {
            // TBD CORRECT AREA DETECTED
            //if (this.y - 0.5 * this.x + 30 < y - x && this.y - 0.5 * this.x - 30 > y - x && this.y + 0.5 * this.x + 30 < y - x && this.y + 0.5 * this.x - 30 > y - x) return true;
            //if (0.5 * Math.Abs(this.x - x) -  Math.Abs(this.y - y) > 30) return true;
            if (Math.Sqrt(Math.Pow(this.x - x, 2) + 2 * Math.Pow(this.y - y, 2)) < 60) return true;
            return false;
        }
        public override void Draw(Bitmap drawArea)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                var d = new System.Drawing.Pen(Brushes.Black, 2);
                if (marked == true)
                   d.DashPattern = new float[] { 10, 5 };
                Point[] p = new Point[4];
                p[0] = new Point(x - 60, y);
                p[1] = new Point(x, y - 30);
                p[2] = new Point(x + 60, y);
                p[3] = new Point(x, y + 30);
                g.FillPolygon(Brushes.White, p);
                g.DrawPolygon(d, p);
                left_exit.Draw(drawArea);
                right_exit.Draw(drawArea);
                up_entrance.Draw(drawArea);
                using (Graphics gr = Graphics.FromImage(drawArea))
                {
                    gr.DrawString(text, f, Brushes.Black, x, y, sf);
                    gr.DrawString("T", f, Brushes.Black, x - 60, y - 15, sf);
                    gr.DrawString("F", f, Brushes.Black, x + 60, y - 15, sf);
                }
            }
        }
        public override void Mark()
        {

        }
    }
    public class Line
    {
        public Node from;
        public Node to;

        public Line(int x_from, int y_from, int x_to, int y_to)
        {
            from = new Node(x_from, y_from, true);
            to = new Node(x_to, y_to, false);
        }
        public void Draw(Bitmap drawArea)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                var p = new Pen(Brushes.Black, 3);
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(p, from.coords, to.coords);
            }
        }
    }
    public class Node
    {
        public Point coords;
        public bool exit;
        int radius = 3;
        public Node(int x, int y, bool exit)
        {
            coords = new Point(x, y);
            this.exit = exit;
        }
        public void Draw(Bitmap drawArea)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                if(exit == true)
                    g.FillEllipse(Brushes.Black, coords.X - radius, coords.Y - radius, 2 * radius, 2 * radius);
                else
                    g.FillEllipse(Brushes.White, coords.X - radius, coords.Y - radius, 2 * radius, 2 * radius);
                g.DrawEllipse((new Pen(Brushes.Black, 1)), coords.X - radius, coords.Y - radius, 2 * radius, 2 * radius);
            }
        }
        public bool IsInside(int x, int y)
        {
            if (Math.Sqrt(Math.Pow(coords.X - x, 2) + 2 * Math.Pow(coords.Y - y, 2)) < radius + 3) return true;
            return false;
        }
    }
}
