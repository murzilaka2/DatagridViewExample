
using System.ComponentModel;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView;
        private BindingList<Person> people;
        public Form1()
        {
            InitializeComponent();

            //DataGridViewButtonColumn
            //DataGridViewCheckBoxColumn
            //DataGridViewComboBoxColumn
            //DataGridViewImageColumn
            //DataGridViewLinkColumn
            //DataGridViewTextBoxCell

            dataGridView = new DataGridView();
            dataGridView.Columns.Add("Column1", "Id");
            dataGridView.Columns.Add("Column2", "Name");
            dataGridView.Columns.Add("Column3", "Age");


            DataGridViewTextBoxCell dataGridViewTextBoxCellCompany = new DataGridViewTextBoxCell();
            dataGridView.Columns.Add(new DataGridViewColumn(dataGridViewTextBoxCellCompany)
            {
                HeaderText = "Company",
                Name = "Column4"
            });

            DataGridViewTextBoxCell dataGridViewTextBoxCellHobby = new DataGridViewTextBoxCell();
            dataGridView.Columns.Insert(2, new DataGridViewColumn(dataGridViewTextBoxCellHobby)
            {
                HeaderText = "Hobby",
                Name = "Column5"
            });

            //********************************
            dataGridView.Dock = DockStyle.Fill;
            panel1.Controls.Add(dataGridView);
        }

        private void RemoveCellButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell?.ColumnIndex ?? -1;
            int columnsCount = dataGridView.Columns.Count;

            if ((columnsCount > 0) && (index >= 0) && (index < columnsCount))
            {
                dataGridView.Columns.RemoveAt(index);
            }
        }

        private void UpdateColumnsButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.ColumnIndex;
            if (index >= 0 && index < dataGridView.Columns.Count)
            {
                dataGridView.Columns[index].HeaderText = dataGridView.Columns[index].HeaderText + "Updated";
                dataGridView.Columns[index].Name = dataGridView.Columns[index].Name + "Updated";

                dataGridView.Columns[index].DefaultCellStyle.BackColor = Color.Black;
                dataGridView.Columns[index].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(1, "Alex", 40, "WallMart", "Cooking");
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            int rowsCount = dataGridView.Rows.Count;

            if ((rowsCount > 1) && (index >= 0) && (index < rowsCount))
            {
                dataGridView.Rows.RemoveAt(index);
            }
        }

        private void SetDataSourceButton_Click(object sender, EventArgs e)
        {
            SetDataSource();
        }

        private void SetDataSource()
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            people = Person.GetData();
            dataGridView.DataSource = people;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //dataGridView.Rows.Clear();
            //dataGridView.Columns.Clear();
            dataGridView.DataSource = people;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {

            DataGridViewCell dataGridViewCell = null!;
            Random r = new Random();
            switch (r.Next(1, 6))
            {
                case 1: { dataGridViewCell = new DataGridViewTextBoxCell(); break; }
                case 2: { dataGridViewCell = new DataGridViewComboBoxCell(); break; }
                case 3: { dataGridViewCell = new DataGridViewImageCell(); break; }
                case 4: { dataGridViewCell = new DataGridViewLinkCell(); break; }
                case 5: { dataGridViewCell = new DataGridViewTextBoxCell(); break; }
            }
            dataGridView.Columns.Add(new DataGridViewColumn(dataGridViewCell)
            {
                HeaderText = "Header " + dataGridView.Columns.Count,
                Name = "Column" + dataGridView.Columns.Count
            });
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bm, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }

    public class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public static BindingList<Person> GetData()
        {
            return new BindingList<Person>()
            {
                new Person{ Name = "Alex", Age = 32, Company = "WallMart"},
                new Person{ Name = "Jonh", Age = 16, Company = "Wendys"},
                new Person{ Name = "Kate", Age = 25, Company = "BestBuy"},
                new Person{ Name = "Sarah", Age = 41, Company = "WallMart"},
                new Person{ Name = "Smith", Age = 29, Company = "Aoc"}
            };
        }
    }
}
