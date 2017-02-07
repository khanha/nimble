using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_In_Pathway.Models
{

    public class Patient
    {
        //private Patient p;
        public Patient()
        {

        }

        public MongoDB.Bson.ObjectId Id { get; set; }

        [BsonElement("PatientId")]
        public int PatientId { get; set; }

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }


        [BsonElement("Height")]
        public string Height { get; set; }

        [BsonElement("Age")]
        public double Age { get; set; }

        [BsonElement("Weight")]
        public string Weight { get; set; }

        [BsonElement("BMI")]
        public string BMI { get; set; }

        [BsonElement("ExclusionForMRI")]
        public string ExclusionForMRI { get; set; }



        [BsonElement("Tests")]
        //BsonArray Tests = new BsonArray();
        public List<Tests> Tests { get; set; }


        [BsonElement("Appointments")]
        //BsonArray Appointments = new BsonArray();
        public List<Appointments> Appointments { get; set; }

        [BsonElement("Assessment")]
        //BsonArray Assessment = new BsonArray();
        public List<Assessments> Assessments { get; set; }

        [BsonElement("PreviousProstateBiopsies")]
        //BsonArray PreviousProstateBiopsies = new BsonArray();
        public List<PreviousBiopsies> PreviousBiopsies { get; set; }


    }

    public class Tests
    {
        public string TestType { get; set; }
        public string TestName { get; set; }
        public string TestDate { get; set; }
        public string TestResult { get; set; }

    }

    public class Appointments
    {
        public string AppointmentType { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentAttended { get; set; }

        public string AppointmentResult { get; set; }
    }

    public class Assessments
    {
        public string AssessmentType { get; set; }
        public string AssessmentName { get; set; }
        public string AssessmentDate { get; set; }
        public string AssessmentResult { get; set; }
        public string Comments { get; set; }


    }

    public class PreviousBiopsies
    {
        public string BiopsyDate { get; set; }
        public string BiopsyResult { get; set; }
        public string BiposyDate { get; set; }
        public string BiposyResult { get; set; }
    }
}

