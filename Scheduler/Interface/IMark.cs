using Prognoser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prognoser.Interface
{
    interface IMark
    {
        void Add(string name, double begin, double maxBegin, double maxEnd, double end);

        void Edit(string name, double begin, double maxBegin, double maxEnd, double end, int index);

        void DeleteByIndex(int index);

        void DeleteLast();
    }
}
