using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandip.Karki_Assignment1
{
    class cooking
    {
        public double people { get; set; }
        public double milk { get; set; }
        public double powder { get; set; }
        public double eggs { get; set; }
        public double oil { get; set; }
        List<string> items = new List<string>();
        
        public cooking(string peopleNo) {

            
            people = Double.Parse(peopleNo);
            milk = people * 1.5;
            powder = people * 1;
            eggs = people * 2;
            oil = people * 1;

        }

        public List<string> lister() {
            return items;
        }

        public  void calcIng()
        {
            items.Add(powder + " cups of Baking powder.");
            items.Add(milk + " cup of milk.");
            items.Add(eggs + " eggs.");
            items.Add(oil + " tabel spoon of oil.");
           
        }

        
    }
}
