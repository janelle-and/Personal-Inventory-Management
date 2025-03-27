namespace Personal_Inventory_Management
{
    partial class frmMainPage
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
            fLayMainDisplay = new FlowLayoutPanel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnAdd = new Button();
            btnExit = new Button();
            lblSearchResult = new Label();
            SuspendLayout();
            // 
            // fLayMainDisplay
            // 
            fLayMainDisplay.AutoScroll = true;
            fLayMainDisplay.Location = new Point(85, 86);
            fLayMainDisplay.Name = "fLayMainDisplay";
            fLayMainDisplay.Size = new Size(1058, 359);
            fLayMainDisplay.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(925, 488);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 27);
            txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(863, 491);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(58, 528);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(215, 528);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblSearchResult
            // 
            lblSearchResult.AutoSize = true;
            lblSearchResult.Location = new Point(863, 547);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new Size(52, 20);
            lblSearchResult.TabIndex = 8;
            lblSearchResult.Text = "Result:";
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 665);
            Controls.Add(lblSearchResult);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(fLayMainDisplay);
            Name = "frmMainPage";
            Text = "Personal Inventory Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel fLayMainDisplay;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnAdd;
        private Button btnExit;
        private Label lblSearchResult;
    }
}
