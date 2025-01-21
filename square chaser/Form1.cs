using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace square_chaser
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        
        Rectangle player1 = new Rectangle(10, 150, 10, 10);
        Rectangle player2 = new Rectangle(10, 190, 10, 10);
        Rectangle pointUp = new Rectangle(75, 195, 15, 15);
        Rectangle speedUp = new Rectangle(295, 195, 15, 15);


        int player1score = 0;
        int player2socre = 0;
        int player1Speed = 4;
        int player2Speed = 4;
        int ballxSpeed = 6;
        int ballySpeed = 6;

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        bool downPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;
        bool active = false;

        SolidBrush blueBrush = new SolidBrush(Color.Cyan);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        Pen blackPen = new Pen(Color.Black, 5);

      
        


        public Form1()
        { 
            InitializeComponent();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
            }
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.DrawRectangle(blackPen, player1);
            e.Graphics.DrawRectangle(blackPen, player2);
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.DrawRectangle(blackPen, pointUp);
            e.Graphics.FillRectangle(whiteBrush, pointUp);
            e.Graphics.DrawRectangle(blackPen, speedUp);
            e.Graphics.FillRectangle(yellowBrush, speedUp);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            playerBox1.Text = $"{player1score}";

            playerBox2.Text = $"{player2socre}";


            if (wPressed == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sPressed == true && player1.Y < this.Height - 10)
            {
                player1.Y += player1Speed;

            }
            Refresh();

            if (aPressed == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dPressed == true && player1.X < this.Width - 10)
            {
                player1.X += player1Speed;
            }


            if (upPressed == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downPressed == true && player2.Y < this.Height - 10)
            {
                player2.Y += player2Speed;

            }
           

            if (leftPressed == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }

            if (rightPressed == true && player2.X < this.Width - 10)
            {
                player2.X += player2Speed;
            }

            if (player1.IntersectsWith(pointUp))
            {
                int random1 = random.Next(25, 450);
                int random2 = random.Next(25, 450);
                pointUp = new Rectangle(random2, random1, 15, 15);
                player1score++;
            }
            else if (player2.IntersectsWith(pointUp))
            {
                int random1 = random.Next(25, 450);
                int random2 = random.Next(25, 450);
                pointUp = new Rectangle(random2, random1, 15, 15);
                player2socre++;
            }

            if (player1.IntersectsWith(speedUp))
            {
                int random1 = random.Next(25, 450);
                int random2 = random.Next(25, 450);
                speedUp = new Rectangle(random2, random1, 15, 15);
                player1Speed++;
            }
            else if (player2.IntersectsWith(speedUp))
            {
                int random1 = random.Next(25, 450);
                int random2 = random.Next(25, 450);
                speedUp = new Rectangle(random2, random1, 15, 15);
                player2Speed++;
            }

            if (player1Speed < 10)
            {
               
                player1Speed = 4;
            }



           if (player2Speed < 10) 
            {
               
                player2Speed = 4; 
            }

           
                

        }

        





    }
}
