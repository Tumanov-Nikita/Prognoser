using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prognoser.Model
{
    public class Trend
    {
        public Mark First { set; get; }
        public Mark Second { set; get; }
        public Mark Prognosed { set; get; }
        public int Count { set; get; }
        public int Time { set; get; }
        public string Name { set; get; }

        public Trend(Mark first, Mark second)
        {
            this.First = first;
            this.Second = second;
        }
    }
}
