using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
    //public class QuestionnaireWrap7
    //{
    //    public QuestionnaireWrap7()
    //    {
    //        result = new List<Questionnaire7>();

    //    }
    //    public IEnumerable<Questionnaire7> result { get; set; }

    //}
    public class Questionnaire7
    {
        [Key]
        public string savedformID { get; set; }
        public string Depository_ID { get; set; }
        public string SampleID { get; set; }
        public string CollectionPoint { get; set; }
        public string CollectedBy { get; set; }
        public string DateofAssessment { get; set; }
        public string PERS_T1DChild { get; set; }
        public string PERS_YearofDiagnosis { get; set; }
        public string PERS_Mother { get; set; }
        public string PERS_Father { get; set; }
        public string PERS_Sibling { get; set; }
        public string PERS_Firstname { get; set; }
        public string PERS_MiddleName { get; set; }
        public string PERS_FamilyName { get; set; }
        public string PERS_Gender { get; set; }
        public string PERS_PlaceofBirth { get; set; }
        public string PERS_DateofBirth { get; set; }
        public string PERS_Nationality { get; set; }
        public string PERS_MaritalStatus { get; set; }
        public string PERS_Ethnicity { get; set; }
        public string PERS_ParentAgeDuringPregnancy { get; set; }
        public string PERS_marriage_con { get; set; }
        public string PERS_NumberofChildren { get; set; }
        public string PERS_Address { get; set; }
        public string PERS_Mobile_Number { get; set; }
        public string PERS_SiblingDiabetesType1 { get; set; }
        public string CLIN_BodyWeight_KG { get; set; }
        public string CLIN_Height_CM { get; set; }
        public string CLIN_BMI_KGM2 { get; set; }
        public string CLIN_WaistCircumference_CM { get; set; }
        public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        public string CLIN_BloodPressure_DIA_mmHg { get; set; }
        public string CLIN_Hypertension { get; set; }
        public string CLIN_HypertensionAge { get; set; }
        public string CLIN_Diabetes { get; set; }
        public string CLIN_DiabetesType { get; set; }
        public string CLIN_DiabetesAge { get; set; }
        public string CLIN_OtherDiseases { get; set; }
        public string CLIN_MC { get; set; }
        public string CLIN_MC_YesRemarks { get; set; }
        public string CLIN_MC_Type2Diabetes { get; set; }
        public string CLIN_MC_Type1Diabetes { get; set; }
        public string CLIN_MC_Hypertension { get; set; }
        public string CLIN_MC_Dyslipidemia { get; set; }
        public string CLIN_MC_DiabetesComplications { get; set; }
        public string CLIN_MC_Diabetes_Retinopathy { get; set; }
        public string CLIN_MC_Diabetes_Neuropathy { get; set; }
        public string CLIN_MC_Diabetes_Neuropathy_Other { get; set; }
        public string CLIN_MC_Diabetes_CVA { get; set; }
        public string CLIN_MC_Diabetes_Nephropathy { get; set; }
        public string CLIN_MC_Diabetes_Nephropathy_Albuminuria { get; set; }
        public string CLIN_MC_Diabetes_Nephropathy_eGFR { get; set; }
        public string CLIN_MC_Diabetes_CAD { get; set; }
        public string CLIN_MC_Diabetes_Others { get; set; }
        public string CLIN_MC_Diabetes_Others_Remarks { get; set; }
        public string CLIN_MC_PastHistory { get; set; }
        public string CLIN_MC_PastHistory_Autoimmune { get; set; }
        public string CLIN_MC_PastHistory_Celiac { get; set; }
        public string CLIN_MC_PastHistory_Hypothyroidism { get; set; }
        public string CLIN_MC_PastHistory_Arthritis { get; set; }
        public string CLIN_MC_PastHistory_Other { get; set; }
        public string CLIN_MC_PastHistory_Other_Remarks { get; set; }
        public string BIOC_HbA1c_Test_Date { get; set; }
        public string BIOC_HbA1c_Test_Result { get; set; }
        public string BIOC_HbA1c_IsNormalResult { get; set; }
        public string BIOC_TotalCholesterol_Test_Date { get; set; }
        public string BIOC_TotalCholesterol_Result { get; set; }
        public string BIOC_TotalCholesterol_IsNormalResult { get; set; }
        public string BIOC_Triglyceride_Test_Date { get; set; }
        public string BIOC_Triglyceride_Result { get; set; }
        public string BIOC_Triglyceride_IsNormalResult { get; set; }
        public string BIOC_HDL_Test_Date { get; set; }
        public string BIOC_HDL_Result { get; set; }
        public string BIOC_HDL_IsNormalResult { get; set; }
        public string BIOC_LDL_Test_Date { get; set; }
        public string BIOC_LDL_Result { get; set; }
        public string BIOC_LDL_IsNormalResult { get; set; }
        public string BIOC_VitaminDLevel_Test_Date { get; set; }
        public string BIOC_VitaminDLevel_Result { get; set; }
        public string BIOC_VitaminDLevel_IsNormalResult { get; set; }
        public string BIOC_HCO3PH_Test_Date { get; set; }
        public string BIOC_HCO3PH_Result { get; set; }
        public string BIOC_HCO3PH_IsNormalResult { get; set; }
        public string BIOC_FastingCPEP_Test_Date { get; set; }
        public string BIOC_FastingCPEP_Result { get; set; }
        public string BIOC_FastingCPEP_IsNormalResult { get; set; }
        public string BIOC_FBC_Haemoglobin_Test_Date { get; set; }
        public string BIOC_FBC_Haemoglobin_Result { get; set; }
        public string BIOC_FBC_Haemoglobin_IsNormalResult { get; set; }
        public string BIOC_FBC_WhiteCellCount_Test_Date { get; set; }
        public string BIOC_FBC_WhiteCellCount_Result { get; set; }
        public string BIOC_FBC_WhiteCellCount_IsNormalResult { get; set; }
        public string BIOC_FBC_Platelets_Test_Date { get; set; }
        public string BIOC_FBC_Platelets_Result { get; set; }
        public string BIOC_FBC_Platelets_IsNormalResult { get; set; }
        public string BIOC_FBC_Neutrophils_Test_Date { get; set; }
        public string BIOC_FBC_Neutrophils_Result { get; set; }
        public string BIOC_FBC_Neutrophils_IsNormalResult { get; set; }
        public string BIOC_FBC_Lymphocytes_Test_Date { get; set; }
        public string BIOC_FBC_Lymphocytes_Result { get; set; }
        public string BIOC_FBC_Lymphocytes_IsNormalResult { get; set; }
        public string BIOC_FBC_Monocytes_Test_Date { get; set; }
        public string BIOC_FBC_Monocytes_Result { get; set; }
        public string BIOC_FBC_Monocytes_IsNormalResult { get; set; }
        public string BIOC_FBC_Eosinophils_Test_Date { get; set; }
        public string BIOC_FBC_Eosinophils_Result { get; set; }
        public string BIOC_FBC_Eosinophils_IsNormalResult { get; set; }
        public string BIOC_FBC_Haematocrit_Test_Date { get; set; }
        public string BIOC_FBC_Haematocrit_Result { get; set; }
        public string BIOC_FBC_Haematocrit_IsNormalResult { get; set; }
        public string BIOC_FBC_MCV_Test_Date { get; set; }
        public string BIOC_FBC_MCV_Result { get; set; }
        public string BIOC_FBC_MCV_IsNormalResult { get; set; }
        public string BIOC_FBC_MCH_Test_Date { get; set; }
        public string BIOC_FBC_MCH_Result { get; set; }
        public string BIOC_FBC_MCH_IsNormalResult { get; set; }
        public string BIOC_FBC_MCHC_Test_Date { get; set; }
        public string BIOC_FBC_MCHC_Result { get; set; }
        public string BIOC_FBC_MCHC_IsNormalResult { get; set; }
        public string LIFE_SmokingStatus { get; set; }
        public string MEDI_Any_Medication { get; set; }
        public string MEDI_Any_Medication_Remarks { get; set; }
        public string MEDI_CurrentInsulinDose { get; set; }
        public string FAMH_T1DFamily { get; set; }
        public string FAMH_T2DFamily { get; set; }
        public string FAMH_Diabetescomplication { get; set; }
        public string FAMH_Diabetescomplication_Remarks { get; set; }
        public string FAMH_Obesity { get; set; }
        public string FAMH_Hypertension { get; set; }
        public string FAMH_Dyslipidaemia { get; set; }
        public string FAMH_OtherDisease { get; set; }
        public string FAMH_OtherDisease_Remarks { get; set; }
        public string FAPD_MemberDiabetes { get; set; }
        public string PERS_OtherRel { get; set; }
        public string PERS_OtherRel_Remarks { get; set; }
        public string CLIN_MC_OtherCon { get; set; }
        public string CLIN_MC_OtherCon_Remarks { get; set; }
    }
}
