﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
    //public class QuestionnaireWrap
    //{
    //    public QuestionnaireWrap()
    //    {
    //        result = new List<Questionnaire>();

    //    }
    //    public IEnumerable<Questionnaire> result { get; set; }
    


    //}
    public class Questionnaire
    {

        [Key]
        public string SavedFormID { get; set; }

        public string Depository_ID { get; set; }
        public string Sample { get; set; }
        public string DateAsses { get; set; }
        public string collected_by { get; set; }
        public string Collected_point { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Familyname { get; set; }
        public string dob { get; set; }
        public string country { get; set; }
        public string Ethnicity { get; set; }
        public string sex_mat { get; set; }
        public string MaritalStatus { get; set; }
        public string marriage_con { get; set; }
        public string Numberofwives { get; set; }
        public string Numberofchildren { get; set; }
        public string Healthcardnumber { get; set; }
        public string healthcentre { get; set; }
        public string Placeofbirth { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string home { get; set; }
        public string work { get; set; }
        public string mobile { get; set; }
        public string comments { get; set; }
        public string BodyWeight { get; set; }
        public string Height { get; set; }
        public string BodyMass { get; set; }
        public string Waist { get; set; }
        public string BloodPressureSystolic { get; set; }
        public string BloodPressureDiastolic { get; set; }
        public string clinical_hypertension { get; set; }
        public string diabetesMellitus { get; set; }
        public string diabetic { get; set; }
        public string age { get; set; }
        public string dyslipidemia { get; set; }
        public string diabetic_other { get; set; }
        public string diabetes_com { get; set; }
        public string diabetes_com_specify { get; set; }
        public string spec_app_retinopathy { get; set; }
        public string spec_app_neuropathy { get; set; }
        public string neuropathy_other { get; set; }
        public string spec_app_cva { get; set; }
        public string spec_app_nephropathy { get; set; }
        public string nephropathy_albuminuria_others { get; set; }
        public string nephropathy_eGFR_others { get; set; }
        public string spec_app_cad { get; set; }
        public string diabetes_comp_other_check { get; set; }
        public string diabetes_comp_others_text { get; set; }
        public string diabetes_man_none { get; set; }
        public string diabetes_man_tabletsonly { get; set; }
        public string diabetes_man_diettablets { get; set; }
        public string diabetes_man_diettabletsinsulin { get; set; }
        public string diabetes_man_dietonly { get; set; }
        public string diabetes_man_insulinonly { get; set; }
        public string diabetes_man_dietinsulin { get; set; }
        public string diabetes_man_unknown { get; set; }
        public string current_diabetes_man_other { get; set; }
        public string current_diabetes_man_other_text { get; set; }
        public string bloodCollectedDate { get; set; }
        public string recentresult { get; set; }
        public string glucose_collected_date { get; set; }
        public string glucose_recentresult { get; set; }
        public string glucose_tolerance_collected_date { get; set; }
        public string glucose_tolerance_recent_result { get; set; }
        public string hba1c { get; set; }
        public string hba1c_RecentResult { get; set; }
        public string cholesterol_CollectedDate { get; set; }
        public string cholesterol_RecentResult { get; set; }
        public string Triglyceride_CollectedDate { get; set; }
        public string Triglyceride_RecentResult { get; set; }
        public string HDL_CollectedDate { get; set; }
        public string HDL_RecentResult { get; set; }
        public string LDL_CollectedDate { get; set; }
        public string LDL_RecentResult { get; set; }
        public string Microalbumin_CollectedDate { get; set; }
        public string Microalbumin_RecentResult { get; set; }
        public string Creatinine_CollectedDate { get; set; }
        public string Creatinine_RecentResult { get; set; }
        public string Urea_CollectedDate { get; set; }
        public string Urea_RecentResult { get; set; }
        public string VitaminD_CollectedDate { get; set; }
        public string VitaminD_RecentResult { get; set; }
        public string eGFR_CollectedDate { get; set; }
        public string eGFR_RecentResult { get; set; }
        public string lifestyle_walk { get; set; }
        public string lifestyle_walk_specify { get; set; }
        public string lifestyle_exercise { get; set; }
        public string intensity { get; set; }
        public string healthy { get; set; }
        public string SpecifyHealthy { get; set; }
        public string currentSmoke { get; set; }
        public string medications_allergies { get; set; }
        public string medications_allergies_specify { get; set; }
        public string medication_intolerance { get; set; }
        public string medication_intolerance_specify { get; set; }
        public string medication_medication { get; set; }
        public string medication_medication_specify { get; set; }
        public string inhibit_ace { get; set; }
        public string perindop { get; set; }
        public string captopril { get; set; }
        public string enalapril { get; set; }
        public string lisinop { get; set; }
        public string medications_others { get; set; }
        public string inhibit_arbs { get; set; }
        public string losartan { get; set; }
        public string Valsartan { get; set; }
        public string anti_dose { get; set; }
        public string inhibit_beta { get; set; }
        public string atenolol { get; set; }
        public string bisopr { get; set; }
        public string beta_dose { get; set; }
        public string inhibit_diuret { get; set; }
        public string indapam { get; set; }
        public string hydroch { get; set; }
        public string fruse { get; set; }
        public string diur_others { get; set; }
        public string inhibit_channel { get; set; }
        public string amlodip { get; set; }
        public string nifedip { get; set; }
        public string verapamil { get; set; }
        public string diur_inhibit_others { get; set; }
        public string others_oh { get; set; }
        public string methyldop { get; set; }
        public string otr_dose { get; set; }
        public string AntiRadio_statinsan { get; set; }
        public string simvast { get; set; }
        public string atorvast { get; set; }
        public string rosuvas { get; set; }
        public string OtherD { get; set; }
        public string AntiRadio_Fibrates { get; set; }
        public string gemfib { get; set; }
        public string fenofib { get; set; }
        public string fibrat1 { get; set; }
        public string fibrat2 { get; set; }
        public string AntiRadio_others { get; set; }
        public string AntiOthers { get; set; }
        public string anti_hyper_Biguanides { get; set; }
        public string Metformin { get; set; }
        public string anti_hyper_sus { get; set; }
        public string glibenclamide { get; set; }
        public string glimepir { get; set; }
        public string glipizide { get; set; }
        public string gliclazide_mr { get; set; }
        public string glipizide_dose { get; set; }
        public string pride_dose { get; set; }
        public string anti_hyper_other_su { get; set; }
        public string anti_hyper_thiazolid { get; set; }
        public string anti_hyper_pioglit { get; set; }
        public string AntiOther { get; set; }
        public string anti_hyper_meglitin { get; set; }
        public string anti_hyper_nateglinide { get; set; }
        public string anti_hyper_nateglinide_repaglinide { get; set; }
        public string anti_hyper_glucosid { get; set; }
        public string acarbose { get; set; }
        public string anti_hyper_dipeptidyl { get; set; }
        public string sitaglip { get; set; }
        public string vildaglip { get; set; }
        public string saxaglip { get; set; }
        public string linaglip { get; set; }
        public string anti_hyper_peptid_others { get; set; }
        public string pramlintide { get; set; }
        public string other_inhibit { get; set; }
        public string anti_hyper_incretinm { get; set; }
        public string exenatide { get; set; }
        public string liraglut { get; set; }
        public string exenatide_dose { get; set; }
        public string anti_hyper_insulin_lin { get; set; }
        public string lispro_dose { get; set; }
        public string aspart_dose { get; set; }
        public string regular_dose { get; set; }
        public string nph_dose { get; set; }
        public string Detemir_Dose { get; set; }
        public string glargine { get; set; }
        public string insulin_lin_other_su { get; set; }
        public string combination { get; set; }
        public string combination_other_su { get; set; }
        public string anti_hyper_vitamin { get; set; }
        public string OtherVit { get; set; }
        public string anti_hyper_prozac { get; set; }
        public string OthersPro { get; set; }
        public string anti_hyper_diazepam { get; set; }
        public string OthersDia { get; set; }
        public string chin_specify { get; set; }
        public string diabetes { get; set; }
        public string diabetesc { get; set; }
        public string obesity { get; set; }
        public string hypertension { get; set; }
        public string cvd { get; set; }
        public string dyslipidaemia { get; set; }
        public string familyothers { get; set; }
        public string grandfa_maside_no { get; set; }
        public string grandfa_maside_dec { get; set; }
        public string grandfa_maside_notaff { get; set; }
        public string grandfa_maside_aff { get; set; }
        public string grandfa_maside_notsur { get; set; }
        public string grandma_maside_no { get; set; }
        public string grandma_maside_dec { get; set; }
        public string grandma_maside_notaff { get; set; }
        public string grandma_maside_aff { get; set; }
        public string grandma_maside_notsur { get; set; }
        public string grandfa_faside_no { get; set; }
        public string grandfa_faside_dec { get; set; }
        public string grandfa_faside_notaff { get; set; }
        public string grandfa_faside_aff { get; set; }
        public string grandfa_faside_notsur { get; set; }
        public string grandma_faside_no { get; set; }
        public string grandma_faside_dec { get; set; }
        public string grandma_faside_notaff { get; set; }
        public string grandma_faside_aff { get; set; }
        public string grandma_faside_notsur { get; set; }
        public string ma_no { get; set; }
        public string ma_dec { get; set; }
        public string ma_notaff { get; set; }
        public string ma_aff { get; set; }
        public string ma_notsur { get; set; }
        public string fa_no { get; set; }
        public string fa_dec { get; set; }
        public string fa_notaff { get; set; }
        public string fa_aff { get; set; }
        public string fa_notsur { get; set; }
        public string sister_no { get; set; }
        public string sister_dec { get; set; }
        public string sister_notaff { get; set; }
        public string sister_aff { get; set; }
        public string sister_notsur { get; set; }
        public string brother_no { get; set; }
        public string brother_dec { get; set; }
        public string brother_notaff { get; set; }
        public string brother_aff { get; set; }
        public string brother_notsur { get; set; }
        public string wives_no { get; set; }
        public string wives_dec { get; set; }
        public string wives_notaff { get; set; }
        public string wives_aff { get; set; }
        public string wives_notsur { get; set; }
        public string husband_no { get; set; }
        public string husband_dec { get; set; }
        public string husband_notaff { get; set; }
        public string husband_aff { get; set; }
        public string husband_notsur { get; set; }
        public string son_no { get; set; }
        public string son_dec { get; set; }
        public string son_notaff { get; set; }
        public string son_aff { get; set; }
        public string son_notsur { get; set; }
        public string daughters_no { get; set; }
        public string daughters_dec { get; set; }
        public string daughters_notaff { get; set; }
        public string daughters_aff { get; set; }
        public string daughters_notsur { get; set; }
        public string grandsons_no { get; set; }
        public string grandsons_dec { get; set; }
        public string grandsons_notaff { get; set; }
        public string grandsons_aff { get; set; }
        public string grandsons_notsur { get; set; }
        public string grand_daughters_no { get; set; }
        public string grand_daughters_dec { get; set; }
        public string grand_daughters_notaff { get; set; }
        public string grand_daughters_aff { get; set; }
        public string grand_daughters_notsur { get; set; }
        public string uncles_maside_no { get; set; }
        public string uncles_maside_dec { get; set; }
        public string uncles_maside_notaff { get; set; }
        public string uncles_maside_aff { get; set; }
        public string uncles_maside_notsur { get; set; }
        public string aunts_maside_no { get; set; }
        public string aunts_maside_dec { get; set; }
        public string aunts_maside_notaff { get; set; }
        public string aunts_maside_aff { get; set; }
        public string aunts_maside_notsur { get; set; }
        public string uncles_faside_no { get; set; }
        public string uncles_faside_dec { get; set; }
        public string uncles_faside_notaff { get; set; }
        public string uncles_faside_aff { get; set; }
        public string uncles_faside_notsur { get; set; }
        public string aunts_faside_no { get; set; }
        public string aunts_faside_dec { get; set; }
        public string aunts_faside_notaff { get; set; }
        public string aunts_faside_aff { get; set; }
        public string aunts_faside_notsur { get; set; }
        public string cousins_maside_aunt_no { get; set; }
        public string cousins_maside_aunt_dec { get; set; }
        public string cousins_maside_aunt_notaff { get; set; }
        public string cousins_maside_aunt_aff { get; set; }
        public string cousins_maside_aunt_notsur { get; set; }
        public string cousins_maside_uncle_no { get; set; }
        public string cousins_maside_uncle_dec { get; set; }
        public string cousins_maside_uncle_notaff { get; set; }
        public string cousins_maside_uncle_aff { get; set; }
        public string cousins_maside_uncle_notsur { get; set; }
        public string cousins_faside_aunt_no { get; set; }
        public string cousins_faside_aunt_dec { get; set; }
        public string cousins_faside_aunt_notaff { get; set; }
        public string cousins_faside_aunt_aff { get; set; }
        public string cousins_faside_aunt_notsur { get; set; }
        public string cousins_faside_uncle_no { get; set; }
        public string cousins_faside_uncle_dec { get; set; }
        public string cousins_faside_uncle_notaff { get; set; }
        public string cousins_faside_uncle_aff { get; set; }
        public string cousins_faside_uncle_notsur { get; set; }
        public string family_pedigree { get; set; }
        public string stride_length { get; set; }
        public string stride_velocity { get; set; }
        public string plantar_pres { get; set; }
        public string Metatarsal_specify { get; set; }
        public string Reas_specify { get; set; }
        public string profilePicture { get; set; }
        public string medication_traditional_chinese { get; set; }
        public string anti_hyper_nateglinide_others { get; set; }
        public string acarbose_others { get; set; }
        public string dipeptidyl_others { get; set; }
        public string others { get; set; }
        public string anti_hyper_incretinm_others_dose { get; set; }

    }


}