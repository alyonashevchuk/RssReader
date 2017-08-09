namespace LatestNews
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(273, 436);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 455);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "News";
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(302, 273);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.ReadOnly = true;
            this.textBox_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_text.Size = new System.Drawing.Size(436, 191);
            this.textBox_text.TabIndex = 3;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(302, 221);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.ReadOnly = true;
            this.textBox_title.Size = new System.Drawing.Size(436, 20);
            this.textBox_title.TabIndex = 4;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_image.Location = new System.Drawing.Point(302, 12);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(436, 203);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image.TabIndex = 5;
            this.pictureBox_image.TabStop = false;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(302, 247);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(436, 20);
            this.textBox_date.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 479);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "RSS Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.TextBox textBox_date;
    }
}

