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
            label1 = new Label();
            inventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1241, 53);
            label1.TabIndex = 0;
            label1.Text = "InventoryTracker - Twoje rozwiązanie do zarządzania inwentarzem\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // 
            // newButton
            // 
            newButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(12, 228);
            newButton.Name = "newButton";
            newButton.Size = new Size(343, 59);
            newButton.TabIndex = 2;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(462, 228);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(343, 59);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(910, 228);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(343, 59);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // InventoryTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1265, 744);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(inventoryGridView);
            Controls.Add(label1);
            Name = "InventoryTracker";
            Text = "InventoryTracker";
            Load += InventoryTracker_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView inventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
    }
}