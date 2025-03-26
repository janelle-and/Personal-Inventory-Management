using Microsoft.VisualBasic.Devices;

namespace Personal_Inventory_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Box Box1 = new Box("Box1", new List<Tuple<string, Boolean>>());
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box1));
        }

        private Control CreateBoxControl(Box box)
        {
            // Create a new Panel or any other Control to represent the Box
            Panel panel = new Panel();
            panel.Name = box.Name;
            panel.Size = new Size(200, 200);
            panel.BackColor = Color.LightGray;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 100);
            pictureBox.Location = new Point(50, 50);
            // Add additional properties and child controls to the panel as needed

            if (File.Exists(@"C:\\Users\\scemb\\OneDrive\\Pictures\\Random\\uppdatera-storage-box-light-bamboo__1029005_pe835616_s5.avi"))
                pictureBox.Image = Image.FromFile(@"C:\\Users\\scemb\\OneDrive\\Pictures\\Random\\uppdatera-storage-box-light-bamboo__1029005_pe835616_s5.avi");
            
            return panel;


        }
    }
}
