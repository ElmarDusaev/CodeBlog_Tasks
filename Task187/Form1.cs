using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task187
{
    public partial class Form1 : Form
    {
        Color bgcolor;
        Shape shape;
        Thread thread;

        public Form1()
        {
            InitializeComponent();
            bgcolor = Color.Red;
            pictureBox1.BackColor = bgcolor;
            InitShape(ShapeType.Circle);
            trackX.Maximum = this.Width;
            trackY.Maximum = this.Height;
        }




        private void btn_start_Click(object sender, EventArgs e)
        {
            if (thread != null && thread.IsAlive) { btn_start.Text = "СТАРТ"; thread.Abort(); return; } else
            btn_start.Text = "СТОП";
            thread = new Thread(()=> {

                int val = 0;
                bool flagGrow = true;
                while (true)
                {
                    Thread.Sleep(trackSpeed.Value);



                    this.Invalidate(shape.Rectangle);
                    this.Update();

                    
                    shape.Width = val;
                    shape.Height = val;
                    shape.PosX = trackX.Value;
                    shape.PosY = trackY.Value;


                    shape.Draw();

                    if (flagGrow)
                    {
                        if (val >= trackSize.Value) flagGrow = false;
                        val++;
                    }
                    else
                    {
                        if (val <= 0) flagGrow = true;
                        val--;
                    }
                }

            });
            thread.Start();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bgcolor = dialog.Color;
                shape.BackColor = bgcolor;
                pictureBox1.BackColor = dialog.Color;
            }
        }



        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            shape.Height = trackSize.Value;
            shape.Width = trackSize.Value;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null && thread.IsAlive)  thread.Abort();

        }

        private void rb_circle_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_circle.Checked) InitShape(ShapeType.Circle);
            else InitShape(ShapeType.Rectangle);
        }

        void InitShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    shape = new Rectangle(trackX.Value, trackY.Value, trackSize.Value, trackSize.Value, bgcolor, CreateGraphics());
                    break;
                case ShapeType.Circle:
                    shape = new Circle(trackX.Value, trackY.Value, trackSize.Value, trackSize.Value, bgcolor, CreateGraphics());
                    break;
                default:
                    break;
            }
        }


    }

}
