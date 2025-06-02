using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalNotes
{
    public partial class TryCS : Form
    {
        public event EventHandler<string> CategoryChangedByUser;
        public TryCS()
        {
            InitializeComponent();
            categorySelectorv11.LoadCategories();

            categorySelectorv11.CategoryChanged += (s, e) =>
            {
                CategoryChangedByUser?.Invoke(this, categorySelectorv11.CategorySelected);
                
            };
           
        }

        public string Category
        {
            get
            {
                return categorySelectorv11.CategorySelected;
            }
            set
            {
                categorySelectorv11.CategorySelected = value;
            }
        }


        private void categorySelector1_Load(object sender, EventArgs e)
        {

        }

        private void TryCS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
