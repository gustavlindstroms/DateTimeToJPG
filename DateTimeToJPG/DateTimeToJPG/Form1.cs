using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace DateTimeToJPG
{
    public partial class Form1 : Form
    {
        private static Regex r = new Regex(":");
        private string[] filepaths;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.Columns.Add("FilePath", "FilePath");
        }

        private void execute_Btn_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            
            string savePathFullDir = filepaths[1];
            Console.WriteLine(savePathFullDir);
            
            var savePath = Path.GetDirectoryName(savePathFullDir);
            Console.WriteLine(savePath);
            string[] dateTimeArray = GetDateTakenFromImage(filepaths, filepaths.Length);
            for (int i = 0; i < filepaths.Length; i++)
            {
                Bitmap bmp = new Bitmap(filepaths[i]);
                Graphics gra = Graphics.FromImage(bmp);
                gra.DrawString(dateTimeArray[i], new Font("Verdana", 16), Brushes.MediumBlue, new PointF(0, 0));
                bmp.Save(savePath + @"\" + i +".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
               
                
            }
            watch.Stop();
            response_Lbl.Text = $"Operation completed sucessfully in {watch.ElapsedMilliseconds} ms";
        }

        private void select_Folder_Btn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filepaths = Directory.GetFiles(fbd.SelectedPath);

                    int count = filepaths.Count() - 1;
                    
                    
                    for (int i = 0; i < filepaths.Length; i++)
                    {
                        dataGridView1.Rows.Add(new object[] {filepaths[i] });
                    }

                    response_Lbl.Text = count + " files selected in folder";

                }
            }
        }



        public static string[] GetDateTakenFromImage(string[] path, int count)
        {
            string[] dateTimesArray = new string[count];
            for(int i = 0; i < path.Length; i++)
            {
                using (FileStream fs = new FileStream(path[i], FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    string date = DateTime.Parse(dateTaken).ToShortDateString();
                    dateTimesArray[i] = date;
                }
            }
            return dateTimesArray;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string message =
                "Developed by Gustav Lindström. Open Soruce - free use: https://github.com/gustavlindstroms/DateTimeToJPG";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, "",  buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }
    }
}