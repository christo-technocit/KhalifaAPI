
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
    public class Questionnaire1
    {


        [Key]
        public string SavedFormID { get; set; }
        [FromQuery]
        public string Depository_ID { get; set; }

        [FromQuery]
        public  string Sample { get; set; }
       [FromQuery]
        public string DateAsses { get; set; }
       [FromQuery]
        public string collected_by { get; set; }
       [FromQuery]
        public string Collected_point { get; set; }
       [FromQuery]
        public string Firstname { get; set; }
       [FromQuery]
        public string Middlename { get; set; }
       [FromQuery]
        public string Familyname { get; set; }
       [FromQuery]
        public string dob { get; set; }
       [FromQuery]
        public string country { get; set; }
       [FromQuery]
        public string Ethnicity { get; set; }
       [FromQuery]
        public string sex_mat { get; set; }
       [FromQuery]
        public string MaritalStatus { get; set; }
       [FromQuery]
        public string marriage_con { get; set; }
       [FromQuery]
        public string Numberofwives { get; set; }
       [FromQuery]
        public string Numberofchildren { get; set; }
       [FromQuery]
        public string Healthcardnumber { get; set; }
       [FromQuery]
        public string healthcentre { get; set; }
       [FromQuery]
        public string Placeofbirth { get; set; }
       [FromQuery]
        public string Address { get; set; }
       [FromQuery]
        public string Suburb { get; set; }
       [FromQuery]
        public string home { get; set; }
       [FromQuery]
        public string work { get; set; }
       [FromQuery]
        public string mobile { get; set; }
       [FromQuery]
        public string comments { get; set; }
       [FromQuery]
        public string  BodyWeight  { get; set; }
       [FromQuery]
        public string Height { get; set; }
       [FromQuery]
        public string BodyMass { get; set; }
       [FromQuery]
        public string Waist { get; set; }
       [FromQuery]
        public string BloodPressureSystolic { get; set; }
       [FromQuery]
        public string BloodPressureDiastolic { get; set; }
       [FromQuery]
        public string clinical_hypertension { get; set; }
       [FromQuery]
        public string diabetesMellitus { get; set; }
       [FromQuery]
        public string diabetic { get; set; }
       [FromQuery]
        public string age { get; set; }
       [FromQuery]
        public string dyslipidemia { get; set; }
       [FromQuery]
        public string diabetic_other { get; set; }
       [FromQuery]
        public string diabetes_com { get; set; }
       [FromQuery]
        public string diabetes_com_specify { get; set; }
       [FromQuery]
        public string spec_app_retinopathy { get; set; }
       [FromQuery]
        public string spec_app_neuropathy { get; set; }
       [FromQuery]
        public string neuropathy_other { get; set; }
       [FromQuery]
        public string spec_app_cva { get; set; }
       [FromQuery]
        public string spec_app_nephropathy { get; set; }
       [FromQuery]
        public string nephropathy_albuminuria_others { get; set; }
       [FromQuery]
        public string nephropathy_eGFR_others { get; set; }
       [FromQuery]
        public string spec_app_cad { get; set; }
       [FromQuery]
        public string diabetes_comp_other_check { get; set; }
       [FromQuery]
        public string diabetes_comp_others_text { get; set; }
       [FromQuery]
        public string diabetes_man_none { get; set; }
       [FromQuery]
        public string diabetes_man_tabletsonly { get; set; }
       [FromQuery]
        public string diabetes_man_diettablets { get; set; }
       [FromQuery]
        public string diabetes_man_diettabletsinsulin { get; set; }
       [FromQuery]
        public string diabetes_man_dietonly { get; set; }
       [FromQuery]
        public string diabetes_man_insulinonly { get; set; }
       [FromQuery]
        public string diabetes_man_dietinsulin { get; set; }

       [FromQuery]
        public string diabetes_man_unknown { get; set; }
       [FromQuery]
        public string current_diabetes_man_other { get; set; }
       [FromQuery]
        public string current_diabetes_man_other_text { get; set; }
       [FromQuery]
        public string bloodCollectedDate { get; set; }
       [FromQuery]
        public string recentresult { get; set; }
       [FromQuery]
        public string glucose_collected_date { get; set; }
       [FromQuery]
        public string glucose_recentresult { get; set; }
       [FromQuery]
        public string glucose_tolerance_collected_date { get; set; }
       [FromQuery]
        public string glucose_tolerance_recent_result { get; set; }
       [FromQuery]
        public string hba1c { get; set; }
       [FromQuery]
        public string hba1c_RecentResult { get; set; }
       [FromQuery]
        public string cholesterol_CollectedDate { get; set; }
       [FromQuery]
        public string cholesterol_RecentResult { get; set; }
       [FromQuery]
        public string Triglyceride_CollectedDate { get; set; }
       [FromQuery]
        public string Triglyceride_RecentResult { get; set; }
       [FromQuery]
        public string HDL_CollectedDate { get; set; }
       [FromQuery]
        public string HDL_RecentResult { get; set; }
       [FromQuery]
        public string LDL_CollectedDate { get; set; }
       [FromQuery]
        public string LDL_RecentResult { get; set; }
       [FromQuery]
        public string Microalbumin_CollectedDate { get; set; }
       [FromQuery]
        public string Microalbumin_RecentResult { get; set; }
       [FromQuery]
        public string Creatinine_CollectedDate { get; set; }
       [FromQuery]
        public string Creatinine_RecentResult { get; set; }
       [FromQuery]
        public string Urea_CollectedDate { get; set; }
       [FromQuery]
        public string Urea_RecentResult { get; set; }
       [FromQuery]
        public string VitaminD_CollectedDate { get; set; }
       [FromQuery]
        public string VitaminD_RecentResult { get; set; }
       [FromQuery]
        public string eGFR_CollectedDate { get; set; }
       [FromQuery]
        public string eGFR_RecentResult { get; set; }
       [FromQuery]
        public string lifestyle_walk { get; set; }
       [FromQuery]
        public string lifestyle_walk_specify { get; set; }
       [FromQuery]
        public string lifestyle_exercise { get; set; }
       [FromQuery]
        public string intensity { get; set; }
       [FromQuery]
        public string healthy { get; set; }
       [FromQuery]
        public string SpecifyHealthy { get; set; }
       [FromQuery]
        public string currentSmoke { get; set; }
       [FromQuery]
        public string medications_allergies { get; set; }
       [FromQuery]
        public string medications_allergies_specify { get; set; }
       [FromQuery]
        public string medication_intolerance { get; set; }
       [FromQuery]
        public string medication_intolerance_specify { get; set; }
       [FromQuery]
        public string medication_medication { get; set; }
       [FromQuery]
        public string medication_medication_specify { get; set; }
       [FromQuery]
        public string inhibit_ace { get; set; }
       [FromQuery]
        public string perindop { get; set; }
       [FromQuery]
        public string captopril { get; set; }
       [FromQuery]
        public string enalapril { get; set; }
       [FromQuery]
        public string lisinop { get; set; }
       [FromQuery]
        public string medications_others { get; set; }
       [FromQuery]
        public string inhibit_arbs { get; set; }
       [FromQuery]
        public string losartan { get; set; }
       [FromQuery]
        public string Valsartan { get; set; }
       [FromQuery]
        public string anti_dose { get; set; }
       [FromQuery]
        public string inhibit_beta { get; set; }
       [FromQuery]
        public string atenolol { get; set; }
       [FromQuery]
        public string bisopr { get; set; }
       [FromQuery]
        public string beta_dose { get; set; }
       [FromQuery]
        public string inhibit_diuret { get; set; }
       [FromQuery]
        public string indapam { get; set; }
       [FromQuery]
        public string hydroch { get; set; }
       [FromQuery]
        public string fruse { get; set; }
       [FromQuery]
        public string diur_others { get; set; }
       [FromQuery]
        public string inhibit_channel { get; set; }
       [FromQuery]
        public string amlodip { get; set; }
       [FromQuery]
        public string nifedip { get; set; }
       [FromQuery]
        public string verapamil { get; set; }
       [FromQuery]
        public string diur_inhibit_others { get; set; }
       [FromQuery]
        public string others_oh { get; set; }
       [FromQuery]
        public string methyldop { get; set; }
       [FromQuery]
        public string otr_dose { get; set; }
       [FromQuery]
        public string AntiRadio_statinsan { get; set; }
       [FromQuery]
        public string simvast { get; set; }
       [FromQuery]
        public string atorvast { get; set; }
       [FromQuery]
        public string rosuvas { get; set; }
       [FromQuery]
        public string OtherD { get; set; }
       [FromQuery]
        public string AntiRadio_Fibrates { get; set; }
       [FromQuery]
        public string gemfib { get; set; }
       [FromQuery]
        public string fenofib { get; set; }
       [FromQuery]
        public string fibrat1 { get; set; }
       [FromQuery]

        public string fibrat2 { get; set; }
       [FromQuery]
        public string AntiRadio_others { get; set; }
       [FromQuery]
        public string AntiOthers { get; set; }
       [FromQuery]
        public string anti_hyper_Biguanides { get; set; }
       [FromQuery]
        public string Metformin { get; set; }
       [FromQuery]
        public string anti_hyper_sus { get; set; }
       [FromQuery]
        public string glibenclamide { get; set; }
       [FromQuery]
        public string glimepir { get; set; }
       [FromQuery]
        public string glipizide { get; set; }
       [FromQuery]
        public string gliclazide_mr { get; set; }
       [FromQuery]
        public string glipizide_dose { get; set; }
       [FromQuery]
        public string pride_dose { get; set; }
       [FromQuery]
        public string anti_hyper_other_su { get; set; }
       [FromQuery]
        public string anti_hyper_thiazolid { get; set; }
       [FromQuery]
        public string anti_hyper_pioglit { get; set; }
       [FromQuery]
        public string AntiOther { get; set; }
       [FromQuery]
        public string anti_hyper_meglitin { get; set; }
       [FromQuery]
        public string anti_hyper_nateglinide { get; set; }
       [FromQuery]
        public string anti_hyper_nateglinide_repaglinide { get; set; }
       [FromQuery]
        public string anti_hyper_glucosid { get; set; }
       [FromQuery]
        public string acarbose { get; set; }
       [FromQuery]
        public string anti_hyper_dipeptidyl { get; set; }
       [FromQuery]
        public string sitaglip { get; set; }
       [FromQuery]
        public string vildaglip { get; set; }
       [FromQuery]
        public string saxaglip { get; set; }
       [FromQuery]
        public string linaglip { get; set; }
       [FromQuery]
        public string anti_hyper_peptid_others { get; set; }
       [FromQuery]
        public string pramlintide { get; set; }
       [FromQuery]
        public string other_inhibit { get; set; }
       [FromQuery]
        public string anti_hyper_incretinm { get; set; }
       [FromQuery]
        public string exenatide { get; set; }
       [FromQuery]
        public string liraglut { get; set; }
       [FromQuery]
        public string exenatide_dose { get; set; }
       [FromQuery]
        public string anti_hyper_insulin_lin { get; set; }
       [FromQuery]
        public string lispro_dose { get; set; }
       [FromQuery]
        public string aspart_dose { get; set; }
       [FromQuery]
        public string regular_dose { get; set; }
       [FromQuery]
        public string nph_dose { get; set; }
       [FromQuery]
        public string Detemir_Dose { get; set; }
       [FromQuery]
        public string glargine { get; set; }
       [FromQuery]
        public string insulin_lin_other_su { get; set; }
       [FromQuery]
        public string combination { get; set; }
       [FromQuery]
        public string combination_other_su { get; set; }
       [FromQuery]
        public string anti_hyper_vitamin { get; set; }
       [FromQuery]
        public string OtherVit { get; set; }
       [FromQuery]
        public string anti_hyper_prozac { get; set; }
       [FromQuery]
        public string OthersPro { get; set; }
       [FromQuery]
        public string anti_hyper_diazepam { get; set; }
       [FromQuery]
        public string OthersDia { get; set; }
       [FromQuery]
        public string chin_specify { get; set; }
       [FromQuery]
        public string diabetes { get; set; }
       [FromQuery]
        public string diabetesc { get; set; }
       [FromQuery]
        public string obesity { get; set; }
       [FromQuery]
        public string hypertension { get; set; }
       [FromQuery]
        public string cvd { get; set; }
       [FromQuery]
        public string dyslipidaemia { get; set; }
       [FromQuery]
        public string familyothers { get; set; }
       [FromQuery]
        public string grandfa_maside_no { get; set; }
       [FromQuery]
        public string grandfa_maside_dec { get; set; }
       [FromQuery]
        public string grandfa_maside_notaff { get; set; }
       [FromQuery]
        public string grandfa_maside_aff { get; set; }
       [FromQuery]
        public string grandfa_maside_notsur { get; set; }
       [FromQuery]
        public string grandma_maside_no { get; set; }
       [FromQuery]
        public string grandma_maside_dec { get; set; }
       [FromQuery]
        public string grandma_maside_notaff { get; set; }
       [FromQuery]
        public string grandma_maside_aff { get; set; }
       [FromQuery]
        public string grandma_maside_notsur { get; set; }
       [FromQuery]
        public string grandfa_faside_no { get; set; }
       [FromQuery]
        public string grandfa_faside_dec { get; set; }
       [FromQuery]
        public string grandfa_faside_notaff { get; set; }
       [FromQuery]
        public string grandfa_faside_aff { get; set; }
       [FromQuery]
        public string grandfa_faside_notsur { get; set; }
       [FromQuery]
        public string grandma_faside_no { get; set; }
       [FromQuery]
        public string grandma_faside_dec { get; set; }
       [FromQuery]
        public string grandma_faside_notaff { get; set; }
       [FromQuery]
        public string grandma_faside_aff { get; set; }
       [FromQuery]
        public string grandma_faside_notsur { get; set; }
       [FromQuery]
        public string ma_no { get; set; }
       [FromQuery]
        public string ma_dec { get; set; }
       [FromQuery]
        public string ma_notaff { get; set; }
       [FromQuery]
        public string ma_aff { get; set; }
       [FromQuery]
        public string ma_notsur { get; set; }
       [FromQuery]
        public string fa_no { get; set; }
       [FromQuery]
        public string fa_dec { get; set; }
       [FromQuery]
        public string fa_notaff { get; set; }
       [FromQuery]
        public string fa_aff { get; set; }
       [FromQuery]
        public string fa_notsur { get; set; }
       [FromQuery]
        public string sister_no { get; set; }
       [FromQuery]
        public string sister_dec { get; set; }
       [FromQuery]
        public string sister_notaff { get; set; }
       [FromQuery]
        public string sister_aff { get; set; }
       [FromQuery]
        public string sister_notsur { get; set; }
       [FromQuery]
        public string brother_no { get; set; }
       [FromQuery]
        public string brother_dec { get; set; }
       [FromQuery]
        public string brother_notaff { get; set; }
       [FromQuery]
        public string brother_aff { get; set; }
       [FromQuery]
        public string brother_notsur { get; set; }
       [FromQuery]
        public string wives_no { get; set; }
       [FromQuery]
        public string wives_dec { get; set; }
       [FromQuery]
        public string wives_notaff { get; set; }
       [FromQuery]
        public string wives_aff { get; set; }
       [FromQuery]
        public string wives_notsur { get; set; }
       [FromQuery]
        public string husband_no { get; set; }
       [FromQuery]
        public string husband_dec { get; set; }
       [FromQuery]
        public string husband_notaff { get; set; }
       [FromQuery]
        public string husband_aff { get; set; }
       [FromQuery]
        public string husband_notsur { get; set; }
       [FromQuery]
        public string son_no { get; set; }
       [FromQuery]
        public string son_dec { get; set; }
       [FromQuery]
        public string son_notaff { get; set; }
       [FromQuery]
        public string son_aff { get; set; }
       [FromQuery]
        public string son_notsur { get; set; }
       [FromQuery]
        public string daughters_no { get; set; }
       [FromQuery]
        public string daughters_dec { get; set; }
       [FromQuery]
        public string daughters_notaff { get; set; }
       [FromQuery]
        public string daughters_aff { get; set; }
       [FromQuery]
        public string daughters_notsur { get; set; }
       [FromQuery]
        public string grandsons_no { get; set; }
       [FromQuery]
        public string grandsons_dec { get; set; }
       [FromQuery]
        public string grandsons_notaff { get; set; }
       [FromQuery]
        public string grandsons_aff { get; set; }
       [FromQuery]
        public string grandsons_notsur { get; set; }
       [FromQuery]
        public string grand_daughters_no { get; set; }
       [FromQuery]
        public string grand_daughters_dec { get; set; }
       [FromQuery]
        public string grand_daughters_notaff { get; set; }
       [FromQuery]
        public string grand_daughters_aff { get; set; }
       [FromQuery]
        public string grand_daughters_notsur { get; set; }
       [FromQuery]
        public string uncles_maside_no { get; set; }
       [FromQuery]
        public string uncles_maside_dec { get; set; }
       [FromQuery]
        public string uncles_maside_notaff { get; set; }
       [FromQuery]
        public string uncles_maside_aff { get; set; }
       [FromQuery]
        public string uncles_maside_notsur { get; set; }
       [FromQuery]
        public string aunts_maside_no { get; set; }
       [FromQuery]
        public string aunts_maside_dec { get; set; }
       [FromQuery]
        public string aunts_maside_notaff { get; set; }
       [FromQuery]
        public string aunts_maside_aff { get; set; }
       [FromQuery]
        public string aunts_maside_notsur { get; set; }
       [FromQuery]
        public string uncles_faside_no { get; set; }
       [FromQuery]
        public string uncles_faside_dec { get; set; }
       [FromQuery]
        public string uncles_faside_notaff { get; set; }
       [FromQuery]
        public string uncles_faside_aff { get; set; }
       [FromQuery]
        public string uncles_faside_notsur { get; set; }
       [FromQuery]
        public string aunts_faside_no { get; set; }
       [FromQuery]
        public string aunts_faside_dec { get; set; }
       [FromQuery]
        public string aunts_faside_notaff { get; set; }
       [FromQuery]
        public string aunts_faside_aff { get; set; }
       [FromQuery]
        public string aunts_faside_notsur { get; set; }
       [FromQuery]
        public string cousins_maside_aunt_no { get; set; }
       [FromQuery]
        public string cousins_maside_aunt_dec { get; set; }
       [FromQuery]
        public string cousins_maside_aunt_notaff { get; set; }
       [FromQuery]
        public string cousins_maside_aunt_aff { get; set; }
       [FromQuery]
        public string cousins_maside_aunt_notsur { get; set; }
       [FromQuery]
        public string cousins_maside_uncle_no { get; set; }
       [FromQuery]
        public string cousins_maside_uncle_dec { get; set; }
       [FromQuery]
        public string cousins_maside_uncle_notaff { get; set; }
       [FromQuery]
        public string cousins_maside_uncle_aff { get; set; }
       [FromQuery]
        public string cousins_maside_uncle_notsur { get; set; }
       [FromQuery]
        public string cousins_faside_aunt_no { get; set; }
       [FromQuery]
        public string cousins_faside_aunt_dec { get; set; }
       [FromQuery]
        public string cousins_faside_aunt_notaff { get; set; }
       [FromQuery]
        public string cousins_faside_aunt_aff { get; set; }
       [FromQuery]
        public string cousins_faside_aunt_notsur { get; set; }
       [FromQuery]
        public string cousins_faside_uncle_no { get; set; }
       [FromQuery]
        public string cousins_faside_uncle_dec { get; set; }
       [FromQuery]
        public string cousins_faside_uncle_notaff { get; set; }
       [FromQuery]
        public string cousins_faside_uncle_aff { get; set; }
       [FromQuery]
        public string cousins_faside_uncle_notsur { get; set; }
       [FromQuery]
        public string family_pedigree { get; set; }
       [FromQuery]
        public string stride_length { get; set; }
       [FromQuery]
        public string stride_velocity { get; set; }
       [FromQuery]
        public string plantar_pres { get; set; }
       [FromQuery]
        public string Metatarsal_specify { get; set; }
       [FromQuery]
        public string Reas_specify { get; set; }
       [FromQuery]
        public string profilePicture { get; set; }
       [FromQuery]
        public string medication_traditional_chinese { get; set; }
       [FromQuery]
        public string anti_hyper_nateglinide_others { get; set; }
       [FromQuery]
        public string acarbose_others { get; set; }
       [FromQuery]
        public string dipeptidyl_others { get; set; }
       [FromQuery]
        public string others { get; set; }
       [FromQuery]
        public string anti_hyper_incretinm_others_dose { get; set; }

     
    }

    
}