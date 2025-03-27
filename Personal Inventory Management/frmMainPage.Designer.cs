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
            fLayMainDisplay = new System.Windows.Forms.FlowLayoutPanel();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblSearchResult = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // fLayMainDisplay
            // 
            fLayMainDisplay.AutoScroll = true;
            fLayMainDisplay.Location = new System.Drawing.Point(85, 86);
            fLayMainDisplay.Name = "fLayMainDisplay";
            fLayMainDisplay.Size = new System.Drawing.Size(1058, 359);
            fLayMainDisplay.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(925, 488);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(199, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(863, 491);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(58, 528);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(215, 528);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblSearchResult
            // 
            lblSearchResult.AutoSize = true;
            lblSearchResult.Location = new System.Drawing.Point(863, 547);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new System.Drawing.Size(42, 15);
            lblSearchResult.TabIndex = 8;
            lblSearchResult.Text = "Result:";
            // 
            // frmMainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1217, 665);
            Controls.Add(lblSearchResult);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(fLayMainDisplay);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Text = "Personal Inventory Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel fLayMainDisplay;
        private TextBox textBox1;
        private Label label1;
        private Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private Label lblSearchResult;
    }
}
