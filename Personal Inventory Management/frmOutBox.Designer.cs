namespace Personal_Inventory_Management
{
    partial class frmOutBox
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
            lstOutItems = new ListBox();
            btnReturnItem = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstOutItems
            // 
            lstOutItems.FormattingEnabled = true;
            lstOutItems.Location = new Point(47, 65);
            lstOutItems.Name = "lstOutItems";
            lstOutItems.Size = new Size(562, 304);
            lstOutItems.TabIndex = 0;
            // 
            // btnReturnItem
            // 
            btnReturnItem.Location = new Point(665, 165);
            btnReturnItem.Name = "btnReturnItem";
            btnReturnItem.Size = new Size(94, 29);
            btnReturnItem.TabIndex = 1;
            btnReturnItem.Text = "&Return Item";
            btnReturnItem.UseVisualStyleBackColor = true;
            btnReturnItem.Click += btnReturnItem_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(665, 264);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(665, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 4;
            label1.Text = "Items out of their box:";
            // 
            // frmOutBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnReturnItem);
            Controls.Add(lstOutItems);
            Name = "frmOutBox";
            Text = "OutBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOutItems;
        private Button btnReturnItem;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
    }
}