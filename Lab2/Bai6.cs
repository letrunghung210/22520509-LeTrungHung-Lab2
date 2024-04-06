using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab2.Bai6;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        
        public class MonAn
        {
            public int IDMA { get; set; }
            public string TenMonAn { get; set; }
            public string HinhAnh { get; set; }
            public int IDNCC { get; set; }

            public MonAn(int idma, string tenMonAn, string hinhAnh, int idncc)
            {
                IDMA = idma;
                TenMonAn = tenMonAn;
                HinhAnh = hinhAnh;
                IDNCC = idncc;
            }
        }

        public class NguoiDung
        {
            public int IDNCC { get; set; }
            public string HoVaTen { get; set; }
            public string QuyenHan { get; set; }

            public NguoiDung(int idncc, string hoVaTen, string quyenHan)
            {
                IDNCC = idncc;
                HoVaTen = hoVaTen;
                QuyenHan = quyenHan;
            }
        }
        List<MonAn> monan = new List<MonAn>();
        List<NguoiDung> nguoiDungs = new List<NguoiDung>();
        public Bai6()
        {
            InitializeComponent();
            // Add some sample data (replace with your data source)
            monan.Add(new MonAn(1, "Bún chả", @"E:\WinForm\Lab2\Images\buncha.jpg", 1));
            monan.Add(new MonAn(2, "Phở", @"E:\WinForm\Lab2\Images\pho.jpg", 2));
            monan.Add(new MonAn(3, "Bánh mì", @"E:\WinForm\Lab2\Images\banhmi.jpg", 3));

            nguoiDungs.Add(new NguoiDung(1, "Nguyễn Phạm Tiến Đạt", "thành viên rách"));
            nguoiDungs.Add(new NguoiDung(2, "Lưu Quốc Cường", "thành viên kim cương"));
            nguoiDungs.Add(new NguoiDung(3, "Bùi Minh Quân", "thành viên không chính thức"));
            // Configure ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Tên món ăn", 200);
            listView1.Columns.Add("Hình ảnh", 100);

            // Add items to ListView
            FillListView();
        }
        private void FillListView()
        {
            listView1.Items.Clear(); // Clear existing items before adding new ones

            foreach (MonAn item in monan)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.TenMonAn, item.HinhAnh });
                listView1.Items.Add(listViewItem);
            }
        }
 

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRandomDish_Click_1(object sender, EventArgs e)
        {
            if (monan.Count > 0)
            {
                // Get random index
                Random random = new Random();
                int randomIndex = random.Next(monan.Count);

                // Get selected dish and contributor
                MonAn selectedDish = monan[randomIndex];
                
                // Display information (replace with your UI elements)
                lblMonAn.Text = selectedDish.TenMonAn;
                
                int nguoidung = selectedDish.IDNCC;
                if (selectedDish.IDNCC != null)
                {
                    foreach(NguoiDung nd in nguoiDungs)
                    {
                        if (nd.IDNCC == nguoidung)
                        {
                            lblNguoiDung.Text = nd.HoVaTen;
                        }    
                    }   
                }
                
                
                // Load image (replace with your image control)
                if (File.Exists(selectedDish.HinhAnh))
                {
                    pictureBox1.Image = Image.FromFile(selectedDish.HinhAnh);
                }
                else
                {
                    pictureBox1.Image = null; // Handle missing image case
                }
            }
            else
            {
                // Handle no dishes case (display message)
                MessageBox.Show("Không có món ăn nào!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}
