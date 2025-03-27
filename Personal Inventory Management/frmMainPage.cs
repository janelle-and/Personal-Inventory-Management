using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Personal_Inventory_Management
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
            Box Box1 = new Box("Box1", new List<Tuple<string, Boolean>>());
            string txt = Box1.Name;
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box1,txt));
        }

        private Control CreateBoxControl(Box box,String boxName)
        {
            // Create a new Panel or any other Control to represent the Box
            Panel panel = new Panel();
            panel.Name = box.Name;
            panel.Size = new Size(100, 150);
            panel.BackColor = Color.LightGray;
            Label boxTitle = new Label();
            boxTitle.Text = boxName;
            boxTitle.Dock = DockStyle.Bottom;
            panel.Controls.Add(boxTitle);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "pictureBox";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(100,100);
            pictureBox.Location = new Point(0, 0);
            // Add additional properties and child controls to the panel as needed
            string path = "../../../project_Box_2.jpeg";
            if (File.Exists(path))
                pictureBox.Image = Image.FromFile(path);
            panel.Controls.Add(pictureBox);
            return panel;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}