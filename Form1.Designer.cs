namespace Teyyare
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLeft = new Panel();
            pbLight = new PictureBox();
            pbPlane = new PictureBox();
            btnEnis = new Button();
            btnTurbulans = new Button();
            btnKemerler = new Button();
            btnTesekkurler = new Button();
            btnBeep = new Button();
            btnGas = new Button();
            btnBreak = new Button();
            btnOnOff = new Button();
            timerPlane = new System.Windows.Forms.Timer(components);
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPlane).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.DimGray;
            panelLeft.Controls.Add(pbLight);
            panelLeft.Controls.Add(pbPlane);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 625);
            panelLeft.TabIndex = 0;
            // 
            // pbLight
            // 
            pbLight.BackColor = Color.Transparent;
            pbLight.Image = (Image)resources.GetObject("pbLight.Image");
            pbLight.Location = new Point(135, 288);
            pbLight.Margin = new Padding(3, 4, 3, 4);
            pbLight.Name = "pbLight";
            pbLight.Size = new Size(30, 38);
            pbLight.SizeMode = PictureBoxSizeMode.Zoom;
            pbLight.TabIndex = 1;
            pbLight.TabStop = false;
            pbLight.Visible = false;
            // 
            // pbPlane
            // 
            pbPlane.BackColor = Color.Transparent;
            pbPlane.Image = (Image)resources.GetObject("pbPlane.Image");
            pbPlane.Location = new Point(75, 312);
            pbPlane.Margin = new Padding(3, 4, 3, 4);
            pbPlane.Name = "pbPlane";
            pbPlane.Size = new Size(150, 250);
            pbPlane.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlane.TabIndex = 0;
            pbPlane.TabStop = false;
            // 
            // btnEnis
            // 
            btnEnis.BackColor = Color.DarkOrange;
            btnEnis.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnEnis.Location = new Point(320, 19);
            btnEnis.Margin = new Padding(3, 4, 3, 4);
            btnEnis.Name = "btnEnis";
            btnEnis.Size = new Size(340, 56);
            btnEnis.TabIndex = 1;
            btnEnis.Text = "Eniş hazırlığı";
            btnEnis.UseVisualStyleBackColor = false;
            btnEnis.Click += btnEnis_Click;
            // 
            // btnTurbulans
            // 
            btnTurbulans.BackColor = Color.DarkOrange;
            btnTurbulans.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnTurbulans.Location = new Point(320, 88);
            btnTurbulans.Margin = new Padding(3, 4, 3, 4);
            btnTurbulans.Name = "btnTurbulans";
            btnTurbulans.Size = new Size(340, 56);
            btnTurbulans.TabIndex = 2;
            btnTurbulans.Text = "Turbulans";
            btnTurbulans.UseVisualStyleBackColor = false;
            btnTurbulans.Click += btnTurbulans_Click;
            // 
            // btnKemerler
            // 
            btnKemerler.BackColor = Color.DarkOrange;
            btnKemerler.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnKemerler.Location = new Point(320, 156);
            btnKemerler.Margin = new Padding(3, 4, 3, 4);
            btnKemerler.Name = "btnKemerler";
            btnKemerler.Size = new Size(340, 56);
            btnKemerler.TabIndex = 3;
            btnKemerler.Text = "Kəmərlər";
            btnKemerler.UseVisualStyleBackColor = false;
            btnKemerler.Click += btnKemerler_Click;
            // 
            // btnTesekkurler
            // 
            btnTesekkurler.BackColor = Color.DarkOrange;
            btnTesekkurler.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnTesekkurler.Location = new Point(320, 225);
            btnTesekkurler.Margin = new Padding(3, 4, 3, 4);
            btnTesekkurler.Name = "btnTesekkurler";
            btnTesekkurler.Size = new Size(340, 56);
            btnTesekkurler.TabIndex = 4;
            btnTesekkurler.Text = "Təşəkkürlər";
            btnTesekkurler.UseVisualStyleBackColor = false;
            btnTesekkurler.Click += btnTesekkurler_Click;
            // 
            // btnBeep
            // 
            btnBeep.BackColor = Color.DarkOrange;
            btnBeep.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnBeep.Location = new Point(320, 294);
            btnBeep.Margin = new Padding(3, 4, 3, 4);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new Size(340, 56);
            btnBeep.TabIndex = 5;
            btnBeep.Text = "Beep";
            btnBeep.UseVisualStyleBackColor = false;
            btnBeep.Click += btnBeep_Click;
            // 
            // btnGas
            // 
            btnGas.BackColor = Color.Green;
            btnGas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnGas.ForeColor = Color.White;
            btnGas.Location = new Point(330, 400);
            btnGas.Margin = new Padding(3, 4, 3, 4);
            btnGas.Name = "btnGas";
            btnGas.Size = new Size(150, 75);
            btnGas.TabIndex = 6;
            btnGas.Text = "GAS";
            btnGas.UseVisualStyleBackColor = false;
            btnGas.Click += btnGas_Click;
            // 
            // btnBreak
            // 
            btnBreak.BackColor = Color.DarkRed;
            btnBreak.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnBreak.ForeColor = Color.White;
            btnBreak.Location = new Point(500, 400);
            btnBreak.Margin = new Padding(3, 4, 3, 4);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(150, 75);
            btnBreak.TabIndex = 7;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = false;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnOnOff
            // 
            btnOnOff.BackColor = Color.MediumBlue;
            btnOnOff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnOnOff.ForeColor = Color.White;
            btnOnOff.Location = new Point(310, 512);
            btnOnOff.Margin = new Padding(3, 4, 3, 4);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(360, 62);
            btnOnOff.TabIndex = 8;
            btnOnOff.Text = "ON/OFF";
            btnOnOff.UseVisualStyleBackColor = false;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // timerPlane
            // 
            timerPlane.Interval = 50;
            timerPlane.Tick += timerPlane_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 600);
            Controls.Add(btnOnOff);
            Controls.Add(btnBreak);
            Controls.Add(btnGas);
            Controls.Add(btnBeep);
            Controls.Add(btnTesekkurler);
            Controls.Add(btnKemerler);
            Controls.Add(btnTurbulans);
            Controls.Add(btnEnis);
            Controls.Add(panelLeft);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plane";
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPlane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbPlane;
        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Button btnEnis;
        private System.Windows.Forms.Button btnTurbulans;
        private System.Windows.Forms.Button btnKemerler;
        private System.Windows.Forms.Button btnTesekkurler;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Timer timerPlane;
    }
}