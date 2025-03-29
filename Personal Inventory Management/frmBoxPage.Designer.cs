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
            lblName = new System.Windows.Forms.Label();
            lstItems = new System.Windows.Forms.ListBox();
            btnUpdateItem = new System.Windows.Forms.Button();
            btnDeleteItem = new System.Windows.Forms.Button();
            btnMoveToOutBox = new System.Windows.Forms.Button();
            btnAddItem = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            btnDeleteBox = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(19, 26);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new System.Drawing.Point(19, 51);
            lstItems.Name = "lstItems";
            lstItems.Size = new System.Drawing.Size(208, 214);
            lstItems.TabIndex = 2;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new System.Drawing.Point(248, 109);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new System.Drawing.Size(108, 29);
            btnUpdateItem.TabIndex = 5;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new System.Drawing.Point(248, 173);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new System.Drawing.Size(108, 29);
            btnDeleteItem.TabIndex = 6;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnMoveToOutBox
            // 
            btnMoveToOutBox.Location = new System.Drawing.Point(248, 236);
            btnMoveToOutBox.Name = "btnMoveToOutBox";
            btnMoveToOutBox.Size = new System.Drawing.Size(108, 29);
            btnMoveToOutBox.TabIndex = 7;
            btnMoveToOutBox.Text = "Move To OutBox";
            btnMoveToOutBox.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new System.Drawing.Point(248, 51);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new System.Drawing.Size(108, 29);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(19, 284);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(77, 22);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(150, 23);
            txtName.TabIndex = 0;
            // 
            // btnDeleteBox
            // 
            btnDeleteBox.Location = new System.Drawing.Point(248, 284);
            btnDeleteBox.Name = "btnDeleteBox";
            btnDeleteBox.Size = new System.Drawing.Size(108, 29);
            btnDeleteBox.TabIndex = 10;
            btnDeleteBox.Text = "Delete Box";
            btnDeleteBox.UseVisualStyleBackColor = true;
            btnDeleteBox.Click += btnDeleteBox_Click_1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(120, 284);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "&Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmBoxPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(370, 330);
            Controls.Add(button1);
            Controls.Add(btnDeleteBox);
            Controls.Add(btnCancel);
            Controls.Add(btnAddItem);
            Controls.Add(btnMoveToOutBox);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnUpdateItem);
            Controls.Add(lstItems);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
    }
}