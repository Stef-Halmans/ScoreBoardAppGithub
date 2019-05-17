using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreBoardApp
{
    public class Information
    {
        public List<Players> Players;
    }
    public class Players
    {
        public string Name;
        public int Score;
        public List<string> Data;
    }
}
