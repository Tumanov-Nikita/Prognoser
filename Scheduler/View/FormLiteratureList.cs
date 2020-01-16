using Prognoser.Controller;
using Prognoser.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;

namespace Prognoser.View
{
    public partial class FormLiteratureList : Form
    {
        Checkers check = new Checkers();
        LiteratureController Controller;
        static PrognoserContext db;
        List<TextBox> TextBoxes;
        public FormLiteratureList()
        {
            InitializeComponent();
            db = new PrognoserContext();
            TextBoxes = new List<TextBox>();
            TextBoxes.Add(textBoxName);
            TextBoxes.Add(textBoxAuthor);
            TextBoxes.Add(textBoxPrice);
            TextBoxes.Add(textBoxSold);
        }

        public static void refreshForm(DataGridView dataGridView, List<TextBox> textBoxes)
        {
            db.Literatures.Load();
            dataGridView.DataSource = db.Literatures.Local.ToBindingList();
            dataGridView.Update();
            dataGridView.Refresh();
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
            string nameId1 = dataGridView[1, CurrentRow].Value.ToString();
            string nameId2 = dataGridView[2, CurrentRow].Value.ToString();
            string nameId3 = dataGridView[3, CurrentRow].Value.ToString();
            string nameId4 = dataGridView[4, CurrentRow].Value.ToString();
            textBoxName.Text = nameId1;
            textBoxAuthor.Text = nameId2;
            textBoxPrice.Text = nameId3;
            textBoxSold.Text = nameId4;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (check.TexboxPriceAmountValidation(textBoxPrice, textBoxSold))
            {
                Controller.Add(textBoxName.Text, textBoxAuthor.Text, Convert.ToDouble(check.UnPointReplace(textBoxPrice.Text)), Convert.ToInt32(textBoxSold.Text));
                refreshForm(dataGridView, TextBoxes);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (check.TexboxPriceAmountValidation(textBoxPrice, textBoxSold))
            {
                int CurrentRow = dataGridView.SelectedCells[0].RowIndex;
                Controller.Edit(textBoxName.Text, textBoxAuthor.Text, Convert.ToDouble(check.UnPointReplace(textBoxPrice.Text)), Convert.ToInt32(textBoxSold.Text), Convert.ToInt32(dataGridView[0, CurrentRow].Value));
                refreshForm(dataGridView, TextBoxes);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView.SelectedCells[0].RowIndex;
            int rowId = Convert.ToInt32(dataGridView[0, selectedId].Value);
            Controller.DeleteByIndex(rowId);
            refreshForm(dataGridView, TextBoxes);
        }

        private void FormLiteratureList_Load(object sender, EventArgs e)
        {
            Controller = new LiteratureController(db);
            db.Literatures.Load();
            dataGridView.DataSource = db.Literatures.Local.ToBindingList();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void textBox_KeyPressLetters(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < 'A' || c > 'я') && c != '\b' && c != '.' && c != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox_KeyPressPrice(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < '0' || c > '9') && c != '\b' && c != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox_KeyPressAmount(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < '0' || c > '9') && c != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
