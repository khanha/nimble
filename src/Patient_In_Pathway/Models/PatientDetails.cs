using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_In_Pathway.Models
{
    public class PatientDetails
    {
        public PatientDetails() {

        }

        [BsonElement("Title")]
        public int Title { get; set; }

        [BsonElement("ForeName")]
        public int ForeName { get; set; }

        [BsonElement("LastName")]
        public int LastName { get; set; }

        [BsonElement("Dob")]
        public int Dob { get; set; }

        [BsonElement("Gender")]
        public int Gender { get; set; }

        [BsonElement("Address1")]
        public int Address1 { get; set; }

        [BsonElement("Address2")]
        public int Address2 { get; set; }

        [BsonElement("Address3")]
        public int Address3 { get; set; }

        [BsonElement("Title")]
        public int Postcode { get; set; }

        [BsonElement("HomePhoneNumber")]
        public int HomePhoneNumber { get; set; }

        [BsonElement("MobilePhoneNumber")]
        public int MobilePhoneNumber { get; set; }

        [BsonElement("Email")]
        public int Email { get; set; }

        [BsonElement("Ethnicity")]
        public int Ethnicity { get; set; }

        [BsonElement("FirstLanguage")]
        public int FirstLanguage { get; set; }

        [BsonElement("InterpreterRequired")]
        public int InterpreterRequired { get; set; }

        [BsonElement("NHSNumber")]
        public int NHSNumber { get; set; }

        [BsonElement("HospitalNumber")]
        public int HospitalNumber { get; set; }

        [BsonElement("ReferringGP")]
        public int ReferringGP { get; set; }

        [BsonElement("GPOrganisationName")]
        public int GPOrganisationName { get; set; }

        [BsonElement("GPOrganisationFullAddress")]
        public int GPOrganisationFullAddress { get; set; }

        [BsonElement("GPTelephoneNumber")]
        public int GPTelephoneNumber { get; set; }

        [BsonElement("GPFaxNumber")]
        public int GPFaxNumber { get; set; }

        [BsonElement("PracticeEmail")]
        public int PracticeEmail { get; set; }

        [BsonElement("ReferralDate")]
        public int ReferralDate { get; set; }

        [BsonElement("DateReceived")]
        public int DateReceived { get; set; }

        [BsonElement("UrologyEmailAdviceServiceUsed")]
        public int UrologyEmailAdviceServiceUsed { get; set; }

        [BsonElement("PatientInformedOfCancerPathway")]
        public int PatientInformedOfCancerPathway { get; set; }

        [BsonElement("PatientAvailableNextFiveDays")]
        public int PatientAvailableNextFiveDays { get; set; }

        [BsonElement("PatientInformedOfPhoneCallByConsultant")]
        public int PatientInformedOfPhoneCallByConsultant { get; set; }

        [BsonElement("PatientInformedOfMRIAppointment")]
        public int PatientInformedOfMRIAppointment { get; set; }

        [BsonElement("PatientAvaiableNextNineWeeks")]
        public int PatientAvaiableNextNineWeeks { get; set; }

        [BsonElement("PatientPreferredContactNumber")]
        public int PatientPreferredContactNumber { get; set; }

        [BsonElement("PatientAgreedToPhoneMessageAndNominatedPerson")]
        public int PatientAgreedToPhoneMessageAndNominatedPerson { get; set; }

        [BsonElement("PatientAgreedToAnswerPhoneMessage")]
        public int PatientAgreedToAnswerPhoneMessage { get; set; }

        [BsonElement("AbnormalAgeSpecificPSA")]
        public int AbnormalAgeSpecificPSA { get; set; }

        [BsonElement("ProstateExamSuspicious")]
        public int ProstateExamSuspicious { get; set; }

        [BsonElement("SpecificProstateCancerWith")]
        public int SpecificProstateCancerWith { get; set; }

        [BsonElement("PSA")]
        public int PSA { get; set; }

        [BsonElement("DREDone")]
        public int DREDone { get; set; }

        [BsonElement("DRE")]
        public int DRE { get; set; }

        [BsonElement("Examination")]
        public int Examination { get; set; }

        [BsonElement("PatientHasPacemaker")]
        public int PatientHasPacemaker { get; set; }

        [BsonElement("PatientHasPacemakerComment")]
        public int PatientHasPacemakerComment { get; set; }

        [BsonElement("PatientHasImplantedDeviceStents")]
        public int PatientHasImplantedDeviceStents { get; set; }

        [BsonElement("PatientHasImplantedDeviceStentsComment")]
        public int PatientHasImplantedDeviceStentsComment { get; set; }

        [BsonElement("PatientHasSurgeryIn8Weeks")]
        public int PatientHasSurgeryIn8Weeks { get; set; }

        [BsonElement("PatientHasSurgeryIn8WeeksComment")]
        public int PatientHasSurgeryIn8WeeksComment { get; set; }

        [BsonElement("PatientHistoryOfMetallicForeignBody")]
        public int PatientHistoryOfMetallicForeignBody { get; set; }

        [BsonElement("PatientHistoryOfMetallicForeignBodyComment")]
        public int PatientHistoryOfMetallicForeignBodyComment { get; set; }

        [BsonElement("PatientHasArtificialHip")]
        public int PatientHasArtificialHip { get; set; }

        [BsonElement("PatientHasArtificialHipComment")]
        public int PatientHasArtificialHipComment { get; set; }

        [BsonElement("PatientHasClaustrophobia")]
        public int PatientHasClaustrophobia { get; set; }

        [BsonElement("PatientHasClaustrophobiaComment")]
        public int PatientHasClaustrophobiaComment { get; set; }

        [BsonElement("NarrativeOfReferral")]
        public int NarrativeOfReferral { get; set; }

        [BsonElement("PatientAnticoagulated")]
        public int PatientAnticoagulated { get; set; }

        [BsonElement("PatientAnticoagulatedComment")]
        public int PatientAnticoagulatedComment { get; set; }

        [BsonElement("PatientHistoryOfBleedingDisorder")]
        public int PatientHistoryOfBleedingDisorder { get; set; }

        [BsonElement("PatientSmokingHistory")]
        public int PatientSmokingHistory { get; set; }

        [BsonElement("PatientAlcoholConsumption")]
        public int PatientAlcoholConsumption { get; set; }

        [BsonElement("PatientFamilyHistoryOfCancer")]
        public int PatientFamilyHistoryOfCancer { get; set; }

        [BsonElement("FHNeoplasm")]
        public int FHNeoplasm { get; set; }


        [BsonElement("Consultations")]
        public int Consultations { get; set; }

        [BsonElement("Problems")]
        public int Problems { get; set; }

        [BsonElement("Medication")]
        public int Medication { get; set; }

        [BsonElement("Allergies")]
        public int Allergies { get; set; }


        [BsonElement("Weight")]
        public int Weight { get; set; }

        [BsonElement("BMI")]
        public int BMI { get; set; }

        [BsonElement("ExclusionForMRI")]
        public int ExclusionForMRI { get; set; }

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

        //public class Tests
        //{
        //    public string TestType { get; set; }
        //    public string TestName { get; set; }
        //    public string TestDate { get; set; }
        //    public string TestResult { get; set; }

        //}

        //public class Appointments
        //{
        //    public string AppointmentType { get; set; }
        //    public string AppointmentDate { get; set; }
        //    public string AppointmentAttended { get; set; }

        //    public string AppointmentResult { get; set; }
        //}

        //public class Assessments
        //{
        //    public string AssessmentType { get; set; }
        //    public string AssessmentName { get; set; }
        //    public string AssessmentDate { get; set; }
        //    public string AssessmentResult { get; set; }
        //    public string Comments { get; set; }


        //}

        //public class PreviousBiopsies
        //{
        //    public string BiopsyDate { get; set; }
        //    public string BiopsyResult { get; set; }
        //    public string BiposyDate { get; set; }
        //    public string BiposyResult { get; set; }
        //}
 }

