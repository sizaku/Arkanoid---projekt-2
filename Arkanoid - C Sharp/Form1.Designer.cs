namespace Arkanoid___C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paletka = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.timer_pilka = new System.Windows.Forms.Timer(this.components);
            this.timer_b1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.PictureBox();
            this.b9 = new System.Windows.Forms.PictureBox();
            this.b8 = new System.Windows.Forms.PictureBox();
            this.b7 = new System.Windows.Forms.PictureBox();
            this.b6 = new System.Windows.Forms.PictureBox();
            this.b5 = new System.Windows.Forms.PictureBox();
            this.b4 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.b15 = new System.Windows.Forms.PictureBox();
            this.b14 = new System.Windows.Forms.PictureBox();
            this.b13 = new System.Windows.Forms.PictureBox();
            this.b12 = new System.Windows.Forms.PictureBox();
            this.b11 = new System.Windows.Forms.PictureBox();
            this.timer_b2 = new System.Windows.Forms.Timer(this.components);
            this.timer_b3 = new System.Windows.Forms.Timer(this.components);
            this.timer_b4 = new System.Windows.Forms.Timer(this.components);
            this.timer_b5 = new System.Windows.Forms.Timer(this.components);
            this.timer_b6 = new System.Windows.Forms.Timer(this.components);
            this.timer_b7 = new System.Windows.Forms.Timer(this.components);
            this.timer_b8 = new System.Windows.Forms.Timer(this.components);
            this.timer_b9 = new System.Windows.Forms.Timer(this.components);
            this.timer_b10 = new System.Windows.Forms.Timer(this.components);
            this.timer_b11 = new System.Windows.Forms.Timer(this.components);
            this.timer_b12 = new System.Windows.Forms.Timer(this.components);
            this.timer_b13 = new System.Windows.Forms.Timer(this.components);
            this.timer_b14 = new System.Windows.Forms.Timer(this.components);
            this.timer_b15 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pilka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paletka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            this.SuspendLayout();
            // 
            // paletka
            // 
            this.paletka.BackColor = System.Drawing.Color.DodgerBlue;
            this.paletka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.paletka, "paletka");
            this.paletka.Name = "paletka";
            this.paletka.TabStop = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b1, "b1");
            this.b1.Name = "b1";
            this.b1.TabStop = false;
            // 
            // timer_pilka
            // 
            this.timer_pilka.Enabled = true;
            this.timer_pilka.Interval = 10;
            this.timer_pilka.Tick += new System.EventHandler(this.timer_pilka_Tick);
            // 
            // timer_b1
            // 
            this.timer_b1.Enabled = true;
            this.timer_b1.Interval = 90;
            this.timer_b1.Tick += new System.EventHandler(this.timer_b1_Tick);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b10
            // 
            this.b10.BackColor = System.Drawing.Color.White;
            this.b10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b10, "b10");
            this.b10.Name = "b10";
            this.b10.TabStop = false;
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.White;
            this.b9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b9, "b9");
            this.b9.Name = "b9";
            this.b9.TabStop = false;
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.White;
            this.b8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b8, "b8");
            this.b8.Name = "b8";
            this.b8.TabStop = false;
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.White;
            this.b7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b7, "b7");
            this.b7.Name = "b7";
            this.b7.TabStop = false;
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.White;
            this.b6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b6, "b6");
            this.b6.Name = "b6";
            this.b6.TabStop = false;
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b5, "b5");
            this.b5.Name = "b5";
            this.b5.TabStop = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b4, "b4");
            this.b4.Name = "b4";
            this.b4.TabStop = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b3, "b3");
            this.b3.Name = "b3";
            this.b3.TabStop = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b2, "b2");
            this.b2.Name = "b2";
            this.b2.TabStop = false;
            // 
            // b15
            // 
            this.b15.BackColor = System.Drawing.Color.White;
            this.b15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b15, "b15");
            this.b15.Name = "b15";
            this.b15.TabStop = false;
            // 
            // b14
            // 
            this.b14.BackColor = System.Drawing.Color.White;
            this.b14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b14, "b14");
            this.b14.Name = "b14";
            this.b14.TabStop = false;
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.White;
            this.b13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b13, "b13");
            this.b13.Name = "b13";
            this.b13.TabStop = false;
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.White;
            this.b12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b12, "b12");
            this.b12.Name = "b12";
            this.b12.TabStop = false;
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.White;
            this.b11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.b11, "b11");
            this.b11.Name = "b11";
            this.b11.TabStop = false;
            // 
            // timer_b2
            // 
            this.timer_b2.Enabled = true;
            this.timer_b2.Interval = 90;
            this.timer_b2.Tick += new System.EventHandler(this.timer_b2_Tick);
            // 
            // timer_b3
            // 
            this.timer_b3.Enabled = true;
            this.timer_b3.Interval = 90;
            this.timer_b3.Tick += new System.EventHandler(this.timer_b3_Tick);
            // 
            // timer_b4
            // 
            this.timer_b4.Enabled = true;
            this.timer_b4.Interval = 90;
            this.timer_b4.Tick += new System.EventHandler(this.timer_b4_Tick);
            // 
            // timer_b5
            // 
            this.timer_b5.Enabled = true;
            this.timer_b5.Interval = 90;
            this.timer_b5.Tick += new System.EventHandler(this.timer_b5_Tick);
            // 
            // timer_b6
            // 
            this.timer_b6.Enabled = true;
            this.timer_b6.Interval = 90;
            this.timer_b6.Tick += new System.EventHandler(this.timer_b6_Tick);
            // 
            // timer_b7
            // 
            this.timer_b7.Enabled = true;
            this.timer_b7.Interval = 90;
            this.timer_b7.Tick += new System.EventHandler(this.timer_b7_Tick);
            // 
            // timer_b8
            // 
            this.timer_b8.Enabled = true;
            this.timer_b8.Interval = 90;
            this.timer_b8.Tick += new System.EventHandler(this.timer_b8_Tick);
            // 
            // timer_b9
            // 
            this.timer_b9.Enabled = true;
            this.timer_b9.Interval = 90;
            this.timer_b9.Tick += new System.EventHandler(this.timer_b9_Tick);
            // 
            // timer_b10
            // 
            this.timer_b10.Enabled = true;
            this.timer_b10.Interval = 90;
            this.timer_b10.Tick += new System.EventHandler(this.timer_b10_Tick);
            // 
            // timer_b11
            // 
            this.timer_b11.Enabled = true;
            this.timer_b11.Interval = 90;
            this.timer_b11.Tick += new System.EventHandler(this.timer_b11_Tick);
            // 
            // timer_b12
            // 
            this.timer_b12.Enabled = true;
            this.timer_b12.Interval = 90;
            this.timer_b12.Tick += new System.EventHandler(this.timer_b12_Tick);
            // 
            // timer_b13
            // 
            this.timer_b13.Enabled = true;
            this.timer_b13.Interval = 90;
            this.timer_b13.Tick += new System.EventHandler(this.timer_b13_Tick);
            // 
            // timer_b14
            // 
            this.timer_b14.Enabled = true;
            this.timer_b14.Interval = 90;
            this.timer_b14.Tick += new System.EventHandler(this.timer_b14_Tick);
            // 
            // timer_b15
            // 
            this.timer_b15.Enabled = true;
            this.timer_b15.Interval = 90;
            this.timer_b15.Tick += new System.EventHandler(this.timer_b15_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Name = "label2";
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pilka, "pilka");
            this.pilka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pilka.Name = "pilka";
            this.pilka.TabStop = false;
            this.pilka.Click += new System.EventHandler(this.pilka_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b14);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.paletka);
            this.Controls.Add(this.pilka);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.paletka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox paletka;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.Timer timer_pilka;
        private System.Windows.Forms.Timer timer_b1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox b10;
        private System.Windows.Forms.PictureBox b9;
        private System.Windows.Forms.PictureBox b8;
        private System.Windows.Forms.PictureBox b7;
        private System.Windows.Forms.PictureBox b6;
        private System.Windows.Forms.PictureBox b5;
        private System.Windows.Forms.PictureBox b4;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox b15;
        private System.Windows.Forms.PictureBox b14;
        private System.Windows.Forms.PictureBox b13;
        private System.Windows.Forms.PictureBox b12;
        private System.Windows.Forms.PictureBox b11;
        private System.Windows.Forms.Timer timer_b2;
        private System.Windows.Forms.Timer timer_b3;
        private System.Windows.Forms.Timer timer_b4;
        private System.Windows.Forms.Timer timer_b5;
        private System.Windows.Forms.Timer timer_b6;
        private System.Windows.Forms.Timer timer_b7;
        private System.Windows.Forms.Timer timer_b8;
        private System.Windows.Forms.Timer timer_b9;
        private System.Windows.Forms.Timer timer_b10;
        private System.Windows.Forms.Timer timer_b11;
        private System.Windows.Forms.Timer timer_b12;
        private System.Windows.Forms.Timer timer_b13;
        private System.Windows.Forms.Timer timer_b14;
        private System.Windows.Forms.Timer timer_b15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pilka;
    }
}

