using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add to cart what do you want to buy!");
            Console.WriteLine("Use characters W for women clothes, K for kids clothes, M for man clothes with no spaces.");
            Console.WriteLine("You can add more than one product. (Ex. WMKKWM)");

            ClothesFactory factory = new ClothesFactory();
            int count = 0;
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();
            int countItem=0;
            

            foreach (char c in chars)
            {
                count++;
                ClothesStore store = factory.GetClothes(c);
                store.ViewClothes(count);
               
            }

            foreach (char c in chars)
            {

                countItem++;
                ClothesStore store = factory.GetQuantity(c);
                store.SellItem(countItem);

            }

            Console.ReadLine();
        }
    }
}
