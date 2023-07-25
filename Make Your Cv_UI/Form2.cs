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
    public partial class Form2 : Form
    {
        private string ImagePath;
        public Form2(string _Phone, string _Email, string _Address, int _UnvirstyDgree
            , int _Specfization, bool _English, bool _Arabic, string _Experiance 
            ,int _Natioanlty,
            string _BirthDay,string _Country,string _City, string _Street,string _ImagePath)
        {
            InitializeComponent();
             mtxtPhone.Text = _Phone;
            txtEmail.Text = _Email;
            txtAddress.Text = _Address;
            cbUniversityDgree.SelectedIndex = _Specfization;
            chbArbic.Checked = _Arabic;
            chbEnglish.Checked = _English;
            mtxtExperiance.Text = _Experiance;
            cbSoecialization.SelectedIndex = _Specfization;
            cbNationality.SelectedIndex = _Natioanlty;
            mtxtBithDate.Text = _BirthDay;
            txtCountry.Text = _Country;
            txtCity.Text = _City;
            txtStreet.Text = _Street;
            ImagePath = _ImagePath;
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(7, 25, 82);

            Pen whitePen = new Pen(White);
            whitePen.Width = 5;
            // whitePen.
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            //draw horizental lines

            e.Graphics.DrawLine(whitePen, 0, 110, 340, 110);
            e.Graphics.DrawLine(whitePen, 0, 199, 338, 199);
            e.Graphics.DrawLine(whitePen, 0, 287, 338, 287);
            e.Graphics.DrawLine(whitePen, 0, 386, 338, 386);
            e.Graphics.DrawRectangle(whitePen, 73, 578, 187, 53);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen whitePen = new Pen(White);
            whitePen.Width = 5;
            // whitePen.
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;


            e.Graphics.DrawRectangle(whitePen, 52, 30, 97, 67);
            e.Graphics.DrawLine(whitePen, 6, 155, 315, 155);
            e.Graphics.DrawLine(whitePen, 6, 438, 315, 438);
            e.Graphics.DrawLine(whitePen, 6, 652, 315, 652);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(ImagePath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
