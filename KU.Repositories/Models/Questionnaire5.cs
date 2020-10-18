using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
    //public class QuestionnaireWrap5
    //{
    //    public QuestionnaireWrap5()
    //    {
    //        result = new List<Questionnaire5>();

    //    }
    //    public IEnumerable<Questionnaire5> result { get; set; }

    //}
    public class Questionnaire5
    {
        [Key]
        public string savedformID { get; set; }
        public string Depository_ID { get; set; }
        public string SampleID { get; set; }
        public string CollectionPoint { get; set; }
        public string CollectedBy { get; set; }
        public string DateofAssessment { get; set; }
        public string PERS_Firstname { get; set; }
        public string PERS_MiddleName { get; set; }
        public string PERS_FamilyName { get; set; }
        public string PERS_DateofBirth { get; set; }
        public string PERS_PlaceofBirth { get; set; }
        public string PERS_Nationality { get; set; }
        public string PERS_Ethnicity { get; set; }
        public string PERS_Ethnicity_Mixed_Remarks { get; set; }
        public string PERS_Ethnicity_Others_Remarks { get; set; }
        public string PERS_Gender { get; set; }
        public string PERS_IsParents_Related { get; set; }
        public string PERS_MaritalStatus { get; set; }
        public string PERS_marriage_con { get; set; }
        public string PERS_Numberofwives { get; set; }
        public string PERS_NumberofChildren { get; set; }
        public string PERS_Home_Number { get; set; }
        public string PERS_Work_Number { get; set; }
        public string PERS_Mobile_Number { get; set; }
        public string PERS_Address { get; set; }
        public string PERS_City { get; set; }
        public string PERS_Emirates { get; set; }
        public string CLIN_BodyWeight_KG { get; set; }
        public string CLIN_Height_CM { get; set; }
        public string CLIN_BMI_KGM2 { get; set; }
        public string CLIN_WaistCircumference_CM { get; set; }
        public string CLIN_Hipcircumference_CM { get; set; }
        public string CLIN_VerticalTrunkCircumference_CM { get; set; }
        public string CLIN_WHR { get; set; }
        public string CLIN_BodyFatMass_Kg { get; set; }
        public string CLIN_BMIFatPercent { get; set; }
        public string CLIN_BloodPressure_mmHg { get; set; }
        public string CLIN_MC { get; set; }
        public string CLIN_MC_Type2Diabetes { get; set; }
        public string CLIN_MC_Hypertension { get; set; }
        public string CLIN_MC_Dyslipidemia { get; set; }
        public string CLIN_MC_Respiratory { get; set; }
        public string CLIN_MC_Gastrointestinal { get; set; }
        public string CLIN_MC_Others { get; set; }
        public string CLIN_MC_Others_Remarks { get; set; }
        public string BIOC_FastingGlucose_RecentTest_Date_PO { get; set; }
        public string BIOC_FastingGlucose_RecentTest_Result_PO { get; set; }
        public string BIOC_FastingGlucose_LastTest_Date_PO { get; set; }
        public string BIOC_FastingGlucose_LastTest_Result_PO { get; set; }
        public string BIOC_FastingGlucose_IsNormalResult_PO { get; set; }
        public string BIOC_RandomGlucose_RecentTest_Date_PO { get; set; }
        public string BIOC_RandomGlucose_RecentTest_Result_PO { get; set; }
        public string BIOC_RandomGlucose_LastTest_Date_PO { get; set; }
        public string BIOC_RandomGlucose_LastTest_Result_PO { get; set; }
        public string BIOC_RandomGlucose_IsNormalResult_PO { get; set; }
        public string BIOC_OGTT_FBG_RecentTest_Date_PO { get; set; }
        public string BIOC_OGTT_FBG_RecentTest_Result_PO { get; set; }
        public string BIOC_OGTT_FBG_LastTest_Date_PO { get; set; }
        public string BIOC_OGTT_FBG_LastTest_Result_PO { get; set; }
        public string BIOC_OGTT_FBG_IsNormalResult_PO { get; set; }
        public string BIOC_OGTT_FBG2_RecentTest_Date_PO { get; set; }
        public string BIOC_OGTT_FBG2_RecentTest_Result_PO { get; set; }
        public string BIOC_OGTT_FBG2_LastTest_Date_PO { get; set; }
        public string BIOC_OGTT_FBG2_LastTest_Result_PO { get; set; }
        public string BIOC_OGTT_FBG2_IsNormalResult_PO { get; set; }
        public string BIOC_HbA1c_RecentTest_Date_PO { get; set; }
        public string BIOC_HbA1c_RecentTest_Result_PO { get; set; }
        public string BIOC_HbA1c_LastTest_Date_PO { get; set; }
        public string BIOC_HbA1c_LastTest_Result_PO { get; set; }
        public string BIOC_HbA1c_IsNormalResult_PO { get; set; }
        public string BIOC_TotalCholesterol_RecentTest_Date_PO { get; set; }
        public string BIOC_TotalCholesterol_RecentTest_Result_PO { get; set; }
        public string BIOC_TotalCholesterol_LastTest_Date_PO { get; set; }
        public string BIOC_TotalCholesterol_LastTest_Result_PO { get; set; }
        public string BIOC_TotalCholesterol_IsNormalResult_PO { get; set; }
        public string BIOC_Triglyceride_RecentTest_Date_PO { get; set; }
        public string BIOC_Triglyceride_RecentTest_Result_PO { get; set; }
        public string BIOC_Triglyceride_LastTest_Date_PO { get; set; }
        public string BIOC_Triglyceride_LastTest_Result_PO { get; set; }
        public string BIOC_Triglyceride_IsNormalResult_PO { get; set; }
        public string BIOC_HDL_RecentTest_Date_PO { get; set; }
        public string BIOC_HDL_RecentTest_Result_PO { get; set; }
        public string BIOC_HDL_LastTest_Date_PO { get; set; }
        public string BIOC_HDL_LastTest_Result_PO { get; set; }
        public string BIOC_HDL_IsNormalResult_PO { get; set; }
        public string BIOC_LDL_RecentTest_Date_PO { get; set; }
        public string BIOC_LDL_RecentTest_Result_PO { get; set; }
        public string BIOC_LDL_LastTest_Date_PO { get; set; }
        public string BIOC_LDL_LastTest_Result_PO { get; set; }
        public string BIOC_LDL_IsNormalResult_PO { get; set; }
        public string BIOC_Microalbumin_RecentTest_Date_PO { get; set; }
        public string BIOC_Microalbumin_RecentTest_Result_PO { get; set; }
        public string BIOC_Microalbumin_LastTest_Date_PO { get; set; }
        public string BIOC_Microalbumin_LastTest_Result_PO { get; set; }
        public string BIOC_Microalbumin_IsNormalResult_PO { get; set; }
        public string BIOC_Creatinine_RecentTest_Date_PO { get; set; }
        public string BIOC_Creatinine_RecentTest_Result_PO { get; set; }
        public string BIOC_Creatinine_LastTest_Date_PO { get; set; }
        public string BIOC_Creatinine_LastTest_Result_PO { get; set; }
        public string BIOC_Creatinine_IsNormalResult_PO { get; set; }
        public string BIOC_Urea_RecentTest_Date_PO { get; set; }
        public string BIOC_Urea_RecentTest_Result_PO { get; set; }
        public string BIOC_Urea_LastTest_Date_PO { get; set; }
        public string BIOC_Urea_LastTest_Result_PO { get; set; }
        public string BIOC_Urea_IsNormalResult_PO { get; set; }
        public string BIOC_VitaminDLevel_RecentTest_Date_PO { get; set; }
        public string BIOC_VitaminDLevel_RecentTest_Result_PO { get; set; }
        public string BIOC_VitaminDLevel_LastTest_Date_PO { get; set; }
        public string BIOC_VitaminDLevel_LastTest_Result_PO { get; set; }
        public string BIOC_VitaminDLevel_IsNormalResult_PO { get; set; }
        public string BIOC_Lepatin_RecentTest_Date_PO { get; set; }
        public string BIOC_Lepatin_RecentTest_Result_PO { get; set; }
        public string BIOC_Lepatin_LastTest_Date_PO { get; set; }
        public string BIOC_Lepatin_LastTest_Result_PO { get; set; }
        public string BIOC_Lepatin_IsNormalResult_PO { get; set; }
        public string BIOC_LepatinReceptor_RecentTest_Date_PO { get; set; }
        public string BIOC_LepatinReceptor_RecentTest_Result_PO { get; set; }
        public string BIOC_LepatinReceptor_LastTest_Date_PO { get; set; }
        public string BIOC_LepatinReceptor_LastTest_Result_PO { get; set; }
        public string BIOC_LepatinReceptor_IsNormalResult_PO { get; set; }
        public string BIOC_CRP_RecentTest_Date_PO { get; set; }
        public string BIOC_CRP_RecentTest_Result_PO { get; set; }
        public string BIOC_CRP_LastTest_Date_PO { get; set; }
        public string BIOC_CRP_LastTest_Result_PO { get; set; }
        public string BIOC_CRP_IsNormalResult_PO { get; set; }
        public string BIOC_TNF_RecentTest_Date_PO { get; set; }
        public string BIOC_TNF_RecentTest_Result_PO { get; set; }
        public string BIOC_TNF_LastTest_Date_PO { get; set; }
        public string BIOC_TNF_LastTest_Result_PO { get; set; }
        public string BIOC_TNF_IsNormalResult_PO { get; set; }
        public string BIOC_ILF_RecentTest_Date_PO { get; set; }
        public string BIOC_ILF_RecentTest_Result_PO { get; set; }
        public string BIOC_ILF_LastTest_Date_PO { get; set; }
        public string BIOC_ILF_LastTest_Result_PO { get; set; }
        public string BIOC_ILF_IsNormalResult_PO { get; set; }
        public string MEDI_Any_Medication { get; set; }
        public string MEDI_Any_Medication_Remarks { get; set; }
        public string MEDI_Any_Allergies { get; set; }
        public string MEDI_Any_Allergies_Remarks { get; set; }
        public string MEDI_Intolerance { get; set; }
        public string MEDI_Intolerance_Remarks { get; set; }
        public string SDBC_SkinColor { get; set; }
        public string SDBC_Socioeconomic { get; set; }
        public string SDBC_SmokingStatus { get; set; }
        public string FOOD_EatFastfood_Week { get; set; }
        public string FOOD_Fruits_Vegetables_Day { get; set; }
        public string FOOD_Sodapop_Week { get; set; }
        public string FOOD_Eat_Midnight { get; set; }
        public string FOOD_HealthyDiet { get; set; }
        public string PHYA_Exercise_Week { get; set; }
        public string PHYA_Satisfy_Body { get; set; }
        public string PHYA_Happy_Life { get; set; }
        public string FAMI_Obesity { get; set; }
        public string FAMI_ObesityComplication { get; set; }
        public string FAMI_ObesityComplication_Remarks { get; set; }
        public string FAMI_Diabetes { get; set; }
        public string FAMI_Hypertension { get; set; }
        public string FAMI_Dyslipidemia { get; set; }
        public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        public string CLIN_BloodPressure_DIA_mmHg { get; set; }
    }
}
