using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApartmentMini_Management_System.themKH;


namespace ApartmentMini_Management_System
{
    public partial class thongTinKh : Form
    {
        public thongTinKh()
        {
            InitializeComponent();
            hdButton1.ForeColor = Color.FromArgb(24, 103, 206);
            hdButton1.SetUnderline(true);
        }
        private Form currentFormChild;

        private void openChildForm(Form childForm, Panel panelBody)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thongTinKh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPARTMENTDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.aPARTMENTDataSet.KHACHHANG);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hdButton1_Click(object sender, EventArgs e)
        {
            hdButton1.ForeColor = Color.FromArgb(24, 103, 206);
            hdButton1.SetUnderline(true);
            hdButton2.ForeColor = Color.FromArgb(91, 106, 130);
            hdButton2.SetUnderline(false);
            hdButton3.ForeColor = Color.FromArgb(91, 106, 130);
            hdButton3.SetUnderline(false);
            // Đóng form con hiện tại nếu có
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild = null;
            }

            // Gọi hàm LoadData khi hdButton1 được nhấn
            LoadData();
        }

        private void hdButton2_Click(object sender, EventArgs e)
        {
            hdButton2.ForeColor = Color.FromArgb(24, 103, 206);
            hdButton2.SetUnderline(true);
            hdButton1.ForeColor = Color.FromArgb(91, 106, 130);
            hdButton1.SetUnderline(false);
            hdButton3.ForeColor = Color.FromArgb(91, 106, 130);
            hdButton3.SetUnderline(false);
            Checker = false;
            openChildForm(new themKH(this), panel1);
            //openChildForm(new hoaDon(), panel1);  
            
        }

        private void hdButton1_MouseEnter(object sender, EventArgs e)
        {
            //hdButton1.BackColor = Color.FromArgb(224, 255, 255);
            //hdButton1.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void hdButton1_MouseLeave(object sender, EventArgs e)
        {
            //hdButton1.BackColor = Color.FromArgb(249, 251, 252);
            //hdButton1.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void hdButton2_MouseEnter(object sender, EventArgs e)
        {
            //hdButton2.BackColor = Color.FromArgb(224, 255, 255);
            //hdButton2.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void hdButton2_MouseLeave(object sender, EventArgs e)
        {
            //hdButton2.BackColor = Color.FromArgb(249, 251, 252);
            //hdButton2.ForeColor = Color.FromArgb(91, 106, 130);
        }
        private void LoadData()
        {
            try
            {
                this.kHACHHANGTableAdapter.Fill(this.aPARTMENTDataSet.KHACHHANG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void hdButton3_MouseEnter(object sender, EventArgs e)
        { 
        }

        private void hdButton3_MouseHover(object sender, EventArgs e)
        { 
        }

        private void hdButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hdButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        { 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

                //hdButton3.ForeColor = Color.FromArgb(24, 103, 206);
                //hdButton3.SetUnderline(true);
                //hdButton1.ForeColor = Color.FromArgb(91, 106, 130);
                //hdButton1.SetUnderline(false);
            
        }

        public void UpdateButton3()
        {
            hdButton3.ForeColor = Color.FromArgb(24, 103, 206);
            hdButton3.SetUnderline(true);
            hdButton1.ForeColor = Color.FromArgb(91, 106, 130);
            hdButton1.SetUnderline(false);
            hdButton2.ForeColor = Color.FromArgb(91, 106, 130);
            hdButton2.SetUnderline(false);
        }

        private void thongTinKh_MouseMove(object sender, MouseEventArgs e)
        {
/*            if (Checker == true)
            {
                hdButton3.ForeColor = Color.FromArgb(24, 103, 206);
                hdButton3.SetUnderline(true);
            }*/
        }
    }
}
