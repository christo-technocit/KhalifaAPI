using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
    public class QuestionnaireWrap5
    {
        public QuestionnaireWrap5()
        {
            result = new List<Q5ViewModel>();

        }
        public IEnumerable<Q5ViewModel> result { get; set; }

    }
    public class Q5ViewModel
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
        [JsonProperty("Body Mass")] public string CLIN_BMI_KGM2 { get; set; }
        [JsonProperty("Waist Circumference")] public string CLIN_WaistCircumference_CM { get; set; }
        [JsonProperty("Hip Circumference")] public string CLIN_Hipcircumference_CM { get; set; }
        [JsonProperty("Vertical Trunk Circumference")] public string CLIN_VerticalTrunkCircumference_CM { get; set; }
        [JsonProperty("WHR (Wc/Hc)")] public string CLIN_WHR { get; set; }
        [JsonProperty("Body Fat Mass (Kg)")] public string CLIN_BodyFatMass_Kg { get; set; }
        [JsonProperty("Body Fat Percentage (%)")] public string CLIN_BMIFatPercent { get; set; }
        [JsonProperty("Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_mmHg { get; set; }
        [JsonProperty("Have Any Medical Conditions")] public string CLIN_MC { get; set; }
        [JsonProperty("Type 2 Diabetes Mellitus")] public string CLIN_MC_Type2Diabetes { get; set; }
        [JsonProperty("Hypertension")] public string CLIN_MC_Hypertension { get; set; }
        [JsonProperty("Dyslipidemia")] public string CLIN_MC_Dyslipidemia { get; set; }
        [JsonProperty("Respiratory Disease")] public string CLIN_MC_Respiratory { get; set; }
        [JsonProperty("Gastrointestinal System")] public string CLIN_MC_Gastrointestinal { get; set; }
        [JsonProperty("Other")] public string CLIN_MC_Others { get; set; }
        [JsonProperty("Specify")] public string CLIN_MC_Others_Remarks { get; set; }
        [JsonProperty("FBG (Mmol/L) Recent Date")] public string BIOC_FastingGlucose_RecentTest_Date_PO { get; set; }
        [JsonProperty("FBG (Mmol/L) Recent Result")] public string BIOC_FastingGlucose_RecentTest_Result_PO { get; set; }
        [JsonProperty("FBG (Mmol/L) Last Date")] public string BIOC_FastingGlucose_LastTest_Date_PO { get; set; }
        [JsonProperty("FBG (Mmol/L) Last Result ")] public string BIOC_FastingGlucose_LastTest_Result_PO { get; set; }
        [JsonProperty("FBG (Mmol/L) Result Normal")] public string BIOC_FastingGlucose_IsNormalResult_PO { get; set; }
        [JsonProperty("Random Glucose Level Recent Date")] public string BIOC_RandomGlucose_RecentTest_Date_PO { get; set; }
        [JsonProperty("Random Glucose Level Recent Result")] public string BIOC_RandomGlucose_RecentTest_Result_PO { get; set; }
        [JsonProperty("Random Glucose Level Last Date")] public string BIOC_RandomGlucose_LastTest_Date_PO { get; set; }
        [JsonProperty("Random Glucose Level Last Result ")] public string BIOC_RandomGlucose_LastTest_Result_PO { get; set; }
        [JsonProperty("Random Glucose LevelResult Normal")] public string BIOC_RandomGlucose_IsNormalResult_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG Recent Date")] public string BIOC_OGTT_FBG_RecentTest_Date_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG Recent Result")] public string BIOC_OGTT_FBG_RecentTest_Result_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG Last Date")] public string BIOC_OGTT_FBG_LastTest_Date_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG Last Result ")] public string BIOC_OGTT_FBG_LastTest_Result_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG Result Normal")] public string BIOC_OGTT_FBG_IsNormalResult_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hrs Recent Date")] public string BIOC_OGTT_FBG2_RecentTest_Date_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hrs Recent Result")] public string BIOC_OGTT_FBG2_RecentTest_Result_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hrs Last Date")] public string BIOC_OGTT_FBG2_LastTest_Date_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hrs Last Result ")] public string BIOC_OGTT_FBG2_LastTest_Result_PO { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hrs Result Normal")] public string BIOC_OGTT_FBG2_IsNormalResult_PO { get; set; }
        [JsonProperty("HbA1c (%) Recent Date")] public string BIOC_HbA1c_RecentTest_Date_PO { get; set; }
        [JsonProperty("HbA1c (%) Recent Result")] public string BIOC_HbA1c_RecentTest_Result_PO { get; set; }
        [JsonProperty("HbA1c (%) Last Date")] public string BIOC_HbA1c_LastTest_Date_PO { get; set; }
        [JsonProperty("HbA1c (%) Last Result ")] public string BIOC_HbA1c_LastTest_Result_PO { get; set; }
        [JsonProperty("HbA1c (%) Result Normal")] public string BIOC_HbA1c_IsNormalResult_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Recent Date")] public string BIOC_TotalCholesterol_RecentTest_Date_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Recent Result")] public string BIOC_TotalCholesterol_RecentTest_Result_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Last Date")] public string BIOC_TotalCholesterol_LastTest_Date_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Last Result ")] public string BIOC_TotalCholesterol_LastTest_Result_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Result Normal")] public string BIOC_TotalCholesterol_IsNormalResult_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Recent Date")] public string BIOC_Triglyceride_RecentTest_Date_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Recent Result")] public string BIOC_Triglyceride_RecentTest_Result_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Last Date")] public string BIOC_Triglyceride_LastTest_Date_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Last Result ")] public string BIOC_Triglyceride_LastTest_Result_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Result Normal")] public string BIOC_Triglyceride_IsNormalResult_PO { get; set; }
        [JsonProperty("HDL (Mmol/L) Recent Date")] public string BIOC_HDL_RecentTest_Date_PO { get; set; }
        [JsonProperty("HDL (Mmol/L) Recent Result")] public string BIOC_HDL_RecentTest_Result_PO { get; set; }
        [JsonProperty("HDL (Mmol/L) Last Date")] public string BIOC_HDL_LastTest_Date_PO { get; set; }
        [JsonProperty("HDL (Mmol/L) Last Result ")] public string BIOC_HDL_LastTest_Result_PO { get; set; }
        [JsonProperty("HDL (Mmol/L) Result Normal")] public string BIOC_HDL_IsNormalResult_PO { get; set; }
        [JsonProperty("LDL (Mmol/L) Recent Date")] public string BIOC_LDL_RecentTest_Date_PO { get; set; }
        [JsonProperty("LDL (Mmol/L) Recent Result")] public string BIOC_LDL_RecentTest_Result_PO { get; set; }
        [JsonProperty("LDL (Mmol/L) Last Date")] public string BIOC_LDL_LastTest_Date_PO { get; set; }
        [JsonProperty("LDL (Mmol/L) Last Result ")] public string BIOC_LDL_LastTest_Result_PO { get; set; }
        [JsonProperty("LDL (Mmol/L) Result Normal")] public string BIOC_LDL_IsNormalResult_PO { get; set; }
        [JsonProperty("Microalbumin (Mg) Recent Date")] public string BIOC_Microalbumin_RecentTest_Date_PO { get; set; }
        [JsonProperty("Microalbumin (Mg) Recent Result")] public string BIOC_Microalbumin_RecentTest_Result_PO { get; set; }
        [JsonProperty("Microalbumin (Mg) Last Date")] public string BIOC_Microalbumin_LastTest_Date_PO { get; set; }
        [JsonProperty("Microalbumin (Mg) Last Result ")] public string BIOC_Microalbumin_LastTest_Result_PO { get; set; }
        [JsonProperty("Microalbumin (Mg) Result Normal")] public string BIOC_Microalbumin_IsNormalResult_PO { get; set; }
        [JsonProperty("Creatinine Recent Date")] public string BIOC_Creatinine_RecentTest_Date_PO { get; set; }
        [JsonProperty("Creatinine Recent Result")] public string BIOC_Creatinine_RecentTest_Result_PO { get; set; }
        [JsonProperty("Creatinine Last Date")] public string BIOC_Creatinine_LastTest_Date_PO { get; set; }
        [JsonProperty("Creatinine Last Result")] public string BIOC_Creatinine_LastTest_Result_PO { get; set; }
        [JsonProperty("Creatinine Result Normal")] public string BIOC_Creatinine_IsNormalResult_PO { get; set; }
        [JsonProperty("Urea Recent Date")] public string BIOC_Urea_RecentTest_Date_PO { get; set; }
        [JsonProperty("Urea Recent Result")] public string BIOC_Urea_RecentTest_Result_PO { get; set; }
        [JsonProperty("Urea Last Date")] public string BIOC_Urea_LastTest_Date_PO { get; set; }
        [JsonProperty("Urea Last Result ")] public string BIOC_Urea_LastTest_Result_PO { get; set; }
        [JsonProperty("Urea Result Normal")] public string BIOC_Urea_IsNormalResult_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Recent Date")] public string BIOC_VitaminDLevel_RecentTest_Date_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Recent Result")] public string BIOC_VitaminDLevel_RecentTest_Result_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Last Date")] public string BIOC_VitaminDLevel_LastTest_Date_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Last Result ")] public string BIOC_VitaminDLevel_LastTest_Result_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Result Normal")] public string BIOC_VitaminDLevel_IsNormalResult_PO { get; set; }
        [JsonProperty("Lepatin Recent Date")] public string BIOC_Lepatin_RecentTest_Date_PO { get; set; }
        [JsonProperty("Lepatin Recent Result")] public string BIOC_Lepatin_RecentTest_Result_PO { get; set; }
        [JsonProperty("Lepatin Last Date")] public string BIOC_Lepatin_LastTest_Date_PO { get; set; }
        [JsonProperty("Lepatin Last Result ")] public string BIOC_Lepatin_LastTest_Result_PO { get; set; }
        [JsonProperty("Lepatin Result Normal")] public string BIOC_Lepatin_IsNormalResult_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Recent Date")] public string BIOC_LepatinReceptor_RecentTest_Date_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Recent Result")] public string BIOC_LepatinReceptor_RecentTest_Result_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Last Date")] public string BIOC_LepatinReceptor_LastTest_Date_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Last Result ")] public string BIOC_LepatinReceptor_LastTest_Result_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Result Normal")] public string BIOC_LepatinReceptor_IsNormalResult_PO { get; set; }
        [JsonProperty("CRP (Ng/Ml) Recent Date")] public string BIOC_CRP_RecentTest_Date_PO { get; set; }
        [JsonProperty("CRP (Ng/Ml) Recent Result")] public string BIOC_CRP_RecentTest_Result_PO { get; set; }
        [JsonProperty("CRP (Ng/Ml) Last Date")] public string BIOC_CRP_LastTest_Date_PO { get; set; }
        [JsonProperty("CRP (Ng/Ml) Last Result ")] public string BIOC_CRP_LastTest_Result_PO { get; set; }
        [JsonProperty("CRP (Ng/Ml) Result Normal")] public string BIOC_CRP_IsNormalResult_PO { get; set; }
        [JsonProperty("TNF (Ng/Ml) Recent Date")] public string BIOC_TNF_RecentTest_Date_PO { get; set; }
        [JsonProperty("TNF (Ng/Ml) Recent Result")] public string BIOC_TNF_RecentTest_Result_PO { get; set; }
        [JsonProperty("TNF (Ng/Ml) Last Date")] public string BIOC_TNF_LastTest_Date_PO { get; set; }
        [JsonProperty("TNF (Ng/Ml) Last Result ")] public string BIOC_TNF_LastTest_Result_PO { get; set; }
        [JsonProperty("TNF (Ng/Ml) Result Normal")] public string BIOC_TNF_IsNormalResult_PO { get; set; }
        [JsonProperty("ILF (Ng/Ml) Recent Date")] public string BIOC_ILF_RecentTest_Date_PO { get; set; }
        [JsonProperty("ILF (Ng/Ml) Recent Result")] public string BIOC_ILF_RecentTest_Result_PO { get; set; }
        [JsonProperty("ILF (Ng/Ml) Last Date")] public string BIOC_ILF_LastTest_Date_PO { get; set; }
        [JsonProperty("ILF (Ng/Ml) Last Result ")] public string BIOC_ILF_LastTest_Result_PO { get; set; }
        [JsonProperty("ILF (Ng/Ml) Result Normal")] public string BIOC_ILF_IsNormalResult_PO { get; set; }
        [JsonProperty("Currently On Medication")] public string MEDI_Any_Medication { get; set; }
        [JsonProperty("Medication Remarks")] public string MEDI_Any_Medication_Remarks { get; set; }
        [JsonProperty("Have Allergies")] public string MEDI_Any_Allergies { get; set; }
        [JsonProperty("Allergies Remarks")] public string MEDI_Any_Allergies_Remarks { get; set; }
        [JsonProperty("Have Intolerance")] public string MEDI_Intolerance { get; set; }
        [JsonProperty("Intolerance Remarks")] public string MEDI_Intolerance_Remarks { get; set; }
        [JsonProperty("Skin Colour")] public string SDBC_SkinColor { get; set; }
        [JsonProperty("SocioEconomic Status")] public string SDBC_Socioeconomic { get; set; }
        [JsonProperty("Smoking Status")] public string SDBC_SmokingStatus { get; set; }
        [JsonProperty("Fast Food")] public string FOOD_EatFastfood_Week { get; set; }
        [JsonProperty("Fruit Or Vegetables")] public string FOOD_Fruits_Vegetables_Day { get; set; }
        [JsonProperty("Soda Pop")] public string FOOD_Sodapop_Week { get; set; }
        [JsonProperty("Eat Middle Of The Night")] public string FOOD_Eat_Midnight { get; set; }
        [JsonProperty("Follow A Healthy Diet")] public string FOOD_HealthyDiet { get; set; }
        [JsonProperty("Exercise 30 Min Each Week")] public string PHYA_Exercise_Week { get; set; }
        [JsonProperty("*Satisfied With Your Body")] public string PHYA_Satisfy_Body { get; set; }
        [JsonProperty("Happy About Your Life")] public string PHYA_Happy_Life { get; set; }
        [JsonProperty("Obesity In The Family")] public string FAMI_Obesity { get; set; }
        [JsonProperty("Obesity Complication In The Family")] public string FAMI_ObesityComplication { get; set; }
        [JsonProperty("Obesity Complication Remarks")] public string FAMI_ObesityComplication_Remarks { get; set; }
        [JsonProperty("Diabetes In The Family")] public string FAMI_Diabetes { get; set; }
        [JsonProperty("Hypertension In The Family")] public string FAMI_Hypertension { get; set; }
        [JsonProperty("Dyslipidemia In The Family")] public string FAMI_Dyslipidemia { get; set; }
        [JsonProperty("Systolic BP (Mmhg)")] public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        [JsonProperty("Diastolic BP (Mmhg)")] public string CLIN_BloodPressure_DIA_mmHg { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
