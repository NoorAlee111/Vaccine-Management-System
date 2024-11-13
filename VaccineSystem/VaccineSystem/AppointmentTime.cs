using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineSystem
{
  public class AppointmentTime
    {
        private int month;
        private int date;
        private int time;
        public int Month { get => month; set => month = value; }
        public int Date { get => date; set => date = value; }
        public int Time { get => time; set => time = value; }
        public AppointmentTime(int Time ,int Date,int Month)
        {
            this.Time = Time;
            this.Date = Date;
            this.Month = Month;
        }
        public AppointmentTime()
        {
           
        }
    }
}
