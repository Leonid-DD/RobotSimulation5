using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApp
{
    /// <summary>
    /// Класс, обеспечивающий передвижение робота
    /// </summary>
    public class ClassRobot
    {
        //****Свойства класса
        public int X, Y;             //Свойства координат
        public int c;                //Свойство величины шага
        public int PercentErergy;    //Свойства энергии

        //****Методы - действия
        /// <summary>
        /// Зарядить робота на 100%
        /// </summary>
        public void ChargeUp()
        {
            PercentErergy = 100;
        }

        /// <summary>
        /// Разрядить робота на 0%
        /// </summary>
        public void ChargeDown()
        {
            PercentErergy = 0;
        }

        /// <summary>
        /// Движение робота
        /// </summary>
        /// <param name="direct">Направление движения</param>
        public void Walking(string direct, int c)
        {
            if (PercentErergy>0)    //Проверка уровня
            {
                switch (direct)     //Проверка направления
                {
                    case "Left":
                        X = X - c;
                        break;
                    case "Right":
                        X = X + c;
                        break;
                    case "Up":
                        Y = Y - c; 
                        break;
                    case "Down":
                        Y = Y + c;
                        break;
                    case "Up Left":
                        Y = Y - c;
                        X = X - c;
                        break;
                    case "Up Right":
                        Y = Y - c;
                        X = X + c;
                        break;
                    case "Down Left":
                        Y = Y + c;
                        X = X - c;
                        break;
                    case "Down Right":
                        Y = Y + c;
                        X = X + c;
                        break;
                }
                PercentErergy--;   //Уменьшение уровня энергии
            }
        }
    }
}
