using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace InventoryTracker
{
    public partial class InventoryTracker : Form
    {
        //inicjalizacja bazy danych
        DataTable inventory = new DataTable();


        public InventoryTracker()
        {
            InitializeComponent();

            // Sprawdzenie czy plik inventory.dat istnieje
            if (File.Exists("inventory.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("inventory.dat", FileMode.Open))
                {
                    inventory = (DataTable)formatter.Deserialize(stream);
                }
            }
            else
            {
                // Jeśli nie istnieje to jest tworzona jego instancja
                inventory.Columns.Add("EAN");
                inventory.Columns.Add("Name");
                inventory.Columns.Add("Category");
                inventory.Columns.Add("Price");
                inventory.Columns.Add("Description");
                inventory.Columns.Add("Quantity");
            }

            inventoryGridView.DataSource = inventory;
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

            // Sprawdzenie po indiwidualnym dla produktu kodzie ean, czy dana rzecz już nie istnieje. Jeśli istnieje to następuje aktualizacja
            DataRow[] foundRows = inventory.Select("EAN = '" + ean + "'");
            if (foundRows.Length > 0)
            {
                // Aktualizacja istniejącego wpisu
                foundRows[0]["Name"] = name;
                foundRows[0]["Category"] = category;
                foundRows[0]["Price"] = price;
                foundRows[0]["Description"] = description;
                foundRows[0]["Quantity"] = quantity;
            }
            else
            {
                // Dodanie nowego wpisu jeśli nie ma produktu z kodem ean
                inventory.Rows.Add(ean, name, category, price, description, quantity);
            }

            // Zapisanie danych do pliku
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("inventory.dat", FileMode.Create))
            {
                formatter.Serialize(stream, inventory);
            }

            // Wyczyszczenie pól tekstowych
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
            // obsługa błędu jeśli takowy się pojawi
            catch (Exception err)
            {
                Console.WriteLine("There has been an error while trying to load the data for edition: " + err);
            }
        }


        //z jakiegoś powodu usunięcie tch funkcji psuje GUI. Niestety nie wiem jak to naprawić
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void instrukcjaLabel_Click(object sender, EventArgs e)
        {

        }
        private void InventoryTracker_Load(object sender, EventArgs e)
        {

        }
    }
}