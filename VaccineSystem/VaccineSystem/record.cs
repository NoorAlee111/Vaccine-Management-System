using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineSystem
{
  public  class record
    {
        private string NameA;
        private string GenderA;
        private string PrfA;
        private int AgeA;
        private string CnicA;
        private int BpA;
        private int BtA;
        private string PnoA;
        private AppointmentTime appointment = new AppointmentTime();
        private int Pdose;
        private int Cgeneration;

        public string NameA1 { get => NameA; set => NameA = value; }
        public string GenderA1 { get => GenderA; set => GenderA = value; }
        public string PrfA1 { get => PrfA; set => PrfA = value; }
        public int AgeA1 { get => AgeA; set => AgeA = value; }
        public string CnicA1 { get => CnicA; set => CnicA = value; }
        public int BpA1 { get => BpA; set => BpA = value; }
        public int BtA1 { get => BtA; set => BtA = value; }
        public string PnoA1 { get => PnoA; set => PnoA = value; }
      
        public int Pdose1 { get => Pdose; set => Pdose = value; }
        public int Cgeneration1 { get => Cgeneration; set => Cgeneration = value; }
        public AppointmentTime Appointment { get => appointment; set => appointment = value; }

        public record(string NameA, string GenderA, string PnoA, string CnicA, string PrfA, int AgeA, int BpA, int BtA)
        {
            this.NameA1 = NameA;
            this.GenderA1 = GenderA;
            this.PrfA1 = PrfA;
            this.CnicA1 = CnicA;
            this.AgeA1 = AgeA;
            this.BpA1 = BpA;
            this.BtA1 = BtA;
            this.PnoA1 = PnoA;
            this.Pdose1 = 0;
            this.Cgeneration = 0;
            this.Appointment.Time = 0;
            this.Appointment.Month = 0;
            this.Appointment.Date = 0;
        }
        public record()
        {
            NameA1 = "";
            GenderA1 = "";
            PrfA1 = "";
            CnicA1 = "";
            AgeA1 = 0;
            BpA1 = 0;
            BtA1 = 0;
            PnoA1 = "";

        }
        public record(int time,int date,int month)
        {
            this.appointment.Time = time;
            this.appointment.Date = date;
            this.appointment.Month = month;
           

        }

    }
}
