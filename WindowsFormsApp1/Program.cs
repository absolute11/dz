using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Programm
    {
        int top;
        int bottom;

        public Programm(int t,int b)
        {
            top = t;
            bottom = b;
        }

        public int GetTop()
        {
            return top;
        }
        public int Bottom
        {
            get
            {
                return bottom;
            }
        }
        public Programm Plus(Programm f)
        {
            int t = this.top * f.bottom + f.top * this.bottom;
            int b = this.bottom * f.bottom;

            Programm res = new Programm(t, b);

            return res;
        }
        public Programm Minus(Programm f)
        {
            int t = this.top * f.bottom - f.top * this.bottom;
            int b = this.bottom * f.bottom;

            Programm res = new Programm(t, b);
            return res;
        }
        public Programm Divide(Programm f)
        {
            int t = this.top * f.bottom;
            int b = this.bottom * f.top;

            Programm res = new Programm(t, b);
            return res;
        }
        public Programm Multiply(Programm f)
        {
            int t = this.top * f.top;
            int b = this.bottom * f.bottom;

            Programm res = new Programm(t, b);
            return res;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }

}
