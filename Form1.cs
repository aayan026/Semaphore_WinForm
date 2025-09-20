
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaphore_hw_WinForm
{
    public partial class Form1 : Form
    {
        private int threadCounter = 0;
        private Semaphore semaphore;
        public object lockObj = new object();
        public Form1()
        {
            InitializeComponent();
            semaphore = new Semaphore((int)numericUpDown1.Value, (int)numericUpDown1.Value);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddToList(ListBox list, string text)
        {
            if (list.InvokeRequired)
            {
                list.Invoke(new Action(() => list.Items.Add(text)));
            }
            else
            {
                list.Items.Add(text);
            }
        }
        private void RemoveFromList(ListBox list, string text)
        {
            if (list.InvokeRequired)
            {
                list.Invoke(new Action(() => list.Items.Remove(text)));
            }
            else
            {
                list.Items.Remove(text);
            }
        }
        //muellim siz dediyiniz kimi isleyir ama niyese ele bilirem hersey sehvdi
        private void CreatedThreads_DoubleClick(object sender, EventArgs e)
        {
            if (CreatedThreads.SelectedItem != null)
            {

                string threadName = CreatedThreads.SelectedItem.ToString();
                RemoveFromList(CreatedThreads, threadName);
                AddToList(WaitingThreads, threadName);

                Thread t1 = new Thread(() =>
                {
                    Thread.Sleep(4000);

                    semaphore.WaitOne();
                    RemoveFromList(WaitingThreads, threadName);

                    AddToList(WorkingThreads, $"{threadName} isleyir");

                    Thread.Sleep(2000);
                    semaphore.Release();
                    RemoveFromList(WorkingThreads, $"{threadName} isleyir");
                });
                t1.IsBackground = true;
                t1.Start();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            threadCounter++;
            int threadId = threadCounter;
            string threadName = $"Thread {threadId}";

            AddToList(CreatedThreads, threadName);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            semaphore = new Semaphore((int)numericUpDown1.Value, (int)numericUpDown1.Value);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
