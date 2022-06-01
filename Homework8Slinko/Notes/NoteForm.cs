using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrueFalseEditor;

namespace Notes
{
    public partial class NoteForm : Form
    {
        TrueFalseDatabase database;
        public NoteForm()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            database.Add($"Текст заметки{database.Count + 1}", true);
            nudNumberNotes.Maximum = database.Count;
            nudNumberNotes.Value = database.Count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumberNotes.Value - 1].Text = textBoxNotes.Text;
            database[(int)nudNumberNotes.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Remove((int)nudNumberNotes.Value - 1);
                nudNumberNotes.Maximum--;
                nudNumberNotes.Value--;
            }
            else MessageBox.Show("Заметка не выбрана");
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(dlg.FileName);
                database.Load();
                nudNumberNotes.Minimum = 1;
                nudNumberNotes.Maximum = database.Count;
                nudNumberNotes.Value = 1;
            }
        }

        private void MenuItemSaveFile_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("Заметки не созданы");
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudNumberNotes_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                textBoxNotes.Text = database[(int)nudNumberNotes.Value - 1].Text;
                cbTrue.Checked = database[(int)nudNumberNotes.Value - 1].TrueFalse;
            }
            else MessageBox.Show("Выберете файл");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseDatabase(dlg.FileName);
                database.Add("Купить фрукты", true);
                database.Save();
                nudNumberNotes.Minimum = 1;
                nudNumberNotes.Maximum = 1;
                nudNumberNotes.Value = 1;
            }
        }
    }
}
