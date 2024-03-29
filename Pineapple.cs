﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9_Pool_Puzzle_NET
{
    class Pineapple
    {
        const string d = "delivery.txt";
        public enum Fargo {North, South, East, West, Flamingo};
        
        public static void PineappleMain()
        {
            StreamWriter o = new StreamWriter("order.txt");
            Pizza pz = new Pizza(new StreamWriter(d, true));
            pz.Idaho(Fargo.Flamingo);

            for(int w = 3; w >= 0; w--)
            {
                using (StreamWriter writer = new StreamWriter(d, false))
                {
                    Pizza i = new Pizza(writer);
                    i.Idaho((Fargo)w);
                }
                /*
                Pizza i = new Pizza(new StreamWriter(d, false));
                i.Idaho((Fargo)w);
                */
                using (StreamReader reader = new StreamReader(d))
                {
                    Party p = new Party(reader);
                    p.HowMuch(o);
                }
                /*
                Party p = new Party(new StreamReader(d));
                p.HowMuch(o);
                */
            }
            o.WriteLine("That's all Folks!");
            o.Close();


        }
    }
}
