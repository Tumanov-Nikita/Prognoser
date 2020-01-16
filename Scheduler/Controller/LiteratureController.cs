using Prognoser.Interface;
using Prognoser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prognoser.Controller
{
    class LiteratureController : ILiterature
    {
        Checkers check = new Checkers();
        static PrognoserContext LiteratureDB;

        public LiteratureController(PrognoserContext db)
        {
            LiteratureDB = db;
        }

        public void Add(string name, string author, double price, int soldCopies)
        {
            if (check.Firmness(name) && check.Firmness(author))
            {
                try
                {
                    Literature newRow = new Literature(name, author, price, soldCopies);
                    var equalRecords = LiteratureDB.Literatures.Where(l => l.Name.Equals(name) && 
                                                                           l.Author.Equals(author));
                    if (equalRecords.Any())
                    {
                        MessageBox.Show("Такая книга уже существует в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        newRow.Date = DateTime.Now.Date;
                        LiteratureDB.Literatures.Add(newRow);
                        LiteratureDB.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка добавления\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Edit(string name, string author, double price, int soldCopies, int Id)
        {
            if (check.Firmness(name) && check.Firmness(author))
            {
                try
                {
                    Literature newRow = new Literature(name, author, price, soldCopies);
                    var equalRecords = LiteratureDB.Literatures.Where(l => l.Name.Equals(name) &&
                                                                           l.Author.Equals(author));
                    if (equalRecords.Any())
                    {
                        MessageBox.Show("Такая книга уже существует в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var EditedValue = LiteratureDB.Literatures.Where(c => c.Id == Id)
                            .FirstOrDefault();
                        EditedValue.Name = name;
                        EditedValue.Author = author;
                        EditedValue.Price = price;
                        EditedValue.SoldCopies = soldCopies;
                        LiteratureDB.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка редактирования\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteByIndex(int index)
        {
            try
            {
                Literature DelitedValue = LiteratureDB.Literatures.Where(l => l.Id == index).FirstOrDefault();
                LiteratureDB.Literatures.Remove(DelitedValue);
                LiteratureDB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка удаления\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteLast()
        {
            try
            {
                Literature DelitedValue = LiteratureDB.Literatures.Last();
                LiteratureDB.Literatures.Remove(DelitedValue);
                LiteratureDB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка удаления\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
