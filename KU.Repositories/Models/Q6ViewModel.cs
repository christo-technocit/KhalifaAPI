using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;


namespace KU.Repositories.Models
{
    public class QuestionnaireWrap6
    {
        public QuestionnaireWrap6()
        {
            result = new List<Q6ViewModel>();

        }
        public IEnumerable<Q6ViewModel> result { get; set; }

    }
    public class Q6ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        [JsonProperty("Sample Id")] public string SampleID { get; set; }
        [JsonProperty("Collection Point")] public string CollectionPoint { get; set; }
        [JsonProperty("Collected By")] public string CollectedBy { get; set; }
        [JsonProperty("Date Of Assessment")] public string DateofAssessment { get; set; }
        [JsonProperty("First Name")] public string PERS_Firstname { get; set; }
        [JsonProperty("Middle Name")] public string PERS_MiddleName { get; set; }
        [JsonProperty("Family  Name")] public string PERS_FamilyName { get; set; }
        [JsonProperty("Date Of Birth")] public string PERS_DateofBirth { get; set; }
        [JsonProperty("Please Of Birth")] public string PERS_PlaceofBirth { get; set; }
        [JsonProperty("Nationality")] public string PERS_Nationality { get; set; }
        [JsonProperty("Ethnicity")] public string PERS_Ethnicity { get; set; }
        [JsonProperty("Ethnicity Mixed Remarks")] public string PERS_Ethnicity_Mixed_Remarks { get; set; }
        [JsonProperty("Ethnicity Others Remarks")] public string PERS_Ethnicity_Others_Remarks { get; set; }
        [JsonProperty("Gender")] public string PERS_Gender { get; set; }
        [JsonProperty("Parents Related")] public string PERS_IsParents_Related { get; set; }
        [JsonProperty("Marital Status")] public string PERS_MaritalStatus { get; set; }
        [JsonProperty("Consanguineous Marriage")] public string PERS_marriage_con { get; set; }
        [JsonProperty("Number Of Wives")] public string PERS_Numberofwives { get; set; }
        [JsonProperty("Number Of Children")] public string PERS_NumberofChildren { get; set; }
        [JsonProperty("Home")] public string PERS_Home_Number { get; set; }
        [JsonProperty("Work")] public string PERS_Work_Number { get; set; }
        [JsonProperty("Mobile Number")] public string PERS_Mobile_Number { get; set; }
        [JsonProperty("Address")] public string PERS_Address { get; set; }
        [JsonProperty("City")] public string PERS_City { get; set; }
        [JsonProperty("Emirates")] public string PERS_Emirates { get; set; }
        [JsonProperty("Body Weight")] public string CLIN_BodyWeight_KG { get; set; }
        [JsonProperty("Height")] public string CLIN_Height_CM { get; set; }
        [JsonProperty("Body Mass Index(Kg/M2)")] public string CLIN_BMI_KGM2 { get; set; }
        [JsonProperty("Waist Circumference (Cm)")] public string CLIN_WaistCircumference_CM { get; set; }
        [JsonProperty("Hip Circumference (Cm)")] public string CLIN_Hipcircumference_CM { get; set; }
        [JsonProperty("Vertical Trunk Circumference (Cm)")] public string CLIN_VerticalTrunkCircumference_CM { get; set; }
        [JsonProperty("WHR (Wc/Hc)")] public string CLIN_WHR { get; set; }
        [JsonProperty("Body Fat Mass (Kg)")] public string CLIN_BodyFatMass_Kg { get; set; }
        [JsonProperty("Body Fat Percentage (%)")] public string CLIN_BMIFatPercent { get; set; }
        [JsonProperty("Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_mmHg { get; set; }
        [JsonProperty("Medical Conditions")] public string CLIN_MC { get; set; }
        [JsonProperty("Medical Conditions Remarks")] public string CLIN_MC_YesRemarks { get; set; }
        [JsonProperty("Type 2 Diabetes Mellitus")] public string CLIN_MC_Type2Diabetes { get; set; }
        [JsonProperty("Hypertension")] public string CLIN_MC_Hypertension { get; set; }
        [JsonProperty("Dyslipidemia")] public string CLIN_MC_Dyslipidemia { get; set; }
        [JsonProperty("Respiratory Disease")] public string CLIN_MC_Respiratory { get; set; }
        [JsonProperty("Gastrointestinal System")] public string CLIN_MC_Gastrointestinal { get; set; }
        [JsonProperty("Others")] public string CLIN_MC_Others { get; set; }
        [JsonProperty("Others Remarks")] public string CLIN_MC_Others_Remarks { get; set; }
        [JsonProperty("Previous Or Current Fractures")] public string CLIN_MC_Fractures { get; set; }
        [JsonProperty("Type  Of Fracture")] public string CLIN_MC_FracturesType { get; set; }
        [JsonProperty("Date Of Fracture")] public string CLIN_MC_FracturesDate { get; set; }
        [JsonProperty("DEXA Readings")] public string CLIN_MC_DEXAReadings { get; set; }
        [JsonProperty("Fasting Glucose Level Date")] public string BIOC_FastingGlucoseLevel_Test_Date { get; set; }
        [JsonProperty("Fasting Glucose Level Result")] public string BIOC_FastingGlucoseLevel_Result { get; set; }
        [JsonProperty("Fasting Glucose Level Result Normal")] public string BIOC_FastingGlucoseLevel_IsNormalResult { get; set; }
        [JsonProperty("Total Cholesterol (Mg/Dl) Date")] public string BIOC_TotalCholesterol_Test_Date { get; set; }
        [JsonProperty("Total Cholesterol (Mg/Dl) Result")] public string BIOC_TotalCholesterol_Result { get; set; }
        [JsonProperty("Total Cholesterol (Mg/Dl) Result Normal")] public string BIOC_TotalCholesterol_IsNormalResult { get; set; }
        [JsonProperty("Triglyceride (Mg/Dl) Date")] public string BIOC_Triglyceride_Test_Date { get; set; }
        [JsonProperty("Triglyceride (Mg/Dl) Result")] public string BIOC_Triglyceride_Result { get; set; }
        [JsonProperty("Triglyceride (Mg/Dl) Result Normal")] public string BIOC_Triglyceride_IsNormalResult { get; set; }
        [JsonProperty("HDL (Mg/Dl) Date")] public string BIOC_HDL_Test_Date { get; set; }
        [JsonProperty("HDL (Mg/Dl) Result")] public string BIOC_HDL_Result { get; set; }
        [JsonProperty("HDL (Mg/Dl) Result Normal")] public string BIOC_HDL_IsNormalResult { get; set; }
        [JsonProperty("LDL (Mg/Dl) Date")] public string BIOC_LDL_Test_Date { get; set; }
        [JsonProperty("LDL (Mg/Dl) Result")] public string BIOC_LDL_Result { get; set; }
        [JsonProperty("LDL (Mg/Dl) Result Normal")] public string BIOC_LDL_IsNormalResult { get; set; }
        [JsonProperty("Creatinine (Mg/Dl) Date")] public string BIOC_Creatinine_Test_Date { get; set; }
        [JsonProperty("Creatinine (Mg/Dl) Result")] public string BIOC_Creatinine_Result { get; set; }
        [JsonProperty("Creatinine (Mg/Dl) Result Normal")] public string BIOC_Creatinine_IsNormalResult { get; set; }
        [JsonProperty("Ca  Date")] public string BIOC_Ca_Test_Date { get; set; }
        [JsonProperty("Ca  Result")] public string BIOC_Ca_Result { get; set; }
        [JsonProperty("Ca Result Normal")] public string BIOC_Ca_IsNormalResult { get; set; }
        [JsonProperty("Vitamin D Level (Ng/Ml Or Nmole/L) Date")] public string BIOC_VitaminDLevel_Test_Date { get; set; }
        [JsonProperty("Vitamin D Level (Ng/Ml Or Nmole/L) Result")] public string BIOC_VitaminDLevel_Result { get; set; }
        [JsonProperty("Vitamin D Level (Ng/Ml Or Nmole/L) Result Normal")] public string BIOC_VitaminDLevel_IsNormalResult { get; set; }
        [JsonProperty("Medication")] public string MEDI_Any_Medication { get; set; }
        [JsonProperty("Medication Remarks")] public string MEDI_Any_Medication_Remarks { get; set; }
        [JsonProperty("Allergies")] public string MEDI_Any_Allergies { get; set; }
        [JsonProperty("Allergies Remarks")] public string MEDI_Any_Allergies_Remarks { get; set; }
        [JsonProperty("Intolerance")] public string MEDI_Intolerance { get; set; }
        [JsonProperty("Intolerance Remarks")] public string MEDI_Intolerance_Remarks { get; set; }
        [JsonProperty("Take Multivitamins")] public string MEDIS_Multivitamins { get; set; }
        [JsonProperty("Multivitamins Contain Vitamin D")] public string MEDIS_Multivitamins_VitaminD { get; set; }
        [JsonProperty("Calcium Supplements")] public string MEDIS_CalciumSupplements { get; set; }
        [JsonProperty("Calcium Supplements Dose")] public string MEDIS_CalciumSupplements_Dose { get; set; }
        [JsonProperty("Vitamin D Supplements")] public string MEDIS_VitaminD { get; set; }
        [JsonProperty("Vitamin D Dose")] public string MEDIS_VitaminD_Dose { get; set; }
        [JsonProperty("Hormone Replacement Therapy")] public string MEDIS_HormoneReplacementTherapy { get; set; }
        [JsonProperty("Hormone Replacement Therapy Remarks")] public string MEDIS_HormoneReplacementTherapy_Remarks { get; set; }
        [JsonProperty("Parents Been Diagnosed With Osteoporosis")] public string OMRT_Q1_Parent_osteoporosis { get; set; }
        [JsonProperty("Parents Have A Stooped Back")] public string OMRT_Q2_Parent_StoopedBack { get; set; }
        [JsonProperty("40 Years Old Or Older")] public string OMRT_Q3_Parent_40YearsOlder { get; set; }
        [JsonProperty("Ever Broken A Bone")] public string OMRT_Q4_BrokenBone { get; set; }
        [JsonProperty("Fall Frequently ")] public string OMRT_Q5_FearFalling { get; set; }
        [JsonProperty("After The Age Of 40 Lost More Than 3 Cm In Height")] public string OMRT_Q6_After40_3cmHeight { get; set; }
        [JsonProperty("Underweight (Body Mass Index Less Than 19 Kg/M2)")] public string OMRT_Q7_Underweight { get; set; }
        [JsonProperty("Taken Corticosteroid Tablets")] public string OMRT_Q8_CorticosteroidTablets { get; set; }
        [JsonProperty("Diagnosed With Rheumatoid Arthritis")] public string OMRT_Q9_RheumatoidArthritis { get; set; }
        [JsonProperty("Diagnosed With An Over-Active Thyroid")] public string OMRT_Q10_OveractiveThyroid { get; set; }
        [JsonProperty("Menopause Occur Before The Age Of 45")] public string OMRT_Q11_Menopause { get; set; }
        [JsonProperty("Periods Ever Stopped For 12 Consecutive Months Or More")] public string OMRT_Q12_PeriodsEver { get; set; }
        [JsonProperty("Ovaries Removed Before Age 50")] public string OMRT_Q13_HormoneReplacementTherapy { get; set; }
        [JsonProperty("Smoked Cigarettes")] public string OMRT_Q14_SmokedCigarettes { get; set; }
        [JsonProperty("Physical Activity Less Than 30 Minutes Per Day")] public string OMRT_Q15_PhysicalActivity { get; set; }
        [JsonProperty("Allergic To Milk Or Dairy Products")] public string OMRT_Q16_Allergic_Milk { get; set; }
        [JsonProperty("Spend Less Than 10 Minutes Per Day Outdoors")] public string OMRT_Q17_OutdoorsSpend { get; set; }
        [JsonProperty("*Osteoporosis In The Family")] public string FAMH_Osteoporosis { get; set; }
        [JsonProperty("*Osteoporosis Complication In The Family:")] public string FAMH_Osteoporosis_complication { get; set; }
        [JsonProperty("Osteoporosis complication Remarks")] public string FAMH_Osteoporosis_complication_Remarks { get; set; }
        [JsonProperty("Obesity In Family")] public string FAMH_Obesity { get; set; }
        [JsonProperty("Bone Fractures In Family")] public string FAMH_BoneFractures { get; set; }
        [JsonProperty("*Cvd In The Family")] public string FAMH_CVD { get; set; }
        [JsonProperty("*Other")] public string FAMH_Other { get; set; }
        [JsonProperty("Systolic Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        [JsonProperty("Diastolic Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_DIA_mmHg { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
