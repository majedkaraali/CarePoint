namespace CarePoint.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public int PatientID { get; set; }  // Foreign Key to Patient
        public int DoctorID { get; set; }   // Foreign Key to Doctor
        public string Medication { get; set; }  // Medication prescribed
        public string Dosage { get; set; }  // Dosage information
        public string Instructions { get; set; }  // How to take the medication
        public DateTime DateIssued { get; set; }  // Date when the prescription was issued

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }

}
