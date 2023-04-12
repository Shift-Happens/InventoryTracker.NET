namespace InventoryTracker
{
    partial class InventoryTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTracker));
            label1 = new Label();
            inventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            eanTextBox = new TextBox();
            priceTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            nameTextBox = new TextBox();
            quantityTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            categoryBox = new ComboBox();
            instrukcjaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(12, -2);
            label1.Name = "label1";
            label1.Size = new Size(1241, 33);
            label1.TabIndex = 0;
            label1.Text = "InventoryTracker - Twoje rozwiązanie do zarządzania inwentarzem V0.16 by Arkadiusz Kubiszewski\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // inventoryGridView
            // 
            inventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGridView.BackgroundColor = SystemColors.ButtonFace;
            inventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGridView.Location = new Point(12, 293);
            inventoryGridView.Name = "inventoryGridView";
            inventoryGridView.RowTemplate.Height = 25;
            inventoryGridView.Size = new Size(1241, 439);
            inventoryGridView.TabIndex = 1;
            inventoryGridView.CellDoubleClick += inventoryGridView_CellDoubleClick;
            // 
            // newButton
            // 
            newButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(12, 242);
            newButton.Name = "newButton";
            newButton.Size = new Size(350, 45);
            newButton.TabIndex = 2;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(466, 242);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(350, 45);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(903, 242);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(350, 45);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // eanTextBox
            // 
            eanTextBox.Location = new Point(12, 139);
            eanTextBox.Name = "eanTextBox";
            eanTextBox.Size = new Size(350, 23);
            eanTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 187);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(350, 23);
            priceTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(466, 187);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(350, 23);
            descriptionTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(466, 139);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(350, 23);
            nameTextBox.TabIndex = 7;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(903, 187);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(350, 23);
            quantityTextBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(350, 23);
            label2.TabIndex = 11;
            label2.Text = "EAN (unikalne id):  ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(466, 113);
            label3.Name = "label3";
            label3.Size = new Size(350, 23);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(903, 113);
            label4.Name = "label4";
            label4.Size = new Size(350, 23);
            label4.TabIndex = 13;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(350, 23);
            label5.TabIndex = 14;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(466, 165);
            label6.Name = "label6";
            label6.Size = new Size(350, 23);
            label6.TabIndex = 15;
            label6.Text = "Description:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(903, 165);
            label7.Name = "label7";
            label7.Size = new Size(350, 23);
            label7.TabIndex = 16;
            label7.Text = "Quantity:";
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Żywność", "Obuwie", "Ciuchy", "Chemia", "Owoce", "Leki", "Narzędzia", "RTV", "AGD", "Automotive", "Inne" });
            categoryBox.Location = new Point(903, 138);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(350, 23);
            categoryBox.TabIndex = 17;
            // 
            // instrukcjaLabel
            // 
            instrukcjaLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            instrukcjaLabel.Location = new Point(12, 21);
            instrukcjaLabel.Name = "instrukcjaLabel";
            instrukcjaLabel.Size = new Size(1241, 92);
            instrukcjaLabel.TabIndex = 18;
            instrukcjaLabel.Text = resources.GetString("instrukcjaLabel.Text");
            instrukcjaLabel.Click += instrukcjaLabel_Click;
            // 
            // InventoryTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1265, 744);
            Controls.Add(instrukcjaLabel);
            Controls.Add(categoryBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(quantityTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(eanTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(inventoryGridView);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryTracker";
            Text = "InventoryTracker";
            Load += InventoryTracker_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView inventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private TextBox eanTextBox;
        private TextBox priceTextBox;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private TextBox quantityTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox categoryBox;
        private Label instrukcjaLabel;
    }
}