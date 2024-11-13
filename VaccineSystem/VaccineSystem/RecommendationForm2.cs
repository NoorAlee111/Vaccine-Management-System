using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineSystem
{
    public partial class RecommendationForm2 : Form
    {
        public RecommendationForm2()
        {
            InitializeComponent();
        }

        private void RecommendationForm2_Load(object sender, EventArgs e)
        {
            recommendationlable.Text = "After getting fully vaccinated..." +
                " keep taking precautions"
                + "Keep a safe distance from others and avoid crowds" +
                "Wear a well-fitting mask covering your mouth and nose"
                + "Clean your hands frequently"
                + "Cover any cough or sneeze in your bent elbow";
        }
    }
}
