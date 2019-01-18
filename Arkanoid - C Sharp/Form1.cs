using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid___C_Sharp
{
    public partial class Form1 : Form
    {
        public int x;
        public int y;
        public int a;
        public int do_wygranej = 15;
        public int punkty;
               
        
        public Form1()
        {
            x = 3; //prędkość pionowa
            y = 3; //prędkość pozioma
            a = 1; //prędkość dla bloczków
           
            InitializeComponent();
        }

        private void stop()
        {
            timer_b1.Enabled = false; timer_b9.Enabled = false;
            timer_b2.Enabled = false; timer_b10.Enabled = false;
            timer_b3.Enabled = false; timer_b11.Enabled = false;
            timer_b4.Enabled = false; timer_b12.Enabled = false;
            timer_b5.Enabled = false; timer_b13.Enabled = false;
            timer_b6.Enabled = false; timer_b14.Enabled = false;
            timer_b7.Enabled = false; timer_b15.Enabled = false;
            timer_b8.Enabled = false;
            
        }    

        private void timer_pilka_Tick(object sender, EventArgs e)
        {
            label2.Text = punkty.ToString();
            pilka.Top += x;
            pilka.Left += y;

            //odbicie od górnej krawędzi
            if (pilka.Top < 0)
            {
                x = -x;
            }

            //odbicie od prawej krawędzi
            if(pilka.Right > this.ClientSize.Width)
            {
                y = -y;
            }

            //odbicie od lewej krawędzi
            if(pilka.Left < 0)
            {
                y = -y;               
            }

            //kolizja piłki z paletką
            if(pilka.Bounds.IntersectsWith(paletka.Bounds) ==true)
            {
                x = -x;
                x = (pilka.Left - paletka.Left) / 100 - 6;
            }

            //kolizja piłki z bloczkami
            //BLOK 1
            if(pilka.Bounds.IntersectsWith(b1.Bounds) && b1.Visible == true)
            {
                b1.Visible = false;
                timer_b1.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;
                
            }
            //BLOK 2
            if (pilka.Bounds.IntersectsWith(b2.Bounds) && b2.Visible == true)
            {
                b2.Visible = false;
                timer_b2.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 3
            if (pilka.Bounds.IntersectsWith(b3.Bounds) && b3.Visible == true)
            {
                b3.Visible = false;
                timer_b3.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 4
            if (pilka.Bounds.IntersectsWith(b4.Bounds) && b4.Visible == true)
            {
                b4.Visible = false;
                timer_b4.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 5
            if (pilka.Bounds.IntersectsWith(b5.Bounds) && b5.Visible == true)
            {
                b5.Visible = false;
                timer_b5.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 6
            if (pilka.Bounds.IntersectsWith(b6.Bounds) && b6.Visible == true)
            {
                b6.Visible = false;
                timer_b6.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 7
            if (pilka.Bounds.IntersectsWith(b7.Bounds) && b7.Visible == true)
            {
                b7.Visible = false;
                timer_b7.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 8
            if (pilka.Bounds.IntersectsWith(b8.Bounds) && b8.Visible == true)
            {
                b8.Visible = false;
                timer_b8.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 9
            if (pilka.Bounds.IntersectsWith(b9.Bounds) && b9.Visible == true)
            {
                b9.Visible = false;
                timer_b9.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 10
            if (pilka.Bounds.IntersectsWith(b10.Bounds) && b10.Visible == true)
            {
                b10.Visible = false;
                timer_b10.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 11
            if (pilka.Bounds.IntersectsWith(b11.Bounds) && b11.Visible == true)
            {
                b11.Visible = false;
                timer_b11.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 12
            if (pilka.Bounds.IntersectsWith(b12.Bounds) && b12.Visible == true)
            {
                b12.Visible = false;
                timer_b12.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 13
            if (pilka.Bounds.IntersectsWith(b13.Bounds) && b13.Visible == true)
            {
                b13.Visible = false;
                timer_b13.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 14
            if (pilka.Bounds.IntersectsWith(b14.Bounds) && b14.Visible == true)
            {
                b14.Visible = false;
                timer_b14.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }
            //BLOK 15
            if (pilka.Bounds.IntersectsWith(b15.Bounds) && b15.Visible == true)
            {
                b15.Visible = false;
                timer_b15.Enabled = false;
                x = -x;
                do_wygranej--;
                punkty++;

            }


            //przegrana, gdy piłka spadnie pod paletke
            if (pilka.Top >= paletka.Top + paletka.Height - 20)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
            //warunek wygranej gry
            if(do_wygranej <= 0)
            {
                label2.Text = "15";
                timer_pilka.Enabled = false;
                pilka.Visible = false;
                button1.Text = "Wygrana! Wciśnij, aby zagrać ponownie!";
                button1.Visible = true;               
            }
        }
        //sterowanie paletką za pomocą kursora
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            paletka.Left = e.X - (paletka.Width / 2);
        }


        //spadanie bloczków w dół
        private void timer_b1_Tick(object sender, EventArgs e)
        {
            b1.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b1.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b2_Tick(object sender, EventArgs e)
        {
            b2.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b2.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b3_Tick(object sender, EventArgs e)
        {
            b3.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b3.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b4_Tick(object sender, EventArgs e)
        {
            b4.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b4.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b5_Tick(object sender, EventArgs e)
        {
            b5.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b5.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b6_Tick(object sender, EventArgs e)
        {
            b6.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b6.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b7_Tick(object sender, EventArgs e)
        {
            b7.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b7.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b8_Tick(object sender, EventArgs e)
        {
            b8.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b8.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b9_Tick(object sender, EventArgs e)
        {
            b9.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b9.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b10_Tick(object sender, EventArgs e)
        {
            b10.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b10.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b11_Tick(object sender, EventArgs e)
        {
            b11.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b11.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b12_Tick(object sender, EventArgs e)
        {
            b12.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b12.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b13_Tick(object sender, EventArgs e)
        {
            b13.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b13.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b14_Tick(object sender, EventArgs e)
        {
            b14.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b14.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }

        private void timer_b15_Tick(object sender, EventArgs e)
        {
            b15.Top += a;
            //przegrana, gdy bloczek zleci do poziomu paletki
            if (b15.Top >= paletka.Top - 30)
            {
                pilka.Visible = false;
                button1.Text = "Porażka! Wciśnij, aby spróbować ponownie!";
                button1.Visible = true;
                stop();
            }
        }


        //naciśnięcie przycisku restartującego gre
        private void button1_Click(object sender, EventArgs e)
        {
           //ustawienie pozycji początkowej piłki
            pilka.Top = 200;
            pilka.Left = 150;

           //powrót bloczków do pozycji początkowej 
            b1.Top = 12; b9.Top = 48;
            b2.Top = 12; b10.Top = 48;
            b3.Top = 12; b11.Top = 84;
            b4.Top = 12; b12.Top = 84;
            b5.Top = 12; b13.Top = 84;
            b6.Top = 48; b14.Top = 84;
            b7.Top = 48; b15.Top = 84;
            b8.Top = 48;

            //ponowne pojawienie się bloczków na planszy
            b1.Visible = true; b9.Visible = true;
            b2.Visible = true; b10.Visible = true;
            b3.Visible = true; b11.Visible = true;
            b4.Visible = true; b12.Visible = true;
            b5.Visible = true; b13.Visible = true;
            b6.Visible = true; b14.Visible = true;
            b7.Visible = true; b15.Visible = true;
            b8.Visible = true;

            //ponowne włączenie timerów bloczków
            timer_b1.Enabled = true; timer_b9.Enabled = true;
            timer_b2.Enabled = true; timer_b10.Enabled = true;
            timer_b3.Enabled = true; timer_b11.Enabled = true;
            timer_b4.Enabled = true; timer_b12.Enabled = true;
            timer_b5.Enabled = true; timer_b13.Enabled = true;
            timer_b6.Enabled = true; timer_b14.Enabled = true;
            timer_b7.Enabled = true; timer_b15.Enabled = true;
            timer_b8.Enabled = true;


            pilka.Visible = true;
            timer_pilka.Enabled = true;

            x = 3;
            y = 3;
            a = 1;

            button1.Visible = false;
            do_wygranej = 15;
            punkty = 0;
        }

        private void pilka_Click(object sender, EventArgs e)
        {

        }
    }
}
