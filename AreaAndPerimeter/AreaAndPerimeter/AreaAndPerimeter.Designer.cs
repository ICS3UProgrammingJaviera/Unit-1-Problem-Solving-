namespace AreaAndPerimeter
{
    partial class frmAreaAndPerimeter
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
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculateButton = new System.Windows.Forms.Button();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.lblPerimeterAnswer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Nueva Std Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(160, 149);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(142, 35);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length (cm)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Orator Std", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(159, 243);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(187, 39);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width (cm)";
            this.lblWidth.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("RomanD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(252, 374);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(181, 42);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perimeter:";
            this.lblPerimeter.Click += new System.EventHandler(this.lblPerimeter_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(272, 457);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 29);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(568, 164);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(568, 262);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 6;
            // 
            // btnCalculateButton
            // 
            this.btnCalculateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculateButton.Font = new System.Drawing.Font("Myriad Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateButton.Location = new System.Drawing.Point(754, 197);
            this.btnCalculateButton.Name = "btnCalculateButton";
            this.btnCalculateButton.Size = new System.Drawing.Size(147, 44);
            this.btnCalculateButton.TabIndex = 7;
            this.btnCalculateButton.Text = "Calculate";
            this.btnCalculateButton.UseVisualStyleBackColor = false;
            this.btnCalculateButton.Click += new System.EventHandler(this.btnCalculateButton_Click);
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(399, 462);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(142, 24);
            this.lblAreaAnswer.TabIndex = 8;
            this.lblAreaAnswer.Text = "Area answer";
            // 
            // lblPerimeterAnswer
            // 
            this.lblPerimeterAnswer.AutoSize = true;
            this.lblPerimeterAnswer.Font = new System.Drawing.Font("Myriad Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterAnswer.Location = new System.Drawing.Point(465, 376);
            this.lblPerimeterAnswer.Name = "lblPerimeterAnswer";
            this.lblPerimeterAnswer.Size = new System.Drawing.Size(120, 44);
            this.lblPerimeterAnswer.TabIndex = 9;
            this.lblPerimeterAnswer.Text = "PerAnswer";
            // 
            // frmAreaAndPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 618);
            this.Controls.Add(this.lblPerimeterAnswer);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.btnCalculateButton);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAreaAndPerimeter";
            this.Text = "Area & Perimeter";
            this.Load += new System.EventHandler(this.frmAreaAndPerimeter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculateButton;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.Label lblPerimeterAnswer;
    }
}

