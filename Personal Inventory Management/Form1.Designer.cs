namespace Personal_Inventory_Management
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // fLayMainDisplay
            // 
            fLayMainDisplay.Location = new Point(64, 86);
            fLayMainDisplay.Name = "fLayMainDisplay";
            fLayMainDisplay.Size = new Size(573, 499);
            fLayMainDisplay.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(713, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 382);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 665);
            Controls.Add(groupBox1);
            Controls.Add(fLayMainDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fLayMainDisplay;
        private GroupBox groupBox1;
    }
}
