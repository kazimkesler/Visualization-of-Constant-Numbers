using drawConstants.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace drawConstants
{
    public partial class drawConstants : Form
    {
        string pinumber;
        string enumber;
        string phinumber;
        string sqrt2number;
        string sqrt3number;
        string sqrt5number;

        Label selected_label;
        public drawConstants()
        {
            pinumber = Resources.pinumber;
            enumber = Resources.enumber;
            phinumber = Resources.phinumber;
            sqrt2number = Resources.sqrt2number;
            sqrt3number = Resources.sqrt3number;
            sqrt5number = Resources.sqrt5number;
            InitializeComponent();
        }

        public void Draw()
        {
            PointF pt_last, pt, temp;
            string num;
            int linesize;
            Bitmap bmp = new Bitmap(20480, 20480, PixelFormat.Format32bppRgb);
            Graphics grp = Graphics.FromImage(bmp);
            grp.SmoothingMode = SmoothingMode.AntiAlias;
            grp.Clear(colorDialog_backcolor.Color);
            Pen pen = new Pen(colorDialog_forecolor.Color, (float)updown_pensize.Value);

            if (selected_label == label_pi)
            { num = pinumber; linesize = 18; pt_last = pt = new PointF(bmp.Width / 2 + 7750, bmp.Height / 2 - 4000); saveDialog.FileName = "pi"; }
            else if (selected_label == label_e)
            { num = enumber; linesize = 10; pt_last = pt = new PointF(bmp.Width / 2 + 9000, bmp.Height / 2 - 4000); saveDialog.FileName = "e"; }
            else if (selected_label == label_phi)
            { num = phinumber; linesize = 14; pt_last = pt = new PointF(bmp.Width / 2 + 4000, bmp.Height / 2 + 7500); saveDialog.FileName = "phi"; }
            else if (selected_label == label_sqrt2)
            { num = sqrt2number; linesize = 16; pt_last = pt = new PointF(bmp.Width / 2 + 9000, bmp.Height / 2 + 2500); saveDialog.FileName = "sqrt2"; }
            else if (selected_label == label_sqrt3)
            { num = sqrt3number; linesize = 13; pt_last = pt = new PointF(bmp.Width / 2 + 7000, bmp.Height / 2 + 9000); saveDialog.FileName = "sqrt3"; }
            else if (selected_label == label_sqrt5)
            { num = sqrt5number; linesize = 20; pt_last = pt = new PointF(bmp.Width / 2 + 2000, bmp.Height / 2 - 6000); saveDialog.FileName = "sqrt5"; }
            else
            { MessageBox.Show("Select a constant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            for (int i = 0, angle = 0; i < num.Length; i++)
            {
                angle = int.Parse(num[i].ToString()) * 36;
                temp = Trigonometry.UnitPoint(Trigonometry.DegreeToRadian(angle));
                pt.X += linesize * temp.X;
                pt.Y += linesize * temp.Y;
                grp.DrawLine(pen, pt_last, pt);
                pt_last = pt;
                progressBar.Value = i / 10000 + 1;
            }

            saveDialog.ShowDialog();
            bmp.Save(saveDialog.FileName);
            bmp.Dispose();
            GC.Collect();
            progressBar.Value = 0;
        }
        private void label_pi_Click(object sender, EventArgs e)
        {
            if (!(selected_label is null))
                selected_label.BorderStyle = BorderStyle.None;
            label_pi.BorderStyle = BorderStyle.FixedSingle;
            selected_label = label_pi;
        }

        private void label_e_Click(object sender, EventArgs e)
        {
            if (!(selected_label is null))
                selected_label.BorderStyle = BorderStyle.None;
            label_e.BorderStyle = BorderStyle.FixedSingle;
            selected_label = label_e;
        }

        private void label_phi_Click(object sender, EventArgs e)
        {
            if (!(selected_label is null))
                selected_label.BorderStyle = BorderStyle.None;
            label_phi.BorderStyle = BorderStyle.FixedSingle;
            selected_label = label_phi;
        }

        private void label_sqrt2_Click(object sender, EventArgs e)
        {
            if (!(selected_label is null))
                selected_label.BorderStyle = BorderStyle.None;
            label_sqrt2.BorderStyle = BorderStyle.FixedSingle;
            selected_label = label_sqrt2;
        }

        private void label_sqrt3_Click(object sender, EventArgs e)
        {
            if (!(selected_label is null))
                selected_label.BorderStyle = BorderStyle.None;
            label_sqrt3.BorderStyle = BorderStyle.FixedSingle;
            selected_label = label_sqrt3;
        }

        private void label_sqrt5_Click(object sender, EventArgs e)
        {
            if (!(selected_label is null))
                selected_label.BorderStyle = BorderStyle.None;
            label_sqrt5.BorderStyle = BorderStyle.FixedSingle;
            selected_label = label_sqrt5;
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void label_backcolor_Click(object sender, EventArgs e)
        {
            colorDialog_backcolor.ShowDialog();
        }

        private void label_forecolor_Click(object sender, EventArgs e)
        {
            colorDialog_forecolor.ShowDialog();
        }

        private void drawConstants_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This Program uses a lot of ram memory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
