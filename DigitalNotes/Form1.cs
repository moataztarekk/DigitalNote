using DigitalNotes.Data;
using System.Linq;

namespace DigitalNotes
{
    public partial class Form1 : Form
    {
        public DigitalNoteDbContext db { get; set; }
        public string? Category;

        TryCS tryCS = new TryCS();
        public Form1()
        {
            this.db = new DigitalNoteDbContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TryCS tryCS = new TryCS();

            tryCS.CategoryChangedByUser += (s, selectedCategory) =>
            {
                textBox1.Text = selectedCategory;
                Category = selectedCategory;
            };
            tryCS.ShowDialog();

            //if(!db.Categories.Contains(new Models.Category()))
            //foreach()
            //    db.Add(Category);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
