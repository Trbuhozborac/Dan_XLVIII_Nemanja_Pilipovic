using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Models
{
    public class Food
    {
        #region Properties

        public string Name { get; set; }
        public int Price { get; set; }

        #endregion

        #region Constructors

        public Food()
        {

        }

        public Food(string name, int price)
        {
            Name = name;
            Price = price;
        }

        #endregion
    }
}
