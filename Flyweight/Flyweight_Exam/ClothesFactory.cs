using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Exam
{
    class ClothesFactory
    {
        public Dictionary<char, ClothesStore> clothes = new Dictionary<char, ClothesStore>();
        public ClothesStore GetClothes(char key)
        {
            ClothesStore clothesStore = null;
            if (clothes.ContainsKey(key))
            {
                clothesStore = clothes[key];
            }
            else
            {
                switch (key)
                {
                    case 'W':
                        clothesStore = new WomenClothes();
                        break;
                    case 'M':
                        clothesStore = new ManClothes();
                        break;
                    case 'K':
                        clothesStore = new KidsClothes();
                        break;
                }
                clothes.Add(key, clothesStore);
            }
            return clothesStore;
        }

        public Dictionary<char, ClothesStore> _quantity = new Dictionary<char, ClothesStore>();
        public ClothesStore GetQuantity(char key)
        {
            ClothesStore clothesQuant = null;
            if (clothes.ContainsKey(key))
            {
                clothesQuant = clothes[key];
            }
            else
            {
                switch (key)
                {
                    case 'W':
                        clothesQuant = new WomenClothes();
                        break;
                    case 'M':
                        clothesQuant = new ManClothes();
                        break;
                    case 'K':
                        clothesQuant = new KidsClothes();
                        break;
                }
                clothes.Add(key, clothesQuant);
            }
            return clothesQuant;
        }


    }

 

    }


