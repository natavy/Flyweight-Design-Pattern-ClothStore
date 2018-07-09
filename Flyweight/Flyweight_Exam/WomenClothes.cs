using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Exam
{
    public class WomenClothes : ClothesStore
    {
        public WomenClothes()
        {
            this.Name = "Dress";
            this.Color = "black";
            this.Size = "S";
            this.Price = 80;
            this.Quantity = 7;
        }

        public override void SellItem(int countItem)
        {
            if (Quantity<=1)
            {
                Console.WriteLine("Women clothes is out of stock!");
                
            }
            else
            {
                Quantity--;
                Console.WriteLine("You add" + " " + countItem + ":" + " " + "women clothes and there left" + " " + Quantity);
            }
        }

        public override void ViewClothes(int count)
        {
            Console.WriteLine("In your cart is"+ "-"+ count + ": " + Name + " in color"+" " + Color + " in size" +" "+ Size + " "+"and cost"+" " + Price.ToString()+"lv");
        }
    }

 }

