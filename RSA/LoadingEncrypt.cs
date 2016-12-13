using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class LoadingEncrypt : Form
    {
        int w = 0;
        public LoadingEncrypt()
        {
            InitializeComponent();
            w = 0;
            label2.Text = w.ToString() + " S";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            w++;
            label2.Text = w.ToString() + " S";
        }

        private void LoadingEncrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            w = 0;
        }

        private void LoadingEncrypt_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            w = 0;
        }

        private void LoadingEncrypt_Load(object sender, EventArgs e)
        {
            w = 0;
            label2.Text = w.ToString() + " S";
            timer1.Start();
        }
    }
}
