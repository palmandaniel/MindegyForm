namespace MindegyForm
{
    partial class Form1
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
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.btnOsszeg = new System.Windows.Forms.Button();
            this.btnAtlag = new System.Windows.Forms.Button();
            this.btnHanyadik = new System.Windows.Forms.Button();
            this.btnHanyszor = new System.Windows.Forms.Button();
            this.btnVane = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.lbEredmeny = new System.Windows.Forms.ListBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBeolvas.Location = new System.Drawing.Point(12, 12);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(100, 25);
            this.btnBeolvas.TabIndex = 0;
            this.btnBeolvas.Text = "Beolvasás";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // btnOsszeg
            // 
            this.btnOsszeg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOsszeg.Location = new System.Drawing.Point(12, 78);
            this.btnOsszeg.Name = "btnOsszeg";
            this.btnOsszeg.Size = new System.Drawing.Size(100, 25);
            this.btnOsszeg.TabIndex = 1;
            this.btnOsszeg.Text = "Összegzés";
            this.btnOsszeg.UseVisualStyleBackColor = true;
            this.btnOsszeg.Click += new System.EventHandler(this.btnOsszeg_Click);
            // 
            // btnAtlag
            // 
            this.btnAtlag.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAtlag.Location = new System.Drawing.Point(12, 109);
            this.btnAtlag.Name = "btnAtlag";
            this.btnAtlag.Size = new System.Drawing.Size(100, 25);
            this.btnAtlag.TabIndex = 2;
            this.btnAtlag.Text = "Átlagszámítás";
            this.btnAtlag.UseVisualStyleBackColor = true;
            this.btnAtlag.Click += new System.EventHandler(this.btnAtlag_Click);
            // 
            // btnHanyadik
            // 
            this.btnHanyadik.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHanyadik.Location = new System.Drawing.Point(12, 140);
            this.btnHanyadik.Name = "btnHanyadik";
            this.btnHanyadik.Size = new System.Drawing.Size(100, 25);
            this.btnHanyadik.TabIndex = 3;
            this.btnHanyadik.Text = "7143 helye";
            this.btnHanyadik.UseVisualStyleBackColor = true;
            this.btnHanyadik.Click += new System.EventHandler(this.btnHanyadik_Click);
            // 
            // btnHanyszor
            // 
            this.btnHanyszor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHanyszor.Location = new System.Drawing.Point(12, 171);
            this.btnHanyszor.Name = "btnHanyszor";
            this.btnHanyszor.Size = new System.Drawing.Size(100, 25);
            this.btnHanyszor.TabIndex = 4;
            this.btnHanyszor.Text = "1170 hányszor";
            this.btnHanyszor.UseVisualStyleBackColor = true;
            this.btnHanyszor.Click += new System.EventHandler(this.btnHanyszor_Click);
            // 
            // btnVane
            // 
            this.btnVane.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVane.Location = new System.Drawing.Point(12, 202);
            this.btnVane.Name = "btnVane";
            this.btnVane.Size = new System.Drawing.Size(100, 25);
            this.btnVane.TabIndex = 5;
            this.btnVane.Text = "8876 van-e";
            this.btnVane.UseVisualStyleBackColor = true;
            this.btnVane.Click += new System.EventHandler(this.btnVane_Click);
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMin.Location = new System.Drawing.Point(12, 233);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(100, 25);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Minimum";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMax.Location = new System.Drawing.Point(12, 264);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(100, 25);
            this.btnMax.TabIndex = 7;
            this.btnMax.Text = "Maximum";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnKilep.Location = new System.Drawing.Point(328, 295);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(100, 25);
            this.btnKilep.TabIndex = 8;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // lbEredmeny
            // 
            this.lbEredmeny.FormattingEnabled = true;
            this.lbEredmeny.Location = new System.Drawing.Point(118, 77);
            this.lbEredmeny.Name = "lbEredmeny";
            this.lbEredmeny.Size = new System.Drawing.Size(310, 212);
            this.lbEredmeny.TabIndex = 9;
            // 
            // btnTorles
            // 
            this.btnTorles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnTorles.Location = new System.Drawing.Point(222, 295);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(100, 25);
            this.btnTorles.TabIndex = 10;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 322);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.lbEredmeny);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnVane);
            this.Controls.Add(this.btnHanyszor);
            this.Controls.Add(this.btnHanyadik);
            this.Controls.Add(this.btnAtlag);
            this.Controls.Add(this.btnOsszeg);
            this.Controls.Add(this.btnBeolvas);
            this.Name = "Form1";
            this.Text = "Palman Dániel Formos Applikációja mely a MindegyForm projekthez tartozik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnOsszeg;
        private System.Windows.Forms.Button btnAtlag;
        private System.Windows.Forms.Button btnHanyadik;
        private System.Windows.Forms.Button btnHanyszor;
        private System.Windows.Forms.Button btnVane;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.ListBox lbEredmeny;
        private System.Windows.Forms.Button btnTorles;
    }
}

