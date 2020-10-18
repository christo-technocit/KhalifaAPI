using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
    public class QuestionnaireWrap7
    {
        public QuestionnaireWrap7()
        {
            result = new List<Q7ViewModel>();

        }
        public IEnumerable<Q7ViewModel> result { get; set; }

    }
    public class Q7ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        [JsonProperty("Sample Id")] public string SampleID { get; set; }
        [JsonProperty("Collection Point")] public string CollectionPoint { get; set; }
        [JsonProperty("Collected By")] public string CollectedBy { get; set; }
        [JsonProperty("Date Of Assessment")] public string DateofAssessment { get; set; }
        [JsonProperty("T1D Child")] public string PERS_T1DChild { get; set; }
        [JsonProperty("Year Of Diagnosis")] public string PERS_YearofDiagnosis { get; set; }
        [JsonProperty("Mother")] public string PERS_Mother { get; set; }
        [JsonProperty("Father")] public string PERS_Father { get; set; }
        [JsonProperty("Sibling")] public string PERS_Sibling { get; set; }
        [JsonProperty("Name")] public string PERS_Firstname { get; set; }
        [JsonProperty("Middle Name")] public string PERS_MiddleName { get; set; }
        [JsonProperty("Family  Name")] public string PERS_FamilyName { get; set; }
        [JsonProperty("Gender")] public string PERS_Gender { get; set; }
        [JsonProperty("Place Of Birth")] public string PERS_PlaceofBirth { get; set; }
        [JsonProperty("Date Of Birth")] public string PERS_DateofBirth { get; set; }
        [JsonProperty("Nationality")] public string PERS_Nationality { get; set; }
        [JsonProperty("Marital Status")] public string PERS_MaritalStatus { get; set; }
        [JsonProperty("Ethnicity")] public string PERS_Ethnicity { get; set; }
        [JsonProperty("Age Of Parent During Pregnancy")] public string PERS_ParentAgeDuringPregnancy { get; set; }
        [JsonProperty("Consanguineous Marriage")] public string PERS_marriage_con { get; set; }
        [JsonProperty("Number Of Children")] public string PERS_NumberofChildren { get; set; }
        [JsonProperty("Address")] public string PERS_Address { get; set; }
        [JsonProperty("Mobile Number")] public string PERS_Mobile_Number { get; set; }
        [JsonProperty("Siblings Diagnosed With Diabetes Type 1")] public string PERS_SiblingDiabetesType1 { get; set; }
        [JsonProperty("Body Weight Without Shoes (Kg)")] public string CLIN_BodyWeight_KG { get; set; }
        [JsonProperty("Height Without Shoes (M)")] public string CLIN_Height_CM { get; set; }
        [JsonProperty("Body Mass Index(Kg/M2)")] public string CLIN_BMI_KGM2 { get; set; }
        [JsonProperty("Waist Circumference (Cm)")] public string CLIN_WaistCircumference_CM { get; set; }
        [JsonProperty("Systolic Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        [JsonProperty("Diastolic Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_DIA_mmHg { get; set; }
        [JsonProperty("Hypertension")] public string CLIN_Hypertension { get; set; }
        [JsonProperty("Age Of Hypertension Diagnose")] public string CLIN_HypertensionAge { get; set; }
        [JsonProperty("Diabetes")] public string CLIN_Diabetes { get; set; }
        [JsonProperty("Diabetes Type")] public string CLIN_DiabetesType { get; set; }
        [JsonProperty("Age Of Diabetes Diagnose")] public string CLIN_DiabetesAge { get; set; }
        [JsonProperty("Other Diseases")] public string CLIN_OtherDiseases { get; set; }
        [JsonProperty("Medical Conditions")] public string CLIN_MC { get; set; }
        [JsonProperty(" Medical Conditions Remarks")] public string CLIN_MC_YesRemarks { get; set; }
        [JsonProperty("Type 2 Diabetes Mellitus")] public string CLIN_MC_Type2Diabetes { get; set; }
        [JsonProperty("Type 1 Diabetes")] public string CLIN_MC_Type1Diabetes { get; set; }
        [JsonProperty("MC Hypertension")] public string CLIN_MC_Hypertension { get; set; }
        [JsonProperty("Dyslipidemia")] public string CLIN_MC_Dyslipidemia { get; set; }
        [JsonProperty("Diabetes Related Complications")] public string CLIN_MC_DiabetesComplications { get; set; }
        [JsonProperty("Retinopathy")] public string CLIN_MC_Diabetes_Retinopathy { get; set; }
        [JsonProperty("Neuropathy")] public string CLIN_MC_Diabetes_Neuropathy { get; set; }
        [JsonProperty("Neuropathy Other")] public string CLIN_MC_Diabetes_Neuropathy_Other { get; set; }
        [JsonProperty("Cerebrovascular Accident (C.V.A)")] public string CLIN_MC_Diabetes_CVA { get; set; }
        [JsonProperty("Nephropathy")] public string CLIN_MC_Diabetes_Nephropathy { get; set; }
        [JsonProperty("Albuminuria")] public string CLIN_MC_Diabetes_Nephropathy_Albuminuria { get; set; }
        [JsonProperty("eGFR")] public string CLIN_MC_Diabetes_Nephropathy_eGFR { get; set; }
        [JsonProperty("Coronary Artery Disease (C.A.D)")] public string CLIN_MC_Diabetes_CAD { get; set; }
        [JsonProperty("Diabetes Others")] public string CLIN_MC_Diabetes_Others { get; set; }
        [JsonProperty("Diabetes Others Remarks")] public string CLIN_MC_Diabetes_Others_Remarks { get; set; }
        [JsonProperty("Past History")] public string CLIN_MC_PastHistory { get; set; }
        [JsonProperty("Autoimmune Diseases")] public string CLIN_MC_PastHistory_Autoimmune { get; set; }
        [JsonProperty("Celiac")] public string CLIN_MC_PastHistory_Celiac { get; set; }
        [JsonProperty("Hypothyroidism")] public string CLIN_MC_PastHistory_Hypothyroidism { get; set; }
        [JsonProperty("Arthritis")] public string CLIN_MC_PastHistory_Arthritis { get; set; }
        [JsonProperty("Past History Other")] public string CLIN_MC_PastHistory_Other { get; set; }
        [JsonProperty("Past History Other Remarks")] public string CLIN_MC_PastHistory_Other_Remarks { get; set; }
        [JsonProperty("HbA1C (%) Date")] public string BIOC_HbA1c_Test_Date { get; set; }
        [JsonProperty("HbA1C (%) Result")] public string BIOC_HbA1c_Test_Result { get; set; }
        [JsonProperty("HbA1C (%) Result Normal")] public string BIOC_HbA1c_IsNormalResult { get; set; }
        [JsonProperty("Total Cholesterol (Mg/Dl) Date")] public string BIOC_TotalCholesterol_Test_Date { get; set; }
        [JsonProperty("Total Cholesterol (Mg/Dl)  Result")] public string BIOC_TotalCholesterol_Result { get; set; }
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
        [JsonProperty("Vitamin D Level (Ng/Ml) Date")] public string BIOC_VitaminDLevel_Test_Date { get; set; }
        [JsonProperty("Vitamin D Level (Ng/Ml) Result")] public string BIOC_VitaminDLevel_Result { get; set; }
        [JsonProperty("Vitamin D Level (Ng/Ml) Result Normal")] public string BIOC_VitaminDLevel_IsNormalResult { get; set; }
        [JsonProperty("HCO3PH At Diagnosis Date")] public string BIOC_HCO3PH_Test_Date { get; set; }
        [JsonProperty("HCO3PH At Diagnosis Result")] public string BIOC_HCO3PH_Result { get; set; }
        [JsonProperty("HCO3PH At Diagnosis Result Normal")] public string BIOC_HCO3PH_IsNormalResult { get; set; }
        [JsonProperty("Fasting CPEP Date")] public string BIOC_FastingCPEP_Test_Date { get; set; }
        [JsonProperty("Fasting CPEP Result")] public string BIOC_FastingCPEP_Result { get; set; }
        [JsonProperty("Fasting CPEP Normal Result")] public string BIOC_FastingCPEP_IsNormalResult { get; set; }
        [JsonProperty("Haemoglobin Date")] public string BIOC_FBC_Haemoglobin_Test_Date { get; set; }
        [JsonProperty("Haemoglobin Result")] public string BIOC_FBC_Haemoglobin_Result { get; set; }
        [JsonProperty("Haemoglobin Normal Result")] public string BIOC_FBC_Haemoglobin_IsNormalResult { get; set; }
        [JsonProperty("White Cell Count Date")] public string BIOC_FBC_WhiteCellCount_Test_Date { get; set; }
        [JsonProperty("White Cell Count Result")] public string BIOC_FBC_WhiteCellCount_Result { get; set; }
        [JsonProperty("White Cell Count Normal Result")] public string BIOC_FBC_WhiteCellCount_IsNormalResult { get; set; }
        [JsonProperty("Platelets Date")] public string BIOC_FBC_Platelets_Test_Date { get; set; }
        [JsonProperty("Platelets Result")] public string BIOC_FBC_Platelets_Result { get; set; }
        [JsonProperty("Platelets Normal Result")] public string BIOC_FBC_Platelets_IsNormalResult { get; set; }
        [JsonProperty("Neutrophils Date")] public string BIOC_FBC_Neutrophils_Test_Date { get; set; }
        [JsonProperty("Neutrophils Result")] public string BIOC_FBC_Neutrophils_Result { get; set; }
        [JsonProperty("Neutrophils Normal Result")] public string BIOC_FBC_Neutrophils_IsNormalResult { get; set; }
        [JsonProperty("Lymphocytes Date")] public string BIOC_FBC_Lymphocytes_Test_Date { get; set; }
        [JsonProperty("Lymphocytes Result")] public string BIOC_FBC_Lymphocytes_Result { get; set; }
        [JsonProperty("Lymphocytes Normal Result")] public string BIOC_FBC_Lymphocytes_IsNormalResult { get; set; }
        [JsonProperty("Monocytes Date")] public string BIOC_FBC_Monocytes_Test_Date { get; set; }
        [JsonProperty("Monocytes Result")] public string BIOC_FBC_Monocytes_Result { get; set; }
        [JsonProperty("Monocytes Normal Result")] public string BIOC_FBC_Monocytes_IsNormalResult { get; set; }
        [JsonProperty("Eosinophils Date")] public string BIOC_FBC_Eosinophils_Test_Date { get; set; }
        [JsonProperty("Eosinophils Result")] public string BIOC_FBC_Eosinophils_Result { get; set; }
        [JsonProperty("Eosinophils Normal Result")] public string BIOC_FBC_Eosinophils_IsNormalResult { get; set; }
        [JsonProperty("Haematocrit Date ")] public string BIOC_FBC_Haematocrit_Test_Date { get; set; }
        [JsonProperty("Haematocrit Result")] public string BIOC_FBC_Haematocrit_Result { get; set; }
        [JsonProperty("Haematocrit Normal Result")] public string BIOC_FBC_Haematocrit_IsNormalResult { get; set; }
        [JsonProperty("MCV Date")] public string BIOC_FBC_MCV_Test_Date { get; set; }
        [JsonProperty("MCV Result")] public string BIOC_FBC_MCV_Result { get; set; }
        [JsonProperty("MCV Normal Result")] public string BIOC_FBC_MCV_IsNormalResult { get; set; }
        [JsonProperty("MCH Date")] public string BIOC_FBC_MCH_Test_Date { get; set; }
        [JsonProperty("MCH Result")] public string BIOC_FBC_MCH_Result { get; set; }
        [JsonProperty("MCH Normal Result")] public string BIOC_FBC_MCH_IsNormalResult { get; set; }
        [JsonProperty("MCHC Date ")] public string BIOC_FBC_MCHC_Test_Date { get; set; }
        [JsonProperty("MCHC Result")] public string BIOC_FBC_MCHC_Result { get; set; }
        [JsonProperty("MCHC Normal Result")] public string BIOC_FBC_MCHC_IsNormalResult { get; set; }
        [JsonProperty("Smoking Status")] public string LIFE_SmokingStatus { get; set; }
        [JsonProperty("Medications")] public string MEDI_Any_Medication { get; set; }
        [JsonProperty("Medication Remarks")] public string MEDI_Any_Medication_Remarks { get; set; }
        [JsonProperty("Current Insulin Dose (Unit/Kg/Day)")] public string MEDI_CurrentInsulinDose { get; set; }
        [JsonProperty("T1D In The Family")] public string FAMH_T1DFamily { get; set; }
        [JsonProperty("T2D In The Family")] public string FAMH_T2DFamily { get; set; }
        [JsonProperty("Diabetes Complication In The Family")] public string FAMH_Diabetescomplication { get; set; }
        [JsonProperty("Diabetes Complication Remarks")] public string FAMH_Diabetescomplication_Remarks { get; set; }
        [JsonProperty("Obesity In The Family")] public string FAMH_Obesity { get; set; }
        [JsonProperty("Hypertension In The Family")] public string FAMH_Hypertension { get; set; }
        [JsonProperty("Dyslipidaemia In The Family")] public string FAMH_Dyslipidaemia { get; set; }
        [JsonProperty("Other Disease In The Family")] public string FAMH_OtherDisease { get; set; }
        [JsonProperty("Other Disease Remark")] public string FAMH_OtherDisease_Remarks { get; set; }
        [JsonProperty("Family Members With Diabetes")] public string FAPD_MemberDiabetes { get; set; }
        [JsonProperty("Other Rel.")] public string PERS_OtherRel { get; set; }
        [JsonProperty("Other Rel. Remarks")] public string PERS_OtherRel_Remarks { get; set; }
        [JsonProperty("Other Con. ")] public string CLIN_MC_OtherCon { get; set; }
        [JsonProperty("Other Con. Remarks")] public string CLIN_MC_OtherCon_Remarks { get; set; }
        [JsonProperty("Full Blood Count Date")] public string BIOC_FBC_Test_Date { get; set; }
        [JsonProperty("Full Blood Count Result")] public string BIOC_FBC_Result { get; set; }
        [JsonProperty("Full Blood Count Normal Result")] public string BIOC_FBC_IsNormalResult { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
