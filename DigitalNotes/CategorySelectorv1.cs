using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalNotes
{
    public partial class CategorySelectorv1 : UserControl
    {
        public event EventHandler CategoryChanged;


        public CategorySelectorv1()
        {
            InitializeComponent();

            //Subscribe if the User choose from the list 
            //CBCategorySelector.SelectedIndexChanged += CBCategorySelector_SelectedIndexChanged;

            //if the user add new category
            //CBCategorySelector.TextChanged += CBCategorySelector_TextChanged;
        }


        public void LoadCategories()
        {
            //CBCategorySelector.DataSource = Repository.Categories;
        }

        //this property to get or set the category
        public string CategorySelected
        { 
            get 
            {
                return CBCategorySelector.Text;
            }
            set
            {
                CBCategorySelector.Text = value;
            }
        }


        //if the user choose existed category Invoke
        //private void CBCategorySelector_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CategoryChanged?.Invoke(this, EventArgs.Empty);
        //}

        //if the user add new category Invoke
        //private void CBCategorySelector_TextChanged(object sender, EventArgs e)
        //{
        //    CategoryChanged?.Invoke(this, EventArgs.Empty);
        //}


        //private void CategorySelectorv1_Load(object sender, EventArgs e)
        //{

        ////}
    }
}
