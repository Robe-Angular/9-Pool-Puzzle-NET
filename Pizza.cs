using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9_Pool_Puzzle_NET
{
    class Pizza
    {
        private StreamWriter writer;
        public Pizza(StreamWriter writer)
        {
            this.writer = writer;
        }

        public void Idaho(Pineapple.Fargo f)
        {
            writer.WriteLine(f.ToString());
            writer.Close();
        }
    }
}
