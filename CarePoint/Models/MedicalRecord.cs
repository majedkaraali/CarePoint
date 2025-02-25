namespace CarePoint.Models
{
    public class MedicalRecord
    {
        public int ID { get; set; }  // Primary Key
        public int PatientID { get; set; }  // Foreign Key to Patient
        public int DoctorID { get; set; }   // Foreign Key to Doctor
        public string Diagnosis { get; set; }  // Diagnosis details
        public string Treatment { get; set; }  // Treatment plan or prescribed actions
        public DateTime RecordDate { get; set; }  // Date of the medical record

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }


}
