namespace MovingCatJavieraD
{
    partial class frmMovingCat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCats = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat3 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCats});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCats
            // 
            this.mnuCats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2,
            this.mniCat3});
            this.mnuCats.Name = "mnuCats";
            this.mnuCats.Size = new System.Drawing.Size(42, 20);
            this.mnuCats.Text = "Cats";
            this.mnuCats.Click += new System.EventHandler(this.mnuCats_Click);
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(152, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(152, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // mniCat3
            // 
            this.mniCat3.Name = "mniCat3";
            this.mniCat3.Size = new System.Drawing.Size(152, 22);
            this.mniCat3.Text = "Cat3";
            this.mniCat3.Click += new System.EventHandler(this.mniCat3_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatJavieraD.Properties.Resources.MovingCat3;
            this.picCat.Location = new System.Drawing.Point(301, 119);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(500, 500);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCat.TabIndex = 0;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.picCat_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1100, 690);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMovingCat";
            this.Text = "MovingCat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCats;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.ToolStripMenuItem mniCat3;
    }
}

