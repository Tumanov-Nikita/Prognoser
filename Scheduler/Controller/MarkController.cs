using Prognoser;
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
    class MarkController : IMark
    {
        Checkers check = new Checkers();
        static PrognoserContext MarksDB;

        public MarkController(PrognoserContext db)
        {
            MarksDB = db;
        }

        public void Add(string name, double begin, double maxBegin, double maxEnd, double end)
        {
            if (check.Firmness(name) && check.Firmness(begin) &&
                check.Firmness(maxBegin) && check.Firmness(maxEnd) &&
                check.Firmness(end))
            {
                try
                {
                    Mark newRow = new Mark(name, begin, maxBegin, maxEnd, end);
                    var equalRecords = MarksDB.Marks.Where(l => l.Name.Equals(name));
                    if (equalRecords.Any())
                    {
                        MessageBox.Show("Такая метка уже существует в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MarksDB.Marks.Add(newRow);
                        MarksDB.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка добавления\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Edit(string name, double begin, double maxBegin, double maxEnd, double end, int rowId)
        {
            if (check.Firmness(name) && check.Firmness(begin) &&
                check.Firmness(maxBegin) && check.Firmness(maxEnd) &&
                check.Firmness(end))
            {
                try
                {
                    Mark newRow = new Mark(name, begin, maxBegin, maxEnd, end);
                    var equalRecords = MarksDB.Marks.Where(l => l.Name.Equals(name));
                    if (equalRecords.Any())
                    {
                        MessageBox.Show("Такая метка уже существует в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var EditedValue = MarksDB.Marks.Where(c => c.Id == rowId)
                            .FirstOrDefault();
                        EditedValue.Name = name;
                        EditedValue.Begin = begin;
                        EditedValue.Max_begin = maxBegin;
                        EditedValue.Max_end = maxEnd;
                        EditedValue.End = end;
                        MarksDB.SaveChanges();
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
                Mark DelitedValue = MarksDB.Marks.Where(l => l.Id == index).FirstOrDefault();
                MarksDB.Marks.Remove(DelitedValue);
                MarksDB.SaveChanges();
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
                Mark DelitedValue = MarksDB.Marks.Last();
                MarksDB.Marks.Remove(DelitedValue);
                MarksDB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка удаления\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
