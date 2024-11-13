using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace VaccineSystem
{
    class recordDL
    {
        private static List<record> recordlist = new List<record>();
        private static string path = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\records.txt";
        private static string Cardpath = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\card.txt";
        private static string DosePath = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\dose.txt";
        private static string timepath = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\time.txt";


        public static List<record> Recordlist { get => recordlist; set => recordlist = value; }
        public static void addintoList(record r)
        {
            recordlist.Add(r);
        }
        public static void StoreRecordsData(record r)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(r.NameA1 + "," + r.AgeA1 + "," +r.PrfA1+","+ r.GenderA1+","+r.BtA1+","+r.BpA1+","+r.CnicA1+","+r.PnoA1);
            file.Flush();
            file.Close();

        }
        public static bool ReadRecordData()
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {

                while ((record = f.ReadLine()) != null)
                {
                    if ((record == null)|| (record ==""))
                    {
                        break;
                    }
                    else
                    {
                        string[] spllitedrecord = record.Split(',');
                        string name = spllitedrecord[0];
                        int Age = int.Parse(spllitedrecord[1]);
                        string prf = spllitedrecord[2];
                        string gender = spllitedrecord[3];
                        int bt = int.Parse(spllitedrecord[4]);
                        int bp = int.Parse(spllitedrecord[5]);
                        string cnic = spllitedrecord[6];
                        string pno = spllitedrecord[7];

                        record r = new record(name, gender, pno, cnic, prf, Age, bp, bt);
                        addintoList(r);
                    }
                    
                }
               
            f.Close();
            return true;
        }
            
            else
            {
                return false;
            }
        }
        public static bool ReadTimeData()
        {
            StreamReader f = new StreamReader(timepath);
            string record;
            if (File.Exists(timepath))
            {
               
                    int x = 0;
                    while ((record = f.ReadLine()) != null)
                    {
                    if ((record = f.ReadLine()) == null)
                    {
                        break;
                    }
                    else
                    {
                        string[] spllitedrecord = record.Split(',');
                        int Time = int.Parse(spllitedrecord[0]);
                        int Date = int.Parse(spllitedrecord[1]);
                        int Month = int.Parse(spllitedrecord[2]);
                        AppointmentTime App = new AppointmentTime(Time, Date, Month);
                        recordlist[x].Appointment = App;
                        x++;
                    }
                    }
                
                f.Close();

                return true;
            }

            else
            {
                return false;
            }
        }
        public static void deleterecordFromList(record r)
        {
            foreach (record r1 in recordlist)
            {
                if (r1.CnicA1== r.CnicA1)
                {
                    recordlist.Remove(r1);
                    break;
                }
            }
        }
        public static void EditrecordFromList(record previous, record updated)
        {
            foreach (record r in recordlist)
            {
                if (r.CnicA1 == previous.CnicA1)
                {
                    r.NameA1 = updated.NameA1;
                    r.GenderA1 = updated.GenderA1;
                    r.PrfA1 = updated.PrfA1;
                    r.CnicA1 = updated.CnicA1;
                    r.AgeA1 = updated.AgeA1;
                    r.BpA1 = updated.BpA1;
                    r.BtA1 = updated.BtA1;
                    r.PnoA1 = updated.PnoA1;
                }
            }
        }
        public static record EditTime(record previous, record updated)
        {
            record r1=null;
            foreach (record r in recordlist)
            {
                if (r.CnicA1 == previous.CnicA1)
                {
                    r.Appointment.Time=updated.Appointment.Time;
                    r.Appointment.Date = updated.Appointment.Date;
                    r.Appointment.Month = updated.Appointment.Month;
                    r1 = r;

                }
            }
            return r1;
        }
        public static void storeallDataIntoFile()
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (record r  in recordlist)
            {
                file.WriteLine(r.NameA1 + "," + r.AgeA1 + "," + r.PrfA1 + "," + r.GenderA1 + "," + r.BtA1 + "," + r.BpA1 + "," + r.CnicA1 + "," + r.PnoA1);
            }
            file.Flush();
            file.Close();
        }
        public static void storealltimedataIntoFile()
        {
            StreamWriter file = new StreamWriter(timepath, false);
            foreach (record r in recordlist)
            {
                file.WriteLine(r.Appointment.Time + "," + r.Appointment.Date + "," + r.Appointment.Month );
            }
            file.Flush();
            file.Close();
        }
        public static bool isexist(record r)
        {
            foreach(record r1 in recordlist)
            {
                if(r.CnicA1==r1.CnicA1)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<record> sortedrecordlist()
        {
            List<record> sortedlist = new List<record>();
            sortedlist = recordlist.OrderByDescending(o => o.AgeA1).ToList();
            return sortedlist;
        }
        public static List<record> getgenderlist(string gender)
        {
            List<record> genderrecord = new List<record>();
            foreach(record r in recordlist)
            {
                if(r.GenderA1==gender)
                {
                    genderrecord.Add(r);
                }
            }
            return genderrecord;
        }
        public static void cardgenerate()
        {
            foreach (record r in recordlist)
            {
                if (r.Pdose1 == 1 || r.Pdose1 == 2)
                {
                    r.Cgeneration1 = 1;
                }
                else
                {
                    r.Cgeneration1 = 0;
                }
            }
    }

        public static bool ReadCarddata()
        {
            StreamReader f = new StreamReader(Cardpath);
            string record;
            if (File.Exists(Cardpath))
            {

                while ((record = f.ReadLine()) != null)
                {

                    string[] spllitedrecord = record.Split(' ');
                    for (int i = 0; i < recordlist.Count; i++)
                    {
                        recordlist[i].Cgeneration1 = int.Parse(spllitedrecord[i]);
                    }
                }
                f.Close();

                return true;
            }

            else
            {
                return false;
            }
        }
        public static bool ReadDosedata()
        {
            StreamReader f = new StreamReader(DosePath);
            string record;
            if (File.Exists(DosePath))
            {

                while ((record = f.ReadLine()) != null)
                {

                    string[] spllitedrecord = record.Split(' ');
                    for (int i = 0; i < recordlist.Count; i++)
                    {
                        recordlist[i].Pdose1 = int.Parse(spllitedrecord[i]);
                    }
                }
                f.Close();

                return true;
            }

            else
            {
                return false;
            }
        }
        public static void storecardDataIntoFile()
        {
            StreamWriter file = new StreamWriter(Cardpath,false);
            foreach (record r in recordlist)
            {
                file.Write(r.Cgeneration1 + " " );
            }
            file.Flush();
            file.Close();
        }
       
        public static void storealltimeDataIntoFile()
        {
            StreamWriter file = new StreamWriter(timepath,false);
            foreach (record r in recordlist)
            {
                file.WriteLine(r.Appointment.Time + "," + r.Appointment.Date + "," + r.Appointment.Month);
            }
            file.Flush();
            file.Close();
        }
        public  static void savedoseData()
        {
            StreamWriter f1 = new StreamWriter(DosePath,false);
            foreach (record r in recordlist)
            {
                f1.Write(r.Pdose1 + " ");
            }
            f1.Flush();
            f1.Close();
        }
        public static record checkuser(string cnic)
        {
            foreach (record r1 in recordlist)
            {
                if (r1.CnicA1 == cnic)
                {
                    return r1;
                }
            }
            return null;
        }
    }
}

