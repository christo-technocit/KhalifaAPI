using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
     public class QuestionnaireWrap12
    {
       public QuestionnaireWrap12()
        {
           result = new List<Q12ViewModel>();

        }
        public IEnumerable<Q12ViewModel> result { get; set; }

    }
    public class Q12ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("Sample ID")] public string Sample { get; set; }
        [JsonProperty("COVID19 ID")] public string COVID19ID { get; set; }
        [JsonProperty("Depository ID")] public string DepositoryID { get; set; }
        [JsonProperty("Project Title")] public string ProjectTitle { get; set; }
        [JsonProperty("Principal Investigator")] public string PrincipalInvestigator { get; set; }
        [JsonProperty("Collection Point")] public string CollectionPoint { get; set; }
        [JsonProperty("Collected By")] public string CollectedBy { get; set; }
        [JsonProperty("Collected Date")] public string CollectedDate { get; set; }
        [JsonProperty("Individual/Family")] public string Indifamily { get; set; }
        [JsonProperty("Severity")] public string Severity { get; set; }
        [JsonProperty("First Name")] public string FirstName { get; set; }
        [JsonProperty("Middle Name")] public string MiddleName { get; set; }
        [JsonProperty("Last Name")] public string LastName { get; set; }
        [JsonProperty("Gender")] public string Gender { get; set; }
        [JsonProperty("Emirates ID")] public string EmiratesID { get; set; }
        [JsonProperty("Nationality")] public string Nationality { get; set; }
        [JsonProperty("Date of Birth")] public string DOB { get; set; }
        [JsonProperty("Place of Birth")] public string PlaceOfBirth { get; set; }
        [JsonProperty("City/Emirate")] public string City { get; set; }
        [JsonProperty("Phone")] public string Phone { get; set; }
        [JsonProperty("Email")] public string Email { get; set; }
        [JsonProperty("Ethnicity")] public string Ethnicity { get; set; }
        [JsonProperty("Ethnicity Mixed Specify")] public string EthnicityMixedSpecify { get; set; }
        [JsonProperty("Ethnicity Others Specify")] public string EthnicityOthersSpecify { get; set; }
        [JsonProperty("DiagnosticDate")] public string DiagnosticDate { get; set; }
        [JsonProperty("Person Have Symptoms")] public string PersonHaveSymptoms { get; set; }
        [JsonProperty("13_Person Have Symptoms Onset Date")] public string PersonHaveSymptomsDate { get; set; }
        [JsonProperty("Person Have Symptoms Duration")] public string PersonHaveSymptomsDuration { get; set; }
        [JsonProperty("Did the Person Travel")] public string PersonTravel { get; set; }
        [JsonProperty("Travel Date")] public string PersonTravelDate { get; set; }
        [JsonProperty("Travel Destination")] public string PersonTravelDestination { get; set; }
        [JsonProperty("Acute Respiratory Distress Syndrome")] public string ARDS { get; set; }
        [JsonProperty("ARDS Onset Date")] public string ARDSDate { get; set; }
        [JsonProperty("ARDS Confirmed by X-Ray")] public string ARDS_Xray { get; set; }
        [JsonProperty("Pneumonia")] public string Pneumonia { get; set; }
        [JsonProperty("Pneumonia Onset Date")] public string Pneumonia_date { get; set; }
        [JsonProperty("Pneumonia Confirmed by X-Ray")] public string Pneumonia_Xray { get; set; }
        [JsonProperty("Fever")] public string Fever { get; set; }
        [JsonProperty("Fever Onset Date")] public string FeverDate { get; set; }
        [JsonProperty("Cough")] public string Cough { get; set; }
        [JsonProperty("Cough Onset Date")] public string Cough_date { get; set; }
        [JsonProperty("New Loss of Taste or Smell")] public string NewLossOfTasteOrSmell { get; set; }
        [JsonProperty("New Loss of Taste or Smell Onset Date")] public string NewLossOfTasteOrSmellDate { get; set; }
        [JsonProperty("Fatigue")] public string Fatigue { get; set; }
        [JsonProperty("Fatigue Onset Date")] public string FatigueDate { get; set; }
        [JsonProperty("Chills or Rigors")] public string ChillsOrRigors { get; set; }
        [JsonProperty("Chills or Rigors Onset Date")] public string ChillsOrRigorsDate { get; set; }
        [JsonProperty("Headache")] public string Headache { get; set; }
        [JsonProperty("Headache Onset Date")] public string HeadacheDate { get; set; }
        [JsonProperty("Diarrhea")] public string Diarrhea { get; set; }
        [JsonProperty("Diarrhea Onset Date")] public string DiarrheaDate { get; set; }
        [JsonProperty("Nausea")] public string Nausea { get; set; }
        [JsonProperty("Nausea Onset Date")] public string NauseaDate { get; set; }
        [JsonProperty("Shortness of Breath")] public string ShortnessOfBreath { get; set; }
        [JsonProperty("Shortness of Breath Onset Date")] public string ShortnessOfBreathDate { get; set; }
        [JsonProperty("Sore Throat")] public string SoreThroat { get; set; }
        [JsonProperty("Sore Throat Onset Date")] public string SoreThroatDate { get; set; }
        [JsonProperty("Runny or Stuffy Nose")] public string RunnyOrStuffyNose { get; set; }
        [JsonProperty("Runny or Stuffy Nose Onset Date")] public string RunnyOrStuffyNoseDate { get; set; }
        [JsonProperty("Muscle or Body Aches")] public string MuscleOrBodyAches { get; set; }
        [JsonProperty("Muscle or BodyAches Onset Date")] public string MuscleOrBodyAchesDate { get; set; }
        [JsonProperty("Vomiting")] public string Vomiting { get; set; }
        [JsonProperty("Vomiting Onset Date")] public string VomitingDate { get; set; }
        [JsonProperty("Sneezing")] public string Sneezing { get; set; }
        [JsonProperty("Sneezing Onset Date")] public string SneezingDate { get; set; }
        [JsonProperty("Clinical Notes")] public string ClinicalNotes { get; set; }
        [JsonProperty("Person Hospitalized")] public string PersonHospitalized { get; set; }
        [JsonProperty("Oxygen Therapy Required")] public string OxygenTherapyRequired { get; set; }
        [JsonProperty("Admitted in ICU")] public string AdmittedICU { get; set; }
        [JsonProperty("Intubation Required")] public string IntubationRequired { get; set; }
        [JsonProperty("Mechanical Incubation Required")] public string MechanicalIncubationRequired { get; set; }
        [JsonProperty("Hospital Medical Record/ChartNumber")] public string HospitalMedicalRecordChartNumber { get; set; }
        [JsonProperty("Medication Administered 1")] public string MedicationAdministered1 { get; set; }
        [JsonProperty("Dose 1")] public string Dose1 { get; set; }
        [JsonProperty("Comments 1")] public string Comments1 { get; set; }
        [JsonProperty("Medication Administered 2")] public string MedicationAdministered2 { get; set; }
        [JsonProperty("Dose 2")] public string Dose2 { get; set; }
        [JsonProperty("Comments 2")] public string Comments2 { get; set; }
        [JsonProperty("No Risk Medical Conditions")] public string NoRiskMedicalConditions { get; set; }
        [JsonProperty("Cardiac Disease (Not Simple Hypertension): ")] public string CardiacDisease { get; set; }
        [JsonProperty("Chronic Lung Disease")] public string ChronicLungDisease { get; set; }
        [JsonProperty("Haemoglobinopathies")] public string Haemoglobinopathies { get; set; }
        [JsonProperty("Type 2 Diabetes")] public string Type2Diabetes { get; set; }
        [JsonProperty("Type 2 Diabetes Dialysis")] public string Dialysis { get; set; }
        [JsonProperty("Immunosuppressive Condition")] public string ImmunosuppressiveCondition { get; set; }
        [JsonProperty("Immunosuppressive Condition Speficy")] public string ImmunosuppressiveConditionSpecify { get; set; }
        [JsonProperty("Liver Disease")] public string LiverDisease { get; set; }
        [JsonProperty("Metabolic Disease")] public string MetabolicDisease { get; set; }
        [JsonProperty("Neurological Disorder")] public string NeurologicalDisorder { get; set; }
        [JsonProperty("Obesity")] public string Obesity { get; set; }
        [JsonProperty("Renal Disease")] public string RenalDisease { get; set; }
        [JsonProperty("Renal Disease Dialysis")] public string RenalDiseaseDialysis { get; set; }
        [JsonProperty("Other Risk Medical Condition")] public string OtherRiskMedicalCondition { get; set; }
        [JsonProperty("Other Risk Medical Condition Specify")] public string OtherRiskMedicalConditionSpecify { get; set; }
        [JsonProperty("Received COVID-19 Vaccine")] public string ReceivedCOVID19Vaccine { get; set; }
        [JsonProperty("Currently Pregnant")] public string CurrentlyPregnant { get; set; }
        [JsonProperty("Current Smoker")] public string CurrentSmoker { get; set; }
        [JsonProperty("Consume Alcohol")] public string ConsumeAlcohol { get; set; }
        [JsonProperty("Blood Type")] public string BloodType { get; set; }
        [JsonProperty("Weight")] public string ParticipantsWeight { get; set; }
        [JsonProperty("Height")] public string ParticipantsHeight { get; set; }
        [JsonProperty("Fruit  (Tinned/Fresh)")] public string Fruit { get; set; }
        [JsonProperty("Vegetables (Tinned/Frozen)")] public string Vegetables { get; set; }
        [JsonProperty("Whole Meal Breads")] public string WholeMealBreads { get; set; }
        [JsonProperty("Beans Peas and Lentils")] public string BeansPeasLentils { get; set; }
        [JsonProperty("Nuts and Seeds")] public string NutsSeeds { get; set; }
        [JsonProperty("Treatment Regimen")] public string TreatmentRegimen { get; set; }
        [JsonProperty("Day 0 Saliva")] public string Day0Saliva { get; set; }
        [JsonProperty("Day 0 Nasal Swab")] public string Day0NasalSwab { get; set; }
        [JsonProperty("Day 0 Date")] public string Day0Date { get; set; }
        [JsonProperty("Day 2 Saliva")] public string Day2Saliva { get; set; }
        [JsonProperty("Day 2 Nasal Swab")] public string Day2NasalSwab { get; set; }
        [JsonProperty("Day 2 Date")] public string Day2Date { get; set; }
        [JsonProperty("Day 4 Saliva")] public string Day4Saliva { get; set; }
        [JsonProperty("Day 4 Nasal Swab")] public string Day4NasalSwab { get; set; }
        [JsonProperty("Day 4 Date")] public string Day4Date { get; set; }
        [JsonProperty("Day 6 Saliva")] public string Day6Saliva { get; set; }
        [JsonProperty("Day 6 Nasal Swab")] public string Day6NasalSwab { get; set; }
        [JsonProperty("Day 6 Date")] public string Day6Date { get; set; }
        [JsonProperty("Day 8 Saliva")] public string Day8Saliva { get; set; }
        [JsonProperty("Day 8 Nasal Swab")] public string Day8NasalSwab { get; set; }
        [JsonProperty("Day 8 Date")] public string Day8Date { get; set; }
        [JsonProperty("Day 10 Saliva")] public string Day10Saliva { get; set; }
        [JsonProperty("Day 10 Nasal Swab")] public string Day10NasalSwab { get; set; }
        [JsonProperty("Day 10 Date")] public string Day10Date { get; set; }
        [JsonProperty("Day 12 Saliva")] public string Day12Saliva { get; set; }
        [JsonProperty("Day 12 Nasal Swab")] public string Day12NasalSwab { get; set; }
        [JsonProperty("Day 12 Date")] public string Day12Date { get; set; }
        [JsonProperty("Day 14 Saliva")] public string Day14Saliva { get; set; }
        [JsonProperty("Day 14 Nasal Swab")] public string Day14NasalSwab { get; set; }
        [JsonProperty("Day 14 Date")] public string Day14Date { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
