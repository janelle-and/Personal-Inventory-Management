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
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(22, 68);
            lstItems.Margin = new Padding(3, 4, 3, 4);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(612, 284);
            lstItems.TabIndex = 2;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(641, 145);
            btnUpdateItem.Margin = new Padding(3, 4, 3, 4);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(123, 39);
            btnUpdateItem.TabIndex = 5;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(641, 231);
            btnDeleteItem.Margin = new Padding(3, 4, 3, 4);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(123, 39);
            btnDeleteItem.TabIndex = 6;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnMoveToOutBox
            // 
            btnMoveToOutBox.Location = new Point(641, 302);
            btnMoveToOutBox.Margin = new Padding(3, 4, 3, 4);
            btnMoveToOutBox.Name = "btnMoveToOutBox";
            btnMoveToOutBox.Size = new Size(123, 50);
            btnMoveToOutBox.TabIndex = 7;
            btnMoveToOutBox.Text = "Move To OutBox";
            btnMoveToOutBox.UseVisualStyleBackColor = true;
            btnMoveToOutBox.Click += btnMoveToOutBox_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(641, 68);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(123, 39);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(22, 379);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 39);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 29);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 27);
            txtName.TabIndex = 0;
            // 
            // btnDeleteBox
            // 
            btnDeleteBox.Location = new Point(641, 379);
            btnDeleteBox.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBox.Name = "btnDeleteBox";
            btnDeleteBox.Size = new Size(123, 39);
            btnDeleteBox.TabIndex = 10;
            btnDeleteBox.Text = "Delete Box";
            btnDeleteBox.UseVisualStyleBackColor = true;
            btnDeleteBox.Click += btnDeleteBox_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(350, 379);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 39);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmBoxPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 440);
            Controls.Add(btnSave);
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnMoveToOutBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDeleteBox;
        private System.Windows.Forms.Button btnSave;
    }
}