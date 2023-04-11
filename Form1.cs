using System.Data;

namespace InventoryTracker
{
    public partial class InventoryTracker : Form
    {

        //inicjalizacja bazy danych
        DataTable inventory = new DataTable();
        public InventoryTracker()
        {
            InitializeComponent();
        }


        private void InventoryTracker_Load(object sender, EventArgs e)
        {
            //inicjuje kolumny w komponencie DataGridView
            inventory.Columns.Add("EAN");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;
        }

        //z jakiegoś powodu usunięcie tej funkcji psuje program
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // klinięcie guzika "New" inicjujące puste pola
            eanTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
            quantityTextBox.Text = "";
            categoryBox.SelectedIndex = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // kliknięcie guziuka "save button" zapisujące inputy jako stringi
            String ean = eanTextBox.Text;
            String name = nameTextBox.Text;
            String price = priceTextBox.Text;
            String quantity = quantityTextBox.Text;
            String description = descriptionTextBox.Text;
            String category = (string)categoryBox.SelectedItem;

            // dodanie wartości do tabeli danych
            inventory.Rows.Add(ean, name, category, price, description, quantity);

            // czyszczenie pól po zapisaniu
            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //usuwanie wpisu z deklaracją błędu jeśli takowy się pojawi
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while deleting a row: " + err);
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // dwukrotne kliknięcie na jakieś pole w DataGridView powodujące załadowanie do edycji
            try
            {
                eanTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                String itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryBox.SelectedIndex = categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error while trying to load the data for edition: " + err);
            }
        }
    }
}