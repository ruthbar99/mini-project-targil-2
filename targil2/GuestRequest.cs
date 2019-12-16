using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    public class GuestRequest
    {
        //public static  bool[,] mat = new bool[12, 31];
        //private static void Reset(bool[,] mat)
        //{
        //for (int i = 0; i< 12; ++i)
        //    {
        //        for (int j = 0; j< 31; ++j)
        //        {
        //            mat[i, j] = false;
        //        }
        //    }
        //}

        //public
        /// int fday=1;
        //int fmounth=1;
        //int fyear=1;
        //int lday=1;
        //int lmounth=1;
        //int lyear=1;
        //bool yes_no;
        public int fday { get; set; }
        public int fmounth { get; set; }
        public int fyear { get; set; }
        public int lmounth { get; set; }
        public int lyear { get; set; }
        public int lday { get; set; }
        public bool yes_no { get; set; }


        //private static void YesNo(int fday, int fmounth, int fyear,int lday,int lmounth, int lyear, bool yes_no,bool[,] mat)
        //{
        //    bool temp1 = true;
        //    bool temp2 = true;
        //    yes_no = true;
        //    if ((fmounth == lmounth) && (fyear == lyear))//if the begin and the end in tae same mounth
        //    {
        //        for (int i = (fday-1); i <( lday-1); i++)//the function checks if the dates are availble
        //        {
        //            if (mat[fmounth-1, i-1] == true)
        //          yes_no = false;
        //        }                
        //           if (yes_no==true)//the dates availble
        //        {
        //            for (int i = (fday-1); i < (lday-1); i++)
        //            {
        //                mat[fmounth-1, i-1] = true;
        //            }
        //        }
        //    }
        //    if ((fmounth!=lmounth)&&(fyear == lyear))
        //    {
        //        for (int i = (fday-1); i < 31; i++)//the function checks if the dates are availble
        //        {
        //            if (mat[fmounth-1, i-1] == true)
        //                temp1 = false;
        //        }
        //        for (int i =0; i < fday; i++)
        //        {
        //            if (mat[lmounth-1, i-1] == true)
        //                temp2 = false;
        //        }
        //        if ((temp1 == true) && (temp2 == true))
        //            yes_no = true;
        //            if ((temp1==true)&&(temp2==true))
        //            for (int i = fday-1; i < 31; i++)//the function checks if the dates are availble
        //        {
        //                mat[fmounth-1, i-1] = true;

        //        }
        //        for (int i = 0; i < lday; i++)
        //        {
        //            mat[lmounth-1, i-1] = true;

        //        }
        //    }
        //}
    }

}