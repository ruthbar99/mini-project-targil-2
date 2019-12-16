using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace targil2
{
    public class Host
    {
        public int HostKey;
        public List<hostingUnit> HostingUnitCollection;

        //constructor
        public Host(int aHostKey, int aHostingUnitCollection)
        {
            // Creating an List<hostingUnit> of Integers 
            List<hostingUnit> HostingUnitCollection = new List<hostingUnit>();
            HostKey = aHostKey;
            for(int i=0; i< aHostingUnitCollection;i++)
            {
                hostingUnit a = new hostingUnit();
                // Adding elements to List 
                HostingUnitCollection.Add(a);
            }

        }

        public void ToString()
        {
            for (int i = 0; i < HostingUnitCollection.Count; i++)
            {
                Console.WriteLine($" {HostingUnitCollection[i].ToString()}");
            }
        }


        public long SubmitRequest(GuestRequest guestReq)
        {
           if(ApproveRequest(guestReq))
            {
                return HostKey;
            }
            return -1;
        }

        public int GetHostAnnualBusyDays()
        {
            return GetAnnualBusyDays();
        }
        
        public void SortUnits()
        {
            HostingUnitCollection.Sort();
        }

        public bool AssignRequests(GuestRequest[]a)
        {
            bool flag = true;
            for(int i=0; i< a.Length;i++)
                for (int j = 0; j < HostingUnitCollection.Count; j++)
                {
                    if (SubmitRequest(a[i]) != -1)
                        break;

     
                }

            
        }
    }
}
