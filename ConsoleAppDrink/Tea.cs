using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDrink
{
    class Tea : Drink
    {
        string grade = "черный";

        public string Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        int sugar = 1;

        public int Sugar
        {
            get
            {
                return sugar;
            }
            set
            {
                sugar = value;
            }
        }

        public Tea (string grade1)
        {
            grade = grade1;
        }

        public string AddJae()
        {
            
            return "Вы добавили варенье в " + grade + " чай";
        }

        public string AddSugar()
        {
            Console.WriteLine("Введите количество сахара: ");
            int sugar = int.Parse(Console.ReadLine());
            return "Вы положили " + sugar + " в " + grade + " чай.";

        }
       
    }
}
