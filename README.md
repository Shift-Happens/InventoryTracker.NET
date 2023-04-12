<h1> InventoryTracker </h1>
This is a C# project for a simple inventory tracker application that allows users to add, edit, and delete items from an inventory. The application uses a DataTable to store the inventory data and a binary file to persist the data between sessions. I've made this ap for my .NET programming course.

Here is a brief summary of what the code does:

<ul>
<li>The "using" statements import the required namespaces for the application to work with DataTable and BinaryFormatter objects.</li>
<li>The "namespace" statement declares the name of the application's namespace, which is InventoryTracker. </li>
<li>The "public partial class" statement defines the main form class of the application, also named InventoryTracker. </li>
<li>The form's DataTable object is initialized to store the inventory data. </li>
<li>The constructor of the form checks if a file named "inventory.dat" exists in the current directory. If the file exists, it is deserialized using a BinaryFormatter and its contents are loaded into the DataTable. Otherwise, the DataTable is initialized with empty columns.</li>
<li>The "newButton_Click" event handler clears the text fields of the form.</li>
<li>The "saveButton_Click" event handler retrieves the input values from the text fields and the dropdown list, checks if an item with the same EAN (European Article Number) code already exists in the inventory, and either updates the existing item or adds a new item to the DataTable. The inventory data is then serialized to a binary file named "inventory.dat" in the current directory, and the text fields are cleared using the "newButton_Click" event handler.</li>
<li>The "deleteButton_Click" event handler deletes the currently selected item from the DataTable.</li>
<li>The "inventoryGridView_CellDoubleClick" event handler loads the data of the double-clicked item into the text fields and the dropdown list to allow editing. If an error occurs, a message is displayed in the console.</li>
</ul>

<h2> A simple solution for adding, deleting and tracking an inventory</h2>

![image](https://user-images.githubusercontent.com/90008035/231557860-4969382c-8fdd-49e5-bf4a-e46216b25fb2.png)

<h2> Adding, Saveing and Deleting items form database</h2>

![image](https://user-images.githubusercontent.com/90008035/231558266-b604723d-e319-4e64-823d-1494d530b021.png)

<h2> Edition of already existing items with a dubble click</h2>

![image](https://user-images.githubusercontent.com/90008035/231558746-a1d37b6b-322e-4e34-896e-3f49f2cfcf08.png)

<h2> Quick and accesable instruction</h2>

![image](https://user-images.githubusercontent.com/90008035/231559012-18a83646-6332-4231-a686-7973094e9504.png)




