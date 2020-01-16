using Prognoser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prognoser.Interface
{
    interface ILiterature
    {
        void Add(string name, string author, double price, int soldCopies);

        void Edit(string name, string author, double price, int soldCopies, int index);

        void DeleteByIndex(int index);

        void DeleteLast();
    }
}
