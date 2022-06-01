using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ForTextBox
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            List<string> text = new List<string>();
            int count = 1;
            text.Add($"вопрос: {count}");
        }

        

        private void nupForText_ValueChanged(object sender, EventArgs e)
        {
            List<string> text = new List<string>();
            int count = 1;
            
            for (int i = 0; i < 5; i++)
            {
                text.Add($"вопрос: {count}");
                count++;
            }

            foreach (string s in text)
            {
                textChange.Text = text[(int)text.Count - 1];
            }
        }
    }
}
