namespace drawConstants
{
    partial class drawConstants
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drawConstants));
            this.label_desc = new System.Windows.Forms.Label();
            this.label_pi = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.label_phi = new System.Windows.Forms.Label();
            this.label_sqrt2 = new System.Windows.Forms.Label();
            this.label_sqrt3 = new System.Windows.Forms.Label();
            this.label_sqrt5 = new System.Windows.Forms.Label();
            this.button_draw = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_linesize = new System.Windows.Forms.Label();
            this.updown_pensize = new System.Windows.Forms.NumericUpDown();
            this.colorDialog_backcolor = new System.Windows.Forms.ColorDialog();
            this.label_backcolor = new System.Windows.Forms.Label();
            this.label_forecolor = new System.Windows.Forms.Label();
            this.colorDialog_forecolor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.updown_pensize)).BeginInit();
            this.SuspendLayout();
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Italic);
            this.label_desc.Location = new System.Drawing.Point(17, 12);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(424, 26);
            this.label_desc.TabIndex = 0;
            this.label_desc.Text = "Select a constant that you want to picturize:";
            // 
            // label_pi
            // 
            this.label_pi.BackColor = System.Drawing.Color.Transparent;
            this.label_pi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_pi.Font = new System.Drawing.Font("Cambria", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_pi.Location = new System.Drawing.Point(17, 47);
            this.label_pi.Name = "label_pi";
            this.label_pi.Size = new System.Drawing.Size(150, 125);
            this.label_pi.TabIndex = 1;
            this.label_pi.Text = "π";
            this.label_pi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pi.Click += new System.EventHandler(this.label_pi_Click);
            // 
            // label_e
            // 
            this.label_e.BackColor = System.Drawing.Color.Transparent;
            this.label_e.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_e.Font = new System.Drawing.Font("Cambria", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_e.Location = new System.Drawing.Point(173, 47);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(150, 125);
            this.label_e.TabIndex = 2;
            this.label_e.Text = "e";
            this.label_e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_e.Click += new System.EventHandler(this.label_e_Click);
            // 
            // label_phi
            // 
            this.label_phi.BackColor = System.Drawing.Color.Transparent;
            this.label_phi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_phi.Font = new System.Drawing.Font("Cambria", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_phi.Location = new System.Drawing.Point(329, 47);
            this.label_phi.Name = "label_phi";
            this.label_phi.Size = new System.Drawing.Size(150, 125);
            this.label_phi.TabIndex = 3;
            this.label_phi.Text = "φ";
            this.label_phi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_phi.Click += new System.EventHandler(this.label_phi_Click);
            // 
            // label_sqrt2
            // 
            this.label_sqrt2.BackColor = System.Drawing.Color.Transparent;
            this.label_sqrt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sqrt2.Font = new System.Drawing.Font("Cambria", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sqrt2.Location = new System.Drawing.Point(17, 172);
            this.label_sqrt2.Name = "label_sqrt2";
            this.label_sqrt2.Size = new System.Drawing.Size(150, 125);
            this.label_sqrt2.TabIndex = 4;
            this.label_sqrt2.Text = "√2";
            this.label_sqrt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_sqrt2.Click += new System.EventHandler(this.label_sqrt2_Click);
            // 
            // label_sqrt3
            // 
            this.label_sqrt3.BackColor = System.Drawing.Color.Transparent;
            this.label_sqrt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sqrt3.Font = new System.Drawing.Font("Cambria", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sqrt3.Location = new System.Drawing.Point(173, 172);
            this.label_sqrt3.Name = "label_sqrt3";
            this.label_sqrt3.Size = new System.Drawing.Size(150, 125);
            this.label_sqrt3.TabIndex = 5;
            this.label_sqrt3.Text = "√3";
            this.label_sqrt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_sqrt3.Click += new System.EventHandler(this.label_sqrt3_Click);
            // 
            // label_sqrt5
            // 
            this.label_sqrt5.BackColor = System.Drawing.Color.Transparent;
            this.label_sqrt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sqrt5.Font = new System.Drawing.Font("Cambria", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sqrt5.Location = new System.Drawing.Point(329, 172);
            this.label_sqrt5.Name = "label_sqrt5";
            this.label_sqrt5.Size = new System.Drawing.Size(150, 125);
            this.label_sqrt5.TabIndex = 6;
            this.label_sqrt5.Text = "√5";
            this.label_sqrt5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_sqrt5.Click += new System.EventHandler(this.label_sqrt5_Click);
            // 
            // button_draw
            // 
            this.button_draw.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_draw.Location = new System.Drawing.Point(379, 315);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(100, 30);
            this.button_draw.TabIndex = 7;
            this.button_draw.Text = "Draw";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "png";
            this.saveDialog.Filter = "PNG Files | *.png";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 363);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 16);
            this.progressBar.TabIndex = 8;
            // 
            // label_linesize
            // 
            this.label_linesize.AutoSize = true;
            this.label_linesize.Font = new System.Drawing.Font("Cambria", 12F);
            this.label_linesize.Location = new System.Drawing.Point(18, 322);
            this.label_linesize.Name = "label_linesize";
            this.label_linesize.Size = new System.Drawing.Size(74, 19);
            this.label_linesize.TabIndex = 9;
            this.label_linesize.Text = "Line Size:";
            // 
            // updown_pensize
            // 
            this.updown_pensize.Font = new System.Drawing.Font("Cambria", 12F);
            this.updown_pensize.Location = new System.Drawing.Point(98, 320);
            this.updown_pensize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.updown_pensize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_pensize.Name = "updown_pensize";
            this.updown_pensize.Size = new System.Drawing.Size(45, 26);
            this.updown_pensize.TabIndex = 10;
            this.updown_pensize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_backcolor
            // 
            this.label_backcolor.AutoSize = true;
            this.label_backcolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_backcolor.Font = new System.Drawing.Font("Cambria", 12F);
            this.label_backcolor.Location = new System.Drawing.Point(161, 322);
            this.label_backcolor.Name = "label_backcolor";
            this.label_backcolor.Size = new System.Drawing.Size(91, 19);
            this.label_backcolor.TabIndex = 11;
            this.label_backcolor.Text = "Back Color...";
            this.label_backcolor.Click += new System.EventHandler(this.label_backcolor_Click);
            // 
            // label_forecolor
            // 
            this.label_forecolor.AutoSize = true;
            this.label_forecolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forecolor.Font = new System.Drawing.Font("Cambria", 12F);
            this.label_forecolor.Location = new System.Drawing.Point(263, 322);
            this.label_forecolor.Name = "label_forecolor";
            this.label_forecolor.Size = new System.Drawing.Size(90, 19);
            this.label_forecolor.TabIndex = 12;
            this.label_forecolor.Text = "Fore Color...";
            this.label_forecolor.Click += new System.EventHandler(this.label_forecolor_Click);
            // 
            // colorDialog_forecolor
            // 
            this.colorDialog_forecolor.Color = System.Drawing.Color.White;
            // 
            // drawConstants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 372);
            this.Controls.Add(this.label_forecolor);
            this.Controls.Add(this.label_backcolor);
            this.Controls.Add(this.updown_pensize);
            this.Controls.Add(this.label_linesize);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.label_sqrt5);
            this.Controls.Add(this.label_sqrt3);
            this.Controls.Add(this.label_sqrt2);
            this.Controls.Add(this.label_phi);
            this.Controls.Add(this.label_e);
            this.Controls.Add(this.label_pi);
            this.Controls.Add(this.label_desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "drawConstants";
            this.Text = "Draw Mathematical Constants";
            this.Load += new System.EventHandler(this.drawConstants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updown_pensize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_pi;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.Label label_phi;
        private System.Windows.Forms.Label label_sqrt2;
        private System.Windows.Forms.Label label_sqrt3;
        private System.Windows.Forms.Label label_sqrt5;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_linesize;
        private System.Windows.Forms.NumericUpDown updown_pensize;
        private System.Windows.Forms.ColorDialog colorDialog_backcolor;
        private System.Windows.Forms.Label label_backcolor;
        private System.Windows.Forms.Label label_forecolor;
        private System.Windows.Forms.ColorDialog colorDialog_forecolor;
    }
}

