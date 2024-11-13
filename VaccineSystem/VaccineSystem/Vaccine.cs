using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VaccineSystem
{
  public class VaccineDL
    {
        private static List<Vaccine> Vaccines = new List<Vaccine>();
   
        private static string VaccinesPath = "C:\\Users\\DELL\\source\\repos\\VaccineSystem\\vaccines.Txt";

        internal static List<Vaccine> Vaccines1 { get => Vaccines; set => Vaccines = value; }

        public static void savevaccineData()
        {
            StreamWriter f1 = new StreamWriter(VaccinesPath);
            foreach (Vaccine v in Vaccines1)
            {
                f1.Write(v.VaccineQuantity1 + " ");
            }
            f1.Flush();
            f1.Close();
        }
        public static bool ReadVaccinedata()
        {
            StreamReader f = new StreamReader(VaccinesPath);
            string record;
            if (File.Exists(VaccinesPath))
            {
                int x = 0;
                while ((record = f.ReadLine()) != null)
                {

                    string[] spllitedrecord = record.Split(' ');
                    foreach (Vaccine v in Vaccines1)
                    {
                        v.VaccineQuantity1 = int.Parse(spllitedrecord[x]);
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
        public static void editvaccine(string vaccinename,int newquantity)
        {
            foreach(Vaccine v in Vaccines1)
            {

                if(v.VaccineName1==vaccinename)
                {
                    v.VaccineQuantity1 = newquantity;
                }
            }
        }
        public static void DecreaseVaccineQuantity(int age)
        {
            if (age <= 15)
            {
                Vaccines1[0].VaccineQuantity1 = Vaccines1[0].VaccineQuantity1 - 1;
            }
            if (age > 15 && age <= 40)
            {
                Vaccines1[2].VaccineQuantity1 = Vaccines1[2].VaccineQuantity1 - 1;
            }
            if (age > 40)
            {
                Vaccines1[1].VaccineQuantity1 = Vaccines1[1].VaccineQuantity1 - 1;
            }
        }
    }
}
