using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace video_accurate_cut_and_merge
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txt_period_length_TextChanged(null,null);
            Trace.Listeners.Add(new TextWriterTraceListener("log.log"));
        }

        private DialogResult startOpenFileDialog(string title, bool multiselect, string filter, string fileName)
        {
            openFileDialog1.Title = title;
            openFileDialog1.Multiselect = multiselect;
            openFileDialog1.Filter = filter;
            openFileDialog1.FileName = fileName;
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            return dialogResult;
        }

        private async void  button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = startOpenFileDialog("选择文件", true, "", "");
            if (dialogResult == DialogResult.OK)
            {
                foreach (var item in openFileDialog1.FileNames)
                {


                    Task<string> task = new TaskFactory().StartNew(() =>
                    {
                        string output = String.Empty;

                        Process process = new Process();
                        process.StartInfo.FileName = "ffprobe.exe";
                        process.StartInfo.Arguments = "\"" + item + "\"";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardError = true;

                        process.Start();



                        output = process.StandardError.ReadToEnd();

                        process.WaitForExit();
                        process.Close();

                        output = output.Substring(output.IndexOf("Duration:") + 10, 11);
                        return output;
                    });
                    await task;

                    lb_cut.Items.Add(item+"@"+task.Result);

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lb_cut.SelectedIndex == -1)
                return;
            lb_cut.Items.RemoveAt(lb_cut.SelectedIndex);
        }

        private async void  button1_Click(object sender, EventArgs e)
        {

            lbl_success_cut.Visible = false;
            pgb_cut_list.Maximum = lb_cut.Items.Count;
            lbl_cut_num_list.Text = pgb_cut_list.Value + "/" + pgb_cut_list.Maximum;
            pgb_cut_list.Value = 0;
            pgb_cut_period.Value = 0;


            foreach (string item in lb_cut.Items)
            {
                string[] tmp = item.Split('@');
                string filename = Path.GetFileNameWithoutExtension(tmp[0]);
                tmp[1] = tmp[1].Substring(0, 8);
                DateTime length = Convert.ToDateTime(tmp[1]);
                int period_count = (length.Hour * 3600 + length.Minute * 60 + length.Second) / Convert.ToInt32(txt_period_length.Text);
                int remain = (length.Hour * 3600 + length.Minute * 60 + length.Second) % Convert.ToInt32(txt_period_length.Text);
                DateTime current_period = Convert.ToDateTime("00:00:00");
                DateTime next_period = current_period.AddSeconds(Convert.ToInt32(txt_period_length.Text));

                pgb_cut_period.Maximum = period_count;
                pgb_cut_period.Value = 0;
                if (chk_cut_autoCreateFolder.Checked)
                {
                    Directory.CreateDirectory(filename);
                }
                for (int i = 0; i <= period_count; i++)
                {



                    Task task = new TaskFactory().StartNew(() =>
                  {
                      if (i == period_count)
                          next_period = current_period.AddSeconds(remain);

                      string outpath="";
                      if(txt_outPath_cut.Text=="@")
                      {
                          outpath = Path.GetDirectoryName(item)+@"\";
                      }
                      else if(txt_outPath_cut.Text!="")
                      {
                          outpath=txt_outPath_cut.Text+@"\";
                      }
                      if (chk_cut_autoCreateFolder.Checked)
                      {
                          outpath += filename + @"\";
                      }
                      outpath += filename + "_" + i.ToString() + Path.GetExtension(tmp[0]);


                      using (Process process = new Process())
                      {
                          process.StartInfo.FileName = "ffmpeg.exe";
                          process.StartInfo.Arguments = String.Format("-i \"{0}\" -ss {1} -to {2} -c copy \"{3}\" -y", tmp[0], current_period.ToLongTimeString(), next_period.ToLongTimeString(), outpath);
                          process.StartInfo.UseShellExecute = false;
                          process.StartInfo.CreateNoWindow = true;
                          process.StartInfo.RedirectStandardOutput = true;
                          process.StartInfo.RedirectStandardError = true;


                          process.Start();
                          Trace.WriteLine("-----------------new task-------------------");
                          Trace.WriteLine("Arguments:" + process.StartInfo.Arguments);
                          Trace.WriteLine("");
                          Trace.WriteLine(process.StandardError.ReadToEnd());
                          Trace.Flush();
                          process.WaitForExit();

                          if(txt_cut_extraName.Text!="")
                          {
                              string useExtraName = "." + txt_cut_extraName.Text;
                              string newoutpath = Path.GetDirectoryName((outpath) + @"\" + Path.GetFileNameWithoutExtension(outpath) + useExtraName);
                              FileInfo fileInfo = new FileInfo(outpath);
                              if (File.Exists(newoutpath))
                                  File.Delete(newoutpath);
                              fileInfo.MoveTo(newoutpath);
                              current_period = next_period;
                              next_period = current_period.AddSeconds(Convert.ToInt32(txt_period_length.Text));
                          }
                          

                      }
                  });
                    await task;
                    if (pgb_cut_period.Value < pgb_cut_period.Maximum)
                    {
                        pgb_cut_period.Value++;
                    }
                    lbl_cut_num_period.Text = pgb_cut_period.Value + "/" + pgb_cut_period.Maximum;

                }
                if (pgb_cut_list.Value < pgb_cut_list.Maximum)
                {
                    pgb_cut_list.Value++;
                }
                lbl_cut_num_list.Text = pgb_cut_list.Value + "/" + pgb_cut_list.Maximum;
            }
            lbl_success_cut.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (startOpenFileDialog("选择文件",false,"","") == DialogResult.OK)
            {
                string filename = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                string mainname = filename.Substring(0, filename.LastIndexOf('_'));

                DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(openFileDialog1.FileName));



                foreach (FileInfo item in directoryInfo.GetFiles())
                {
                    if (item.Extension != Path.GetExtension(openFileDialog1.FileName))
                        continue;
                    try
                    {
                        string item_filename = Path.GetFileNameWithoutExtension(item.Name);
                        string item_mainname = item_filename.Substring(0, item_filename.LastIndexOf('_'));

                        if (item_mainname == mainname)
                            lb_merge.Items.Add(item);
                    }
                    catch (Exception)
                    {
                    }
                    
                }

            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            pgb_period_merge.Value = 0;
            timer1.Start();
            lbl_success_merge.Visible = false;


            FileStream fileStream = new FileStream("tmp.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);


            foreach (FileInfo item in lb_merge.Items)
            {
                if(chk_extraName_repair.Checked && item.Extension == "."+txt_extraName_old.Text)
                {
                    item.MoveTo(item.DirectoryName + @"\" + Path.GetFileNameWithoutExtension(item.Name) + "." + txt_extraName_new.Text);
                }
                streamWriter.WriteLine("file '" + item.FullName + "'");
            }

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();


            string outpath = "";
            if (txt_outpath_merge.Text == "@")
            {
                outpath =((FileInfo)lb_merge.Items[0]).DirectoryName + @"\";
            }
            else if (txt_outpath_merge.Text != "")
            {
                outpath = txt_outPath_cut.Text + @"\";
            }
            //获取名称
            outpath +=Path.GetFileNameWithoutExtension(((FileInfo)lb_merge.Items[0]).Name).Substring(0, Path.GetFileNameWithoutExtension(((FileInfo)lb_merge.Items[0]).Name).LastIndexOf('_'));
            outpath +=chk_extraName_repair.Checked?"." + txt_extraName_new.Text: ((FileInfo)lb_merge.Items[0]).Extension;

            Task task = new TaskFactory().StartNew(() =>
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "ffmpeg.exe";
                    process.StartInfo.Arguments = String.Format("-f concat -safe 0 -i tmp.txt -y -c copy \"{0}\"", outpath);
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;


                    process.Start();
                    Trace.WriteLine("-----------------new task-------------------");
                    Trace.WriteLine("Arguments:" + process.StartInfo.Arguments);
                    Trace.WriteLine("");
                    Trace.WriteLine(process.StandardError.ReadToEnd());
                    Trace.Flush();
                    process.WaitForExit();

                }
            });
            await task;
            timer1.Stop();
            pgb_period_merge.Value = pgb_period_merge.Maximum;

            try
            {
                File.Delete("tmp.txt");
            }
            catch (Exception)
            { }
            lbl_success_merge.Visible = true;
            if (!chk_merge_deleteSource.Checked)
                return;
            try
            {
                foreach (FileInfo item in lb_merge.Items)
                {
                    File.Delete(chk_extraName_repair.Checked ? (item.DirectoryName + @"\" + Path.GetFileNameWithoutExtension(item.Name) + "." + txt_extraName_new.Text) :(item.FullName));
                }
            }
            catch (Exception ex)
            {
                lbl_statue_2.Text = "删除时出错:" + ex.Message;
            }
            
        }

        private void txt_period_length_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_each_period_length.Text = DateTime.Parse("00:00:00").AddSeconds(Convert.ToInt32(txt_period_length.Text)).ToLongTimeString();
                btn_cut.Enabled = true;
            }
            catch (Exception)
            {
                lbl_each_period_length.Text = "error";
                btn_cut.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txt_outPath_cut.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_outpath_merge.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_extraName_old.Enabled = chk_extraName_repair.Checked;
            txt_extraName_new.Enabled = chk_extraName_repair.Checked;
        }

        private void chk_openLog_cut_CheckedChanged(object sender, EventArgs e)
        {
            //if (chk_openLog_cut.Checked)
            //    logform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pgb_period_merge.Value>= pgb_period_merge.Maximum* 0.65)
            {
                pgb_period_merge.Value += 4;
            }
            else if(pgb_period_merge.Value >= pgb_period_merge.Maximum*0.9)
            {
                pgb_period_merge.Value += 1;
            }
            else if(pgb_period_merge.Value>= pgb_period_merge.Maximum*0.95)
            {
                timer1.Stop();
            }
            else
            {
                pgb_period_merge.Value += 12;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(startOpenFileDialog("选择文件", true, "", "")==DialogResult.OK)
            {
                foreach (var item in openFileDialog1.FileNames)
                {

                    try
                    {
                        if (Int32.TryParse(item.Substring(item.LastIndexOf('_') + 1, item.LastIndexOf('.') - item.LastIndexOf('_') - 1), out int i))
                            lb_merge.Items.Add(new FileInfo(item));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lb_merge.SelectedIndex == -1)
                return;
            lb_merge.Items.RemoveAt(lb_merge.SelectedIndex);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lb_merge.SelectedIndex <= 0)
                return;
            string tmp = lb_merge.Items[lb_merge.SelectedIndex-1].ToString();
            lb_merge.Items[lb_merge.SelectedIndex - 1] = new FileInfo(lb_merge.Items[lb_merge.SelectedIndex].ToString());
            lb_merge.Items[lb_merge.SelectedIndex] = new FileInfo(tmp);
            lb_merge.SelectedIndex--;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lb_merge.SelectedIndex == lb_merge.Items.Count-1)
                return;
            string tmp = lb_merge.Items[lb_merge.SelectedIndex + 1].ToString();
            lb_merge.Items[lb_merge.SelectedIndex + 1] = new FileInfo(lb_merge.Items[lb_merge.SelectedIndex].ToString());
            lb_merge.Items[lb_merge.SelectedIndex] = new FileInfo(tmp);
            lb_merge.SelectedIndex++;
        }

        private void lb_merge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_merge_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lb_merge.Items[lb_merge.SelectedIndex].ToString());
        }

        private void lb_cut_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(lb_cut.Items[lb_cut.SelectedIndex].ToString());
        }

        private void lb_cut_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private async void lb_cut_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    Task<string> task = new TaskFactory().StartNew(() =>
                    {
                        string output = String.Empty;

                        Process process = new Process();
                        process.StartInfo.FileName = "ffprobe.exe";
                        process.StartInfo.Arguments = "\"" + item + "\"";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardError = true;

                        process.Start();



                        output = process.StandardError.ReadToEnd();

                        process.WaitForExit();
                        process.Close();

                        output = output.Substring(output.IndexOf("Duration:") + 10, 11);
                        return output;
                    });
                    await task;

                    lb_cut.Items.Add(item + "@" + task.Result);
                }
            }
        }

        private void lb_merge_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lb_merge_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    try
                    {
                        if (Int32.TryParse(item.Substring(item.LastIndexOf('_') + 1, item.LastIndexOf('.') - item.LastIndexOf('_') - 1), out int i))
                            lb_merge.Items.Add(new FileInfo(item));
                    }
                    catch (Exception)
                    {
                    }
                    
                }
            }

        }
    }




}
