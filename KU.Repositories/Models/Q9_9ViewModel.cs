using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
     public class QuestionnaireWrap9_9
    {
       public QuestionnaireWrap9_9()
        {
           result = new List<Q9_9ViewModel>();

        }
        public IEnumerable<Q9_9ViewModel> result { get; set; }

    }
    public class Q9_9ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("DSM longterm diabetic complications")] public string DSM_longterm_diabetic_complications { get; set; }
        [JsonProperty("DSM longterm diabetic complications year")] public string DSM_longterm_diabetic_complications_year { get; set; }
        [JsonProperty("DSM longterm diabetic complications others")] public string DSM_longterm_diabetic_complications_others { get; set; }
        [JsonProperty("DSM DiabetesTreatment medication")] public string DSM_DiabetesTreatment_medication { get; set; }
        [JsonProperty("DSM DiabetesTreatment 2year dose")] public string DSM_DiabetesTreatment_2year_dose { get; set; }
        [JsonProperty("DSM DiabetesTreatment 3year dose")] public string DSM_DiabetesTreatment_3year_dose { get; set; }
        [JsonProperty("DSM DiabetesTreatment 4year dose")] public string DSM_DiabetesTreatment_4year_dose { get; set; }
        [JsonProperty("DSM DiabetesTreatment 1year dose")] public string DSM_DiabetesTreatment_1year_dose { get; set; }
        [JsonProperty("DSM longterm diabetic complications Kidney")] public string DSM_longterm_diabetic_complications_Kidney { get; set; }
        [JsonProperty("DSM longterm diabetic complications Foot")] public string DSM_longterm_diabetic_complications_Foot { get; set; }
        [JsonProperty("DSM longterm diabetic complication Stroke")] public string DSM_longterm_diabetic_complication_Stroke { get; set; }
        [JsonProperty("DSM longterm diabetic complications Heart")] public string DSM_longterm_diabetic_complications_Heart { get; set; }
        [JsonProperty("DSM longterm diabetic complications Eye")] public string DSM_longterm_diabetic_complications_Eye { get; set; }
        [JsonProperty("DSM longterm diabetic complications other")] public string DSM_longterm_diabetic_complications_other { get; set; }
        [JsonProperty("DSM longterm diabetic complications dontknow")] public string DSM_longterm_diabetic_complications_dontknow { get; set; }
        [JsonProperty("DSM longterm diabetic complications notdisclose")] public string DSM_longterm_diabetic_complications_notdisclose { get; set; }
        [JsonProperty("DSM blood sugar levels with care")] public string DSM_blood_sugar_levels_with_care { get; set; }
        [JsonProperty("DSM achieve optimal blood sugar level")] public string DSM_achieve_optimal_blood_sugar_level { get; set; }
        [JsonProperty("DSM keep doctors appointments")] public string DSM_keep_doctors_appointments { get; set; }
        [JsonProperty("DSM take diabetes medication")] public string DSM_take_diabetes_medication { get; set; }
        [JsonProperty("DSM Occasionally eat sweets")] public string DSM_Occasionally_eat_sweets { get; set; }
        [JsonProperty("DSM record blood sugar")] public string DSM_record_blood_sugar { get; set; }
        [JsonProperty("DSM avoid diabetes related appointments")] public string DSM_avoid_diabetes_related_appointments { get; set; }
        [JsonProperty("DSM physically active")] public string DSM_physically_active { get; set; }
        [JsonProperty("DSM follow dietary recommendations")] public string DSM_follow_dietary_recommendations { get; set; }
        [JsonProperty("DSM do not check blood sugar levels")] public string DSM_do_not_check_blood_sugar_levels { get; set; }
        [JsonProperty("DSM avoid physical activity")] public string DSM_avoid_physical_activity { get; set; }
        [JsonProperty("DSM skip medication")] public string DSM_skip_medication { get; set; }
        [JsonProperty("DSM food binges")] public string DSM_food_binges { get; set; }
        [JsonProperty("DSM morevisit")] public string DSM_morevisit { get; set; }
        [JsonProperty("DSM less physically active")] public string DSM_less_physically_active { get; set; }
        [JsonProperty("DSM self care poor")] public string DSM_self_care_poor { get; set; }
        [JsonProperty("DSM DiabetesTreatment none")] public string DSM_DiabetesTreatment_none { get; set; }
        [JsonProperty("DSM DiabetesTreatment 1name")] public string DSM_DiabetesTreatment_1name { get; set; }
        [JsonProperty("DSM DiabetesTreatment 1year")] public string DSM_DiabetesTreatment_1year { get; set; }
        [JsonProperty("DSM DiabetesTreatment 2name")] public string DSM_DiabetesTreatment_2name { get; set; }
        [JsonProperty("DSM DiabetesTreatment 2year")] public string DSM_DiabetesTreatment_2year { get; set; }
        [JsonProperty("DSM DiabetesTreatment 3name")] public string DSM_DiabetesTreatment_3name { get; set; }
        [JsonProperty("DSM DiabetesTreatment 3year")] public string DSM_DiabetesTreatment_3year { get; set; }
        [JsonProperty("DSM DiabetesTreatment 4name")] public string DSM_DiabetesTreatment_4name { get; set; }
        [JsonProperty("DSM DiabetesTreatment 4year")] public string DSM_DiabetesTreatment_4year { get; set; }
        [JsonProperty("DSM stop medication")] public string DSM_stop_medication { get; set; }
        [JsonProperty("DSM stop medication name")] public string DSM_stop_medication_name { get; set; }
        [JsonProperty("DSM stop medication reason")] public string DSM_stop_medication_reason { get; set; }
        [JsonProperty("DSM stop medication 1name")] public string DSM_stop_medication_1name { get; set; }
        [JsonProperty("DSM stop medication 1reason")] public string DSM_stop_medication_1reason { get; set; }
        [JsonProperty("DSM stop medication 2name")] public string DSM_stop_medication_2name { get; set; }
        [JsonProperty("DSM stop medication 2reason")] public string DSM_stop_medication_2reason { get; set; }
        [JsonProperty("DSM stop medication 3name")] public string DSM_stop_medication_3name { get; set; }
        [JsonProperty("DSM stop medication 3reason")] public string DSM_stop_medication_3reason { get; set; }
        [JsonProperty("DSM stop medication 4name")] public string DSM_stop_medication_4name { get; set; }
        [JsonProperty("DSM stop medication 4reason")] public string DSM_stop_medication_4reason { get; set; }
        [JsonProperty("DSM medication yesterday")] public string DSM_medication_yesterday { get; set; }
        [JsonProperty("DSM prescribed metformin")] public string DSM_prescribed_metformin { get; set; }
        [JsonProperty("DSM take metformin")] public string DSM_take_metformin { get; set; }
        [JsonProperty("DSM take metformin period")] public string DSM_take_metformin_period { get; set; }
        [JsonProperty("DSM take metformin pastweek")] public string DSM_take_metformin_pastweek { get; set; }
        [JsonProperty("DSM take metformin days")] public string DSM_take_metformin_days { get; set; }
        [JsonProperty("DSM take metformin times")] public string DSM_take_metformin_times { get; set; }
        [JsonProperty("DSM take metformin qty")] public string DSM_take_metformin_qty { get; set; }
        [JsonProperty("DSM take metformin missed")] public string DSM_take_metformin_missed { get; set; }
        [JsonProperty("DSM take metformin works")] public string DSM_take_metformin_works { get; set; }
        [JsonProperty("DSM take metformin bothers")] public string DSM_take_metformin_bothers { get; set; }
        [JsonProperty("DSM difficulty hard to remember")] public string DSM_difficulty_hard_to_remember { get; set; }
        [JsonProperty("DSM difficulty hard to pay")] public string DSM_difficulty_hard_to_pay { get; set; }
        [JsonProperty("DSM difficulty hard to refill")] public string DSM_difficulty_hard_to_refill { get; set; }
        [JsonProperty("DSM difficulty unwanted side effect")] public string DSM_difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("DSM difficulty other concern")] public string DSM_difficulty_other_concern { get; set; }
        [JsonProperty("DSM discomfort Nausea")] public string DSM_discomfort_Nausea { get; set; }
        [JsonProperty("DSM discomfort Vomiting")] public string DSM_discomfort_Vomiting { get; set; }
        [JsonProperty("DSM discomfort Diarrhea")] public string DSM_discomfort_Diarrhea { get; set; }
        [JsonProperty("DSM discomfort Abdominal pain")] public string DSM_discomfort_Abdominal_pain { get; set; }
        [JsonProperty("DSM discomfort Bloating")] public string DSM_discomfort_Bloating { get; set; }
        [JsonProperty("DSM discomfort Loss of appetite")] public string DSM_discomfort_Loss_of_appetite { get; set; }
        [JsonProperty("DSM discomfort Loss of appetite specify")] public string DSM_discomfort_Loss_of_appetite_specify { get; set; }
        [JsonProperty("DSM Metformin anorexia")] public string DSM_Metformin_anorexia { get; set; }
        [JsonProperty("DSM 1OAD Name")] public string DSM_1OAD_Name { get; set; }
        [JsonProperty("DSM 1OAD Period")] public string DSM_1OAD_Period { get; set; }
        [JsonProperty("DSM 1OAD take")] public string DSM_1OAD_take { get; set; }
        [JsonProperty("DSM 1OAD days")] public string DSM_1OAD_days { get; set; }
        [JsonProperty("DSM 1OAD times")] public string DSM_1OAD_times { get; set; }
        [JsonProperty("DSM 1OAD qty")] public string DSM_1OAD_qty { get; set; }
        [JsonProperty("DSM 1OAD miss")] public string DSM_1OAD_miss { get; set; }
        [JsonProperty("DSM 1OAD works")] public string DSM_1OAD_works { get; set; }
        [JsonProperty("DSM 1OAD bothers")] public string DSM_1OAD_bothers { get; set; }
        [JsonProperty("DSM 1OAD Difficulty hard to remember")] public string DSM_1OAD_Difficulty_hard_to_remember { get; set; }
        [JsonProperty("DSM 1OAD Difficulty hard to pay")] public string DSM_1OAD_Difficulty_hard_to_pay { get; set; }
        [JsonProperty("DSM 1OAD Difficulty hard to refill")] public string DSM_1OAD_Difficulty_hard_to_refill { get; set; }
        [JsonProperty("DSM 1OAD Difficulty unwanted side effect")] public string DSM_1OAD_Difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("DSM 1OAD Difficulty other concern")] public string DSM_1OAD_Difficulty_other_concern { get; set; }
        [JsonProperty("DSM 2OAD Name")] public string DSM_2OAD_Name { get; set; }
        [JsonProperty("DSM 2OAD Period")] public string DSM_2OAD_Period { get; set; }
        [JsonProperty("DSM 2OAD take")] public string DSM_2OAD_take { get; set; }
        [JsonProperty("DSM 2OAD days")] public string DSM_2OAD_days { get; set; }
        [JsonProperty("DSM 2OAD times")] public string DSM_2OAD_times { get; set; }
        [JsonProperty("DSM 2OAD qty")] public string DSM_2OAD_qty { get; set; }
        [JsonProperty("DSM 2OAD miss")] public string DSM_2OAD_miss { get; set; }
        [JsonProperty("DSM 2OAD works")] public string DSM_2OAD_works { get; set; }
        [JsonProperty("DSM 2OAD bothers")] public string DSM_2OAD_bothers { get; set; }
        [JsonProperty("DSM 2OAD Difficulty hard to remember")] public string DSM_2OAD_Difficulty_hard_to_remember { get; set; }
        [JsonProperty("DSM 2OAD Difficulty hard to pay")] public string DSM_2OAD_Difficulty_hard_to_pay { get; set; }
        [JsonProperty("DSM 2OAD Difficulty hard to refill")] public string DSM_2OAD_Difficulty_hard_to_refill { get; set; }
        [JsonProperty("DSM 2OAD Difficulty unwanted side effect")] public string DSM_2OAD_Difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("DSM 2OAD Difficulty other concern")] public string DSM_2OAD_Difficulty_other_concern { get; set; }
        [JsonProperty("DSM 3OAD Name")] public string DSM_3OAD_Name { get; set; }
        [JsonProperty("DSM 3OAD Period")] public string DSM_3OAD_Period { get; set; }
        [JsonProperty("DSM 3OAD take")] public string DSM_3OAD_take { get; set; }
        [JsonProperty("DSM 3OAD days")] public string DSM_3OAD_days { get; set; }
        [JsonProperty("DSM 3OAD times")] public string DSM_3OAD_times { get; set; }
        [JsonProperty("DSM 3OAD qty")] public string DSM_3OAD_qty { get; set; }
        [JsonProperty("DSM 3OAD miss")] public string DSM_3OAD_miss { get; set; }
        [JsonProperty("DSM 3OAD works")] public string DSM_3OAD_works { get; set; }
        [JsonProperty("DSM 3OAD bothers")] public string DSM_3OAD_bothers { get; set; }
        [JsonProperty("DSM 3OAD Difficulty hard to remember")] public string DSM_3OAD_Difficulty_hard_to_remember { get; set; }
        [JsonProperty("DSM 3OAD Difficulty hard to pay")] public string DSM_3OAD_Difficulty_hard_to_pay { get; set; }
        [JsonProperty("DSM 3OAD Difficulty hard to refill")] public string DSM_3OAD_Difficulty_hard_to_refill { get; set; }
        [JsonProperty("DSM 3OAD Difficulty unwanted side effect")] public string DSM_3OAD_Difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("DSM 3OAD Difficulty other concern")] public string DSM_3OAD_Difficulty_other_concern { get; set; }
        [JsonProperty("physical activity")] public string physical_activity { get; set; }
        [JsonProperty("physical activity specify")] public string physical_activity_specify { get; set; }
        [JsonProperty("physical activity year")] public string physical_activity_year { get; set; }
        [JsonProperty("diet")] public string diet { get; set; }
        [JsonProperty("diet specify")] public string diet_specify { get; set; }
        [JsonProperty("diet specify year")] public string diet_specify_year { get; set; }
        [JsonProperty("diet specify until year")] public string diet_specify_until_year { get; set; }
        [JsonProperty("education")] public string education { get; set; }
        [JsonProperty("education specify")] public string education_specify { get; set; }
        [JsonProperty("education specify year")] public string education_specify_year { get; set; }
        [JsonProperty("education specify date")] public string education_specify_date { get; set; }
        [JsonProperty("metformin")] public string metformin { get; set; }
        [JsonProperty("metformin specify")] public string metformin_specify { get; set; }
        [JsonProperty("metformin year")] public string metformin_year { get; set; }
        [JsonProperty("metformin current dose")] public string metformin_current_dose { get; set; }
        [JsonProperty("antidiabetic")] public string antidiabetic { get; set; }
        [JsonProperty("antidiabetic date")] public string antidiabetic_date { get; set; }
        [JsonProperty("antidiabetic year")] public string antidiabetic_year { get; set; }
        [JsonProperty("antidiabetic current dose")] public string antidiabetic_current_dose { get; set; }
        [JsonProperty("insulin")] public string insulin { get; set; }
        [JsonProperty("insulin specify")] public string insulin_specify { get; set; }
        [JsonProperty("insulin date")] public string insulin_date { get; set; }
        [JsonProperty("insulin year")] public string insulin_year { get; set; }
        [JsonProperty("insulin current dose")] public string insulin_current_dose { get; set; }
        [JsonProperty("others")] public string others { get; set; }
        [JsonProperty("other specify")] public string other_specify { get; set; }
        [JsonProperty("other year")] public string other_year { get; set; }
        [JsonProperty("none")] public string none { get; set; }
        [JsonProperty("other txt")] public string other_txt { get; set; }
        [JsonProperty("DSM absence reason")] public string DSM_absence_reason { get; set; }
        [JsonProperty("DSM absence death date")] public string DSM_absence_death_date { get; set; }
        [JsonProperty("DSM absence death reason")] public string DSM_absence_death_reason { get; set; }
        [JsonProperty("DSM absence other reason")] public string DSM_absence_other_reason { get; set; }
        [JsonProperty("DSM longterm diabetic complications others Specify")] public string DSM_longterm_diabetic_complications_others_Specify { get; set; }
        [JsonProperty("BodyWeight")] public string BodyWeight { get; set; }
        [JsonProperty("PCD BodyWeight")] public string PCD_BodyWeight { get; set; }
        [JsonProperty("PCD Waist")] public string PCD_Waist { get; set; }
        [JsonProperty("PCD BodyMass")] public string PCD_BodyMass { get; set; }
        [JsonProperty("PCD Height")] public string PCD_Height { get; set; }
        [JsonProperty("PCD hip")] public string PCD_hip { get; set; }
        [JsonProperty("PCD neck")] public string PCD_neck { get; set; }
        [JsonProperty("PCD bodyfatper")] public string PCD_bodyfatper { get; set; }
        [JsonProperty("PCD bmi")] public string PCD_bmi { get; set; }
        [JsonProperty("PCD WHR")] public string PCD_WHR { get; set; }
        [JsonProperty("PCD BloodPressure")] public string PCD_BloodPressure { get; set; }
        [JsonProperty("PCD BloodPressureSystolic")] public string PCD_BloodPressureSystolic { get; set; }
        [JsonProperty("PCD BloodPressureDiastolic")] public string PCD_BloodPressureDiastolic { get; set; }
        [JsonProperty("Anti Hypertensive ACE inhibitors")] public string Anti_Hypertensive_ACE_inhibitors { get; set; }
        [JsonProperty("Anti Hypertensive ACE inhibitors Perindopril")] public string Anti_Hypertensive_ACE_inhibitors_Perindopril { get; set; }
        [JsonProperty("Anti Hypertensive ACE inhibitors Captopril")] public string Anti_Hypertensive_ACE_inhibitors_Captopril { get; set; }
        [JsonProperty("Anti Hypertensive ACE inhibitors Enalapril")] public string Anti_Hypertensive_ACE_inhibitors_Enalapril { get; set; }
        [JsonProperty("Anti Hypertensive ACE inhibitors Lisinopril")] public string Anti_Hypertensive_ACE_inhibitors_Lisinopril { get; set; }
        [JsonProperty("Anti Hypertensive ACE inhibitors other")] public string Anti_Hypertensive_ACE_inhibitors_other { get; set; }
        [JsonProperty("Anti Hypertensive ARBs")] public string Anti_Hypertensive_ARBs { get; set; }
        [JsonProperty("Anti Hypertensive ARBs Losartan")] public string Anti_Hypertensive_ARBs_Losartan { get; set; }
        [JsonProperty("Anti Hypertensive ARBs Valsartan")] public string Anti_Hypertensive_ARBs_Valsartan { get; set; }
        [JsonProperty("Anti Hypertensive ARBs other")] public string Anti_Hypertensive_ARBs_other { get; set; }
        [JsonProperty("Anti Hypertensive Beta blockers")] public string Anti_Hypertensive_Beta_blockers { get; set; }
        [JsonProperty("Anti Hypertensive Beta blockers Atenolol")] public string Anti_Hypertensive_Beta_blockers_Atenolol { get; set; }
        [JsonProperty("Anti Hypertensive Beta blockers Bisoprolol")] public string Anti_Hypertensive_Beta_blockers_Bisoprolol { get; set; }
        [JsonProperty("Anti Hypertensive Beta blockers other")] public string Anti_Hypertensive_Beta_blockers_other { get; set; }
        [JsonProperty("Anti Hypertensive Diuretics")] public string Anti_Hypertensive_Diuretics { get; set; }
        [JsonProperty("Anti Hypertensive Diuretics Indapamide")] public string Anti_Hypertensive_Diuretics_Indapamide { get; set; }
        [JsonProperty("Anti Hypertensive Diuretics Hydrochlorothiazide")] public string Anti_Hypertensive_Diuretics_Hydrochlorothiazide { get; set; }
        [JsonProperty("Anti Hypertensive Diuretics Frusemide")] public string Anti_Hypertensive_Diuretics_Frusemide { get; set; }
        [JsonProperty("Anti Hypertensive Diuretics other")] public string Anti_Hypertensive_Diuretics_other { get; set; }
        [JsonProperty("Anti Hypertensive CaChannel Blockers")] public string Anti_Hypertensive_CaChannel_Blockers { get; set; }
        [JsonProperty("Anti Hypertensive CaChannel Blockers Amlodipine")] public string Anti_Hypertensive_CaChannel_Blockers_Amlodipine { get; set; }
        [JsonProperty("Anti Hypertensive CaChannel Blockers Nifedipine")] public string Anti_Hypertensive_CaChannel_Blockers_Nifedipine { get; set; }
        [JsonProperty("Anti Hypertensive CaChannel Blockers Verapamil")] public string Anti_Hypertensive_CaChannel_Blockers_Verapamil { get; set; }
        [JsonProperty("Anti Hypertensive CaChannel Blockers other")] public string Anti_Hypertensive_CaChannel_Blockers_other { get; set; }
        [JsonProperty("Anti Hypertensive other")] public string Anti_Hypertensive_other { get; set; }
        [JsonProperty("Anti Hypertensive other other")] public string Anti_Hypertensive_other_other { get; set; }
        [JsonProperty("Anti Dyslipidemia Statins")] public string Anti_Dyslipidemia_Statins { get; set; }
        [JsonProperty("Anti Dyslipidemia Statins Simvastatin")] public string Anti_Dyslipidemia_Statins_Simvastatin { get; set; }
        [JsonProperty("Anti Dyslipidemia Statins Atorvastatin")] public string Anti_Dyslipidemia_Statins_Atorvastatin { get; set; }
        [JsonProperty("Anti Dyslipidemia Statins Rosuvastatin")] public string Anti_Dyslipidemia_Statins_Rosuvastatin { get; set; }
        [JsonProperty("Anti Dyslipidemia Statins other")] public string Anti_Dyslipidemia_Statins_other { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates")] public string Anti_Dyslipidemia_Fibrates { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates Gemfibrozil")] public string Anti_Dyslipidemia_Fibrates_Gemfibrozil { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates Fenofibrate")] public string Anti_Dyslipidemia_Fibrates_Fenofibrate { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates yes1")] public string Anti_Dyslipidemia_Fibrates_yes1 { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates yes2")] public string Anti_Dyslipidemia_Fibrates_yes2 { get; set; }
        [JsonProperty("Anti Dyslipidemia other")] public string Anti_Dyslipidemia_other { get; set; }
        [JsonProperty("Anti Dyslipidemia other other")] public string Anti_Dyslipidemia_other_other { get; set; }
        [JsonProperty("Oral agents Biguanides")] public string Oral_agents_Biguanides { get; set; }
        [JsonProperty("Oral agents Biguanides Metformin")] public string Oral_agents_Biguanides_Metformin { get; set; }
        [JsonProperty("Oral agents Sulphonyureas")] public string Oral_agents_Sulphonyureas { get; set; }
        [JsonProperty("Oral agents Sulphonyureas Glibenclamide")] public string Oral_agents_Sulphonyureas_Glibenclamide { get; set; }
        [JsonProperty("Oral agents Sulphonyureas Glimepiride")] public string Oral_agents_Sulphonyureas_Glimepiride { get; set; }
        [JsonProperty("Oral agents Sulphonyureas Glipizide")] public string Oral_agents_Sulphonyureas_Glipizide { get; set; }
        [JsonProperty("Oral agents Sulphonyureas GliclazideMR")] public string Oral_agents_Sulphonyureas_GliclazideMR { get; set; }
        [JsonProperty("Oral agents Sulphonyureas Glipizide1")] public string Oral_agents_Sulphonyureas_Glipizide1 { get; set; }
        [JsonProperty("Oral agents Sulphonyureas Glimepride")] public string Oral_agents_Sulphonyureas_Glimepride { get; set; }
        [JsonProperty("Oral agents Sulphonyureas other")] public string Oral_agents_Sulphonyureas_other { get; set; }
        [JsonProperty("Oral agents Thiazolidinediones")] public string Oral_agents_Thiazolidinediones { get; set; }
        [JsonProperty("Oral agents Thiazolidinediones Pioglitazone")] public string Oral_agents_Thiazolidinediones_Pioglitazone { get; set; }
        [JsonProperty("Oral agents Thiazolidinediones other")] public string Oral_agents_Thiazolidinediones_other { get; set; }
        [JsonProperty("Oral agents Meglitinides")] public string Oral_agents_Meglitinides { get; set; }
        [JsonProperty("Oral agents Meglitinides Nateglinide")] public string Oral_agents_Meglitinides_Nateglinide { get; set; }
        [JsonProperty("Oral agents Meglitinides Repaglinide")] public string Oral_agents_Meglitinides_Repaglinide { get; set; }
        [JsonProperty("Oral agents Alpha glucosidase inhibitors")] public string Oral_agents_Alpha_glucosidase_inhibitors { get; set; }
        [JsonProperty("Oral agents Alpha glucosidase inhibitors Acarbose")] public string Oral_agents_Alpha_glucosidase_inhibitors_Acarbose { get; set; }
        [JsonProperty("Oral agents Dipeptidyl")] public string Oral_agents_Dipeptidyl { get; set; }
        [JsonProperty("Oral agents Dipeptidyl Sitagliptin")] public string Oral_agents_Dipeptidyl_Sitagliptin { get; set; }
        [JsonProperty("Oral agents Dipeptidyl Vildagliptin")] public string Oral_agents_Dipeptidyl_Vildagliptin { get; set; }
        [JsonProperty("Oral agents Dipeptidyl Saxagliptin")] public string Oral_agents_Dipeptidyl_Saxagliptin { get; set; }
        [JsonProperty("Oral agents Dipeptidyl Linagliptin")] public string Oral_agents_Dipeptidyl_Linagliptin { get; set; }
        [JsonProperty("Oral agents other")] public string Oral_agents_other { get; set; }
        [JsonProperty("Oral agents other Pramlintide")] public string Oral_agents_other_Pramlintide { get; set; }
        [JsonProperty("Oral agents other other")] public string Oral_agents_other_other { get; set; }
        [JsonProperty("Oral agents Incretin")] public string Oral_agents_Incretin { get; set; }
        [JsonProperty("Oral agents Incretin Exenatide")] public string Oral_agents_Incretin_Exenatide { get; set; }
        [JsonProperty("Oral agents Incretin Liraglutide")] public string Oral_agents_Incretin_Liraglutide { get; set; }
        [JsonProperty("Oral agents Incretin Exenatide weekly")] public string Oral_agents_Incretin_Exenatide_weekly { get; set; }
        [JsonProperty("Injections Insulin")] public string Injections_Insulin { get; set; }
        [JsonProperty("Injections Insulin Lispro")] public string Injections_Insulin_Lispro { get; set; }
        [JsonProperty("Injections Insulin Aspart")] public string Injections_Insulin_Aspart { get; set; }
        [JsonProperty("Injections Insulin Glulisine")] public string Injections_Insulin_Glulisine { get; set; }
        [JsonProperty("Injections Insulin Regular")] public string Injections_Insulin_Regular { get; set; }
        [JsonProperty("Injections Insulin NPH")] public string Injections_Insulin_NPH { get; set; }
        [JsonProperty("Injections Insulin Detemir")] public string Injections_Insulin_Detemir { get; set; }
        [JsonProperty("Injections Insulin Glargine")] public string Injections_Insulin_Glargine { get; set; }
        [JsonProperty("Injections Insulin Combination")] public string Injections_Insulin_Combination { get; set; }
        [JsonProperty("Supplements VitaminD3")] public string Supplements_VitaminD3 { get; set; }
        [JsonProperty("Supplements others")] public string Supplements_others { get; set; }
        [JsonProperty("Antidepressants Prozac")] public string Antidepressants_Prozac { get; set; }
        [JsonProperty("Antidepressants other")] public string Antidepressants_other { get; set; }
        [JsonProperty("Antianxiety Diazepam")] public string Antianxiety_Diazepam { get; set; }
        [JsonProperty("Antianxiety other")] public string Antianxiety_other { get; set; }
        [JsonProperty("othermedication other")] public string othermedication_other { get; set; }
        [JsonProperty("traditional chinese")] public string traditional_chinese { get; set; }
        [JsonProperty("Oral agents Sulphonyuras other")] public string Oral_agents_Sulphonyuras_other { get; set; }
        [JsonProperty("Oral agents Alpha glucosidase inhibitors other")] public string Oral_agents_Alpha_glucosidase_inhibitors_other { get; set; }
        [JsonProperty("Oral agents SGLT2")] public string Oral_agents_SGLT2 { get; set; }
        [JsonProperty("Oral agents Amylin")] public string Oral_agents_Amylin { get; set; }
        [JsonProperty("Supplements Erythropoietin")] public string Supplements_Erythropoietin { get; set; }
        [JsonProperty("Antianxiety Alprazolam")] public string Antianxiety_Alprazolam { get; set; }
        [JsonProperty("othermedication other specify")] public string othermedication_other_specify { get; set; }
        [JsonProperty("traditional chinese specify")] public string traditional_chinese_specify { get; set; }
        [JsonProperty("following medications other")] public string following_medications_other { get; set; }
        [JsonProperty("DT OAD 1")] public string DT_OAD_1 { get; set; }
        [JsonProperty("DT OAD 1 start")] public string DT_OAD_1_start { get; set; }
        [JsonProperty("DT OAD 1 3month")] public string DT_OAD_1_3month { get; set; }
        [JsonProperty("DT OAD 1 6month")] public string DT_OAD_1_6month { get; set; }
        [JsonProperty("DT OAD 1 9month")] public string DT_OAD_1_9month { get; set; }
        [JsonProperty("DT OAD 1 12month")] public string DT_OAD_1_12month { get; set; }
        [JsonProperty("DT OAD 2")] public string DT_OAD_2 { get; set; }
        [JsonProperty("DT OAD 2 start")] public string DT_OAD_2_start { get; set; }
        [JsonProperty("DT OAD 2 3month")] public string DT_OAD_2_3month { get; set; }
        [JsonProperty("DT OAD 2 6month")] public string DT_OAD_2_6month { get; set; }
        [JsonProperty("DT OAD 2 9month")] public string DT_OAD_2_9month { get; set; }
        [JsonProperty("DT OAD 2 12month")] public string DT_OAD_2_12month { get; set; }
        [JsonProperty("DT OAD 3")] public string DT_OAD_3 { get; set; }
        [JsonProperty("DT OAD 3 start")] public string DT_OAD_3_start { get; set; }
        [JsonProperty("DT OAD 3 3month")] public string DT_OAD_3_3month { get; set; }
        [JsonProperty("DT OAD 3 6month")] public string DT_OAD_3_6month { get; set; }
        [JsonProperty("DT OAD 3 9month")] public string DT_OAD_3_9month { get; set; }
        [JsonProperty("DT OAD 3 12month")] public string DT_OAD_3_12month { get; set; }
        [JsonProperty("DT OAD 4")] public string DT_OAD_4 { get; set; }
        [JsonProperty("DT OAD 4 start")] public string DT_OAD_4_start { get; set; }
        [JsonProperty("DT OAD 4 3month")] public string DT_OAD_4_3month { get; set; }
        [JsonProperty("DT OAD 4 6month")] public string DT_OAD_4_6month { get; set; }
        [JsonProperty("DT OAD 4 9month")] public string DT_OAD_4_9month { get; set; }
        [JsonProperty("DT OAD 4 12month")] public string DT_OAD_4_12month { get; set; }
        [JsonProperty("DT OAD side 1")] public string DT_OAD_side_1 { get; set; }
        [JsonProperty("DT OAD side 1 start")] public string DT_OAD_side_1_start { get; set; }
        [JsonProperty("DT OAD side 1 3month")] public string DT_OAD_side_1_3month { get; set; }
        [JsonProperty("DT OAD side 1 6month")] public string DT_OAD_side_1_6month { get; set; }
        [JsonProperty("DT OAD side 1 9month")] public string DT_OAD_side_1_9month { get; set; }
        [JsonProperty("DT OAD side 1 12month")] public string DT_OAD_side_1_12month { get; set; }
        [JsonProperty("DT OAD side 2")] public string DT_OAD_side_2 { get; set; }
        [JsonProperty("DT OAD side 2 start")] public string DT_OAD_side_2_start { get; set; }
        [JsonProperty("DT OAD side 2 3month")] public string DT_OAD_side_2_3month { get; set; }
        [JsonProperty("DT OAD side 2 6month")] public string DT_OAD_side_2_6month { get; set; }
        [JsonProperty("DT OAD side 2 9month")] public string DT_OAD_side_2_9month { get; set; }
        [JsonProperty("DT OAD side 2 12month")] public string DT_OAD_side_2_12month { get; set; }
        [JsonProperty("DT OAD side 3")] public string DT_OAD_side_3 { get; set; }
        [JsonProperty("DT OAD side 3 start")] public string DT_OAD_side_3_start { get; set; }
        [JsonProperty("DT OAD side 3 3month")] public string DT_OAD_side_3_3month { get; set; }
        [JsonProperty("DT OAD side 3 6month")] public string DT_OAD_side_3_6month { get; set; }
        [JsonProperty("DT OAD side 3 9month")] public string DT_OAD_side_3_9month { get; set; }
        [JsonProperty("DT OAD side 3 12month")] public string DT_OAD_side_3_12month { get; set; }
        [JsonProperty("DT OAD side 4")] public string DT_OAD_side_4 { get; set; }
        [JsonProperty("DT OAD side 4 start")] public string DT_OAD_side_4_start { get; set; }
        [JsonProperty("DT OAD side 4 3month")] public string DT_OAD_side_4_3month { get; set; }
        [JsonProperty("DT OAD side 4 6month")] public string DT_OAD_side_4_6month { get; set; }
        [JsonProperty("DT OAD side 4 9month")] public string DT_OAD_side_4_9month { get; set; }
        [JsonProperty("DT OAD side 4 12month")] public string DT_OAD_side_4_12month { get; set; }
        [JsonProperty("DT Metformin Bloating")] public string DT_Metformin_Bloating { get; set; }
        [JsonProperty("DT Metformin Bloating start")] public string DT_Metformin_Bloating_start { get; set; }
        [JsonProperty("DT Metformin Bloating 3month")] public string DT_Metformin_Bloating_3month { get; set; }
        [JsonProperty("DT Metformin Bloating 6month")] public string DT_Metformin_Bloating_6month { get; set; }
        [JsonProperty("DT Metformin Bloating 9month")] public string DT_Metformin_Bloating_9month { get; set; }
        [JsonProperty("DT Metformin Bloating 12month")] public string DT_Metformin_Bloating_12month { get; set; }
        [JsonProperty("DT Metformin Abdominal pain")] public string DT_Metformin_Abdominal_pain { get; set; }
        [JsonProperty("DT Metformin Abdominal pain start")] public string DT_Metformin_Abdominal_pain_start { get; set; }
        [JsonProperty("DT Metformin Abdominal pain 3month")] public string DT_Metformin_Abdominal_pain_3month { get; set; }
        [JsonProperty("DT Metformin Abdominal pain 6month")] public string DT_Metformin_Abdominal_pain_6month { get; set; }
        [JsonProperty("DT Metformin Abdominal pain 9month")] public string DT_Metformin_Abdominal_pain_9month { get; set; }
        [JsonProperty("DT Metformin Abdominal pain 12month")] public string DT_Metformin_Abdominal_pain_12month { get; set; }
        [JsonProperty("DT Metformin Nausea start")] public string DT_Metformin_Nausea_start { get; set; }
        [JsonProperty("DT Metformin Nausea 3month")] public string DT_Metformin_Nausea_3month { get; set; }
        [JsonProperty("DT Metformin Nausea 6month")] public string DT_Metformin_Nausea_6month { get; set; }
        [JsonProperty("DT Metformin Nausea 9month")] public string DT_Metformin_Nausea_9month { get; set; }
        [JsonProperty("DT Metformin Nausea 12month")] public string DT_Metformin_Nausea_12month { get; set; }
        [JsonProperty("DT Metformin Diarrhea")] public string DT_Metformin_Diarrhea { get; set; }
        [JsonProperty("DT Metformin Diarrhea start")] public string DT_Metformin_Diarrhea_start { get; set; }
        [JsonProperty("DT Metformin Diarrhea 3month")] public string DT_Metformin_Diarrhea_3month { get; set; }
        [JsonProperty("DT Metformin Diarrhea 6month")] public string DT_Metformin_Diarrhea_6month { get; set; }
        [JsonProperty("DT Metformin Diarrhea 9month")] public string DT_Metformin_Diarrhea_9month { get; set; }
        [JsonProperty("DT Metformin Diarrhea 12month")] public string DT_Metformin_Diarrhea_12month { get; set; }
        [JsonProperty("DT Metformin Vomiting")] public string DT_Metformin_Vomiting { get; set; }
        [JsonProperty("DT Metformin Vomiting start")] public string DT_Metformin_Vomiting_start { get; set; }
        [JsonProperty("DT Metformin Vomiting 3month")] public string DT_Metformin_Vomiting_3month { get; set; }
        [JsonProperty("DT Metformin Vomiting 6month")] public string DT_Metformin_Vomiting_6month { get; set; }
        [JsonProperty("DT Metformin Vomiting 9month")] public string DT_Metformin_Vomiting_9month { get; set; }
        [JsonProperty("DT Metformin Vomiting 12month")] public string DT_Metformin_Vomiting_12month { get; set; }
        [JsonProperty("DT Metformin Anorexia")] public string DT_Metformin_Anorexia { get; set; }
        [JsonProperty("DT Metformin Anorexia 3month")] public string DT_Metformin_Anorexia_3month { get; set; }
        [JsonProperty("DT Metformin Anorexia start")] public string DT_Metformin_Anorexia_start { get; set; }
        [JsonProperty("DT Metformin Anorexia 6month")] public string DT_Metformin_Anorexia_6month { get; set; }
        [JsonProperty("DT Metformin Anorexia 9month")] public string DT_Metformin_Anorexia_9month { get; set; }
        [JsonProperty("DT Metformin Anorexia 12month")] public string DT_Metformin_Anorexia_12month { get; set; }
        [JsonProperty("DT Metformin Other")] public string DT_Metformin_Other { get; set; }
        [JsonProperty("DT Metformin Other start")] public string DT_Metformin_Other_start { get; set; }
        [JsonProperty("DT Metformin Other 3month")] public string DT_Metformin_Other_3month { get; set; }
        [JsonProperty("DT Metformin Other 6month")] public string DT_Metformin_Other_6month { get; set; }
        [JsonProperty("DT Metformin Other 9month")] public string DT_Metformin_Other_9month { get; set; }
        [JsonProperty("DT Metformin Other 12month")] public string DT_Metformin_Other_12month { get; set; }
        [JsonProperty("DT Comments")] public string DT_Comments { get; set; }
        [JsonProperty("DT Metformin Nausea")] public string DT_Metformin_Nausea { get; set; }
        [JsonProperty("Cognitive test result time")] public string Cognitive_test_result_time { get; set; }
        [JsonProperty("lab blood")] public string lab_blood { get; set; }
        [JsonProperty("lab saliva")] public string lab_saliva { get; set; }
        [JsonProperty("lab tissue")] public string lab_tissue { get; set; }
        [JsonProperty("lab other")] public string lab_other { get; set; }
        [JsonProperty("lab other text")] public string lab_other_text { get; set; }
        [JsonProperty("lab sample date")] public string lab_sample_date { get; set; }
        [JsonProperty("lab storage")] public string lab_storage { get; set; }
        [JsonProperty("lab sample volume")] public string lab_sample_volume { get; set; }
        [JsonProperty("lab project code")] public string lab_project_code { get; set; }
        [JsonProperty("lab test code")] public string lab_test_code { get; set; }
        [JsonProperty("lab comments")] public string lab_comments { get; set; }
        [JsonProperty("LD test code")] public string LD_test_code { get; set; }
        [JsonProperty("LD sample time")] public string LD_sample_time { get; set; }
        [JsonProperty("BIO FastingGlucose before medication")] public string BIO_FastingGlucose_before_medication { get; set; }
        [JsonProperty("BIO FastingGlucose Result after3")] public string BIO_FastingGlucose_Result_after3 { get; set; }
        [JsonProperty("BIO FastingGlucose result after6")] public string BIO_FastingGlucose_result_after6 { get; set; }
        [JsonProperty("BIO FastingGlucose result after9")] public string BIO_FastingGlucose_result_after9 { get; set; }
        [JsonProperty("BIO FastingGlucose result after12")] public string BIO_FastingGlucose_result_after12 { get; set; }
        [JsonProperty("BIO RandomGlucose before medication")] public string BIO_RandomGlucose_before_medication { get; set; }
        [JsonProperty("BIO RandomGlucose result after3")] public string BIO_RandomGlucose_result_after3 { get; set; }
        [JsonProperty("BIO RandomGlucose result after6")] public string BIO_RandomGlucose_result_after6 { get; set; }
        [JsonProperty("BIO RandomGlucose result after9")] public string BIO_RandomGlucose_result_after9 { get; set; }
        [JsonProperty("BIO RandomGlucose result after12")] public string BIO_RandomGlucose_result_after12 { get; set; }
        [JsonProperty("BIO OGTT before medication")] public string BIO_OGTT_before_medication { get; set; }
        [JsonProperty("BIO OGTT result after3")] public string BIO_OGTT_result_after3 { get; set; }
        [JsonProperty("BIO OGTT result after6")] public string BIO_OGTT_result_after6 { get; set; }
        [JsonProperty("BIO OGTT result after9")] public string BIO_OGTT_result_after9 { get; set; }
        [JsonProperty("BIO OGTT result after12")] public string BIO_OGTT_result_after12 { get; set; }
        [JsonProperty("BIO FG2 before medication")] public string BIO_FG2_before_medication { get; set; }
        [JsonProperty("BIO FG2 result after3")] public string BIO_FG2_result_after3 { get; set; }
        [JsonProperty("BIO FG2 result after6")] public string BIO_FG2_result_after6 { get; set; }
        [JsonProperty("BIO FG2 result after9")] public string BIO_FG2_result_after9 { get; set; }
        [JsonProperty("BIO FG2 result after12")] public string BIO_FG2_result_after12 { get; set; }
        [JsonProperty("BIO HbA1c before medication")] public string BIO_HbA1c_before_medication { get; set; }
        [JsonProperty("BIO HbA1c result after3")] public string BIO_HbA1c_result_after3 { get; set; }
        [JsonProperty("BIO HbA1c result after6")] public string BIO_HbA1c_result_after6 { get; set; }
        [JsonProperty("BIO HbA1c result after9")] public string BIO_HbA1c_result_after9 { get; set; }
        [JsonProperty("BIO HbA1c result after12")] public string BIO_HbA1c_result_after12 { get; set; }
        [JsonProperty("BIO Fasting insulin before medication")] public string BIO_Fasting_insulin_before_medication { get; set; }
        [JsonProperty("BIO Fasting insulin result after3")] public string BIO_Fasting_insulin_result_after3 { get; set; }
        [JsonProperty("BIO Fasting insulin result after6")] public string BIO_Fasting_insulin_result_after6 { get; set; }
        [JsonProperty("BIO Fasting insulin result after9")] public string BIO_Fasting_insulin_result_after9 { get; set; }
        [JsonProperty("BIO Fasting insulin result after12")] public string BIO_Fasting_insulin_result_after12 { get; set; }
        [JsonProperty("BIO TotalCholesterol before medication")] public string BIO_TotalCholesterol_before_medication { get; set; }
        [JsonProperty("BIO TotalCholesterol result after3")] public string BIO_TotalCholesterol_result_after3 { get; set; }
        [JsonProperty("BIO TotalCholesterol result after6")] public string BIO_TotalCholesterol_result_after6 { get; set; }
        [JsonProperty("BIO TotalCholesterol result after9")] public string BIO_TotalCholesterol_result_after9 { get; set; }
        [JsonProperty("BIO TotalCholesterol result after12")] public string BIO_TotalCholesterol_result_after12 { get; set; }
        [JsonProperty("BIO Triglyceride before medication")] public string BIO_Triglyceride_before_medication { get; set; }
        [JsonProperty("BIO Triglyceride result after3")] public string BIO_Triglyceride_result_after3 { get; set; }
        [JsonProperty("BIO Triglyceride result after6")] public string BIO_Triglyceride_result_after6 { get; set; }
        [JsonProperty("BIO Triglyceride result after9")] public string BIO_Triglyceride_result_after9 { get; set; }
        [JsonProperty("BIO Triglyceride result after12")] public string BIO_Triglyceride_result_after12 { get; set; }
        [JsonProperty("BIO HDL before medication")] public string BIO_HDL_before_medication { get; set; }
        [JsonProperty("BIO HDL result after3")] public string BIO_HDL_result_after3 { get; set; }
        [JsonProperty("BIO HDL result after6")] public string BIO_HDL_result_after6 { get; set; }
        [JsonProperty("BIO HDL result after9")] public string BIO_HDL_result_after9 { get; set; }
        [JsonProperty("BIO HDL result after12")] public string BIO_HDL_result_after12 { get; set; }
        [JsonProperty("BIO LDL before medication")] public string BIO_LDL_before_medication { get; set; }
        [JsonProperty("BIO LDL result after3")] public string BIO_LDL_result_after3 { get; set; }
        [JsonProperty("BIO LDL result after6")] public string BIO_LDL_result_after6 { get; set; }
        [JsonProperty("BIO LDL result after9")] public string BIO_LDL_result_after9 { get; set; }
        [JsonProperty("BIO LDL result after12")] public string BIO_LDL_result_after12 { get; set; }
        [JsonProperty("BIO VitaminDLevel before medication")] public string BIO_VitaminDLevel_before_medication { get; set; }
        [JsonProperty("BIO VitaminDLevel result after3")] public string BIO_VitaminDLevel_result_after3 { get; set; }
        [JsonProperty("BIO VitaminDLevel result after6")] public string BIO_VitaminDLevel_result_after6 { get; set; }
        [JsonProperty("BIO VitaminDLevel result after9")] public string BIO_VitaminDLevel_result_after9 { get; set; }
        [JsonProperty("BIO VitaminDLevel result after12")] public string BIO_VitaminDLevel_result_after12 { get; set; }
        [JsonProperty("BIO Microalbumin before medication")] public string BIO_Microalbumin_before_medication { get; set; }
        [JsonProperty("BIO Microalbumin result after3")] public string BIO_Microalbumin_result_after3 { get; set; }
        [JsonProperty("BIO Microalbumin result after6")] public string BIO_Microalbumin_result_after6 { get; set; }
        [JsonProperty("BIO Microalbumin result after9")] public string BIO_Microalbumin_result_after9 { get; set; }
        [JsonProperty("BIO Microalbumin result after12")] public string BIO_Microalbumin_result_after12 { get; set; }
        [JsonProperty("BIO albuminuria before medication")] public string BIO_albuminuria_before_medication { get; set; }
        [JsonProperty("BIO albuminuria result after3")] public string BIO_albuminuria_result_after3 { get; set; }
        [JsonProperty("BIO albuminuria result after6")] public string BIO_albuminuria_result_after6 { get; set; }
        [JsonProperty("BIO albuminuria result after9")] public string BIO_albuminuria_result_after9 { get; set; }
        [JsonProperty("BIO albuminuria result after12")] public string BIO_albuminuria_result_after12 { get; set; }
        [JsonProperty("BIO albumincreatinine before medication")] public string BIO_albumincreatinine_before_medication { get; set; }
        [JsonProperty("BIO albumincreatinine result after3")] public string BIO_albumincreatinine_result_after3 { get; set; }
        [JsonProperty("BIO albumincreatinine result after6")] public string BIO_albumincreatinine_result_after6 { get; set; }
        [JsonProperty("BIO albumincreatinine result after9")] public string BIO_albumincreatinine_result_after9 { get; set; }
        [JsonProperty("BIO albumincreatinine result after12")] public string BIO_albumincreatinine_result_after12 { get; set; }
        [JsonProperty("BIO Creatinine before medication")] public string BIO_Creatinine_before_medication { get; set; }
        [JsonProperty("BIO Creatinine result after3")] public string BIO_Creatinine_result_after3 { get; set; }
        [JsonProperty("BIO Creatinine result after6")] public string BIO_Creatinine_result_after6 { get; set; }
        [JsonProperty("BIO Creatinine result after9")] public string BIO_Creatinine_result_after9 { get; set; }
        [JsonProperty("BIO Creatinine result after12")] public string BIO_Creatinine_result_after12 { get; set; }
        [JsonProperty("BIO Urea before medication")] public string BIO_Urea_before_medication { get; set; }
        [JsonProperty("BIO Urea result after3")] public string BIO_Urea_result_after3 { get; set; }
        [JsonProperty("BIO Urea result after6")] public string BIO_Urea_result_after6 { get; set; }
        [JsonProperty("BIO Urea result after9")] public string BIO_Urea_result_after9 { get; set; }
        [JsonProperty("BIO Urea result after12")] public string BIO_Urea_result_after12 { get; set; }
        [JsonProperty("BIO egfr before medication")] public string BIO_egfr_before_medication { get; set; }
        [JsonProperty("BIO egfr result after3")] public string BIO_egfr_result_after3 { get; set; }
        [JsonProperty("BIO egfr result after6")] public string BIO_egfr_result_after6 { get; set; }
        [JsonProperty("BIO egfr result after9")] public string BIO_egfr_result_after9 { get; set; }
        [JsonProperty("BIO egfr result after12")] public string BIO_egfr_result_after12 { get; set; }
        [JsonProperty("BIO sodium before")] public string BIO_sodium_before { get; set; }
        [JsonProperty("BIO sodium result after3")] public string BIO_sodium_result_after3 { get; set; }
        [JsonProperty("BIO sodium result after6")] public string BIO_sodium_result_after6 { get; set; }
        [JsonProperty("BIO sodium result after9")] public string BIO_sodium_result_after9 { get; set; }
        [JsonProperty("BIO sodium result after12")] public string BIO_sodium_result_after12 { get; set; }
        [JsonProperty("BIO potassium before")] public string BIO_potassium_before { get; set; }
        [JsonProperty("BIO potassium result after3")] public string BIO_potassium_result_after3 { get; set; }
        [JsonProperty("BIO potassium result after6")] public string BIO_potassium_result_after6 { get; set; }
        [JsonProperty("BIO potassium result after9")] public string BIO_potassium_result_after9 { get; set; }
        [JsonProperty("BIO potassium result after12")] public string BIO_potassium_result_after12 { get; set; }
        [JsonProperty("BIO calcium before")] public string BIO_calcium_before { get; set; }
        [JsonProperty("BIO calcium result after3")] public string BIO_calcium_result_after3 { get; set; }
        [JsonProperty("BIO calcium result after6")] public string BIO_calcium_result_after6 { get; set; }
        [JsonProperty("BIO calcium result after9")] public string BIO_calcium_result_after9 { get; set; }
        [JsonProperty("BIO calcium result after12")] public string BIO_calcium_result_after12 { get; set; }
        [JsonProperty("BIO Magnesium before")] public string BIO_Magnesium_before { get; set; }
        [JsonProperty("BIO Magnesium result after3")] public string BIO_Magnesium_result_after3 { get; set; }
        [JsonProperty("BIO Magnesium result after6")] public string BIO_Magnesium_result_after6 { get; set; }
        [JsonProperty("BIO Magnesium result after9")] public string BIO_Magnesium_result_after9 { get; set; }
        [JsonProperty("BIO Magnesium result after12")] public string BIO_Magnesium_result_after12 { get; set; }
        [JsonProperty("BIO Phosphorus before")] public string BIO_Phosphorus_before { get; set; }
        [JsonProperty("BIO Phosphorus result after3")] public string BIO_Phosphorus_result_after3 { get; set; }
        [JsonProperty("BIO Phosphorus result after6")] public string BIO_Phosphorus_result_after6 { get; set; }
        [JsonProperty("BIO Phosphorus result after9")] public string BIO_Phosphorus_result_after9 { get; set; }
        [JsonProperty("BIO Phosphorus result after12")] public string BIO_Phosphorus_result_after12 { get; set; }
        [JsonProperty("BIO Bicarbonate before")] public string BIO_Bicarbonate_before { get; set; }
        [JsonProperty("BIO Bicarbonate result after3")] public string BIO_Bicarbonate_result_after3 { get; set; }
        [JsonProperty("BIO Bicarbonate result after6")] public string BIO_Bicarbonate_result_after6 { get; set; }
        [JsonProperty("BIO Bicarbonate result after9")] public string BIO_Bicarbonate_result_after9 { get; set; }
        [JsonProperty("BIO Bicarbonate result after12")] public string BIO_Bicarbonate_result_after12 { get; set; }
        [JsonProperty("BIO ALT before")] public string BIO_ALT_before { get; set; }
        [JsonProperty("BIO ALT result after3")] public string BIO_ALT_result_after3 { get; set; }
        [JsonProperty("BIO ALT result after6")] public string BIO_ALT_result_after6 { get; set; }
        [JsonProperty("BIO ALT result after9")] public string BIO_ALT_result_after9 { get; set; }
        [JsonProperty("BIO ALT result after12")] public string BIO_ALT_result_after12 { get; set; }
        [JsonProperty("BIO ALP before")] public string BIO_ALP_before { get; set; }
        [JsonProperty("BIO ALP result after3")] public string BIO_ALP_result_after3 { get; set; }
        [JsonProperty("BIO ALP result after6")] public string BIO_ALP_result_after6 { get; set; }
        [JsonProperty("BIO ALP result after9")] public string BIO_ALP_result_after9 { get; set; }
        [JsonProperty("BIO ALP result after12")] public string BIO_ALP_result_after12 { get; set; }
        [JsonProperty("BIO AST before")] public string BIO_AST_before { get; set; }
        [JsonProperty("BIO AST result after3")] public string BIO_AST_result_after3 { get; set; }
        [JsonProperty("BIO AST result after6")] public string BIO_AST_result_after6 { get; set; }
        [JsonProperty("BIO AST result after9")] public string BIO_AST_result_after9 { get; set; }
        [JsonProperty("BIO AST result after12")] public string BIO_AST_result_after12 { get; set; }
        [JsonProperty("BIO bilirubin before")] public string BIO_bilirubin_before { get; set; }
        [JsonProperty("BIO bilirubin result after3")] public string BIO_bilirubin_result_after3 { get; set; }
        [JsonProperty("BIO bilirubin result after6")] public string BIO_bilirubin_result_after6 { get; set; }
        [JsonProperty("BIO bilirubin result after9")] public string BIO_bilirubin_result_after9 { get; set; }
        [JsonProperty("BIO bilirubin result after12")] public string BIO_bilirubin_result_after12 { get; set; }
        [JsonProperty("BIO Protein before")] public string BIO_Protein_before { get; set; }
        [JsonProperty("BIO Protein result after3")] public string BIO_Protein_result_after3 { get; set; }
        [JsonProperty("BIO Protein result after6")] public string BIO_Protein_result_after6 { get; set; }
        [JsonProperty("BIO Protein result after9")] public string BIO_Protein_result_after9 { get; set; }
        [JsonProperty("BIO Protein result after12")] public string BIO_Protein_result_after12 { get; set; }
        [JsonProperty("BIO Serum albumin before")] public string BIO_Serum_albumin_before { get; set; }
        [JsonProperty("BIO Serum albumin result after3")] public string BIO_Serum_albumin_result_after3 { get; set; }
        [JsonProperty("BIO Serum albumin result after6")] public string BIO_Serum_albumin_result_after6 { get; set; }
        [JsonProperty("BIO Serum albumin result after9")] public string BIO_Serum_albumin_result_after9 { get; set; }
        [JsonProperty("BIO Serum albumin result after12")] public string BIO_Serum_albumin_result_after12 { get; set; }
        [JsonProperty("BIO cprotein before")] public string BIO_cprotein_before { get; set; }
        [JsonProperty("BIO cprotein result after3")] public string BIO_cprotein_result_after3 { get; set; }
        [JsonProperty("BIO cprotein result after6")] public string BIO_cprotein_result_after6 { get; set; }
        [JsonProperty("BIO cprotein result after9")] public string BIO_cprotein_result_after9 { get; set; }
        [JsonProperty("BIO cprotein result after12")] public string BIO_cprotein_result_after12 { get; set; }
        [JsonProperty("BIO Fibrinogen before")] public string BIO_Fibrinogen_before { get; set; }
        [JsonProperty("BIO Fibrinogen result after3")] public string BIO_Fibrinogen_result_after3 { get; set; }
        [JsonProperty("BIO Fibrinogen result after6")] public string BIO_Fibrinogen_result_after6 { get; set; }
        [JsonProperty("BIO Fibrinogen result after9")] public string BIO_Fibrinogen_result_after9 { get; set; }
        [JsonProperty("BIO Fibrinogen result after12")] public string BIO_Fibrinogen_result_after12 { get; set; }
        [JsonProperty("BIO Interleukin before")] public string BIO_Interleukin_before { get; set; }
        [JsonProperty("BIO Interleukin result after3")] public string BIO_Interleukin_result_after3 { get; set; }
        [JsonProperty("BIO Interleukin result after6")] public string BIO_Interleukin_result_after6 { get; set; }
        [JsonProperty("BIO Interleukin result after9")] public string BIO_Interleukin_result_after9 { get; set; }
        [JsonProperty("BIO Interleukin result after12")] public string BIO_Interleukin_result_after12 { get; set; }
        [JsonProperty("BIO Procalcitonin before")] public string BIO_Procalcitonin_before { get; set; }
        [JsonProperty("BIO Procalcitonin result after3")] public string BIO_Procalcitonin_result_after3 { get; set; }
        [JsonProperty("BIO Procalcitonin result after6")] public string BIO_Procalcitonin_result_after6 { get; set; }
        [JsonProperty("BIO Procalcitonin result after9")] public string BIO_Procalcitonin_result_after9 { get; set; }
        [JsonProperty("BIO Procalcitonin result after12")] public string BIO_Procalcitonin_result_after12 { get; set; }
        [JsonProperty("BIO PAI1 before")] public string BIO_PAI1_before { get; set; }
        [JsonProperty("BIO PAI1 result after3")] public string BIO_PAI1_result_after3 { get; set; }
        [JsonProperty("BIO PAI1 result after6")] public string BIO_PAI1_result_after6 { get; set; }
        [JsonProperty("BIO PAI1 result after9")] public string BIO_PAI1_result_after9 { get; set; }
        [JsonProperty("BIO PAI1 result after12")] public string BIO_PAI1_result_after12 { get; set; }
        [JsonProperty("BIO Insulin before")] public string BIO_Insulin_before { get; set; }
        [JsonProperty("BIO Insulin result after3")] public string BIO_Insulin_result_after3 { get; set; }
        [JsonProperty("BIO Insulin result after6")] public string BIO_Insulin_result_after6 { get; set; }
        [JsonProperty("BIO Insulin result after9")] public string BIO_Insulin_result_after9 { get; set; }
        [JsonProperty("BIO Insulin result after12")] public string BIO_Insulin_result_after12 { get; set; }
        [JsonProperty("BIO Cortisol before")] public string BIO_Cortisol_before { get; set; }
        [JsonProperty("BIO Cortisol result after3")] public string BIO_Cortisol_result_after3 { get; set; }
        [JsonProperty("BIO Cortisol result after6")] public string BIO_Cortisol_result_after6 { get; set; }
        [JsonProperty("BIO Cortisol result after9")] public string BIO_Cortisol_result_after9 { get; set; }
        [JsonProperty("BIO Cortisol result after12")] public string BIO_Cortisol_result_after12 { get; set; }
        [JsonProperty("BIO T3 before")] public string BIO_T3_before { get; set; }
        [JsonProperty("BIO T3 result after3")] public string BIO_T3_result_after3 { get; set; }
        [JsonProperty("BIO T3 result after6")] public string BIO_T3_result_after6 { get; set; }
        [JsonProperty("BIO T3 result after9")] public string BIO_T3_result_after9 { get; set; }
        [JsonProperty("BIO T3 result after12")] public string BIO_T3_result_after12 { get; set; }
        [JsonProperty("BIO T4 before")] public string BIO_T4_before { get; set; }
        [JsonProperty("BIO T4 result after3")] public string BIO_T4_result_after3 { get; set; }
        [JsonProperty("BIO T4 result after6")] public string BIO_T4_result_after6 { get; set; }
        [JsonProperty("BIO T4 result after9")] public string BIO_T4_result_after9 { get; set; }
        [JsonProperty("BIO T4 result after12")] public string BIO_T4_result_after12 { get; set; }
        [JsonProperty("BIO FreeT4 before")] public string BIO_FreeT4_before { get; set; }
        [JsonProperty("BIO FreeT4 result after3")] public string BIO_FreeT4_result_after3 { get; set; }
        [JsonProperty("BIO FreeT4 result after6")] public string BIO_FreeT4_result_after6 { get; set; }
        [JsonProperty("BIO FreeT4 result after9")] public string BIO_FreeT4_result_after9 { get; set; }
        [JsonProperty("BIO FreeT4 result after12")] public string BIO_FreeT4_result_after12 { get; set; }
        [JsonProperty("BIO TSH before")] public string BIO_TSH_before { get; set; }
        [JsonProperty("BIO TSH result after3")] public string BIO_TSH_result_after3 { get; set; }
        [JsonProperty("BIO TSH result after6")] public string BIO_TSH_result_after6 { get; set; }
        [JsonProperty("BIO TSH result after9")] public string BIO_TSH_result_after9 { get; set; }
        [JsonProperty("BIO TSH result after12")] public string BIO_TSH_result_after12 { get; set; }
        [JsonProperty("BIO parathyroid before")] public string BIO_parathyroid_before { get; set; }
        [JsonProperty("BIO parathyroid result after3")] public string BIO_parathyroid_result_after3 { get; set; }
        [JsonProperty("BIO parathyroid result after6")] public string BIO_parathyroid_result_after6 { get; set; }
        [JsonProperty("BIO parathyroid result after9")] public string BIO_parathyroid_result_after9 { get; set; }
        [JsonProperty("BIO parathyroid result after12")] public string BIO_parathyroid_result_after12 { get; set; }
        [JsonProperty("BIO Estrogen before")] public string BIO_Estrogen_before { get; set; }
        [JsonProperty("BIO Estrogen result after3")] public string BIO_Estrogen_result_after3 { get; set; }
        [JsonProperty("BIO Estrogen result after6")] public string BIO_Estrogen_result_after6 { get; set; }
        [JsonProperty("BIO Estrogen result after9")] public string BIO_Estrogen_result_after9 { get; set; }
        [JsonProperty("BIO Estrogen result after12")] public string BIO_Estrogen_result_after12 { get; set; }
        [JsonProperty("BIO Progesterone before")] public string BIO_Progesterone_before { get; set; }
        [JsonProperty("BIO Progesterone result after3")] public string BIO_Progesterone_result_after3 { get; set; }
        [JsonProperty("BIO Progesterone result after6")] public string BIO_Progesterone_result_after6 { get; set; }
        [JsonProperty("BIO Progesterone result after9")] public string BIO_Progesterone_result_after9 { get; set; }
        [JsonProperty("BIO Progesterone result after12")] public string BIO_Progesterone_result_after12 { get; set; }
        [JsonProperty("BIO Testosterone before")] public string BIO_Testosterone_before { get; set; }
        [JsonProperty("BIO Testosterone result after3")] public string BIO_Testosterone_result_after3 { get; set; }
        [JsonProperty("BIO Testosterone result after6")] public string BIO_Testosterone_result_after6 { get; set; }
        [JsonProperty("BIO Testosterone result after9")] public string BIO_Testosterone_result_after9 { get; set; }
        [JsonProperty("BIO Testosterone result after12")] public string BIO_Testosterone_result_after12 { get; set; }
        [JsonProperty("BIO WBC Count before")] public string BIO_WBC_Count_before { get; set; }
        [JsonProperty("BIO WBC Count result after3")] public string BIO_WBC_Count_result_after3 { get; set; }
        [JsonProperty("BIO WBC Count result after6")] public string BIO_WBC_Count_result_after6 { get; set; }
        [JsonProperty("BIO WBC Count result after9")] public string BIO_WBC_Count_result_after9 { get; set; }
        [JsonProperty("BIO WBC Count result after12")] public string BIO_WBC_Count_result_after12 { get; set; }
        [JsonProperty("BIO WBC DiffCount before")] public string BIO_WBC_DiffCount_before { get; set; }
        [JsonProperty("BIO WBC DiffCount result after3")] public string BIO_WBC_DiffCount_result_after3 { get; set; }
        [JsonProperty("BIO WBC DiffCount result after6")] public string BIO_WBC_DiffCount_result_after6 { get; set; }
        [JsonProperty("BIO WBC DiffCount result after9")] public string BIO_WBC_DiffCount_result_after9 { get; set; }
        [JsonProperty("BIO WBC DiffCount result after12")] public string BIO_WBC_DiffCount_result_after12 { get; set; }
        [JsonProperty("BIO RBC Count before")] public string BIO_RBC_Count_before { get; set; }
        [JsonProperty("BIO RBC Count result after3")] public string BIO_RBC_Count_result_after3 { get; set; }
        [JsonProperty("BIO RBC Count result after6")] public string BIO_RBC_Count_result_after6 { get; set; }
        [JsonProperty("BIO RBC Count result after9")] public string BIO_RBC_Count_result_after9 { get; set; }
        [JsonProperty("BIO RBC Count result after12")] public string BIO_RBC_Count_result_after12 { get; set; }
        [JsonProperty("BIO Haemoglobin Count before")] public string BIO_Haemoglobin_Count_before { get; set; }
        [JsonProperty("BIO Haemoglobin Count result after3")] public string BIO_Haemoglobin_Count_result_after3 { get; set; }
        [JsonProperty("BIO Haemoglobin Count result after6")] public string BIO_Haemoglobin_Count_result_after6 { get; set; }
        [JsonProperty("BIO Haemoglobin Count result after9")] public string BIO_Haemoglobin_Count_result_after9 { get; set; }
        [JsonProperty("BIO Haemoglobin Count result after12")] public string BIO_Haemoglobin_Count_result_after12 { get; set; }
        [JsonProperty("BIO Haematocrit Count before")] public string BIO_Haematocrit_Count_before { get; set; }
        [JsonProperty("BIO Haematocrit Count result after3")] public string BIO_Haematocrit_Count_result_after3 { get; set; }
        [JsonProperty("BIO Haematocrit Count result after6")] public string BIO_Haematocrit_Count_result_after6 { get; set; }
        [JsonProperty("BIO Haematocrit Count result after9")] public string BIO_Haematocrit_Count_result_after9 { get; set; }
        [JsonProperty("BIO Haematocrit Count result after12")] public string BIO_Haematocrit_Count_result_after12 { get; set; }
        [JsonProperty("BIO Ferritin Count before")] public string BIO_Ferritin_Count_before { get; set; }
        [JsonProperty("BIO Ferritin Count result after3")] public string BIO_Ferritin_Count_result_after3 { get; set; }
        [JsonProperty("BIO Ferritin Count result after6")] public string BIO_Ferritin_Count_result_after6 { get; set; }
        [JsonProperty("BIO Ferritin Count result after9")] public string BIO_Ferritin_Count_result_after9 { get; set; }
        [JsonProperty("BIO Ferritin Count result after12")] public string BIO_Ferritin_Count_result_after12 { get; set; }
        [JsonProperty("BIO RDW Count before")] public string BIO_RDW_Count_before { get; set; }
        [JsonProperty("BIO RDW Count result after3")] public string BIO_RDW_Count_result_after3 { get; set; }
        [JsonProperty("BIO RDW Count result after6")] public string BIO_RDW_Count_result_after6 { get; set; }
        [JsonProperty("BIO RDW Count result after9")] public string BIO_RDW_Count_result_after9 { get; set; }
        [JsonProperty("BIO RDW Count result after12")] public string BIO_RDW_Count_result_after12 { get; set; }
        [JsonProperty("BIO Redbloodcellindice before")] public string BIO_Redbloodcellindice_before { get; set; }
        [JsonProperty("BIO Redbloodcellindice result after3")] public string BIO_Redbloodcellindice_result_after3 { get; set; }
        [JsonProperty("BIO Redbloodcellindice result after6")] public string BIO_Redbloodcellindice_result_after6 { get; set; }
        [JsonProperty("BIO Redbloodcellindice result after9")] public string BIO_Redbloodcellindice_result_after9 { get; set; }
        [JsonProperty("BIO Redbloodcellindice result after12")] public string BIO_Redbloodcellindice_result_after12 { get; set; }
        [JsonProperty("BIO MCV before")] public string BIO_MCV_before { get; set; }
        [JsonProperty("BIO MCV result after3")] public string BIO_MCV_result_after3 { get; set; }
        [JsonProperty("BIO MCV result after6")] public string BIO_MCV_result_after6 { get; set; }
        [JsonProperty("BIO MCV result after9")] public string BIO_MCV_result_after9 { get; set; }
        [JsonProperty("BIO MCV result after12")] public string BIO_MCV_result_after12 { get; set; }
        [JsonProperty("BIO MCH before")] public string BIO_MCH_before { get; set; }
        [JsonProperty("BIO MCH result after3")] public string BIO_MCH_result_after3 { get; set; }
        [JsonProperty("BIO MCH result after6")] public string BIO_MCH_result_after6 { get; set; }
        [JsonProperty("BIO MCH result after9")] public string BIO_MCH_result_after9 { get; set; }
        [JsonProperty("BIO MCH result after12")] public string BIO_MCH_result_after12 { get; set; }
        [JsonProperty("BIO MCHC before")] public string BIO_MCHC_before { get; set; }
        [JsonProperty("BIO MCHC result after3")] public string BIO_MCHC_result_after3 { get; set; }
        [JsonProperty("BIO MCHC result after6")] public string BIO_MCHC_result_after6 { get; set; }
        [JsonProperty("BIO MCHC result after9")] public string BIO_MCHC_result_after9 { get; set; }
        [JsonProperty("BIO MCHC result after12")] public string BIO_MCHC_result_after12 { get; set; }
        [JsonProperty("BIO Reticulocyte before")] public string BIO_Reticulocyte_before { get; set; }
        [JsonProperty("BIO Reticulocyte result after3")] public string BIO_Reticulocyte_result_after3 { get; set; }
        [JsonProperty("BIO Reticulocyte result after6")] public string BIO_Reticulocyte_result_after6 { get; set; }
        [JsonProperty("BIO Reticulocyte result after9")] public string BIO_Reticulocyte_result_after9 { get; set; }
        [JsonProperty("BIO Reticulocyte result after12")] public string BIO_Reticulocyte_result_after12 { get; set; }
        [JsonProperty("BIO Platelet before")] public string BIO_Platelet_before { get; set; }
        [JsonProperty("BIO Platelet result after3")] public string BIO_Platelet_result_after3 { get; set; }
        [JsonProperty("BIO Platelet result after6")] public string BIO_Platelet_result_after6 { get; set; }
        [JsonProperty("BIO Platelet result after9")] public string BIO_Platelet_result_after9 { get; set; }
        [JsonProperty("BIO Platelet result after12")] public string BIO_Platelet_result_after12 { get; set; }
        [JsonProperty("BIO MPVPlatelet before")] public string BIO_MPVPlatelet_before { get; set; }
        [JsonProperty("BIO MPVPlatelet result after3")] public string BIO_MPVPlatelet_result_after3 { get; set; }
        [JsonProperty("BIO MPVPlatelet result after6")] public string BIO_MPVPlatelet_result_after6 { get; set; }
        [JsonProperty("BIO MPVPlatelet result after9")] public string BIO_MPVPlatelet_result_after9 { get; set; }
        [JsonProperty("BIO MPVPlatelet result after12")] public string BIO_MPVPlatelet_result_after12 { get; set; }
        [JsonProperty("BIO Abeta40 before")] public string BIO_Abeta40_before { get; set; }
        [JsonProperty("BIO Abeta40 result after3")] public string BIO_Abeta40_result_after3 { get; set; }
        [JsonProperty("BIO Abeta40 result after6")] public string BIO_Abeta40_result_after6 { get; set; }
        [JsonProperty("BIO Abeta40 result after9")] public string BIO_Abeta40_result_after9 { get; set; }
        [JsonProperty("BIO Abeta40 result after12")] public string BIO_Abeta40_result_after12 { get; set; }
        [JsonProperty("BIO Abeta42 before")] public string BIO_Abeta42_before { get; set; }
        [JsonProperty("BIO Abeta42 result after3")] public string BIO_Abeta42_result_after3 { get; set; }
        [JsonProperty("BIO Abeta42 result after6")] public string BIO_Abeta42_result_after6 { get; set; }
        [JsonProperty("BIO Abeta42 result after9")] public string BIO_Abeta42_result_after9 { get; set; }
        [JsonProperty("BIO Abeta42 result after12")] public string BIO_Abeta42_result_after12 { get; set; }
        [JsonProperty("BIO tTau before")] public string BIO_tTau_before { get; set; }
        [JsonProperty("BIO tTau result after3")] public string BIO_tTau_result_after3 { get; set; }
        [JsonProperty("BIO tTau result after6")] public string BIO_tTau_result_after6 { get; set; }
        [JsonProperty("BIO tTau result after9")] public string BIO_tTau_result_after9 { get; set; }
        [JsonProperty("BIO tTau result after12")] public string BIO_tTau_result_after12 { get; set; }
        [JsonProperty("BIO UTSmacroscopic before")] public string BIO_UTSmacroscopic_before { get; set; }
        [JsonProperty("BIO UTSmacroscopic result after3")] public string BIO_UTSmacroscopic_result_after3 { get; set; }
        [JsonProperty("BIO UTSmacroscopic result after6")] public string BIO_UTSmacroscopic_result_after6 { get; set; }
        [JsonProperty("BIO UTSmacroscopic result after9")] public string BIO_UTSmacroscopic_result_after9 { get; set; }
        [JsonProperty("BIO UTSmacroscopic result after12")] public string BIO_UTSmacroscopic_result_after12 { get; set; }
        [JsonProperty("BIO UTSpH before")] public string BIO_UTSpH_before { get; set; }
        [JsonProperty("BIO UTSpH result after3")] public string BIO_UTSpH_result_after3 { get; set; }
        [JsonProperty("BIO UTSpH result after6")] public string BIO_UTSpH_result_after6 { get; set; }
        [JsonProperty("BIO UTSpH result after9")] public string BIO_UTSpH_result_after9 { get; set; }
        [JsonProperty("BIO UTSpH result after12")] public string BIO_UTSpH_result_after12 { get; set; }
        [JsonProperty("BIO UTSGlucose before")] public string BIO_UTSGlucose_before { get; set; }
        [JsonProperty("BIO UTSGlucose result after3")] public string BIO_UTSGlucose_result_after3 { get; set; }
        [JsonProperty("BIO UTSGlucose result after6")] public string BIO_UTSGlucose_result_after6 { get; set; }
        [JsonProperty("BIO UTSGlucose result after9")] public string BIO_UTSGlucose_result_after9 { get; set; }
        [JsonProperty("BIO UTSGlucose result after12")] public string BIO_UTSGlucose_result_after12 { get; set; }
        [JsonProperty("BIO UTSGravity before")] public string BIO_UTSGravity_before { get; set; }
        [JsonProperty("BIO UTSGravity result after3")] public string BIO_UTSGravity_result_after3 { get; set; }
        [JsonProperty("BIO UTSGravity result after6")] public string BIO_UTSGravity_result_after6 { get; set; }
        [JsonProperty("BIO UTSGravity result after9")] public string BIO_UTSGravity_result_after9 { get; set; }
        [JsonProperty("BIO UTSGravity result after12")] public string BIO_UTSGravity_result_after12 { get; set; }
        [JsonProperty("BIO UTSNitrite before")] public string BIO_UTSNitrite_before { get; set; }
        [JsonProperty("BIO UTSNitrite result after3")] public string BIO_UTSNitrite_result_after3 { get; set; }
        [JsonProperty("BIO UTSNitrite result after6")] public string BIO_UTSNitrite_result_after6 { get; set; }
        [JsonProperty("BIO UTSNitrite result after9")] public string BIO_UTSNitrite_result_after9 { get; set; }
        [JsonProperty("BIO UTSNitrite result after12")] public string BIO_UTSNitrite_result_after12 { get; set; }
        [JsonProperty("BIO UTSWBC before")] public string BIO_UTSWBC_before { get; set; }
        [JsonProperty("BIO UTSWBC result after3")] public string BIO_UTSWBC_result_after3 { get; set; }
        [JsonProperty("BIO UTSWBC result after6")] public string BIO_UTSWBC_result_after6 { get; set; }
        [JsonProperty("BIO UTSWBC result after9")] public string BIO_UTSWBC_result_after9 { get; set; }
        [JsonProperty("BIO UTSWBC result after12")] public string BIO_UTSWBC_result_after12 { get; set; }
        [JsonProperty("BIO UTSProtein before")] public string BIO_UTSProtein_before { get; set; }
        [JsonProperty("BIO UTSProtein result after3")] public string BIO_UTSProtein_result_after3 { get; set; }
        [JsonProperty("BIO UTSProtein result after6")] public string BIO_UTSProtein_result_after6 { get; set; }
        [JsonProperty("BIO UTSProtein result after9")] public string BIO_UTSProtein_result_after9 { get; set; }
        [JsonProperty("BIO UTSProtein result after12")] public string BIO_UTSProtein_result_after12 { get; set; }
        [JsonProperty("BIO UTSBilirubin before")] public string BIO_UTSBilirubin_before { get; set; }
        [JsonProperty("BIO UTSBilirubin result after3")] public string BIO_UTSBilirubin_result_after3 { get; set; }
        [JsonProperty("BIO UTSBilirubin result after6")] public string BIO_UTSBilirubin_result_after6 { get; set; }
        [JsonProperty("BIO UTSBilirubin result after9")] public string BIO_UTSBilirubin_result_after9 { get; set; }
        [JsonProperty("BIO UTSBilirubin result after12")] public string BIO_UTSBilirubin_result_after12 { get; set; }
        [JsonProperty("BIO UTSBlood before")] public string BIO_UTSBlood_before { get; set; }
        [JsonProperty("BIO UTSBlood result after3")] public string BIO_UTSBlood_result_after3 { get; set; }
        [JsonProperty("BIO UTSBlood result after6")] public string BIO_UTSBlood_result_after6 { get; set; }
        [JsonProperty("BIO UTSBlood result after9")] public string BIO_UTSBlood_result_after9 { get; set; }
        [JsonProperty("BIO UTSBlood result after12")] public string BIO_UTSBlood_result_after12 { get; set; }
        [JsonProperty("BIO UTSLeukocyte before")] public string BIO_UTSLeukocyte_before { get; set; }
        [JsonProperty("BIO UTSLeukocyte result after3")] public string BIO_UTSLeukocyte_result_after3 { get; set; }
        [JsonProperty("BIO UTSLeukocyte result after6")] public string BIO_UTSLeukocyte_result_after6 { get; set; }
        [JsonProperty("BIO UTSLeukocyte result after9")] public string BIO_UTSLeukocyte_result_after9 { get; set; }
        [JsonProperty("BIO UTSLeukocyte result after12")] public string BIO_UTSLeukocyte_result_after12 { get; set; }
        [JsonProperty("BIO UTSMicroscopy cells before")] public string BIO_UTSMicroscopy_cells_before { get; set; }
        [JsonProperty("BIO UTSMicroscopy cells result after3")] public string BIO_UTSMicroscopy_cells_result_after3 { get; set; }
        [JsonProperty("BIO UTSMicroscopy cells result after6")] public string BIO_UTSMicroscopy_cells_result_after6 { get; set; }
        [JsonProperty("BIO UTSMicroscopy cells result after9")] public string BIO_UTSMicroscopy_cells_result_after9 { get; set; }
        [JsonProperty("BIO UTSMicroscopy cells result after12")] public string BIO_UTSMicroscopy_cells_result_after12 { get; set; }
        [JsonProperty("BIO UTSMicroscopy casts before")] public string BIO_UTSMicroscopy_casts_before { get; set; }
        [JsonProperty("BIO UTSMicroscopy casts result after3")] public string BIO_UTSMicroscopy_casts_result_after3 { get; set; }
        [JsonProperty("BIO UTSMicroscopy casts result after6")] public string BIO_UTSMicroscopy_casts_result_after6 { get; set; }
        [JsonProperty("BIO UTSMicroscopy casts result after9")] public string BIO_UTSMicroscopy_casts_result_after9 { get; set; }
        [JsonProperty("BIO UTSMicroscopy casts result after12")] public string BIO_UTSMicroscopy_casts_result_after12 { get; set; }
        [JsonProperty("BIO UTSMicroscopy crystals before")] public string BIO_UTSMicroscopy_crystals_before { get; set; }
        [JsonProperty("BIO UTSMicroscopy crystals result after3")] public string BIO_UTSMicroscopy_crystals_result_after3 { get; set; }
        [JsonProperty("BIO UTSMicroscopy crystals result after6")] public string BIO_UTSMicroscopy_crystals_result_after6 { get; set; }
        [JsonProperty("BIO UTSMicroscopy crystals result after9")] public string BIO_UTSMicroscopy_crystals_result_after9 { get; set; }
        [JsonProperty("BIO UTSMicroscopy crystals result after12")] public string BIO_UTSMicroscopy_crystals_result_after12 { get; set; }
        [JsonProperty("BIO Blood ketone level before medication")] public string BIO_Blood_ketone_level_before_medication { get; set; }
        [JsonProperty("BIO Blood ketone level result after3")] public string BIO_Blood_ketone_level_result_after3 { get; set; }
        [JsonProperty("BIO Blood ketone level result after6")] public string BIO_Blood_ketone_level_result_after6 { get; set; }
        [JsonProperty("BIO Blood ketone level result after9")] public string BIO_Blood_ketone_level_result_after9 { get; set; }
        [JsonProperty("BIO Blood ketone level result after12")] public string BIO_Blood_ketone_level_result_after12 { get; set; }
        [JsonProperty("BIO beta amyloid before medication")] public string BIO_beta_amyloid_before_medication { get; set; }
        [JsonProperty("BIO beta amyloid result after3")] public string BIO_beta_amyloid_result_after3 { get; set; }
        [JsonProperty("BIO beta amyloid result after6")] public string BIO_beta_amyloid_result_after6 { get; set; }
        [JsonProperty("BIO beta amyloid result after9")] public string BIO_beta_amyloid_result_after9 { get; set; }
        [JsonProperty("BIO beta amyloid result after12")] public string BIO_beta_amyloid_result_after12 { get; set; }
        [JsonProperty("BIO ptau181 before medication")] public string BIO_ptau181_before_medication { get; set; }
        [JsonProperty("BIO ptau181 result after3")] public string BIO_ptau181_result_after3 { get; set; }
        [JsonProperty("BIO ptau181 result after6")] public string BIO_ptau181_result_after6 { get; set; }
        [JsonProperty("BIO ptau181 result after9")] public string BIO_ptau181_result_after9 { get; set; }
        [JsonProperty("BIO ptau181 result after12")] public string BIO_ptau181_result_after12 { get; set; }
        [JsonProperty("BIO Ketones before medication")] public string BIO_Ketones_before_medication { get; set; }
        [JsonProperty("BIO Ketones result after3")] public string BIO_Ketones_result_after3 { get; set; }
        [JsonProperty("BIO Ketones result after6")] public string BIO_Ketones_result_after6 { get; set; }
        [JsonProperty("BIO Ketones result after9")] public string BIO_Ketones_result_after9 { get; set; }
        [JsonProperty("BIO Ketones result after12")] public string BIO_Ketones_result_after12 { get; set; }
        [JsonProperty("BIO ABG before medication")] public string BIO_ABG_before_medication { get; set; }
        [JsonProperty("BIO ABG result after3")] public string BIO_ABG_result_after3 { get; set; }
        [JsonProperty("BIO ABG result after6")] public string BIO_ABG_result_after6 { get; set; }
        [JsonProperty("BIO ABG result after9")] public string BIO_ABG_result_after9 { get; set; }
        [JsonProperty("BIO ABG result after12")] public string BIO_ABG_result_after12 { get; set; }
        [JsonProperty("BIO Comments")] public string BIO_Comments { get; set; }
        [JsonProperty("BIO covid1 before medication")] public string BIO_covid19_before_medication { get; set; }
        [JsonProperty("BIO covid1 result after3")] public string BIO_covid19_result_after3 { get; set; }
        [JsonProperty("BIO covid1 result after6")] public string BIO_covid19_result_after6 { get; set; }
        [JsonProperty("BIO covid1 result after9")] public string BIO_covid19_result_after9 { get; set; }
        [JsonProperty("BIO covid1 result after12")] public string BIO_covid19_result_after12 { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
