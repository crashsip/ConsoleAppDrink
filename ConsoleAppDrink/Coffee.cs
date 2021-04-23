using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDrink
{
    class Coffee : Drink
    {
        string sort = "арабика";

        public string AddMilk()
        {
            return "Вы добавили молоко в кофе сорта " + sort;
        }

        public Coffee(string _sort)
        {
            sort = _sort;
        }

        private Coffee()
        {

        }
    }
}
