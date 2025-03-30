using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
namespace Personal_Inventory_Management {
    public partial class frmMainPage : Form
    {
        /* initialize and display the OutBox on program start */
        static Box OutBox = new Box("OutBox", new List<Tuple<string, bool>>());

        // creating a box sto save initial items
        static Box testBox = new Box("TestBox", new List<Tuple<string, bool>>());

        // creating list of items for the TestBox
        List<Tuple<string, bool>> TestBoxItems = new List<Tuple<string, bool>>()
        {

            new Tuple<string, bool>("Item 1", false),
            new Tuple<string, bool>("Item 2", false),

        };

 


        String OutboxName = OutBox.Name;
        private Dictionary<Panel, Box> _boxPanelsDict; // initialize a dictionary to store the box objects at each panel
        public frmMainPage()
        {
            InitializeComponent(); // start and show the main form
            _boxPanelsDict = new Dictionary<Panel, Box>(); // create the dictionary
            fLayMainDisplay.Controls.Add(CreateBoxControl(OutBox, OutboxName)); // display the OutBox as it should always be there
            fLayMainDisplay.Controls.Add(CreateBoxControl(testBox, testBox.Name)); // display the TestBox as it should always be there
        }
        Box emptyBox = new Box("", new List<Tuple<string, bool>>()); // create an empty box to use with the add button
        private Box _currentBox; // Private backing field for the CurrentBox property
        /* Public property for accessing and setting the _currentBox field */
        public Box CurrentBox
        {
            get { return _currentBox; } // Returns the value of _currentBox
            /* Sets the value of _currentBox if the new value is different from the current one */
            set
            {
                /* Check if the new value is different from the current value */
                if (_currentBox != value)
                {
                    _currentBox = value; // If different, update the private field to the new value
                }
            }
        }
        /* function to handle what happens when the add button on the main form is clicked */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBoxPage addboxpage = new frmBoxPage(emptyBox); // initialize the addboxpage form
            /* handle the logic for using the addboxpage form */
            if (addboxpage.ShowDialog() == DialogResult.OK)
            {
                Box newBox = addboxpage.newBox; // when the form is closed with the save button create a new box
                String newBoxName = newBox.Name; // get the box name
                fLayMainDisplay.Controls.Add(CreateBoxControl(newBox, newBoxName)); // add the box to the flowlayoutpanel
            }
        }
        /* function to handle the logic of adding boxes to the flowlayoutpanel */
        private Control CreateBoxControl(Box box, String boxName)
        {
            /* setup the panel for displaying the box */
            Panel panel = new Panel();
            panel.Name = box.Name;
            panel.Size = new Size(100, 150);
            panel.BackColor = Color.White;
            /* setup the label for the box panel */
            Label boxTitle = new Label();
            boxTitle.Text = boxName;
            boxTitle.Dock = DockStyle.Bottom; // set the label to show at the bottom of the panel
            boxTitle.TextAlign = ContentAlignment.MiddleCenter;
            boxTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            panel.Controls.Add(boxTitle); // add the label to the box panel
            /* setup the picture for the box panel */
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "pictureBox";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // make the image scale with the size of the panel
            pictureBox.Size = new Size(100, 100);
            pictureBox.Location = new Point(0, 0); // make the panels always spawn from top right
            string path = "../../../project_Box_2.jpeg"; // get the path of the picture used in the panel
            /* make sure the picture exists, and if it does use it */
            if (File.Exists(path))
            {
                pictureBox.Image = Image.FromFile(path);
            }
            _boxPanelsDict[panel] = box; // get the box object for the new panel
            panel.Controls.Add(pictureBox); // add the picture to the panel
            panel.Click += new EventHandler(Box_Click); // make the box panel clickable
            /* get the box panel user clicked on from the available panels */
            foreach (Control c in panel.Controls)
            {
                c.Click += new EventHandler(Box_Click); // create an event handler for the click and run the Box_Click function
            }
            return panel; // return the panel so the panel can be displayed
        }
        /* function to handle when the user clicks on a box panel */
        private void Box_Click(object? sender, EventArgs e)
        {
            /* make sure the user clicked on the actual panel */
            if (sender.GetType() != typeof(Panel))
            {
                MessageBox.Show("Please select a box first!"); // show a messagebox telling the user to select a panel
                return; // return from function so nothing happens
            }
            /* Get the Box corresponding to the clicked Panel */
            Panel clickedPanel = sender as Panel; // save the clicked panel as a variable
            Box selectedBox = _boxPanelsDict[clickedPanel]; // Get the box associated with this panel
            frmBoxPage boxPage = new frmBoxPage(selectedBox); // Create a new frmBoxPage to passing the selected Box to be edited
            /* Show the box form and handle the result when the user clicks Save or Cancel */
            DialogResult result = boxPage.ShowDialog(); // Get the result of the dialog
            /*If Cancel was clicked, do not save or update anything */
            if (result == DialogResult.Cancel)
            {
                return; // return from the function so nothing happens
            }
            /* switch case to handle the other dialog results (user actions from the boxPage form) */
            switch (result)
            {
                /* user clicked save */
                case DialogResult.OK:
                    /* only update the panel and box if changes were made */
                    if (selectedBox.Name != boxPage.newBox.Name || !selectedBox.items.SequenceEqual(boxPage.newBox.items))
                    {
                        _boxPanelsDict[clickedPanel] = boxPage.newBox; // Update the box in the dictionary at the selected index
                        Label boxTitle = clickedPanel.Controls.OfType<Label>().FirstOrDefault(); // Update the label for the panel (only matters if name was changed)
                        /* only change box name if the value is not null */
                        if (boxTitle != null)
                        {
                            boxTitle.Text = boxPage.newBox.Name; // set the box name
                        }
                    }
                    break;
                /* user clicked delele box */
                case DialogResult.No:
                    _boxPanelsDict.Remove(clickedPanel); // Remove the box reference from the dictionary
                    fLayMainDisplay.Controls.Remove(clickedPanel); // Remove the panel from the layout
                    break;
            }
            /* user added item to outbox */
            if (boxPage.moved == true)
            {
                /* Only update if changes were made */
                if (selectedBox.Name != boxPage.newBox.Name || !selectedBox.items.SequenceEqual(boxPage.newBox.items))
                {
                    _boxPanelsDict[clickedPanel] = boxPage.newBox; // Update the box in the dictionary
                    fLayMainDisplay.Controls.Remove(clickedPanel); // Remove the outdated panel
                    fLayMainDisplay.Controls.Add(CreateBoxControl(boxPage.newBox, boxPage.newBox.Name)); // Add updated box panel
                }
                /* If the user moved an item to the OutBox, add it to OutBox items */
                if (boxPage.sending != null && boxPage.sending.items.Count > 0)
                {
                    foreach (var item in boxPage.sending.items)
                    {
                        var existingItem = OutBox.items.FirstOrDefault(i => i.Item1 == item.Item1); // Find if the item with the same name already exists in OutBox
                        /* If the item is in the list already, update its boolean value to true */
                        if (existingItem != null)
                        {
                            var index = OutBox.items.IndexOf(existingItem); // get the index of the item
                            OutBox.items[index] = new Tuple<string, bool>(existingItem.Item1, true); // change the tuple to have a true value
                        }
                        else
                        {
                            OutBox.items.Add(item); // If the item doesnt exist, add it to OutBox
                        }
                    }
                }
            }
        }
        /* function to handle when the user clicks the exit button */
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // close the main form when exit button is clicked
        }

        // Searches the Boxes list for which box contains the item and returns the box name in lblResutls label
        private void btnSearch_Click(object sender, EventArgs e)
        {


        }
    }
}