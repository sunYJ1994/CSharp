using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimilarPhoto;

namespace GraphIndex
{
    public struct IndexResult
    {
        public string fileName;
        public int pixelCount;
        public string dirPath;
        public string sourcePath;
    };

    public partial class GraphIndex : Form
    {
        private List<IndexResult> indexResults = new List<IndexResult>();
        private IndexResult[] indexResultsArr;
        private int indexPic = 0;
        private string fileName = "";
        private string fileDir = "";
        private string extension = "";
        private string direPath = "";

        public GraphIndex()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(Application.StartupPath + "/config.ini");
            string history_image_dir = sr.ReadLine();
            string history_image = sr.ReadLine();
            string history_imgae_extension = sr.ReadLine();
            string history_dir = sr.ReadLine();
            sr.Close();

            if (!history_image_dir.Equals("null"))
                fileDir = history_image_dir;
            else
                fileDir = Application.StartupPath;

            if (!history_image.Equals("null") && !history_imgae_extension.Equals("null"))
            {
                if (File.Exists(history_image))
                {
                    fileName = history_image;
                    extension = history_imgae_extension;
                    source_pic_box.ImageLocation = fileName;
                }
            }

            if (!history_dir.Equals("null"))
            {
                if (Directory.Exists(history_dir))
                {
                    direPath = history_dir;
                    index_path_lab.Text = direPath;
                }
            }
        }

        private void select_pic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = fileDir;
            ofd.Title = "Select your source Image";
            ofd.Filter = "PNG文件|*.png|JPG文件|*.jpg|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                extension = Path.GetExtension(fileName);
                fileDir = Path.GetDirectoryName(fileName);
                source_pic_box.ImageLocation = fileName;
            }
        }

        private void select_dir_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = direPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                direPath = fbd.SelectedPath;
                index_path_lab.Text = direPath;
            }
        }

        private void start_index_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("请选择源文件");
                return;
            }
            if (string.IsNullOrEmpty(direPath))
            {
                MessageBox.Show("请选择搜索的目录");
                return;
            }
            Thread thread = new Thread(ThreadX);
            thread.IsBackground = true;
            thread.Start();
            UnLock(false);

            StreamWriter sw = new StreamWriter(Application.StartupPath + "/config.ini");
            sw.WriteLine(fileDir);
            sw.WriteLine(fileName);
            sw.WriteLine(extension);
            sw.WriteLine(direPath);
            sw.Flush();
            sw.Close();
        }

        void UnLock(bool unlock)
        {
            if (unlock)
            {
                select_pic_btn.Enabled = true;
                select_dir_btn.Enabled = true;
                start_index_btn.Enabled = true;
                pre_pic_btn.Enabled = true;
                pre_next_btn.Enabled = true;
                index_pic_box.Enabled = true;
                last_image_btn.Enabled = true;
                first_image_btn.Enabled = true;
                open_dir_btn.Enabled = true;
                copy_name_btn.Enabled = true;
                copy_path_btn.Enabled = true;
            }
            else
            {
                select_pic_btn.Enabled = false;
                select_dir_btn.Enabled = false;
                start_index_btn.Enabled = false;
                pre_pic_btn.Enabled = false;
                pre_next_btn.Enabled = false;
                index_pic_box.Enabled = false;
                last_image_btn.Enabled = false;
                first_image_btn.Enabled = false;
                open_dir_btn.Enabled = false;
                copy_name_btn.Enabled = false;
                copy_path_btn.Enabled = false;
            }
        }

        void ThreadX()
        {
            IndexResult[] irs = IndexFiles().ToArray();
            indexResultsArr = Sort(irs);
            UnLock(true);
            indexPic = 0;
            ShowIndexImage(indexPic);
        }

        void ShowIndexImage(int index, int position = 0)
        {
            if (indexResultsArr == null)
            {
                MessageBox.Show("还没有数据");
                return;
            }
            else if (index < 0 || index > indexResultsArr.Length - 1)
            {

                MessageBox.Show("没有更多的数据了");
                return;
            }
            if (position == 1)
            {
                index = indexResultsArr.Length - 1;
            }
            indexPic = index;
            IndexResult ir = indexResultsArr[index];
            pixel_count_lab.Text = "Same Pixel:" + ir.pixelCount;
            index_result_path_lab.Text = ir.sourcePath;
            index_pic_box.ImageLocation = ir.sourcePath;
        }

        IndexResult[] Sort(IndexResult[] _irs)
        {
            IndexResult ir;
            for (int i = 0; i < _irs.Length; i++)
            {
                for (int j = i + 1; j < _irs.Length; j++)
                {
                    if (_irs[j].pixelCount > _irs[i].pixelCount)
                    {
                        ir = _irs[i];
                        _irs[i] = _irs[j];
                        _irs[j] = ir;
                    }
                }
            }

            return _irs;
        }

        List<IndexResult> IndexFiles()
        {
            SimilarPhotoClass sourceSpc = new SimilarPhotoClass(fileName);
            string sourceHash = sourceSpc.GetHash();
            SimilarPhotoClass targetSpc = null;
            string targetHash = "";
            indexResults.Clear();
            DirectoryInfo di = new DirectoryInfo(direPath);
            FileInfo[] files = di.GetFiles("*.*", SearchOption.AllDirectories);
            searching_bar.Maximum = files.Length;
            searching_bar.Minimum = 1;
            int progress = 1;
            foreach (FileInfo outin in files)
            {
                searching_bar.Value = progress;
                progress++;
                if (!outin.Extension.Equals(extension))
                    continue;
                targetSpc = new SimilarPhotoClass(outin.FullName);
                targetHash = targetSpc.GetHash();
                IndexResult ir;
                ir.fileName = outin.Name;
                ir.pixelCount = SimilarPhotoClass.CalcSimilarDegree(sourceHash, targetHash);
                ir.sourcePath = outin.FullName;
                ir.dirPath = outin.DirectoryName;
                
                indexResults.Add(ir);

            }

            return indexResults;
        }

        private void pre_pic_btn_Click(object sender, EventArgs e)
        {
            int t_index = indexPic;
            ShowIndexImage(--t_index);
        }

        private void pre_next_btn_Click(object sender, EventArgs e)
        {
            int t_index = indexPic;
            ShowIndexImage(++t_index);
        }

        private void open_index_result_btn_Click(object sender, EventArgs e)
        {
            if (indexResultsArr == null)
            {
                SearchAfterMessage();
                return;
            }
            if (indexPic > indexResultsArr.Length - 1)
            {
                MessageBox.Show("没有更多的数据了");
            }
            System.Diagnostics.Process.Start(indexResultsArr[indexPic].sourcePath);
        }

        public static bool ImageCompareString(Bitmap firstImage, Bitmap secondImage)
        {
            MemoryStream ms = new MemoryStream();
            firstImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            String firstBitmap = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;

            secondImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            String secondBitmap = Convert.ToBase64String(ms.ToArray());

            if (firstBitmap.Equals(secondBitmap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void copy_index_result_path(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(index_path_lab.Text.ToString()) || indexResultsArr == null)
            {
                SearchAfterMessage();
                return;
            }
            Clipboard.SetDataObject(index_result_path_lab.Text);
        }

        private void copy_path_btn_Click(object sender, EventArgs e)
        {
            copy_index_result_path(null, null);
        }

        private void copy_name_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(index_path_lab.Text.ToString()) || indexResultsArr == null)
            {
                SearchAfterMessage();
                return;
            }
            Clipboard.SetDataObject(indexResultsArr[indexPic].fileName);
        }

        private void first_image_btn_Click(object sender, EventArgs e)
        {
            ShowIndexImage(0, 0);
        }

        private void last_image_btn_Click(object sender, EventArgs e)
        {
            ShowIndexImage(0, 1);
        }

        private void open_dir_btn_Click(object sender, EventArgs e)
        {
            if (indexResultsArr == null)
            {
                SearchAfterMessage();
                return;
            }
            System.Diagnostics.Process.Start(indexResultsArr[indexPic].dirPath);
        }

        void SearchAfterMessage()
        {
            MessageBox.Show("请在搜索后执行此操作");
        }
    }
}
