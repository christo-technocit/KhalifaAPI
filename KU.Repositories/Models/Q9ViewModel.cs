using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
     public class QuestionnaireWrap9
    {
       public QuestionnaireWrap9()
        {
           result = new List<Q9ViewModel>();

        }
        public IEnumerable<Q9ViewModel> result { get; set; }

    }
    public class Q9ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("sample")] public string sample { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        [JsonProperty("projecttitle")] public string projecttitle { get; set; }
        [JsonProperty("principalinvestigator")] public string principalinvestigator { get; set; }
        [JsonProperty("collection point")] public string collection_point { get; set; }
        [JsonProperty("collected by")] public string collected_by { get; set; }
        [JsonProperty("collected date")] public string collected_date { get; set; }
        [JsonProperty("gender")] public string gender { get; set; }
        [JsonProperty("country")] public string country { get; set; }
        [JsonProperty("nationality")] public string nationality { get; set; }
        [JsonProperty("dob")] public string dob { get; set; }
        [JsonProperty("PlaceOfBirth")] public string PlaceOfBirth { get; set; }
        [JsonProperty("city")] public string city { get; set; }
        [JsonProperty("age")] public string age { get; set; }
        [JsonProperty("pers Numberofwives")] public string pers_Numberofwives { get; set; }
        [JsonProperty("pers BoysGirls")] public string pers_BoysGirls { get; set; }
        [JsonProperty("pers Girls")] public string pers_Girls { get; set; }
        [JsonProperty("pers Boys")] public string pers_Boys { get; set; }
        [JsonProperty("ethnicity")] public string ethnicity { get; set; }
        [JsonProperty("ethnicity mixed specify text")] public string ethnicity_mixed_specify_text { get; set; }
        [JsonProperty("ethnicity others text")] public string ethnicity_others_text { get; set; }
        [JsonProperty("maritalstatus")] public string maritalstatus { get; set; }
        [JsonProperty("marriage con")] public string marriage_con { get; set; }
        [JsonProperty("pers NumberofChildren")] public string pers_NumberofChildren { get; set; }
        [JsonProperty("highest grade")] public string highest_grade { get; set; }
        [JsonProperty("highest degree earned")] public string highest_degree_earned { get; set; }
        [JsonProperty("eduGradel")] public string eduGradel { get; set; }
        [JsonProperty("eduLevel")] public string eduLevel { get; set; }
        [JsonProperty("household")] public string household { get; set; }
        [JsonProperty("household minor")] public string household_minor { get; set; }
        [JsonProperty("ownresidence")] public string ownresidence { get; set; }
        [JsonProperty("employment status")] public string employment_status { get; set; }
        [JsonProperty("employment work")] public string employment_work { get; set; }
        [JsonProperty("employment nightshift")] public string employment_nightshift { get; set; }
        [JsonProperty("employment nightshift others")] public string employment_nightshift_others { get; set; }
        [JsonProperty("eduGrade other")] public string eduGrade_other { get; set; }
        [JsonProperty("PPA work txt")] public string PPA_work_txt { get; set; }
        [JsonProperty("eduLevel other")] public string eduLevel_other { get; set; }
        [JsonProperty("employment nightshift often")] public string employment_nightshift_often { get; set; }
        [JsonProperty("elementary school")] public string elementary_school { get; set; }
        [JsonProperty("high school")] public string high_school { get; set; }
        [JsonProperty("elementary school value")] public string elementary_school_value { get; set; }
        [JsonProperty("high school value")] public string high_school_value { get; set; }
        [JsonProperty("college")] public string college { get; set; }
        [JsonProperty("college value")] public string college_value { get; set; }
        [JsonProperty("graduate")] public string graduate { get; set; }
        [JsonProperty("graduate value")] public string graduate_value { get; set; }
        [JsonProperty("other grade")] public string other_grade { get; set; }
        [JsonProperty("prefernottodisclose grade")] public string prefernottodisclose_grade { get; set; }
        [JsonProperty("health overall 4weeks")] public string health_overall_4weeks { get; set; }
        [JsonProperty("health physical problem 4weeks")] public string health_physical_problem_4weeks { get; set; }
        [JsonProperty("health difficulty 4weeks")] public string health_difficulty_4weeks { get; set; }
        [JsonProperty("health body pain 4weeks")] public string health_body_pain_4weeks { get; set; }
        [JsonProperty("health energy 4weeks")] public string health_energy_4weeks { get; set; }
        [JsonProperty("health emotional problems 4weeks")] public string health_emotional_problems_4weeks { get; set; }
        [JsonProperty("health bothered emotional problems 4weeks")] public string health_bothered_emotional_problems_4weeks { get; set; }
        [JsonProperty("health bothered emotional problems affect 4weeks")] public string health_bothered_emotional_problems_affect_4weeks { get; set; }
        [JsonProperty("health brushteethtwice 4weeks")] public string health_brushteethtwice_4weeks { get; set; }
        [JsonProperty("health weight change")] public string health_weight_change { get; set; }
        [JsonProperty("health special diet 4weeks")] public string health_special_diet_4weeks { get; set; }
        [JsonProperty("health bowel movement 4weeks")] public string health_bowel_movement_4weeks { get; set; }
        [JsonProperty("health urinate 4weeks")] public string health_urinate_4weeks { get; set; }
        [JsonProperty("health urinate night 4weeks")] public string health_urinate_night_4weeks { get; set; }
        [JsonProperty("health urinate night 4weeks often")] public string health_urinate_night_4weeks_often { get; set; }
        [JsonProperty("health advcontact")] public string health_advcontact { get; set; }
        [JsonProperty("health emergency")] public string health_emergency { get; set; }
        [JsonProperty("health emergency reason")] public string health_emergency_reason { get; set; }
        [JsonProperty("health hospital")] public string health_hospital { get; set; }
        [JsonProperty("health hospital reason")] public string health_hospital_reason { get; set; }
        [JsonProperty("health advice noone")] public string health_advice_noone { get; set; }
        [JsonProperty("health advice Dietitian")] public string health_advice_Dietitian { get; set; }
        [JsonProperty("health advice Nurse")] public string health_advice_Nurse { get; set; }
        [JsonProperty("health advice GP")] public string health_advice_GP { get; set; }
        [JsonProperty("health advice Pharmacist")] public string health_advice_Pharmacist { get; set; }
        [JsonProperty("health advice Diabetes specialist")] public string health_advice_Diabetes_specialist { get; set; }
        [JsonProperty("health advice others")] public string health_advice_others { get; set; }
        [JsonProperty("health advice others remarks")] public string health_advice_others_remarks { get; set; }
        [JsonProperty("health annual medical checkup")] public string health_annual_medical_checkup { get; set; }
        [JsonProperty("health annual medical checkuptxtdateyear")] public string health_annual_medical_checkuptxtdateyear { get; set; }
        [JsonProperty("female first period")] public string female_first_period { get; set; }
        [JsonProperty("female first period others")] public string female_first_period_others { get; set; }
        [JsonProperty("female menopause")] public string female_menopause { get; set; }
        [JsonProperty("female menopause others")] public string female_menopause_others { get; set; }
        [JsonProperty("female period days")] public string female_period_days { get; set; }
        [JsonProperty("female period days number")] public string female_period_days_number { get; set; }
        [JsonProperty("female period How often")] public string female_period_How_often { get; set; }
        [JsonProperty("female period How often others")] public string female_period_How_often_others { get; set; }
        [JsonProperty("female period regular time intervals")] public string female_period_regular_time_intervals { get; set; }
        [JsonProperty("female period regular time intervals yes when")] public string female_period_regular_time_intervals_yes_when { get; set; }
        [JsonProperty("female period regular time intervals no when")] public string female_period_regular_time_intervals_no_when { get; set; }
        [JsonProperty("female pregnant")] public string female_pregnant { get; set; }
        [JsonProperty("female pregnant when")] public string female_pregnant_when { get; set; }
        [JsonProperty("female pregnant when year")] public string female_pregnant_when_year { get; set; }
        [JsonProperty("female birth control")] public string female_birth_control { get; set; }
        [JsonProperty("female birth control when")] public string female_birth_control_when { get; set; }
        [JsonProperty("female birth control Which medication")] public string female_birth_control_Which_medication { get; set; }
        [JsonProperty("female birth control dose")] public string female_birth_control_dose { get; set; }
        [JsonProperty("female facial hair")] public string female_facial_hair { get; set; }
        [JsonProperty("female fg points")] public string female_fg_points { get; set; }
        [JsonProperty("health emergency my mental health")] public string health_emergency_my_mental_health { get; set; }
        [JsonProperty("health emergency my physical health")] public string health_emergency_my_physical_health { get; set; }
        [JsonProperty("health emergency my diabetes status")] public string health_emergency_my_diabetes_status { get; set; }
        [JsonProperty("health emergency Non applicable")] public string health_emergency_Non_applicable { get; set; }
        [JsonProperty("health hospital my mental health")] public string health_hospital_my_mental_health { get; set; }
        [JsonProperty("health hospital my physical health")] public string health_hospital_my_physical_health { get; set; }
        [JsonProperty("health hospital my diabetes status")] public string health_hospital_my_diabetes_status { get; set; }
        [JsonProperty("health hospital Non applicable")] public string health_hospital_Non_applicable { get; set; }
        [JsonProperty("PPA vigorous physical activities")] public string PPA_vigorous_physical_activities { get; set; }
        [JsonProperty("PPA vigorous physical activities days per week")] public string PPA_vigorous_physical_activities_days_per_week { get; set; }
        [JsonProperty("PPA vigorous physical activities time")] public string PPA_vigorous_physical_activities_time { get; set; }
        [JsonProperty("PPA vigorous physical activities hours")] public string PPA_vigorous_physical_activities_hours { get; set; }
        [JsonProperty("PPA vigorous physical activities min")] public string PPA_vigorous_physical_activities_min { get; set; }
        [JsonProperty("PPA moderate physical activities")] public string PPA_moderate_physical_activities { get; set; }
        [JsonProperty("PPA moderate physical activities time")] public string PPA_moderate_physical_activities_time { get; set; }
        [JsonProperty("PPA moderate physical activities hours")] public string PPA_moderate_physical_activities_hours { get; set; }
        [JsonProperty("PPA moderate physical activities min")] public string PPA_moderate_physical_activities_min { get; set; }
        [JsonProperty("PPA walk")] public string PPA_walk { get; set; }
        [JsonProperty("PPA walk days")] public string PPA_walk_days { get; set; }
        [JsonProperty("PPA walk time")] public string PPA_walk_time { get; set; }
        [JsonProperty("PPA walk time hours")] public string PPA_walk_time_hours { get; set; }
        [JsonProperty("PPA walk time min")] public string PPA_walk_time_min { get; set; }
        [JsonProperty("PPA sit")] public string PPA_sit { get; set; }
        [JsonProperty("PPA sit hours")] public string PPA_sit_hours { get; set; }
        [JsonProperty("PPA sit min")] public string PPA_sit_min { get; set; }
        [JsonProperty("PPA work days")] public string PPA_work_days { get; set; }
        [JsonProperty("PPA work")] public string PPA_work { get; set; }
        [JsonProperty("PPA getintobed hour")] public string PPA_getintobed_hour { get; set; }
        [JsonProperty("PPA getintobed minute")] public string PPA_getintobed_minute { get; set; }
        [JsonProperty("PPA getintobed AMPM")] public string PPA_getintobed_AMPM { get; set; }
        [JsonProperty("PPA getoutbed hour")] public string PPA_getoutbed_hour { get; set; }
        [JsonProperty("PPA getoutbed minute")] public string PPA_getoutbed_minute { get; set; }
        [JsonProperty("PPA getoutbed AMPM")] public string PPA_getoutbed_AMPM { get; set; }
        [JsonProperty("PPA startwork hour")] public string PPA_startwork_hour { get; set; }
        [JsonProperty("PPA startwork minute")] public string PPA_startwork_minute { get; set; }
        [JsonProperty("PPA startwork AMPM")] public string PPA_startwork_AMPM { get; set; }
        [JsonProperty("PPA leavework hour")] public string PPA_leavework_hour { get; set; }
        [JsonProperty("PPA leavework minute")] public string PPA_leavework_minute { get; set; }
        [JsonProperty("PPA leavework AMPM")] public string PPA_leavework_AMPM { get; set; }
        [JsonProperty("PPA workhours yourdeskperc")] public string PPA_workhours_yourdeskperc { get; set; }
        [JsonProperty("PPA workhours awaydeskperc")] public string PPA_workhours_awaydeskperc { get; set; }
        [JsonProperty("PPA workhours yourdeskperc sitting")] public string PPA_workhours_yourdeskperc_sitting { get; set; }
        [JsonProperty("PPA workhours yourdeskperc standing")] public string PPA_workhours_yourdeskperc_standing { get; set; }
        [JsonProperty("PPA workhours yourdeskperc moving")] public string PPA_workhours_yourdeskperc_moving { get; set; }
        [JsonProperty("PPA workhours awaydeskperc sitting")] public string PPA_workhours_awaydeskperc_sitting { get; set; }
        [JsonProperty("PPA workhours awaydeskperc standing")] public string PPA_workhours_awaydeskperc_standing { get; set; }
        [JsonProperty("PPA workhours awaydeskperc moving")] public string PPA_workhours_awaydeskperc_moving { get; set; }
        [JsonProperty("PPA sit transport nonworkhours workdays")] public string PPA_sit_transport_nonworkhours_workdays { get; set; }
        [JsonProperty("PPA sit transport nonworkhours hours")] public string PPA_sit_transport_nonworkhours_hours { get; set; }
        [JsonProperty("PPA sit transport nonworkhours mininutes")] public string PPA_sit_transport_nonworkhours_mininutes { get; set; }
        [JsonProperty("PPA sit transport nonworkdays")] public string PPA_sit_transport_nonworkdays { get; set; }
        [JsonProperty("PPA sit transport nonwork hours")] public string PPA_sit_transport_nonwork_hours { get; set; }
        [JsonProperty("PPA sit transport nonwork mininutes")] public string PPA_sit_transport_nonwork_mininutes { get; set; }
        [JsonProperty("PPA sit tv nonworkhours workdays")] public string PPA_sit_tv_nonworkhours_workdays { get; set; }
        [JsonProperty("PPA sit tv nonworkhours hours")] public string PPA_sit_tv_nonworkhours_hours { get; set; }
        [JsonProperty("PPA sit tv nonworkhours mininutes")] public string PPA_sit_tv_nonworkhours_mininutes { get; set; }
        [JsonProperty("PPA sit tv nonworkdays")] public string PPA_sit_tv_nonworkdays { get; set; }
        [JsonProperty("PPA sit tv nonwork hours")] public string PPA_sit_tv_nonwork_hours { get; set; }
        [JsonProperty("PPA sit tv nonwork mininutes")] public string PPA_sit_tv_nonwork_mininutes { get; set; }
        [JsonProperty("PPA sit computer nonworkhours workdays")] public string PPA_sit_computer_nonworkhours_workdays { get; set; }
        [JsonProperty("PPA sit computer nonworkhours hours")] public string PPA_sit_computer_nonworkhours_hours { get; set; }
        [JsonProperty("PPA sit computer nonworkhours mininutes")] public string PPA_sit_computer_nonworkhours_mininutes { get; set; }
        [JsonProperty("PPA sit computer nonworkdays")] public string PPA_sit_computer_nonworkdays { get; set; }
        [JsonProperty("PPA sit computer nonwork hours")] public string PPA_sit_computer_nonwork_hours { get; set; }
        [JsonProperty("PPA sit computer nonwork mininutes")] public string PPA_sit_computer_nonwork_mininutes { get; set; }
        [JsonProperty("PPA sit others nonworkhours workdays")] public string PPA_sit_others_nonworkhours_workdays { get; set; }
        [JsonProperty("PPA sit others nonworkhours hours")] public string PPA_sit_others_nonworkhours_hours { get; set; }
        [JsonProperty("PPA sit others nonworkhours mininutes")] public string PPA_sit_others_nonworkhours_mininutes { get; set; }
        [JsonProperty("PPA sit others nonworkdays")] public string PPA_sit_others_nonworkdays { get; set; }
        [JsonProperty("PPA sit others nonwork hours")] public string PPA_sit_others_nonwork_hours { get; set; }
        [JsonProperty("PPA sit others nonwork mininutes")] public string PPA_sit_others_nonwork_mininutes { get; set; }
        [JsonProperty("PD eat vegetables")] public string PD_eat_vegetables { get; set; }
        [JsonProperty("PD eat by ordering")] public string PD_eat_by_ordering { get; set; }
        [JsonProperty("PD eat fruit")] public string PD_eat_fruit { get; set; }
        [JsonProperty("PD eat cake")] public string PD_eat_cake { get; set; }
        [JsonProperty("PD eat sugary drinks")] public string PD_eat_sugary_drinks { get; set; }
        [JsonProperty("PD eat fullfat spread")] public string PD_eat_fullfat_spread { get; set; }
        [JsonProperty("PD eat fullfat cheese")] public string PD_eat_fullfat_cheese { get; set; }
        [JsonProperty("PD eat processed meat")] public string PD_eat_processed_meat { get; set; }
        [JsonProperty("PD eat savory food")] public string PD_eat_savory_food { get; set; }
        [JsonProperty("PD eat savory pastry")] public string PD_eat_savory_pastry { get; set; }
        [JsonProperty("PD eat fast food")] public string PD_eat_fast_food { get; set; }
        [JsonProperty("PD eat meal at home")] public string PD_eat_meal_at_home { get; set; }
        [JsonProperty("PD eat pudding")] public string PD_eat_pudding { get; set; }
        [JsonProperty("PD eat oilyfish")] public string PD_eat_oilyfish { get; set; }
        [JsonProperty("PD eat regular meals")] public string PD_eat_regular_meals { get; set; }
        [JsonProperty("PD eat breakfast")] public string PD_eat_breakfast { get; set; }
        [JsonProperty("PD eat snack between meals")] public string PD_eat_snack_between_meals { get; set; }
        [JsonProperty("PD eat portion bread")] public string PD_eat_portion_bread { get; set; }
        [JsonProperty("PD eat highfiber bread")] public string PD_eat_highfiber_bread { get; set; }
        [JsonProperty("PD eat bowl breakfast")] public string PD_eat_bowl_breakfast { get; set; }
        [JsonProperty("PD eat bowl highfiber")] public string PD_eat_bowl_highfiber { get; set; }
        [JsonProperty("PD milk type")] public string PD_milk_type { get; set; }
        [JsonProperty("PD milk type others")] public string PD_milk_type_others { get; set; }
        [JsonProperty("PD weight concern")] public string PD_weight_concern { get; set; }
        [JsonProperty("PD important change diet")] public string PD_important_change_diet { get; set; }
        [JsonProperty("PD confident change diet")] public string PD_confident_change_diet { get; set; }
        [JsonProperty("PSE unable to control")] public string PSE_unable_to_control { get; set; }
        [JsonProperty("PSE handle problem")] public string PSE_handle_problem { get; set; }
        [JsonProperty("PSE yourway")] public string PSE_yourway { get; set; }
        [JsonProperty("PSE difficulty handle problem")] public string PSE_difficulty_handle_problem { get; set; }
        [JsonProperty("PSE little interest")] public string PSE_little_interest { get; set; }
        [JsonProperty("PSE depressed")] public string PSE_depressed { get; set; }
        [JsonProperty("PSE sleeping toomuch")] public string PSE_sleeping_toomuch { get; set; }
        [JsonProperty("PSE little energy")] public string PSE_little_energy { get; set; }
        [JsonProperty("PSE overeating")] public string PSE_overeating { get; set; }
        [JsonProperty("PSE feelingbad")] public string PSE_feelingbad { get; set; }
        [JsonProperty("PSE concentrating trouble")] public string PSE_concentrating_trouble { get; set; }
        [JsonProperty("PSE restless")] public string PSE_restless { get; set; }
        [JsonProperty("PSE dead thoughts")] public string PSE_dead_thoughts { get; set; }
        [JsonProperty("PSE get along")] public string PSE_get_along { get; set; }
        [JsonProperty("PSH falling asleep")] public string PSH_falling_asleep { get; set; }
        [JsonProperty("PSH staying asleep")] public string PSH_staying_asleep { get; set; }
        [JsonProperty("PSH wakeup tooearly")] public string PSH_wakeup_tooearly { get; set; }
        [JsonProperty("PSH satisfied sleep pattern")] public string PSH_satisfied_sleep_pattern { get; set; }
        [JsonProperty("PSH noticeable sleeping problem")] public string PSH_noticeable_sleeping_problem { get; set; }
        [JsonProperty("PSH worried sleeping problem")] public string PSH_worried_sleeping_problem { get; set; }
        [JsonProperty("PSH interfere sleeping problem")] public string PSH_interfere_sleeping_problem { get; set; }
        [JsonProperty("PSS smoked 100 cigarettes")] public string PSS_smoked_100_cigarettes { get; set; }
        [JsonProperty("PSS first smoke age")] public string PSS_first_smoke_age { get; set; }
        [JsonProperty("PSS first smoke age694 txt")] public string PSS_first_smoke_age694_txt { get; set; }
        [JsonProperty("PSS current smoker")] public string PSS_current_smoker { get; set; }
        [JsonProperty("PSS quit smoking")] public string PSS_quit_smoking { get; set; }
        [JsonProperty("PSS quit smoking days txt")] public string PSS_quit_smoking_days_txt { get; set; }
        [JsonProperty("PSS quit smoking week txt")] public string PSS_quit_smoking_week_txt { get; set; }
        [JsonProperty("PSS quit smoking month txt")] public string PSS_quit_smoking_month_txt { get; set; }
        [JsonProperty("PSS quit smoking yrs txt")] public string PSS_quit_smoking_yrs_txt { get; set; }
        [JsonProperty("PSS quit smoking since1year")] public string PSS_quit_smoking_since1year { get; set; }
        [JsonProperty("PSS avg cigarettes perday")] public string PSS_avg_cigarettes_perday { get; set; }
        [JsonProperty("PSS avg cigarettes perday194 txt")] public string PSS_avg_cigarettes_perday194_txt { get; set; }
        [JsonProperty("PSS cigarettes 30days")] public string PSS_cigarettes_30days { get; set; }
        [JsonProperty("PSS avg cigarettes 30days")] public string PSS_avg_cigarettes_30days { get; set; }
        [JsonProperty("PSS cigarettes 30days number")] public string PSS_cigarettes_30days_number { get; set; }
        [JsonProperty("PSS trying quit smoke")] public string PSS_trying_quit_smoke { get; set; }
        [JsonProperty("PSS avg cigarettes 30days 1 94")] public string PSS_avg_cigarettes_30days_1_94 { get; set; }
        [JsonProperty("his hypertension")] public string his_hypertension { get; set; }
        [JsonProperty("his hypertension year")] public string his_hypertension_year { get; set; }
        [JsonProperty("his Prediabetes")] public string his_Prediabetes { get; set; }
        [JsonProperty("his Prediabetes year")] public string his_Prediabetes_year { get; set; }
        [JsonProperty("his type2diabetes")] public string his_type2diabetes { get; set; }
        [JsonProperty("his type2diabetes year")] public string his_type2diabetes_year { get; set; }
        [JsonProperty("his Gestational Diabetes")] public string his_Gestational_Diabetes { get; set; }
        [JsonProperty("his Gestational Diabetes year")] public string his_Gestational_Diabetes_year { get; set; }
        [JsonProperty("his type1diabetes")] public string his_type1diabetes { get; set; }
        [JsonProperty("his type1diabetes year")] public string his_type1diabetes_year { get; set; }
        [JsonProperty("his highcholesterol")] public string his_highcholesterol { get; set; }
        [JsonProperty("his highcholesterol year")] public string his_highcholesterol_year { get; set; }
        [JsonProperty("his obesity")] public string his_obesity { get; set; }
        [JsonProperty("his obesity year")] public string his_obesity_year { get; set; }
        [JsonProperty("his heartdis")] public string his_heartdis { get; set; }
        [JsonProperty("his heartdis year")] public string his_heartdis_year { get; set; }
        [JsonProperty("his cancer")] public string his_cancer { get; set; }
        [JsonProperty("his cancer year")] public string his_cancer_year { get; set; }
        [JsonProperty("his osteoporosis")] public string his_osteoporosis { get; set; }
        [JsonProperty("his osteoporosis year")] public string his_osteoporosis_year { get; set; }
        [JsonProperty("his asthma")] public string his_asthma { get; set; }
        [JsonProperty("his asthma year")] public string his_asthma_year { get; set; }
        [JsonProperty("his Hypothyroidism")] public string his_Hypothyroidism { get; set; }
        [JsonProperty("his Hypothyroidism year")] public string his_Hypothyroidism_year { get; set; }
        [JsonProperty("his Hyperthyroidism")] public string his_Hyperthyroidism { get; set; }
        [JsonProperty("his Hyperthyroidism year")] public string his_Hyperthyroidism_year { get; set; }
        [JsonProperty("his Autoimmune")] public string his_Autoimmune { get; set; }
        [JsonProperty("his Autoimmune year")] public string his_Autoimmune_year { get; set; }
        [JsonProperty("his thyroid other")] public string his_thyroid_other { get; set; }
        [JsonProperty("his thyroid other text")] public string his_thyroid_other_text { get; set; }
        [JsonProperty("his thyroid year")] public string his_thyroid_year { get; set; }
        [JsonProperty("his liver")] public string his_liver { get; set; }
        [JsonProperty("his liver year")] public string his_liver_year { get; set; }
        [JsonProperty("his arthritis")] public string his_arthritis { get; set; }
        [JsonProperty("his arthritis year")] public string his_arthritis_year { get; set; }
        [JsonProperty("his hepatitis type")] public string his_hepatitis_type { get; set; }
        [JsonProperty("his hepatitis type b")] public string his_hepatitis_type_b { get; set; }
        [JsonProperty("his hepatitis year b")] public string his_hepatitis_year_b { get; set; }
        [JsonProperty("his hepatitis type c")] public string his_hepatitis_type_c { get; set; }
        [JsonProperty("his hepatitis c year")] public string his_hepatitis_c_year { get; set; }
        [JsonProperty("his hepatitis type d")] public string his_hepatitis_type_d { get; set; }
        [JsonProperty("his hepatitis d year")] public string his_hepatitis_d_year { get; set; }
        [JsonProperty("his hepatitis year")] public string his_hepatitis_year { get; set; }
        [JsonProperty("his Anxiety")] public string his_Anxiety { get; set; }
        [JsonProperty("his Anxiety year")] public string his_Anxiety_year { get; set; }
        [JsonProperty("his depression")] public string his_depression { get; set; }
        [JsonProperty("his depression year")] public string his_depression_year { get; set; }
        [JsonProperty("his Bipolar")] public string his_Bipolar { get; set; }
        [JsonProperty("his Bipolar year")] public string his_Bipolar_year { get; set; }
        [JsonProperty("his Schizophrenia")] public string his_Schizophrenia { get; set; }
        [JsonProperty("his Schizophrenia year")] public string his_Schizophrenia_year { get; set; }
        [JsonProperty("his PTSD")] public string his_PTSD { get; set; }
        [JsonProperty("his PTSD year")] public string his_PTSD_year { get; set; }
        [JsonProperty("his Alzheimer")] public string his_Alzheimer { get; set; }
        [JsonProperty("his Alzheimer year")] public string his_Alzheimer_year { get; set; }
        [JsonProperty("his Parkinson")] public string his_Parkinson { get; set; }
        [JsonProperty("his Parkinson year")] public string his_Parkinson_year { get; set; }
        [JsonProperty("his Epilepsy")] public string his_Epilepsy { get; set; }
        [JsonProperty("his Epilepsy year")] public string his_Epilepsy_year { get; set; }
        [JsonProperty("his Other neurological")] public string his_Other_neurological { get; set; }
        [JsonProperty("his Other neurological text")] public string his_Other_neurological_text { get; set; }
        [JsonProperty("his Other neurological year")] public string his_Other_neurological_year { get; set; }
        [JsonProperty("his Other Psychiatric disorder")] public string his_Other_Psychiatric_disorder { get; set; }
        [JsonProperty("his Other Psychiatric disorder specify")] public string his_Other_Psychiatric_disorder_specify { get; set; }
        [JsonProperty("his Other Psychiatric disorder year")] public string his_Other_Psychiatric_disorder_year { get; set; }
        [JsonProperty("his covid")] public string his_covid { get; set; }
        [JsonProperty("his covid PCR")] public string his_covid_PCR { get; set; }
        [JsonProperty("his covid19")] public string his_covid19 { get; set; }
        [JsonProperty("his covid1 Onset")] public string his_covid19_Onset { get; set; }
        [JsonProperty("his covid1 EndDate")] public string his_covid19_EndDate { get; set; }
        [JsonProperty("his covid1 Pneumonia")] public string his_covid19_Pneumonia { get; set; }
        [JsonProperty("his covid1 ARDS")] public string his_covid19_ARDS { get; set; }
        [JsonProperty("his covid1 ACX")] public string his_covid19_ACX { get; set; }
        [JsonProperty("his covid1 AbnormalECG")] public string his_covid19_AbnormalECG { get; set; }
        [JsonProperty("his covid1 MVI")] public string his_covid19_MVI { get; set; }
        [JsonProperty("his covid1 ECMO")] public string his_covid19_ECMO { get; set; }
        [JsonProperty("his hypertension specify")] public string his_hypertension_specify { get; set; }
        [JsonProperty("his Prediabetes specify")] public string his_Prediabetes_specify { get; set; }
        [JsonProperty("PMD Chronic gastrointestinal")] public string PMD_Chronic_gastrointestinal { get; set; }
        [JsonProperty("PMD Inflammatory bowel")] public string PMD_Inflammatory_bowel { get; set; }
        [JsonProperty("PMD Gastrointestinal ulcer")] public string PMD_Gastrointestinal_ulcer { get; set; }
        [JsonProperty("PMD Chronic liver")] public string PMD_Chronic_liver { get; set; }
        [JsonProperty("PMD Chronic pancreatitis")] public string PMD_Chronic_pancreatitis { get; set; }
        [JsonProperty("PMD Chronic kidney")] public string PMD_Chronic_kidney { get; set; }
        [JsonProperty("PMD Cholelithiasis")] public string PMD_Cholelithiasis { get; set; }
        [JsonProperty("PMD Endocrine disorders")] public string PMD_Endocrine_disorders { get; set; }
        [JsonProperty("PMD inflammation")] public string PMD_inflammation { get; set; }
        [JsonProperty("complications retinopathy")] public string complications_retinopathy { get; set; }
        [JsonProperty("complications neuropathy")] public string complications_neuropathy { get; set; }
        [JsonProperty("complications cva")] public string complications_cva { get; set; }
        [JsonProperty("complications neuropathy other")] public string complications_neuropathy_other { get; set; }
        [JsonProperty("complications No proliferative")] public string complications_No_proliferative { get; set; }
        [JsonProperty("complications proliferative")] public string complications_proliferative { get; set; }
        [JsonProperty("complications Laser")] public string complications_Laser { get; set; }
        [JsonProperty("complications Retinopathy other")] public string complications_Retinopathy_other { get; set; }
        [JsonProperty("complications foot")] public string complications_foot { get; set; }
        [JsonProperty("complications Gangrene")] public string complications_Gangrene { get; set; }
        [JsonProperty("complications numbness")] public string complications_numbness { get; set; }
        [JsonProperty("complications Amputation")] public string complications_Amputation { get; set; }
        [JsonProperty("complications Loss of toe")] public string complications_Loss_of_toe { get; set; }
        [JsonProperty("complications Pain in calfmuscles")] public string complications_Pain_in_calfmuscles { get; set; }
        [JsonProperty("complications Circulation peripheral vascular")] public string complications_Circulation_peripheral_vascular { get; set; }
        [JsonProperty("complications Retinopathy other other")] public string complications_Retinopathy_other_other { get; set; }
        [JsonProperty("complications tia")] public string complications_tia { get; set; }
        [JsonProperty("complications Stroke")] public string complications_Stroke { get; set; }
        [JsonProperty("complications onesidebody")] public string complications_onesidebody { get; set; }
        [JsonProperty("complications Bleeding")] public string complications_Bleeding { get; set; }
        [JsonProperty("complications Diff speaking")] public string complications_Diff_speaking { get; set; }
        [JsonProperty("complications Operation on artery")] public string complications_Operation_on_artery { get; set; }
        [JsonProperty("complications Facial drop")] public string complications_Facial_drop { get; set; }
        [JsonProperty("complications Paralyzedarm")] public string complications_Paralyzedarm { get; set; }
        [JsonProperty("complications Laser other")] public string complications_Laser_other { get; set; }
        [JsonProperty("complications albumin")] public string complications_albumin { get; set; }
        [JsonProperty("complications Albuminuria")] public string complications_Albuminuria { get; set; }
        [JsonProperty("complications 30 29mg 24h")] public string complications_30_29mg_24h { get; set; }
        [JsonProperty("complications 300 mg 24h")] public string complications_300_mg_24h { get; set; }
        [JsonProperty("complications egfr")] public string complications_egfr { get; set; }
        [JsonProperty("complications CABG")] public string complications_CABG { get; set; }
        [JsonProperty("complications PCI")] public string complications_PCI { get; set; }
        [JsonProperty("complications Arrhythmias")] public string complications_Arrhythmias { get; set; }
        [JsonProperty("complications nephropathy")] public string complications_nephropathy { get; set; }
        [JsonProperty("complications cad")] public string complications_cad { get; set; }
        [JsonProperty("complications other")] public string complications_other { get; set; }
        [JsonProperty("complications neuropathy other other")] public string complications_neuropathy_other_other { get; set; }
        [JsonProperty("complications Laser other other")] public string complications_Laser_other_other { get; set; }
        [JsonProperty("type2 egfr")] public string type2_egfr { get; set; }
        [JsonProperty("med hypertension")] public string med_hypertension { get; set; }
        [JsonProperty("med hypertension year")] public string med_hypertension_year { get; set; }
        [JsonProperty("med Prediabetes")] public string med_Prediabetes { get; set; }
        [JsonProperty("med Prediabetes year")] public string med_Prediabetes_year { get; set; }
        [JsonProperty("med type2diabetes")] public string med_type2diabetes { get; set; }
        [JsonProperty("med type2diabetes year")] public string med_type2diabetes_year { get; set; }
        [JsonProperty("med Gestational Diabetes")] public string med_Gestational_Diabetes { get; set; }
        [JsonProperty("med Gestational Diabetes year")] public string med_Gestational_Diabetes_year { get; set; }
        [JsonProperty("med type1diabetes")] public string med_type1diabetes { get; set; }
        [JsonProperty("med type1diabetes year")] public string med_type1diabetes_year { get; set; }
        [JsonProperty("med highcholesterol")] public string med_highcholesterol { get; set; }
        [JsonProperty("med highcholesterol year")] public string med_highcholesterol_year { get; set; }
        [JsonProperty("med obesity")] public string med_obesity { get; set; }
        [JsonProperty("med obesity year")] public string med_obesity_year { get; set; }
        [JsonProperty("med heartdis")] public string med_heartdis { get; set; }
        [JsonProperty("med heartdis year")] public string med_heartdis_year { get; set; }
        [JsonProperty("med cancer")] public string med_cancer { get; set; }
        [JsonProperty("med cancer year")] public string med_cancer_year { get; set; }
        [JsonProperty("med osteoporosis")] public string med_osteoporosis { get; set; }
        [JsonProperty("med osteoporosis year")] public string med_osteoporosis_year { get; set; }
        [JsonProperty("med asthma")] public string med_asthma { get; set; }
        [JsonProperty("med asthma year")] public string med_asthma_year { get; set; }
        [JsonProperty("med Hypothyroidism")] public string med_Hypothyroidism { get; set; }
        [JsonProperty("med Hypothyroidism year")] public string med_Hypothyroidism_year { get; set; }
        [JsonProperty("med Hyperthyroidism")] public string med_Hyperthyroidism { get; set; }
        [JsonProperty("med Hyerthyroidism year")] public string med_Hyerthyroidism_year { get; set; }
        [JsonProperty("med Autoimmune")] public string med_Autoimmune { get; set; }
        [JsonProperty("med Autoimmune year")] public string med_Autoimmune_year { get; set; }
        [JsonProperty("med thyroid other text")] public string med_thyroid_other_text { get; set; }
        [JsonProperty("med thyroid year")] public string med_thyroid_year { get; set; }
        [JsonProperty("med liver")] public string med_liver { get; set; }
        [JsonProperty("med liver year")] public string med_liver_year { get; set; }
        [JsonProperty("med arthritis")] public string med_arthritis { get; set; }
        [JsonProperty("med arthritis year")] public string med_arthritis_year { get; set; }
        [JsonProperty("med hepatitis type")] public string med_hepatitis_type { get; set; }
        [JsonProperty("med hepatitis type b")] public string med_hepatitis_type_b { get; set; }
        [JsonProperty("med hepatitis b year")] public string med_hepatitis_b_year { get; set; }
        [JsonProperty("med hepatitis type c")] public string med_hepatitis_type_c { get; set; }
        [JsonProperty("med hepatitis c year")] public string med_hepatitis_c_year { get; set; }
        [JsonProperty("med hepatitis type d")] public string med_hepatitis_type_d { get; set; }
        [JsonProperty("med hepatitis d year")] public string med_hepatitis_d_year { get; set; }
        [JsonProperty("med hepatitis year")] public string med_hepatitis_year { get; set; }
        [JsonProperty("med Anxiety")] public string med_Anxiety { get; set; }
        [JsonProperty("med Anxiety year")] public string med_Anxiety_year { get; set; }
        [JsonProperty("med depression")] public string med_depression { get; set; }
        [JsonProperty("med depression year")] public string med_depression_year { get; set; }
        [JsonProperty("med Bipolar")] public string med_Bipolar { get; set; }
        [JsonProperty("med Bipolar year")] public string med_Bipolar_year { get; set; }
        [JsonProperty("med Schizophrenia")] public string med_Schizophrenia { get; set; }
        [JsonProperty("med Schizophrenia year")] public string med_Schizophrenia_year { get; set; }
        [JsonProperty("med PTSD")] public string med_PTSD { get; set; }
        [JsonProperty("med PTSD year")] public string med_PTSD_year { get; set; }
        [JsonProperty("med Psychiatric other")] public string med_Psychiatric_other { get; set; }
        [JsonProperty("med Psychiatric other specify")] public string med_Psychiatric_other_specify { get; set; }
        [JsonProperty("med Psychiatric other year")] public string med_Psychiatric_other_year { get; set; }
        [JsonProperty("med Alzheimer")] public string med_Alzheimer { get; set; }
        [JsonProperty("med Alzheimer year")] public string med_Alzheimer_year { get; set; }
        [JsonProperty("med Parkinson")] public string med_Parkinson { get; set; }
        [JsonProperty("med Parkinson year")] public string med_Parkinson_year { get; set; }
        [JsonProperty("med Epilepsy")] public string med_Epilepsy { get; set; }
        [JsonProperty("med Epilepsy year")] public string med_Epilepsy_year { get; set; }
        [JsonProperty("med Other neurological")] public string med_Other_neurological { get; set; }
        [JsonProperty("med Other neurological text")] public string med_Other_neurological_text { get; set; }
        [JsonProperty("med Other neurological year")] public string med_Other_neurological_year { get; set; }
        [JsonProperty("med inheriteddis")] public string med_inheriteddis { get; set; }
        [JsonProperty("med inheriteddis text")] public string med_inheriteddis_text { get; set; }
        [JsonProperty("med inheriteddis year")] public string med_inheriteddis_year { get; set; }
        [JsonProperty("med inherited disease")] public string med_inherited_disease { get; set; }
        [JsonProperty("med inherited disease specify")] public string med_inherited_disease_specify { get; set; }
        [JsonProperty("med inherited disease year")] public string med_inherited_disease_year { get; set; }
        [JsonProperty("med other")] public string med_other { get; set; }
        [JsonProperty("med other specify")] public string med_other_specify { get; set; }
        [JsonProperty("med other year")] public string med_other_year { get; set; }
        [JsonProperty("allergies")] public string allergies { get; set; }
        [JsonProperty("allergies yestxt")] public string allergies_yestxt { get; set; }
        [JsonProperty("intolerance")] public string intolerance { get; set; }
        [JsonProperty("intolerance yestxt")] public string intolerance_yestxt { get; set; }
        [JsonProperty("med surgery")] public string med_surgery { get; set; }
        [JsonProperty("med surgery yestxt")] public string med_surgery_yestxt { get; set; }
        [JsonProperty("med surgery year")] public string med_surgery_year { get; set; }
        [JsonProperty("medication hypertension")] public string medication_hypertension { get; set; }
        [JsonProperty("medication hypertension specify")] public string medication_hypertension_specify { get; set; }
        [JsonProperty("medication hypertension year")] public string medication_hypertension_year { get; set; }
        [JsonProperty("medication Prediabetes")] public string medication_Prediabetes { get; set; }
        [JsonProperty("medication Prediabetes specify")] public string medication_Prediabetes_specify { get; set; }
        [JsonProperty("medication Prediabetes year")] public string medication_Prediabetes_year { get; set; }
        [JsonProperty("medication type1")] public string medication_type1 { get; set; }
        [JsonProperty("medication type1 specify")] public string medication_type1_specify { get; set; }
        [JsonProperty("medication type1 year")] public string medication_type1_year { get; set; }
        [JsonProperty("medication type2")] public string medication_type2 { get; set; }
        [JsonProperty("medication type2 specify")] public string medication_type2_specify { get; set; }
        [JsonProperty("medication type2 year")] public string medication_type2_year { get; set; }
        [JsonProperty("medication choles")] public string medication_choles { get; set; }
        [JsonProperty("medication choles specify")] public string medication_choles_specify { get; set; }
        [JsonProperty("medication choles year")] public string medication_choles_year { get; set; }
        [JsonProperty("medication obe")] public string medication_obe { get; set; }
        [JsonProperty("medication obe specify")] public string medication_obe_specify { get; set; }
        [JsonProperty("medication obe year")] public string medication_obe_year { get; set; }
        [JsonProperty("medication heart")] public string medication_heart { get; set; }
        [JsonProperty("medication heart specify")] public string medication_heart_specify { get; set; }
        [JsonProperty("medication heart year")] public string medication_heart_year { get; set; }
        [JsonProperty("medication cancer")] public string medication_cancer { get; set; }
        [JsonProperty("medication cancer specify")] public string medication_cancer_specify { get; set; }
        [JsonProperty("medication cancer year")] public string medication_cancer_year { get; set; }
        [JsonProperty("medication Anxiety")] public string medication_Anxiety { get; set; }
        [JsonProperty("medication Anxiety specify")] public string medication_Anxiety_specify { get; set; }
        [JsonProperty("medication Anxiety year")] public string medication_Anxiety_year { get; set; }
        [JsonProperty("medication dep")] public string medication_dep { get; set; }
        [JsonProperty("medication dep specify")] public string medication_dep_specify { get; set; }
        [JsonProperty("medication dep year")] public string medication_dep_year { get; set; }
        [JsonProperty("medication Bipolar")] public string medication_Bipolar { get; set; }
        [JsonProperty("medication Bipolar specify")] public string medication_Bipolar_specify { get; set; }
        [JsonProperty("medication Bipolar year")] public string medication_Bipolar_year { get; set; }
        [JsonProperty("medication Schizophrenia")] public string medication_Schizophrenia { get; set; }
        [JsonProperty("medication Schizophrenia specify")] public string medication_Schizophrenia_specify { get; set; }
        [JsonProperty("medication Schizophrenia year")] public string medication_Schizophrenia_year { get; set; }
        [JsonProperty("medication PTSD")] public string medication_PTSD { get; set; }
        [JsonProperty("medication PTSD specify")] public string medication_PTSD_specify { get; set; }
        [JsonProperty("medication PTSD year")] public string medication_PTSD_year { get; set; }
        [JsonProperty("medication Other Psychiatric disorder")] public string medication_Other_Psychiatric_disorder { get; set; }
        [JsonProperty("medication Other Psychiatric disorder specify")] public string medication_Other_Psychiatric_disorder_specify { get; set; }
        [JsonProperty("medication Other Psychiatric disorder year")] public string medication_Other_Psychiatric_disorder_year { get; set; }
        [JsonProperty("medication osteo")] public string medication_osteo { get; set; }
        [JsonProperty("medication osteo specify")] public string medication_osteo_specify { get; set; }
        [JsonProperty("medication osteo year")] public string medication_osteo_year { get; set; }
        [JsonProperty("medication asth")] public string medication_asth { get; set; }
        [JsonProperty("medication asth specify")] public string medication_asth_specify { get; set; }
        [JsonProperty("medication asth year")] public string medication_asth_year { get; set; }
        [JsonProperty("medication Endocrine disorders")] public string medication_Endocrine_disorders { get; set; }
        [JsonProperty("medication Endocrine disorders specify")] public string medication_Endocrine_disorders_specify { get; set; }
        [JsonProperty("medication Endocrine disorders year")] public string medication_Endocrine_disorders_year { get; set; }
        [JsonProperty("medication migraine")] public string medication_migraine { get; set; }
        [JsonProperty("medication migraine specify")] public string medication_migraine_specify { get; set; }
        [JsonProperty("medication migraine year")] public string medication_migraine_year { get; set; }
        [JsonProperty("medication Alzheimer")] public string medication_Alzheimer { get; set; }
        [JsonProperty("medication Alzheimer specify")] public string medication_Alzheimer_specify { get; set; }
        [JsonProperty("medication Alzheimer year")] public string medication_Alzheimer_year { get; set; }
        [JsonProperty("medication Parkinson")] public string medication_Parkinson { get; set; }
        [JsonProperty("medication Parkinson specify")] public string medication_Parkinson_specify { get; set; }
        [JsonProperty("medication Parkinson year")] public string medication_Parkinson_year { get; set; }
        [JsonProperty("medication Epilepsy")] public string medication_Epilepsy { get; set; }
        [JsonProperty("medication Epilepsy specify")] public string medication_Epilepsy_specify { get; set; }
        [JsonProperty("medication Epilepsy year")] public string medication_Epilepsy_year { get; set; }
        [JsonProperty("medication Other neurological")] public string medication_Other_neurological { get; set; }
        [JsonProperty("medication Other neurological specify")] public string medication_Other_neurological_specify { get; set; }
        [JsonProperty("medication Other neurological year")] public string medication_Other_neurological_year { get; set; }
        [JsonProperty("medication Other")] public string medication_Other { get; set; }
        [JsonProperty("medication Other specify")] public string medication_Other_specify { get; set; }
        [JsonProperty("medication Other year")] public string medication_Other_year { get; set; }
        [JsonProperty("medication none")] public string medication_none { get; set; }
        [JsonProperty("medication Supplements")] public string medication_Supplements { get; set; }
        [JsonProperty("donot take medication specify")] public string donot_take_medication_specify { get; set; }
        [JsonProperty("donot take medication year")] public string donot_take_medication_year { get; set; }
        [JsonProperty("covid")] public string covid { get; set; }
        [JsonProperty("flu")] public string flu { get; set; }
        [JsonProperty("medication Supplements specify")] public string medication_Supplements_specify { get; set; }
        [JsonProperty("medication Supplements year")] public string medication_Supplements_year { get; set; }
        [JsonProperty("med vaccine")] public string med_vaccine { get; set; }
        [JsonProperty("med flushot")] public string med_flushot { get; set; }
        [JsonProperty("med diagnosed type2diabetes")] public string med_diagnosed_type2diabetes { get; set; }
        [JsonProperty("med diagnosed type2diabetes year")] public string med_diagnosed_type2diabetes_year { get; set; }
        [JsonProperty("med diagnosed med Prediabetes")] public string med_diagnosed_med_Prediabetes { get; set; }
        [JsonProperty("med diagnosed med Prediabetes year")] public string med_diagnosed_med_Prediabetes_year { get; set; }
        [JsonProperty("med covid19")] public string med_covid19 { get; set; }
        [JsonProperty("med covid1 Onset")] public string med_covid19_Onset { get; set; }
        [JsonProperty("med covid1 EndDate")] public string med_covid19_EndDate { get; set; }
        [JsonProperty("med covid1 Headache")] public string med_covid19_Headache { get; set; }
        [JsonProperty("med covid1 temperature")] public string med_covid19_temperature { get; set; }
        [JsonProperty("med covid1 Cough")] public string med_covid19_Cough { get; set; }
        [JsonProperty("med covid1 SoreThroat")] public string med_covid19_SoreThroat { get; set; }
        [JsonProperty("med covid1 Weakness")] public string med_covid19_Weakness { get; set; }
        [JsonProperty("med covid1 Lossofsmell")] public string med_covid19_Lossofsmell { get; set; }
        [JsonProperty("med covid1 Shortnessofbreath")] public string med_covid19_Shortnessofbreath { get; set; }
        [JsonProperty("med covid1 Runningnose")] public string med_covid19_Runningnose { get; set; }
        [JsonProperty("med covid1 Nausea")] public string med_covid19_Nausea { get; set; }
        [JsonProperty("med covid1 Musclepain")] public string med_covid19_Musclepain { get; set; }
        [JsonProperty("med covid1 Diarrhea")] public string med_covid19_Diarrhea { get; set; }
        [JsonProperty("med covid1 Lossoftaste")] public string med_covid19_Lossoftaste { get; set; }
        [JsonProperty("med hypertension specify")] public string med_hypertension_specify { get; set; }
        [JsonProperty("med Prediabetes specify")] public string med_Prediabetes_specify { get; set; }
        [JsonProperty("med type1diabetes specify")] public string med_type1diabetes_specify { get; set; }
        [JsonProperty("med type2diabetes specify")] public string med_type2diabetes_specify { get; set; }
        [JsonProperty("med highcholesterol specify")] public string med_highcholesterol_specify { get; set; }
        [JsonProperty("med obesity specify")] public string med_obesity_specify { get; set; }
        [JsonProperty("med heartdis specify")] public string med_heartdis_specify { get; set; }
        [JsonProperty("med cancer Specify")] public string med_cancer_Specify { get; set; }
        [JsonProperty("med Anxiety Specify")] public string med_Anxiety_Specify { get; set; }
        [JsonProperty("med depression Specify")] public string med_depression_Specify { get; set; }
        [JsonProperty("med Schizophrenia Specify")] public string med_Schizophrenia_Specify { get; set; }
        [JsonProperty("med PTSD Specify")] public string med_PTSD_Specify { get; set; }
        [JsonProperty("med Bipolar Specify")] public string med_Bipolar_Specify { get; set; }
        [JsonProperty("med osteoporosis Specify")] public string med_osteoporosis_Specify { get; set; }
        [JsonProperty("med asthma Specify")] public string med_asthma_Specify { get; set; }
        [JsonProperty("med vaccine Specify")] public string med_vaccine_Specify { get; set; }
        [JsonProperty("med vaccine Year")] public string med_vaccine_Year { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
