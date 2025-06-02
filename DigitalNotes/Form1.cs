namespace DigitalNotes
{
    public partial class Form1 : Form
    {

        public string? Category;

        TryCS tryCS = new TryCS();
        public Form1()
        {
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

            if(!Repository.Categories.Contains(Category))
                Repository.addCategory(Category);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
