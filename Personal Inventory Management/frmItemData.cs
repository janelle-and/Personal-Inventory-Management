namespace Personal_Inventory_Management;
public partial class frmItemData : Form
{
    /* initialize public variables for the info so it can be passed the the calling form */
    public string itemname = "";
    public string itemdesc = "";
    public bool status = false;
    public frmItemData(Box? box) {
        InitializeComponent();
    }
    /* function to handle when the user clicks the save button */
    private void btnSave_Click(object sender, EventArgs e) {
        /* check if the item name is empty */
        if (string.IsNullOrEmpty(txtItemName.Text)) {
            MessageBox.Show("Please enter an item name."); // display a messagebox telling the user to enter an item name if its empty
            return; // return from the function so the form doesnt close and the user can make the required changes
        }
        /* make sure at least one radio button is clicked */
        if (rdbNo.Checked == false && rdbYes.Checked == false) {
            MessageBox.Show("Please choose a status");
            return;
        }
        /* store the values */
        itemname = txtItemName.Text;
        itemdesc = txtItemDescription.Text;
        /* check which radio button is checked and change status accordingly */
        if (rdbNo.Checked) { status = false; }
        else { status = true; }
        DialogResult = DialogResult.OK;
        this.Close();
    }
    /* function to handle when the user clicks the cancel button */
    private void btnCancel_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel; // set the dialog result to cancel which is handled in the calling form
        this.Close(); // close the window
    }
}