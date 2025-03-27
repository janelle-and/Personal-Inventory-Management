namespace Personal_Inventory_Management
{
    partial class frmBoxPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lstItems = new ListBox();
            btnUpdateItem = new Button();
            btnDeleteItem = new Button();
            btnMoveToOutBox = new Button();
            btnAddItem = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            btnDeleteBox = new Button();
            btnChangeName = new Button();
            btnSave = new Button();
            lblitems = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(52, 105);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(150, 184);
            lstItems.TabIndex = 2;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(248, 136);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(108, 29);
            btnUpdateItem.TabIndex = 5;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(248, 183);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(108, 29);
            btnDeleteItem.TabIndex = 6;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnMoveToOutBox
            // 
            btnMoveToOutBox.Location = new Point(238, 229);
            btnMoveToOutBox.Name = "btnMoveToOutBox";
            btnMoveToOutBox.Size = new Size(137, 29);
            btnMoveToOutBox.TabIndex = 7;
            btnMoveToOutBox.Text = "Move To OutBox";
            btnMoveToOutBox.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(248, 92);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(108, 29);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(32, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(77, 22);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 0;
            // 
            // btnDeleteBox
            // 
            btnDeleteBox.Location = new Point(281, 334);
            btnDeleteBox.Name = "btnDeleteBox";
            btnDeleteBox.Size = new Size(94, 29);
            btnDeleteBox.TabIndex = 10;
            btnDeleteBox.Text = "Delete Box";
            btnDeleteBox.UseVisualStyleBackColor = true;
            // 
            // btnChangeName
            // 
            btnChangeName.Location = new Point(238, 22);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(124, 29);
            btnChangeName.TabIndex = 11;
            btnChangeName.Text = "Change Name";
            btnChangeName.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(133, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save/Exit";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblitems
            // 
            lblitems.AutoSize = true;
            lblitems.Location = new Point(49, 80);
            lblitems.Name = "lblitems";
            lblitems.Size = new Size(48, 20);
            lblitems.TabIndex = 13;
            lblitems.Text = "Items:";
            // 
            // frmBoxPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 404);
            Controls.Add(lblitems);
            Controls.Add(btnSave);
            Controls.Add(btnChangeName);
            Controls.Add(btnDeleteBox);
            Controls.Add(btnCancel);
            Controls.Add(btnAddItem);
            Controls.Add(btnMoveToOutBox);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnUpdateItem);
            Controls.Add(lstItems);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "frmBoxPage";
            Text = "Box";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private ListBox lstItems;
        private Button btnUpdateItem;
        private Button btnDeleteItem;
        private Button btnMoveToOutBox;
        private Button btnAddItem;
        private Button btnCancel;
        private TextBox txtName;
        private Button btnDeleteBox;
        private Button btnChangeName;
        private Button btnSave;
        private Label lblitems;
    }
}