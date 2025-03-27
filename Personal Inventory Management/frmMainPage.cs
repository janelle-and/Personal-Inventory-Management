using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
namespace Personal_Inventory_Management {
    public partial class frmMainPage : Form {
        public frmMainPage() {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            frmBoxPage addboxpage = new frmBoxPage();
            if (addboxpage.ShowDialog() == DialogResult.OK) {
                Box box1 = new Box("box1", new List<Tuple<string, bool>>());
                String boxName1 = box1.Name;
                fLayMainDisplay.Controls.Add(CreateBoxControl(box1,boxName1));
            }
        }
        private Control CreateBoxControl(Box box,String boxName) {
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
            string path = "../../../project_Box_2.jpeg";
            if (File.Exists(path))
                pictureBox.Image = Image.FromFile(path);
            panel.Controls.Add(pictureBox);

            panel.Click += new EventHandler(Box_Click);
            foreach (Control c in panel.Controls)
            {
                c.Click += new EventHandler(Box_Click);
            }
            return panel;
        }

        private void Box_Click(object? sender, EventArgs e)
        {
            frmBoxPage boxPage = new frmBoxPage();
            boxPage.ShowDialog();
        }
    }
}