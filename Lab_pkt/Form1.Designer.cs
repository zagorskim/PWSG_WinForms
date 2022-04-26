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
    partial class Bloq
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloq));
            this.form1_splitcontainter = new System.Windows.Forms.SplitContainer();
            this.picture_panel = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.jezyk_groupbox = new System.Windows.Forms.GroupBox();
            this.angielski_button = new System.Windows.Forms.Button();
            this.polski_button = new System.Windows.Forms.Button();
            this.edycja_groupbox = new System.Windows.Forms.GroupBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.link_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.block_text = new System.Windows.Forms.TextBox();
            this.blokdecyzyjny_button = new System.Windows.Forms.Button();
            this.blokoperacyjny_button = new System.Windows.Forms.Button();
            this.plik_groupbox = new System.Windows.Forms.GroupBox();
            this.wczytajschemat_button = new System.Windows.Forms.Button();
            this.zapiszschemat_button = new System.Windows.Forms.Button();
            this.nowyschemat_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form1_splitcontainter)).BeginInit();
            this.form1_splitcontainter.Panel1.SuspendLayout();
            this.form1_splitcontainter.Panel2.SuspendLayout();
            this.form1_splitcontainter.SuspendLayout();
            this.picture_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.jezyk_groupbox.SuspendLayout();
            this.edycja_groupbox.SuspendLayout();
            this.plik_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // form1_splitcontainter
            // 
            this.form1_splitcontainter.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.form1_splitcontainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form1_splitcontainter.Location = new System.Drawing.Point(0, 0);
            this.form1_splitcontainter.Name = "form1_splitcontainter";
            // 
            // form1_splitcontainter.Panel1
            // 
            this.form1_splitcontainter.Panel1.Controls.Add(this.picture_panel);
            // 
            // form1_splitcontainter.Panel2
            // 
            this.form1_splitcontainter.Panel2.Controls.Add(this.jezyk_groupbox);
            this.form1_splitcontainter.Panel2.Controls.Add(this.edycja_groupbox);
            this.form1_splitcontainter.Panel2.Controls.Add(this.plik_groupbox);
            this.form1_splitcontainter.Size = new System.Drawing.Size(784, 561);
            this.form1_splitcontainter.SplitterDistance = 600;
            this.form1_splitcontainter.TabIndex = 0;
            // 
            // picture_panel
            // 
            this.picture_panel.AutoScroll = true;
            this.picture_panel.Controls.Add(this.picture);
            this.picture_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_panel.Location = new System.Drawing.Point(0, 0);
            this.picture_panel.Name = "picture_panel";
            this.picture_panel.Size = new System.Drawing.Size(600, 561);
            this.picture_panel.TabIndex = 1;
            this.picture_panel.Resize += new System.EventHandler(this.picture_panel_Resize);
            // 
            // picture
            // 
            this.picture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(500, 500);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // jezyk_groupbox
            // 
            this.jezyk_groupbox.Controls.Add(this.angielski_button);
            this.jezyk_groupbox.Controls.Add(this.polski_button);
            this.jezyk_groupbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.jezyk_groupbox.Location = new System.Drawing.Point(3, 391);
            this.jezyk_groupbox.Name = "jezyk_groupbox";
            this.jezyk_groupbox.Size = new System.Drawing.Size(174, 158);
            this.jezyk_groupbox.TabIndex = 2;
            this.jezyk_groupbox.TabStop = false;
            this.jezyk_groupbox.Text = "Język";
            // 
            // angielski_button
            // 
            this.angielski_button.Location = new System.Drawing.Point(6, 86);
            this.angielski_button.Name = "angielski_button";
            this.angielski_button.Size = new System.Drawing.Size(162, 58);
            this.angielski_button.TabIndex = 5;
            this.angielski_button.Text = "Angielski";
            this.angielski_button.UseVisualStyleBackColor = true;
            this.angielski_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // polski_button
            // 
            this.polski_button.Location = new System.Drawing.Point(6, 22);
            this.polski_button.Name = "polski_button";
            this.polski_button.Size = new System.Drawing.Size(162, 58);
            this.polski_button.TabIndex = 4;
            this.polski_button.Text = "Polski";
            this.polski_button.UseVisualStyleBackColor = true;
            this.polski_button.Click += new System.EventHandler(this.polski_button_Click);
            // 
            // edycja_groupbox
            // 
            this.edycja_groupbox.Controls.Add(this.delete_button);
            this.edycja_groupbox.Controls.Add(this.link_button);
            this.edycja_groupbox.Controls.Add(this.stop_button);
            this.edycja_groupbox.Controls.Add(this.start_button);
            this.edycja_groupbox.Controls.Add(this.label1);
            this.edycja_groupbox.Controls.Add(this.block_text);
            this.edycja_groupbox.Controls.Add(this.blokdecyzyjny_button);
            this.edycja_groupbox.Controls.Add(this.blokoperacyjny_button);
            this.edycja_groupbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.edycja_groupbox.Location = new System.Drawing.Point(3, 115);
            this.edycja_groupbox.Name = "edycja_groupbox";
            this.edycja_groupbox.Size = new System.Drawing.Size(174, 270);
            this.edycja_groupbox.TabIndex = 1;
            this.edycja_groupbox.TabStop = false;
            this.edycja_groupbox.Text = "Edycja";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.White;
            this.delete_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_button.Image")));
            this.delete_button.Location = new System.Drawing.Point(116, 81);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(52, 52);
            this.delete_button.TabIndex = 7;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.blokoperacyjny_button_Click);
            // 
            // link_button
            // 
            this.link_button.BackColor = System.Drawing.Color.White;
            this.link_button.Image = ((System.Drawing.Image)(resources.GetObject("link_button.Image")));
            this.link_button.Location = new System.Drawing.Point(116, 22);
            this.link_button.Name = "link_button";
            this.link_button.Size = new System.Drawing.Size(52, 52);
            this.link_button.TabIndex = 6;
            this.link_button.UseVisualStyleBackColor = false;
            this.link_button.Click += new System.EventHandler(this.blokoperacyjny_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.White;
            this.stop_button.Image = ((System.Drawing.Image)(resources.GetObject("stop_button.Image")));
            this.stop_button.Location = new System.Drawing.Point(61, 81);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(52, 52);
            this.stop_button.TabIndex = 5;
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.blokoperacyjny_button_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.White;
            this.start_button.Image = ((System.Drawing.Image)(resources.GetObject("start_button.Image")));
            this.start_button.Location = new System.Drawing.Point(61, 22);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(52, 52);
            this.start_button.TabIndex = 4;
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.blokoperacyjny_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tekst na zaznaczonym bloku:";
            // 
            // block_text
            // 
            this.block_text.Location = new System.Drawing.Point(6, 160);
            this.block_text.Multiline = true;
            this.block_text.Name = "block_text";
            this.block_text.Size = new System.Drawing.Size(162, 104);
            this.block_text.TabIndex = 2;
            this.block_text.TextChanged += new System.EventHandler(this.block_text_TextChanged);
            // 
            // blokdecyzyjny_button
            // 
            this.blokdecyzyjny_button.Image = ((System.Drawing.Image)(resources.GetObject("blokdecyzyjny_button.Image")));
            this.blokdecyzyjny_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.blokdecyzyjny_button.Location = new System.Drawing.Point(6, 81);
            this.blokdecyzyjny_button.Name = "blokdecyzyjny_button";
            this.blokdecyzyjny_button.Size = new System.Drawing.Size(52, 52);
            this.blokdecyzyjny_button.TabIndex = 1;
            this.blokdecyzyjny_button.UseVisualStyleBackColor = true;
            this.blokdecyzyjny_button.Click += new System.EventHandler(this.blokoperacyjny_button_Click);
            // 
            // blokoperacyjny_button
            // 
            this.blokoperacyjny_button.BackColor = System.Drawing.Color.White;
            this.blokoperacyjny_button.Image = ((System.Drawing.Image)(resources.GetObject("blokoperacyjny_button.Image")));
            this.blokoperacyjny_button.Location = new System.Drawing.Point(6, 22);
            this.blokoperacyjny_button.Name = "blokoperacyjny_button";
            this.blokoperacyjny_button.Size = new System.Drawing.Size(52, 52);
            this.blokoperacyjny_button.TabIndex = 0;
            this.blokoperacyjny_button.UseVisualStyleBackColor = false;
            this.blokoperacyjny_button.Click += new System.EventHandler(this.blokoperacyjny_button_Click);
            // 
            // plik_groupbox
            // 
            this.plik_groupbox.Controls.Add(this.wczytajschemat_button);
            this.plik_groupbox.Controls.Add(this.zapiszschemat_button);
            this.plik_groupbox.Controls.Add(this.nowyschemat_button);
            this.plik_groupbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.plik_groupbox.Location = new System.Drawing.Point(0, 0);
            this.plik_groupbox.Name = "plik_groupbox";
            this.plik_groupbox.Size = new System.Drawing.Size(177, 109);
            this.plik_groupbox.TabIndex = 0;
            this.plik_groupbox.TabStop = false;
            this.plik_groupbox.Text = "Plik";
            // 
            // wczytajschemat_button
            // 
            this.wczytajschemat_button.Location = new System.Drawing.Point(9, 77);
            this.wczytajschemat_button.Name = "wczytajschemat_button";
            this.wczytajschemat_button.Size = new System.Drawing.Size(162, 23);
            this.wczytajschemat_button.TabIndex = 2;
            this.wczytajschemat_button.Text = "Wczytaj Schemat";
            this.wczytajschemat_button.UseVisualStyleBackColor = true;
            this.wczytajschemat_button.Click += new System.EventHandler(this.wczytajschemat_button_Click);
            // 
            // zapiszschemat_button
            // 
            this.zapiszschemat_button.Location = new System.Drawing.Point(9, 48);
            this.zapiszschemat_button.Name = "zapiszschemat_button";
            this.zapiszschemat_button.Size = new System.Drawing.Size(162, 23);
            this.zapiszschemat_button.TabIndex = 1;
            this.zapiszschemat_button.Text = "Zapisz Schemat";
            this.zapiszschemat_button.UseVisualStyleBackColor = true;
            this.zapiszschemat_button.Click += new System.EventHandler(this.zapiszschemat_button_Click);
            // 
            // nowyschemat_button
            // 
            this.nowyschemat_button.Location = new System.Drawing.Point(9, 19);
            this.nowyschemat_button.Name = "nowyschemat_button";
            this.nowyschemat_button.Size = new System.Drawing.Size(162, 23);
            this.nowyschemat_button.TabIndex = 0;
            this.nowyschemat_button.Text = "Nowy Schemat";
            this.nowyschemat_button.UseVisualStyleBackColor = true;
            this.nowyschemat_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bloq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.form1_splitcontainter);
            this.Name = "Bloq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloq";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form1_splitcontainter.Panel1.ResumeLayout(false);
            this.form1_splitcontainter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1_splitcontainter)).EndInit();
            this.form1_splitcontainter.ResumeLayout(false);
            this.picture_panel.ResumeLayout(false);
            this.picture_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.jezyk_groupbox.ResumeLayout(false);
            this.edycja_groupbox.ResumeLayout(false);
            this.edycja_groupbox.PerformLayout();
            this.plik_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer form1_splitcontainter;
        private System.Windows.Forms.GroupBox plik_groupbox;
        private System.Windows.Forms.Button nowyschemat_button;
        private System.Windows.Forms.GroupBox jezyk_groupbox;
        private System.Windows.Forms.Button angielski_button;
        private System.Windows.Forms.Button polski_button;
        private System.Windows.Forms.GroupBox edycja_groupbox;
        private System.Windows.Forms.Button blokdecyzyjny_button;
        private System.Windows.Forms.Button blokoperacyjny_button;
        private System.Windows.Forms.Button wczytajschemat_button;
        private System.Windows.Forms.Button zapiszschemat_button;
        private System.Windows.Forms.Panel picture_panel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox block_text;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button link_button;
    }
}

