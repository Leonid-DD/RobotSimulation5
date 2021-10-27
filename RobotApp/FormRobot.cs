using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotApp
{
    public partial class FormRobot : Form
    {
        //Объявить объект робота - глобальный объект
        ClassRobot Robot;

        public FormRobot()
        {
            InitializeComponent();
            //Создание объекта (выделение памяти)
            Robot = new ClassRobot();
            Robot.X = groupBoxControl.Width + pictureBoxGameField.Width / 2 - pictureBoxRobot.Width / 2;
            Robot.Y = pictureBoxGameField.Height / 2 - pictureBoxRobot.Height / 2;
            pictureBoxRobot.Left = Robot.X;
            pictureBoxRobot.Top = Robot.Y;
        }
        /// <summary>
        /// Щелчок для движения вверх
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {           
            if (pictureBoxRobot.Top >= Convert.ToInt32(textBoxSpeed.Text))
            {
                Robot.Walking("Up", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Top = Robot.Y;
                pictureBoxRobot.Left = Robot.X;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }
        /// <summary>
        /// Щелчок для зарядки робота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChargeUp_Click(object sender, EventArgs e)
        {
            Robot.ChargeUp();
            textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
        }
        /// <summary>
        /// Щелчок для разрядки робота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChargeDown_Click(object sender, EventArgs e)
        {
            Robot.ChargeDown();
            textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (pictureBoxRobot.Left >= Convert.ToInt32(textBoxSpeed.Text) + groupBoxControl.Width)
            {
                Robot.Walking("Left", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }

        private void buttonDOWN_Click(object sender, EventArgs e)
        {
            if (pictureBoxRobot.Bottom <= pictureBoxGameField.Height - Convert.ToInt32(textBoxSpeed.Text))
            {
                Robot.Walking("Down", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }

        private void buttonRIGHT_Click(object sender, EventArgs e)
        {
            if (pictureBoxRobot.Right <= groupBoxControl.Width + pictureBoxGameField.Width - Convert.ToInt32(textBoxSpeed.Text))
            {
                Robot.Walking("Right", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
           
        }

        private void buttonUpRight_Click(object sender, EventArgs e)
        {
            if ((pictureBoxRobot.Top >= Convert.ToInt32(textBoxSpeed.Text)) && (pictureBoxRobot.Right <= groupBoxControl.Width + pictureBoxGameField.Width - Convert.ToInt32(textBoxSpeed.Text)))
            {
                Robot.Walking("Up Right", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }

        private void buttonUpLeft_Click(object sender, EventArgs e)
        {
            if ((pictureBoxRobot.Left >= Convert.ToInt32(textBoxSpeed.Text) + groupBoxControl.Width) && (pictureBoxRobot.Top >= Convert.ToInt32(textBoxSpeed.Text)))
            {
                Robot.Walking("Up Left", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }

        private void buttonDownRight_Click(object sender, EventArgs e)
        {
            if ((pictureBoxRobot.Right <= groupBoxControl.Width + pictureBoxGameField.Width - Convert.ToInt32(textBoxSpeed.Text)) && (pictureBoxRobot.Bottom <= pictureBoxGameField.Height - Convert.ToInt32(textBoxSpeed.Text)))
            {
                Robot.Walking("Down Right", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }

        private void buttonDownLeft_Click(object sender, EventArgs e)
        {
            if ((pictureBoxRobot.Left >= Convert.ToInt32(textBoxSpeed.Text) + groupBoxControl.Width) && (pictureBoxRobot.Bottom <= pictureBoxGameField.Height - Convert.ToInt32(textBoxSpeed.Text)))
            {
                Robot.Walking("Down Left", Convert.ToInt32(textBoxSpeed.Text));
                pictureBoxRobot.Left = Robot.X;
                pictureBoxRobot.Top = Robot.Y;
                textBoxPercentEnergy.Text = Robot.PercentErergy.ToString();
            }
            else
            {
                MessageBox.Show("Вы не можете двигаться за край игрового поля");
            }
        }
    }
}
