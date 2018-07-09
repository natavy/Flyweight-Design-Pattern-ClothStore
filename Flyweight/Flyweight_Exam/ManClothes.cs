using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Exam
{
    public class ManClothes : ClothesStore
    {
        public ManClothes()
        {
            this.Name = "Jeans";
            this.Color = "blue";
            this.Size = "L";
            this.Price = 100;
            this.Quantity = 12;
        }

        public override void SellItem(int countItem)
        {
            if (Quantity <= 1)
            {
                Console.WriteLine("Man clothes is out of stock!");

            }
            else
            {
                Quantity--;
                Console.WriteLine("You add" + " " + countItem + ":" + " " + "man clothes and there left" + " " + Quantity);
            }
        }

        public override void ViewClothes(int count)
        {
            Console.WriteLine("In your cart is" + "-" + count + ": " + Name + " in color" + " " + Color + " in size" + " " + Size + " " + "and cost" + " " + Price.ToString() + "lv");


        }
    }
}
