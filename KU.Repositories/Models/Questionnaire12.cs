using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
   // public class QuestionnaireWrap12
    //{
    //    public QuestionnaireWrap12()
    //    {
    //        result = new List<Questionnaire12>();

    //    }
    //    public IEnumerable<Questionnaire12> result { get; set; }

    //}
    public class Questionnaire12
    {
        [Key]
        public string Sample { get; set; }
        public string COVID19ID { get; set; }
        public string DepositoryID { get; set; }
        public string ProjectTitle { get; set; }
        public string PrincipalInvestigator { get; set; }
        public string CollectionPoint { get; set; }
        public string CollectedBy { get; set; }
        public string CollectedDate { get; set; }
        public string Indifamily { get; set; }
        public string Severity { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EmiratesID { get; set; }
        public string Nationality { get; set; }
        public string DOB { get; set; }
        public string PlaceOfBirth { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Ethnicity { get; set; }
        public string EthnicityMixedSpecify { get; set; }
        public string EthnicityOthersSpecify { get; set; }
        public string DiagnosticDate { get; set; }
        public string PersonHaveSymptoms { get; set; }
        public string PersonHaveSymptomsDate { get; set; }
        public string PersonHaveSymptomsDuration { get; set; }
        public string PersonTravel { get; set; }
        public string PersonTravelDate { get; set; }
        public string PersonTravelDestination { get; set; }
        public string ARDS { get; set; }
        public string ARDSDate { get; set; }
        public string ARDS_Xray { get; set; }
        public string Pneumonia { get; set; }
        public string Pneumonia_date { get; set; }
        public string Pneumonia_Xray { get; set; }
        public string Fever { get; set; }
        public string FeverDate { get; set; }
        public string Cough { get; set; }
        public string Cough_date { get; set; }
        public string NewLossOfTasteOrSmell { get; set; }
        public string NewLossOfTasteOrSmellDate { get; set; }
        public string Fatigue { get; set; }
        public string FatigueDate { get; set; }
        public string ChillsOrRigors { get; set; }
        public string ChillsOrRigorsDate { get; set; }
        public string Headache { get; set; }
        public string HeadacheDate { get; set; }
        public string Diarrhea { get; set; }
        public string DiarrheaDate { get; set; }
        public string Nausea { get; set; }
        public string NauseaDate { get; set; }
        public string ShortnessOfBreath { get; set; }
        public string ShortnessOfBreathDate { get; set; }
        public string SoreThroat { get; set; }
        public string SoreThroatDate { get; set; }
        public string RunnyOrStuffyNose { get; set; }
        public string RunnyOrStuffyNoseDate { get; set; }
        public string MuscleOrBodyAches { get; set; }
        public string MuscleOrBodyAchesDate { get; set; }
        public string Vomiting { get; set; }
        public string VomitingDate { get; set; }
        public string Sneezing { get; set; }
        public string SneezingDate { get; set; }
        public string ClinicalNotes { get; set; }
        public string PersonHospitalized { get; set; }
        public string OxygenTherapyRequired { get; set; }
        public string AdmittedICU { get; set; }
        public string IntubationRequired { get; set; }
        public string MechanicalIncubationRequired { get; set; }
        public string HospitalMedicalRecordChartNumber { get; set; }
        public string MedicationAdministered1 { get; set; }
        public string Dose1 { get; set; }
        public string Comments1 { get; set; }
        public string MedicationAdministered2 { get; set; }
        public string Dose2 { get; set; }
        public string Comments2 { get; set; }
        public string NoRiskMedicalConditions { get; set; }
        public string CardiacDisease { get; set; }
        public string ChronicLungDisease { get; set; }
        public string Haemoglobinopathies { get; set; }
        public string Type2Diabetes { get; set; }
        public string Dialysis { get; set; }
        public string ImmunosuppressiveCondition { get; set; }
        public string ImmunosuppressiveConditionSpecify { get; set; }
        public string LiverDisease { get; set; }
        public string MetabolicDisease { get; set; }
        public string NeurologicalDisorder { get; set; }
        public string Obesity { get; set; }
        public string RenalDisease { get; set; }
        public string RenalDiseaseDialysis { get; set; }
        public string OtherRiskMedicalCondition { get; set; }
        public string OtherRiskMedicalConditionSpecify { get; set; }
        public string ReceivedCOVID19Vaccine { get; set; }
        public string CurrentlyPregnant { get; set; }
        public string CurrentSmoker { get; set; }
        public string ConsumeAlcohol { get; set; }
        public string BloodType { get; set; }
        public string ParticipantsWeight { get; set; }
        public string ParticipantsHeight { get; set; }
        public string Fruit { get; set; }
        public string Vegetables { get; set; }
        public string WholeMealBreads { get; set; }
        public string BeansPeasLentils { get; set; }
        public string NutsSeeds { get; set; }
        public string TreatmentRegimen { get; set; }
        public string Day0Saliva { get; set; }
        public string Day0NasalSwab { get; set; }
        public string Day0Date { get; set; }
        public string Day2Saliva { get; set; }
        public string Day2NasalSwab { get; set; }
        public string Day2Date { get; set; }
        public string Day4Saliva { get; set; }
        public string Day4NasalSwab { get; set; }
        public string Day4Date { get; set; }
        public string Day6Saliva { get; set; }
        public string Day6NasalSwab { get; set; }
        public string Day6Date { get; set; }
        public string Day8Saliva { get; set; }
        public string Day8NasalSwab { get; set; }
        public string Day8Date { get; set; }
        public string Day10Saliva { get; set; }
        public string Day10NasalSwab { get; set; }
        public string Day10Date { get; set; }
        public string Day12Saliva { get; set; }
        public string Day12NasalSwab { get; set; }
        public string Day12Date { get; set; }
        public string Day14Saliva { get; set; }
        public string Day14NasalSwab { get; set; }
        public string Day14Date { get; set; }
    }
}
