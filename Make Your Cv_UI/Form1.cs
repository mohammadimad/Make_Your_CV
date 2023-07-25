using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Cv_UI
{
    public partial class Form1 : Form
    {
        stInfo Info;
        public Form1()
        {
            InitializeComponent();
          
        }

       
        struct stInfo {
            public string Address;
            public string Phone;
            public string Email;
            public int Nationalty;
            public int Specialization;
            public int UniverstyDgree;
            public bool Arbic;
            public bool English;
            public string Experiance;
            public string Date;

            public string Country;
            public string City;
            public string Street;
            public string ImagePath;
        }
        
        

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen whitePen = new Pen(White);
            whitePen.Width = 5;
           
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            
            e.Graphics.DrawRectangle(whitePen, 52, 30, 97, 67);
            e.Graphics.DrawLine(whitePen, 6, 155, 315, 155);
            e.Graphics.DrawLine(whitePen, 6, 438, 315, 438);
            e.Graphics.DrawLine(whitePen, 6, 652, 315, 652);

            // e.Graphics.DrawLine(whitePen, 12, 47, 127, 41);


        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File  (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                 Info.ImagePath = openFileDialog.FileName;
               // Form2 form2 = new Form2(imagePath);
                //form2.Show();
            }
            
        }

       

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(7, 25, 82);

            Pen whitePen = new Pen(White);
            whitePen.Width = 5;
            // whitePen.
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            

            e.Graphics.DrawLine(whitePen, 0, 110, 340, 110);
            e.Graphics.DrawLine(whitePen, 0, 199 ,338, 199);
            e.Graphics.DrawLine(whitePen, 0, 287, 338, 287);
            e.Graphics.DrawLine(whitePen, 0, 386, 338, 386);
            e.Graphics.DrawRectangle(whitePen, 5, 559, 145, 53);
            e.Graphics.DrawRectangle(whitePen, 179, 559 , 139, 53);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Info.Address = txtAddress.Text;
            Info.City = txtCity.Text;
            Info.Date = mtxtBithDate.Text;
            Info.Country = txtCountry.Text;
            Info.Email = txtEmail.Text;
            Info.Arbic = chbArbic.Checked;
            Info.English = chbEnglish.Checked;
            Info.Phone = mtxtPhone.Text;
            Info.Experiance = mtxtExperiance.Text;
            Info.Specialization = cbSpecialization.SelectedIndex;
            Info.UniverstyDgree = cbUniversityDgree.SelectedIndex;
            Info.Nationalty = cbNationality.SelectedIndex;
            Info.Street = txtStreet.Text;
            Form2 Form23 = new Form2(Info.Phone, Info.Email, Info.Address,
                Info.UniverstyDgree, Info.Specialization, Info.English, Info.Arbic,
                 Info.Experiance, Info.Nationalty, Info.Date, Info.Country,
                 Info.City,Info.Street,Info.ImagePath);

            Form23.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
             txtAddress.Text = "";
             txtCity.Text = "";
            mtxtBithDate.Text = "";
            txtCountry.Text = "";
            txtEmail.Text = "";
            chbArbic.Checked = false;
            chbEnglish.Checked = false;
            mtxtPhone.Text = "";
            mtxtExperiance.Text = "";
            cbSpecialization.SelectedIndex = 0;
            cbUniversityDgree.SelectedIndex = 0;
            cbNationality.SelectedIndex = 0;
            txtStreet.Text = "";
        }

        
    }
}
