using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ФРОГГЕР
{
    public partial class Form1 : Form
    {
        private balvan balv1;
        private balvan balv2;
        private balvan balv3;
        private balvan balv4;
        private balvan balv5;
        private balvan balv6;
        private balvan balv7;
        private balvan balv8;
        private balvan balv9;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            balv1 = new balvan(0, 0, panel1.Width, panel1.Height, Color.Brown, Color.Black);
            balv2 = new balvan(0, 0, panel2.Width, panel2.Height, Color.Brown, Color.Black);
            balv3 = new balvan(0, 0, panel3.Width, panel3.Height, Color.Brown, Color.Black);
            balv4 = new balvan(0, 0, panel4.Width, panel4.Height, Color.Brown, Color.Black);
            balv5 = new balvan(0, 0, panel5.Width, panel5.Height, Color.Brown, Color.Black);
            balv6 = new balvan(0, 0, panel6.Width, panel6.Height, Color.Brown, Color.Black);
            balv7 = new balvan(0, 0, panel7.Width, panel7.Height, Color.Brown, Color.Black);
            balv8 = new balvan(0, 0, panel8.Width, panel8.Height, Color.Brown, Color.Black);
            balv9 = new balvan(0, 0, panel9.Width, panel9.Height, Color.Brown, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            balv1.NacrtajSe(e.Graphics);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            balv2.NacrtajSe(e.Graphics);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            balv3.NacrtajSe(e.Graphics);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            balv4.NacrtajSe(e.Graphics);
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            balv5.NacrtajSe(e.Graphics);
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            balv6.NacrtajSe(e.Graphics);
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            balv7.NacrtajSe(e.Graphics);
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            balv8.NacrtajSe(e.Graphics);
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            balv9.NacrtajSe(e.Graphics);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //балвани
            Sudaranje();

            panel1.Left = panel1.Left - 2;
            if(panel1.Left <= -panel1.Width)
            {
                panel1.Left = ClientRectangle.Width;
            }
            panel2.Left = panel2.Left + 5;
            if (panel2.Left >= ClientRectangle.Width)
            {
                panel2.Left = -panel2.Width;
            }
            panel3.Left = panel3.Left - 2;
            if (panel3.Left <= -panel3.Width)
            {
                panel3.Left = ClientRectangle.Width;
            }

            panel4.Left = panel4.Left - 2;
            if (panel4.Left <= -panel4.Width)
            {
                panel4.Left = ClientRectangle.Width;
            }
            panel5.Left = panel5.Left + 5;
            if (panel5.Left >= ClientRectangle.Width)
            {
                panel5.Left = -panel5.Width;
            }
            panel6.Left = panel6.Left - 2;
            if (panel6.Left <= -panel6.Width)
            {
                panel6.Left = ClientRectangle.Width;
            }

            panel7.Left = panel7.Left - 2;
            if (panel7.Left <= -panel7.Width)
            {
                panel7.Left = ClientRectangle.Width;
            }
            panel8.Left = panel8.Left + 5;
            if (panel8.Left >= ClientRectangle.Width)
            {
                panel8.Left = -panel8.Width;
            }
            panel9.Left = panel9.Left - 2;
            if (panel9.Left <= -panel9.Width)
            {
                panel9.Left = ClientRectangle.Width;
            }

            //кола

            car1.Left = car1.Left - 2;
            if (car1.Left <= -car1.Width)
            {
                car1.Left = ClientRectangle.Width;
            }

            car2.Left = car2.Left - 2;
            if (car2.Left <= -car2.Width)
            {
                car2.Left = ClientRectangle.Width;
            }

            car3.Left = car3.Left - 2;
            if (car3.Left <= -car3.Width)
            {
                car3.Left = ClientRectangle.Width;
            }

            car4.Left = car4.Left - 2;
            if (car4.Left <= -car4.Width)
            {
                car4.Left = ClientRectangle.Width;
            }

            car5.Left = car5.Left - 2;
            if (car5.Left <= -car5.Width)
            {
                car5.Left = ClientRectangle.Width;
            }

            car6.Left = car6.Left - 2;
            if (car6.Left <= -car6.Width)
            {
                car6.Left = ClientRectangle.Width;
            }

            car7.Left = car7.Left - 2;
            if (car7.Left <= -car7.Width)
            {
                car7.Left = ClientRectangle.Width;
            }

            car8.Left = car8.Left - 2;
            if (car8.Left <= -car8.Width)
            {
                car8.Left = ClientRectangle.Width;
            }

            //камиони
            kamion1.Left = kamion1.Left + 5;
            if (kamion1.Left >= ClientRectangle.Width)
            {
                kamion1.Left = -kamion1.Width;
            }

            kamion2.Left = kamion2.Left + 5;
            if (kamion2.Left >= ClientRectangle.Width)
            {
                kamion2.Left = -kamion2.Width;
            }

            kamion3.Left = kamion3.Left + 5;
            if (kamion3.Left >= ClientRectangle.Width)
            {
                kamion3.Left = -kamion3.Width;
            }


        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void kamion2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                zabac.Top -= 20;
            }
            if(e.KeyCode == Keys.Down)
            {
                zabac.Top += 20;
            }
            if (e.KeyCode == Keys.Left)
            {
                zabac.Left -= 20;
            }
            if (e.KeyCode == Keys.Right)
            {
                zabac.Left += 20;
            }
        }

        private void GUBITAK()
        {
            timer1.Stop();
            MessageBox.Show("ИЗГУБИЛИ СТЕ!");
            
        }

        private void POBEDA()
        {
            timer1.Stop();
            MessageBox.Show("ПОБЕДИЛИ СТЕ!");

        }

        private void Sudaranje()
        {
            if(zabac.Bounds.IntersectsWith(car1.Bounds) || zabac.Bounds.IntersectsWith(car2.Bounds) || zabac.Bounds.IntersectsWith(car3.Bounds) || zabac.Bounds.IntersectsWith(car4.Bounds) ||
                zabac.Bounds.IntersectsWith(car5.Bounds) || zabac.Bounds.IntersectsWith(car6.Bounds) || zabac.Bounds.IntersectsWith(car7.Bounds) || zabac.Bounds.IntersectsWith(car8.Bounds) ||
                    zabac.Bounds.IntersectsWith(kamion1.Bounds) || zabac.Bounds.IntersectsWith(kamion2.Bounds) || zabac.Bounds.IntersectsWith(kamion3.Bounds))
            {
                GUBITAK();
            }

            if(zabac.Bounds.IntersectsWith(voda1.Bounds))
            {
                if(zabac.Bounds.IntersectsWith(panel1.Bounds) || zabac.Bounds.IntersectsWith(panel3.Bounds) || zabac.Bounds.IntersectsWith(panel4.Bounds) || zabac.Bounds.IntersectsWith(panel6.Bounds) ||
                    zabac.Bounds.IntersectsWith(panel7.Bounds) || zabac.Bounds.IntersectsWith(panel9.Bounds))
                {
                    zabac.Left -= 2;
                }
                else if(zabac.Bounds.IntersectsWith(panel2.Bounds) || zabac.Bounds.IntersectsWith(panel5.Bounds) || zabac.Bounds.IntersectsWith(panel8.Bounds))
                {
                    zabac.Left += 5;
                }
                else
                {
                    GUBITAK();
                }
            }

            if(zabac.Bottom <= jkra.Bottom)
            {
                POBEDA();
            }
        }
    }
}
