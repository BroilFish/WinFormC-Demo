using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DllTest
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SystemTime
    {
        public int year;
        public int month;
        public int day;
        public int hour;
        public int minute;
        public int second;
        public int millsecond;

        public SystemTime(DateTime dt)
        {
            this.year = dt.Year;
            this.month = dt.Month;
            this.day = dt.Day;
            this.hour = dt.Hour;
            this.minute = dt.Minute;
            this.second = dt.Second;
            this.millsecond = dt.Millisecond;
        }

        public override string ToString()
        {
            return this.year.ToString() + "-" + this.month.ToString() + "-" + this.day.ToString() + "  "
                + this.hour.ToString() + ":" + this.minute.ToString() + "-" + this.second.ToString() + "-"
                + this.millsecond.ToString();
        }
    };

    public class CFunction
    {
        [DllImport("MyNativeDll.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static int add(int x, int y);

        [DllImport("MyNativeDll.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static int sub(int x, int y);

        [DllImport("MyNativeDll.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static int testChar(ref byte src, ref byte res, int nCount);

        [DllImport("MyNativeDll.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static int testStruct(ref SystemTime stSrc, ref SystemTime stRes);
    }
}
