using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil2
{
    public class hostingUnit
    {

        private static readonly int s_id = 10000001;
        private static readonly int count = 0;
        public bool[,] mat = new bool[12, 31];

        private void Reset(bool[,] mat)
        {
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    mat[i, j] = false;
                }
            }
        }

        //constractor
        public hostingUnit()
        {

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    mat[i, j] = false;
                }
            }
        }


        public void ToString(int s_id)
        {
            Console.WriteLine(s_id);

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    if (mat[i, j] == false)
                        break;
                    else if (mat[i, j] == true && mat[i, j - 1] == false)
                        Console.WriteLine("start date " + (i + 1) + "/" + (j + 1));
                    else if (mat[i, j] == true && mat[i, j + 1] == false)
                        Console.WriteLine("end date " + (i + 1) + "/" + (j + 1));
                }
            }

        }
        public bool ApproveRequest(GuestRequest guestReq)
        {
            bool temp1 = true;
            bool temp2 = true;
            guestReq.yes_no = true;
            if ((guestReq.fmounth == guestReq.lmounth) && (guestReq.fyear == guestReq.lyear))//if the begin and the end in tae same mounth
            {
                for (int i = (guestReq.fday - 1); i < (guestReq.lday - 1); i++)//the function checks if the dates are availble
                {
                    if (mat[guestReq.fmounth - 1, i - 1] == true)
                        guestReq.yes_no = false;
                }
                if (guestReq.yes_no == true)//the dates availble
                {
                    for (int i = (guestReq.fday - 1); i < (guestReq.lday - 1); i++)
                    {
                        mat[guestReq.fmounth - 1, i - 1] = true;
                    }
                }
            }
            if ((guestReq.fmounth != guestReq.lmounth) && (guestReq.fyear == guestReq.lyear))
            {
                for (int i = (guestReq.fday - 1); i < 31; i++)//the function checks if the dates are availble
                {
                    if (mat[guestReq.fmounth - 1, i - 1] == true)
                        temp1 = false;
                }
                for (int i = 0; i < guestReq.fday; i++)
                {
                    if (mat[guestReq.lmounth - 1, i - 1] == true)
                        temp2 = false;
                }
                if ((temp1 == true) && (temp2 == true))
                    guestReq.yes_no = true;
                if ((temp1 == true) && (temp2 == true))
                    for (int i = guestReq.fday - 1; i < 31; i++)//the function checks if the dates are availble
                    {
                        mat[guestReq.fmounth - 1, i - 1] = true;

                    }
                for (int i = 0; i < guestReq.lday; i++)
                {
                    mat[guestReq.lmounth - 1, i - 1] = true;

                }
            }
            return guestReq.yes_no;
        }
        public int GetAnnualBusyDays()
        {
            int count = 0;
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    if (mat[i, j] == true)
                        count++;
                }
            }
            return count;
        }
        public float GetAnnualBusyPercentage()
        {
            int count = 0;
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    if (mat[i, j] == true)
                        count++;
                }
            }
            int present = (count / 365) * 100;
            return present;
        }
        public int CompareTo(object obj)
        {
            return this.GetAnnualBusyDays().CompareTo((obj as hostingUnit).GetAnnualBusyDays());
        }

    }
}