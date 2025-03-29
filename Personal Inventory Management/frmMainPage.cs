using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
namespace Personal_Inventory_Management {
    public partial class frmMainPage : Form {
        public frmMainPage() {
            InitializeComponent(); // start and show the main form
            /* initialize and display the OutBox on program start as it should always be there */
            Box OutBox = new Box("OutBox", new List<Tuple<string, bool>>());
            String OutboxName = OutBox.Name;
            fLayMainDisplay.Controls.Add(CreateBoxControl(OutBox,OutboxName));
        }
        frmBoxPage addboxpage = new frmBoxPage(); // initialize the addboxpage form
        /* function to handle what happens when the add button on the main form is clicked */
        private void btnAdd_Click(object sender, EventArgs e) {
            /* handle the logic for using the addboxpage form */
            if (addboxpage.ShowDialog() == DialogResult.OK) {
                Box newBox = addboxpage.newBox; // when the form is closed with the save button create a new box
                String newBoxName = newBox.Name; // get the box name
                fLayMainDisplay.Controls.Add(CreateBoxControl(newBox,newBoxName)); // add the box to the flowlayoutpanel
            }
        }
        /* function to handle the logic of adding boxes to the flowlayoutpanel */
        private Control CreateBoxControl(Box box,String boxName) {
            /* setup the panel for displaying the box */
            Panel panel = new Panel();
            panel.Name = box.Name;
            panel.Size = new Size(100, 150);
            panel.BackColor = Color.LightGray;
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
            pictureBox.Size = new Size(100,100);
            pictureBox.Location = new Point(0, 0); // make the panels always spawn from top right
            string path = "../../../project_Box_2.jpeg"; // get the path of the picture used in the panel
            /* make sure the picture exists, and if it does use it */
            if (File.Exists(path)) {
                pictureBox.Image = Image.FromFile(path);
            }
            panel.Controls.Add(pictureBox); // add the picture to the panel
            panel.Click += new EventHandler(Box_Click); // make the box panel clickable
            /* get the box panel user clicked on from the available panels */
            foreach (Control c in panel.Controls) {
                c.Click += new EventHandler(Box_Click); // create an event handler for the click and run the Box_Click function
            }
            return panel; // return the panel so the panel can be displayed
        }
        private void Box_Click(object? sender, EventArgs e)
        {
            frmBoxPage boxPage = addboxpage; // create a new boxpage when clicking on the box
            /* show the box form and save changes if user clicks save */
            switch (boxPage.ShowDialog()) {
            case DialogResult.OK:
                Box box = new Box("", new List<Tuple<string, bool>>()); // initialize a new box to store the updated version
                box = boxPage.newBox; // save the updated box
                if (box.Name == boxPage.newBox.Name && box.items == boxPage.newBox.items) { return; } // don't remove the panel or create a new one if the boxes are the same (meaning the user hasnt changed anything) and the user clicks save
                fLayMainDisplay.Controls.Remove(sender as Control); // remove the panel for the outdated box
                fLayMainDisplay.Controls.Add(CreateBoxControl(box, box.Name)); // add the updated box
                break;
            case DialogResult.No:
            fLayMainDisplay.Controls.Remove(sender as Control); // remove the panel for the box user wants to delete
            break;
            }
        }
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close(); // close the main form when exit button is clicked
        }
    }
}