using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineSystem
{
    class Vaccine
    {
        private string VaccineName;
        private int VaccineQuantity;

        public string VaccineName1 { get => VaccineName; set => VaccineName = value; }
        public int VaccineQuantity1 { get => VaccineQuantity; set => VaccineQuantity = value; }
        public Vaccine(string VaccineName)
        {
            this.VaccineName = VaccineName;
            
        }
    }
}
