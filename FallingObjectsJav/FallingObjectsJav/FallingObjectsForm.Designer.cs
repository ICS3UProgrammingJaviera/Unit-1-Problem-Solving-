namespace FallingObjectsJav
{
    partial class frmFallingObjects
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
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.lblStatment = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.BackColor = System.Drawing.Color.SlateGray;
            this.lblEnterTime.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEnterTime.Location = new System.Drawing.Point(59, 153);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(611, 30);
            this.lblEnterTime.TabIndex = 0;
            this.lblEnterTime.Text = "Enter the time (in seconds) since you released the object:";
            // 
            // lblStatment
            // 
            this.lblStatment.AutoSize = true;
            this.lblStatment.BackColor = System.Drawing.Color.SlateGray;
            this.lblStatment.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatment.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblStatment.Location = new System.Drawing.Point(256, 397);
            this.lblStatment.Name = "lblStatment";
            this.lblStatment.Size = new System.Drawing.Size(414, 26);
            this.lblStatment.TabIndex = 1;
            this.lblStatment.Text = "The height of the object above the ground is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.SlateGray;
            this.lblAnswer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswer.Location = new System.Drawing.Point(704, 399);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(82, 24);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(708, 163);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(125, 20);
            this.txtTime.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCalculate.Location = new System.Drawing.Point(471, 255);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 63);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.SlateGray;
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(1180, 24);
            this.mnuFile.TabIndex = 5;
            this.mnuFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.BackColor = System.Drawing.Color.SlateGray;
            this.mniExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FallingObjectsJav.Properties.Resources.image_0;
            this.ClientSize = new System.Drawing.Size(1180, 581);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblStatment);
            this.Controls.Add(this.lblEnterTime);
            this.Controls.Add(this.mnuFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects by Javiera Diaz";
            this.Load += new System.EventHandler(this.FallingObjectsForm_Load);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.Label lblStatment;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

