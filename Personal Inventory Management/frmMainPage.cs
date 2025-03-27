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
            Label txt = new Label();
            txt.Name = "BoxName";
            txt.Text = Box1.Name;
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
            pictureBox.Size = new Size(200,200);
            pictureBox.Location = new Point(0, 10);
            // Add additional properties and child controls to the panel as needed
            string path = "../../../project_Box_2.jpeg";
            if (File.Exists(path))
                pictureBox.Image = Image.FromFile(path);
            panel.Controls.Add(pictureBox);
            return panel;
        }

        //     private void GetCast(int id)
        //     {
        //         using (var context = new MoviesEntities())
        //         {
        //             var Movies = context.movielinkpersons.Where(p => p.movieId == id).ToList();
        //             int i = 1;
        //             foreach (var person in Movies)
        //             {
        //                 string Thumb = "";
        //                 if (person.person.profile_path == "/JohnWayneBig.png")
        //                 {
        //                     Thumb = ImgPath + "JohnWayneSml.png";
        //                     BigPicturePath = ImgPath + "JohnWayneBig.png";
        //
        //                 }
        //                 else
        //                 {
        //                     Thumb = ImgURL + "w45" + person.person.profile_path;
        //                     BigPicturePath = ImgURL + "original" + person.person.profile_path;
        //                 }
        //
        //                 var picture = new PictureBox
        //                 {
        //                     Name = "pictureBox" + i.ToString(),
        //                     Size = new Size(45, 70),
        //
        //
        //                 };
        //                 picture.Tag = BigPicturePath;
        //                 picture.MouseHover += ThumbPictureBox_MouseHover;
        //                 picture.LoadAsync(Thumb);
        //                 flowLayoutPanel1.Controls.Add(picture);
        //                 i++;
        //             }
        //
        //
        //         }
        //     }
        //
        //     private void ThumbPictureBox_MouseHover(object sender, EventArgs e)
        //     {
        //         //BigPicturePath = this.Tag.ToString();
        //         if (BigPicturePath != null)
        //         {
        //             string Orientation = "P";
        //             FilmsDB.PictureForm frm = new PictureForm(Orientation);
        //             frm.SetValues(BigPicturePath);
        //             frm.ShowDialog();
        //         }
        //
        //     }
        // }
    }
}
