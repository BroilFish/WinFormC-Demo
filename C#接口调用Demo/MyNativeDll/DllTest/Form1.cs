using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int a = CFunction.add(100, 50);
            int b = CFunction.sub(100, 50);
            Debug.WriteLine("add = " + a.ToString() + "  b = " + b.ToString());
            Debug.WriteLine("\r\n");

            string src = "123456";
            byte[] srcBytes = System.Text.Encoding.ASCII.GetBytes(src);
            byte[] resBytes = new byte[100];
            a = CFunction.testChar(ref srcBytes[0], ref resBytes[0], src.Length);
            string res = (System.Text.Encoding.ASCII.GetString(resBytes, 0, resBytes.Length)).TrimEnd();
            Debug.WriteLine(res.ToString());
            Debug.WriteLine("\r\n");

            SystemTime stSrc = new SystemTime(DateTime.Now);
            SystemTime stRes = new SystemTime();
            a = CFunction.testStruct(ref stSrc, ref stRes);
            Debug.WriteLine(stRes.ToString());
            Debug.WriteLine("\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
