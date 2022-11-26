using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cmd;
using ItachiUIBunifu;

namespace freemusic
{
    public partial class Form1 : Form
    {
        string dir = "",pingtai="wangyiyun",song_name="",song_url="none";
        int error_num = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void write(string dir,string str)
        {
            FileStream fs = new FileStream(dir, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(str);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }



        private string[] read(string dir)
        {
            int s = 0;
            string line = "";
            string[] info = new string[11];
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            while ((line = file.ReadLine()) != null)
            {
                info[s]=line;
                s++;
            }
            file.Close();
            return info;
        }


        private void download(string url,string name,string dir)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(url, name);
            if (dir != "none")
            {
                /*if (System.IO.Directory.Exists(dir)==false)
                {
                    System.IO.Directory.CreateDirectory(dir);
                }*/
                FileInfo fi1 = new FileInfo(name);
                fi1.CopyTo(dir + "\\" + name,true);
            }
        }





        private void showinfo(int num)
        {
            /*
            int x1 = 12, y1 = 42;
            PictureBoxBunifuItachi pb1 = new PictureBoxBunifuItachi();
            pb1.Location = new Point(x1, y1);
            pb1.Width = 33;
            pb1.Height = 33;
            pb1.Image = freemusic.Properties.Resources.music;
            this.Controls.Add(pb1);*/

            int x1 = 12, y1 = 16,x2=51,x3=179,x4=269,x5=322;


            Label lb1 = new Label();
            lb1.Location= new Point(51, 1);
            lb1.Text = "歌曲名称";
            lb1.Font = new Font("宋体", 10, FontStyle.Bold);
            lb1.AutoSize = true;
            panel1.Controls.Add(lb1);

            Label lb2 = new Label();
            lb2.Location = new Point(179, 1);
            lb2.Text = "歌手";
            lb2.Font = new Font("宋体", 10, FontStyle.Bold);
            lb2.AutoSize = true;
            panel1.Controls.Add(lb2);

            Label lb3 = new Label();
            lb3.Location = new Point(269, 1);
            lb3.Text = "时长";
            lb3.Font = new Font("宋体", 10, FontStyle.Bold);
            lb3.AutoSize = true;
            panel1.Controls.Add(lb3);

            Label lb4 = new Label();
            lb4.Location = new Point(322, 1);
            lb4.Text = "专辑";
            lb4.Font = new Font("宋体", 10, FontStyle.Bold);
            lb4.AutoSize = true;
            panel1.Controls.Add(lb4);

            string[] info = read("info.txt");



            for (int i = 1; i <= num; i++)
            {

                string[] tinfo = info[i - 1].Split('|');


                PictureBoxBunifuItachi pb = new PictureBoxBunifuItachi();
                pb.Location= new Point(x1,y1 + 36 * (i - 1));
                pb.Name="pb"+i.ToString();
                pb.Width = 30;
                pb.Height = 30;
                pb.Image = freemusic.Properties.Resources.music;
                panel1.Controls.Add(pb);
                pb.Click += delegate
                {

                    pictureBoxBunifuItachi1.Enabled = true;

                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    string name=tinfo[0].TrimEnd();
                    //MessageBox.Show(pb.Name.ToString());
                    int id = int.Parse(pb.Name.ToString().Substring(pb.Name.ToString().Length - 1, 1));
                    //MessageBox.Show(id.ToString());
                    string[] url = read("url.txt");
                    //MessageBox.Show(url[id - 1]);
                    if (url[id - 1] == "none" || url[id - 1] == "None")
                    {
                        MessageBox.Show("抱歉，由于神秘的原因，该歌曲暂不能播放/下载，请换首下载吧awa");
                    }
                    else
                    {
                        song_name = name+url[id-1].Substring(url[id-1].Length-4);
                        song_url = url[id - 1];
                        char a = (char)(id + '0');
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        download(url[id - 1], name + '-' + a + url[id - 1].Substring(url[id - 1].Length - 4), "download");
                        
                        axWindowsMediaPlayer1.URL = "download\\" + name+'-'+a+url[id-1].Substring(url[id-1].Length-4);
                    }


                };

                


                Label l4 = new Label();
                l4.Location = new Point(x5, y1 +10+ 36 * (i - 1));
                l4.Text = tinfo[3].TrimEnd();
                l4.Font = new Font("宋体", 9, FontStyle.Bold);
                l4.AutoSize = true;
                panel1.Controls.Add(l4);


                Label l3 = new Label();
                l3.Location = new Point(x4, y1 + 10+36 * (i - 1));
                l3.Text = tinfo[2].TrimEnd();
                l3.Font = new Font("宋体", 9, FontStyle.Bold);
                l3.AutoSize = true;
                panel1.Controls.Add(l3);
                l3.Parent = panel1;
                l3.Show();

                Label l2 = new Label();
                l2.Location = new Point(x3, y1 +10+ 36 * (i - 1));
                l2.Text = tinfo[1].TrimEnd();
                l2.Font = new Font("宋体", 9, FontStyle.Bold);
                l2.AutoSize = true;
                panel1.Controls.Add(l2);

                Label l1 = new Label();
                l1.Location = new Point(x2, y1+10+36*(i-1));
                l1.Text = tinfo[0].TrimEnd();
                l1.Font = new Font("宋体", 9, FontStyle.Bold);
                l1.AutoSize = true;
                panel1.Controls.Add(l1);

                


                

            }


        }






        private void cmd(string order)
        {
            CMD c=new CMD();
            string s_c = c.cmd(order);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.enableContextMenu = false;
            comboBox1.Items.Add("网易云");
            pictureBoxBunifuItachi1.Enabled = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "选择下载目录";
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                dir = folderBrowser.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //InitializeComponent();

            panel1.Controls.Clear();


            axWindowsMediaPlayer1.enableContextMenu = false;
            comboBox1.Items.Add("网易云");
            pictureBoxBunifuItachi1.Enabled = false;

            //pictureBoxBunifuItachi1.Enabled = false;

            
            write("search.txt", "");
            write("info.txt", "");
            write("url.txt", "");
            string name = textBox1.Text;
            write("search.txt", name);
            cmd("wangyiyun.exe");
            //System.Diagnostics.Process.Start("wangyiyun.exe");
            string[] info = read("info.txt");
            string[] url = read("url.txt");
            info = info.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            url = url.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            int size_info = info.Length;
            int size_url = url.Length;
            if(size_info == size_url)
            {
                error_num = 0;
                showinfo(size_info);
            }
            else
            {
                /*if (error_num == 4)
                {
                    error_num = 0;
                    MessageBox.Show("自动重试失败，请一段时间后再次手动尝试！");
                    return;
                    goto g1;
                }
                error_num++;*/
                MessageBox.Show("网络错误，即将自动重试（3次以内为正常情况）...");
                Thread.Sleep(1500);
                button1_Click(sender, e);
            }
            //g1: return;
            //url = url.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            //MessageBox.Show(url[0]);
        }

        private void pictureBoxBunifuItachi2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本信息：Musicer v1.1.0 \n----------\nQ：为什么下载正在播放的文件报错？\nA：一般来说是有同名文件，自己修改一下吧。\nQ：为什么有些歌曲无法播放？\nA：核心py程序是xiayouyou博主编写的，我只不过是写了个图形化界面，还是期望能够快点修复吧\n---------\n此外，特别感谢 夏悠悠 博主(https://blog.csdn.net/qq_42730750)提供的py程序。\n----------\nby迷惘   22.4.1");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBunifuItachi1_Click(object sender, EventArgs e)
        {

            if(song_url == "none")
            {
                MessageBox.Show("灰肠抱歉，该歌曲暂时无法下载！");
            }
            else
            {
                if (dir == "")
                {
                    MessageBox.Show("请选择下载目录！");
                }
                else
                {
                    download(song_url, song_name, dir);
                    MessageBox.Show("下载完成！");
                }
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "网易云")
            {
                pingtai = "wangyiyun";
            }
        }
    }
}
