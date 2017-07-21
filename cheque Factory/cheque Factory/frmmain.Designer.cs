namespace cheque_Factory
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.analogClock3 = new AnalogClock.AnalogClock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.aboutme = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 741);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // analogClock3
            // 
            this.analogClock3.DrawHourHand = true;
            this.analogClock3.DrawHourHandShadow = true;
            this.analogClock3.DrawMinuteHand = true;
            this.analogClock3.DrawMinuteHandShadow = true;
            this.analogClock3.DrawSecondHand = true;
            this.analogClock3.DropShadowColor = System.Drawing.Color.RosyBrown;
            this.analogClock3.DropShadowOffset = new System.Drawing.Point(0, 0);
            this.analogClock3.FaceColorHigh = System.Drawing.Color.Red;
            this.analogClock3.FaceColorLow = System.Drawing.Color.Crimson;
            this.analogClock3.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.analogClock3.FaceImage = null;
            this.analogClock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.analogClock3.HourHandColor = System.Drawing.Color.Gainsboro;
            this.analogClock3.HourHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock3.Location = new System.Drawing.Point(1178, -2);
            this.analogClock3.MinuteHandColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock3.MinuteHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock3.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
            this.analogClock3.Name = "analogClock3";
            this.analogClock3.NumeralColor = System.Drawing.Color.WhiteSmoke;
            this.analogClock3.RimColorHigh = System.Drawing.Color.RosyBrown;
            this.analogClock3.RimColorLow = System.Drawing.Color.Black;
            this.analogClock3.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.analogClock3.SecondHandColor = System.Drawing.Color.Tomato;
            this.analogClock3.SecondHandDropShadowColor = System.Drawing.Color.Gray;
            this.analogClock3.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.analogClock3.SecondHandTickStyle = AnalogClock.TickStyle.Smooth;
            this.analogClock3.Size = new System.Drawing.Size(192, 192);
            this.analogClock3.TabIndex = 9;
            this.analogClock3.Time = new System.DateTime(((long)(0)));
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1178, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("B Nazanin+ Regular", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1099, 551);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 32);
            this.button5.TabIndex = 11;
            this.button5.Text = "اضافه کردن حساب";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("B Nazanin+ Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1212, 655);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "خروج از برنامه";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // aboutme
            // 
            this.aboutme.BackColor = System.Drawing.Color.Transparent;
            this.aboutme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutme.BackgroundImage")));
            this.aboutme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutme.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutme.FlatAppearance.BorderSize = 0;
            this.aboutme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutme.Font = new System.Drawing.Font("B Nazanin+ Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.aboutme.ForeColor = System.Drawing.Color.Red;
            this.aboutme.Location = new System.Drawing.Point(1212, 556);
            this.aboutme.Name = "aboutme";
            this.aboutme.Size = new System.Drawing.Size(137, 51);
            this.aboutme.TabIndex = 7;
            this.aboutme.Text = "حساب ها";
            this.aboutme.UseVisualStyleBackColor = false;
            this.aboutme.Click += new System.EventHandler(this.aboutme_Click);
            this.aboutme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aboutme_MouseDown);
            this.aboutme.MouseLeave += new System.EventHandler(this.aboutme_MouseLeave);
            this.aboutme.MouseHover += new System.EventHandler(this.aboutme_MouseHover);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("B Nazanin+ Regular", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1212, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "مدیریت الگو ها";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("B Nazanin+ Regular", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1212, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "چاپ چک";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Nazanin+ Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1212, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "ذخیره الگو چک";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("B Nazanin+ Regular", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(1099, 586);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 32);
            this.button6.TabIndex = 12;
            this.button6.Text = "مدیریت حسابها";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analogClock3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.aboutme);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmmain";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button aboutme;
        private System.Windows.Forms.Button button4;
        private AnalogClock.AnalogClock analogClock3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}