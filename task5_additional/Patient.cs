using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_additional
{
    internal class Patient
    {
        TreatmentPlan code;
        public Patient(TreatmentPlan codePlan)
        {
            code = codePlan;
        }
        public void Heal()
        {
            switch(code.codePlan)
            {
                case 1:
                    Surgeon.Heal();
                    break;
                case 2:
                    Dentist.Heal();
                    break;
                default:
                    Therapist.Heal();
                    break;
            }
        }
    }
}
