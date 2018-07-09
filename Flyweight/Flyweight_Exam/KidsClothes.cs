using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Exam
{
    public class KidsClothes : ClothesStore
    {
        public KidsClothes()
        {
            this.Name = "T-shirt";
            this.Color = "red";
            this.Size = "XXS";
            this.Price = 20;
            this.Quantity = 5;
        }

        public override void SellItem(int countItem)
        {
            if (Quantity <= 1)
            {
                Console.WriteLine("Kids clothes is out of stock!");

            }
            else
            {
                Quantity--;
                Console.WriteLine("You add" + " " + countItem + ":" + " " + "kids clothes and there left" + " " + Quantity);
            }
        }

        public override void ViewClothes(int count)
        {
            Console.WriteLine("In your cart is" + "-" + count + ": " + Name + " in color" + " " + Color + " in size" + " " + Size + " " + "and cost" + " " + Price.ToString() + "lv");


        }

    }
}
