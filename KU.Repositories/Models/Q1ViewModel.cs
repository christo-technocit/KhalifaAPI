using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
    public class QuestionnaireWrap
    {
        public QuestionnaireWrap()
        {
            result = new List<Q1ViewModel>();

        }
        public IEnumerable<Q1ViewModel> result { get; set; }



    }
    public class Q1ViewModel
    {

        [Key]
        public string SavedFormID { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }

        public string Sample { get; set; }
        [JsonProperty("Date Assesed")] public string DateAsses { get; set; }
        [JsonProperty("Collected By")] public string collected_by { get; set; }
        [JsonProperty("Collected Point")] public string Collected_point { get; set; }
        [JsonProperty("First Name")] public string Firstname { get; set; }
        [JsonProperty("Middle Name")] public string Middlename { get; set; }
        [JsonProperty("Family Name")] public string Familyname { get; set; }
        [JsonProperty("DOB")] public string dob { get; set; }
        public string Country { get; set; }
        public string Ethnicity { get; set; }
        [JsonProperty("Gender")] public string sex_mat { get; set; }
        [JsonProperty("Marital Status")] public string MaritalStatus { get; set; }
        [JsonProperty("Marriage Con")] public string marriage_con { get; set; }
        [JsonProperty("No.of Wives")] public string Numberofwives { get; set; }
        [JsonProperty("No. of Children")] public string Numberofchildren { get; set; }
        [JsonProperty("Health Card No.")] public string Healthcardnumber { get; set; }
        [JsonProperty("Health Centre")] public string healthcentre { get; set; }
        [JsonProperty("Place of Birth")] public string Placeofbirth { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string home { get; set; }
        public string work { get; set; }
         public string mobile { get; set; }
        public string comments { get; set; }
        [JsonProperty("Body Weight")] public string BodyWeight { get; set; }
        public string Height { get; set; }
        [JsonProperty("Body Mass")] public string BodyMass { get; set; }
         public string Waist { get; set; }
        [JsonProperty("Blood Pressure Systolic")] public string BloodPressureSystolic { get; set; }
        [JsonProperty("Blood Pressure Diastolic")] public string BloodPressureDiastolic { get; set; }
        [JsonProperty("Clinical Hypertension")] public string clinical_hypertension { get; set; }
        [JsonProperty("Diabetes Mellitus")] public string diabetesMellitus { get; set; }
        public string Diabetic { get; set; }
        public string Age { get; set; }
        public string Dyslipidemia { get; set; }
        [JsonProperty("Diabetic Other")] public string diabetic_other { get; set; }
        [JsonProperty("Diabetes Com")] public string diabetes_com { get; set; }
        [JsonProperty("Diabetes Com Specify")] public string diabetes_com_specify { get; set; }
        [JsonProperty("Spec App Retinopathy")] public string spec_app_retinopathy { get; set; }
        [JsonProperty("Spec App Neuropathy")] public string spec_app_neuropathy { get; set; }
        [JsonProperty("Neuropathy Other")] public string neuropathy_other { get; set; }
        [JsonProperty("Spec App CVA")] public string spec_app_cva { get; set; }
        [JsonProperty("Spec App Nephropathy")] public string spec_app_nephropathy { get; set; }
        [JsonProperty("Nephropathy Albuminuria Others")] public string nephropathy_albuminuria_others { get; set; }
        [JsonProperty("Nephropathy eGFR Others")] public string nephropathy_eGFR_others { get; set; }
        [JsonProperty("Spec App Cad")] public string spec_app_cad { get; set; }
        [JsonProperty("Diabetes Comp Other Check")] public string diabetes_comp_other_check { get; set; }
        [JsonProperty("Diabetes Comp Others Text")] public string diabetes_comp_others_text { get; set; }
        [JsonProperty("Diabetes Man None")] public string diabetes_man_none { get; set; }
        [JsonProperty("Diabetes Man Tabletsonly")] public string diabetes_man_tabletsonly { get; set; }
        [JsonProperty("Diabetes Man Diettablets")] public string diabetes_man_diettablets { get; set; }
        [JsonProperty("Diabetes Man Diettabletsinsulin")] public string diabetes_man_diettabletsinsulin { get; set; }
        [JsonProperty("Diabetes Man Dietonly")] public string diabetes_man_dietonly { get; set; }
        [JsonProperty("Diabetes Man Insulinonly")] public string diabetes_man_insulinonly { get; set; }
        [JsonProperty("Diabetes Man Dietinsulin")] public string diabetes_man_dietinsulin { get; set; }
        [JsonProperty("Diabetes Man Unknown")] public string diabetes_man_unknown { get; set; }
        [JsonProperty("Current Diabetes Man Other")] public string current_diabetes_man_other { get; set; }
        [JsonProperty("Current Diabetes Man Other Text")] public string current_diabetes_man_other_text { get; set; }
        [JsonProperty("Bloodcollecteddate")] public string bloodCollectedDate { get; set; }
        [JsonProperty("Recentresult")] public string recentresult { get; set; }
        [JsonProperty("Glucose Collected Date")] public string glucose_collected_date { get; set; }
        [JsonProperty("Glucose Recentresult")] public string glucose_recentresult { get; set; }
        [JsonProperty("Glucose Tolerance Collected Date")] public string glucose_tolerance_collected_date { get; set; }
        [JsonProperty("Glucose Tolerance Recent Result")] public string glucose_tolerance_recent_result { get; set; }
        [JsonProperty("Hba1C")] public string hba1c { get; set; }
        [JsonProperty("Hba1C Recentresult")] public string hba1c_RecentResult { get; set; }
        [JsonProperty("Cholesterol Collecteddate")] public string cholesterol_CollectedDate { get; set; }
        [JsonProperty("Cholesterol Recentresult")] public string cholesterol_RecentResult { get; set; }
        [JsonProperty("Triglyceride Collecteddate")] public string Triglyceride_CollectedDate { get; set; }
        [JsonProperty("Triglyceride Recentresult")] public string Triglyceride_RecentResult { get; set; }
        [JsonProperty("Hdl Collecteddate")] public string HDL_CollectedDate { get; set; }
        [JsonProperty("Hdl Recentresult")] public string HDL_RecentResult { get; set; }
        [JsonProperty("Ldl Collecteddate")] public string LDL_CollectedDate { get; set; }
        [JsonProperty("Ldl Recentresult")] public string LDL_RecentResult { get; set; }
        [JsonProperty("Microalbumin Collected date")] public string Microalbumin_CollectedDate { get; set; }
        [JsonProperty("Microalbumin Recent result")] public string Microalbumin_RecentResult { get; set; }
        [JsonProperty("Creatinine Collected date")] public string Creatinine_CollectedDate { get; set; }
        [JsonProperty("Creatinine Recent result")] public string Creatinine_RecentResult { get; set; }
        [JsonProperty("Urea Collecteddate")] public string Urea_CollectedDate { get; set; }
        [JsonProperty("Urea Recentresult")] public string Urea_RecentResult { get; set; }
        [JsonProperty("Vitamind Collected date")] public string VitaminD_CollectedDate { get; set; }
        [JsonProperty("Vitamind Recent result")] public string VitaminD_RecentResult { get; set; }
        [JsonProperty("Egfr Collected date")] public string eGFR_CollectedDate { get; set; }
        [JsonProperty("Egfr Recentresult")] public string eGFR_RecentResult { get; set; }
        [JsonProperty("Lifestyle Walk")] public string lifestyle_walk { get; set; }
        [JsonProperty("Lifestyle Walk Specify")] public string lifestyle_walk_specify { get; set; }
        [JsonProperty("Lifestyle Exercise")] public string lifestyle_exercise { get; set; }
        [JsonProperty("Intensity")] public string intensity { get; set; }
        [JsonProperty("Healthy")] public string healthy { get; set; }
        [JsonProperty("Specifyhealthy")] public string SpecifyHealthy { get; set; }
        [JsonProperty("Currentsmoke")] public string currentSmoke { get; set; }
        [JsonProperty("Medications Allergies")] public string medications_allergies { get; set; }
        [JsonProperty("Medications Allergies Specify")] public string medications_allergies_specify { get; set; }
        [JsonProperty("Medication Intolerance")] public string medication_intolerance { get; set; }
        [JsonProperty("Medication Intolerance Specify")] public string medication_intolerance_specify { get; set; }
        [JsonProperty("Medication Medication")] public string medication_medication { get; set; }
        [JsonProperty("Medication Medication Specify")] public string medication_medication_specify { get; set; }
        [JsonProperty("Inhibit Ace")] public string inhibit_ace { get; set; }
        [JsonProperty("Perindop")] public string perindop { get; set; }
        [JsonProperty("Captopril")] public string captopril { get; set; }
        [JsonProperty("Enalapril")] public string enalapril { get; set; }
        [JsonProperty("Lisinop")] public string lisinop { get; set; }
        [JsonProperty("Medications Others")] public string medications_others { get; set; }
        [JsonProperty("Inhibit Arbs")] public string inhibit_arbs { get; set; }
        [JsonProperty("Losartan")] public string losartan { get; set; }
        [JsonProperty("Valsartan")] public string Valsartan { get; set; }
        [JsonProperty("Anti Dose")] public string anti_dose { get; set; }
        [JsonProperty("Inhibit Beta")] public string inhibit_beta { get; set; }
        [JsonProperty("Atenolol")] public string atenolol { get; set; }
        [JsonProperty("Bisopr")] public string bisopr { get; set; }
        [JsonProperty("Beta Dose")] public string beta_dose { get; set; }
        [JsonProperty("Inhibit Diuret")] public string inhibit_diuret { get; set; }
        [JsonProperty("Indapam")] public string indapam { get; set; }
        [JsonProperty("Hydroch")] public string hydroch { get; set; }
        [JsonProperty("Fruse")] public string fruse { get; set; }
        [JsonProperty("Diur Others")] public string diur_others { get; set; }
        [JsonProperty("Inhibit Channel")] public string inhibit_channel { get; set; }
        [JsonProperty("Amlodip")] public string amlodip { get; set; }
        [JsonProperty("Nifedip")] public string nifedip { get; set; }
        [JsonProperty("Verapamil")] public string verapamil { get; set; }
        [JsonProperty("Diur Inhibit Others")] public string diur_inhibit_others { get; set; }
        [JsonProperty("Others Oh")] public string others_oh { get; set; }
        [JsonProperty("Methyldop")] public string methyldop { get; set; }
        [JsonProperty("Otr Dose")] public string otr_dose { get; set; }
        [JsonProperty("Antiradio Statinsan")] public string AntiRadio_statinsan { get; set; }
        [JsonProperty("Simvast")] public string simvast { get; set; }
        [JsonProperty("Atorvast")] public string atorvast { get; set; }
        [JsonProperty("Rosuvas")] public string rosuvas { get; set; }
        [JsonProperty("Otherd")] public string OtherD { get; set; }
        [JsonProperty("Antiradio Fibrates")] public string AntiRadio_Fibrates { get; set; }
        [JsonProperty("Gemfib")] public string gemfib { get; set; }
        [JsonProperty("Fenofib")] public string fenofib { get; set; }
        [JsonProperty("Fibrat1")] public string fibrat1 { get; set; }
        [JsonProperty("Fibrat2")] public string fibrat2 { get; set; }
        [JsonProperty("Antiradio Others")] public string AntiRadio_others { get; set; }
        [JsonProperty("Antiothers")] public string AntiOthers { get; set; }
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
        [JsonProperty("Anti Hyper Pioglit")] public string anti_hyper_pioglit { get; set; }
        [JsonProperty("Antiother")] public string AntiOther { get; set; }
        [JsonProperty("Anti Hyper Meglitin")] public string anti_hyper_meglitin { get; set; }
        [JsonProperty("Anti Hyper Nateglinide")] public string anti_hyper_nateglinide { get; set; }
        [JsonProperty("Anti Hyper Nateglinide Repaglinide")] public string anti_hyper_nateglinide_repaglinide { get; set; }
        [JsonProperty("Anti Hyper Glucosid")] public string anti_hyper_glucosid { get; set; }
        [JsonProperty("Acarbose")] public string acarbose { get; set; }
        [JsonProperty("Anti Hyper Dipeptidyl")] public string anti_hyper_dipeptidyl { get; set; }
        [JsonProperty("Sitaglip")] public string sitaglip { get; set; }
        [JsonProperty("Vildaglip")] public string vildaglip { get; set; }
        [JsonProperty("Saxaglip")] public string saxaglip { get; set; }
        [JsonProperty("Linaglip")] public string linaglip { get; set; }
        [JsonProperty("Anti Hyper Peptid Others")] public string anti_hyper_peptid_others { get; set; }
        [JsonProperty("Pramlintide")] public string pramlintide { get; set; }
        [JsonProperty("Other Inhibit")] public string other_inhibit { get; set; }
        [JsonProperty("Anti Hyper Incretinm")] public string anti_hyper_incretinm { get; set; }
        [JsonProperty("Exenatide")] public string exenatide { get; set; }
        [JsonProperty("Liraglut")] public string liraglut { get; set; }
        [JsonProperty("Exenatide Dose")] public string exenatide_dose { get; set; }
        [JsonProperty("Anti Hyper Insulin Lin")] public string anti_hyper_insulin_lin { get; set; }
        [JsonProperty("Lispro Dose")] public string lispro_dose { get; set; }
        [JsonProperty("Aspart Dose")] public string aspart_dose { get; set; }
        [JsonProperty("Regular Dose")] public string regular_dose { get; set; }
        [JsonProperty("Nph Dose")] public string nph_dose { get; set; }
        [JsonProperty("Detemir Dose")] public string Detemir_Dose { get; set; }
        [JsonProperty("Glargine")] public string glargine { get; set; }
        [JsonProperty("Insulin Lin Other Su")] public string insulin_lin_other_su { get; set; }
        [JsonProperty("Combination")] public string combination { get; set; }
        [JsonProperty("Combination Other Su")] public string combination_other_su { get; set; }
        [JsonProperty("Anti Hyper Vitamin")] public string anti_hyper_vitamin { get; set; }
        [JsonProperty("Othervit")] public string OtherVit { get; set; }
        [JsonProperty("Anti Hyper Prozac")] public string anti_hyper_prozac { get; set; }
        [JsonProperty("Otherspro")] public string OthersPro { get; set; }
        [JsonProperty("Anti Hyper Diazepam")] public string anti_hyper_diazepam { get; set; }
        [JsonProperty("Othersdia")] public string OthersDia { get; set; }
        [JsonProperty("Chin Specify")] public string chin_specify { get; set; }
        [JsonProperty("Diabetes")] public string diabetes { get; set; }
        [JsonProperty("Diabetesc")] public string diabetesc { get; set; }
        [JsonProperty("Obesity")] public string obesity { get; set; }
        [JsonProperty("Hypertension")] public string hypertension { get; set; }
        [JsonProperty("Cvd")] public string cvd { get; set; }
        [JsonProperty("Dyslipidaemia")] public string dyslipidaemia { get; set; }
        [JsonProperty("Familyothers")] public string familyothers { get; set; }
        [JsonProperty("Grandfa Maside No")] public string grandfa_maside_no { get; set; }
        [JsonProperty("Grandfa Maside Dec")] public string grandfa_maside_dec { get; set; }
        [JsonProperty("Grandfa Maside Notaff")] public string grandfa_maside_notaff { get; set; }
        [JsonProperty("Grandfa Maside Aff")] public string grandfa_maside_aff { get; set; }
        [JsonProperty("Grandfa Maside Notsur")] public string grandfa_maside_notsur { get; set; }
        [JsonProperty("Grandma Maside No")] public string grandma_maside_no { get; set; }
        [JsonProperty("Grandma Maside Dec")] public string grandma_maside_dec { get; set; }
        [JsonProperty("Grandma Maside Notaff")] public string grandma_maside_notaff { get; set; }
        [JsonProperty("Grandma Maside Aff")] public string grandma_maside_aff { get; set; }
        [JsonProperty("Grandma Maside Notsur")] public string grandma_maside_notsur { get; set; }
        [JsonProperty("Grandfa Faside No")] public string grandfa_faside_no { get; set; }
        [JsonProperty("Grandfa Faside Dec")] public string grandfa_faside_dec { get; set; }
        [JsonProperty("Grandfa Faside Notaff")] public string grandfa_faside_notaff { get; set; }
        [JsonProperty("Grandfa Faside Aff")] public string grandfa_faside_aff { get; set; }
        [JsonProperty("Grandfa Faside Notsur")] public string grandfa_faside_notsur { get; set; }
        [JsonProperty("Grandma Faside No")] public string grandma_faside_no { get; set; }
        [JsonProperty("Grandma Faside Dec")] public string grandma_faside_dec { get; set; }
        [JsonProperty("Grandma Faside Notaff")] public string grandma_faside_notaff { get; set; }
        [JsonProperty("Grandma Faside Aff")] public string grandma_faside_aff { get; set; }
        [JsonProperty("Grandma Faside Notsur")] public string grandma_faside_notsur { get; set; }
        [JsonProperty("Ma No")] public string ma_no { get; set; }
        [JsonProperty("Ma Dec")] public string ma_dec { get; set; }
        [JsonProperty("Ma Notaff")] public string ma_notaff { get; set; }
        [JsonProperty("Ma Aff")] public string ma_aff { get; set; }
        [JsonProperty("Ma Notsur")] public string ma_notsur { get; set; }
        [JsonProperty("Fa No")] public string fa_no { get; set; }
        [JsonProperty("Fa Dec")] public string fa_dec { get; set; }
        [JsonProperty("Fa Notaff")] public string fa_notaff { get; set; }
        [JsonProperty("Fa Aff")] public string fa_aff { get; set; }
        [JsonProperty("Fa Notsur")] public string fa_notsur { get; set; }
        [JsonProperty("Sister No")] public string sister_no { get; set; }
        [JsonProperty("Sister Dec")] public string sister_dec { get; set; }
        [JsonProperty("Sister Notaff")] public string sister_notaff { get; set; }
        [JsonProperty("Sister Aff")] public string sister_aff { get; set; }
        [JsonProperty("Sister Notsur")] public string sister_notsur { get; set; }
        [JsonProperty("Brother No")] public string brother_no { get; set; }
        [JsonProperty("Brother Dec")] public string brother_dec { get; set; }
        [JsonProperty("Brother Notaff")] public string brother_notaff { get; set; }
        [JsonProperty("Brother Aff")] public string brother_aff { get; set; }
        [JsonProperty("Brother Notsur")] public string brother_notsur { get; set; }
        [JsonProperty("Wives No")] public string wives_no { get; set; }
        [JsonProperty("Wives Dec")] public string wives_dec { get; set; }
        [JsonProperty("Wives Notaff")] public string wives_notaff { get; set; }
        [JsonProperty("Wives Aff")] public string wives_aff { get; set; }
        [JsonProperty("Wives Notsur")] public string wives_notsur { get; set; }
        [JsonProperty("Husband No")] public string husband_no { get; set; }
        [JsonProperty("Husband Dec")] public string husband_dec { get; set; }
        [JsonProperty("Husband Notaff")] public string husband_notaff { get; set; }
        [JsonProperty("Husband Aff")] public string husband_aff { get; set; }
        [JsonProperty("Husband Notsur")] public string husband_notsur { get; set; }
        [JsonProperty("Son No")] public string son_no { get; set; }
        [JsonProperty("Son Dec")] public string son_dec { get; set; }
        [JsonProperty("Son Notaff")] public string son_notaff { get; set; }
        [JsonProperty("Son Aff")] public string son_aff { get; set; }
        [JsonProperty("Son Notsur")] public string son_notsur { get; set; }
        [JsonProperty("Daughters No")] public string daughters_no { get; set; }
        [JsonProperty("Daughters Dec")] public string daughters_dec { get; set; }
        [JsonProperty("Daughters Notaff")] public string daughters_notaff { get; set; }
        [JsonProperty("Daughters Aff")] public string daughters_aff { get; set; }
        [JsonProperty("Daughters Notsur")] public string daughters_notsur { get; set; }
        [JsonProperty("Grandsons No")] public string grandsons_no { get; set; }
        [JsonProperty("Grandsons Dec")] public string grandsons_dec { get; set; }
        [JsonProperty("Grandsons Notaff")] public string grandsons_notaff { get; set; }
        [JsonProperty("Grandsons Aff")] public string grandsons_aff { get; set; }
        [JsonProperty("Grandsons Notsur")] public string grandsons_notsur { get; set; }
        [JsonProperty("Grand Daughters No")] public string grand_daughters_no { get; set; }
        [JsonProperty("Grand Daughters Dec")] public string grand_daughters_dec { get; set; }
        [JsonProperty("Grand Daughters Notaff")] public string grand_daughters_notaff { get; set; }
        [JsonProperty("Grand Daughters Aff")] public string grand_daughters_aff { get; set; }
        [JsonProperty("Grand Daughters Notsur")] public string grand_daughters_notsur { get; set; }
        [JsonProperty("Uncles Maside No")] public string uncles_maside_no { get; set; }
        [JsonProperty("Uncles Maside Dec")] public string uncles_maside_dec { get; set; }
        [JsonProperty("Uncles Maside Notaff")] public string uncles_maside_notaff { get; set; }
        [JsonProperty("Uncles Maside Aff")] public string uncles_maside_aff { get; set; }
        [JsonProperty("Uncles Maside Notsur")] public string uncles_maside_notsur { get; set; }
        [JsonProperty("Aunts Maside No")] public string aunts_maside_no { get; set; }
        [JsonProperty("Aunts Maside Dec")] public string aunts_maside_dec { get; set; }
        [JsonProperty("Aunts Maside Notaff")] public string aunts_maside_notaff { get; set; }
        [JsonProperty("Aunts Maside Aff")] public string aunts_maside_aff { get; set; }
        [JsonProperty("Aunts Maside Notsur")] public string aunts_maside_notsur { get; set; }
        [JsonProperty("Uncles Faside No")] public string uncles_faside_no { get; set; }
        [JsonProperty("Uncles Faside Dec")] public string uncles_faside_dec { get; set; }
        [JsonProperty("Uncles Faside Notaff")] public string uncles_faside_notaff { get; set; }
        [JsonProperty("Uncles Faside Aff")] public string uncles_faside_aff { get; set; }
        [JsonProperty("Uncles Faside Notsur")] public string uncles_faside_notsur { get; set; }
        [JsonProperty("Aunts Faside No")] public string aunts_faside_no { get; set; }
        [JsonProperty("Aunts Faside Dec")] public string aunts_faside_dec { get; set; }
        [JsonProperty("Aunts Faside Notaff")] public string aunts_faside_notaff { get; set; }
        [JsonProperty("Aunts Faside Aff")] public string aunts_faside_aff { get; set; }
        [JsonProperty("Aunts Faside Notsur")] public string aunts_faside_notsur { get; set; }
        [JsonProperty("Cousins Maside Aunt No")] public string cousins_maside_aunt_no { get; set; }
        [JsonProperty("Cousins Maside Aunt Dec")] public string cousins_maside_aunt_dec { get; set; }
        [JsonProperty("Cousins Maside Aunt Notaff")] public string cousins_maside_aunt_notaff { get; set; }
        [JsonProperty("Cousins Maside Aunt Aff")] public string cousins_maside_aunt_aff { get; set; }
        [JsonProperty("Cousins Maside Aunt Notsur")] public string cousins_maside_aunt_notsur { get; set; }
        [JsonProperty("Cousins Maside Uncle No")] public string cousins_maside_uncle_no { get; set; }
        [JsonProperty("Cousins Maside Uncle Dec")] public string cousins_maside_uncle_dec { get; set; }
        [JsonProperty("Cousins Maside Uncle Notaff")] public string cousins_maside_uncle_notaff { get; set; }
        [JsonProperty("Cousins Maside Uncle Aff")] public string cousins_maside_uncle_aff { get; set; }
        [JsonProperty("Cousins Maside Uncle Notsur")] public string cousins_maside_uncle_notsur { get; set; }
        [JsonProperty("Cousins Faside Aunt No")] public string cousins_faside_aunt_no { get; set; }
        [JsonProperty("Cousins Faside Aunt Dec")] public string cousins_faside_aunt_dec { get; set; }
        [JsonProperty("Cousins Faside Aunt Notaff")] public string cousins_faside_aunt_notaff { get; set; }
        [JsonProperty("Cousins Faside Aunt Aff")] public string cousins_faside_aunt_aff { get; set; }
        [JsonProperty("Cousins Faside Aunt Notsur")] public string cousins_faside_aunt_notsur { get; set; }
        [JsonProperty("Cousins Faside Uncle No")] public string cousins_faside_uncle_no { get; set; }
        [JsonProperty("Cousins Faside Uncle Dec")] public string cousins_faside_uncle_dec { get; set; }
        [JsonProperty("Cousins Faside Uncle Notaff")] public string cousins_faside_uncle_notaff { get; set; }
        [JsonProperty("Cousins Faside Uncle Aff")] public string cousins_faside_uncle_aff { get; set; }
        [JsonProperty("Cousins Faside Uncle Notsur")] public string cousins_faside_uncle_notsur { get; set; }
        [JsonProperty("Family Pedigree")] public string family_pedigree { get; set; }
        [JsonProperty("Stride Length")] public string stride_length { get; set; }
        [JsonProperty("Stride Velocity")] public string stride_velocity { get; set; }
        [JsonProperty("Plantar Pres")] public string plantar_pres { get; set; }
        [JsonProperty("Metatarsal Specify")] public string Metatarsal_specify { get; set; }
        [JsonProperty("Reas Specify")] public string Reas_specify { get; set; }
        [JsonProperty("Profilepicture")] public string profilePicture { get; set; }
        [JsonProperty("1 Medication Traditional Chinese")] public string medication_traditional_chinese { get; set; }
        [JsonProperty("1 Anti Hyper Nateglinide Others")] public string anti_hyper_nateglinide_others { get; set; }
        [JsonProperty("1 Acarbose Others")] public string acarbose_others { get; set; }
        [JsonProperty("1 Dipeptidyl Others")] public string dipeptidyl_others { get; set; }
        [JsonProperty("1 Others")] public string others { get; set; }
        [JsonProperty("1 Anti Hyper Incretinm Others Dose")] public string anti_hyper_incretinm_others_dose { get; set; }

        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }



    }


}