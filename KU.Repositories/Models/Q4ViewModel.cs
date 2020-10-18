
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
    public class QuestionnaireWrap4
    {
        public QuestionnaireWrap4()
        {
            result = new List<Q4ViewModel>();

        }
        public IEnumerable<Q4ViewModel> result { get; set; }

    }
    public class Q4ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        public string SampleID { get; set; }
        [JsonProperty("Collection Point")] public string CollectionPoint { get; set; }
        [JsonProperty("Collected By")] public string CollectedBy { get; set; }
        [JsonProperty("Date Of Assessment")] public string DateofAssessment { get; set; }
        [JsonProperty("First Name")] public string PERS_Firstname { get; set; }
        [JsonProperty("Middle Name")] public string PERS_MiddleName { get; set; }
        [JsonProperty("Last Name")] public string PERS_LastName { get; set; }
        [JsonProperty("Gender")] public string PERS_Gender { get; set; }
        [JsonProperty("Date Of Birth")] public string PERS_DateofBirth { get; set; }
        [JsonProperty("Please Of Birth")] public string PERS_PlaceofBirth { get; set; }
        [JsonProperty("Nationality")] public string PERS_Nationality { get; set; }
        [JsonProperty("Ethnicity")] public string PERS_Ethnicity { get; set; }
        [JsonProperty("Marital Status")] public string PERS_MaritalStatus { get; set; }
        [JsonProperty("Consanguineous Marriage")] public string PERS_marriage_con { get; set; }
        [JsonProperty("Number Of Children")] public string PERS_NumberofChildren { get; set; }
        [JsonProperty("Boys")] public string PERS_Boys { get; set; }
        [JsonProperty("Girls")] public string PERS_Girls { get; set; }
        [JsonProperty("Number Of Wives")] public string PERS_Numberofwives { get; set; }
        [JsonProperty("Address")] public string PERS_Address { get; set; }
        [JsonProperty("City")] public string PERS_City { get; set; }
        [JsonProperty("Emirates")] public string PERS_Emirates { get; set; }
        [JsonProperty("Mobile Number")] public string PERS_Mobilenumber { get; set; }
        [JsonProperty("Smoking Status")] public string LIFE_SmokingStatus { get; set; }
        [JsonProperty("Exercise")] public string LIFE_ExcersizeFrquent { get; set; }
        [JsonProperty("Healthy Diet")] public string LIFE_FollowHealthyDiet { get; set; }
        [JsonProperty("Special Diet")] public string LIFE_SpecialDiet_weight_LossGain { get; set; }
        [JsonProperty("Weight Changed In 5 Years")] public string LIFE_Weightchangedin5years { get; set; }
        [JsonProperty("Healthy Individual")] public string LIFE_healthy_Individual { get; set; }
        [JsonProperty("Fast Food Per Week")] public string FOOD_EatFastfood_Week { get; set; }
        [JsonProperty("Consume Soda Pop Per Week")] public string FOOD_Sodapop_Week { get; set; }
        [JsonProperty("Fruits Vegetables Per Day")] public string FOOD_Fruits_Vegetables_Day { get; set; }
        [JsonProperty("Eat In The Middle Night")] public string FOOD_Eat_Midnight { get; set; }
        [JsonProperty("Allergies")] public string MEDI_Any_Allergies { get; set; }
        [JsonProperty("Specify Allergies")] public string MEDI_Any_Allergies_Remarks { get; set; }
        [JsonProperty("Intolerance")] public string MEDI_Intolerance { get; set; }
        [JsonProperty("Specify Intolerance")] public string MEDI_Intolerance_Remarks { get; set; }
        [JsonProperty("Medications")] public string MEDI_Any_Medications { get; set; }
        [JsonProperty("Vitamins Or Supplements")] public string MEDI_Any_Vitamins_Supplements { get; set; }
        [JsonProperty("Specify Supplements")] public string MEDI_Any_Vitamins_Supplements_Remarks { get; set; }
        [JsonProperty("Any Diseases")] public string MEDI_Any_Diseases { get; set; }
        [JsonProperty("Type 1 Diabetes")] public string MEDI_Type1Diabetes { get; set; }
        [JsonProperty("Type 1 Diabetes Age")] public string MEDI_Type1Diabetes_Age { get; set; }
        [JsonProperty("Type 2 Diabetes")] public string MEDI_Type2Diabetes { get; set; }
        [JsonProperty("Type 2 Diabetes Age")] public string MEDI_Type2Diabetes_Age { get; set; }
        [JsonProperty("Cardiovascular")] public string MEDI_Cardiovascular { get; set; }
        [JsonProperty("Cardiovascular Age")] public string MEDI_Cardiovascular_Age { get; set; }
        [JsonProperty("Cancer")] public string MEDI_Cancer { get; set; }
        [JsonProperty("Specify Cancer")] public string MEDI_Cancer_Remarks { get; set; }
        [JsonProperty("Asthma")] public string MEDI_Asthma { get; set; }
        [JsonProperty("Asthma Age")] public string MEDI_Asthma_Age { get; set; }
        [JsonProperty("Seizures")] public string MEDI_Seizures { get; set; }
        [JsonProperty("Seizures Age")] public string MEDI_Seizures_Age { get; set; }
        [JsonProperty("Hypertension")] public string MEDI_Hypertension { get; set; }
        [JsonProperty("Hypertension Age")] public string MEDI_Hypertension_Age { get; set; }
        [JsonProperty("Arthritis Rheumatism")] public string MEDI_Arthritis_Rheumatism { get; set; }
        [JsonProperty("Arthritis Age")] public string MEDI_Arthritis_Rheumatism_Age { get; set; }
        [JsonProperty("Eczema")] public string MEDI_Eczema { get; set; }
        [JsonProperty("Eczema Age")] public string MEDI_Eczema_Age { get; set; }
        [JsonProperty("Kidney Disease")] public string MEDI_Kidneydisease { get; set; }
        [JsonProperty("Kidney Disease Age")] public string MEDI_Kidneydisease_Age { get; set; }
        [JsonProperty("Liver Disease")] public string MEDI_Liverdisease { get; set; }
        [JsonProperty("Liver Disease Age")] public string MEDI_Liverdisease_Age { get; set; }
        [JsonProperty("Neurological Disorder")] public string MEDI_Neurologicaldisorder { get; set; }
        [JsonProperty("Neurological Disorder Remarks")] public string MEDI_Neurologicaldisorder_Remarks { get; set; }
        [JsonProperty("Psychological Diseases")] public string MEDI_Psychologicaldiseases { get; set; }
        [JsonProperty("Psychological Diseases Remarks")] public string MEDI_Psychologicaldiseases_Remarks { get; set; }
        [JsonProperty("Thyroid")] public string MEDI_Thyroid { get; set; }
        [JsonProperty("Thyroid Age")] public string MEDI_Thyroid_Age { get; set; }
        [JsonProperty("Medical Others")] public string MEDI_Others { get; set; }
        [JsonProperty("Medical Others Remarks")] public string MEDI_Others_Remarks { get; set; }
        [JsonProperty("Surgery")] public string MEDI_Any_Surgery { get; set; }
        [JsonProperty("Surgery Remarks")] public string MEDI_Any_Surgery_Remarks { get; set; }
        [JsonProperty("Ethnicity Of Mother")] public string FAMI_Ethnicity_BiologicalMother { get; set; }
        [JsonProperty("Ethnicity Of Father")] public string FAMI_Ethnicity_BiologicalFather { get; set; }
        [JsonProperty("Country Of Birth Of Mother")] public string FAMI_BiologicalMother_BirthCountry { get; set; }
        [JsonProperty("Country Of Birth Of Father")] public string FAMI_BiologicalFather_BirthCountry { get; set; }
        [JsonProperty("Parents Related")] public string FAMI_IsParents_Related { get; set; }
        [JsonProperty("Parents Related Remarks")] public string FAMI_IsParents_Related_Remarks { get; set; }
        [JsonProperty("Family Detail Asthma")] public string FADI_Asthma { get; set; }
        [JsonProperty("Asthma Remarks")] public string FADI_Asthma_Remarks { get; set; }
        [JsonProperty("Blood Disorders")] public string FADI_Blooddisorders { get; set; }
        [JsonProperty("Blood Disorders Remarks")] public string FADI_Blooddisorders_Remarks { get; set; }
        [JsonProperty("Family Detail Cancer")] public string FADI_Cancer { get; set; }
        [JsonProperty("Cancer Remarks")] public string FADI_Cancer_Remarks { get; set; }
        [JsonProperty("Depression")] public string FADI_Depression { get; set; }
        [JsonProperty("Depression Remarks")] public string FADI_Depression_Remarks { get; set; }
        [JsonProperty("Diabetes Type 1")] public string FADI_DiabetesType1 { get; set; }
        [JsonProperty("Diabetes Type 1 Remarks")] public string FADI_DiabetesType1_Remarks { get; set; }
        [JsonProperty("Family Detail Hypertension")] public string FADI_Hypertension { get; set; }
        [JsonProperty("Hypertension Remarks")] public string FADI_Hypertension_Remarks { get; set; }
        [JsonProperty("Family Detail Cardiovascular")] public string FADI_Cardiovascular { get; set; }
        [JsonProperty("Cardiovascular Remarks")] public string FADI_Cardiovascular_Remarks { get; set; }
        [JsonProperty("Hearing Loss")] public string FADI_Hearingloss { get; set; }
        [JsonProperty("Hearing Loss Remarks")] public string FADI_Hearingloss_Remarks { get; set; }
        [JsonProperty("Obesity")] public string FADI_Obesity { get; set; }
        [JsonProperty("Obesity Remarks")] public string FADI_Obesity_Remarks { get; set; }
        [JsonProperty("Diabetes Type 2")] public string FADI_Diabetestype2 { get; set; }
        [JsonProperty("Diabetes Type 2 Remarks")] public string FADI_Diabetestype2_Remarks { get; set; }
        [JsonProperty("Others")] public string FADI_Others { get; set; }
        [JsonProperty("Other Remarks")] public string FADI_Others_Remarks { get; set; }
        [JsonProperty("Family Pedigree")] public string FamilyPedigree { get; set; }
        [JsonProperty("Body Weight (Kg)")] public string CLIN_BodyWeight_KG { get; set; }
        [JsonProperty("Waist Circumference (Cm)")] public string CLIN_WaistCircumference_CM { get; set; }
        [JsonProperty("Height (Cm)")] public string CLIN_Height_CM { get; set; }
        [JsonProperty("Hip Circumference (Cm)")] public string CLIN_Hipcircumference_CM { get; set; }
        [JsonProperty("BMI (Kg.M2)")] public string CLIN_BMI_KGM2 { get; set; }
        [JsonProperty("Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_mmHg { get; set; }
        [JsonProperty("Fasting Blood Glucose (Mmol/L) Date")] public string BIOC_FastingGlucose_RecentTest_Date_PO { get; set; }
        [JsonProperty("Fasting Blood Glucose (Mmol/L) Result")] public string BIOC_FastingGlucose_RecentTest_Result_PO { get; set; }
        [JsonProperty("Fasting Blood Glucose (Mmol/L) Result Normal")] public string BIOC_FastingGlucose_IsNormalResult_PO { get; set; }
        [JsonProperty("Random Glucose Level Date")] public string BIOC_RandomGlucose_RecentTest_Date_PO { get; set; }
        [JsonProperty("Random Glucose Level Result")] public string BIOC_RandomGlucose_RecentTest_Result_PO { get; set; }
        [JsonProperty("Random Glucose Level Result Normal")] public string BIOC_RandomGlucose_IsNormalResult_PO { get; set; }
        [JsonProperty("Hba1C (%) Date")] public string BIOC_HbA1c_RecentTest_Date_PO { get; set; }
        [JsonProperty("Hba1C (%) Result")] public string BIOC_HbA1c_RecentTest_Result_PO { get; set; }
        [JsonProperty("Hba1C (%) Result Normal")] public string BIOC_HbA1c_IsNormalResult_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Date")] public string BIOC_TotalCholesterol_RecentTest_Date_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L)Result")] public string BIOC_TotalCholesterol_RecentTest_Result_PO { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Result Normal")] public string BIOC_TotalCholesterol_IsNormalResult_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Date")] public string BIOC_Triglyceride_RecentTest_Date_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Result")] public string BIOC_Triglyceride_RecentTest_Result_PO { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Result Normal")] public string BIOC_Triglyceride_IsNormalResult_PO { get; set; }
        [JsonProperty("Hdl (Mmol/L) Date")] public string BIOC_HDL_RecentTest_Date_PO { get; set; }
        [JsonProperty("Hdl (Mmol/L) Result")] public string BIOC_HDL_RecentTest_Result_PO { get; set; }
        [JsonProperty("Hdl (Mmol/L) Result Normal")] public string BIOC_HDL_IsNormalResult_PO { get; set; }
        [JsonProperty("Ldl (Mmol/L) Date")] public string BIOC_LDL_RecentTest_Date_PO { get; set; }
        [JsonProperty("Ldl (Mmol/L) Result")] public string BIOC_LDL_RecentTest_Result_PO { get; set; }
        [JsonProperty("Ldl (Mmol/L) Result Normal")] public string BIOC_LDL_IsNormalResult_PO { get; set; }
        [JsonProperty("Calcium Date")] public string BIOC_Calcium_RecentTest_Date_PO { get; set; }
        [JsonProperty("Calcium Result")] public string BIOC_Calcium_RecentTest_Result_PO { get; set; }
        [JsonProperty("Calcium Result Normal")] public string BIOC_Calcium_IsNormalResult_PO { get; set; }
        [JsonProperty("Urea Date")] public string BIOC_Urea_RecentTest_Date_PO { get; set; }
        [JsonProperty("Urea Result")] public string BIOC_Urea_RecentTest_Result_PO { get; set; }
        [JsonProperty("Urea Result Normal")] public string BIOC_Urea_IsNormalResult_PO { get; set; }
        [JsonProperty("Creatinine Date")] public string BIOC_Creatinine_RecentTest_Date_PO { get; set; }
        [JsonProperty("Creatinine Result")] public string BIOC_Creatinine_RecentTest_Result_PO { get; set; }
        [JsonProperty("Creatinine Result Normal")] public string BIOC_Creatinine_IsNormalResult_PO { get; set; }
        [JsonProperty("Total Protein Date")] public string BIOC_TotalProtein_RecentTest_Date_PO { get; set; }
        [JsonProperty("Total Protein Result")] public string BIOC_TotalProtein_RecentTest_Result_PO { get; set; }
        [JsonProperty("Total Protein Result Normal")] public string BIOC_TotalProtein_IsNormalResult_PO { get; set; }
        [JsonProperty("Albumin Date")] public string BIOC_Albumin_RecentTest_Date_PO { get; set; }
        [JsonProperty("Albumin Result")] public string BIOC_Albumin_RecentTest_Result_PO { get; set; }
        [JsonProperty("Albumin Result Normal")] public string BIOC_Albumin_IsNormalResult_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Date")] public string BIOC_VitaminDLevel_RecentTest_Date_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Result")] public string BIOC_VitaminDLevel_RecentTest_Result_PO { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Result Normal")] public string BIOC_VitaminDLevel_IsNormalResult_PO { get; set; }
        [JsonProperty("Lepatin Date")] public string BIOC_Lepatin_RecentTest_Date_PO { get; set; }
        [JsonProperty("Lepatin Result")] public string BIOC_Lepatin_RecentTest_Result_PO { get; set; }
        [JsonProperty("Lepatin Result Normal ")] public string BIOC_Lepatin_IsNormalResult_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Date")] public string BIOC_LepatinReceptor_RecentTest_Date_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Result")] public string BIOC_LepatinReceptor_RecentTest_Result_PO { get; set; }
        [JsonProperty("Lepatin Receptor (Ng/Ml) Result Normal")] public string BIOC_LepatinReceptor_IsNormalResult_PO { get; set; }
        [JsonProperty("Alkaline Phosphatase Date")] public string BIOC_Alkaline_RecentTest_Date_PO { get; set; }
        [JsonProperty("Alkaline Phosphatase Result")] public string BIOC_Alkaline_RecentTest_Result_PO { get; set; }
        [JsonProperty("Alkaline Phosphatase Result Normal")] public string BIOC_Alkaline_IsNormalResult_PO { get; set; }
        [JsonProperty("ALT Date")] public string BIOC_ALT_RecentTest_Date_PO { get; set; }
        [JsonProperty("ALT Result")] public string BIOC_ALT_RecentTest_Result_PO { get; set; }
        [JsonProperty("ALT Result Normal")] public string BIOC_ALT_IsNormalResult_PO { get; set; }
        [JsonProperty("Gamma Glutamyl Transferase Date")] public string BIOC_GammaGlutamyl_RecentTest_Date_PO { get; set; }
        [JsonProperty("Gamma Glutamyl Transferase Result")] public string BIOC_GammaGlutamyl_RecentTest_Result_PO { get; set; }
        [JsonProperty("Gamma Glutamyl Transferase Result Normal")] public string BIOC_GammaGlutamyl_IsNormalResult_PO { get; set; }
        [JsonProperty("Platelet Count Date")] public string BIOC_PlateletCount_RecentTest_Date_PO { get; set; }
        [JsonProperty("Platelet Count Result")] public string BIOC_PlateletCount_RecentTest_Result_PO { get; set; }
        [JsonProperty("Platelet Count Result Normal")] public string BIOC_PlateletCount_IsNormalResult_PO { get; set; }
        [JsonProperty("Bilirubin Date")] public string BIOC_Bilirubin_RecentTest_Date_PO { get; set; }
        [JsonProperty("Bilirubin Result")] public string BIOC_Bilirubin_RecentTest_Result_PO { get; set; }
        [JsonProperty("Bilirubin")] public string BIOC_Bilirubin_IsNormalResult_PO { get; set; }
        [JsonProperty("Ecg Test Before")] public string ECXR_AnyECGTestBefore { get; set; }
        [JsonProperty("When Ecg Test")] public string ECXR_AnyECGTestBefore_Date { get; set; }
        [JsonProperty("Chest X-Ray Before")] public string ECXR_AnyXRayBefore { get; set; }
        [JsonProperty("When Chest X-Ray")] public string ECXR_AnyXRayBefore_Date { get; set; }
        [JsonProperty("Chest X-Ray Exam Normal")] public string PHYS_IsXRayNormal_PO { get; set; }
        [JsonProperty("ECG Test Normal")] public string PHYS_IsECGNormal_PO { get; set; }
        [JsonProperty("Healthy")] public string PHYS_IsHealthy_PO { get; set; }
        [JsonProperty("Ethnicity Mixed Remarks")] public string PERS_Ethnicity_Mixed_Remarks { get; set; }
        [JsonProperty("Ethnicity Other Remarks")] public string PERS_Ethnicity_Other_Remarks { get; set; }
        [JsonProperty("Mother Mixed Remarks")] public string FAMI_Ethnicity_BiologicalMother_Mixed_Remarks { get; set; }
        [JsonProperty("Mother Others Remarks")] public string FAMI_Ethnicity_BiologicalMother_Others_Remarks { get; set; }
        [JsonProperty("Father Mixed Remarks")] public string FAMI_Ethnicity_BiologicalFather_Mixed_Remarks { get; set; }
        [JsonProperty("Father Others Remarks")] public string FAMI_Ethnicity_BiologicalFather_Others_Remarks { get; set; }
        [JsonProperty("Systolic Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        [JsonProperty("Diastolic Blood Pressure (Mmhg)")] public string CLIN_BloodPressure_DIA_mmHg { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
