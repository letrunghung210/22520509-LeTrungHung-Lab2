using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Bai5 : Form
    {
        class Phim
        {
            public string TenPhim { get; set; }
            public int GiaVeChuan { get; set; }
            public int[] PhongChieu { get; set; }
            public int SoVeBanRa { get; set; }
            public int SoVeTon { get; set; }
            public double TiLeVeBanRa { get; set; }
            public int DoanhThu { get; set; }
            public int XepHang { get; set; }

            public override string ToString()
            {
                return TenPhim;
            }
        }
        public Bai5()
        {
            InitializeComponent();
        }
        List<Phim> phims = new List<Phim>();
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                phims = JsonSerializer.Deserialize<List<Phim>>(fileStream);
                comboBox1.DataSource = phims;
                comboBox1.DisplayMember = "TenPhim";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write("Phim: '" + comboBox1.SelectedItem.ToString() + "'\n");
                streamWriter.Write("Vé bán ra: " + txtWriteName.Text + "\n");
                streamWriter.Write("Vé tồn: " + txtWriteID.Text + "\n");
                streamWriter.Write("Tỉ lệ vé bán ra: "+ txtWritePhone.Text + "\n");
                streamWriter.Write("Doanh thu: " + txtWriteCourse1.Text + "\n");
                streamWriter.Write("Xếp hạng: " + txtWriteCourse2.Text + "\n");
                streamWriter.Close();
                fileStream.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            double tile = 0;
            int doanhthu = 0;
            if (selectedValue != null)
            {
                switch (selectedValue)
                {
                    case "Spider-Man: No Way Home":
                        txtWriteName.Text = phims[0].SoVeBanRa.ToString();
                        txtWriteID.Text = Convert.ToString(phims[0].SoVeTon);
                        tile = Math.Round((double)phims[0].SoVeBanRa / (phims[0].SoVeBanRa + phims[0].SoVeTon), 2);
                        txtWritePhone.Text = tile.ToString();
                        doanhthu = phims[0].SoVeBanRa * phims[0].GiaVeChuan;
                        txtWriteCourse1.Text = doanhthu.ToString();
                        txtWriteCourse2.Text = Convert.ToString(phims[0].XepHang);

                        break;
                    case "The Batman":
                        txtWriteName.Text = phims[1].SoVeBanRa.ToString();
                        txtWriteID.Text = Convert.ToString(phims[1].SoVeTon);
                        tile = Math.Round((double)phims[1].SoVeBanRa / (phims[1].SoVeBanRa + phims[1].SoVeTon), 2);
                        txtWritePhone.Text = tile.ToString();
                        doanhthu = phims[1].SoVeBanRa * phims[1].GiaVeChuan;
                        txtWriteCourse1.Text = doanhthu.ToString();
                        txtWriteCourse2.Text = Convert.ToString(phims[1].XepHang);
                        break;
                    case "Logan":
                        txtWriteName.Text = phims[2].SoVeBanRa.ToString();
                        txtWriteID.Text = Convert.ToString(phims[2].SoVeTon);
                        tile = Math.Round((double)phims[2].SoVeBanRa / (phims[2].SoVeBanRa + phims[2].SoVeTon), 2);
                        txtWritePhone.Text = tile.ToString();
                        doanhthu = phims[2].SoVeBanRa * phims[2].GiaVeChuan;
                        txtWriteCourse1.Text = doanhthu.ToString();
                        txtWriteCourse2.Text = Convert.ToString(phims[2].XepHang);
                        break;
                    default:
                        
                        break;
                }
            }
        }
        private void lbWriteName_Click(object sender, EventArgs e)
        {

        }

        private void lbWriteCourse3_Click(object sender, EventArgs e)
        {

        }

        private void txtWriteCourse1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbWriteCourse1_Click(object sender, EventArgs e)
        {

        }

        private void txtWriteCourse3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWriteCourse2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbWritePhone_Click(object sender, EventArgs e)
        {

        }

        private void txtWritePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbWriteID_Click(object sender, EventArgs e)
        {

        }

        private void lbWriteCourse2_Click(object sender, EventArgs e)
        {

        }

        private void txtWriteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWriteName_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}