using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prognoser.Model
{
    public class Mark
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Begin { set; get; }
        public double Max_begin { set; get; }
        public double Max_end { set; get; }
        public double End { set; get; }
        public int Direction { get; set; }

        public Mark(string name, double begin, double maxBegin, double maxEnd, double end)
        {
            Name = name;
            Begin = begin;
            Max_begin = maxBegin;
            Max_end = maxEnd;
            End = end;
        }

        public Mark() {}
    }
}
