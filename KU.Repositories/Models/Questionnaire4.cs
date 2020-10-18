
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
    //public class QuestionnaireWrap4
    //{
    //    public QuestionnaireWrap4()
    //    {
    //        result = new List<Questionnaire4>();

    //    }
    //    public IEnumerable<Questionnaire4> result { get; set; }

    //}
    public class Questionnaire4
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
        public string PERS_LastName { get; set; }
        public string PERS_Gender { get; set; }
        public string PERS_DateofBirth { get; set; }
        public string PERS_PlaceofBirth { get; set; }
        public string PERS_Nationality { get; set; }
        public string PERS_Ethnicity { get; set; }
        public string PERS_MaritalStatus { get; set; }
        public string PERS_marriage_con { get; set; }
        public string PERS_NumberofChildren { get; set; }
        public string PERS_Boys { get; set; }
        public string PERS_Girls { get; set; }
        public string PERS_Numberofwives { get; set; }
        public string PERS_Address { get; set; }
        public string PERS_City { get; set; }
        public string PERS_Emirates { get; set; }
        public string PERS_Mobilenumber { get; set; }
        public string LIFE_SmokingStatus { get; set; }
        public string LIFE_ExcersizeFrquent { get; set; }
        public string LIFE_FollowHealthyDiet { get; set; }
        public string LIFE_SpecialDiet_weight_LossGain { get; set; }
        public string LIFE_Weightchangedin5years { get; set; }
        public string LIFE_healthy_Individual { get; set; }
        public string FOOD_EatFastfood_Week { get; set; }
        public string FOOD_Sodapop_Week { get; set; }
        public string FOOD_Fruits_Vegetables_Day { get; set; }
        public string FOOD_Eat_Midnight { get; set; }
        public string MEDI_Any_Allergies { get; set; }
        public string MEDI_Any_Allergies_Remarks { get; set; }
        public string MEDI_Intolerance { get; set; }
        public string MEDI_Intolerance_Remarks { get; set; }
        public string MEDI_Any_Medications { get; set; }
        public string MEDI_Any_Vitamins_Supplements { get; set; }
        public string MEDI_Any_Vitamins_Supplements_Remarks { get; set; }
        public string MEDI_Any_Diseases { get; set; }
        public string MEDI_Type1Diabetes { get; set; }
        public string MEDI_Type1Diabetes_Age { get; set; }
        public string MEDI_Type2Diabetes { get; set; }
        public string MEDI_Type2Diabetes_Age { get; set; }
        public string MEDI_Cardiovascular { get; set; }
        public string MEDI_Cardiovascular_Age { get; set; }
        public string MEDI_Cancer { get; set; }
        public string MEDI_Cancer_Remarks { get; set; }
        public string MEDI_Asthma { get; set; }
        public string MEDI_Asthma_Age { get; set; }
        public string MEDI_Seizures { get; set; }
        public string MEDI_Seizures_Age { get; set; }
        public string MEDI_Hypertension { get; set; }
        public string MEDI_Hypertension_Age { get; set; }
        public string MEDI_Arthritis_Rheumatism { get; set; }
        public string MEDI_Arthritis_Rheumatism_Age { get; set; }
        public string MEDI_Eczema { get; set; }
        public string MEDI_Eczema_Age { get; set; }
        public string MEDI_Kidneydisease { get; set; }
        public string MEDI_Kidneydisease_Age { get; set; }
        public string MEDI_Liverdisease { get; set; }
        public string MEDI_Liverdisease_Age { get; set; }
        public string MEDI_Neurologicaldisorder { get; set; }
        public string MEDI_Neurologicaldisorder_Remarks { get; set; }
        public string MEDI_Psychologicaldiseases { get; set; }
        public string MEDI_Psychologicaldiseases_Remarks { get; set; }
        public string MEDI_Thyroid { get; set; }
        public string MEDI_Thyroid_Age { get; set; }
        public string MEDI_Others { get; set; }
        public string MEDI_Others_Remarks { get; set; }
        public string MEDI_Any_Surgery { get; set; }
        public string MEDI_Any_Surgery_Remarks { get; set; }
        public string FAMI_Ethnicity_BiologicalMother { get; set; }
        public string FAMI_Ethnicity_BiologicalFather { get; set; }
        public string FAMI_BiologicalMother_BirthCountry { get; set; }
        public string FAMI_BiologicalFather_BirthCountry { get; set; }
        public string FAMI_IsParents_Related { get; set; }
        public string FAMI_IsParents_Related_Remarks { get; set; }
        public string FADI_Asthma { get; set; }
        public string FADI_Asthma_Remarks { get; set; }
        public string FADI_Blooddisorders { get; set; }
        public string FADI_Blooddisorders_Remarks { get; set; }
        public string FADI_Cancer { get; set; }
        public string FADI_Cancer_Remarks { get; set; }
        public string FADI_Depression { get; set; }
        public string FADI_Depression_Remarks { get; set; }
        public string FADI_DiabetesType1 { get; set; }
        public string FADI_DiabetesType1_Remarks { get; set; }
        public string FADI_Hypertension { get; set; }
        public string FADI_Hypertension_Remarks { get; set; }
        public string FADI_Cardiovascular { get; set; }
        public string FADI_Cardiovascular_Remarks { get; set; }
        public string FADI_Hearingloss { get; set; }
        public string FADI_Hearingloss_Remarks { get; set; }
        public string FADI_Obesity { get; set; }
        public string FADI_Obesity_Remarks { get; set; }
        public string FADI_Diabetestype2 { get; set; }
        public string FADI_Diabetestype2_Remarks { get; set; }
        public string FADI_Others { get; set; }
        public string FADI_Others_Remarks { get; set; }
        public string FamilyPedigree { get; set; }
        public string CLIN_BodyWeight_KG { get; set; }
        public string CLIN_WaistCircumference_CM { get; set; }
        public string CLIN_Height_CM { get; set; }
        public string CLIN_Hipcircumference_CM { get; set; }
        public string CLIN_BMI_KGM2 { get; set; }
        public string CLIN_BloodPressure_mmHg { get; set; }
        public string BIOC_FastingGlucose_RecentTest_Date_PO { get; set; }
        public string BIOC_FastingGlucose_RecentTest_Result_PO { get; set; }
        public string BIOC_FastingGlucose_IsNormalResult_PO { get; set; }
        public string BIOC_RandomGlucose_RecentTest_Date_PO { get; set; }
        public string BIOC_RandomGlucose_RecentTest_Result_PO { get; set; }
        public string BIOC_RandomGlucose_IsNormalResult_PO { get; set; }
        public string BIOC_HbA1c_RecentTest_Date_PO { get; set; }
        public string BIOC_HbA1c_RecentTest_Result_PO { get; set; }
        public string BIOC_HbA1c_IsNormalResult_PO { get; set; }
        public string BIOC_TotalCholesterol_RecentTest_Date_PO { get; set; }
        public string BIOC_TotalCholesterol_RecentTest_Result_PO { get; set; }
        public string BIOC_TotalCholesterol_IsNormalResult_PO { get; set; }
        public string BIOC_Triglyceride_RecentTest_Date_PO { get; set; }
        public string BIOC_Triglyceride_RecentTest_Result_PO { get; set; }
        public string BIOC_Triglyceride_IsNormalResult_PO { get; set; }
        public string BIOC_HDL_RecentTest_Date_PO { get; set; }
        public string BIOC_HDL_RecentTest_Result_PO { get; set; }
        public string BIOC_HDL_IsNormalResult_PO { get; set; }
        public string BIOC_LDL_RecentTest_Date_PO { get; set; }
        public string BIOC_LDL_RecentTest_Result_PO { get; set; }
        public string BIOC_LDL_IsNormalResult_PO { get; set; }
        public string BIOC_Calcium_RecentTest_Date_PO { get; set; }
        public string BIOC_Calcium_RecentTest_Result_PO { get; set; }
        public string BIOC_Calcium_IsNormalResult_PO { get; set; }
        public string BIOC_Urea_RecentTest_Date_PO { get; set; }
        public string BIOC_Urea_RecentTest_Result_PO { get; set; }
        public string BIOC_Urea_IsNormalResult_PO { get; set; }
        public string BIOC_Creatinine_RecentTest_Date_PO { get; set; }
        public string BIOC_Creatinine_RecentTest_Result_PO { get; set; }
        public string BIOC_Creatinine_IsNormalResult_PO { get; set; }
        public string BIOC_TotalProtein_RecentTest_Date_PO { get; set; }
        public string BIOC_TotalProtein_RecentTest_Result_PO { get; set; }
        public string BIOC_TotalProtein_IsNormalResult_PO { get; set; }
        public string BIOC_Albumin_RecentTest_Date_PO { get; set; }
        public string BIOC_Albumin_RecentTest_Result_PO { get; set; }
        public string BIOC_Albumin_IsNormalResult_PO { get; set; }
        public string BIOC_VitaminDLevel_RecentTest_Date_PO { get; set; }
        public string BIOC_VitaminDLevel_RecentTest_Result_PO { get; set; }
        public string BIOC_VitaminDLevel_IsNormalResult_PO { get; set; }
        public string BIOC_Lepatin_RecentTest_Date_PO { get; set; }
        public string BIOC_Lepatin_RecentTest_Result_PO { get; set; }
        public string BIOC_Lepatin_IsNormalResult_PO { get; set; }
        public string BIOC_LepatinReceptor_RecentTest_Date_PO { get; set; }
        public string BIOC_LepatinReceptor_RecentTest_Result_PO { get; set; }
        public string BIOC_LepatinReceptor_IsNormalResult_PO { get; set; }
        public string BIOC_Alkaline_RecentTest_Date_PO { get; set; }
        public string BIOC_Alkaline_RecentTest_Result_PO { get; set; }
        public string BIOC_Alkaline_IsNormalResult_PO { get; set; }
        public string BIOC_ALT_RecentTest_Date_PO { get; set; }
        public string BIOC_ALT_RecentTest_Result_PO { get; set; }
        public string BIOC_ALT_IsNormalResult_PO { get; set; }
        public string BIOC_GammaGlutamyl_RecentTest_Date_PO { get; set; }
        public string BIOC_GammaGlutamyl_RecentTest_Result_PO { get; set; }
        public string BIOC_GammaGlutamyl_IsNormalResult_PO { get; set; }
        public string BIOC_PlateletCount_RecentTest_Date_PO { get; set; }
        public string BIOC_PlateletCount_RecentTest_Result_PO { get; set; }
        public string BIOC_PlateletCount_IsNormalResult_PO { get; set; }
        public string BIOC_Bilirubin_RecentTest_Date_PO { get; set; }
        public string BIOC_Bilirubin_RecentTest_Result_PO { get; set; }
        public string BIOC_Bilirubin_IsNormalResult_PO { get; set; }
        public string ECXR_AnyECGTestBefore { get; set; }
        public string ECXR_AnyECGTestBefore_Date { get; set; }
        public string ECXR_AnyXRayBefore { get; set; }
        public string ECXR_AnyXRayBefore_Date { get; set; }
        public string PHYS_IsXRayNormal_PO { get; set; }
        public string PHYS_IsECGNormal_PO { get; set; }
        public string PHYS_IsHealthy_PO { get; set; }
        public string PERS_Ethnicity_Mixed_Remarks { get; set; }
        public string PERS_Ethnicity_Other_Remarks { get; set; }
        public string FAMI_Ethnicity_BiologicalMother_Mixed_Remarks { get; set; }
        public string FAMI_Ethnicity_BiologicalMother_Others_Remarks { get; set; }
        public string FAMI_Ethnicity_BiologicalFather_Mixed_Remarks { get; set; }
        public string FAMI_Ethnicity_BiologicalFather_Others_Remarks { get; set; }
        public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        public string CLIN_BloodPressure_DIA_mmHg { get; set; }
    }
}
