
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GUIAsyncDownload
{
    public partial class Form1 : Form
    {
        //在下载窗体上面 建一个委托
        public delegate void ChangeProgress(int value); //进度条
        public delegate void ChangeButton(int value); //按钮
        //创建上面的委托的变量
        public ChangeProgress changeProgerss;
        public ChangeButton changebtn;

        public Form1()
        {
            InitializeComponent();
            //为这个委托变量赋值
            changeProgerss = FunChangeProgress;
            changebtn = FunChangebutton;
        }

        //通过创建工作线程消除用户界面线程的阻塞问题 
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //新创建一个线程
            System.Threading.Thread thr = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(Download));
            thr.Start();
        }

        //线程方法 一定要是object 类型参数 同时返回值是void
        private void Download(object obj)
        {
            for (int i = 0; i <= 100; i++)
            {
                //执行委托 更新按钮  -重点
                this.button1.Invoke(changebtn, i);
                //执行委托 更新进度条  -重点
                this.progressBar1.Invoke(changeProgerss, i);
                System.Threading.Thread.Sleep(100);
            }
        }

        //更新进度条
        public void FunChangeProgress(int value)
        {
            progressBar1.Value = value;
        }

        //更新按钮
        public void FunChangebutton(int value)
        {
            if (value == 100)
            {
                button1.Text = "开始新进程";
                button1.Enabled = true;
            }
            else
            {
                //相除保留两位小数 且四舍五入 Math.Round(1.00 * value / 100, 2,MidpointRounding.AwayFromZero)
                button1.Text = Math.Round(1.00 * value / 100, 2, MidpointRounding.AwayFromZero) * 100 + "%";
            }
        }

        //窗体关闭 强制退出 销毁所有相关进程
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //强制退出 销毁进程
            System.Environment.Exit(System.Environment.ExitCode);
            this.Dispose();
            this.Close();
        }
    }
}