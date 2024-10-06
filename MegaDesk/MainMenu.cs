using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Show();
        }

        private void addQuoteBtn_Click_1(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
        }

        private void searchQuotesBtn_Click_1(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Show();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
