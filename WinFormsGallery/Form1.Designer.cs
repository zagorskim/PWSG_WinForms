
namespace WinFormsGallery
{
    partial class Form1
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
            this.galleryLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.emptyLabel1 = new System.Windows.Forms.Label();
            this.imageButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.emptyLabel2 = new System.Windows.Forms.Label();
            this.galleryLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // galleryLayoutPanel
            // 
            this.galleryLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.galleryLayoutPanel.ColumnCount = 2;
            this.galleryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.galleryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.galleryLayoutPanel.Controls.Add(this.emptyLabel1, 0, 0);
            this.galleryLayoutPanel.Controls.Add(this.imageButton, 1, 0);
            this.galleryLayoutPanel.Controls.Add(this.colorButton, 1, 1);
            this.galleryLayoutPanel.Controls.Add(this.emptyLabel2, 0, 1);
            this.galleryLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.galleryLayoutPanel.Name = "galleryLayoutPanel";
            this.galleryLayoutPanel.RowCount = 2;
            this.galleryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.galleryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.galleryLayoutPanel.Size = new System.Drawing.Size(760, 437);
            this.galleryLayoutPanel.TabIndex = 0;
            // 
            // emptyLabel1
            // 
            this.emptyLabel1.AutoSize = true;
            this.emptyLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyLabel1.Location = new System.Drawing.Point(3, 0);
            this.emptyLabel1.Name = "emptyLabel1";
            this.emptyLabel1.Size = new System.Drawing.Size(500, 218);
            this.emptyLabel1.TabIndex = 1;
            // 
            // imageButton
            // 
            this.imageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageButton.Location = new System.Drawing.Point(509, 3);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(248, 212);
            this.imageButton.TabIndex = 0;
            this.imageButton.Text = "Choose Image";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorButton.Location = new System.Drawing.Point(509, 221);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(248, 213);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Choose Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // emptyLabel2
            // 
            this.emptyLabel2.AutoSize = true;
            this.emptyLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyLabel2.Location = new System.Drawing.Point(3, 218);
            this.emptyLabel2.Name = "emptyLabel2";
            this.emptyLabel2.Size = new System.Drawing.Size(500, 219);
            this.emptyLabel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.galleryLayoutPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.galleryLayoutPanel.ResumeLayout(false);
            this.galleryLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel galleryLayoutPanel;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label emptyLabel2;
        private System.Windows.Forms.Label emptyLabel1;
    }
}

