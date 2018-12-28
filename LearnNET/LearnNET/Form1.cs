using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 执行动作:耗时而已
        /// </summary>
        private void TestThread0()
        {
            Console.WriteLine("Thread Start：The name of Thread is :{0}，current time is : {1},", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
            long sum = 0;
            for (int i = 1; i < 999999999; i++)
            {
                sum += i;
            }
            Console.WriteLine("Thread end：The name of Thread is :{0}，current time is : {1}", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"));
        }

        /// <summary>
        /// 执行动作:耗时而已
        /// </summary>
        private void TestThread(string threadName)
        {
            Console.WriteLine("Thread Start：The name of Thread is ：{2}，the id of current thread is :{0}，current time is : {1},", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName);
            long sum = 0;
            for (int i = 1; i < 999999999; i++)
            {
                sum += i;
            }
            Console.WriteLine("Thread end：The name of Thread is ：{2}，the id of current thread is :{0}，current time is : {1}", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName);
        }

        /// <summary>
        /// 执行动作:耗时而已
        /// </summary>
        private void TestThread2(string threadName1, string threadName2)
        {
            Console.WriteLine("Thread Start：The name of Thread is ：{2} and {3}，the id of current thread is :{0}，current time is : {1},", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName1, threadName2);
            long sum = 0;
            for (int i = 1; i < 999999999; i++)
            {
                sum += i;
            }
            Console.WriteLine("Thread end：The name of Thread is ：{2} and {3}，the id of current thread is : {0}，current time is ： {1}", System.Threading.Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), threadName1, threadName2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            Action<string, string> myFunc = TestThread2;
            
            for (int i=0; i<5; i++)
            {
                string name = string.Format("Button1_Click{0}", i);
                myFunc.Invoke(name, name);
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region 2 BeginInvoke
            // first example
            {
                Action<string, string> myFunc = TestThread2;

                for (int i = 0; i < 5; i++)
                {
                    string name = string.Format("button2_Click{0}", i);
                    myFunc.BeginInvoke(name, name, null, null);
                }
            }
/*
            // second example
            {
                for (int i = 0; i < 5; i++)
                {
                    string name = string.Format("button2_Click{0}", i);
                    Action myFunc = () =>
                    {
                        TestThread2(name, name);
                    };
                    myFunc.BeginInvoke(null, null);
                }
            }
            */
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("----------------- button3_Click Start The id of main thread is ：{0}  --------------------------", Thread.CurrentThread.ManagedThreadId);

            Action<string> myFunc = this.TestThread;
            IAsyncResult asyncResult = null;
            //参数说明：前面几个参数都是方法的参数值，倒数第二个为异步调用的回调函数，倒数第一个为传给回调函数的参数
            for (int i = 0; i < 1; i++)
            {
                string name = string.Format("button1_Click{0}", i);
                asyncResult = myFunc.BeginInvoke(name, t =>
                {
                    Console.WriteLine("The Callback of thread {0}", Thread.CurrentThread.ManagedThreadId);
                    //用 t.AsyncState 来获取回调传进来的参数
                    Console.WriteLine("The inpur parameter of callback：{0}", t.AsyncState);

                    //测试一下异步返回值的结果
                    Console.WriteLine("the return value of AsyncResult is ：{0}", t.Equals(asyncResult));
                }, "maru");
            }

            watch.Stop();
            Console.WriteLine("----------------- button1_Click end The id of main thread is ：{0}  the eclapsed time is ：{1}--------------------------", Thread.CurrentThread.ManagedThreadId, watch.ElapsedMilliseconds);
        }
    }
}
