using System.ComponentModel;

namespace Personal_Inventory_Management;

partial class frmItemData
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lblItemName = new System.Windows.Forms.Label();
        txtItemName = new System.Windows.Forms.TextBox();
        lblItemDescription = new System.Windows.Forms.Label();
        txtItemDescription = new System.Windows.Forms.TextBox();
        lblstatus = new System.Windows.Forms.Label();
        rdbYes = new System.Windows.Forms.RadioButton();
        rdbNo = new System.Windows.Forms.RadioButton();
        btnSave = new System.Windows.Forms.Button();
        btnCancel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblItemName
        // 
        lblItemName.Location = new System.Drawing.Point(12, 12);
        lblItemName.Name = "lblItemName";
        lblItemName.Size = new System.Drawing.Size(78, 23);
        lblItemName.TabIndex = 0;
        lblItemName.Text = "Item Name:";
        // 
        // txtItemName
        // 
        txtItemName.Location = new System.Drawing.Point(118, 12);
        txtItemName.Name = "txtItemName";
        txtItemName.Size = new System.Drawing.Size(183, 23);
        txtItemName.TabIndex = 1;
        // 
        // lblItemDescription
        // 
        lblItemDescription.Location = new System.Drawing.Point(12, 59);
        lblItemDescription.Name = "lblItemDescription";
        lblItemDescription.Size = new System.Drawing.Size(100, 23);
        lblItemDescription.TabIndex = 2;
        lblItemDescription.Text = "Item Description:";
        // 
        // txtItemDescription
        // 
        txtItemDescription.Location = new System.Drawing.Point(118, 59);
        txtItemDescription.Name = "txtItemDescription";
        txtItemDescription.Size = new System.Drawing.Size(183, 23);
        txtItemDescription.TabIndex = 3;
        // 
        // lblstatus
        // 
        lblstatus.Location = new System.Drawing.Point(80, 107);
        lblstatus.Name = "lblstatus";
        lblstatus.Size = new System.Drawing.Size(168, 23);
        lblstatus.TabIndex = 4;
        lblstatus.Text = "Is this item taken out already?";
        // 
        // rdbYes
        // 
        rdbYes.Location = new System.Drawing.Point(103, 133);
        rdbYes.Name = "rdbYes";
        rdbYes.Size = new System.Drawing.Size(47, 24);
        rdbYes.TabIndex = 5;
        rdbYes.TabStop = true;
        rdbYes.Text = "yes";
        rdbYes.UseVisualStyleBackColor = true;
        // 
        // rdbNo
        // 
        rdbNo.Location = new System.Drawing.Point(167, 133);
        rdbNo.Name = "rdbNo";
        rdbNo.Size = new System.Drawing.Size(47, 24);
        rdbNo.TabIndex = 6;
        rdbNo.TabStop = true;
        rdbNo.Text = "No";
        rdbNo.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Location = new System.Drawing.Point(75, 176);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(75, 23);
        btnSave.TabIndex = 7;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new System.Drawing.Point(167, 176);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new System.Drawing.Size(75, 23);
        btnCancel.TabIndex = 8;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // frmItemData
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(322, 221);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(rdbNo);
        Controls.Add(rdbYes);
        Controls.Add(lblstatus);
        Controls.Add(txtItemDescription);
        Controls.Add(lblItemDescription);
        Controls.Add(txtItemName);
        Controls.Add(lblItemName);
        Text = "frmItemData";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblItemName;
    private System.Windows.Forms.TextBox txtItemName;
    private System.Windows.Forms.Label lblItemDescription;
    private System.Windows.Forms.TextBox txtItemDescription;
    private System.Windows.Forms.Label lblstatus;
    private System.Windows.Forms.RadioButton rdbYes;
    private System.Windows.Forms.RadioButton rdbNo;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;

    #endregion
}