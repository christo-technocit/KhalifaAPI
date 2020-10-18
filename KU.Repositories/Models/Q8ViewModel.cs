using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
     public class QuestionnaireWrap8
    {
       public QuestionnaireWrap8()
        {
           result = new List<Q8ViewModel>();

        }
        public IEnumerable<Q8ViewModel> result { get; set; }

    }
    public class Q8ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        [JsonProperty("Sample")] public string sample { get; set; }
        [JsonProperty("Project Title")] public string projecttitle { get; set; }
        [JsonProperty("Principal Investigator")] public string principalinvestigator { get; set; }
        [JsonProperty("Collection Point")] public string collection_point { get; set; }
        [JsonProperty("Collected By")] public string collected_by { get; set; }
        [JsonProperty("Date Of Collection")] public string collected_date { get; set; }
        [JsonProperty("Individual/Family")] public string indifamily { get; set; }
        [JsonProperty("Family Number")] public string family_number { get; set; }
        [JsonProperty("Father/Mother/Adult/Child")] public string family_yes { get; set; }
        [JsonProperty("First Name")] public string per_firstname { get; set; }
        [JsonProperty("Middle Name")] public string per_middlename { get; set; }
        [JsonProperty("Last Name")] public string per_lastname { get; set; }
        [JsonProperty("Gender")] public string gender { get; set; }
        [JsonProperty("Emirates Id")] public string emiratesid { get; set; }
        [JsonProperty("Nationality")] public string nationality { get; set; }
        [JsonProperty("Date Of Birth")] public string dob { get; set; }
        [JsonProperty("Placeofbirth")] public string PlaceOfBirth { get; set; }
        [JsonProperty("City")] public string city { get; set; }
        [JsonProperty("Phone Number")] public string phone { get; set; }
        [JsonProperty("Email")] public string email { get; set; }
        [JsonProperty("Ethnicity")] public string ethnicity { get; set; }
        [JsonProperty("Ethnicity Mixed")] public string ethnicity_mixed_specify_text { get; set; }
        [JsonProperty("Ethnicity Others")] public string ethnicity_others_text { get; set; }
        [JsonProperty("Marital Status")] public string maritalstatus { get; set; }
        [JsonProperty("Consanguineous")] public string marriage_con { get; set; }
        [JsonProperty("Number Of Children")] public string pers_NumberofChildren { get; set; }
        [JsonProperty("Boys")] public string pers_Boys { get; set; }
        [JsonProperty("Girls")] public string pers_Girls { get; set; }
        [JsonProperty("Number Of Wives")] public string pers_Numberofwives { get; set; }
        [JsonProperty("Highest Level Of Education")] public string eduLevel { get; set; }
        [JsonProperty("Current Employment Status")] public string employment_status { get; set; }
        [JsonProperty("Body Weight (Kg)")] public string BodyWeight { get; set; }
        [JsonProperty("Waist Circumference (Cm)")] public string Waist { get; set; }
        [JsonProperty("Body Fat Mass (Kg)")] public string BodyMass { get; set; }
        [JsonProperty("Height")] public string Height { get; set; }
        [JsonProperty("Hip Circumference(Cm)")] public string hip { get; set; }
        [JsonProperty("Body Fat Percentage (%)")] public string bodyfatper { get; set; }
        [JsonProperty("Body Mass Index (Kg/M2)")] public string bmi { get; set; }
        [JsonProperty("WHR (WR/HR)")] public string WHR { get; set; }
        [JsonProperty("Blood Pressure Systolic")] public string BloodPressureSystolic { get; set; }
        [JsonProperty("Blood Pressure Diastolic")] public string BloodPressureDiastolic { get; set; }
        [JsonProperty("Skin Color")] public string skincolor { get; set; }
        [JsonProperty("Other")] public string skincolor_other_text { get; set; }
        [JsonProperty("Contact For Health Advice")] public string med_healthadvcontact { get; set; }
        [JsonProperty("Contact For Health Advice Other")] public string med_healthadvcontact_othtxt { get; set; }
        [JsonProperty("Annual Medical Checkup")] public string med_annualcheck { get; set; }
        [JsonProperty("Health Practitioners (Gp/Specialist/Consultant) In The Last 12 Months")] public string med_Gpvisit { get; set; }
        [JsonProperty("Health Practitioners Visit Remarks")] public string med_Gpvisit_yestxt { get; set; }
        [JsonProperty("Monitor Blood Glucose At Home (I.E. With Finger Pricks)")] public string med_glucosemon40 { get; set; }
        [JsonProperty("Monitor Blood Glucose Other")] public string med_glucosemon40_othtxt { get; set; }
        [JsonProperty("Admitted To The Hospital/Emergency")] public string med_hospitaladm { get; set; }
        [JsonProperty("Admitted To The Hospital/Emergency Remarks")] public string med_hospitaladm_yestxt { get; set; }
        [JsonProperty("Allergies")] public string allergies { get; set; }
        [JsonProperty("Allergies Remarks")] public string allergies_yestxt { get; set; }
        [JsonProperty("Intolerance")] public string intolerance { get; set; }
        [JsonProperty("Intolerance Remarks")] public string intolerance_yestxt { get; set; }
        [JsonProperty("Hypertension")] public string med_hypertension { get; set; }
        [JsonProperty("Hypertension Year")] public string med_hypertension_year { get; set; }
        [JsonProperty("Type 2 Diabetes")] public string med_type2diabetes { get; set; }
        [JsonProperty("Type 2 Diabetes Year")] public string med_type2diabetes_year { get; set; }
        [JsonProperty("Type 1 Diabetes")] public string med_type1diabetes { get; set; }
        [JsonProperty("Type 1 Diabetes Year")] public string med_type1diabetes_year { get; set; }
        [JsonProperty("High Cholesterol")] public string med_highcholesterol { get; set; }
        [JsonProperty("High Cholesterol Year")] public string med_highcholesterol_year { get; set; }
        [JsonProperty("Obesity")] public string med_obesity { get; set; }
        [JsonProperty("Obesity Year")] public string med_obesity_year { get; set; }
        [JsonProperty("Heart Disease")] public string med_heartdis { get; set; }
        [JsonProperty("Heart Disease Year")] public string med_heartdis_year { get; set; }
        [JsonProperty("Cancer")] public string med_cancer { get; set; }
        [JsonProperty("Cancer Year")] public string med_cancer_year { get; set; }
        [JsonProperty("Cancer Type")] public string med_cancer_type { get; set; }
        [JsonProperty("Depression")] public string med_depression { get; set; }
        [JsonProperty("Depression Year")] public string med_depression_year { get; set; }
        [JsonProperty("Osteoporosis")] public string med_osteoporosis { get; set; }
        [JsonProperty("Osteoporosis Year")] public string med_osteoporosis_year { get; set; }
        [JsonProperty("Asthma")] public string med_asthma { get; set; }
        [JsonProperty("Asthma Year")] public string med_asthma_year { get; set; }
        [JsonProperty("Inherited Disease")] public string med_inheriteddis { get; set; }
        [JsonProperty("Inherited Disease Year")] public string med_inheriteddis_year { get; set; }
        [JsonProperty("Thyroid Problem")] public string med_thyroid { get; set; }
        [JsonProperty("Thyroid Problem Year")] public string med_thyroid_year { get; set; }
        [JsonProperty("Liver Disease")] public string med_liver { get; set; }
        [JsonProperty("Liver Disease Year")] public string med_liver_year { get; set; }
        [JsonProperty("Arthritis Rheumatism")] public string med_arthritis { get; set; }
        [JsonProperty("Arthritis Rheumatism Year")] public string med_arthritis_year { get; set; }
        [JsonProperty("Hepatitis A-B-C-D")] public string med_hepatitis { get; set; }
        [JsonProperty("Hepatitis A-B-C-D Year")] public string med_hepatitis_year { get; set; }
        [JsonProperty("Sickle Cell Disease")] public string med_sickle { get; set; }
        [JsonProperty("Sickle Cell Disease Year")] public string med_sickle_year { get; set; }
        [JsonProperty("Neurological Disorder")] public string med_neurological { get; set; }
        [JsonProperty("Neurological Disorder Year")] public string med_neurological_year { get; set; }
        [JsonProperty("Fainting/Dizzy Spills")] public string med_faint { get; set; }
        [JsonProperty("Fainting/Dizzy Spills Year")] public string med_faint_year { get; set; }
        [JsonProperty("Headache/Migraine")] public string med_migraine { get; set; }
        [JsonProperty("Headache/Migraine Year")] public string med_migraine_year { get; set; }
        [JsonProperty("Epilepsy/Seizures")] public string med_epilepsy { get; set; }
        [JsonProperty("Epilepsy/Seizures Year")] public string med_epilepsy_year { get; set; }
        [JsonProperty("Epilepsy/Seizures Others")] public string med_other_specify { get; set; }
        [JsonProperty("Surgery")] public string med_surgery { get; set; }
        [JsonProperty("Surgery Remarks")] public string med_surgery_yestxt { get; set; }
        [JsonProperty("Medication For Hypertension")] public string medication_hypertension { get; set; }
        [JsonProperty("Medication For Type1 Diabetes")] public string medication_type1 { get; set; }
        [JsonProperty("Medication For Type2 Diabetes")] public string medication_type2 { get; set; }
        [JsonProperty("Medication For High Cholestrol")] public string medication_choles { get; set; }
        [JsonProperty("Medication For Obesity")] public string medication_obe { get; set; }
        [JsonProperty("Medication For Heart Disease")] public string medication_heart { get; set; }
        [JsonProperty("Medication For Cancer")] public string medication_cancer { get; set; }
        [JsonProperty("Medication For Depression")] public string medication_dep { get; set; }
        [JsonProperty("Medication For Osteoporosis")] public string medication_osteo { get; set; }
        [JsonProperty("Medication For Asthma")] public string medication_asth { get; set; }
        [JsonProperty("Medication For Inherited Disease")] public string medication_inhdis { get; set; }
        [JsonProperty("Vitamin Supplements")] public string medication_vit { get; set; }
        [JsonProperty("No Medication")] public string medication_none { get; set; }
        [JsonProperty("Vaccinations Up-To-Date")] public string med_vaccine { get; set; }
        [JsonProperty("Diabetes Related Complications")] public string type2_complications { get; set; }
        [JsonProperty("Diabetes Related Complications Years")] public string type2_complications_yestxt { get; set; }
        [JsonProperty("Retinopathy")] public string type2_retinopathy { get; set; }
        [JsonProperty("Neuropathy")] public string type2_neuropathy { get; set; }
        [JsonProperty("Neuropathy Other")] public string type2_neuropathy_other { get; set; }
        [JsonProperty("Cerebrovascular Accident(Cva)")] public string type2_cva { get; set; }
        [JsonProperty("Nephropathy")] public string type2_nephropathy { get; set; }
        [JsonProperty("Nephropathy Egfr")] public string type2_egfr { get; set; }
        [JsonProperty("Coronary Artery Disease")] public string type2_cad { get; set; }
        [JsonProperty("Type 2 Other")] public string type2_other { get; set; }
        [JsonProperty("Type 2 Other Remarks")] public string type2_other_specify { get; set; }
        [JsonProperty("Current Diabetes Management Method None")] public string diabetes_mgt_none { get; set; }
        [JsonProperty("Current Diabetes Management Method Tablets Only")] public string diabetes_mgt_tabletsonly { get; set; }
        [JsonProperty("Current Diabetes Management Method Diet/Tablet")] public string diabetes_mgt_diettablets { get; set; }
        [JsonProperty("Current Diabetes Management Method Diet/Tablet/Insulin")] public string diabetes_mgt_diettabletsinsulin { get; set; }
        [JsonProperty("Current Diabetes Management Method Diet Only")] public string diabetes_mgt_dietonly { get; set; }
        [JsonProperty("Current Diabetes Management Method Insulin Only")] public string diabetes_mgt_insulinonly { get; set; }
        [JsonProperty("Current Diabetes Management Method Diet/Insulin")] public string diabetes_mgt_dietinsulin { get; set; }
        [JsonProperty("Current Diabetes Management Method Unknown")] public string diabetes_mgt_unknown { get; set; }
        [JsonProperty("Current Diabetes Management Others")] public string diabetes_mgt_other { get; set; }
        [JsonProperty("Current Diabetes Management Others Remarks")] public string diabetes_mgt_othertxt { get; set; }
        [JsonProperty("Fasting Glucose Level Recent Date")] public string BIO_FastingGlucose_RecentTest_Date { get; set; }
        [JsonProperty("Fasting Glucose Level Recent Result")] public string BIO_FastingGlucose_RecentTest_Result { get; set; }
        [JsonProperty("Fasting Glucose Level Last Date")] public string BIO_FastingGlucose_LastTest_Date { get; set; }
        [JsonProperty("Fasting Glucose Level Last Result")] public string BIO_FastingGlucose_LastTest_Result { get; set; }
        [JsonProperty("Fasting Glucose Level  Result Normal")] public string BIO_FastingGlucose_IsNormalResult { get; set; }
        [JsonProperty("Random Glucose Level Recent Date")] public string BIO_RandomGlucose_RecentTest_Date { get; set; }
        [JsonProperty("Random Glucose Level Recent Result")] public string BIO_RandomGlucose_RecentTest_Result { get; set; }
        [JsonProperty("Random Glucose Level Last Date")] public string BIO_RandomGlucose_LastTest_Date { get; set; }
        [JsonProperty("Random Glucose Level Last Result")] public string BIO_RandomGlucose_LastTest_Result { get; set; }
        [JsonProperty("Random Glucose Level  Result Normal")] public string BIO_RandomGlucose_IsNormalResult { get; set; }
        [JsonProperty("FBG Level Recent Date")] public string BIO_OGTT_FBG_RecentTest_Date { get; set; }
        [JsonProperty("FBG Level Recent Result")] public string BIO_OGTT_FBG_RecentTest_Result { get; set; }
        [JsonProperty("FBG Level Last Date")] public string BIO_OGTT_FBG_LastTest_Date { get; set; }
        [JsonProperty("FBG Level Last Result")] public string BIO_OGTT_FBG_LastTest_Result { get; set; }
        [JsonProperty("FBG Level  Result Normal")] public string BIO_OGTT_FBG_IsNormalResult { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hours Recent Date")] public string BIO_OGTT_FBG2_RecentTest_Date { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hours Recent Result")] public string BIO_OGTT_FBG2_RecentTest_Result { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hours Last Date")] public string BIO_OGTT_FBG2_LastTest_Date { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hours Last Result")] public string BIO_OGTT_FBG2_LastTest_Result { get; set; }
        [JsonProperty("Glucose Tolerance (OGTT) FBG After 2 Hours Result Normal")] public string BIO_OGTT_FBG2_IsNormalResult { get; set; }
        [JsonProperty("HbA1C (%) Recent Date")] public string BIO_HbA1c_RecentTest_Date { get; set; }
        [JsonProperty("HbA1C (%) Recent Result")] public string BIO_HbA1c_RecentTest_Result { get; set; }
        [JsonProperty("HbA1C (%) Last Date")] public string BIO_HbA1c_LastTest_Date { get; set; }
        [JsonProperty("HbA1C (%) Last Result")] public string BIO_HbA1c_LastTest_Result { get; set; }
        [JsonProperty("HbA1C (%) Result Normal")] public string BIO_HbA1c_IsNormalResult { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Recent Date")] public string BIO_TotalCholesterol_RecentTest_Date { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Recent Result")] public string BIO_TotalCholesterol_RecentTest_Result { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) last Date")] public string BIO_TotalCholesterol_LastTest_Date { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Last Result")] public string BIO_TotalCholesterol_LastTest_Result { get; set; }
        [JsonProperty("Total Cholesterol (Mmol/L) Result Normal")] public string BIO_TotalCholesterol_IsNormalResult { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Recent Date")] public string BIO_Triglyceride_RecentTest_Date { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Recent Result")] public string BIO_Triglyceride_RecentTest_Result { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Last Date")] public string BIO_Triglyceride_LastTest_Date { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Last Result")] public string BIO_Triglyceride_LastTest_Result { get; set; }
        [JsonProperty("Triglyceride (Mmol/L) Result Normal")] public string BIO_Triglyceride_IsNormalResult { get; set; }
        [JsonProperty("HDL (Mmol/L) Recent Date")] public string BIO_HDL_RecentTest_Date { get; set; }
        [JsonProperty("HDL (Mmol/L) Recent Result")] public string BIO_HDL_RecentTest_Result { get; set; }
        [JsonProperty("HDL (Mmol/L) Last Date")] public string BIO_HDL_LastTest_Date { get; set; }
        [JsonProperty("HDL (Mmol/L) Last Result")] public string BIO_HDL_LastTest_Result { get; set; }
        [JsonProperty("HDL (Mmol/L) Result Normal")] public string BIO_HDL_IsNormalResult { get; set; }
        [JsonProperty("LDL (Mmol/L) Recent Date")] public string BIO_LDL_RecentTest_Date { get; set; }
        [JsonProperty("LDL (Mmol/L) Recent Result")] public string BIO_LDL_RecentTest_Result { get; set; }
        [JsonProperty("LDL (Mmol/L) Last Date")] public string BIO_LDL_LastTest_Date { get; set; }
        [JsonProperty("LDL (Mmol/L) Last Result")] public string BIO_LDL_LastTest_Result { get; set; }
        [JsonProperty("LDL (Mmol/L) Result Normal")] public string BIO_LDL_IsNormalResult { get; set; }
        [JsonProperty("Microalbumin (Mg) Recent Date")] public string BIO_Microalbumin_RecentTest_Date { get; set; }
        [JsonProperty("Microalbumin (Mg) Recent Result")] public string BIO_Microalbumin_RecentTest_Result { get; set; }
        [JsonProperty("Microalbumin (Mg) Last Date")] public string BIO_Microalbumin_LastTest_Date { get; set; }
        [JsonProperty("Microalbumin (Mg) Last Result")] public string BIO_Microalbumin_LastTest_Result { get; set; }
        [JsonProperty("Microalbumin (Mg) Result Normal")] public string BIO_Microalbumin_IsNormalResult { get; set; }
        [JsonProperty("Albuminuria (Mg) Recent Date")] public string BIO_albuminuria_RecentTest_Date { get; set; }
        [JsonProperty("Albuminuria (Mg) Recent Result")] public string BIO_albuminuria_RecentTest_Result { get; set; }
        [JsonProperty("Albuminuria (Mg) Last Date")] public string BIO_albuminuria_LastTest_Date { get; set; }
        [JsonProperty("Albuminuria (Mg) Last Result")] public string BIO_albuminuria_LastTest_Result { get; set; }
        [JsonProperty("Albuminuria (Mg) Result Normal")] public string BIO_albuminuria_IsNormalResult { get; set; }
        [JsonProperty("Albumincreatinine (Mg) Recent Date")] public string BIO_albumincreatinine_RecentTest_Date { get; set; }
        [JsonProperty("Albumincreatinine (Mg) Recent Result")] public string BIO_albumincreatinine_RecentTest_Result { get; set; }
        [JsonProperty("Albumincreatinine (Mg) Last Date")] public string BIO_albumincreatinine_LastTest_Date { get; set; }
        [JsonProperty("Albumincreatinine (Mg) Last Result")] public string BIO_albumincreatinine_LastTest_Result { get; set; }
        [JsonProperty("Albumincreatinine (Mg) Result Normal")] public string BIO_albumincreatinine_IsNormalResult { get; set; }
        [JsonProperty("Creatinine Recent Date")] public string BIO_Creatinine_RecentTest_Date { get; set; }
        [JsonProperty("Creatinine Recent Result")] public string BIO_Creatinine_RecentTest_Result { get; set; }
        [JsonProperty("Creatinine Last Date")] public string BIO_Creatinine_LastTest_Date { get; set; }
        [JsonProperty("Creatinine Last Result")] public string BIO_Creatinine_LastTest_Result { get; set; }
        [JsonProperty("Creatinine Result Normal")] public string BIO_Creatinine_IsNormalResult { get; set; }
        [JsonProperty("Urea Recent Date")] public string BIO_Urea_RecentTest_Date { get; set; }
        [JsonProperty("Urea Recent Result")] public string BIO_Urea_RecentTest_Result { get; set; }
        [JsonProperty("Urea Last Date")] public string BIO_Urea_LastTest_Date { get; set; }
        [JsonProperty("Urea Last Result")] public string BIO_Urea_LastTest_Result { get; set; }
        [JsonProperty("Urea Result Normal")] public string BIO_Urea_IsNormalResult { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Recent Date")] public string BIO_VitaminDLevel_RecentTest_Date { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L)  Recent Result")] public string BIO_VitaminDLevel_RecentTest_Result { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Last Date")] public string BIO_VitaminDLevel_LastTest_Date { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Last Result")] public string BIO_VitaminDLevel_LastTest_Result { get; set; }
        [JsonProperty("Vitamin D Level (Nmol/L) Result Normal")] public string BIO_VitaminDLevel_IsNormalResult { get; set; }
        [JsonProperty("Egfr Recent Date")] public string BIO_egfr_RecentTest_Date { get; set; }
        [JsonProperty("Egfr Recent Result")] public string BIO_egfr_RecentTest_Result { get; set; }
        [JsonProperty("Egfr Last Date")] public string BIO_egfr_LastTest_Date { get; set; }
        [JsonProperty("Egfr Last Result")] public string BIO_egfr_LastTest_Result { get; set; }
        [JsonProperty("Egfr Result Normal")] public string BIO_egfr_IsNormalResult { get; set; }
        [JsonProperty("Sodium Recent Date")] public string BIO_sodium_RecentTest_Date { get; set; }
        [JsonProperty("Sodium Recent Result")] public string BIO_sodium_RecentTest_Result { get; set; }
        [JsonProperty("Sodium Last Date")] public string BIO_sodium_LastTest_Date { get; set; }
        [JsonProperty("Sodium Last Result")] public string BIO_sodium_LastTest_Result { get; set; }
        [JsonProperty("Sodium Result Normal")] public string BIO_sodium_IsNormalResult { get; set; }
        [JsonProperty("Potassium Recent Date")] public string BIO_potassium_RecentTest_Date { get; set; }
        [JsonProperty("Potassium Recent Result")] public string BIO_potassium_RecentTest_Result { get; set; }
        [JsonProperty("Potassium Last Date")] public string BIO_potassium_LastTest_Date { get; set; }
        [JsonProperty("Potassium Last Result")] public string BIO_potassium_LastTest_Result { get; set; }
        [JsonProperty("Potassium Result Normal")] public string BIO_potassium_IsNormalResult { get; set; }
        [JsonProperty("Calcium Recent Date")] public string BIO_calcium_RecentTest_Date { get; set; }
        [JsonProperty("Calcium Recent Result")] public string BIO_calcium_RecentTest_Result { get; set; }
        [JsonProperty("Calcium Last Date")] public string BIO_calcium_LastTest_Date { get; set; }
        [JsonProperty("Calcium Last Result")] public string BIO_calcium_LastTest_Result { get; set; }
        [JsonProperty("Calcium Result Normal")] public string BIO_calcium_IsNormalResult { get; set; }
        [JsonProperty("Magnesium Recent Date")] public string BIO_mag_RecentTest_Date { get; set; }
        [JsonProperty("Magnesium Recent Result")] public string BIO_mag_RecentTest_Result { get; set; }
        [JsonProperty("Magnesium Last Date")] public string BIO_mag_LastTest_Date { get; set; }
        [JsonProperty("Magnesium Last Result")] public string BIO_mag_LastTest_Result { get; set; }
        [JsonProperty("Magnesium Result Normal")] public string BIO_mag_IsNormalResult { get; set; }
        [JsonProperty("Phosphorus Recent Date")] public string BIO_phos_RecentTest_Date { get; set; }
        [JsonProperty("Phosphorus Recent Result")] public string BIO_phos_RecentTest_Result { get; set; }
        [JsonProperty("Phosphorus Last Date")] public string BIO_phos_LastTest_Date { get; set; }
        [JsonProperty("Phosphorus Last Result")] public string BIO_phos_LastTest_Result { get; set; }
        [JsonProperty("Phosphorus Result Normal")] public string BIO_phos_IsNormalResult { get; set; }
        [JsonProperty("Bicarbonate Recent Date")] public string BIO_bicar_RecentTest_Date { get; set; }
        [JsonProperty("Bicarbonate Recent Result")] public string BIO_bicar_RecentTest_Result { get; set; }
        [JsonProperty("Bicarbonate Last Date")] public string BIO_bicar_LastTest_Date { get; set; }
        [JsonProperty("Bicarbonate Last Result")] public string BIO_bicar_LastTest_Result { get; set; }
        [JsonProperty("Bicarbonate Result Normal")] public string BIO_bicar_IsNormalResult { get; set; }
        [JsonProperty("Protein Recent Date")] public string BIO_protein_RecentTest_Date { get; set; }
        [JsonProperty("Protein Recent Result")] public string BIO_protein_RecentTest_Result { get; set; }
        [JsonProperty("Protein Last Date")] public string BIO_protein_LastTest_Date { get; set; }
        [JsonProperty("Protein Last Result")] public string BIO_protein_LastTest_Result { get; set; }
        [JsonProperty("Protein Result Normal")] public string BIO_protein_IsNormalResult { get; set; }
        [JsonProperty("Serum Recent Date")] public string BIO_serum_RecentTest_Date { get; set; }
        [JsonProperty("Serum Recent Result")] public string BIO_serum_RecentTest_Result { get; set; }
        [JsonProperty("Serum Last Date")] public string BIO_serum_LastTest_Date { get; set; }
        [JsonProperty("Serum Last Result")] public string BIO_serum_LastTest_Result { get; set; }
        [JsonProperty("Serum Result Normal")] public string BIO_serum_IsNormalResult { get; set; }
        [JsonProperty("C-Reative Protein Recent Date")] public string BIO_cprotein_RecentTest_Date { get; set; }
        [JsonProperty("C-Reactive Protein Recent Result")] public string BIO_cprotein_RecentTest_Result { get; set; }
        [JsonProperty("C-Reactive Protein Last Date")] public string BIO_cprotein_LastTest_Date { get; set; }
        [JsonProperty("C-Reactive Protein Last Result")] public string BIO_cprotein_LastTest_Result { get; set; }
        [JsonProperty("C-Reactive Protein Result Normal")] public string BIO_cprotein_IsNormalResult { get; set; }
        [JsonProperty("Alt Recent Date")] public string BIO_alt_RecentTest_Date { get; set; }
        [JsonProperty("Alt Recent Result")] public string BIO_alt_RecentTest_Result { get; set; }
        [JsonProperty("Alt Last Date")] public string BIO_alt_LastTest_Date { get; set; }
        [JsonProperty("Alt Last Result")] public string BIO_alt_LastTest_Result { get; set; }
        [JsonProperty("Alt Result Normal")] public string BIO_alt_IsNormalResult { get; set; }
        [JsonProperty("Alp Recent Date")] public string BIO_alp_RecentTest_Date { get; set; }
        [JsonProperty("Alp Recent Result")] public string BIO_alp_RecentTest_Result { get; set; }
        [JsonProperty("Alp Last Date")] public string BIO_alp_LastTest_Date { get; set; }
        [JsonProperty("Alp Last Result")] public string BIO_alp_LastTest_Result { get; set; }
        [JsonProperty("Alp Result Normal")] public string BIO_alp_IsNormalResult { get; set; }
        [JsonProperty("Ast Recent Date")] public string BIO_ast_RecentTest_Date { get; set; }
        [JsonProperty("Ast Recent Result")] public string BIO_ast_RecentTest_Result { get; set; }
        [JsonProperty("Ast Last Date")] public string BIO_ast_LastTest_Date { get; set; }
        [JsonProperty("Ast Last Result")] public string BIO_ast_LastTest_Result { get; set; }
        [JsonProperty("Ast Result Normal")] public string BIO_ast_IsNormalResult { get; set; }
        [JsonProperty("Bilirubin Recent Date")] public string BIO_bilirubin_RecentTest_Date { get; set; }
        [JsonProperty("Bilirubin Recent Result")] public string BIO_bilirubin_RecentTest_Result { get; set; }
        [JsonProperty("Bilirubin Last Date")] public string BIO_bilirubin_LastTest_Date { get; set; }
        [JsonProperty("Bilirubin Last Result")] public string BIO_bilirubin_LastTest_Result { get; set; }
        [JsonProperty("Bilirubin Result Normal")] public string BIO_bilirubin_IsNormalResult { get; set; }
        [JsonProperty("T3 Recent Date")] public string BIO_t3_RecentTest_Date { get; set; }
        [JsonProperty("T3 Recent Result")] public string BIO_t3_RecentTest_Result { get; set; }
        [JsonProperty("T3 Last Date")] public string BIO_t3_LastTest_Date { get; set; }
        [JsonProperty("T3 Last Result")] public string BIO_t3_LastTest_Result { get; set; }
        [JsonProperty("T3 Result Normal")] public string BIO_t3_IsNormalResult { get; set; }
        [JsonProperty("T4 Recent Date")] public string BIO_t4_RecentTest_Date { get; set; }
        [JsonProperty("T4 Recent Result")] public string BIO_t4_RecentTest_Result { get; set; }
        [JsonProperty("T4 Last Date")] public string BIO_t4_LastTest_Date { get; set; }
        [JsonProperty("T4 Last Result")] public string BIO_t4_LastTest_Result { get; set; }
        [JsonProperty("T4 Result Normal")] public string BIO_t4_IsNormalResult { get; set; }
        [JsonProperty("Free T4 Recent Date")] public string BIO_freet4_RecentTest_Date { get; set; }
        [JsonProperty("Free T4 Recent Result")] public string BIO_freet4_RecentTest_Result { get; set; }
        [JsonProperty("Free T4 Last Date")] public string BIO_freet4_LastTest_Date { get; set; }
        [JsonProperty("Free T4 Last Result")] public string BIO_freet4_LastTest_Result { get; set; }
        [JsonProperty("Free T4 Result Normal")] public string BIO_freet4_IsNormalResult { get; set; }
        [JsonProperty("Tsh Recent Date")] public string BIO_tsh_RecentTest_Date { get; set; }
        [JsonProperty("Tsh Recent Result")] public string BIO_tsh_RecentTest_Result { get; set; }
        [JsonProperty("Tsh Last Date")] public string BIO_tsh_LastTest_Date { get; set; }
        [JsonProperty("Tsh Last Result")] public string BIO_tsh_LastTest_Result { get; set; }
        [JsonProperty("Tsh Result Normal")] public string BIO_tsh_IsNormalResult { get; set; }
        [JsonProperty("Parathyroid Recent Date")] public string BIO_parathyroid_RecentTest_Date { get; set; }
        [JsonProperty("Parathyroid Recent Result")] public string BIO_parathyroid_RecentTest_Result { get; set; }
        [JsonProperty("Parathyroid Last Date")] public string BIO_parathyroid_LastTest_Date { get; set; }
        [JsonProperty("Parathyroid Last Result")] public string BIO_parathyroid_LastTest_Result { get; set; }
        [JsonProperty("Parathyroid Result Normal")] public string BIO_parathyroid_IsNormalResult { get; set; }
        [JsonProperty("Wbc Count Recent Date")] public string BIO_wbc_RecentTest_Date { get; set; }
        [JsonProperty("Wbc Count Recent Result")] public string BIO_wbc_RecentTest_Result { get; set; }
        [JsonProperty("Wbc Count Last Date")] public string BIO_wbc_LastTest_Date { get; set; }
        [JsonProperty("Wbc Count Last Result")] public string BIO_wbc_LastTest_Result { get; set; }
        [JsonProperty("Wbc Count Result Normal")] public string BIO_wbc_IsNormalResult { get; set; }
        [JsonProperty("Wbc Differential Count Recent Date")] public string BIO_wbc_diff_RecentTest_Date { get; set; }
        [JsonProperty("Wbc Differential Count Recent Result")] public string BIO_wbc_diff_RecentTest_Result { get; set; }
        [JsonProperty("Wbc Differential Count Last Date")] public string BIO_wbc_diff_LastTest_Date { get; set; }
        [JsonProperty("Wbc Differential Count Last Result")] public string BIO_wbc_diff_LastTest_Result { get; set; }
        [JsonProperty("Wbc Differential Count Result Normal")] public string BIO_wbc_diff_IsNormalResult { get; set; }
        [JsonProperty("Rbc Count Recent Date")] public string BIO_rbc_RecentTest_Date { get; set; }
        [JsonProperty("Rbc Count Recent Result")] public string BIO_rbc_RecentTest_Result { get; set; }
        [JsonProperty("Rbc Count Last Date")] public string BIO_rbc_LastTest_Date { get; set; }
        [JsonProperty("Rbc Count Last Result")] public string BIO_rbc_LastTest_Result { get; set; }
        [JsonProperty("Rbc Count Result Normal")] public string BIO_rbc_IsNormalResult { get; set; }
        [JsonProperty("Haemoglobin Recent Date")] public string BIO_haemoglobin_RecentTest_Date { get; set; }
        [JsonProperty("Haemoglobin Recent Result")] public string BIO_haemoglobin_RecentTest_Result { get; set; }
        [JsonProperty("Haemoglobin Last Date")] public string BIO_haemoglobin_LastTest_Date { get; set; }
        [JsonProperty("Haemoglobin Last Result")] public string BIO_haemoglobin_LastTest_Result { get; set; }
        [JsonProperty("Haemoglobin Result Normal")] public string BIO_haemoglobin_IsNormalResult { get; set; }
        [JsonProperty("Haematocrit Recent Date")] public string BIO_haematocrit_RecentTest_Date { get; set; }
        [JsonProperty("Haematocrit Recent Result")] public string BIO_haematocrit_RecentTest_Result { get; set; }
        [JsonProperty("Haematocrit Last Date")] public string BIO_haematocrit_LastTest_Date { get; set; }
        [JsonProperty("Haematocrit Last Result")] public string BIO_haematocrit_LastTest_Result { get; set; }
        [JsonProperty("Haematocrit Result Normal")] public string BIO_haematocrit_IsNormalResult { get; set; }
        [JsonProperty("Ferritin Recent Date")] public string BIO_ferritin_RecentTest_Date { get; set; }
        [JsonProperty("Ferritin Recent Result")] public string BIO_ferritin_RecentTest_Result { get; set; }
        [JsonProperty("Ferritin Last Date")] public string BIO_ferritin_LastTest_Date { get; set; }
        [JsonProperty("Ferritin Last Result")] public string BIO_ferritin_LastTest_Result { get; set; }
        [JsonProperty("Ferritin Result Normal")] public string BIO_ferritin_IsNormalResult { get; set; }
        [JsonProperty("Rdw Recent Date")] public string BIO_rdw_RecentTest_Date { get; set; }
        [JsonProperty("Rdw Recent Result")] public string BIO_rdw_RecentTest_Result { get; set; }
        [JsonProperty("Rdw Last Date")] public string BIO_rdw_LastTest_Date { get; set; }
        [JsonProperty("Rdw Last Result")] public string BIO_rdw_LastTest_Result { get; set; }
        [JsonProperty("Rdw Result Normal")] public string BIO_rdw_IsNormalResult { get; set; }
        [JsonProperty("Rbcmcv Recent Date")] public string BIO_rbcmcv_RecentTest_Date { get; set; }
        [JsonProperty("Rbcmcv Recent Result")] public string BIO_rbcmcv_RecentTest_Result { get; set; }
        [JsonProperty("Rbcmcv Last Date")] public string BIO_rbcmcv_LastTest_Date { get; set; }
        [JsonProperty("Rbcmcv Last Result")] public string BIO_rbcmcv_LastTest_Result { get; set; }
        [JsonProperty("Rbcmcv Result Normal")] public string BIO_rbcmcv_IsNormalResult { get; set; }
        [JsonProperty("Rbcmch Recent Date")] public string BIO_rbcmch_RecentTest_Date { get; set; }
        [JsonProperty("Rbcmch Recent Result")] public string BIO_rbcmch_RecentTest_Result { get; set; }
        [JsonProperty("Rbcmch Last Date")] public string BIO_rbcmch_LastTest_Date { get; set; }
        [JsonProperty("Rbcmch Last Result")] public string BIO_rbcmch_LastTest_Result { get; set; }
        [JsonProperty("Rbcmch Result Normal")] public string BIO_rbcmch_IsNormalResult { get; set; }
        [JsonProperty("Rbcmchc Recent Date")] public string BIO_rbcmchc_RecentTest_Date { get; set; }
        [JsonProperty("Rbcmchc Recent Result")] public string BIO_rbcmchc_RecentTest_Result { get; set; }
        [JsonProperty("Rbcmchc Last Date")] public string BIO_rbcmchc_LastTest_Date { get; set; }
        [JsonProperty("Rbcmchc Last Result")] public string BIO_rbcmchc_LastTest_Result { get; set; }
        [JsonProperty("Rbcmchc Result Normal")] public string BIO_rbcmchc_IsNormalResult { get; set; }
        [JsonProperty("Reticulocyte Recent Date")] public string BIO_Reticulocyte_RecentTest_Date { get; set; }
        [JsonProperty("Reticulocyte Recent Result")] public string BIO_Reticulocyte_RecentTest_Result { get; set; }
        [JsonProperty("Reticulocyte Last Date")] public string BIO_Reticulocyte_LastTest_Date { get; set; }
        [JsonProperty("Reticulocyte Last Result")] public string BIO_Reticulocyte_LastTest_Result { get; set; }
        [JsonProperty("Reticulocyte Result Normal")] public string BIO_Reticulocyte_IsNormalResult { get; set; }
        [JsonProperty("Platelet Recent Date")] public string BIO_Platelet_RecentTest_Date { get; set; }
        [JsonProperty("Platelet Recent Result")] public string BIO_Platelet_RecentTest_Result { get; set; }
        [JsonProperty("Platelet Last Date")] public string BIO_Platelet_LastTest_Date { get; set; }
        [JsonProperty("Platelet Last Result")] public string BIO_Platelet_LastTest_Result { get; set; }
        [JsonProperty("Platelet Result Normal")] public string BIO_Platelet_IsNormalResult { get; set; }
        [JsonProperty("Mpv Recent Date")] public string BIO_mpv_RecentTest_Date { get; set; }
        [JsonProperty("Mpv Recent Result")] public string BIO_mpv_RecentTest_Result { get; set; }
        [JsonProperty("Mpv Last Date")] public string BIO_mpv_LastTest_Date { get; set; }
        [JsonProperty("Mpv Last Result")] public string BIO_mpv_LastTest_Result { get; set; }
        [JsonProperty("Mpv Result Normal")] public string BIO_mpv_IsNormalResult { get; set; }
        [JsonProperty("Urine Tests Summary Macroscopic Recent Date")] public string BIO_UTSmacroscopic_RecentTest_Date { get; set; }
        [JsonProperty("Urine Tests Summary Macroscopic Recent Result")] public string BIO_UTSmacroscopic_RecentTest_Result { get; set; }
        [JsonProperty("Urine Tests Summary Macroscopic Last Date")] public string BIO_UTSmacroscopic_LastTest_Date { get; set; }
        [JsonProperty("Urine Tests Summary Macroscopic Last Result")] public string BIO_UTSmacroscopic_LastTest_Result { get; set; }
        [JsonProperty("Urine Tests Summary Macroscopic Result Normal")] public string BIO_UTSmacroscopic_IsNormalResult { get; set; }
        [JsonProperty("UTSph Recent Date")] public string BIO_UTSph_RecentTest_Date { get; set; }
        [JsonProperty("UTSph Recent Result")] public string BIO_UTSph_RecentTest_Result { get; set; }
        [JsonProperty("UTSph Last Date")] public string BIO_UTSph_LastTest_Date { get; set; }
        [JsonProperty("UTSph Last Result")] public string BIO_UTSph_LastTest_Result { get; set; }
        [JsonProperty("UTSph Result Normal")] public string BIO_UTSph_IsNormalResult { get; set; }
        [JsonProperty("UTS Glucose Recent Date")] public string BIO_UTSglu_RecentTest_Date { get; set; }
        [JsonProperty("UTS Glucose Recent Result")] public string BIO_UTSglu_RecentTest_Result { get; set; }
        [JsonProperty("UTS Glucose Last Date")] public string BIO_UTSglu_LastTest_Date { get; set; }
        [JsonProperty("UTS Glucose Last Result")] public string BIO_UTSglu_LastTest_Result { get; set; }
        [JsonProperty("UTS Glucose Result Normal")] public string BIO_UTSglu_IsNormalResult { get; set; }
        [JsonProperty("UTS Gravity Recent Date")] public string BIO_UTSgravity_RecentTest_Date { get; set; }
        [JsonProperty("UTS Gravity Recent Result")] public string BIO_UTSgravity_RecentTest_Result { get; set; }
        [JsonProperty("UTS Gravity Last Date")] public string BIO_UTSgravity_LastTest_Date { get; set; }
        [JsonProperty("UTS Gravity Last Result")] public string BIO_UTSgravity_LastTest_Result { get; set; }
        [JsonProperty("UTS Gravity Result Normal")] public string BIO_UTSgravity_IsNormalResult { get; set; }
        [JsonProperty("UTS Nitrite Recent Date")] public string BIO_UTSNitrite_RecentTest_Date { get; set; }
        [JsonProperty("UTS Nitrite Recent Result")] public string BIO_UTSNitrite_RecentTest_Result { get; set; }
        [JsonProperty("UTS Nitrite Last Date")] public string BIO_UTSNitrite_LastTest_Date { get; set; }
        [JsonProperty("UTS Nitrite Last Result")] public string BIO_UTSNitrite_LastTest_Result { get; set; }
        [JsonProperty("UTS Nitrite Result Normal")] public string BIO_UTSNitrite_IsNormalResult { get; set; }
        [JsonProperty("UTS Leukocyte Recent Date")] public string BIO_UTSLeukocyte_RecentTest_Date { get; set; }
        [JsonProperty("UTS Leukocyte Recent Result")] public string BIO_UTSLeukocyte_RecentTest_Result { get; set; }
        [JsonProperty("UTS Leukocyte Last Date")] public string BIO_UTSLeukocyte_LastTest_Date { get; set; }
        [JsonProperty("UTS Leukocyte Last Result")] public string BIO_UTSLeukocyte_LastTest_Result { get; set; }
        [JsonProperty("UTS Leukocyte Result Normal")] public string BIO_UTSLeukocyte_IsNormalResult { get; set; }
        [JsonProperty("UTS Microcells Recent Date")] public string BIO_UTSMicrocells_RecentTest_Date { get; set; }
        [JsonProperty("UTS Microcells Recent Result")] public string BIO_UTSMicrocells_RecentTest_Result { get; set; }
        [JsonProperty("UTS Microcells Last Date")] public string BIO_UTSMicrocells_LastTest_Date { get; set; }
        [JsonProperty("UTS Microcells Last Result")] public string BIO_UTSMicrocells_LastTest_Result { get; set; }
        [JsonProperty("UTS Microcells Result Normal")] public string BIO_UTSMicrocells_IsNormalResult { get; set; }
        [JsonProperty("UTS Microcasts Recent Date")] public string BIO_UTSMicrocasts_RecentTest_Date { get; set; }
        [JsonProperty("UTS Microcasts Recent Result")] public string BIO_UTSMicrocasts_RecentTest_Result { get; set; }
        [JsonProperty("UTS Microcasts Last Date")] public string BIO_UTSMicrocasts_LastTest_Date { get; set; }
        [JsonProperty("UTS Microcasts Last Result")] public string BIO_UTSMicrocasts_LastTest_Result { get; set; }
        [JsonProperty("UTS Microcasts Result Normal")] public string BIO_UTSMicrocasts_IsNormalResult { get; set; }
        [JsonProperty("UTS Microcrystals Recent Date")] public string BIO_UTSMicrocrystals_RecentTest_Date { get; set; }
        [JsonProperty("UTS Microcrystals Recent Result")] public string BIO_UTSMicrocrystals_RecentTest_Result { get; set; }
        [JsonProperty("UTS Microcrystals Last Date")] public string BIO_UTSMicrocrystals_LastTest_Date { get; set; }
        [JsonProperty("UTS Microcrystals Last Result")] public string BIO_UTSMicrocrystals_LastTest_Result { get; set; }
        [JsonProperty("UTS Microcrystals Result Normal")] public string BIO_UTSMicrocrystals_IsNormalResult { get; set; }
        [JsonProperty("Smoking Status")] public string life_smokingstatus { get; set; }
        public string Walk { get; set; }
        [JsonProperty("Walk Minutes A Week")] public string Walk_IfYes { get; set; }
        [JsonProperty("Walk Others")] public string Walk_others_Specify { get; set; }
        [JsonProperty("Intensity")] public string walking_intensity { get; set; }
        [JsonProperty("Healthy Diet")] public string healthy_diet { get; set; }
        [JsonProperty("Other Diet")] public string diet_other { get; set; }
        [JsonProperty("Weight Change In Past 5 Years")] public string weight_change { get; set; }
        [JsonProperty("Special Diet To Lose/Gain Weight")] public string spl_diet { get; set; }
        [JsonProperty("Fast Food")] public string fastfood_intake { get; set; }
        [JsonProperty("Fruits/Vegs")] public string fruits_veg { get; set; }
        [JsonProperty("Soft Drinks")] public string softdrinks { get; set; }
        [JsonProperty("Eat After Mid Night")] public string eat_after_midnight { get; set; }
        [JsonProperty("Satisfied With Body")] public string satisfied_body { get; set; }
        [JsonProperty("Happy With Life")] public string happy_life { get; set; }
        [JsonProperty("Healthy Individual")] public string healthy_individual { get; set; }
        [JsonProperty("Father Ethnicity")] public string fam_fatethnicity { get; set; }
        [JsonProperty("Father Ethnicity Other")] public string fam_fatethnicity_other { get; set; }
        [JsonProperty("Father Place Of Birth")] public string fam_fatplaceofbirth { get; set; }
        [JsonProperty("Mother Ethnicity")] public string fam_motethnicity { get; set; }
        [JsonProperty("Mother Ethnicity Other")] public string fam_motethnicity_other { get; set; }
        [JsonProperty("Mother Place Of Birth")] public string fam_motplaceofbirth { get; set; }
        [JsonProperty("Parents Related")] public string fam_parents_related { get; set; }
        [JsonProperty("Related Remarks")] public string fam_parents_related_yes { get; set; }
        [JsonProperty("Hypertension In Family")] public string fam_hypertension { get; set; }
        [JsonProperty("Heart Disease Family")] public string fam_heart { get; set; }
        [JsonProperty("Depression In Family")] public string fam_dep { get; set; }
        [JsonProperty("Osteoporosis In Family")] public string fam_osteo { get; set; }
        [JsonProperty("Type1 Diabetes In Family")] public string fam_type1 { get; set; }
        [JsonProperty("Type2 Diabetes In Family")] public string fam_type2 { get; set; }
        [JsonProperty("Gestational Diabetes In Family")] public string fam_gesdia { get; set; }
        [JsonProperty("Cancer In Family")] public string fam_cancer { get; set; }
        [JsonProperty("Cancer Type Condition")] public string fam_condition_cancer_type { get; set; }
        [JsonProperty("Other Disease In Family")] public string fam_other { get; set; }
        [JsonProperty("Other Disease In Family Remarks")] public string fam_condition_other { get; set; }
        [JsonProperty("Patients Family Pedigree")] public string fam_pedigree { get; set; }
        [JsonProperty("Blood")] public string lab_sample_type_blood { get; set; }
        [JsonProperty("Saliva")] public string lab_sample_type_saliva { get; set; }
        [JsonProperty("Tissue")] public string lab_sample_type_tissue { get; set; }
        [JsonProperty("Other Sample")] public string lab_sample_type_other { get; set; }
        [JsonProperty("Other Sample Remarls")] public string lab_sample_type_other_text { get; set; }
        [JsonProperty("Sample Receiving Date")] public string lab_sample_date { get; set; }
        [JsonProperty("Storage")] public string lab_storage { get; set; }
        [JsonProperty("Sample Volume")] public string lab_sample_volume { get; set; }
        [JsonProperty("Project Code")] public string lab_project_code { get; set; }
        [JsonProperty("Test Code")] public string lab_test_code { get; set; }
        [JsonProperty("Comments")] public string lab_comments { get; set; }
        [JsonProperty("Inhibit Ace")] public string inhibit_ace { get; set; }
        [JsonProperty("Perindop")] public string perindop { get; set; }
        [JsonProperty("Captopril")] public string captopril { get; set; }
        [JsonProperty("Enalapril")] public string enalapril { get; set; }
        [JsonProperty("Lisinop")] public string lisinop { get; set; }
        [JsonProperty("Medications Others")] public string medications_others { get; set; }
        [JsonProperty("Anti Hyper Arbs")] public string anti_hyper_arbs { get; set; }
        [JsonProperty("Losartan")] public string losartan { get; set; }
        [JsonProperty("Valsartan")] public string Valsartan { get; set; }
        [JsonProperty("Anti Dose")] public string anti_dose { get; set; }
        [JsonProperty("Beta Blockers")] public string beta_blockers { get; set; }
        [JsonProperty("Atenolol")] public string atenolol { get; set; }
        [JsonProperty("Bisopr")] public string bisopr { get; set; }
        [JsonProperty("Beta Other Dose")] public string beta_other_dose { get; set; }
        [JsonProperty("Diurectics")] public string diurectics { get; set; }
        [JsonProperty("Indapam")] public string indapam { get; set; }
        [JsonProperty("Hydroch")] public string hydroch { get; set; }
        [JsonProperty("Fruse")] public string fruse { get; set; }
        [JsonProperty("Diur Others Dose")] public string diur_others_dose { get; set; }
        [JsonProperty("Ca Channel Blockers")] public string CA_channel_blockers { get; set; }
        [JsonProperty("Amlodip")] public string amlodip { get; set; }
        [JsonProperty("Nifedip")] public string nifedip { get; set; }
        [JsonProperty("Verapamil")] public string verapamil { get; set; }
        [JsonProperty("Ca Channer Others")] public string ca_channer_others { get; set; }
        [JsonProperty("Others Oh")] public string others_oh { get; set; }
        [JsonProperty("Methyldop")] public string methyldop { get; set; }
        [JsonProperty("Anti Hyper Others Dose")] public string anti_hyper_others_dose { get; set; }
        [JsonProperty("Anti Dyslipidemia Statins")] public string Anti_Dyslipidemia_statins { get; set; }
        [JsonProperty("Simvast")] public string simvast { get; set; }
        [JsonProperty("Atorvast")] public string atorvast { get; set; }
        [JsonProperty("Rosuvas")] public string rosuvas { get; set; }
        [JsonProperty("Anti Dyslipidemia Otherd")] public string Anti_Dyslipidemia_OtherD { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates")] public string Anti_Dyslipidemia_fibrates { get; set; }
        [JsonProperty("Gemfib")] public string gemfib { get; set; }
        [JsonProperty("Fenofib")] public string fenofib { get; set; }
        [JsonProperty("Fibrat1")] public string fibrat1 { get; set; }
        [JsonProperty("Fibrat2")] public string fibrat2 { get; set; }
        [JsonProperty("Anti Dyslipidemia Others")] public string Anti_Dyslipidemia_others { get; set; }
        [JsonProperty("Anti others")] public string AntiOthers { get; set; }
        [JsonProperty("Anti Hyper Biguanides")] public string anti_hyper_Biguanides { get; set; }
        [JsonProperty("Metformin")] public string Metformin { get; set; }
        [JsonProperty("Anti Hyper Sus")] public string anti_hyper_sus { get; set; }
        [JsonProperty("Glibenclamide")] public string glibenclamide { get; set; }
        [JsonProperty("Glimepir")] public string glimepir { get; set; }
        [JsonProperty("Glipizide")] public string glipizide { get; set; }
        [JsonProperty("Gliclazide Mr")] public string gliclazide_mr { get; set; }
        [JsonProperty("Glipizide Dose")] public string glipizide_dose { get; set; }
        [JsonProperty("Pride Dose")] public string pride_dose { get; set; }
        [JsonProperty("Anti Hyper Other Su")] public string anti_hyper_other_su { get; set; }
        [JsonProperty("Anti Hyper Thiazolid")] public string anti_hyper_thiazolid { get; set; }
        [JsonProperty("Pioglit")] public string pioglit { get; set; }
        [JsonProperty("Anti Hyper Thiazolid Other")] public string anti_hyper_thiazolid_Other { get; set; }
        [JsonProperty("Anti Hyper Meglitin")] public string anti_hyper_meglitin { get; set; }
        [JsonProperty("Anti Hyper Nateglinide")] public string anti_hyper_Nateglinide { get; set; }
        [JsonProperty("Anti Hyper Repaglin")] public string anti_hyper_repaglin { get; set; }
        [JsonProperty("Anti Hyper Glucosid")] public string anti_hyper_glucosid { get; set; }
        [JsonProperty("Acarbose")] public string acarbose { get; set; }
        [JsonProperty("Anti Hyper Dipeptidyl")] public string anti_hyper_dipeptidyl { get; set; }
        [JsonProperty("Anti Hyper Sitaglip")] public string anti_hyper_sitaglip { get; set; }
        [JsonProperty("Anti Hyper Vildaglip")] public string anti_hyper_vildaglip { get; set; }
        [JsonProperty("Anti Hyper Saxaglip")] public string anti_hyper_saxaglip { get; set; }
        [JsonProperty("Anti Hyper Linaglip")] public string anti_hyper_linaglip { get; set; }
        [JsonProperty("Anti Hyper Peptid Others")] public string anti_hyper_peptid_others { get; set; }
        [JsonProperty("Pramlintide")] public string pramlintide { get; set; }
        [JsonProperty("Anti Hyper Other Peptid")] public string anti_hyper_other_peptid { get; set; }
        [JsonProperty("Anti Hyper Incretinm")] public string anti_hyper_incretinm { get; set; }
        [JsonProperty("Anti Hyper Exenatide")] public string anti_hyper_exenatide { get; set; }
        [JsonProperty("Anti Hyper Liraglut")] public string anti_hyper_liraglut { get; set; }
        [JsonProperty("Exenatide Dose")] public string exenatide_dose { get; set; }
        [JsonProperty("Anti Hyper Insulin Lin")] public string anti_hyper_insulin_lin { get; set; }
        [JsonProperty("Lispro Dose")] public string lispro_dose { get; set; }
        [JsonProperty("Aspart Dose")] public string aspart_dose { get; set; }
        [JsonProperty("Glulisine Dose")] public string glulisine_dose { get; set; }
        [JsonProperty("Regular Dose")] public string regular_dose { get; set; }
        [JsonProperty("Nph Dose")] public string nph_dose { get; set; }
        [JsonProperty("Detemir Dose")] public string Detemir_Dose { get; set; }
        [JsonProperty("Glargine")] public string glargine { get; set; }
        [JsonProperty("Anti Hyper Insulin Lin Combination")] public string anti_hyper_insulin_lin_combination { get; set; }
        [JsonProperty("Suplements Vitamind3")] public string suplements_vitamind3 { get; set; }
        [JsonProperty("Suplements Othervit")] public string suplements_OtherVit { get; set; }
        [JsonProperty("Anti Depre Prozac Dose")] public string anti_depre_prozac_dose { get; set; }
        [JsonProperty("Anti Depre Other Dose")] public string anti_depre_other_dose { get; set; }
        [JsonProperty("Anti Anx Diazepam Dose")] public string anti_anx_diazepam_dose { get; set; }
        [JsonProperty("Anti Anx Other Dose")] public string anti_anx_other_dose { get; set; }
        [JsonProperty("Medication Other Dose")] public string medication_other_dose { get; set; }
        [JsonProperty("Traditional Chinese")] public string traditional_chinese { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
