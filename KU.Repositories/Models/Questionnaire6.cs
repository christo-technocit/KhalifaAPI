using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
    //public class QuestionnaireWrap6
    //{
    //    public QuestionnaireWrap6()
    //    {
    //        result = new List<Questionnaire6>();

    //    }
    //    public IEnumerable<Questionnaire6> result { get; set; }

    //}
    public class Questionnaire6
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
        public string CLIN_MC_YesRemarks { get; set; }
        public string CLIN_MC_Type2Diabetes { get; set; }
        public string CLIN_MC_Hypertension { get; set; }
        public string CLIN_MC_Dyslipidemia { get; set; }
        public string CLIN_MC_Respiratory { get; set; }
        public string CLIN_MC_Gastrointestinal { get; set; }
        public string CLIN_MC_Others { get; set; }
        public string CLIN_MC_Others_Remarks { get; set; }
        public string CLIN_MC_Fractures { get; set; }
        public string CLIN_MC_FracturesType { get; set; }
        public string CLIN_MC_FracturesDate { get; set; }
        public string CLIN_MC_DEXAReadings { get; set; }
        public string BIOC_FastingGlucoseLevel_Test_Date { get; set; }
        public string BIOC_FastingGlucoseLevel_Result { get; set; }
        public string BIOC_FastingGlucoseLevel_IsNormalResult { get; set; }
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
        public string BIOC_Creatinine_Test_Date { get; set; }
        public string BIOC_Creatinine_Result { get; set; }
        public string BIOC_Creatinine_IsNormalResult { get; set; }
        public string BIOC_Ca_Test_Date { get; set; }
        public string BIOC_Ca_Result { get; set; }
        public string BIOC_Ca_IsNormalResult { get; set; }
        public string BIOC_VitaminDLevel_Test_Date { get; set; }
        public string BIOC_VitaminDLevel_Result { get; set; }
        public string BIOC_VitaminDLevel_IsNormalResult { get; set; }
        public string MEDI_Any_Medication { get; set; }
        public string MEDI_Any_Medication_Remarks { get; set; }
        public string MEDI_Any_Allergies { get; set; }
        public string MEDI_Any_Allergies_Remarks { get; set; }
        public string MEDI_Intolerance { get; set; }
        public string MEDI_Intolerance_Remarks { get; set; }
        public string MEDIS_Multivitamins { get; set; }
        public string MEDIS_Multivitamins_VitaminD { get; set; }
        public string MEDIS_CalciumSupplements { get; set; }
        public string MEDIS_CalciumSupplements_Dose { get; set; }
        public string MEDIS_VitaminD { get; set; }
        public string MEDIS_VitaminD_Dose { get; set; }
        public string MEDIS_HormoneReplacementTherapy { get; set; }
        public string MEDIS_HormoneReplacementTherapy_Remarks { get; set; }
        public string OMRT_Q1_Parent_osteoporosis { get; set; }
        public string OMRT_Q2_Parent_StoopedBack { get; set; }
        public string OMRT_Q3_Parent_40YearsOlder { get; set; }
        public string OMRT_Q4_BrokenBone { get; set; }
        public string OMRT_Q5_FearFalling { get; set; }
        public string OMRT_Q6_After40_3cmHeight { get; set; }
        public string OMRT_Q7_Underweight { get; set; }
        public string OMRT_Q8_CorticosteroidTablets { get; set; }
        public string OMRT_Q9_RheumatoidArthritis { get; set; }
        public string OMRT_Q10_OveractiveThyroid { get; set; }
        public string OMRT_Q11_Menopause { get; set; }
        public string OMRT_Q12_PeriodsEver { get; set; }
        public string OMRT_Q13_HormoneReplacementTherapy { get; set; }
        public string OMRT_Q14_SmokedCigarettes { get; set; }
        public string OMRT_Q15_PhysicalActivity { get; set; }
        public string OMRT_Q16_Allergic_Milk { get; set; }
        public string OMRT_Q17_OutdoorsSpend { get; set; }
        public string FAMH_Osteoporosis { get; set; }
        public string FAMH_Osteoporosis_complication { get; set; }
        public string FAMH_Osteoporosis_complication_Remarks { get; set; }
        public string FAMH_Obesity { get; set; }
        public string FAMH_BoneFractures { get; set; }
        public string FAMH_CVD { get; set; }
        public string FAMH_Other { get; set; }
        public string CLIN_BloodPressure_SYS_mmHg { get; set; }
        public string CLIN_BloodPressure_DIA_mmHg { get; set; }
    }
}
