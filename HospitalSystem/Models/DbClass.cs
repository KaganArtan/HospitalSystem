using System.Net.Mail;

namespace HospitalSystem.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }
    }


    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Appointment> Appointments { get; set; }
    }

    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppointmentDateTime { get; set; }
    }
}