using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Example
{
    class MedicalRecords
    {
        private string strPatientName;
        private float fltMedicalFees;
        public MedicalRecords(string strPatientName, float fltMedicalFees)
        {
            this.strPatientName = strPatientName;
            this.fltMedicalFees = fltMedicalFees;
        }
        public float CalMedicalFees()
        { 
            return fltMedicalFees; 
        }
        public float CalMedicalFees(string test)
        {
            if (test == "Hepatities")
            {
                fltMedicalFees = fltMedicalFees + 17.70f;
            }
            else if (test == "Cholesterol")
            {
                fltMedicalFees = fltMedicalFees + 25.00f;
            }
            else if (test == "Diabetes")
            {
                fltMedicalFees = fltMedicalFees + 20.00f;
            }
            return fltMedicalFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter patient's name: ");
            string PatientName = Console.ReadLine();
            Console.Write("Enter patient'medical fees: ");
            float MedicalFees = float.Parse(Console.ReadLine());
            MedicalRecords mObj = new MedicalRecords(PatientName, MedicalFees);
            Console.WriteLine("Medical fees without teast is : " + mObj.CalMedicalFees().ToString());
            Console.WriteLine("Medical fees with hepatities is : " + mObj.CalMedicalFees("Hepatities").ToString());
            Console.WriteLine("Medical fees with cholesterol is : " + mObj.CalMedicalFees("Cholesterol").ToString());
        }
    }
}
