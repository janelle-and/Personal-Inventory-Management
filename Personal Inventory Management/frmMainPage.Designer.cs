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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fLayMainDisplay = new FlowLayoutPanel();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            lblSearchResult = new Label();
            lblResult = new Label();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // fLayMainDisplay
            // 
            fLayMainDisplay.AutoScroll = true;
            fLayMainDisplay.BorderStyle = BorderStyle.FixedSingle;
            fLayMainDisplay.Location = new Point(14, 16);
            fLayMainDisplay.Margin = new Padding(3, 4, 3, 4);
            fLayMainDisplay.Name = "fLayMainDisplay";
            fLayMainDisplay.Size = new Size(1209, 478);
            fLayMainDisplay.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(995, 561);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 556);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 39);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(158, 556);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 39);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblSearchResult
            // 
            lblSearchResult.AutoSize = true;
            lblSearchResult.Location = new Point(903, 631);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new Size(52, 20);
            lblSearchResult.TabIndex = 8;
            lblSearchResult.Text = "Result:";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(995, 631);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(227, 31);
            lblResult.TabIndex = 9;
            lblResult.Text = "This is some placeholder text";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(882, 561);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 713);
            Controls.Add(btnSearch);
            Controls.Add(lblResult);
            Controls.Add(lblSearchResult);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(fLayMainDisplay);
            Name = "frmMainPage";
            Text = "Personal Inventory Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblResult;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLayMainDisplay;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSearchResult;
        private Button btnSearch;
    }
}
