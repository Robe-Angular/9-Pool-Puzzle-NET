using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9_Pool_Puzzle_NET
{
    class Party
    {
        private StreamReader reader;
        public Party(StreamReader reader)
        {
            this.reader = reader;
        }

        public void HowMuch(StreamWriter q)
        {
            q.WriteLine(reader.ReadLine());
            reader.ReadLine();
        }
    }
}
