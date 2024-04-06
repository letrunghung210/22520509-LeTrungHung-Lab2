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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                pathdisk = drive.Name;
                TreeNode root = new TreeNode(pathdisk);
                TreeDirectory.Nodes.Add(root);
                if (drive.Name == "E:\\")
                {
                    LoadExplorer(root);
                }
                root.Text = drive.VolumeLabel + " (" + pathdisk + ")";
                root.Name = drive.Name;
            }
        }

        string pathdisk;

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                DirectoryInfo[] listfolder = new DirectoryInfo(root.Text).GetDirectories();
                string[] listfile = Directory.GetFiles(root.Text);
                foreach (string item in listfile)
                {
                    FileInfo file = new FileInfo(item);
                    TreeNode filenode = new TreeNode(item);
                    root.Nodes.Add(filenode);
                    filenode.Name = item;
                    filenode.Text = file.Name;
                }
                foreach (DirectoryInfo item in listfolder)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode folder = new TreeNode(item.FullName);
                        root.Nodes.Add(folder);
                        LoadExplorer(folder);
                        folder.Name = item.FullName;
                        folder.Text = item.Name;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;

            // Duyệt qua các nút con
            while (node != null)
            {
                FileAttributes attr = File.GetAttributes(node.Name);

                // Nếu là thư mục, di chuyển đến thư mục đó
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    
                    return;
                }

                // Di chuyển đến nút con tiếp theo
                node = node.NextNode;
            }
        }

        private void treeDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode node = e.Node;
            FileAttributes attr = File.GetAttributes(node.Name);

            if (!attr.HasFlag(FileAttributes.Directory))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(node.Name);

                    // Xử lý file ảnh
                    if (fileInfo.Extension == ".png" || fileInfo.Extension == ".jpg")
                    {
                        FilePictureContent.Visible = true;
                        txtFileContent.Visible = false;
                        FilePictureContent.Load(node.Name);
                    }

                    // Xử lý file văn bản
                    else if (fileInfo.Extension == ".txt")
                    {
                        FilePictureContent.Visible = false;
                        txtFileContent.Visible = true;

                        using (FileStream fs = new FileStream(node.Name, FileMode.Open, FileAccess.Read))
                        using (StreamReader reader = new StreamReader(fs))
                        {
                            txtFileContent.Text = reader.ReadToEnd();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        
        private void Bai7_Load(object sender, EventArgs e)
        {

        }
    }
}
