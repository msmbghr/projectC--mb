using System;
using System.Globalization;

namespace Miladi2Shamsi
{
    public class shamsi2miladi
    {
        /// <summary>
        ///یک تابع که میلادی را تبدیل به شمسی می کند .در این تابع سه متغیر سال و ماه و روز و یک متغیر موود یا بالا آمدن را در بر دارد..
        /// </summary>
        /// <param name="yy"></param>
        /// <param name="mm"></param>
        /// <param name="dd"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        public static string Mil2Sham(int yy, int mm, int dd, int style)
        {
            DateTime dtime = new DateTime(yy, mm, dd);
            PersianCalendar pdate = new PersianCalendar();
            int py, pm, pd, mode;
            py = Convert.ToInt32(pdate.GetYear(dtime));
            pm = Convert.ToInt32(pdate.GetMonth(dtime));
            pd = Convert.ToInt32(pdate.GetDayOfMonth(dtime));
            mode = Convert.ToInt32(pdate.GetDayOfWeek(dtime));
            string[] dname = new string[8];
            string[] dmon = new string[13];
            string m2s = "";

            dname[0] = "یکشنبه";
            dname[1] = "دوشنبه";
            dname[2] = "سه شنبه";
            dname[3] = "چهارشنبه";
            dname[4] = "پنجشنبه";
            dname[5] = "جمعه";
            dname[6] = "شنبه";
            dname[7] = "";

            dmon[1] = "فروردین";
            dmon[2] = "اردیبهشت";
            dmon[3] = "خرداد";
            dmon[4] = "تیر";
            dmon[5] = "مرداد";
            dmon[6] = "شهریور";
            dmon[7] = "مهر";
            dmon[8] = "آبان";
            dmon[9] = "آذر";
            dmon[10] = "دی";
            dmon[11] = "بهمن";
            dmon[12] = "اسفند";
            dmon[0] = "";
            string spy = "", spm = "", spd = "";
            if (pm < 10)
                spm = "0";
            if (pd < 10)
                spd = "0";
            spy += Convert.ToString(py);
            spm += Convert.ToString(pm);
            spd += Convert.ToString(pd);
            if (style == 1)
                m2s = spy + "/" + spm + "/" + spd;
            if (style == 2)
                m2s = dname[mode] + "  " + Convert.ToString(pd) + " " + dmon[pm] + " " + Convert.ToString(py);
            if (style == 3)
                m2s = Convert.ToString(py) + "." + Convert.ToString(pm) + "." + Convert.ToString(pd);
            if (style == 4)
                m2s = spy + spm + spd;
            return m2s;

        }
    }
}
