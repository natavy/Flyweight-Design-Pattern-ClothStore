using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Exam
{
    public abstract class ClothesStore
    {
        public string Name;
        public string Color;
        public string Size;
        public decimal Price;
        public int Quantity;

        public abstract void ViewClothes(int count);
        public abstract void SellItem(int countItem);
        
    }
}
