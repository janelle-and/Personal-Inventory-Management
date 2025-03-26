using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Personal_Inventory_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Box Box1 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box2 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box3 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box4 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box5 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box6 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box7 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box8 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box9 = new Box("Box1", new List<Tuple<string, Boolean>>());
            Box Box10 = new Box("Box1", new List<Tuple<string, Boolean>>());
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box1));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box2));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box3));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box4));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box5));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box6));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box7));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box8));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box9));
            fLayMainDisplay.Controls.Add(CreateBoxControl(Box10));

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

        //private void GetCast(int id)
        //{
        //    using (var context = new MoviesEntities())
        //    {
        //        var Movies = context.movielinkpersons.Where(p => p.movieId == id).ToList();
        //        int i = 1;
        //        foreach (var person in Movies)
        //        {
        //            string Thumb = "";
        //            if (person.person.profile_path == "/JohnWayneBig.png")
        //            {
        //                Thumb = ImgPath + "JohnWayneSml.png";
        //                BigPicturePath = ImgPath + "JohnWayneBig.png";

        //            }
        //            else
        //            {
        //                Thumb = ImgURL + "w45" + person.person.profile_path;
        //                BigPicturePath = ImgURL + "original" + person.person.profile_path;
        //            }

        //            var picture = new PictureBox
        //            {
        //                Name = "pictureBox" + i.ToString(),
        //                Size = new Size(45, 70),


        //            };
        //            picture.Tag = BigPicturePath;
        //            picture.MouseHover += ThumbPictureBox_MouseHover;
        //            picture.LoadAsync(Thumb);
        //            flowLayoutPanel1.Controls.Add(picture);
        //            i++;
        //        }


        //    }
        //}

        //private void ThumbPictureBox_MouseHover(object sender, EventArgs e)
        //{
        //    //BigPicturePath = this.Tag.ToString();
        //    if (BigPicturePath != null)
        //    {
        //        string Orientation = "P";
        //        FilmsDB.PictureForm frm = new PictureForm(Orientation);
        //        frm.SetValues(BigPicturePath);
        //        frm.ShowDialog();
        //    }

        //}
    }
}
