namespace Arkanoid
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.btnRacket = new System.Windows.Forms.Button();
            this.lbTop = new System.Windows.Forms.Label();
            this.lbLeft = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.rball = new System.Windows.Forms.RadioButton();
            this.brick1 = new System.Windows.Forms.Label();
            this.brick2 = new System.Windows.Forms.Label();
            this.brick3 = new System.Windows.Forms.Label();
            this.brick4 = new System.Windows.Forms.Label();
            this.brick5 = new System.Windows.Forms.Label();
            this.brick6 = new System.Windows.Forms.Label();
            this.brick7 = new System.Windows.Forms.Label();
            this.brick8 = new System.Windows.Forms.Label();
            this.brick9 = new System.Windows.Forms.Label();
            this.brick10 = new System.Windows.Forms.Label();
            this.brick11 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbCount = new System.Windows.Forms.Label();
            this.lbLife = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRacket
            // 
            this.btnRacket.Enabled = false;
            this.btnRacket.Location = new System.Drawing.Point(394, 490);
            this.btnRacket.Name = "btnRacket";
            this.btnRacket.Size = new System.Drawing.Size(87, 23);
            this.btnRacket.TabIndex = 0;
            this.btnRacket.UseVisualStyleBackColor = true;
            // 
            // lbTop
            // 
            this.lbTop.BackColor = System.Drawing.SystemColors.Control;
            this.lbTop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTop.Location = new System.Drawing.Point(0, 0);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(875, 39);
            this.lbTop.TabIndex = 2;
            // 
            // lbLeft
            // 
            this.lbLeft.BackColor = System.Drawing.SystemColors.Control;
            this.lbLeft.Location = new System.Drawing.Point(0, 9);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(10, 479);
            this.lbLeft.TabIndex = 4;
            // 
            // lbRight
            // 
            this.lbRight.BackColor = System.Drawing.SystemColors.Control;
            this.lbRight.Location = new System.Drawing.Point(878, 29);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(10, 458);
            this.lbRight.TabIndex = 5;
            // 
            // rball
            // 
            this.rball.AutoSize = true;
            this.rball.BackColor = System.Drawing.Color.Transparent;
            this.rball.Checked = true;
            this.rball.Enabled = false;
            this.rball.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rball.Location = new System.Drawing.Point(436, 452);
            this.rball.Name = "rball";
            this.rball.Size = new System.Drawing.Size(14, 13);
            this.rball.TabIndex = 6;
            this.rball.TabStop = true;
            this.rball.UseVisualStyleBackColor = false;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.Maroon;
            this.brick1.Location = new System.Drawing.Point(47, 58);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(100, 23);
            this.brick1.TabIndex = 7;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.Maroon;
            this.brick2.Location = new System.Drawing.Point(47, 132);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(100, 23);
            this.brick2.TabIndex = 8;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.Maroon;
            this.brick3.Location = new System.Drawing.Point(156, 95);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(100, 23);
            this.brick3.TabIndex = 9;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.Maroon;
            this.brick4.Location = new System.Drawing.Point(261, 58);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(100, 23);
            this.brick4.TabIndex = 10;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.Maroon;
            this.brick5.Location = new System.Drawing.Point(261, 132);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(100, 23);
            this.brick5.TabIndex = 11;
            // 
            // brick6
            // 
            this.brick6.BackColor = System.Drawing.Color.Maroon;
            this.brick6.Location = new System.Drawing.Point(374, 95);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(100, 23);
            this.brick6.TabIndex = 12;
            // 
            // brick7
            // 
            this.brick7.BackColor = System.Drawing.Color.Maroon;
            this.brick7.Location = new System.Drawing.Point(489, 58);
            this.brick7.Name = "brick7";
            this.brick7.Size = new System.Drawing.Size(100, 23);
            this.brick7.TabIndex = 13;
            // 
            // brick8
            // 
            this.brick8.BackColor = System.Drawing.Color.Maroon;
            this.brick8.Location = new System.Drawing.Point(489, 132);
            this.brick8.Name = "brick8";
            this.brick8.Size = new System.Drawing.Size(100, 23);
            this.brick8.TabIndex = 14;
            // 
            // brick9
            // 
            this.brick9.BackColor = System.Drawing.Color.Maroon;
            this.brick9.Location = new System.Drawing.Point(611, 95);
            this.brick9.Name = "brick9";
            this.brick9.Size = new System.Drawing.Size(100, 23);
            this.brick9.TabIndex = 15;
            // 
            // brick10
            // 
            this.brick10.BackColor = System.Drawing.Color.Maroon;
            this.brick10.Location = new System.Drawing.Point(728, 58);
            this.brick10.Name = "brick10";
            this.brick10.Size = new System.Drawing.Size(100, 23);
            this.brick10.TabIndex = 16;
            // 
            // brick11
            // 
            this.brick11.BackColor = System.Drawing.Color.Maroon;
            this.brick11.Location = new System.Drawing.Point(728, 132);
            this.brick11.Name = "brick11";
            this.brick11.Size = new System.Drawing.Size(100, 23);
            this.brick11.TabIndex = 17;
            // 
            // labelClose
            // 
            this.labelClose.BackColor = System.Drawing.SystemColors.Control;
            this.labelClose.Image = global::Arkanoid.Properties.Resources.close_window;
            this.labelClose.Location = new System.Drawing.Point(857, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(31, 39);
            this.labelClose.TabIndex = 18;
            this.labelClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(77, 4);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(100, 29);
            this.lbCount.TabIndex = 19;
            this.lbCount.Text = "Count: ";
            // 
            // lbLife
            // 
            this.lbLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLife.Image = ((System.Drawing.Image)(resources.GetObject("lbLife.Image")));
            this.lbLife.Location = new System.Drawing.Point(12, 0);
            this.lbLife.Name = "lbLife";
            this.lbLife.Size = new System.Drawing.Size(37, 39);
            this.lbLife.TabIndex = 20;
            this.lbLife.Text = "3";
            this.lbLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbText.Location = new System.Drawing.Point(129, 247);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(654, 77);
            this.lbText.TabIndex = 21;
            this.lbText.Text = "For start press ENTER";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.level1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 516);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbLife);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.brick11);
            this.Controls.Add(this.brick10);
            this.Controls.Add(this.brick9);
            this.Controls.Add(this.brick8);
            this.Controls.Add(this.brick7);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.rball);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.lbTop);
            this.Controls.Add(this.btnRacket);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTop;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.RadioButton rball;
        private System.Windows.Forms.Label brick2;
        private System.Windows.Forms.Label brick3;
        private System.Windows.Forms.Label brick4;
        private System.Windows.Forms.Label brick5;
        private System.Windows.Forms.Label brick6;
        private System.Windows.Forms.Label brick7;
        private System.Windows.Forms.Label brick8;
        private System.Windows.Forms.Label brick9;
        private System.Windows.Forms.Label brick10;
        private System.Windows.Forms.Label brick11;
        private System.Windows.Forms.Label labelClose;
        public System.Windows.Forms.Button btnRacket;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label brick1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbLife;
        private System.Windows.Forms.Label lbText;
    }
}