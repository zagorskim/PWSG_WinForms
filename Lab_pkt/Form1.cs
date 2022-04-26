using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Lab_pkt
{
    public enum Options
    {
        None,
        BlokOperacyjny,
        BlokDecyzyjny,
        Start,
        Stop,
        Link,
        Delete
    }
    public partial class Bloq : Form
    {
        public Bitmap drawArea;
        public Pen pen;
        public Options option;
        public List<Button> optionButtons;
        public List<Block> objects;
        public List<Line> lines;
        public List<Node> nodes;
        private Block marked;
        private bool isstart = false;
        private bool isstop = false;
        public SolidBrush captioncolor = new SolidBrush(Color.Khaki);
        public Font f = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
        public Timer timer;
        public bool flag = false;
        public bool flag2 = false;
        public Node hitNode = null;
        public Graphics gr;
        public Bloq()
        {
            InitializeComponent();
            polski_button.BackColor = Color.LightBlue;
            pen = new Pen(Brushes.Black, 1);
            drawArea = new Bitmap(picture.Size.Width, picture.Size.Height);
            picture.Image = drawArea;
            picture.Width = drawArea.Width;
            picture.Height = drawArea.Height;
            picture.Image = drawArea;
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }

            option = Options.None;
            optionButtons = new List<Button>();
            optionButtons.Add(blokoperacyjny_button);
            optionButtons.Add(blokdecyzyjny_button);
            optionButtons.Add(start_button);
            optionButtons.Add(stop_button);
            optionButtons.Add(link_button);
            optionButtons.Add(delete_button);

            objects = new List<Block>();
            lines = new List<Line>();
            nodes = new List<Node>();

            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += TimerHandle;
            flag = false;
            flag2 = false;

            picture.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new SizeInput(drawArea.Width, drawArea.Height);
            f.OnBitmapCreated += BitmapCreatedEventHandler;
            f.Show();
            f.parent = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                angielski_button.Text = "English";
                polski_button.Text = "Polish";
                label1.Text = "Text on marked block:";
                edycja_groupbox.Text = "Edit";
                jezyk_groupbox.Text = "Language";
                plik_groupbox.Text = "File";
                nowyschemat_button.Text = "New Schema";
                wczytajschemat_button.Text = "Load Schema";
                zapiszschemat_button.Text = "Save Schema";
                polski_button.BackColor = Color.White;
                angielski_button.BackColor = Color.LightBlue;
        }

        //https://social.msdn.microsoft.com/Forums/sqlserver/en-US/3b33505b-8b36-4e5a-a78a-eccc003d2d85/how-do-i-get-automatic-scrollbars-for-a-picturebox?forum=winforms
        private void Form1_Load(object sender, EventArgs e)
        {
            this.picture.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picture_panel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void picture_panel_Resize(object sender, EventArgs e)
        {
            if (this.picture.Image != null)
            {
                Size picSize = this.picture.Image.Size;
                Size panSize = this.picture_panel.Size;
                if (picSize.Height < panSize.Height)
                {
                    this.picture.Location = new Point(this.picture.Location.X, (panSize.Height - picSize.Height) / 2);
                }
                else
                {
                    this.picture.Location = new Point(this.picture.Location.X, 0);
                }
                if (picSize.Width < panSize.Width)
                {
                    this.picture.Location = new Point((panSize.Width - picSize.Width) / 2, this.picture.Location.Y);
                }
                else
                {
                    this.picture.Location = new Point(0, this.picture.Location.Y);
                }
            }
            picture.Refresh();
        }
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                switch(this.option)
                {
                    case Options.None:
                        break;
                    case Options.BlokOperacyjny:
                        var block1 = new BlokOperacyjny(e.X, e.Y);
                        block1.Draw(drawArea);
                        objects.Add(block1);
                        nodes.Add(block1.down_exit);
                        nodes.Add(block1.up_entrance);
                        break;
                    case Options.BlokDecyzyjny:
                        var block2 = new BlokDecyzyjny(e.X, e.Y);
                        block2.Draw(drawArea);
                        objects.Add(block2);
                        nodes.Add(block2.right_exit);
                        nodes.Add(block2.left_exit);
                        nodes.Add(block2.up_entrance);
                        break;
                    case Options.Start:
                        if (isstart != true)
                        {
                            var block3 = new Start(e.X, e.Y);
                            block3.Draw(drawArea);
                            objects.Add(block3);
                            nodes.Add(block3.down_exit);
                            isstart = true;
                        }
                        else
                        {
                            var m = MessageBox.Show("Istnieje już jeden blok startowy", "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                        }
                        break;
                    case Options.Stop:
                        if (isstop != true)
                        {
                            var block4 = new Stop(e.X, e.Y);
                            block4.Draw(drawArea);
                            objects.Add(block4);
                            nodes.Add(block4.up_entrance);
                            isstop = true;
                        }
                        else
                        {
                            var m = MessageBox.Show("Istnieje już jeden blok końcowy", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                        }
                        break;
                    case Options.Link:
                        foreach(var node in nodes)
                        {
                            if(node.IsInside(e.X, e.Y) == true && node.exit == true)
                            {
                                flag = true;
                                //gr = Graphics.FromImage(drawArea);
                                hitNode = node;
                                //timer.Start();
                                break;
                            }
                        }
                        break;
                    case Options.Delete:
                        objects.Reverse();
                        foreach(var item in objects)
                        {
                            if(item.IsInside(e.X, e.Y))
                            {
                                if (item.GetType() == typeof(Start)) isstart = false;
                                if (item.GetType() == typeof(Stop)) isstop = false;
                                objects.Remove(item);
                                Node n1 = new Node(0, 0, false);
                                Node n2 = new Node(0, 0, false);
                                Node n3 = new Node(0, 0, false);
                                int index = 0;
                                if (item.GetType() == typeof(Start))
                                {
                                    index = 0;
                                    n1 = new Node((item as Start).down_exit.coords.X, (item as Start).down_exit.coords.Y, true);
                                }
                                else if (item.GetType() == typeof(Stop))
                                {
                                    index = 1;
                                    n1 = new Node((item as Stop).up_entrance.coords.X, (item as Stop).up_entrance.coords.Y, false);
                                }
                                else if (item.GetType() == typeof(BlokOperacyjny))
                                {
                                    index = 2;
                                    n1 = new Node((item as BlokOperacyjny).up_entrance.coords.X, (item as BlokOperacyjny).up_entrance.coords.Y, false);
                                    n2 = new Node((item as BlokOperacyjny).down_exit.coords.X, (item as BlokOperacyjny).down_exit.coords.Y, true);
                                }
                                else
                                {
                                    index = 3;
                                    n1 = new Node((item as BlokDecyzyjny).up_entrance.coords.X, (item as BlokDecyzyjny).up_entrance.coords.Y, false);
                                    n2 = new Node((item as BlokDecyzyjny).left_exit.coords.X, (item as BlokDecyzyjny).left_exit.coords.Y, true);
                                    n3 = new Node((item as BlokDecyzyjny).right_exit.coords.X, (item as BlokDecyzyjny).right_exit.coords.Y, true);
                                }
                                for(int i = lines.Count - 1; i >= 0; i--)
                                {
                                    var line = lines[i];
                                    switch(index)
                                    {
                                        case 0:
                                            if (line.from.coords == n1.coords)
                                                lines.Remove(line);
                                            break;
                                        case 1:
                                            if (line.to.coords == n1.coords)
                                                lines.Remove(line);
                                            break;
                                        case 2:
                                            if (line.to.coords == n1.coords)
                                                lines.Remove(line);
                                            if (line.from.coords == n2.coords)
                                                lines.Remove(line);
                                            break;
                                        case 3:
                                            if (line.to.coords == n1.coords)
                                                lines.Remove(line);
                                            if (line.from.coords == n2.coords)
                                                lines.Remove(line);
                                            if (line.from.coords == n3.coords)
                                                lines.Remove(line);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            }
                        }
                        objects.Reverse();
                        RedrawObjects();
                        break;
                    default:
                        break;
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                if (marked != null)
                {
                    marked.marked = false;
                    marked.Draw(drawArea);
                }
                objects.Reverse();
                foreach(var item in objects)
                {
                    if(item.IsInside(e.X, e.Y) == true)
                    {
                        item.marked = true;
                        marked = item;
                        item.Draw(drawArea);
                        block_text.Text = item.text;
                        break;
                    }
                }
                objects.Reverse();
            }
            // MPM -> PPM -> MPM -PPM bugged - generates few same blocks 
            else if (e.Button == MouseButtons.Middle)
            {
                flag2 = true;
            }
            picture.Refresh();
        }
        //Block images from Joanna Sowa
        private void blokoperacyjny_button_Click(object sender, EventArgs e)
        {
            if((sender as Button).BackColor == Color.LightBlue)
            {
                (sender as Button).BackColor = Color.White;
                option = Options.None;
            }
            else
            {
            int current = 0;
                foreach (var item in optionButtons)
                {
                    if ((sender as Button).Name == item.Name)
                    {
                        item.BackColor = Color.LightBlue;
                        option = (Options)(current + 1);
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                    current++;
                }
            }
        }

        private void zapiszschemat_button_Click(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/pl-pl/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
            var d = new SaveFileDialog();
            d.Filter = "Diag File|*.diag|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            d.Title = "Save the schema";
            d.ShowDialog();

            if (d.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)d.OpenFile();
                switch (d.FilterIndex)
                {
                    case 1:
                        // FILL SAVING TO .diag
                        break;
                    case 2:
                        this.picture.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        this.picture.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 4:
                        this.picture.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }
        private void BitmapCreatedEventHandler()
        {
            picture.Image = drawArea;
        }

        private void RedrawObjects()
        {
            picture.Refresh();
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }
            foreach (var item in lines)
            {
                item.Draw(drawArea);
            }
            foreach (var item in objects)
            {
                item.Draw(drawArea);
            }
            picture.Refresh();
        }

        private void block_text_TextChanged(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
            }
            picture.Refresh();
            marked.text = (sender as TextBox).Text;
            RedrawObjects();
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            //timer.Stop();
            if (flag == true)
            {
                foreach (var node in nodes)
                {
                    if (node.IsInside(e.X, e.Y) && node.exit == false)
                    {
                        if (lines.Contains(new Line(hitNode.coords.X, hitNode.coords.Y, node.coords.X, node.coords.Y))) Console.WriteLine("jest");
                        var line = new Line(hitNode.coords.X, hitNode.coords.Y, node.coords.X, node.coords.Y);
                        lines.Add(line);
                    }
                }
                RedrawObjects();
                flag = false;
            }
            else if (flag2 == true && marked != null)
            {
                marked.x = e.X;
                marked.y = e.Y;
                flag2 = false;
            }
        }
        private void polski_button_Click(object sender, EventArgs e)
        {
            angielski_button.Text = "Angielski";
            polski_button.Text = "Polski";
            label1.Text = "Tekst na zaznaczonym bloku:";
            edycja_groupbox.Text = "Edycja";
            jezyk_groupbox.Text = "Język";
            plik_groupbox.Text = "Plik";
            nowyschemat_button.Text = "Nowy Schemat";
            wczytajschemat_button.Text = "Wczytaj Schemat";
            zapiszschemat_button.Text = "Zapisz Schemat";
            polski_button.BackColor = Color.LightBlue;
            angielski_button.BackColor = Color.White;
        }

        public void TimerHandle(object source, System.Timers.ElapsedEventArgs args)
        {
            //using (Graphics g = Graphics.FromImage(drawArea))
            //{
            //    g.DrawLine(pen, hitNode.coords, MousePosition);
            //}
            //RedrawObjects();
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                RedrawObjects();
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.DrawLine(pen, hitNode.coords, new Point(e.X, e.Y));
                }
                picture.Refresh();
            }
            else if (flag2 == true && marked != null)
            {
                marked.x = e.X;
                marked.y = e.Y;
                RedrawObjects();
            }
        }

        private void wczytajschemat_button_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            d.Title = "Open Image";
            d.Filter = "Diag File|*.diag|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if(d.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(d.FileName);
            }
        }

    }
}
