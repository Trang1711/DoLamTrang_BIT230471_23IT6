using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KetnoiCSDL
{
    public partial class Form1 : Form
    {
        string connectstring = @"Data Source=EMBEHAYKHOC\SQLEXPRESS;Initial Catalog=KetnoiCSDL;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            // Khởi tạo SqlConnection trong constructor
            con = new SqlConnection(connectstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Student", con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa DataTable trước khi điền dữ liệu mới
                adt.Fill(dt);
                dataGridView2.DataSource = dt;
                // đổi khung màu hồng nè
                dataGridView2.BackgroundColor= Color.LightPink;
                // đổi màu nền
                dataGridView2.DefaultCellStyle.BackColor = Color.Pink;
                dataGridView2.DefaultCellStyle.SelectionBackColor = Color.Pink;
                // đổi màu nền và màu chữ của tiêu đề cột
                dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.HotPink;
                dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                // Đảm bảo thay đổi được áp dụng
                dataGridView2.EnableHeadersVisualStyles = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
