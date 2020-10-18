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
        [JsonProperty("Sample Id")] public string sample { get; set; }
        [JsonProperty("Project Title")] public string projecttitle { get; set; }
        [JsonProperty("Principal Investigator")] public string principalinvestigator { get; set; }
        [JsonProperty("Collection Point")] public string collection_point { get; set; }
        [JsonProperty("Date Of Collection")] public string collected_date { get; set; }
        [JsonProperty("Gender")] public string gender { get; set; }
        [JsonProperty("Age")] public string age { get; set; }
        [JsonProperty("Date Of Birth")] public string dob { get; set; }
        [JsonProperty("Nationality")] public string nationality { get; set; }
        [JsonProperty("Placeofbirth")] public string PlaceOfBirth { get; set; }
        [JsonProperty("City")] public string city { get; set; }
        [JsonProperty("Ethnicity")] public string ethnicity { get; set; }
        [JsonProperty("Ethnicity Others")] public string ethnicity_others_text { get; set; }
        [JsonProperty("Marital Status")] public string maritalstatus { get; set; }
        [JsonProperty("Number Of Wives")] public string pers_Numberofwives { get; set; }
        [JsonProperty("Consanguineous")] public string marriage_con { get; set; }
        [JsonProperty("Number Of Children")] public string pers_NumberofChildren { get; set; }
        [JsonProperty("Boys")] public string pers_Boys { get; set; }
        [JsonProperty("Girls")] public string pers_Girls { get; set; }
        [JsonProperty("Children Not Applicable")] public string pers_BoysGirls { get; set; }
        [JsonProperty("Highest Grade")] public string eduGradel { get; set; }
        [JsonProperty("Highest Degree")] public string eduLevel { get; set; }
        [JsonProperty("Household Living")] public string household { get; set; }
        [JsonProperty("Household Living Children <=18")] public string household_minor { get; set; }
        [JsonProperty("Own Primary Residence")] public string ownresidence { get; set; }
        [JsonProperty("Current Employment Status")] public string employment_status { get; set; }
        [JsonProperty("Kind Of Work")] public string employment_work { get; set; }
        [JsonProperty("Night Shift")] public string employment_nightshift { get; set; }
        [JsonProperty("Night Shift Others")] public string employment_nightshift_others { get; set; }
        [JsonProperty("Health Past 4 Weeks")] public string health_overall_4weeks { get; set; }
        [JsonProperty("Physical Problem Past 4 Weeks")] public string health_physical_problem_4weeks { get; set; }
        [JsonProperty("Difficulty Past 4 Weeks")] public string health_difficulty_4weeks { get; set; }
        [JsonProperty("Body Pain Past 4 Weeks")] public string health_body_pain_4weeks { get; set; }
        [JsonProperty("Energy Past 4 Weeks")] public string health_energy_4weeks { get; set; }
        [JsonProperty("Emotional Problems Past 4 Weeks")] public string health_emotional_problems_4weeks { get; set; }
        [JsonProperty("Bothered Emotional Problems Past 4 Weeks")] public string health_bothered_emotional_problems_4weeks { get; set; }
        [JsonProperty("Bothered Emotional Problems  Affect Work Past 4 Weeks")] public string health_bothered_emotional_problems_affect_4weeks { get; set; }
        [JsonProperty("Brush Teeth Twice Past 4 Weeks")] public string health_brushteethtwice_4weeks { get; set; }
        [JsonProperty("Weight Change Past Year")] public string health_weight_change { get; set; }
        [JsonProperty("Special Diet Past 4 Weeks")] public string health_special_diet_4weeks { get; set; }
        [JsonProperty("Bowel Movements Past 4 Weeks")] public string health_bowel_movement_4weeks { get; set; }
        [JsonProperty("Urinate Past 4 Weeks")] public string health_urinate_4weeks { get; set; }
        [JsonProperty("Night Urinate Past 4 Weeks")] public string health_urinate_night_4weeks { get; set; }
        [JsonProperty("Contact Primary Care Provider Past Year")] public string health_advcontact { get; set; }
        [JsonProperty("Emergency Room Past 3 Months")] public string health_emergency { get; set; }
        [JsonProperty("Emergency Room Reason")] public string health_emergency_reason { get; set; }
        [JsonProperty("Admitted Hospital Past 3 Months")] public string health_hospital { get; set; }
        [JsonProperty("Admitted  Hospital Reason")] public string health_hospital_reason { get; set; }
        [JsonProperty("Health Advice - No One")] public string health_advice_noone { get; set; }
        [JsonProperty("Health Advice - Dietitian")] public string health_advice_Dietitian { get; set; }
        [JsonProperty("Health Advice - Nurse")] public string health_advice_Nurse { get; set; }
        [JsonProperty("Health Advice - General Practitioner")] public string health_advice_GP { get; set; }
        [JsonProperty("Health Advice - Pharmacist")] public string health_advice_Pharmacist { get; set; }
        [JsonProperty("Health Advice - Diabetes Specialist")] public string health_advice_Diabetes_specialist { get; set; }
        [JsonProperty("Health Advice - Others")] public string health_advice_others { get; set; }
        [JsonProperty("Health Advice - Remarks")] public string health_advice_others_remarks { get; set; }
        [JsonProperty("Annual Medical Checkup")] public string health_annual_medical_checkup { get; set; }
        [JsonProperty("First Period Year")] public string female_first_period { get; set; }
        [JsonProperty("First Period Year Others")] public string female_first_period_others { get; set; }
        [JsonProperty("Menopause")] public string female_menopause { get; set; }
        [JsonProperty("Menopause Since")] public string female_menopause_others { get; set; }
        [JsonProperty("Period Days")] public string female_period_days { get; set; }
        [JsonProperty("How Often  Period")] public string female_period_How_often { get; set; }
        [JsonProperty("How Often  Period Others")] public string female_period_How_often_others { get; set; }
        [JsonProperty("Period Regular Time Intervals")] public string female_period_regular_time_intervals { get; set; }
        [JsonProperty("Period Regular Time Intervals Yes")] public string female_period_regular_time_intervals_yes { get; set; }
        [JsonProperty("Period Regular Time Intervals No")] public string female_period_regular_time_intervals_no { get; set; }
        [JsonProperty("Pregnant")] public string female_pregnant { get; set; }
        [JsonProperty("Pregnant When")] public string female_pregnant_when { get; set; }
        [JsonProperty("Birth Control")] public string female_birth_control { get; set; }
        [JsonProperty("Birth Control When")] public string female_birth_control_when { get; set; }
        [JsonProperty("Birth Control Which Medication")] public string female_birth_control_Which_medication { get; set; }
        [JsonProperty("Birth Control Dose")] public string female_birth_control_dose { get; set; }
        [JsonProperty("Excessive Body Or Facial Hair")] public string female_facial_hair { get; set; }
        [JsonProperty("Fg Scoring System Points")] public string female_fg_points { get; set; }
        [JsonProperty("Vigorous Physical Activities")] public string PPA_vigorous_physical_activities { get; set; }
        [JsonProperty("Vigorous Physical Activities Time")] public string PPA_vigorous_physical_activities_time { get; set; }
        [JsonProperty("Moderate Physical Activities")] public string PPA_moderate_physical_activities { get; set; }
        [JsonProperty("Moderate Physical Activities Time")] public string PPA_moderate_physical_activities_time { get; set; }
        [JsonProperty("Walk Minium 10 Mins")] public string PPA_walk { get; set; }
        [JsonProperty("Walk Time")] public string PPA_walk_time { get; set; }
        [JsonProperty("Sitting On A Week Day")] public string PPA_sit { get; set; }
        [JsonProperty("Work Last 7 Days")] public string PPA_work { get; set; }
        [JsonProperty("Get Into Bed Hour")] public string PPA_getintobed_hour { get; set; }
        [JsonProperty("Get Into Bed Minute")] public string PPA_getintobed_minute { get; set; }
        [JsonProperty("Get Into Bed Am/Pm")] public string PPA_getintobed_AMPM { get; set; }
        [JsonProperty("Get Out Bed Hour")] public string PPA_getoutbed_hour { get; set; }
        [JsonProperty("Get Out Bed Minute")] public string PPA_getoutbed_minute { get; set; }
        [JsonProperty("Get Out Bed Am/Pm")] public string PPA_getoutbed_AMPM { get; set; }
        [JsonProperty("Start Work Hour")] public string PPA_startwork_hour { get; set; }
        [JsonProperty("Start Work Minute")] public string PPA_startwork_minute { get; set; }
        [JsonProperty("Start Work Am/Pm")] public string PPA_startwork_AMPM { get; set; }
        [JsonProperty("Leave Work Hour")] public string PPA_leavework_hour { get; set; }
        [JsonProperty("Leave Work Minute")] public string PPA_leavework_minute { get; set; }
        [JsonProperty("Leave Work Am/Pm")] public string PPA_leavework_AMPM { get; set; }
        [JsonProperty("Work Hours Your Desk %")] public string PPA_workhours_yourdeskperc { get; set; }
        [JsonProperty("Work Hours Away From Desk %")] public string PPA_workhours_awaydeskperc { get; set; }
        [JsonProperty("Work Hours Sitting Your Desk %")] public string PPA_workhours_yourdeskperc_sitting { get; set; }
        [JsonProperty("Work Hours Standing Your Desk %")] public string PPA_workhours_yourdeskperc_standing { get; set; }
        [JsonProperty("Work Hours Moving Your Desk %")] public string PPA_workhours_yourdeskperc_moving { get; set; }
        [JsonProperty("Work Hours Sitting Away Desk %")] public string PPA_workhours_awaydeskperc_sitting { get; set; }
        [JsonProperty("Work Hours Standing Away Desk %")] public string PPA_workhours_awaydeskperc_standing { get; set; }
        [JsonProperty("Work Hours Moving Away Desk %")] public string PPA_workhours_awaydeskperc_moving { get; set; }
        [JsonProperty("Sit Transport Non Work Hours")] public string PPA_sit_transport_nonworkhours_hours { get; set; }
        [JsonProperty("Sit Transport Non Work Minutes")] public string PPA_sit_transport_nonworkhours_mininutes { get; set; }
        [JsonProperty("Sit Transport Non Workdays Hours")] public string PPA_sit_transport_nonwork_hours { get; set; }
        [JsonProperty("Sit Transort Non Workdays Minutes")] public string PPA_sit_transport_nonwork_mininutes { get; set; }
        [JsonProperty("Sit Tv Non Work Hours")] public string PPA_sit_tv_nonworkhours_hours { get; set; }
        [JsonProperty("Sit Tv Non Work Minutes")] public string PPA_sit_tv_nonworkhours_mininutes { get; set; }
        [JsonProperty("Sit Tv Non Workdays Hours")] public string PPA_sit_tv_nonwork_hours { get; set; }
        [JsonProperty("Sit Tv Non Workdays Minutes")] public string PPA_sit_tv_nonwork_mininutes { get; set; }
        [JsonProperty("Sit Computer Non Work Hours")] public string PPA_sit_computer_nonworkhours_hours { get; set; }
        [JsonProperty("Sit Computer Non Work Minutes")] public string PPA_sit_computer_nonworkhours_mininutes { get; set; }
        [JsonProperty("Sit Computer Non Workdays Hours")] public string PPA_sit_computer_nonwork_hours { get; set; }
        [JsonProperty("Sit Computer Non Workdays Minutes")] public string PPA_sit_computer_nonwork_mininutes { get; set; }
        [JsonProperty("Sit Others Non Work Hours")] public string PPA_sit_others_nonworkhours_hours { get; set; }
        [JsonProperty("Sit Others Non Work Minutes")] public string PPA_sit_others_nonworkhours_mininutes { get; set; }
        [JsonProperty("Sit Others Non Workdays Hours")] public string PPA_sit_others_nonwork_hours { get; set; }
        [JsonProperty("Sit Others Non Workdays Minutes")] public string PPA_sit_others_nonwork_mininutes { get; set; }
        [JsonProperty("Eat A Portion Of Vegetables")] public string PD_eat_vegetables { get; set; }
        [JsonProperty("Eat A Portion Of Fruit")] public string PD_eat_fruit { get; set; }
        [JsonProperty("Eat  Cake")] public string PD_eat_cake { get; set; }
        [JsonProperty("Eat  Sugary Drinks")] public string PD_eat_sugary_drinks { get; set; }
        [JsonProperty("Eat  Full Fat Spread")] public string PD_eat_fullfat_spread { get; set; }
        [JsonProperty("Eat  Full Fat Cheese")] public string PD_eat_fullfat_cheese { get; set; }
        [JsonProperty("Eat Processed Meat")] public string PD_eat_processed_meat { get; set; }
        [JsonProperty("Eat Savory Food")] public string PD_eat_savory_food { get; set; }
        [JsonProperty("Eat Savory Pastry")] public string PD_eat_savory_pastry { get; set; }
        [JsonProperty("Eat Fast Food")] public string PD_eat_fast_food { get; set; }
        [JsonProperty("Prepare Meal At Home")] public string PD_eat_meal_at_home { get; set; }
        [JsonProperty("Eat Pudding")] public string PD_eat_pudding { get; set; }
        [JsonProperty("Eat Oily Fish")] public string PD_eat_oilyfish { get; set; }
        [JsonProperty("Eat Regular Meals")] public string PD_eat_regular_meals { get; set; }
        [JsonProperty("Eat Breakfast")] public string PD_eat_breakfast { get; set; }
        [JsonProperty("Eat Snack Between Meals")] public string PD_eat_snack_between_meals { get; set; }
        [JsonProperty("Eat Portion Of Bread")] public string PD_eat_portion_bread { get; set; }
        [JsonProperty("Eat High Fiber Bread")] public string PD_eat_highfiber_bread { get; set; }
        [JsonProperty("Eat Bowl Of Breakfast")] public string PD_eat_bowl_breakfast { get; set; }
        [JsonProperty("Eat High Fiber Cereals")] public string PD_eat_bowl_highfiber { get; set; }
        [JsonProperty("Eat Milk Type")] public string PD_milk_type { get; set; }
        [JsonProperty("Eat Milk Type  Others")] public string PD_milk_type_others { get; set; }
        [JsonProperty("Weight Concern")] public string PD_weight_concern { get; set; }
        [JsonProperty("Important Change Diet")] public string PD_important_change_diet { get; set; }
        [JsonProperty("Confident Change Diet")] public string PD_confident_change_diet { get; set; }
        [JsonProperty("Unable To Control Important Things")] public string PSE_unable_to_control { get; set; }
        [JsonProperty("Handle Personal Problems")] public string PSE_handle_problem { get; set; }
        [JsonProperty("Things Going Your Way")] public string PSE_yourway { get; set; }
        [JsonProperty("Difficultly Handle Personal Problems")] public string PSE_difficulty_handle_problem { get; set; }
        [JsonProperty("Little Interest")] public string PSE_little_interest { get; set; }
        [JsonProperty("Depressed")] public string PSE_depressed { get; set; }
        [JsonProperty("Sleeping Toomuch")] public string PSE_sleeping_toomuch { get; set; }
        [JsonProperty("Little Energy")] public string PSE_little_energy { get; set; }
        [JsonProperty("Poor Apetitite Or Overeating")] public string PSE_overeating { get; set; }
        [JsonProperty("Feeling Bad")] public string PSE_feelingbad { get; set; }
        [JsonProperty("Concentrating  Trouble")] public string PSE_concentrating_trouble { get; set; }
        [JsonProperty("Fidgery Or Restless")] public string PSE_restless { get; set; }
        [JsonProperty("Thought Of Dead")] public string PSE_dead_thoughts { get; set; }
        [JsonProperty("Get Along With Others")] public string PSE_get_along { get; set; }
        [JsonProperty("Diffculty Falling Asleep")] public string PSH_falling_asleep { get; set; }
        [JsonProperty("Diffculty Staying Asleep")] public string PSH_staying_asleep { get; set; }
        [JsonProperty("Wakeup Too Early")] public string PSH_wakeup_tooearly { get; set; }
        [JsonProperty("Satisfied_Sleep_Pattern")] public string PSH_satisfied_sleep_pattern { get; set; }
        [JsonProperty("Noticeable Sleeping Problem")] public string PSH_noticeable_sleeping_problem { get; set; }
        [JsonProperty("Worried Sleeping Problem")] public string PSH_worried_sleeping_problem { get; set; }
        [JsonProperty("Interfere Sleeping Problem")] public string PSH_interfere_sleeping_problem { get; set; }
        [JsonProperty("Smoked 100 Cigarettes")] public string PSS_smoked_100_cigarettes { get; set; }
        [JsonProperty("First Smoke Age")] public string PSS_first_smoke_age { get; set; }
        [JsonProperty("Current Smoker")] public string PSS_current_smoker { get; set; }
        [JsonProperty("Quit_Smoking")] public string PSS_quit_smoking { get; set; }
        [JsonProperty("Average Cigarettes  Per Day")] public string PSS_avg_cigarettes_perday { get; set; }
        [JsonProperty("Cigarettes  Past 30 Days")] public string PSS_cigarettes_30days { get; set; }
        [JsonProperty("Average Cigarettes  Past 30 Days")] public string PSS_avg_cigarettes_30days { get; set; }
        [JsonProperty("Trying To Quit Smoke")] public string PSS_trying_quit_smoke { get; set; }
        [JsonProperty("Hypertension")] public string med_hypertension { get; set; }
        [JsonProperty("Hypertension Year")] public string med_hypertension_year { get; set; }
        [JsonProperty("Prediabetes")] public string med_Prediabetes { get; set; }
        [JsonProperty("Prediabetes Year")] public string med_Prediabetes_year { get; set; }
        [JsonProperty("Type 2 Diabetes")] public string med_type2diabetes { get; set; }
        [JsonProperty("Type 2 Diabetes Year")] public string med_type2diabetes_year { get; set; }
        [JsonProperty("Gestational Diabetes")] public string med_Gestational_Diabetes { get; set; }
        [JsonProperty("Gestational Diabetes  Year")] public string med_Gestational_Diabetes_year { get; set; }
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
        [JsonProperty("Osteoporosis")] public string med_osteoporosis { get; set; }
        [JsonProperty("Osteoporosis Year")] public string med_osteoporosis_year { get; set; }
        [JsonProperty("Asthma")] public string med_asthma { get; set; }
        [JsonProperty("Asthma Year")] public string med_asthma_year { get; set; }
        [JsonProperty("Thyroid Other Problem")] public string med_thyroid_other { get; set; }
        [JsonProperty("Thyroid Problem Year")] public string med_thyroid_year { get; set; }
        [JsonProperty("Liver Disease")] public string med_liver { get; set; }
        [JsonProperty("Liver Disease Year")] public string med_liver_year { get; set; }
        [JsonProperty("Arthritis Rheumatism")] public string med_arthritis { get; set; }
        [JsonProperty("Arthritis Rheumatism Year")] public string med_arthritis_year { get; set; }
        [JsonProperty("Hepatitis A-B-C-D")] public string med_hepatitis { get; set; }
        [JsonProperty("Hepatitis A-B-C-D Year")] public string med_hepatitis_year { get; set; }
        [JsonProperty("Anxiety")] public string med_Anxiety { get; set; }
        [JsonProperty("Anxiety  Year")] public string med_Anxiety_year { get; set; }
        [JsonProperty("Depression")] public string med_depression { get; set; }
        [JsonProperty("Depression Year")] public string med_depression_year { get; set; }
        [JsonProperty("Bipolar Disorder")] public string med_Bipolar { get; set; }
        [JsonProperty("Bipolar Disorder Year")] public string med_Bipolar_year { get; set; }
        [JsonProperty("Schizophrenia")] public string med_Schizophrenia { get; set; }
        [JsonProperty("Schizophrenia Year")] public string med_Schizophrenia_year { get; set; }
        [JsonProperty("Post-Traumatic Stress Disorder")] public string med_PTSD { get; set; }
        [JsonProperty("Post-Traumatic Stress Disorder  Year")] public string med_PTSD_year { get; set; }
        [JsonProperty("Psychiatric Disorder Others")] public string med_Psychiatric_other { get; set; }
        [JsonProperty("Psychiatric Disorder Others Name")] public string med_Psychiatric_other_specify { get; set; }
        [JsonProperty("Psychiatric Disorder Others Year")] public string med_Psychiatric_other_year { get; set; }
        [JsonProperty("Alzheimer  Disease")] public string med_Alzheimer { get; set; }
        [JsonProperty("Alzheimer  Disease Year")] public string med_Alzheimer_year { get; set; }
        [JsonProperty("Parkinson  Disease")] public string med_Parkinson { get; set; }
        [JsonProperty("Parkinson Disease Year")] public string med_Parkinson_year { get; set; }
        [JsonProperty("Epilepsy")] public string med_Epilepsy { get; set; }
        [JsonProperty("Epilepsy Year")] public string med_Epilepsy_year { get; set; }
        [JsonProperty("Other Neurological Disorders")] public string med_Other_neurological { get; set; }
        [JsonProperty("Other Neurological Disorders  Name")] public string med_Other_neurological_text { get; set; }
        [JsonProperty("Other Neurological Disorders Year")] public string med_Other_neurological_year { get; set; }
        [JsonProperty("Inherited Disease1")] public string med_inheriteddis { get; set; }
        [JsonProperty("Inherited Disease Year1")] public string med_inheriteddis_year { get; set; }
        [JsonProperty("Other Disease")] public string med_other { get; set; }
        [JsonProperty("Other Disease  Name")] public string med_other_specify { get; set; }
        [JsonProperty("Other Disease  Year")] public string med_other_year { get; set; }
        [JsonProperty("Allergies")] public string allergies { get; set; }
        [JsonProperty("Allergies Remarks")] public string allergies_yestxt { get; set; }
        [JsonProperty("Intolerance")] public string intolerance { get; set; }
        [JsonProperty("Intolerance Remarks")] public string intolerance_yestxt { get; set; }
        [JsonProperty("Surgery")] public string med_surgery { get; set; }
        [JsonProperty("Surgery Remarks")] public string med_surgery_yestxt { get; set; }
        [JsonProperty("Surgery Year")] public string med_surgery_year { get; set; }
        [JsonProperty("Medication For Hypertension")] public string medication_hypertension { get; set; }
        [JsonProperty("Medication For Hypertension Specify")] public string medication_hypertension_specify { get; set; }
        [JsonProperty("Medication For Hypertension Year")] public string medication_hypertension_year { get; set; }
        [JsonProperty("Medication For Prediabetes")] public string medication_Prediabetes { get; set; }
        [JsonProperty("Medication For Prediabetes Specify")] public string medication_Prediabetes_specify { get; set; }
        [JsonProperty("Medication For Prediabetes Year")] public string medication_Prediabetes_year { get; set; }
        [JsonProperty("Medication For Type1 Diabetes")] public string medication_type1 { get; set; }
        [JsonProperty("Medication For Type1 Diabetes Specify")] public string medication_type1_specify { get; set; }
        [JsonProperty("Medication For Type1 Diabetes Year")] public string medication_type1_year { get; set; }
        [JsonProperty("Medication For Type2 Diabetes")] public string medication_type2 { get; set; }
        [JsonProperty("Medication For Type2 Diabetes Specify")] public string medication_type2_specify { get; set; }
        [JsonProperty("Medication For Type2 Diabetes Year")] public string medication_type2_year { get; set; }
        [JsonProperty("Medication For High Cholestrol")] public string medication_choles { get; set; }
        [JsonProperty("Medication For High Cholestrol Specify")] public string medication_choles_specify { get; set; }
        [JsonProperty("Medication For High Cholestrol Year")] public string medication_choles_year { get; set; }
        [JsonProperty("Medication For Obesity")] public string medication_obe { get; set; }
        [JsonProperty("Medication For Obesity Specify")] public string medication_obe_specify { get; set; }
        [JsonProperty("Medication For Obesity Year")] public string medication_obe_year { get; set; }
        [JsonProperty("Medication For Heart Disease")] public string medication_heart { get; set; }
        [JsonProperty("Medication For Heart Disease Specify")] public string medication_heart_specify { get; set; }
        [JsonProperty("Medication For Heart Disease Year")] public string medication_heart_year { get; set; }
        [JsonProperty("Medication For Cancer")] public string medication_cancer { get; set; }
        [JsonProperty("Medication For Cancer Specify")] public string medication_cancer_specify { get; set; }
        [JsonProperty("Medication For Cancer Year")] public string medication_cancer_year { get; set; }
        [JsonProperty("Medication For Anxiety  Disorder")] public string medication_Anxiety { get; set; }
        [JsonProperty("Medication For Anxiety  Disorder Specify")] public string medication_Anxiety_specify { get; set; }
        [JsonProperty("Medication For Anxiety  Disorder Year")] public string medication_Anxiety_year { get; set; }
        [JsonProperty("Medication For Depression")] public string medication_dep { get; set; }
        [JsonProperty("Medication For Depression Specify")] public string medication_dep_specify { get; set; }
        [JsonProperty("Medication For Depression Year")] public string medication_dep_year { get; set; }
        [JsonProperty("Medication For Bipolar  Disorder")] public string medication_Bipolar { get; set; }
        [JsonProperty("Medication For Bipolar  Disorder Specify")] public string medication_Bipolar_specify { get; set; }
        [JsonProperty("Medication For Bipolar  Disorder Year")] public string medication_Bipolar_year { get; set; }
        [JsonProperty("Medication For Schizophrenia")] public string medication_Schizophrenia { get; set; }
        [JsonProperty("Medication For Schizophrenia Specify")] public string medication_Schizophrenia_specify { get; set; }
        [JsonProperty("Medication For Schizophrenia Year")] public string medication_Schizophrenia_year { get; set; }
        [JsonProperty("Medication For Post-Traumatic Stress Disorder")] public string medication_PTSD { get; set; }
        [JsonProperty("Medication For Post-Traumatic Stress Disorder Specify")] public string medication_PTSD_specify { get; set; }
        [JsonProperty("Medication For Post-Traumatic Stress Disorder Year")] public string medication_PTSD_year { get; set; }
        [JsonProperty("Medication For Other Psychiatric Disorder")] public string medication_Other_Psychiatric_disorder { get; set; }
        [JsonProperty("Medication For Other Psychiatric Disorder Specify")] public string medication_Other_Psychiatric_disorder_specify { get; set; }
        [JsonProperty("Medication For Other Psychiatric Disorder Year")] public string medication_Other_Psychiatric_disorder_year { get; set; }
        [JsonProperty("Medication For Osteoporosis")] public string medication_osteo { get; set; }
        [JsonProperty("Medication For Osteoporosis Specify")] public string medication_osteo_specify { get; set; }
        [JsonProperty("Medication For Osteoporosis Year")] public string medication_osteo_year { get; set; }
        [JsonProperty("Medication For Asthma")] public string medication_asth { get; set; }
        [JsonProperty("Medication For Asthma Specify")] public string medication_asth_specify { get; set; }
        [JsonProperty("Medication For Asthma Year")] public string medication_asth_year { get; set; }
        [JsonProperty("Medication For Endocrine Disorders")] public string medication_Endocrine_disorders { get; set; }
        [JsonProperty("Medication For Endocrine Disorders Specify")] public string medication_Endocrine_disorders_specify { get; set; }
        [JsonProperty("Medication For Endocrine Disorders Year")] public string medication_Endocrine_disorders_year { get; set; }
        [JsonProperty("Medication For Headache/Migraine")] public string medication_migraine { get; set; }
        [JsonProperty("Medication For Headache/Migraine Specify")] public string medication_migraine_specify { get; set; }
        [JsonProperty("Medication For Headache/Migraine Year")] public string medication_migraine_year { get; set; }
        [JsonProperty("Medication For Alzheimer Disease")] public string medication_Alzheimer { get; set; }
        [JsonProperty("Medication For Alzheimer Disease Specify")] public string medication_Alzheimer_specify { get; set; }
        [JsonProperty("Medication For Alzheimer Disease Year")] public string medication_Alzheimer_year { get; set; }
        [JsonProperty("Medication For Parkinson Disease")] public string medication_Parkinson { get; set; }
        [JsonProperty("Medication For Parkinson Disease Specify")] public string medication_Parkinson_specify { get; set; }
        [JsonProperty("Medication For Parkinson Disease Year")] public string medication_Parkinson_year { get; set; }
        [JsonProperty("Medication For Epilepsy/Seizures")] public string medication_Epilepsy { get; set; }
        [JsonProperty("Medication For Epilepsy/Seizures Specify")] public string medication_Epilepsy_specify { get; set; }
        [JsonProperty("Medication For Epilepsy/Seizures Year")] public string medication_Epilepsy_year { get; set; }
        [JsonProperty("Medication For Other Neurological Disorder")] public string medication_Other_neurological { get; set; }
        [JsonProperty("Medication For Other Neurological Disorder Specify")] public string medication_Other_neurological_specify { get; set; }
        [JsonProperty("Medication For Other Neurological Disorder Year")] public string medication_Other_neurological_year { get; set; }
        [JsonProperty("Medication For Others")] public string medication_Other { get; set; }
        [JsonProperty("Medication For Others Specify")] public string medication_Other_specify { get; set; }
        [JsonProperty("Medication For Others Year")] public string medication_Other_year { get; set; }
        [JsonProperty("No Medication")] public string medication_none { get; set; }
        [JsonProperty("Supplements")] public string medication_Supplements { get; set; }
        [JsonProperty("Supplements Specify")] public string medication_Supplements_specify { get; set; }
        [JsonProperty("Supplements Year")] public string medication_Supplements_year { get; set; }
        [JsonProperty("Vaccinations  Past 4 Weeks")] public string med_vaccine { get; set; }
        [JsonProperty("Flu Shot Past 12 Months")] public string med_flushot { get; set; }
        [JsonProperty("Blood Sugar Levels With Care")] public string DSM_blood_sugar_levels_with_care { get; set; }
        [JsonProperty("Achieve Optimal Blood Sugar Level")] public string DSM_achieve_optimal_blood_sugar_level { get; set; }
        [JsonProperty("Keep All Doctors Appointments")] public string DSM_keep_doctors_appointments { get; set; }
        [JsonProperty("Take My Diabetes Medication")] public string DSM_take_diabetes_medication { get; set; }
        [JsonProperty("Occasionally I Eat Lots Of Sweets")] public string DSM_Occasionally_eat_sweets { get; set; }
        [JsonProperty("Record My Blood Sugar")] public string DSM_record_blood_sugar { get; set; }
        [JsonProperty("Avoid Diabetes-Related Doctors Appointments")] public string DSM_avoid_diabetes_related_appointments { get; set; }
        [JsonProperty("Physically Active")] public string DSM_physically_active { get; set; }
        [JsonProperty("Follow The Dietary Recommendations")] public string DSM_follow_dietary_recommendations { get; set; }
        [JsonProperty("Do Not Check My Blood Sugar Levels")] public string DSM_do_not_check_blood_sugar_levels { get; set; }
        [JsonProperty("Avoid Physical Activity")] public string DSM_avoid_physical_activity { get; set; }
        [JsonProperty("Skip Medication")] public string DSM_skip_medication { get; set; }
        [JsonProperty("Food Binges")] public string DSM_food_binges { get; set; }
        [JsonProperty("Should See Medical Practitioner(S) More Often")] public string DSM_morevisit { get; set; }
        [JsonProperty("Less Physically Active")] public string DSM_less_physically_active { get; set; }
        [JsonProperty("Self-Care Is Poor")] public string DSM_self_care_poor { get; set; }
        [JsonProperty("Diabetes Treatment None")] public string DSM_DiabetesTreatment_none { get; set; }
        [JsonProperty("Diabetes Treatment 1 Name")] public string DSM_DiabetesTreatment_1name { get; set; }
        [JsonProperty("Diabetes Treatment 1 Year")] public string DSM_DiabetesTreatment_1year { get; set; }
        [JsonProperty("Diabetes Treatment 2 Name")] public string DSM_DiabetesTreatment_2name { get; set; }
        [JsonProperty("Diabetes Treatment 2 Year")] public string DSM_DiabetesTreatment_2year { get; set; }
        [JsonProperty("Diabetes Treatment 3 Name")] public string DSM_DiabetesTreatment_3name { get; set; }
        [JsonProperty("Diabetes Treatment 3 Year")] public string DSM_DiabetesTreatment_3year { get; set; }
        [JsonProperty("Diabetes Treatment 4 Name")] public string DSM_DiabetesTreatment_4name { get; set; }
        [JsonProperty("Diabetes Treatment 4 Year")] public string DSM_DiabetesTreatment_4year { get; set; }
        [JsonProperty("Stop Medication Past 6 Months")] public string DSM_stop_medication { get; set; }
        [JsonProperty("Stop Medication Name")] public string DSM_stop_medication_name { get; set; }
        [JsonProperty("Stop Medication Reason")] public string DSM_stop_medication_reason { get; set; }
        [JsonProperty("Stop Diabetic Medication  1 Name")] public string DSM_stop_medication_1name { get; set; }
        [JsonProperty("Stop Diabetic Medication  1 Reason")] public string DSM_stop_medication_1reason { get; set; }
        [JsonProperty("Stop Diabetic Medication  2 Name")] public string DSM_stop_medication_2name { get; set; }
        [JsonProperty("Stop Diabetic Medication 2  Reason")] public string DSM_stop_medication_2reason { get; set; }
        [JsonProperty("Stop Diabetic Medication  3 Name")] public string DSM_stop_medication_3name { get; set; }
        [JsonProperty("Stop Diabetic Medication  3 Reason")] public string DSM_stop_medication_3reason { get; set; }
        [JsonProperty("Stop Diabetic Medication 4 Name")] public string DSM_stop_medication_4name { get; set; }
        [JsonProperty("Stop Diabetic Medication  4 Reason")] public string DSM_stop_medication_4reason { get; set; }
        [JsonProperty("Medication Yesterday")] public string DSM_medication_yesterday { get; set; }
        [JsonProperty("Prescribed Metformin")] public string DSM_prescribed_metformin { get; set; }
        [JsonProperty("Take Metformin")] public string DSM_take_metformin { get; set; }
        [JsonProperty("How Often Take Metformin")] public string DSM_take_metformin_period { get; set; }
        [JsonProperty("Past Week Take Metformin")] public string DSM_take_metformin_pastweek { get; set; }
        [JsonProperty("Metformin Days")] public string DSM_take_metformin_days { get; set; }
        [JsonProperty("Metformin Times")] public string DSM_take_metformin_times { get; set; }
        [JsonProperty("Howmuch Metformin")] public string DSM_take_metformin_qty { get; set; }
        [JsonProperty("Metformin Missed")] public string DSM_take_metformin_missed { get; set; }
        [JsonProperty("Metformin Works")] public string DSM_take_metformin_works { get; set; }
        [JsonProperty("Metformin Bothers")] public string DSM_take_metformin_bothers { get; set; }
        [JsonProperty("Hard To Remember")] public string DSM_difficulty_hard_to_remember { get; set; }
        [JsonProperty("Hard To Pay")] public string DSM_difficulty_hard_to_pay { get; set; }
        [JsonProperty("Hard To Refill")] public string DSM_difficulty_hard_to_refill { get; set; }
        [JsonProperty("Unwanted Side Effect")] public string DSM_difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("Other Concern")] public string DSM_difficulty_other_concern { get; set; }
        [JsonProperty("Metformin Discomfort Nausea")] public string DSM_discomfort_Nausea { get; set; }
        [JsonProperty("Metformin Discomfort Vomiting")] public string DSM_discomfort_Vomiting { get; set; }
        [JsonProperty("Metformin Discomfort Diarrhea")] public string DSM_discomfort_Diarrhea { get; set; }
        [JsonProperty("Metformin Discomfort Abdominal Pain")] public string DSM_discomfort_Abdominal_pain { get; set; }
        [JsonProperty("Metformin Discomfort Bloating")] public string DSM_discomfort_Bloating { get; set; }
        [JsonProperty("Metformin Loss Of Appetite")] public string DSM_discomfort_Loss_of_appetite { get; set; }
        [JsonProperty("Metformin Anorexia")] public string DSM_Metformin_anorexia { get; set; }
        [JsonProperty("1Oad Medication Name")] public string DSM_1OAD_Name { get; set; }
        [JsonProperty("1Oad Period")] public string DSM_1OAD_Period { get; set; }
        [JsonProperty("Take 1Oad Past Week")] public string DSM_1OAD_take { get; set; }
        [JsonProperty("1Oad Days")] public string DSM_1OAD_days { get; set; }
        [JsonProperty("1Oad Times")] public string DSM_1OAD_times { get; set; }
        [JsonProperty("How Much 1Oad")] public string DSM_1OAD_qty { get; set; }
        [JsonProperty("1Oad Miss")] public string DSM_1OAD_miss { get; set; }
        [JsonProperty("1Oad Works")] public string DSM_1OAD_works { get; set; }
        [JsonProperty("1Oad Bothers")] public string DSM_1OAD_bothers { get; set; }
        [JsonProperty("1Oad Difficulty - Hard To Remeber")] public string DSM_1OAD_Difficulty_hard_to_remember { get; set; }
        [JsonProperty("1Oad Difficulty - Hard To Pay")] public string DSM_1OAD_Difficulty_hard_to_pay { get; set; }
        [JsonProperty("1Oad Difficulty - Hard To Refill")] public string DSM_1OAD_Difficulty_hard_to_refill { get; set; }
        [JsonProperty("1Oad Difficulty - Unwanted Side Effect")] public string DSM_1OAD_Difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("1Oad Difficulty - Other Concern")] public string DSM_1OAD_Difficulty_other_concern { get; set; }
        [JsonProperty("2Oad Medication Name")] public string DSM_2OAD_Name { get; set; }
        [JsonProperty("2Oad Period")] public string DSM_2OAD_Period { get; set; }
        [JsonProperty("Take 2Oad Past Week")] public string DSM_2OAD_take { get; set; }
        [JsonProperty("2Oad Days")] public string DSM_2OAD_days { get; set; }
        [JsonProperty("2Oad Times")] public string DSM_2OAD_times { get; set; }
        [JsonProperty("How Much 2Oad")] public string DSM_2OAD_qty { get; set; }
        [JsonProperty("2Oad Miss")] public string DSM_2OAD_miss { get; set; }
        [JsonProperty("2Oad Works")] public string DSM_2OAD_works { get; set; }
        [JsonProperty("2Oad Bothers")] public string DSM_2OAD_bothers { get; set; }
        [JsonProperty("2Oad Difficulty - Hard To Remeber")] public string DSM_2OAD_Difficulty_hard_to_remember { get; set; }
        [JsonProperty("2Oad Difficulty - Hard To Pay")] public string DSM_2OAD_Difficulty_hard_to_pay { get; set; }
        [JsonProperty("2Oad Difficulty - Hard To Refill")] public string DSM_2OAD_Difficulty_hard_to_refill { get; set; }
        [JsonProperty("2Oad Difficulty - Unwanted Side Effect")] public string DSM_2OAD_Difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("2Oad Difficulty - Other Concern")] public string DSM_2OAD_Difficulty_other_concern { get; set; }
        [JsonProperty("3Oad Medication Name")] public string DSM_3OAD_Name { get; set; }
        [JsonProperty("3Oad Period")] public string DSM_3OAD_Period { get; set; }
        [JsonProperty("Take 3Oad Past Week")] public string DSM_3OAD_take { get; set; }
        [JsonProperty("3Oad Days")] public string DSM_3OAD_days { get; set; }
        [JsonProperty("3Oad Times")] public string DSM_3OAD_times { get; set; }
        [JsonProperty("How Much 3Oad")] public string DSM_3OAD_qty { get; set; }
        [JsonProperty("3Oad Miss")] public string DSM_3OAD_miss { get; set; }
        [JsonProperty("3Oad Works")] public string DSM_3OAD_works { get; set; }
        [JsonProperty("3Oad Bothers")] public string DSM_3OAD_bothers { get; set; }
        [JsonProperty("3Oad Difficulty - Hard To Remeber")] public string DSM_3OAD_Difficulty_hard_to_remember { get; set; }
        [JsonProperty("3Oad Difficulty - Hard To Pay")] public string DSM_3OAD_Difficulty_hard_to_pay { get; set; }
        [JsonProperty("3Oad Difficulty - Hard To Refill")] public string DSM_3OAD_Difficulty_hard_to_refill { get; set; }
        [JsonProperty("3Oad Difficulty - Unwanted Side Effect")] public string DSM_3OAD_Difficulty_unwanted_side_effect { get; set; }
        [JsonProperty("3Oad Difficulty - Other Concern")] public string DSM_3OAD_Difficulty_other_concern { get; set; }
        [JsonProperty("Body Weight (Kg)")] public string PCD_BodyWeight { get; set; }
        [JsonProperty("Waist Circumference (Cm)")] public string PCD_Waist { get; set; }
        [JsonProperty("Body Fat Mass (Kg)")] public string PCD_BodyMass { get; set; }
        [JsonProperty("Height")] public string PCD_Height { get; set; }
        [JsonProperty("Hip Circumference(Cm)")] public string PCD_hip { get; set; }
        [JsonProperty("Neck Circumference(Cm)")] public string PCD_neck { get; set; }
        [JsonProperty("Body Fat Percentage (%)")] public string PCD_bodyfatper { get; set; }
        [JsonProperty("Body Mass Index (Kg/M2)")] public string PCD_bmi { get; set; }
        [JsonProperty("Waist To Hip Ratio (Wr/Hr)")] public string PCD_WHR { get; set; }
        [JsonProperty("Blood Pressure Systolic")] public string PCD_BloodPressureSystolic { get; set; }
        [JsonProperty("Blood Pressure Diastolic")] public string PCD_BloodPressureDiastolic { get; set; }
        [JsonProperty("Chronic Gastrointestinal Diseases")] public string PMD_Chronic_gastrointestinal { get; set; }
        [JsonProperty("Inflammatory Bowel Diseases")] public string PMD_Inflammatory_bowel { get; set; }
        [JsonProperty("Gastrointestinal Ulcer")] public string PMD_Gastrointestinal_ulcer { get; set; }
        [JsonProperty("Chronic Liver Disease")] public string PMD_Chronic_liver { get; set; }
        [JsonProperty("Chronic Pancreatitis")] public string PMD_Chronic_pancreatitis { get; set; }
        [JsonProperty("Chronic Kidney Disease")] public string PMD_Chronic_kidney { get; set; }
        [JsonProperty("Cholelithiasis")] public string PMD_Cholelithiasis { get; set; }
        [JsonProperty("Endocrine Disorders")] public string PMD_Endocrine_disorders { get; set; }
        [JsonProperty("Inflammation")] public string PMD_inflammation { get; set; }
        [JsonProperty("Retinopathy")] public string complications_retinopathy { get; set; }
        [JsonProperty("Neuropathy")] public string complications_neuropathy { get; set; }
        [JsonProperty("Cerebrovascular Accident(Cva)")] public string complications_cva { get; set; }
        [JsonProperty("No Proliferative")] public string complications_No_proliferative { get; set; }
        [JsonProperty("Foot (Ulcers)")] public string complications_foot { get; set; }
        [JsonProperty("Tia")] public string complications_tia { get; set; }
        [JsonProperty("Proliferative")] public string complications_proliferative { get; set; }
        [JsonProperty("Gangrene")] public string complications_Gangrene { get; set; }
        [JsonProperty("Stroke")] public string complications_Stroke { get; set; }
        [JsonProperty("Laser")] public string complications_Laser { get; set; }
        [JsonProperty("Loss Of Sensation, Numbness")] public string complications_numbness { get; set; }
        [JsonProperty("Loss Of Sensation, One Side Of The Body")] public string complications_onesidebody { get; set; }
        [JsonProperty("Amputation")] public string complications_Amputation { get; set; }
        [JsonProperty("Bleeding")] public string complications_Bleeding { get; set; }
        [JsonProperty("Loss Of Toe")] public string complications_Loss_of_toe { get; set; }
        [JsonProperty("Dif?Culty Speaking")] public string complications_Diff_speaking { get; set; }
        [JsonProperty("Pain In Calf Muscles")] public string complications_Pain_in_calfmuscles { get; set; }
        [JsonProperty("Operation On Artery")] public string complications_Operation_on_artery { get; set; }
        [JsonProperty("Circulation, Peripheral Vascular Disease")] public string complications_Circulation_peripheral_vascular { get; set; }
        [JsonProperty("Facial Drop")] public string complications_Facial_drop { get; set; }
        [JsonProperty("Retinopathy Other")] public string complications_Retinopathy_other { get; set; }
        [JsonProperty("Paralyzed Arm")] public string complications_Paralyzed_arm { get; set; }
        [JsonProperty("Nephropathy")] public string complications_nephropathy { get; set; }
        [JsonProperty("Coronary Artery Disease")] public string complications_cad { get; set; }
        [JsonProperty("Nephropathy Other")] public string complications_other { get; set; }
        [JsonProperty("Nephropathy Albumin")] public string complications_albumin { get; set; }
        [JsonProperty("Coronary Artery Bypass Grafting (Cabg)")] public string complications_CABG { get; set; }
        [JsonProperty("Nephropathy Albuminuria")] public string complications_Albuminuria { get; set; }
        [JsonProperty("Percutaneous Coronary Intervention (Pci)")] public string complications_PCI { get; set; }
        [JsonProperty("Nephropathy 30-299 Mg/24H")] public string complications_30_299_mg_24h { get; set; }
        [JsonProperty("Nephropathy Arrhythmias (Af)")] public string complications_Arrhythmias { get; set; }
        [JsonProperty("Nephropathy >300 Mg/24H")] public string complications_300_mg_24h { get; set; }
        [JsonProperty("Nephropathy Egfr")] public string complications_egfr { get; set; }
        [JsonProperty("Anti-Hypertensive Ace Inhibitors")] public string Anti_Hypertensive_ACE_inhibitors { get; set; }
        [JsonProperty("Anti-Hypertensive Ace Inhibitors Perindopril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Perindopril { get; set; }
        [JsonProperty("Anti-Hypertensive Ace Inhibitors Captopril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Captopril { get; set; }
        [JsonProperty("Anti-Hypertensive Ace Inhibitors Enalapril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Enalapril { get; set; }
        [JsonProperty("Anti-Hypertensive Ace Inhibitors Lisinopril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Lisinopril { get; set; }
        [JsonProperty("Anti-Hypertensive Ace Inhibitors Other Dose")] public string Anti_Hypertensive_ACE_inhibitors_other { get; set; }
        [JsonProperty("Anti-Hypertensive Arbs")] public string Anti_Hypertensive_ARBs { get; set; }
        [JsonProperty("Anti-Hypertensive Arbs Losartan Dose")] public string Anti_Hypertensive_ARBs_Losartan { get; set; }
        [JsonProperty("Anti-Hypertensive Arbs Valsartan Dose")] public string Anti_Hypertensive_ARBs_Valsartan { get; set; }
        [JsonProperty("Anti-Hypertensive Arbs Other Dose")] public string Anti_Hypertensive_ARBs_other { get; set; }
        [JsonProperty("Anti-Hypertensive Beta- Blockers")] public string Anti_Hypertensive_Beta_blockers { get; set; }
        [JsonProperty("Anti-Hypertensive Beta- Blockers Atenolol Dose")] public string Anti_Hypertensive_Beta_blockers_Atenolol { get; set; }
        [JsonProperty("Anti-Hypertensive Beta- Blockers Bisoprolol Dose")] public string Anti_Hypertensive_Beta_blockers_Bisoprolol { get; set; }
        [JsonProperty("Anti-Hypertensive Beta- Blockers Other Dose")] public string Anti_Hypertensive_Beta_blockers_other { get; set; }
        [JsonProperty("Anti-Hypertensive Diuretics")] public string Anti_Hypertensive_Diuretics { get; set; }
        [JsonProperty("Anti-Hypertensive Diuretics Indapamide Dose")] public string Anti_Hypertensive_Diuretics_Indapamide { get; set; }
        [JsonProperty("Anti-Hypertensive Diuretics Hydrochlorothiazide Dose")] public string Anti_Hypertensive_Diuretics_Hydrochlorothiazide { get; set; }
        [JsonProperty("Anti-Hypertensive Diuretics Frusemide Dose")] public string Anti_Hypertensive_Diuretics_Frusemide { get; set; }
        [JsonProperty("Anti-Hypertensive Diuretics Other Dose")] public string Anti_Hypertensive_Diuretics_other { get; set; }
        [JsonProperty("Anti-Hypertensive Ca-Channel Blockers")] public string Anti_Hypertensive_CaChannel_Blockers { get; set; }
        [JsonProperty("Anti-Hypertensive Ca-Channel Blockers Amlodipine Dose")] public string Anti_Hypertensive_CaChannel_Blockers_Amlodipine { get; set; }
        [JsonProperty("Anti-Hypertensive Ca-Channel Blockers Nifedipine Dose")] public string Anti_Hypertensive_CaChannel_Blockers_Nifedipine { get; set; }
        [JsonProperty("Anti-Hypertensive Ca-Channel Blockers Verapamil Dose")] public string Anti_Hypertensive_CaChannel_Blockers_Verapamil { get; set; }
        [JsonProperty("Anti-Hypertensive Ca-Channel Blockers Other Dose")] public string Anti_Hypertensive_CaChannel_Blockers_other { get; set; }
        [JsonProperty("Anti-Hypertensive Other")] public string Anti_Hypertensive_other { get; set; }
        [JsonProperty("Anti-Hypertensive Other Other Dose")] public string Anti_Hypertensive_other_other { get; set; }
        [JsonProperty("Anti-Dyslipidemia Statins")] public string Anti_Dyslipidemia_Statins { get; set; }
        [JsonProperty("Anti-Dyslipidemia Statins Simvastatin Dose")] public string Anti_Dyslipidemia_Statins_Simvastatin { get; set; }
        [JsonProperty("Anti-Dyslipidemia Statins Atorvastatin Dose")] public string Anti_Dyslipidemia_Statins_Atorvastatin { get; set; }
        [JsonProperty("Anti-Dyslipidemia Statins Rosuvastatin Dose")] public string Anti_Dyslipidemia_Statins_Rosuvastatin { get; set; }
        [JsonProperty("Anti-Dyslipidemia Statins Other Dose")] public string Anti_Dyslipidemia_Statins_other { get; set; }
        [JsonProperty("Anti-Dyslipidemia Fibrates")] public string Anti_Dyslipidemia_Fibrates { get; set; }
        [JsonProperty("Anti-Dyslipidemia Fibrates Gemfibrozil Dose")] public string Anti_Dyslipidemia_Fibrates_Gemfibrozil { get; set; }
        [JsonProperty("Anti-Dyslipidemia Fibrates Fenofibrate Dose")] public string Anti_Dyslipidemia_Fibrates_Fenofibrate { get; set; }
        [JsonProperty("Anti-Dyslipidemia Other")] public string Anti_Dyslipidemia_other { get; set; }
        [JsonProperty("Anti-Dyslipidemia Other Other Dose")] public string Anti_Dyslipidemia_other_other { get; set; }
        [JsonProperty("Oral Agents Biguanides")] public string Oral_agents_Biguanides { get; set; }
        [JsonProperty("Oral Agents Biguanides Metformin Dose")] public string Oral_agents_Biguanides_Metformin { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas")] public string Oral_agents_Sulphonyureas { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Glibenclamide Dose")] public string Oral_agents_Sulphonyureas_Glibenclamide { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Glimepiride Dose")] public string Oral_agents_Sulphonyureas_Glimepiride { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Glipizide Dose")] public string Oral_agents_Sulphonyureas_Glipizide { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Gliclazide  Mr Dose")] public string Oral_agents_Sulphonyureas_GliclazideMR { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Glipizide1 Dose")] public string Oral_agents_Sulphonyureas_Glipizide1 { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Glimepride Dose")] public string Oral_agents_Sulphonyureas_Glimepride { get; set; }
        [JsonProperty("Oral Agents Sulphonyureas Other Dose")] public string Oral_agents_Sulphonyureas_other { get; set; }
        [JsonProperty("Oral Agents Thiazolidinediones")] public string Oral_agents_Thiazolidinediones { get; set; }
        [JsonProperty("Oral Agents Thiazolidinediones Pioglitazone Dose")] public string Oral_agents_Thiazolidinediones_Pioglitazone { get; set; }
        [JsonProperty("Oral Agents Thiazolidinediones Other Dose")] public string Oral_agents_Thiazolidinediones_other { get; set; }
        [JsonProperty("Oral Agents Meglitinides")] public string Oral_agents_Meglitinides { get; set; }
        [JsonProperty("Oral Agents Meglitinides Nateglinide Dose")] public string Oral_agents_Meglitinides_Nateglinide { get; set; }
        [JsonProperty("Oral Agents Meglitinides Repaglinide Dose")] public string Oral_agents_Meglitinides_Repaglinide { get; set; }
        [JsonProperty("Oral Agents Alpha-Glucosidase Inhibitors")] public string Oral_agents_Alpha_glucosidase_inhibitors { get; set; }
        [JsonProperty("Oral Agents Alpha-Glucosidase Inhibitors Acarbose Dose")] public string Oral_agents_Alpha_glucosidase_inhibitors_Acarbose { get; set; }
        [JsonProperty("Oral Agents Dipeptidyl Peptidase -Iv Inhibitors (Dpp-Iv)")] public string Oral_agents_Dipeptidyl { get; set; }
        [JsonProperty("Oral Agents Dipeptidyl Sitagliptin Dose")] public string Oral_agents_Dipeptidyl_Sitagliptin { get; set; }
        [JsonProperty("Oral Agents Dipeptidyl Vildagliptin Dose")] public string Oral_agents_Dipeptidyl_Vildagliptin { get; set; }
        [JsonProperty("Oral Agents Dipeptidyl Saxagliptin Dose")] public string Oral_agents_Dipeptidyl_Saxagliptin { get; set; }
        [JsonProperty("Oral Agents Dipeptidyl Linagliptin Dose")] public string Oral_agents_Dipeptidyl_Linagliptin { get; set; }
        [JsonProperty("Oral Agents Other")] public string Oral_agents_other { get; set; }
        [JsonProperty("Oral Agents Other Pramlintide Dose")] public string Oral_agents_other_Pramlintide { get; set; }
        [JsonProperty("Oral Agents Other Other Dose")] public string Oral_agents_other_other { get; set; }
        [JsonProperty("Oral Agents Incretin Mimetics(Glp-1 Agonist)")] public string Oral_agents_Incretin { get; set; }
        [JsonProperty("Oral Agents Incretin Exenatide Dose")] public string Oral_agents_Incretin_Exenatide { get; set; }
        [JsonProperty("Oral Agents Incretin Liraglutide Dose")] public string Oral_agents_Incretin_Liraglutide { get; set; }
        [JsonProperty("Oral Agents Incretin Exenatide  Weekly Dose")] public string Oral_agents_Incretin_Exenatide_weekly { get; set; }
        [JsonProperty("Injections Insulin")] public string Injections_Insulin { get; set; }
        [JsonProperty("Injections Insulin Lispro Dose")] public string Injections_Insulin_Lispro { get; set; }
        [JsonProperty("Injections Insulin Aspart Dose")] public string Injections_Insulin_Aspart { get; set; }
        [JsonProperty("Injections Insulin Glulisine Dose")] public string Injections_Insulin_Glulisine { get; set; }
        [JsonProperty("Injections Insulin Regular Dose")] public string Injections_Insulin_Regular { get; set; }
        [JsonProperty("Injections Insulin Nph Dose")] public string Injections_Insulin_NPH { get; set; }
        [JsonProperty("Injections Insulin Detemir Dose")] public string Injections_Insulin_Detemir { get; set; }
        [JsonProperty("Injections Insulin Glargine Dose")] public string Injections_Insulin_Glargine { get; set; }
        [JsonProperty("Injections Insulin Combination Dose")] public string Injections_Insulin_Combination { get; set; }
        [JsonProperty("Supplements Vitamin D3")] public string Supplements_VitaminD3 { get; set; }
        [JsonProperty("Supplements Others (Erythropoietin  Injections)")] public string Supplements_others { get; set; }
        [JsonProperty("Antidepressants Prozac Dose")] public string Antidepressants_Prozac { get; set; }
        [JsonProperty("Antidepressants Others")] public string Antidepressants_other { get; set; }
        [JsonProperty("Antianxiety Diazepam  Dose")] public string Antianxiety_Diazepam { get; set; }
        [JsonProperty("Antianxiety Others  Dose")] public string Antianxiety_other { get; set; }
        [JsonProperty("Other Medication")] public string othermedication_other { get; set; }
        [JsonProperty("Traditional Chinese Medicine")] public string traditional_chinese { get; set; }
        [JsonProperty("Cognitive Test Result_Time")] public string Cognitive_test_result_time { get; set; }
        [JsonProperty("Laboratory Sample Type")] public string lab_sample_type { get; set; }
        [JsonProperty("Laboratory Blood")] public string lab_blood { get; set; }
        [JsonProperty("Laboratory Other")] public string lab_other { get; set; }
        [JsonProperty("Laboratory Other Text")] public string lab_other_text { get; set; }
        [JsonProperty("Laboratory Sample Date")] public string lab_sample_date { get; set; }
        [JsonProperty("Laboratory Storage")] public string lab_sample_storage { get; set; }
        [JsonProperty("Laboratory Sample Volume")] public string lab_sample_volume { get; set; }
        [JsonProperty("Laboratory Project Code")] public string lab_project_code { get; set; }
        [JsonProperty("Laboratory Comments")] public string lab_comments { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        [JsonProperty("health annual_medical_checkuptxtdateyear")] public string health_annual_medical_checkuptxtdateyear { get; set; }
        [JsonProperty("female pregnant when year")] public string female_pregnant_when_year { get; set; }
        [JsonProperty("vigorous physical activities hours")] public string PPA_vigorous_physical_activities_hours { get; set; }
        [JsonProperty("vigorous physical activities min")] public string PPA_vigorous_physical_activities_min { get; set; }
        [JsonProperty("moderate physical activities_hours")] public string PPA_moderate_physical_activities_hours { get; set; }
        [JsonProperty("moderate physical activities min")] public string PPA_moderate_physical_activities_min { get; set; }
        [JsonProperty("walk days")] public string PPA_walk_days { get; set; }
        [JsonProperty("walk time hours")] public string PPA_walk_time_hours { get; set; }
        [JsonProperty("walk time min")] public string PPA_walk_time_min { get; set; }
        [JsonProperty("sit hours")] public string PPA_sit_hours { get; set; }
        [JsonProperty("sit min")] public string PPA_sit_min { get; set; }
        [JsonProperty("quit smoking days txt")] public string PSS_quit_smoking_days_txt { get; set; }
        [JsonProperty("quit smoking week txt")] public string PSS_quit_smoking_week_txt { get; set; }
        [JsonProperty("quit smoking month txt")] public string PSS_quit_smoking_month_txt { get; set; }
        [JsonProperty("quit smoking yrs txt")] public string PSS_quit_smoking_yrs_txt { get; set; }
        [JsonProperty("avg cigarettes perday194 txt")] public string PSS_avg_cigarettes_perday194_txt { get; set; }
        [JsonProperty("first smoke age694 txt")] public string PSS_first_smoke_age694_txt { get; set; }
        [JsonProperty("vigorous physical activities days")] public string PPA_vigorous_physical_activities_days { get; set; }
        [JsonProperty("work_txt")] public string PPA_work_txt { get; set; }
        [JsonProperty("donot take medication specify")] public string donot_take_medication_specify { get; set; }
        [JsonProperty("donot take medication year")] public string donot_take_medication_year { get; set; }
        [JsonProperty("covid-19")] public string covid { get; set; }
        [JsonProperty("flu")] public string flu { get; set; }
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
        [JsonProperty("other")] public string others { get; set; }
        [JsonProperty("other specify")] public string other_specify { get; set; }
        [JsonProperty("other year")] public string other_year { get; set; }
        [JsonProperty("none")] public string none { get; set; }
        [JsonProperty("other txt")] public string other_txt { get; set; }
        [JsonProperty("complications neuropathy other")] public string complications_neuropathy_other { get; set; }
        [JsonProperty("complications other specify")] public string complications_other_specify { get; set; }
        [JsonProperty("Country")] public string country { get; set; }
        [JsonProperty("Grade Other")] public string eduGrade_other { get; set; }
        [JsonProperty("Education Level Other")] public string eduLevel_other { get; set; }
        [JsonProperty("Employment Night shif often")] public string employment_nightshif_often { get; set; }
        [JsonProperty("urinate during night often")] public string health_urinate_night_4weeks_often { get; set; }
        [JsonProperty("period days number")] public string female_period_days_number { get; set; }
        [JsonProperty("period regular time intervals yes when")] public string female_period_regular_time_intervals_yes_when { get; set; }
        [JsonProperty("period regular time intervals no when")] public string female_period_regular_time_intervals_no_when { get; set; }
        [JsonProperty("moderate physical activities days per_week")] public string PPA_moderate_physical_activities_days_per_week { get; set; }
        [JsonProperty("last 7 days work days")] public string PPA_work_days { get; set; }
        [JsonProperty("Eat by Ordering")] public string PD_eat_by_ordering { get; set; }
        [JsonProperty("No. of cigarettes 30days")] public string PSS_cigarettes_30days_number { get; set; }
        [JsonProperty("Avg cigarettes 30days 1-94")] public string PSS_avg_cigarettes_30days_1_94 { get; set; }
        [JsonProperty("Hypothyroidism")] public string med_Hypothyroidism { get; set; }
        [JsonProperty("Hypothyroidism Year")] public string med_Hypothyroidism_year { get; set; }
        [JsonProperty("Hyperthyroidism")] public string med_Hyperthyroidism { get; set; }
        [JsonProperty("Hyperthyroidism Year")] public string med_Hyperthyroidism_year { get; set; }
        [JsonProperty("Autoimmune")] public string med_Autoimmune { get; set; }
        [JsonProperty("Autoimmune Year")] public string med_Autoimmune_year { get; set; }
        [JsonProperty("thyroid other text")] public string med_thyroid_other_text { get; set; }
        [JsonProperty("hepatitis type")] public string med_hepatitis_type { get; set; }
        [JsonProperty("inherited disease")] public string med_inherited_disease { get; set; }
        [JsonProperty("inherited disease specify")] public string med_inherited_disease_specify { get; set; }
        [JsonProperty("inherited disease year")] public string med_inherited_disease_year { get; set; }
        [JsonProperty("long-term diabetic complications")] public string DSM_longterm_diabetic_complications { get; set; }
        [JsonProperty("long-term diabetic complications year")] public string DSM_longterm_diabetic_complications_year { get; set; }
        [JsonProperty("long-term diabetic complications Kidney problem")] public string DSM_longterm_diabetic_complications_Kidney { get; set; }
        [JsonProperty("long-term diabetic complications Foot problem")] public string DSM_longterm_diabetic_complications_Foot { get; set; }
        [JsonProperty("long-term diabetic complications Stroke problem")] public string DSM_longterm_diabetic_complications_Stroke { get; set; }
        [JsonProperty("long-term diabetic complications Heart problem")] public string DSM_longterm_diabetic_complications_Heart { get; set; }
        [JsonProperty("long-term diabetic complications Eye problem")] public string DSM_longterm_diabetic_complications_Eye { get; set; }
        [JsonProperty("long-term diabetic complications other problem")] public string DSM_longterm_diabetic_complications_other { get; set; }
        [JsonProperty("long-term diabetic complications dont know")] public string DSM_longterm_diabetic_complications_dontknow { get; set; }
        [JsonProperty("long-term diabetic complications not disclose")] public string DSM_longterm_diabetic_complications_notdisclose { get; set; }
        [JsonProperty("DiabetesTreatment medication")] public string DSM_DiabetesTreatment_medication { get; set; }
        [JsonProperty("DiabetesTreatment 1year Daily Dose")] public string DSM_DiabetesTreatment_1year_dose { get; set; }
        [JsonProperty("DiabetesTreatment 2year Daily Dose")] public string DSM_DiabetesTreatment_2year_dose { get; set; }
        [JsonProperty("DiabetesTreatment 3year Daily Dose")] public string DSM_DiabetesTreatment_3year_dose { get; set; }
        [JsonProperty("DiabetesTreatment 4year Daily Dose")] public string DSM_DiabetesTreatment_4year_dose { get; set; }
        [JsonProperty("discomfort Loss of appetite specify")] public string DSM_discomfort_Loss_of_appetite_specify { get; set; }
        [JsonProperty("complications Laser other")] public string complications_Laser_other { get; set; }
        [JsonProperty("complications Retinopathy other")] public string complications_Retinopathy_other_other { get; set; }
        [JsonProperty("complications Anti Hypertensive Methyldopa dose")] public string Anti_Hypertensive_Methyldopa { get; set; }
        [JsonProperty("Anti Dyslipidemia Fibrates Fenofibrate other dose")] public string Anti_Dyslipidemia_Fibrates_Fenofibrate_other { get; set; }
        [JsonProperty("Meglitinides other dose")] public string Oral_agents_Meglitinides_other { get; set; }
        [JsonProperty("Dipeptidyl other dose")] public string Oral_agents_Dipeptidyl_other { get; set; }
        [JsonProperty("Incretin other dose")] public string Oral_agents_Incretin_other { get; set; }
        [JsonProperty("Alpha glucosidase inhibitors other dose")] public string Oral_agents_Alpha_glucosidase_inhibitors_other { get; set; }
        [JsonProperty("SGLT2 inhibitors")] public string Oral_agents_SGLT2 { get; set; }
        [JsonProperty("SGLT2 inhibitors Canagliflozin dose")] public string Oral_agents_SGLT2_Canagliflozin { get; set; }
        [JsonProperty("SGLT2 inhibitors Dapagliflozin dose")] public string Oral_agents_SGLT2_Dapagliflozin { get; set; }
        [JsonProperty("SGLT2 inhibitors Empagliflozin dose")] public string Oral_agents_SGLT2_Empagliflozin { get; set; }
        [JsonProperty("SGLT2 inhibitors other dose")] public string Oral_agents_SGLT2_other { get; set; }
        [JsonProperty("Amylin")] public string Oral_agents_Amylin { get; set; }
        [JsonProperty("Amylin Pramlintide dose")] public string Oral_agents_Amylin_Pramlintide { get; set; }
        [JsonProperty("Amylin other dose")] public string Oral_agents_Amylin_other { get; set; }
        [JsonProperty("Insulin other dose")] public string Injections_Insulin_other { get; set; }
        [JsonProperty("Supplements Erythropoietin Injection dose")] public string Supplements_Erythropoietin { get; set; }
        [JsonProperty("Supplements Erythropoietin other dose")] public string Supplements_Erythropoietin_other { get; set; }
        [JsonProperty("Antianxiety_Alprazolam (Xanax) dose")] public string Antianxiety_Alprazolam { get; set; }
        [JsonProperty("othermedication other specify")] public string othermedication_other_specify { get; set; }
        [JsonProperty("traditional chinese specify")] public string traditional_chinese_specify { get; set; }
        [JsonProperty("following medications other")] public string following_medications_other { get; set; }
        [JsonProperty("OAD  1")] public string DT_OAD_1 { get; set; }
        [JsonProperty("OAD  1 start")] public string DT_OAD_1_start { get; set; }
        [JsonProperty("OAD  1 after 3 month")] public string DT_OAD_1_3month { get; set; }
        [JsonProperty("OAD  1 after 6 month")] public string DT_OAD_1_6month { get; set; }
        [JsonProperty("OAD  1 after 9 month")] public string DT_OAD_1_9month { get; set; }
        [JsonProperty("OAD  1 after 12 month")] public string DT_OAD_1_12month { get; set; }
        [JsonProperty("OAD  2")] public string DT_OAD_2 { get; set; }
        [JsonProperty("OAD  2 start")] public string DT_OAD_2_start { get; set; }
        [JsonProperty("OAD  2 after 3 month")] public string DT_OAD_2_3month { get; set; }
        [JsonProperty("OAD  2 after 6 month")] public string DT_OAD_2_6month { get; set; }
        [JsonProperty("OAD  2 after 9 month")] public string DT_OAD_2_9month { get; set; }
        [JsonProperty("OAD  2 after 12 month")] public string DT_OAD_2_12month { get; set; }
        [JsonProperty("OAD  3")] public string DT_OAD_3 { get; set; }
        [JsonProperty("OAD  3 start")] public string DT_OAD_3_start { get; set; }
        [JsonProperty("OAD  3 after 3 month")] public string DT_OAD_3_3month { get; set; }
        [JsonProperty("OAD  3 after 6 month")] public string DT_OAD_3_6month { get; set; }
        [JsonProperty("OAD  3 after 9 month")] public string DT_OAD_3_9month { get; set; }
        [JsonProperty("OAD  3 after 12 month")] public string DT_OAD_3_12month { get; set; }
        [JsonProperty("OAD  4")] public string DT_OAD_4 { get; set; }
        [JsonProperty("OAD  4 start")] public string DT_OAD_4_start { get; set; }
        [JsonProperty("OAD  4 after 3 month")] public string DT_OAD_4_3month { get; set; }
        [JsonProperty("OAD  4 after 6 month")] public string DT_OAD_4_6month { get; set; }
        [JsonProperty("OAD  4 after 9 month")] public string DT_OAD_4_9month { get; set; }
        [JsonProperty("OAD  4 after 12 month")] public string DT_OAD_4_12month { get; set; }
        [JsonProperty("OAD  1 side effect")] public string DT_OAD_side_1 { get; set; }
        [JsonProperty("OAD  1 start side effect")] public string DT_OAD_side_1_start { get; set; }
        [JsonProperty("OAD  1 after 3 month side effect")] public string DT_OAD_side_1_3month { get; set; }
        [JsonProperty("OAD  1 after 6 month side effect")] public string DT_OAD_side_1_6month { get; set; }
        [JsonProperty("OAD  1 after 9 month side effect")] public string DT_OAD_side_1_9month { get; set; }
        [JsonProperty("OAD  1 after 12 month side effect")] public string DT_OAD_side_1_12month { get; set; }
        [JsonProperty("OAD  2 side effect")] public string DT_OAD_side_2 { get; set; }
        [JsonProperty("OAD  2 start side effect")] public string DT_OAD_side_2_start { get; set; }
        [JsonProperty("OAD  2 after 3 month side effect")] public string DT_OAD_side_2_3month { get; set; }
        [JsonProperty("OAD  2 after 6 month side effect")] public string DT_OAD_side_2_6month { get; set; }
        [JsonProperty("OAD  2 after 9 month side effect")] public string DT_OAD_side_2_9month { get; set; }
        [JsonProperty("OAD  2 after 12 month side effect")] public string DT_OAD_side_2_12month { get; set; }
        [JsonProperty("OAD  3 side effect")] public string DT_OAD_side_3 { get; set; }
        [JsonProperty("OAD  3 start side effect")] public string DT_OAD_side_3_start { get; set; }
        [JsonProperty("OAD  3 after 3 month side effect")] public string DT_OAD_side_3_3month { get; set; }
        [JsonProperty("OAD  3 after 6 month side effect")] public string DT_OAD_side_3_6month { get; set; }
        [JsonProperty("OAD  3 after 9 month side effect")] public string DT_OAD_side_3_9month { get; set; }
        [JsonProperty("OAD  3 after 12 month side effect")] public string DT_OAD_side_3_12month { get; set; }
        [JsonProperty("OAD  4 side effect")] public string DT_OAD_side_4 { get; set; }
        [JsonProperty("OAD  4 start side effect")] public string DT_OAD_side_4_start { get; set; }
        [JsonProperty("OAD  4 after 3 month side effect")] public string DT_OAD_side_4_3month { get; set; }
        [JsonProperty("OAD  4 after 6 month side effect")] public string DT_OAD_side_4_6month { get; set; }
        [JsonProperty("OAD  4 after 9 month side effect")] public string DT_OAD_side_4_9month { get; set; }
        [JsonProperty("OAD  4 after 12 month side effect")] public string DT_OAD_side_4_12month { get; set; }
        [JsonProperty("DT Metformin")] public string DT_Metformin { get; set; }
        [JsonProperty("DT Metformin  start side effect")] public string DT_Metformin_start { get; set; }
        [JsonProperty("DT Metformin  after 3 month side effect")] public string DT_Metformin_3month { get; set; }
        [JsonProperty("DT Metformin  after 6 month side effect")] public string DT_Metformin_6month { get; set; }
        [JsonProperty("DT Metformin  after 9 month side effect")] public string DT_Metformin_9month { get; set; }
        [JsonProperty("DT Metformin  after 12 month side effect")] public string DT_Metformin_12month { get; set; }
        [JsonProperty("Metformin side effect  Bloating")] public string DT_Metformin_Bloating { get; set; }
        [JsonProperty("Metformin side effect  Bloating start side effect")] public string DT_Metformin_Bloating_start { get; set; }
        [JsonProperty("Metformin side effect  Bloating  after 3 month side effect")] public string DT_Metformin_Bloating_3month { get; set; }
        [JsonProperty("Metformin side effect  Bloating  after 6 month side effect")] public string DT_Metformin_Bloating_6month { get; set; }
        [JsonProperty("Metformin side effect  Bloating  after 9 month side effect")] public string DT_Metformin_Bloating_9month { get; set; }
        [JsonProperty("Metformin side effect  Bloating  after 12 month side effect")] public string DT_Metformin_Bloating_12month { get; set; }
        [JsonProperty("Metformin side effect  Abdominal pain")] public string DT_Metformin_Abdominal_pain { get; set; }
        [JsonProperty("Metformin side effect  Abdominal pain start side effect")] public string DT_Metformin_Abdominal_pain_start { get; set; }
        [JsonProperty("Metformin side effect  Abdominal pain  after 3 month side effect")] public string DT_Metformin_Abdominal_pain_3month { get; set; }
        [JsonProperty("Metformin side effect  Abdominal pain  after 6 month side effect")] public string DT_Metformin_Abdominal_pain_6month { get; set; }
        [JsonProperty("Metformin side effect  Abdominal pain  after 9 month side effect")] public string DT_Metformin_Abdominal_pain_9month { get; set; }
        [JsonProperty("Metformin side effect  Abdominal pain  after 12 month side effect")] public string DT_Metformin_Abdominal_pain_12month { get; set; }
        [JsonProperty("Metformin side effect  Nausea")] public string DT_Metformin_Nausea { get; set; }
        [JsonProperty("Metformin side effect  Nausea start side effect")] public string DT_Metformin_Nausea_start { get; set; }
        [JsonProperty("Metformin side effect  Nausea  after 3 month side effect")] public string DT_Metformin_Nausea_3month { get; set; }
        [JsonProperty("Metformin side effect  Nausea  after 6 month side effect")] public string DT_Metformin_Nausea_6month { get; set; }
        [JsonProperty("Metformin side effect  Nausea after 9 month side effect")] public string DT_Metformin_Nausea_9month { get; set; }
        [JsonProperty("Metformin side effect  Nausea  after 12 month side effect")] public string DT_Metformin_Nausea_12month { get; set; }
        [JsonProperty("Metformin side effect  Diarrhea")] public string DT_Metformin_Diarrhea { get; set; }
        [JsonProperty("Metformin side effect  Diarrhea start side effect")] public string DT_Metformin_Diarrhea_start { get; set; }
        [JsonProperty("Metformin side effect  Diarrhea  after 3 month side effect")] public string DT_Metformin_Diarrhea_3month { get; set; }
        [JsonProperty("Metformin side effect  Diarrhea  after 6 month side effect")] public string DT_Metformin_Diarrhea_6month { get; set; }
        [JsonProperty("Metformin side effect  Diarrhea after 9 month side effect")] public string DT_Metformin_Diarrhea_9month { get; set; }
        [JsonProperty("Metformin side effect  Diarrhea  after 12 month side effect")] public string DT_Metformin_Diarrhea_12month { get; set; }
        [JsonProperty("Metformin side effect  Vomiting")] public string DT_Metformin_Vomiting { get; set; }
        [JsonProperty("Metformin side effect  Vomiting start side effect")] public string DT_Metformin_Vomiting_start { get; set; }
        [JsonProperty("Metformin side effect  Vomiting  after 3 month side effect")] public string DT_Metformin_Vomiting_3month { get; set; }
        [JsonProperty("Metformin side effect  Vomiting  after 6 month side effect")] public string DT_Metformin_Vomiting_6month { get; set; }
        [JsonProperty("Metformin side effect  Vomiting after 9 month side effect")] public string DT_Metformin_Vomiting_9month { get; set; }
        [JsonProperty("Metformin side effect  Vomiting  after 12 month side effect")] public string DT_Metformin_Vomiting_12month { get; set; }
        [JsonProperty("Metformin side effect  Anorexia")] public string DT_Metformin_Anorexia { get; set; }
        [JsonProperty("Metformin side effect  Anorexia start side effect")] public string DT_Metformin_Anorexia_start { get; set; }
        [JsonProperty("Metformin side effect  Anorexia  after 3 month side effect")] public string DT_Metformin_Anorexia_3month { get; set; }
        [JsonProperty("Metformin side effect  Anorexia  after 6 month side effect")] public string DT_Metformin_Anorexia_6month { get; set; }
        [JsonProperty("Metformin side effect  Anorexia after 9 month side effect")] public string DT_Metformin_Anorexia_9month { get; set; }
        [JsonProperty("Metformin side effect  Anorexia  after 12 month side effect")] public string DT_Metformin_Anorexia_12month { get; set; }
        [JsonProperty("Metformin side effect  other")] public string DT_Metformin_other { get; set; }
        [JsonProperty("Metformin side effect  other start side effect")] public string DT_Metformin_other_start { get; set; }
        [JsonProperty("Metformin side effect  other  after 3 month side effect")] public string DT_Metformin_other_3month { get; set; }
        [JsonProperty("Metformin side effect  other  after 6 month side effect")] public string DT_Metformin_other_6month { get; set; }
        [JsonProperty("Metformin side effect  other after 9 month side effect")] public string DT_Metformin_other_9month { get; set; }
        [JsonProperty("Metformin side effect  other  after 12 month side effect")] public string DT_Metformin_other_12month { get; set; }
        [JsonProperty("Diabetes Treatment- Dose and Schedule comments")] public string DT_Comments { get; set; }
        [JsonProperty("Time of Sample Collection")] public string LD_sample_time { get; set; }
        [JsonProperty("Lab Test Code")] public string LD_test_code { get; set; }
        [JsonProperty("elementary_school")] public string elementary_school { get; set; }
        [JsonProperty("elementary school value")] public string elementary_school_value { get; set; }
        [JsonProperty("high school")] public string high_school { get; set; }
        [JsonProperty("high school value")] public string high_school_value { get; set; }
        [JsonProperty("college")] public string college { get; set; }
        [JsonProperty("college value")] public string college_value { get; set; }
        [JsonProperty("graduate")] public string graduate { get; set; }
        [JsonProperty("graduate_value")] public string graduate_value { get; set; }
        [JsonProperty("other grade")] public string other_grade { get; set; }
        [JsonProperty("prefer not to disclose grade")] public string prefernottodisclose_grade { get; set; }
        [JsonProperty("emergency my mental health")] public string health_emergency_my_mental_health { get; set; }
        [JsonProperty("emergency my physical health")] public string health_emergency_my_physical_health { get; set; }
        [JsonProperty("emergency my diabetes status")] public string health_emergency_my_diabetes_status { get; set; }
        [JsonProperty("emergency Non applicable")] public string health_emergency_Non_applicable { get; set; }
        [JsonProperty("hospital my mental health")] public string health_hospital_my_mental_health { get; set; }
        [JsonProperty("hospital my physical health")] public string health_hospital_my_physical_health { get; set; }
        [JsonProperty("hospital my diabetes status")] public string health_hospital_my_diabetes_status { get; set; }
        [JsonProperty("hospital Non applicable")] public string health_hospital_Non_applicable { get; set; }
        [JsonProperty("med hepatitis type b")] public string med_hepatitis_type_b { get; set; }
        [JsonProperty("med hepatitis b year")] public string med_hepatitis_b_year { get; set; }
        [JsonProperty("med hepatitis type_c")] public string med_hepatitis_type_c { get; set; }
        [JsonProperty("med hepatitis c year")] public string med_hepatitis_c_year { get; set; }
        [JsonProperty("med hepatitis type d")] public string med_hepatitis_type_d { get; set; }
        [JsonProperty("med hepatitis d year")] public string med_hepatitis_d_year { get; set; }
        [JsonProperty("complications neuropathy other other")] public string complications_neuropathy_other_other { get; set; }
        [JsonProperty("complications Laser other other")] public string complications_Laser_other_other { get; set; }
        //old
        //[JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        //[JsonProperty("Sample Id")] public string sample { get; set; }
        //[JsonProperty("Project Title")] public string projecttitle { get; set; }
        //[JsonProperty("Principal Investigator")] public string principalinvestigator { get; set; }
        //[JsonProperty("Collection Point")] public string collection_point { get; set; }
        //[JsonProperty("Collected By")] public string collected_by { get; set; }
        //[JsonProperty("Date Of Collection")] public string collected_date { get; set; }
        //[JsonProperty("Individual/Family")] public string indifamily { get; set; }
        //[JsonProperty("Family Number")] public string family_number { get; set; }
        //[JsonProperty("Father / Mother/ Child<18 / Child >18")] public string family_yes { get; set; }
        //[JsonProperty("First Name")] public string per_firstname { get; set; }
        //[JsonProperty("Middle Name")] public string per_middlename { get; set; }
        //[JsonProperty("Last Name")] public string per_lastname { get; set; }
        //public string gender { get; set; }
        //public string age { get; set; }
        //[JsonProperty("Date Of Birth")] public string dob { get; set; }
        // public string nationality { get; set; }
        //[JsonProperty("Emirates Id")] public string emiratesid { get; set; }
        // public string PlaceOfBirth { get; set; }
        //public string city { get; set; }
        //[JsonProperty("Phone Number")] public string phone { get; set; }
        // public string email { get; set; }
        // public string ethnicity { get; set; }
        //[JsonProperty("Ethnicity Mixed")] public string ethnicity_mixed_specify_text { get; set; }
        //[JsonProperty("Ethnicity Others")] public string ethnicity_others_text { get; set; }
        //[JsonProperty("Marital Status")] public string maritalstatus { get; set; }
        //[JsonProperty("Number Of Wives")] public string pers_Numberofwives { get; set; }
        //[JsonProperty("Consanguineous")] public string marriage_con { get; set; }
        //[JsonProperty("Number Of Children")] public string pers_NumberofChildren { get; set; }
        //[JsonProperty("Boys")] public string pers_Boys { get; set; }
        //[JsonProperty("Girls")] public string pers_Girls { get; set; }
        //[JsonProperty("Children Not Applicable")] public string pers_BoysGirls { get; set; }
        //[JsonProperty("Highest Grade")] public string eduGradel { get; set; }
        //[JsonProperty("Highest Degree")] public string eduLevel { get; set; }
        //[JsonProperty("Household Living")] public string household { get; set; }
        //[JsonProperty("Household Living Children <=18")] public string household_minor { get; set; }
        //[JsonProperty("Own Primary Residence")] public string ownresidence { get; set; }
        //[JsonProperty("Current Employment Status")] public string employment_status { get; set; }
        //[JsonProperty("Kind Of Work")] public string employment_work { get; set; }
        //[JsonProperty("Night Shift")] public string employment_nightshift { get; set; }
        //[JsonProperty("Night Shift Others")] public string employment_nightshift_others { get; set; }
        //[JsonProperty("Health Past 4 Weeks")] public string health_overall_4weeks { get; set; }
        //[JsonProperty("Physical Problem Past 4 Weeks")] public string health_physical_problem_4weeks { get; set; }
        //[JsonProperty("Difficulty Past 4 Weeks")] public string health_difficulty_4weeks { get; set; }
        //[JsonProperty("Body Pain Past 4 Weeks")] public string health_body_pain_4weeks { get; set; }
        //[JsonProperty("Energy Past 4 Weeks")] public string health_energy_4weeks { get; set; }
        //[JsonProperty("Emotional Problems Past 4 Weeks")] public string health_emotional_problems_4weeks { get; set; }
        //[JsonProperty("Bothered Emotional Problems Past 4 Weeks")] public string health_bothered_emotional_problems_4weeks { get; set; }
        //[JsonProperty("Bothered Emotional Problems  Affect Work Past 4 Weeks")] public string health_bothered_emotional_problems_affect_4weeks { get; set; }
        //[JsonProperty("Brush Teeth Twice Past 4 Weeks")] public string health_brushteethtwice_4weeks { get; set; }
        //[JsonProperty("Weight Change Past Year")] public string health_weight_change { get; set; }
        //[JsonProperty("Special Diet Past 4 Weeks")] public string health_special_diet_4weeks { get; set; }
        //[JsonProperty("Bowel Movements Past 4 Weeks")] public string health_bowel_movement_4weeks { get; set; }
        //[JsonProperty("Urinate Past 4 Weeks")] public string health_urinate_4weeks { get; set; }
        //[JsonProperty("Night Urinate Past 4 Weeks")] public string health_urinate_night_4weeks { get; set; }
        //[JsonProperty("Contact Primary Care Provider Past Year")] public string health_advcontact { get; set; }
        //[JsonProperty("Emergency Room Past 3 Months")] public string health_emergency { get; set; }
        //[JsonProperty("Emergency Room Reason")] public string health_emergency_reason { get; set; }
        //[JsonProperty("Admitted Hospital Past 3 Months")] public string health_hospital { get; set; }
        //[JsonProperty("Admitted  Hospital Reason")] public string health_hospital_reason { get; set; }
        //[JsonProperty("Health Advice - No One")] public string health_advice_noone { get; set; }
        //[JsonProperty("Health Advice - Dietitian")] public string health_advice_Dietitian { get; set; }
        //[JsonProperty("Health Advice - Nurse")] public string health_advice_Nurse { get; set; }
        //[JsonProperty("Health Advice - General Practitioner")] public string health_advice_GP { get; set; }
        //[JsonProperty("Health Advice - Pharmacist")] public string health_advice_Pharmacist { get; set; }
        //[JsonProperty("Health Advice - Diabetes Specialist")] public string health_advice_Diabetes_specialist { get; set; }
        //[JsonProperty("Health Advice - Others")] public string health_advice_others { get; set; }
        //[JsonProperty("Health Advice - Remarks")] public string health_advice_others_remarks { get; set; }
        //[JsonProperty("Annual Medical Checkup")] public string health_annual_medical_checkup { get; set; }
        //[JsonProperty("First Period Year")] public string female_first_period { get; set; }
        //[JsonProperty("First Period Year Others")] public string female_first_period_others { get; set; }
        //[JsonProperty("Menopause")] public string female_menopause { get; set; }
        //[JsonProperty("Menopause Since")] public string female_menopause_others { get; set; }
        //[JsonProperty("Period Days")] public string female_period_days { get; set; }
        //[JsonProperty("How Often  Period")] public string female_period_How_often { get; set; }
        //[JsonProperty("How Often  Period Others")] public string female_period_How_often_others { get; set; }
        //[JsonProperty("Period Regular Time Intervals")] public string female_period_regular_time_intervals { get; set; }
        //[JsonProperty("Period Regular Time Intervals Yes")] public string female_period_regular_time_intervals_yes { get; set; }
        //[JsonProperty("Period Regular Time Intervals No")] public string female_period_regular_time_intervals_no { get; set; }
        //[JsonProperty("Pregnant")] public string female_pregnant { get; set; }
        //[JsonProperty("Pregnant When")] public string female_pregnant_when { get; set; }
        //[JsonProperty("Birth Control")] public string female_birth_control { get; set; }
        //[JsonProperty("Birth Control When")] public string female_birth_control_when { get; set; }
        //[JsonProperty("Birth Control Which Medication")] public string female_birth_control_Which_medication { get; set; }
        //[JsonProperty("Birth Control Dose")] public string female_birth_control_dose { get; set; }
        //[JsonProperty("Excessive Body Or Facial Hair")] public string female_facial_hair { get; set; }
        //[JsonProperty("Fg Scoring System Points")] public string female_fg_points { get; set; }
        //[JsonProperty("Vigorous Physical Activities")] public string PPA_vigorous_physical_activities { get; set; }
        //[JsonProperty("Vigorous Physical Activities Time")] public string PPA_vigorous_physical_activities_time { get; set; }
        //[JsonProperty("Moderate Physical Activities")] public string PPA_moderate_physical_activities { get; set; }
        //[JsonProperty("Moderate Physical Activities Time")] public string PPA_moderate_physical_activities_time { get; set; }
        //[JsonProperty("Walk Minium 10 Mins")] public string PPA_walk { get; set; }
        //[JsonProperty("Walk Time")] public string PPA_walk_time { get; set; }
        //[JsonProperty("Sitting On A Week Day")] public string PPA_sit { get; set; }
        //[JsonProperty("Work Last 7 Days")] public string PPA_work { get; set; }
        //[JsonProperty("Get Into Bed Hour")] public string PPA_getintobed_hour { get; set; }
        //[JsonProperty("Get Into Bed Minute")] public string PPA_getintobed_minute { get; set; }
        //[JsonProperty("Get Into Bed Am/Pm")] public string PPA_getintobed_AMPM { get; set; }
        //[JsonProperty("Get Out Bed Hour")] public string PPA_getoutbed_hour { get; set; }
        //[JsonProperty("Get Out Bed Minute")] public string PPA_getoutbed_minute { get; set; }
        //[JsonProperty("Get Out Bed Am/Pm")] public string PPA_getoutbed_AMPM { get; set; }
        //[JsonProperty("Start Work Hour")] public string PPA_startwork_hour { get; set; }
        //[JsonProperty("Start Work Minute")] public string PPA_startwork_minute { get; set; }
        //[JsonProperty("Start Work Am/Pm")] public string PPA_startwork_AMPM { get; set; }
        //[JsonProperty("Leave Work Hour")] public string PPA_leavework_hour { get; set; }
        //[JsonProperty("Leave Work Minute")] public string PPA_leavework_minute { get; set; }
        //[JsonProperty("Leave Work Am/Pm")] public string PPA_leavework_AMPM { get; set; }
        //[JsonProperty("Work Hours Your Desk %")] public string PPA_workhours_yourdeskperc { get; set; }
        //[JsonProperty("Work Hours Away From Desk %")] public string PPA_workhours_awaydeskperc { get; set; }
        //[JsonProperty("Work Hours Sitting Your Desk %")] public string PPA_workhours_yourdeskperc_sitting { get; set; }
        //[JsonProperty("Work Hours Standing Your Desk %")] public string PPA_workhours_yourdeskperc_standing { get; set; }
        //[JsonProperty("Work Hours Moving Your Desk %")] public string PPA_workhours_yourdeskperc_moving { get; set; }
        //[JsonProperty("Work Hours Sitting Away Desk %")] public string PPA_workhours_awaydeskperc_sitting { get; set; }
        //[JsonProperty("Work Hours Standing Away Desk %")] public string PPA_workhours_awaydeskperc_standing { get; set; }
        //[JsonProperty("Work Hours Moving Away Desk %")] public string PPA_workhours_awaydeskperc_moving { get; set; }
        //[JsonProperty("Sit  Transport Non Work Hours Work Days")] public string PPA_sit_transport_nonworkhours_workdays { get; set; }
        //[JsonProperty("Sit Transport Non Work Hours")] public string PPA_sit_transport_nonworkhours_hours { get; set; }
        //[JsonProperty("Sit Transport Non Work Minutes")] public string PPA_sit_transport_nonworkhours_mininutes { get; set; }
        //[JsonProperty("Sit Transport Non Work Days")] public string PPA_sit_transport_nonworkdays { get; set; }
        //[JsonProperty("Sit Transport Non Workdays Hours")] public string PPA_sit_transport_nonwork_hours { get; set; }
        //[JsonProperty("Sit Transort Non Workdays Minutes")] public string PPA_sit_transport_nonwork_mininutes { get; set; }
        //[JsonProperty("Sit  Tv Non Work Hours Work Days")] public string PPA_sit_tv_nonworkhours_workdays { get; set; }
        //[JsonProperty("Sit Tv Non Work Hours")] public string PPA_sit_tv_nonworkhours_hours { get; set; }
        //[JsonProperty("Sit Tv Non Work Minutes")] public string PPA_sit_tv_nonworkhours_mininutes { get; set; }
        //[JsonProperty("Sit Tv Non Work Days")] public string PPA_sit_tv_nonworkdays { get; set; }
        //[JsonProperty("Sit Tv Non Workdays Hours")] public string PPA_sit_tv_nonwork_hours { get; set; }
        //[JsonProperty("Sit Tv Non Workdays Minutes")] public string PPA_sit_tv_nonwork_mininutes { get; set; }
        //[JsonProperty("Sit  Computer Non Work Hours Work Days")] public string PPA_sit_computer_nonworkhours_workdays { get; set; }
        //[JsonProperty("Sit Computer Non Work Hours")] public string PPA_sit_computer_nonworkhours_hours { get; set; }
        //[JsonProperty("Sit Computer Non Work Minutes")] public string PPA_sit_computer_nonworkhours_mininutes { get; set; }
        //[JsonProperty("Sit Computer Non Work Days")] public string PPA_sit_computer_nonworkdays { get; set; }
        //[JsonProperty("Sit Computer Non Workdays Hours")] public string PPA_sit_computer_nonwork_hours { get; set; }
        //[JsonProperty("Sit Computer Non Workdays Minutes")] public string PPA_sit_computer_nonwork_mininutes { get; set; }
        //[JsonProperty("Sit  Others Non Work Hours Work Days")] public string PPA_sit_others_nonworkhours_workdays { get; set; }
        //[JsonProperty("Sit Others Non Work Hours")] public string PPA_sit_others_nonworkhours_hours { get; set; }
        //[JsonProperty("Sit Others Non Work Minutes")] public string PPA_sit_others_nonworkhours_mininutes { get; set; }
        //[JsonProperty("Sit Others Non Work Days")] public string PPA_sit_others_nonworkdays { get; set; }
        //[JsonProperty("Sit Others Non Workdays Hours")] public string PPA_sit_others_nonwork_hours { get; set; }
        //[JsonProperty("Sit Others Non Workdays Minutes")] public string PPA_sit_others_nonwork_mininutes { get; set; }
        //[JsonProperty("Eat A Portion Of Vegetables")] public string PD_eat_vegetables { get; set; }
        //[JsonProperty("Eat A Portion Of Fruit")] public string PD_eat_fruit { get; set; }
        //[JsonProperty("Eat  Cake")] public string PD_eat_cake { get; set; }
        //[JsonProperty("Eat  Sugary Drinks")] public string PD_eat_sugary_drinks { get; set; }
        //[JsonProperty("Eat  Full Fat Spread")] public string PD_eat_fullfat_spread { get; set; }
        //[JsonProperty("Eat  Full Fat Cheese")] public string PD_eat_fullfat_cheese { get; set; }
        //[JsonProperty("Eat Processed Meat")] public string PD_eat_processed_meat { get; set; }
        //[JsonProperty("Eat Savory Food")] public string PD_eat_savory_food { get; set; }
        //[JsonProperty("Eat Savory Pastry")] public string PD_eat_savory_pastry { get; set; }
        //[JsonProperty("Eat Fast Food")] public string PD_eat_fast_food { get; set; }
        //[JsonProperty("Prepare Meal At Home")] public string PD_eat_meal_at_home { get; set; }
        //[JsonProperty("Eat Pudding")] public string PD_eat_pudding { get; set; }
        //[JsonProperty("Eat Oily Fish")] public string PD_eat_oilyfish { get; set; }
        //[JsonProperty("Eat Regular Meals")] public string PD_eat_regular_meals { get; set; }
        //[JsonProperty("Eat Breakfast")] public string PD_eat_breakfast { get; set; }
        //[JsonProperty("Eat Snack Between Meals")] public string PD_eat_snack_between_meals { get; set; }
        //[JsonProperty("Eat Portion Of Bread")] public string PD_eat_portion_bread { get; set; }
        //[JsonProperty("Eat High Fiber Bread")] public string PD_eat_highfiber_bread { get; set; }
        //[JsonProperty("Eat Bowl Of Breakfast")] public string PD_eat_bowl_breakfast { get; set; }
        //[JsonProperty("Eat High Fiber Cereals")] public string PD_eat_bowl_highfiber { get; set; }
        //[JsonProperty("Eat Milk Type")] public string PD_milk_type { get; set; }
        //[JsonProperty("Eat Milk Type  Others")] public string PD_milk_type_others { get; set; }
        //[JsonProperty("Weight Concern")] public string PD_weight_concern { get; set; }
        //[JsonProperty("Important Change Diet")] public string PD_important_change_diet { get; set; }
        //[JsonProperty("Confident Change Diet")] public string PD_confident_change_diet { get; set; }
        //[JsonProperty("Unable To Control Important Things")] public string PSE_unable_to_control { get; set; }
        //[JsonProperty("Handle Personal Problems")] public string PSE_handle_problem { get; set; }
        //[JsonProperty("Things Going Your Way")] public string PSE_yourway { get; set; }
        //[JsonProperty("Difficultly Handle Personal Problems")] public string PSE_difficulty_handle_problem { get; set; }
        //[JsonProperty("Little Interest")] public string PSE_little_interest { get; set; }
        //[JsonProperty("Depressed")] public string PSE_depressed { get; set; }
        //[JsonProperty("Sleeping Toomuch")] public string PSE_sleeping_toomuch { get; set; }
        //[JsonProperty("Little Energy")] public string PSE_little_energy { get; set; }
        //[JsonProperty("Poor Apetitite Or Overeating")] public string PSE_overeating { get; set; }
        //[JsonProperty("Feeling Bad")] public string PSE_feelingbad { get; set; }
        //[JsonProperty("Concentrating  Trouble")] public string PSE_concentrating_trouble { get; set; }
        //[JsonProperty("Fidgery Or Restless")] public string PSE_restless { get; set; }
        //[JsonProperty("Thought Of Dead")] public string PSE_dead_thoughts { get; set; }
        //[JsonProperty("Get Along With Others")] public string PSE_get_along { get; set; }
        //[JsonProperty("Diffculty Falling Asleep")] public string PSH_falling_asleep { get; set; }
        //[JsonProperty("Diffculty Staying Asleep")] public string PSH_staying_asleep { get; set; }
        //[JsonProperty("Wakeup Too Early")] public string PSH_wakeup_tooearly { get; set; }
        //[JsonProperty("Satisfied_Sleep_Pattern")] public string PSH_satisfied_sleep_pattern { get; set; }
        //[JsonProperty("Noticeable Sleeping Problem")] public string PSH_noticeable_sleeping_problem { get; set; }
        //[JsonProperty("Worried Sleeping Problem")] public string PSH_worried_sleeping_problem { get; set; }
        //[JsonProperty("Interfere Sleeping Problem")] public string PSH_interfere_sleeping_problem { get; set; }
        //[JsonProperty("Smoked 100 Cigarettes")] public string PSS_smoked_100_cigarettes { get; set; }
        //[JsonProperty("First Smoke Age")] public string PSS_first_smoke_age { get; set; }
        //[JsonProperty("Current Smoker")] public string PSS_current_smoker { get; set; }
        //[JsonProperty("Quit_Smoking")] public string PSS_quit_smoking { get; set; }
        //[JsonProperty("Quit_Smoking Since 1 Year")] public string PSS_quit_smoking_since1year { get; set; }
        //[JsonProperty("Average Cigarettes  Per Day")] public string PSS_avg_cigarettes_perday { get; set; }
        //[JsonProperty("Cigarettes  Past 30 Days")] public string PSS_cigarettes_30days { get; set; }
        //[JsonProperty("Average Cigarettes  Past 30 Days")] public string PSS_avg_cigarettes_30days { get; set; }
        //[JsonProperty("Trying To Quit Smoke")] public string PSS_trying_quit_smoke { get; set; }
        //[JsonProperty("Father Ethnicity")] public string fam_fatethnicity { get; set; }
        //[JsonProperty("Father Ethnicity Other")] public string fam_fatethnicity_other { get; set; }
        //[JsonProperty("Father Place Of Birth")] public string fam_fatplaceofbirth { get; set; }
        //[JsonProperty("Mother Ethnicity")] public string fam_motethnicity { get; set; }
        //[JsonProperty("Mother Ethnicity Other")] public string fam_motethnicity_other { get; set; }
        //[JsonProperty("Mother Place Of Birth")] public string fam_motplaceofbirth { get; set; }
        //[JsonProperty("Parents Related")] public string fam_parents_related { get; set; }
        //[JsonProperty("Related Remarks")] public string fam_parents_related_yes { get; set; }
        //[JsonProperty("Epilepsy In Family")] public string fam_Epilepsy { get; set; }
        //[JsonProperty("Depression In Family")] public string fam_dep { get; set; }
        //[JsonProperty("Bipolar Disorder In Family")] public string fam_Bipolar { get; set; }
        //[JsonProperty("Schizophrenia In Family")] public string fam_Schizophrenia { get; set; }
        //[JsonProperty("Post-Traumatic Stress Syndrome In Family")] public string fam_traumatic_stress { get; set; }
        //[JsonProperty("Asthma In Family")] public string fam_Asthma { get; set; }
        //[JsonProperty("Thyroid Problem In Family")] public string fam_Thyroid { get; set; }
        //[JsonProperty("Rheumatoid Arthritis In Family")] public string fam_Rheumatoid_Arthritis { get; set; }
        //[JsonProperty("Liver Disease In Family")] public string fam_Liver { get; set; }
        //[JsonProperty("Cancer In Family")] public string fam_cancer { get; set; }
        //[JsonProperty("Cancer Type Condition")] public string fam_condition_cancer_type { get; set; }
        //[JsonProperty("Other Disease In Family")] public string fam_other { get; set; }
        //[JsonProperty("Other Disease In Family Remarks")] public string fam_condition_other { get; set; }
        //[JsonProperty("Hypertension In Family")] public string fam_hypertension { get; set; }
        //[JsonProperty("Heart Disease Family")] public string fam_heart { get; set; }
        //[JsonProperty("High Cholesterol In Family")] public string fam_High_cholesterol { get; set; }
        //[JsonProperty("Obesity In Family")] public string fam_Obesity { get; set; }
        //[JsonProperty("Osteoporosis In Family")] public string fam_osteo { get; set; }
        //[JsonProperty("Type1 Diabetes In Family")] public string fam_type1 { get; set; }
        //[JsonProperty("Type2 Diabetes In Family")] public string fam_type2 { get; set; }
        //[JsonProperty("Gestational Diabetes In Family")] public string fam_gesdia { get; set; }
        //[JsonProperty("Alzheimer  In Family")] public string fam_Alzheimer { get; set; }
        //[JsonProperty("Parkinson  In Family")] public string fam_Parkinsons { get; set; }
        //[JsonProperty("Patients Family Pedigree")] public string fam_pedigree { get; set; }
        //[JsonProperty("Hypertension")] public string med_hypertension { get; set; }
        //[JsonProperty("Hypertension Year")] public string med_hypertension_year { get; set; }
        //[JsonProperty("Prediabetes")] public string med_Prediabetes { get; set; }
        //[JsonProperty("Prediabetes Year")] public string med_Prediabetes_year { get; set; }
        //[JsonProperty("Type 2 Diabetes")] public string med_type2diabetes { get; set; }
        //[JsonProperty("Type 2 Diabetes Year")] public string med_type2diabetes_year { get; set; }
        //[JsonProperty("Gestational Diabetes")] public string med_Gestational_Diabetes { get; set; }
        //[JsonProperty("Gestational Diabetes  Year")] public string med_Gestational_Diabetes_year { get; set; }
        //[JsonProperty("Type 1 Diabetes")] public string med_type1diabetes { get; set; }
        //[JsonProperty("Type 1 Diabetes Year")] public string med_type1diabetes_year { get; set; }
        //[JsonProperty("High Cholesterol")] public string med_highcholesterol { get; set; }
        //[JsonProperty("High Cholesterol Year")] public string med_highcholesterol_year { get; set; }
        //[JsonProperty("Obesity")] public string med_obesity { get; set; }
        //[JsonProperty("Obesity Year")] public string med_obesity_year { get; set; }
        //[JsonProperty("Heart Disease")] public string med_heartdis { get; set; }
        //[JsonProperty("Heart Disease Year")] public string med_heartdis_year { get; set; }
        //[JsonProperty("Cancer")] public string med_cancer { get; set; }
        //[JsonProperty("Cancer Year")] public string med_cancer_year { get; set; }
        //[JsonProperty("Osteoporosis")] public string med_osteoporosis { get; set; }
        //[JsonProperty("Osteoporosis Year")] public string med_osteoporosis_year { get; set; }
        //[JsonProperty("Asthma")] public string med_asthma { get; set; }
        //[JsonProperty("Asthma Year")] public string med_asthma_year { get; set; }
        //[JsonProperty("Thyroid Problem")] public string med_thyroid { get; set; }
        //[JsonProperty("Thyroid Other Problem")] public string med_thyroid_other { get; set; }
        //[JsonProperty("Thyroid Problem Year")] public string med_thyroid_year { get; set; }
        //[JsonProperty("Liver Disease")] public string med_liver { get; set; }
        //[JsonProperty("Liver Disease Year")] public string med_liver_year { get; set; }
        //[JsonProperty("Arthritis Rheumatism")] public string med_arthritis { get; set; }
        //[JsonProperty("Arthritis Rheumatism Year")] public string med_arthritis_year { get; set; }
        //[JsonProperty("Hepatitis A-B-C-D")] public string med_hepatitis { get; set; }
        //[JsonProperty("Hepatitis A-B-C-D Year")] public string med_hepatitis_year { get; set; }
        //[JsonProperty("Anxiety")] public string med_Anxiety { get; set; }
        //[JsonProperty("Anxiety  Year")] public string med_Anxiety_year { get; set; }
        //[JsonProperty("Depression")] public string med_depression { get; set; }
        //[JsonProperty("Depression Year")] public string med_depression_year { get; set; }
        //[JsonProperty("Bipolar Disorder")] public string med_Bipolar { get; set; }
        //[JsonProperty("Bipolar Disorder Year")] public string med_Bipolar_year { get; set; }
        //[JsonProperty("Schizophrenia")] public string med_Schizophrenia { get; set; }
        //[JsonProperty("Schizophrenia Year")] public string med_Schizophrenia_year { get; set; }
        //[JsonProperty("Post-Traumatic Stress Disorder")] public string med_PTSD { get; set; }
        //[JsonProperty("Post-Traumatic Stress Disorder  Year")] public string med_PTSD_year { get; set; }
        //[JsonProperty("Psychiatric Disorder Others")] public string med_Psychiatric_other { get; set; }
        //[JsonProperty("Psychiatric Disorder Others Name")] public string med_Psychiatric_other_specify { get; set; }
        //[JsonProperty("Psychiatric Disorder Others Year")] public string med_Psychiatric_other_year { get; set; }
        //[JsonProperty("Alzheimer  Disease")] public string med_Alzheimer { get; set; }
        //[JsonProperty("Alzheimer  Disease Year")] public string med_Alzheimer_year { get; set; }
        //[JsonProperty("Parkinson  Disease")] public string med_Parkinson { get; set; }
        //[JsonProperty("Parkinson Disease Year")] public string med_Parkinson_year { get; set; }
        //[JsonProperty("Epilepsy")] public string med_Epilepsy { get; set; }
        //[JsonProperty("Epilepsy Year")] public string med_Epilepsy_year { get; set; }
        //[JsonProperty("Other Neurological Disorders")] public string med_Other_neurological { get; set; }
        //[JsonProperty("Other Neurological Disorders  Name")] public string med_Other_neurological_text { get; set; }
        //[JsonProperty("Other Neurological Disorders Year")] public string med_Other_neurological_year { get; set; }
        //[JsonProperty("Inherited Disease")] public string med_inheriteddis { get; set; }
        //[JsonProperty("Inherited Disease Name")] public string med_inheriteddis_text { get; set; }
        //[JsonProperty("Inherited Disease Year")] public string med_inheriteddis_year { get; set; }
        //[JsonProperty("Other Disease")] public string med_other { get; set; }
        //[JsonProperty("Other Disease  Name")] public string med_other_specify { get; set; }
        //[JsonProperty("Other Disease  Year")] public string med_other_year { get; set; }
        //[JsonProperty("Allergies")] public string allergies { get; set; }
        //[JsonProperty("Allergies Remarks")] public string allergies_yestxt { get; set; }
        //[JsonProperty("Intolerance")] public string intolerance { get; set; }
        //[JsonProperty("Intolerance Remarks")] public string intolerance_yestxt { get; set; }
        //[JsonProperty("Surgery")] public string med_surgery { get; set; }
        //[JsonProperty("Surgery Remarks")] public string med_surgery_yestxt { get; set; }
        //[JsonProperty("Surgery Year")] public string med_surgery_year { get; set; }
        //[JsonProperty("Medication For Hypertension")] public string medication_hypertension { get; set; }
        //[JsonProperty("Medication For Hypertension Specify")] public string medication_hypertension_specify { get; set; }
        //[JsonProperty("Medication For Hypertension Year")] public string medication_hypertension_year { get; set; }
        //[JsonProperty("Medication For Prediabetes")] public string medication_Prediabetes { get; set; }
        //[JsonProperty("Medication For Prediabetes Specify")] public string medication_Prediabetes_specify { get; set; }
        //[JsonProperty("Medication For Prediabetes Year")] public string medication_Prediabetes_year { get; set; }
        //[JsonProperty("Medication For Type1 Diabetes")] public string medication_type1 { get; set; }
        //[JsonProperty("Medication For Type1 Diabetes Specify")] public string medication_type1_specify { get; set; }
        //[JsonProperty("Medication For Type1 Diabetes Year")] public string medication_type1_year { get; set; }
        //[JsonProperty("Medication For Type2 Diabetes")] public string medication_type2 { get; set; }
        //[JsonProperty("Medication For Type2 Diabetes Specify")] public string medication_type2_specify { get; set; }
        //[JsonProperty("Medication For Type2 Diabetes Year")] public string medication_type2_year { get; set; }
        //[JsonProperty("Medication For High Cholestrol")] public string medication_choles { get; set; }
        //[JsonProperty("Medication For High Cholestrol Specify")] public string medication_choles_specify { get; set; }
        //[JsonProperty("Medication For High Cholestrol Year")] public string medication_choles_year { get; set; }
        //[JsonProperty("Medication For Obesity")] public string medication_obe { get; set; }
        //[JsonProperty("Medication For Obesity Specify")] public string medication_obe_specify { get; set; }
        //[JsonProperty("Medication For Obesity Year")] public string medication_obe_year { get; set; }
        //[JsonProperty("Medication For Heart Disease")] public string medication_heart { get; set; }
        //[JsonProperty("Medication For Heart Disease Specify")] public string medication_heart_specify { get; set; }
        //[JsonProperty("Medication For Heart Disease Year")] public string medication_heart_year { get; set; }
        //[JsonProperty("Medication For Cancer")] public string medication_cancer { get; set; }
        //[JsonProperty("Medication For Cancer Specify")] public string medication_cancer_specify { get; set; }
        //[JsonProperty("Medication For Cancer Year")] public string medication_cancer_year { get; set; }
        //[JsonProperty("Medication For Anxiety  Disorder")] public string medication_Anxiety { get; set; }
        //[JsonProperty("Medication For Anxiety  Disorder Specify")] public string medication_Anxiety_specify { get; set; }
        //[JsonProperty("Medication For Anxiety  Disorder Year")] public string medication_Anxiety_year { get; set; }
        //[JsonProperty("Medication For Depression")] public string medication_dep { get; set; }
        //[JsonProperty("Medication For Depression Specify")] public string medication_dep_specify { get; set; }
        //[JsonProperty("Medication For Depression Year")] public string medication_dep_year { get; set; }
        //[JsonProperty("Medication For Bipolar  Disorder")] public string medication_Bipolar { get; set; }
        //[JsonProperty("Medication For Bipolar  Disorder Specify")] public string medication_Bipolar_specify { get; set; }
        //[JsonProperty("Medication For Bipolar  Disorder Year")] public string medication_Bipolar_year { get; set; }
        //[JsonProperty("Medication For Schizophrenia")] public string medication_Schizophrenia { get; set; }
        //[JsonProperty("Medication For Schizophrenia Specify")] public string medication_Schizophrenia_specify { get; set; }
        //[JsonProperty("Medication For Schizophrenia Year")] public string medication_Schizophrenia_year { get; set; }
        //[JsonProperty("Medication For Post-Traumatic Stress Disorder")] public string medication_PTSD { get; set; }
        //[JsonProperty("Medication For Post-Traumatic Stress Disorder Specify")] public string medication_PTSD_specify { get; set; }
        //[JsonProperty("Medication For Post-Traumatic Stress Disorder Year")] public string medication_PTSD_year { get; set; }
        //[JsonProperty("Medication For Other Psychiatric Disorder")] public string medication_Other_Psychiatric_disorder { get; set; }
        //[JsonProperty("Medication For Other Psychiatric Disorder Specify")] public string medication_Other_Psychiatric_disorder_specify { get; set; }
        //[JsonProperty("Medication For Other Psychiatric Disorder Year")] public string medication_Other_Psychiatric_disorder_year { get; set; }
        //[JsonProperty("Medication For Osteoporosis")] public string medication_osteo { get; set; }
        //[JsonProperty("Medication For Osteoporosis Specify")] public string medication_osteo_specify { get; set; }
        //[JsonProperty("Medication For Osteoporosis Year")] public string medication_osteo_year { get; set; }
        //[JsonProperty("Medication For Asthma")] public string medication_asth { get; set; }
        //[JsonProperty("Medication For Asthma Specify")] public string medication_asth_specify { get; set; }
        //[JsonProperty("Medication For Asthma Year")] public string medication_asth_year { get; set; }
        //[JsonProperty("Medication For Endocrine Disorders")] public string medication_Endocrine_disorders { get; set; }
        //[JsonProperty("Medication For Endocrine Disorders Specify")] public string medication_Endocrine_disorders_specify { get; set; }
        //[JsonProperty("Medication For Endocrine Disorders Year")] public string medication_Endocrine_disorders_year { get; set; }
        //[JsonProperty("Medication For Headache/Migraine")] public string medication_migraine { get; set; }
        //[JsonProperty("Medication For Headache/Migraine Specify")] public string medication_migraine_specify { get; set; }
        //[JsonProperty("Medication For Headache/Migraine Year")] public string medication_migraine_year { get; set; }
        //[JsonProperty("Medication For Alzheimer Disease")] public string medication_Alzheimer { get; set; }
        //[JsonProperty("Medication For Alzheimer Disease Specify")] public string medication_Alzheimer_specify { get; set; }
        //[JsonProperty("Medication For Alzheimer Disease Year")] public string medication_Alzheimer_year { get; set; }
        //[JsonProperty("Medication For Parkinson Disease")] public string medication_Parkinson { get; set; }
        //[JsonProperty("Medication For Parkinson Disease Specify")] public string medication_Parkinson_specify { get; set; }
        //[JsonProperty("Medication For Parkinson Disease Year")] public string medication_Parkinson_year { get; set; }
        //[JsonProperty("Medication For Epilepsy/Seizures")] public string medication_Epilepsy { get; set; }
        //[JsonProperty("Medication For Epilepsy/Seizures Specify")] public string medication_Epilepsy_specify { get; set; }
        //[JsonProperty("Medication For Epilepsy/Seizures Year")] public string medication_Epilepsy_year { get; set; }
        //[JsonProperty("Medication For Other Neurological Disorder")] public string medication_Other_neurological { get; set; }
        //[JsonProperty("Medication For Other Neurological Disorder Specify")] public string medication_Other_neurological_specify { get; set; }
        //[JsonProperty("Medication For Other Neurological Disorder Year")] public string medication_Other_neurological_year { get; set; }
        //[JsonProperty("Medication For Others")] public string medication_Other { get; set; }
        //[JsonProperty("Medication For Others Specify")] public string medication_Other_specify { get; set; }
        //[JsonProperty("Medication For Others Year")] public string medication_Other_year { get; set; }
        //[JsonProperty("No Medication")] public string medication_none { get; set; }
        //[JsonProperty("Supplements")] public string medication_Supplements { get; set; }
        //[JsonProperty("Supplements Specify")] public string medication_Supplements_specify { get; set; }
        //[JsonProperty("Supplements Year")] public string medication_Supplements_year { get; set; }
        //[JsonProperty("Vaccinations  Past 4 Weeks")] public string med_vaccine { get; set; }
        //[JsonProperty("Flu Shot Past 12 Months")] public string med_flushot { get; set; }
        //[JsonProperty("Blood Sugar Levels With Care")] public string DSM_blood_sugar_levels_with_care { get; set; }
        //[JsonProperty("Achieve Optimal Blood Sugar Level")] public string DSM_achieve_optimal_blood_sugar_level { get; set; }
        //[JsonProperty("Keep All Doctors Appointments")] public string DSM_keep_doctors_appointments { get; set; }
        //[JsonProperty("Take My Diabetes Medication")] public string DSM_take_diabetes_medication { get; set; }
        //[JsonProperty("Occasionally I Eat Lots Of Sweets")] public string DSM_Occasionally_eat_sweets { get; set; }
        //[JsonProperty("Record My Blood Sugar")] public string DSM_record_blood_sugar { get; set; }
        //[JsonProperty("Avoid Diabetes-Related Doctors Appointments")] public string DSM_avoid_diabetes_related_appointments { get; set; }
        //[JsonProperty("Physically Active")] public string DSM_physically_active { get; set; }
        //[JsonProperty("Follow The Dietary Recommendations")] public string DSM_follow_dietary_recommendations { get; set; }
        //[JsonProperty("Do Not Check My Blood Sugar Levels")] public string DSM_do_not_check_blood_sugar_levels { get; set; }
        //[JsonProperty("Avoid Physical Activity")] public string DSM_avoid_physical_activity { get; set; }
        //[JsonProperty("Skip Medication")] public string DSM_skip_medication { get; set; }
        //[JsonProperty("Food Binges")] public string DSM_food_binges { get; set; }
        //[JsonProperty("Should See Medical Practitioner(S) More Often")] public string DSM_morevisit { get; set; }
        //[JsonProperty("Less Physically Active")] public string DSM_less_physically_active { get; set; }
        //[JsonProperty("Self-Care Is Poor")] public string DSM_self_care_poor { get; set; }
        //[JsonProperty("Diabetes Treatment None")] public string DSM_DiabetesTreatment_none { get; set; }
        //[JsonProperty("Diabetes Treatment 1 Name")] public string DSM_DiabetesTreatment_1name { get; set; }
        //[JsonProperty("Diabetes Treatment 1 Year")] public string DSM_DiabetesTreatment_1year { get; set; }
        //[JsonProperty("Diabetes Treatment 2 Name")] public string DSM_DiabetesTreatment_2name { get; set; }
        //[JsonProperty("Diabetes Treatment 2 Year")] public string DSM_DiabetesTreatment_2year { get; set; }
        //[JsonProperty("Diabetes Treatment 3 Name")] public string DSM_DiabetesTreatment_3name { get; set; }
        //[JsonProperty("Diabetes Treatment 3 Year")] public string DSM_DiabetesTreatment_3year { get; set; }
        //[JsonProperty("Diabetes Treatment 4 Name")] public string DSM_DiabetesTreatment_4name { get; set; }
        //[JsonProperty("Diabetes Treatment 4 Year")] public string DSM_DiabetesTreatment_4year { get; set; }
        //[JsonProperty("Stop Medication Past 6 Months")] public string DSM_stop_medication { get; set; }
        //[JsonProperty("Stop Medication Name")] public string DSM_stop_medication_name { get; set; }
        //[JsonProperty("Stop Medication Reason")] public string DSM_stop_medication_reason { get; set; }
        //[JsonProperty("Stop Diabetic Medication  1 Name")] public string DSM_stop_medication_1name { get; set; }
        //[JsonProperty("Stop Diabetic Medication  1 Reason")] public string DSM_stop_medication_1reason { get; set; }
        //[JsonProperty("Stop Diabetic Medication  2 Name")] public string DSM_stop_medication_2name { get; set; }
        //[JsonProperty("Stop Diabetic Medication 2  Reason")] public string DSM_stop_medication_2reason { get; set; }
        //[JsonProperty("Stop Diabetic Medication  3 Name")] public string DSM_stop_medication_3name { get; set; }
        //[JsonProperty("Stop Diabetic Medication  3 Reason")] public string DSM_stop_medication_3reason { get; set; }
        //[JsonProperty("Stop Diabetic Medication 4 Name")] public string DSM_stop_medication_4name { get; set; }
        //[JsonProperty("Stop Diabetic Medication  4 Reason")] public string DSM_stop_medication_4reason { get; set; }
        //[JsonProperty("Medication Yesterday")] public string DSM_medication_yesterday { get; set; }
        //[JsonProperty("Prescribed Metformin")] public string DSM_prescribed_metformin { get; set; }
        //[JsonProperty("Take Metformin")] public string DSM_take_metformin { get; set; }
        //[JsonProperty("How Often Take Metformin")] public string DSM_take_metformin_period { get; set; }
        //[JsonProperty("Past Week Take Metformin")] public string DSM_take_metformin_pastweek { get; set; }
        //[JsonProperty("Metformin Days")] public string DSM_take_metformin_days { get; set; }
        //[JsonProperty("Metformin Times")] public string DSM_take_metformin_times { get; set; }
        //[JsonProperty("Howmuch Metformin")] public string DSM_take_metformin_qty { get; set; }
        //[JsonProperty("Metformin Missed")] public string DSM_take_metformin_missed { get; set; }
        //[JsonProperty("Metformin Works")] public string DSM_take_metformin_works { get; set; }
        //[JsonProperty("Metformin Bothers")] public string DSM_take_metformin_bothers { get; set; }
        //[JsonProperty("Hard To Remember")] public string DSM_difficulty_hard_to_remember { get; set; }
        //[JsonProperty("Hard To Pay")] public string DSM_difficulty_hard_to_pay { get; set; }
        //[JsonProperty("Hard To Refill")] public string DSM_difficulty_hard_to_refill { get; set; }
        //[JsonProperty("Unwanted Side Effect")] public string DSM_difficulty_unwanted_side_effect { get; set; }
        //[JsonProperty("Other Concern")] public string DSM_difficulty_other_concern { get; set; }
        //[JsonProperty("Metformin Discomfort Nausea")] public string DSM_discomfort_Nausea { get; set; }
        //[JsonProperty("Metformin Discomfort Vomiting")] public string DSM_discomfort_Vomiting { get; set; }
        //[JsonProperty("Metformin Discomfort Diarrhea")] public string DSM_discomfort_Diarrhea { get; set; }
        //[JsonProperty("Metformin Discomfort Abdominal Pain")] public string DSM_discomfort_Abdominal_pain { get; set; }
        //[JsonProperty("Metformin Discomfort Bloating")] public string DSM_discomfort_Bloating { get; set; }
        //[JsonProperty("Metformin Loss Of Appetite")] public string DSM_discomfort_Loss_of_appetite { get; set; }
        //[JsonProperty("Metformin Anorexia")] public string DSM_Metformin_anorexia { get; set; }
        //[JsonProperty("1Oad Medication Name")] public string DSM_1OAD_Name { get; set; }
        //[JsonProperty("1Oad Period")] public string DSM_1OAD_Period { get; set; }
        //[JsonProperty("Take 1Oad Past Week")] public string DSM_1OAD_take { get; set; }
        //[JsonProperty("1Oad Days")] public string DSM_1OAD_days { get; set; }
        //[JsonProperty("1Oad Times")] public string DSM_1OAD_times { get; set; }
        //[JsonProperty("How Much 1Oad")] public string DSM_1OAD_qty { get; set; }
        //[JsonProperty("1Oad Miss")] public string DSM_1OAD_miss { get; set; }
        //[JsonProperty("1Oad Works")] public string DSM_1OAD_works { get; set; }
        //[JsonProperty("1Oad Bothers")] public string DSM_1OAD_bothers { get; set; }
        //[JsonProperty("1Oad Difficulty - Hard To Remeber")] public string DSM_1OAD_Difficulty_hard_to_remember { get; set; }
        //[JsonProperty("1Oad Difficulty - Hard To Pay")] public string DSM_1OAD_Difficulty_hard_to_pay { get; set; }
        //[JsonProperty("1Oad Difficulty - Hard To Refill")] public string DSM_1OAD_Difficulty_hard_to_refill { get; set; }
        //[JsonProperty("1Oad Difficulty - Unwanted Side Effect")] public string DSM_1OAD_Difficulty_unwanted_side_effect { get; set; }
        //[JsonProperty("1Oad Difficulty - Other Concern")] public string DSM_1OAD_Difficulty_other_concern { get; set; }
        //[JsonProperty("2Oad Medication Name")] public string DSM_2OAD_Name { get; set; }
        //[JsonProperty("2Oad Period")] public string DSM_2OAD_Period { get; set; }
        //[JsonProperty("Take 2Oad Past Week")] public string DSM_2OAD_take { get; set; }
        //[JsonProperty("2Oad Days")] public string DSM_2OAD_days { get; set; }
        //[JsonProperty("2Oad Times")] public string DSM_2OAD_times { get; set; }
        //[JsonProperty("How Much 2Oad")] public string DSM_2OAD_qty { get; set; }
        //[JsonProperty("2Oad Miss")] public string DSM_2OAD_miss { get; set; }
        //[JsonProperty("2Oad Works")] public string DSM_2OAD_works { get; set; }
        //[JsonProperty("2Oad Bothers")] public string DSM_2OAD_bothers { get; set; }
        //[JsonProperty("2Oad Difficulty - Hard To Remeber")] public string DSM_2OAD_Difficulty_hard_to_remember { get; set; }
        //[JsonProperty("2Oad Difficulty - Hard To Pay")] public string DSM_2OAD_Difficulty_hard_to_pay { get; set; }
        //[JsonProperty("2Oad Difficulty - Hard To Refill")] public string DSM_2OAD_Difficulty_hard_to_refill { get; set; }
        //[JsonProperty("2Oad Difficulty - Unwanted Side Effect")] public string DSM_2OAD_Difficulty_unwanted_side_effect { get; set; }
        //[JsonProperty("2Oad Difficulty - Other Concern")] public string DSM_2OAD_Difficulty_other_concern { get; set; }
        //[JsonProperty("3Oad Medication Name")] public string DSM_3OAD_Name { get; set; }
        //[JsonProperty("3Oad Period")] public string DSM_3OAD_Period { get; set; }
        //[JsonProperty("Take 3Oad Past Week")] public string DSM_3OAD_take { get; set; }
        //[JsonProperty("3Oad Days")] public string DSM_3OAD_days { get; set; }
        //[JsonProperty("3Oad Times")] public string DSM_3OAD_times { get; set; }
        //[JsonProperty("How Much 3Oad")] public string DSM_3OAD_qty { get; set; }
        //[JsonProperty("3Oad Miss")] public string DSM_3OAD_miss { get; set; }
        //[JsonProperty("3Oad Works")] public string DSM_3OAD_works { get; set; }
        //[JsonProperty("3Oad Bothers")] public string DSM_3OAD_bothers { get; set; }
        //[JsonProperty("3Oad Difficulty - Hard To Remeber")] public string DSM_3OAD_Difficulty_hard_to_remember { get; set; }
        //[JsonProperty("3Oad Difficulty - Hard To Pay")] public string DSM_3OAD_Difficulty_hard_to_pay { get; set; }
        //[JsonProperty("3Oad Difficulty - Hard To Refill")] public string DSM_3OAD_Difficulty_hard_to_refill { get; set; }
        //[JsonProperty("3Oad Difficulty - Unwanted Side Effect")] public string DSM_3OAD_Difficulty_unwanted_side_effect { get; set; }
        //[JsonProperty("3Oad Difficulty - Other Concern")] public string DSM_3OAD_Difficulty_other_concern { get; set; }
        //[JsonProperty("Body Weight (Kg)")] public string PCD_BodyWeight { get; set; }
        //[JsonProperty("Waist Circumference (Cm)")] public string PCD_Waist { get; set; }
        //[JsonProperty("Body Fat Mass (Kg)")] public string PCD_BodyMass { get; set; }
        //[JsonProperty("Height")] public string PCD_Height { get; set; }
        //[JsonProperty("Hip Circumference(Cm)")] public string PCD_hip { get; set; }
        //[JsonProperty("Neck Circumference(Cm)")] public string PCD_neck { get; set; }
        //[JsonProperty("Body Fat Percentage (%)")] public string PCD_bodyfatper { get; set; }
        //[JsonProperty("Body Mass Index (Kg/M2)")] public string PCD_bmi { get; set; }
        //[JsonProperty("Waist To Hip Ratio (Wr/Hr)")] public string PCD_WHR { get; set; }
        //[JsonProperty("Blood Pressure (Mmhg)")] public string PCD_BloodPressure { get; set; }
        //[JsonProperty("Blood Pressure Systolic")] public string PCD_BloodPressureSystolic { get; set; }
        //[JsonProperty("Blood Pressure Diastolic")] public string PCD_BloodPressureDiastolic { get; set; }
        //[JsonProperty("Chronic Gastrointestinal Diseases")] public string PMD_Chronic_gastrointestinal { get; set; }
        //[JsonProperty("Inflammatory Bowel Diseases")] public string PMD_Inflammatory_bowel { get; set; }
        //[JsonProperty("Gastrointestinal Ulcer")] public string PMD_Gastrointestinal_ulcer { get; set; }
        //[JsonProperty("Chronic Liver Disease")] public string PMD_Chronic_liver { get; set; }
        //[JsonProperty("Chronic Pancreatitis")] public string PMD_Chronic_pancreatitis { get; set; }
        //[JsonProperty("Chronic Kidney Disease")] public string PMD_Chronic_kidney { get; set; }
        //[JsonProperty("Cholelithiasis")] public string PMD_Cholelithiasis { get; set; }
        //[JsonProperty("Endocrine Disorders")] public string PMD_Endocrine_disorders { get; set; }
        //[JsonProperty("Inflammation")] public string PMD_inflammation { get; set; }
        //[JsonProperty("Retinopathy")] public string complications_retinopathy { get; set; }
        //[JsonProperty("Neuropathy")] public string complications_neuropathy { get; set; }
        //[JsonProperty("Cerebrovascular Accident(Cva)")] public string complications_cva { get; set; }
        //[JsonProperty("No Proliferative")] public string complications_No_proliferative { get; set; }
        //[JsonProperty("Foot (Ulcers)")] public string complications_foot { get; set; }
        //[JsonProperty("Tia")] public string complications_tia { get; set; }
        //[JsonProperty("Proliferative")] public string complications_proliferative { get; set; }
        //[JsonProperty("Gangrene")] public string complications_Gangrene { get; set; }
        //[JsonProperty("Stroke")] public string complications_Stroke { get; set; }
        //[JsonProperty("Laser")] public string complications_Laser { get; set; }
        //[JsonProperty("Loss Of Sensation, Numbness")] public string complications_numbness { get; set; }
        //[JsonProperty("Loss Of Sensation, One Side Of The Body")] public string complications_onesidebody { get; set; }
        //[JsonProperty("Amputation")] public string complications_Amputation { get; set; }
        //[JsonProperty("Bleeding")] public string complications_Bleeding { get; set; }
        //[JsonProperty("Loss Of Toe")] public string complications_Loss_of_toe { get; set; }
        //[JsonProperty("Dif?Culty Speaking")] public string complications_Diff_speaking { get; set; }
        //[JsonProperty("Pain In Calf Muscles")] public string complications_Pain_in_calfmuscles { get; set; }
        //[JsonProperty("Operation On Artery")] public string complications_Operation_on_artery { get; set; }
        //[JsonProperty("Circulation, Peripheral Vascular Disease")] public string complications_Circulation_peripheral_vascular { get; set; }
        //[JsonProperty("Facial Drop")] public string complications_Facial_drop { get; set; }
        //[JsonProperty("Retinopathy Other")] public string complications_Retinopathy_other { get; set; }
        //[JsonProperty("Paralyzed Arm")] public string complications_Paralyzed_arm { get; set; }
        //[JsonProperty("Nephropathy")] public string complications_nephropathy { get; set; }
        //[JsonProperty("Coronary Artery Disease")] public string complications_cad { get; set; }
        //[JsonProperty("Nephropathy Other")] public string complications_other { get; set; }
        //[JsonProperty("Nephropathy Albumin")] public string complications_albumin { get; set; }
        //[JsonProperty("Coronary Artery Bypass Grafting (Cabg)")] public string complications_CABG { get; set; }
        //[JsonProperty("Nephropathy Albuminuria")] public string complications_Albuminuria { get; set; }
        //[JsonProperty("Percutaneous Coronary Intervention (Pci)")] public string complications_PCI { get; set; }
        //[JsonProperty("Nephropathy 30-299 Mg/24H")] public string complications_30_299_mg_24h { get; set; }
        //[JsonProperty("Nephropathy Arrhythmias (Af)")] public string complications_Arrhythmias { get; set; }
        //[JsonProperty("Nephropathy >300 Mg/24H")] public string complications_300_mg_24h { get; set; }
        //[JsonProperty("Nephropathy Egfr")] public string complications_egfr { get; set; }
        //[JsonProperty("Anti-Hypertensive Ace Inhibitors")] public string Anti_Hypertensive_ACE_inhibitors { get; set; }
        //[JsonProperty("Anti-Hypertensive Ace Inhibitors Perindopril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Perindopril { get; set; }
        //[JsonProperty("Anti-Hypertensive Ace Inhibitors Captopril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Captopril { get; set; }
        //[JsonProperty("Anti-Hypertensive Ace Inhibitors Enalapril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Enalapril { get; set; }
        //[JsonProperty("Anti-Hypertensive Ace Inhibitors Lisinopril Dose")] public string Anti_Hypertensive_ACE_inhibitors_Lisinopril { get; set; }
        //[JsonProperty("Anti-Hypertensive Ace Inhibitors Other Dose")] public string Anti_Hypertensive_ACE_inhibitors_other { get; set; }
        //[JsonProperty("Anti-Hypertensive Arbs")] public string Anti_Hypertensive_ARBs { get; set; }
        //[JsonProperty("Anti-Hypertensive Arbs Losartan Dose")] public string Anti_Hypertensive_ARBs_Losartan { get; set; }
        //[JsonProperty("Anti-Hypertensive Arbs Valsartan Dose")] public string Anti_Hypertensive_ARBs_Valsartan { get; set; }
        //[JsonProperty("Anti-Hypertensive Arbs Other Dose")] public string Anti_Hypertensive_ARBs_other { get; set; }
        //[JsonProperty("Anti-Hypertensive Beta- Blockers")] public string Anti_Hypertensive_Beta_blockers { get; set; }
        //[JsonProperty("Anti-Hypertensive Beta- Blockers Atenolol Dose")] public string Anti_Hypertensive_Beta_blockers_Atenolol { get; set; }
        //[JsonProperty("Anti-Hypertensive Beta- Blockers Bisoprolol Dose")] public string Anti_Hypertensive_Beta_blockers_Bisoprolol { get; set; }
        //[JsonProperty("Anti-Hypertensive Beta- Blockers Other Dose")] public string Anti_Hypertensive_Beta_blockers_other { get; set; }
        //[JsonProperty("Anti-Hypertensive Diuretics")] public string Anti_Hypertensive_Diuretics { get; set; }
        //[JsonProperty("Anti-Hypertensive Diuretics Indapamide Dose")] public string Anti_Hypertensive_Diuretics_Indapamide { get; set; }
        //[JsonProperty("Anti-Hypertensive Diuretics Hydrochlorothiazide Dose")] public string Anti_Hypertensive_Diuretics_Hydrochlorothiazide { get; set; }
        //[JsonProperty("Anti-Hypertensive Diuretics Frusemide Dose")] public string Anti_Hypertensive_Diuretics_Frusemide { get; set; }
        //[JsonProperty("Anti-Hypertensive Diuretics Other Dose")] public string Anti_Hypertensive_Diuretics_other { get; set; }
        //[JsonProperty("Anti-Hypertensive Ca-Channel Blockers")] public string Anti_Hypertensive_CaChannel_Blockers { get; set; }
        //[JsonProperty("Anti-Hypertensive Ca-Channel Blockers Amlodipine Dose")] public string Anti_Hypertensive_CaChannel_Blockers_Amlodipine { get; set; }
        //[JsonProperty("Anti-Hypertensive Ca-Channel Blockers Nifedipine Dose")] public string Anti_Hypertensive_CaChannel_Blockers_Nifedipine { get; set; }
        //[JsonProperty("Anti-Hypertensive Ca-Channel Blockers Verapamil Dose")] public string Anti_Hypertensive_CaChannel_Blockers_Verapamil { get; set; }
        //[JsonProperty("Anti-Hypertensive Ca-Channel Blockers Other Dose")] public string Anti_Hypertensive_CaChannel_Blockers_other { get; set; }
        //[JsonProperty("Anti-Hypertensive Other")] public string Anti_Hypertensive_other { get; set; }
        //[JsonProperty("Anti-Hypertensive Other Other Dose")] public string Anti_Hypertensive_other_other { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Statins")] public string Anti_Dyslipidemia_Statins { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Statins Simvastatin Dose")] public string Anti_Dyslipidemia_Statins_Simvastatin { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Statins Atorvastatin Dose")] public string Anti_Dyslipidemia_Statins_Atorvastatin { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Statins Rosuvastatin Dose")] public string Anti_Dyslipidemia_Statins_Rosuvastatin { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Statins Other Dose")] public string Anti_Dyslipidemia_Statins_other { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Fibrates")] public string Anti_Dyslipidemia_Fibrates { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Fibrates Gemfibrozil Dose")] public string Anti_Dyslipidemia_Fibrates_Gemfibrozil { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Fibrates Fenofibrate Dose")] public string Anti_Dyslipidemia_Fibrates_Fenofibrate { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Fibrates Yes 1")] public string Anti_Dyslipidemia_Fibrates_yes1 { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Fibrates Yes 2")] public string Anti_Dyslipidemia_Fibrates_yes2 { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Other")] public string Anti_Dyslipidemia_other { get; set; }
        //[JsonProperty("Anti-Dyslipidemia Other Other Dose")] public string Anti_Dyslipidemia_other_other { get; set; }
        //[JsonProperty("Oral Agents Biguanides")] public string Oral_agents_Biguanides { get; set; }
        //[JsonProperty("Oral Agents Biguanides Metformin Dose")] public string Oral_agents_Biguanides_Metformin { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas")] public string Oral_agents_Sulphonyureas { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Glibenclamide Dose")] public string Oral_agents_Sulphonyureas_Glibenclamide { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Glimepiride Dose")] public string Oral_agents_Sulphonyureas_Glimepiride { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Glipizide Dose")] public string Oral_agents_Sulphonyureas_Glipizide { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Gliclazide  Mr Dose")] public string Oral_agents_Sulphonyureas_GliclazideMR { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Glipizide1 Dose")] public string Oral_agents_Sulphonyureas_Glipizide1 { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Glimepride Dose")] public string Oral_agents_Sulphonyureas_Glimepride { get; set; }
        //[JsonProperty("Oral Agents Sulphonyureas Other Dose")] public string Oral_agents_Sulphonyureas_other { get; set; }
        //[JsonProperty("Oral Agents Thiazolidinediones")] public string Oral_agents_Thiazolidinediones { get; set; }
        //[JsonProperty("Oral Agents Thiazolidinediones Pioglitazone Dose")] public string Oral_agents_Thiazolidinediones_Pioglitazone { get; set; }
        //[JsonProperty("Oral Agents Thiazolidinediones Other Dose")] public string Oral_agents_Thiazolidinediones_other { get; set; }
        //[JsonProperty("Oral Agents Meglitinides")] public string Oral_agents_Meglitinides { get; set; }
        //[JsonProperty("Oral Agents Meglitinides Nateglinide Dose")] public string Oral_agents_Meglitinides_Nateglinide { get; set; }
        //[JsonProperty("Oral Agents Meglitinides Repaglinide Dose")] public string Oral_agents_Meglitinides_Repaglinide { get; set; }
        //[JsonProperty("Oral Agents Alpha-Glucosidase Inhibitors")] public string Oral_agents_Alpha_glucosidase_inhibitors { get; set; }
        //[JsonProperty("Oral Agents Alpha-Glucosidase Inhibitors Acarbose Dose")] public string Oral_agents_Alpha_glucosidase_inhibitors_Acarbose { get; set; }
        //[JsonProperty("Oral Agents Dipeptidyl Peptidase -Iv Inhibitors (Dpp-Iv)")] public string Oral_agents_Dipeptidyl { get; set; }
        //[JsonProperty("Oral Agents Dipeptidyl Sitagliptin Dose")] public string Oral_agents_Dipeptidyl_Sitagliptin { get; set; }
        //[JsonProperty("Oral Agents Dipeptidyl Vildagliptin Dose")] public string Oral_agents_Dipeptidyl_Vildagliptin { get; set; }
        //[JsonProperty("Oral Agents Dipeptidyl Saxagliptin Dose")] public string Oral_agents_Dipeptidyl_Saxagliptin { get; set; }
        //[JsonProperty("Oral Agents Dipeptidyl Linagliptin Dose")] public string Oral_agents_Dipeptidyl_Linagliptin { get; set; }
        //[JsonProperty("Oral Agents Other")] public string Oral_agents_other { get; set; }
        //[JsonProperty("Oral Agents Other Pramlintide Dose")] public string Oral_agents_other_Pramlintide { get; set; }
        //[JsonProperty("Oral Agents Other Other Dose")] public string Oral_agents_other_other { get; set; }
        //[JsonProperty("Oral Agents Incretin Mimetics(Glp-1 Agonist)")] public string Oral_agents_Incretin { get; set; }
        //[JsonProperty("Oral Agents Incretin Exenatide Dose")] public string Oral_agents_Incretin_Exenatide { get; set; }
        //[JsonProperty("Oral Agents Incretin Liraglutide Dose")] public string Oral_agents_Incretin_Liraglutide { get; set; }
        //[JsonProperty("Oral Agents Incretin Exenatide  Weekly Dose")] public string Oral_agents_Incretin_Exenatide_weekly { get; set; }
        //[JsonProperty("Injections Insulin")] public string Injections_Insulin { get; set; }
        //[JsonProperty("Injections Insulin Lispro Dose")] public string Injections_Insulin_Lispro { get; set; }
        //[JsonProperty("Injections Insulin Aspart Dose")] public string Injections_Insulin_Aspart { get; set; }
        //[JsonProperty("Injections Insulin Glulisine Dose")] public string Injections_Insulin_Glulisine { get; set; }
        //[JsonProperty("Injections Insulin Regular Dose")] public string Injections_Insulin_Regular { get; set; }
        //[JsonProperty("Injections Insulin Nph Dose")] public string Injections_Insulin_NPH { get; set; }
        //[JsonProperty("Injections Insulin Detemir Dose")] public string Injections_Insulin_Detemir { get; set; }
        //[JsonProperty("Injections Insulin Glargine Dose")] public string Injections_Insulin_Glargine { get; set; }
        //[JsonProperty("Injections Insulin Combination Dose")] public string Injections_Insulin_Combination { get; set; }
        //[JsonProperty("Supplements Vitamin D3")] public string Supplements_VitaminD3 { get; set; }
        //[JsonProperty("Supplements Others (Erythropoietin  Injections)")] public string Supplements_others { get; set; }
        //[JsonProperty("Antidepressants Prozac Dose")] public string Antidepressants_Prozac { get; set; }
        //[JsonProperty("Antidepressants Others")] public string Antidepressants_other { get; set; }
        //[JsonProperty("Antianxiety Diazepam  Dose")] public string Antianxiety_Diazepam { get; set; }
        //[JsonProperty("Antianxiety Others  Dose")] public string Antianxiety_other { get; set; }
        //[JsonProperty("Other Medication")] public string othermedication_other { get; set; }
        //[JsonProperty("Traditional Chinese Medicine")] public string traditional_chinese { get; set; }
        //[JsonProperty("Date Of Sample Analysis")] public string BIO_date { get; set; }
        //[JsonProperty("Fasting Glucose Before Medication")] public string BIO_FastingGlucose_before_medication { get; set; }
        //[JsonProperty("Fasting Glucose Result After 3 Months")] public string BIO_FastingGlucose_Result_after3 { get; set; }
        //[JsonProperty("Fasting Glucose Result After 6 Months")] public string BIO_FastingGlucose_result_after6 { get; set; }
        //[JsonProperty("Fasting Glucose Result After 9 Months")] public string BIO_FastingGlucose_result_after9 { get; set; }
        //[JsonProperty("Fasting Glucose Level  Result After 12 Months")] public string BIO_FastingGlucose_result_after12 { get; set; }
        //[JsonProperty("Random Glucose Before Medication")] public string BIO_RandomGlucose_before_medication { get; set; }
        //[JsonProperty("Random Glucose Result After 3 Months")] public string BIO_RandomGlucose_result_after3 { get; set; }
        //[JsonProperty("Random Glucose Result After 6 Moths")] public string BIO_RandomGlucose_result_after6 { get; set; }
        //[JsonProperty("Random Glucose Result After 9 Moths")] public string BIO_RandomGlucose_result_after9 { get; set; }
        //[JsonProperty("Random Glucose Result After 12 Moths")] public string BIO_RandomGlucose_result_after12 { get; set; }
        //[JsonProperty("Ogtt Before Medication")] public string BIO_OGTT_before_medication { get; set; }
        //[JsonProperty("Ogtt Result After 3 Months")] public string BIO_OGTT_result_after3 { get; set; }
        //[JsonProperty("Ogtt Result After 6 Months")] public string BIO_OGTT_result_after6 { get; set; }
        //[JsonProperty("Ogtt Result After 9 Months")] public string BIO_OGTT_result_after9 { get; set; }
        //[JsonProperty("Ogtt Result After 12 Months")] public string BIO_OGTT_result_after12 { get; set; }
        //[JsonProperty("Fg After 2 Hours Before Medication")] public string BIO_FG2_before_medication { get; set; }
        //[JsonProperty("Fg After 2 Hours Result After 3 Months")] public string BIO_FG2_result_after3 { get; set; }
        //[JsonProperty("Fg After 2 Hours Result After 6 Months")] public string BIO_FG2_result_after6 { get; set; }
        //[JsonProperty("Fg After 2 Hours Result After 9 Months")] public string BIO_FG2_result_after9 { get; set; }
        //[JsonProperty("Fg After 2 Hours Result After 12 Months")] public string BIO_FG2_result_after12 { get; set; }
        //[JsonProperty("Hba1C (%) Before  Medication")] public string BIO_HbA1c_before_medication { get; set; }
        //[JsonProperty("Hba1C (%) Result After 3 Months")] public string BIO_HbA1c_result_after3 { get; set; }
        //[JsonProperty("Hba1C (%) Result After 6 Months")] public string BIO_HbA1c_result_after6 { get; set; }
        //[JsonProperty("Hba1C (%) Result After 9 Months")] public string BIO_HbA1c_result_after9 { get; set; }
        //[JsonProperty("Hba1C (%) Result After 12 Months")] public string BIO_HbA1c_result_after12 { get; set; }
        //[JsonProperty("Fasting Insulin Before  Medication")] public string BIO_Fasting_insulin_before_medication { get; set; }
        //[JsonProperty("Fasting Insulin Result After 3 Months")] public string BIO_Fasting_insulin_result_after3 { get; set; }
        //[JsonProperty("Fasting Insulin Result After 6 Months")] public string BIO_Fasting_insulin_result_after6 { get; set; }
        //[JsonProperty("Fasting Insulin Result After 9 Months")] public string BIO_Fasting_insulin_result_after9 { get; set; }
        //[JsonProperty("Fasting Insulin Result After 12 Months")] public string BIO_Fasting_insulin_result_after12 { get; set; }
        //[JsonProperty("Total Cholesterol (Mg/Dl)  Before Medication")] public string BIO_TotalCholesterol_before_medication { get; set; }
        //[JsonProperty("Total Cholesterol (Mgl/Dl) Result After 3 Months")] public string BIO_TotalCholesterol_result_after3 { get; set; }
        //[JsonProperty("Total Cholesterol (Mg/Dl) Result After 6 Months")] public string BIO_TotalCholesterol_result_after6 { get; set; }
        //[JsonProperty("Total Cholesterol (Mg/Dl) Result After 9 Months")] public string BIO_TotalCholesterol_result_after9 { get; set; }
        //[JsonProperty("Total Cholesterol (Mmol/L) Result After 12 Months")] public string BIO_TotalCholesterol_result_after12 { get; set; }
        //[JsonProperty("Triglyceride (Mg/Dl) Before Medication")] public string BIO_Triglyceride_before_medication { get; set; }
        //[JsonProperty("Triglyceride (Mg/Dl) Result After 3 Months")] public string BIO_Triglyceride_result_after3 { get; set; }
        //[JsonProperty("Triglyceride (Mg/Dl) Result After 6 Months")] public string BIO_Triglyceride_result_after6 { get; set; }
        //[JsonProperty("Triglyceride (Mg/Dl) Result After 9 Months")] public string BIO_Triglyceride_result_after9 { get; set; }
        //[JsonProperty("Triglyceride (Mg/Dl) Result After 12 Months")] public string BIO_Triglyceride_result_after12 { get; set; }
        //[JsonProperty("Hdl (Mg/Dl)  Before Medication")] public string BIO_HDL_before_medication { get; set; }
        //[JsonProperty("Hdl (Mg/Dl) Result After 3 Months")] public string BIO_HDL_result_after3 { get; set; }
        //[JsonProperty("Hdl (Mg/Dl) Result After 6 Months")] public string BIO_HDL_result_after6 { get; set; }
        //[JsonProperty("Hdl (Mg/Dl) Result After 9 Months")] public string BIO_HDL_result_after9 { get; set; }
        //[JsonProperty("Hdl (Mg/Dl) Result After 12 Months")] public string BIO_HDL_result_after12 { get; set; }
        //[JsonProperty("Ldl (Mg/Dl)  Before Medication")] public string BIO_LDL_before_medication { get; set; }
        //[JsonProperty("Ldl (Mg/Dl) Result After 3 Months")] public string BIO_LDL_result_after3 { get; set; }
        //[JsonProperty("Ldl (Mg/Dl) Result After 6 Months")] public string BIO_LDL_result_after6 { get; set; }
        //[JsonProperty("Ldl (Mg/Dl) Result After 9 Months")] public string BIO_LDL_result_after9 { get; set; }
        //[JsonProperty("Ldl (Mg/Dl) Result After 12 Months")] public string BIO_LDL_result_after12 { get; set; }
        //[JsonProperty("Vitamin D Level (Ng/Ml) _Before Medication")] public string BIO_VitaminDLevel_before_medication { get; set; }
        //[JsonProperty("Vitamin D Level (Ng/Ml) Result After 3 Months")] public string BIO_VitaminDLevel_result_after3 { get; set; }
        //[JsonProperty("Vitamin D Level (Ng/Ml) Result After 6 Months")] public string BIO_VitaminDLevel_result_after6 { get; set; }
        //[JsonProperty("Vitamin D Level (Ng/Ml) Result After 9 Months")] public string BIO_VitaminDLevel_result_after9 { get; set; }
        //[JsonProperty("Vitamin D Level (Ngl/Ml) Result After 12 Months")] public string BIO_VitaminDLevel_result_after12 { get; set; }
        //[JsonProperty("Microalbumin (Mg)  Before Medication")] public string BIO_Microalbumin_before_medication { get; set; }
        //[JsonProperty("Microalbumin (Mg) Result After 3 Months")] public string BIO_Microalbumin_result_after3 { get; set; }
        //[JsonProperty("Microalbumin (Mg) Result After 6 Months")] public string BIO_Microalbumin_result_after6 { get; set; }
        //[JsonProperty("Microalbumin (Mg) Result After 9 Months")] public string BIO_Microalbumin_result_after9 { get; set; }
        //[JsonProperty("Microalbumin (Mg) Result After 12 Months")] public string BIO_Microalbumin_result_after12 { get; set; }
        //[JsonProperty("Albuminuria (Mg/G) Before Medication")] public string BIO_albuminuria_before_medication { get; set; }
        //[JsonProperty("Albuminuria (Mg/G) Result After 3 Months")] public string BIO_albuminuria_result_after3 { get; set; }
        //[JsonProperty("Albuminuria (Mg/G) Result After 6 Months")] public string BIO_albuminuria_result_after6 { get; set; }
        //[JsonProperty("Albuminuria (Mg/G) Result After 9 Months")] public string BIO_albuminuria_result_after9 { get; set; }
        //[JsonProperty("Albuminuria (Mg/G) Result After 12 Months")] public string BIO_albuminuria_result_after12 { get; set; }
        //[JsonProperty("Albumincreatinine (Mg/Gm) Before Medication")] public string BIO_albumincreatinine_before_medication { get; set; }
        //[JsonProperty("Albumincreatinine (Mg/Gm) Result After 3 Months")] public string BIO_albumincreatinine_result_after3 { get; set; }
        //[JsonProperty("Albumincreatinine (Mg/Gm) Result After 6 Months")] public string BIO_albumincreatinine_result_after6 { get; set; }
        //[JsonProperty("Albumincreatinine (Mg/Gm) Result After 9 Months")] public string BIO_albumincreatinine_result_after9 { get; set; }
        //[JsonProperty("Albumincreatinine (Mg/Gm) Result After 12 Months")] public string BIO_albumincreatinine_result_after12 { get; set; }
        //[JsonProperty("Creatinine Before Medication")] public string BIO_Creatinine_before_medication { get; set; }
        //[JsonProperty("Creatinine Result After 3 Months")] public string BIO_Creatinine_result_after3 { get; set; }
        //[JsonProperty("Creatinine Result After 6 Months")] public string BIO_Creatinine_result_after6 { get; set; }
        //[JsonProperty("Creatinine Result After 9 Months")] public string BIO_Creatinine_result_after9 { get; set; }
        //[JsonProperty("Creatinine Result After 12 Months")] public string BIO_Creatinine_result_after12 { get; set; }
        //[JsonProperty("Urea Before Medication")] public string BIO_Urea_before_medication { get; set; }
        //[JsonProperty("Urea Result After 3 Months")] public string BIO_Urea_result_after3 { get; set; }
        //[JsonProperty("Urea Result After 6 Months")] public string BIO_Urea_result_after6 { get; set; }
        //[JsonProperty("Urea Result After 9 Months")] public string BIO_Urea_result_after9 { get; set; }
        //[JsonProperty("Urea Result After 12 Months")] public string BIO_Urea_result_after12 { get; set; }
        //[JsonProperty("Egfr Before Medication")] public string BIO_egfr_before_medication { get; set; }
        //[JsonProperty("Egfr Result After 3 Months")] public string BIO_egfr_result_after3 { get; set; }
        //[JsonProperty("Egfr Result After 6 Months")] public string BIO_egfr_result_after6 { get; set; }
        //[JsonProperty("Egfr Result After 9 Months")] public string BIO_egfr_result_after9 { get; set; }
        //[JsonProperty("Egfr Result After 12 Months")] public string BIO_egfr_result_after12 { get; set; }
        //[JsonProperty("Serum Sodium Before Medication")] public string BIO_sodium_before { get; set; }
        //[JsonProperty("Serum Sodium Result After 3 Months")] public string BIO_sodium_result_after3 { get; set; }
        //[JsonProperty("Serum Sodium Result After 6 Months")] public string BIO_sodium_result_after6 { get; set; }
        //[JsonProperty("Serum Sodium Result After 9 Months")] public string BIO_sodium_result_after9 { get; set; }
        //[JsonProperty("Serum Sodium Result After 12 Months")] public string BIO_sodium_result_after12 { get; set; }
        //[JsonProperty("Serum Potassium Before Medication")] public string BIO_potassium_before { get; set; }
        //[JsonProperty("Serum Potassium Result After 3 Months")] public string BIO_potassium_result_after3 { get; set; }
        //[JsonProperty("Serum Potassium Result After 6 Months")] public string BIO_potassium_result_after6 { get; set; }
        //[JsonProperty("Serum Potassium Result After 9 Months")] public string BIO_potassium_result_after9 { get; set; }
        //[JsonProperty("Serum Potassium Result After 12 Months")] public string BIO_potassium_result_after12 { get; set; }
        //[JsonProperty("Serum Calcium Before Medication")] public string BIO_calcium_before { get; set; }
        //[JsonProperty("Serum Calcium Result After 3 Months")] public string BIO_calcium_result_after3 { get; set; }
        //[JsonProperty("Serum Calcium Result After 6 Months")] public string BIO_calcium_result_after6 { get; set; }
        //[JsonProperty("Serum Calcium Result After 9 Months")] public string BIO_calcium_result_after9 { get; set; }
        //[JsonProperty("Serum Calcium Result After 12 Months")] public string BIO_calcium_result_after12 { get; set; }
        //[JsonProperty("Serum Magnesium Before Medication")] public string BIO_Magnesium_before { get; set; }
        //[JsonProperty("Serum Magnesium Result After 3 Months")] public string BIO_Magnesium_result_after3 { get; set; }
        //[JsonProperty("Serum Magnesium Result After 6 Months")] public string BIO_Magnesium_result_after6 { get; set; }
        //[JsonProperty("Serum Magnesium Result After 9 Months")] public string BIO_Magnesium_result_after9 { get; set; }
        //[JsonProperty("Serum Magnesium Result After 12 Months")] public string BIO_Magnesium_result_after12 { get; set; }
        //[JsonProperty("Phosphorus Before Medication")] public string BIO_Phosphorus_before { get; set; }
        //[JsonProperty("Phosphorus Result After 3 Months")] public string BIO_Phosphorus_result_after3 { get; set; }
        //[JsonProperty("Phosphorus Result After 6 Months")] public string BIO_Phosphorus_result_after6 { get; set; }
        //[JsonProperty("Phosphorus Result After 9 Months")] public string BIO_Phosphorus_result_after9 { get; set; }
        //[JsonProperty("Phosphorus Result After 12 Months")] public string BIO_Phosphorus_result_after12 { get; set; }
        //[JsonProperty("Bicarbonate Before Medication")] public string BIO_Bicarbonate_before { get; set; }
        //[JsonProperty("Bicarbonate Result After 3 Months")] public string BIO_Bicarbonate_result_after3 { get; set; }
        //[JsonProperty("Bicarbonate Result After 6 Months")] public string BIO_Bicarbonate_result_after6 { get; set; }
        //[JsonProperty("Bicarbonate Result After 9 Months")] public string BIO_Bicarbonate_result_after9 { get; set; }
        //[JsonProperty("Bicarbonate Result After 12 Months")] public string BIO_Bicarbonate_result_after12 { get; set; }
        //[JsonProperty("Alanine Transaminase (Alt) Before Medication")] public string BIO_ALT_before { get; set; }
        //[JsonProperty("Alanine Transaminase (Alt) Result After 3 Months")] public string BIO_ALT_result_after3 { get; set; }
        //[JsonProperty("Alanine Transaminase (Alt) Result After 6 Months")] public string BIO_ALT_result_after6 { get; set; }
        //[JsonProperty("Alanine Transaminase (Alt) Result After 9 Months")] public string BIO_ALT_result_after9 { get; set; }
        //[JsonProperty("Alanine Transaminase (Alt) Result After 12 Months")] public string BIO_ALT_result_after12 { get; set; }
        //[JsonProperty("Alkaline Phosphatase (Alp) Before Medication")] public string BIO_ALP_before { get; set; }
        //[JsonProperty("Alkaline Phosphatase (Alp) Result After 3 Months")] public string BIO_ALP_result_after3 { get; set; }
        //[JsonProperty("Alkaline Phosphatase (Alp) Result After 6 Months")] public string BIO_ALP_result_after6 { get; set; }
        //[JsonProperty("Alkaline Phosphatase (Alp) Result After 9 Months")] public string BIO_ALP_result_after9 { get; set; }
        //[JsonProperty("Alkaline Phosphatase (Alp) Result After 12 Months")] public string BIO_ALP_result_after12 { get; set; }
        //[JsonProperty("Aspartate Transaminase (Ast) Before Medication")] public string BIO_AST_before { get; set; }
        //[JsonProperty("Aspartate Transaminase  (Ast) Result After 3 Months")] public string BIO_AST_result_after3 { get; set; }
        //[JsonProperty("Aspartate Transaminase (Ast) Result After 6 Months")] public string BIO_AST_result_after6 { get; set; }
        //[JsonProperty("Aspartate Transaminase (Ast) Result After 9 Months")] public string BIO_AST_result_after9 { get; set; }
        //[JsonProperty("Aspartate Transaminase (Ast) Result After 12 Months")] public string BIO_AST_result_after12 { get; set; }
        //[JsonProperty("Bilirubin Before Medication")] public string BIO_bilirubin_before { get; set; }
        //[JsonProperty("Bilirubin Result After 3 Months")] public string BIO_bilirubin_result_after3 { get; set; }
        //[JsonProperty("Bilirubin Result After 6 Months")] public string BIO_bilirubin_result_after6 { get; set; }
        //[JsonProperty("Bilirubin Result After 9 Months")] public string BIO_bilirubin_result_after9 { get; set; }
        //[JsonProperty("Bilirubin Result After 12 Months")] public string BIO_bilirubin_result_after12 { get; set; }
        //[JsonProperty("Total Protein Before Medication")] public string BIO_Protein_before { get; set; }
        //[JsonProperty("Total Protein Result After 3 Months")] public string BIO_Protein_result_after3 { get; set; }
        //[JsonProperty("Total Protein Result After 6 Months")] public string BIO_Protein_result_after6 { get; set; }
        //[JsonProperty("Total Protein Result After 9 Months")] public string BIO_Protein_result_after9 { get; set; }
        //[JsonProperty("Total Protein Result After 12 Months")] public string BIO_Protein_result_after12 { get; set; }
        //[JsonProperty("Serum Albumin Before Medication")] public string BIO_Serum_albumin_before { get; set; }
        //[JsonProperty("Serum Albumin Result After 3 Months")] public string BIO_Serum_albumin_result_after3 { get; set; }
        //[JsonProperty("Serum Albumin Result After 6 Months")] public string BIO_Serum_albumin_result_after6 { get; set; }
        //[JsonProperty("Serum Albumin Result After 9 Months")] public string BIO_Serum_albumin_result_after9 { get; set; }
        //[JsonProperty("Serum Albumin Result After 12 Months")] public string BIO_Serum_albumin_result_after12 { get; set; }
        //[JsonProperty("C-Reative Protein Before Medication")] public string BIO_cprotein_before { get; set; }
        //[JsonProperty("C-Reative Protein Result After 3 Months")] public string BIO_cprotein_result_after3 { get; set; }
        //[JsonProperty("C-Reative Protein Result After 6 Months")] public string BIO_cprotein_result_after6 { get; set; }
        //[JsonProperty("C-Reative Protein Result After 9 Months")] public string BIO_cprotein_result_after9 { get; set; }
        //[JsonProperty("C-Reative Protein Result After 12 Months")] public string BIO_cprotein_result_after12 { get; set; }
        //[JsonProperty("Fibrinogen Before Medication")] public string BIO_Fibrinogen_before { get; set; }
        //[JsonProperty("Fibrinogen Result After 3 Months")] public string BIO_Fibrinogen_result_after3 { get; set; }
        //[JsonProperty("Fibrinogen Result After 6 Months")] public string BIO_Fibrinogen_result_after6 { get; set; }
        //[JsonProperty("Fibrinogen Result After 9 Months")] public string BIO_Fibrinogen_result_after9 { get; set; }
        //[JsonProperty("Fibrinogen Result After 12 Months")] public string BIO_Fibrinogen_result_after12 { get; set; }
        //[JsonProperty("Interleukin 6 (Il6) Before Medication")] public string BIO_Interleukin_before { get; set; }
        //[JsonProperty("Interleukin 6 (Il6) Result After 3 Months")] public string BIO_Interleukin_result_after3 { get; set; }
        //[JsonProperty("Interleukin 6 (Il6) Result After 6 Months")] public string BIO_Interleukin_result_after6 { get; set; }
        //[JsonProperty("Interleukin 6 (Il6) Result After 9 Months")] public string BIO_Interleukin_result_after9 { get; set; }
        //[JsonProperty("Interleukin 6 (Il6) Result After 12 Months")] public string BIO_Interleukin_result_after12 { get; set; }
        //[JsonProperty("Procalcitonin Before Medication")] public string BIO_Procalcitonin_before { get; set; }
        //[JsonProperty("Procalcitonin Result After 3 Months")] public string BIO_Procalcitonin_result_after3 { get; set; }
        //[JsonProperty("Procalcitonin Result After 6 Months")] public string BIO_Procalcitonin_result_after6 { get; set; }
        //[JsonProperty("Procalcitonin Result After 9 Months")] public string BIO_Procalcitonin_result_after9 { get; set; }
        //[JsonProperty("Procalcitonin Result After 12 Months")] public string BIO_Procalcitonin_result_after12 { get; set; }
        //[JsonProperty("Pai-1 Before Medication")] public string BIO_PAI1_before { get; set; }
        //[JsonProperty("Pai-1 Result After 3 Months")] public string BIO_PAI1_result_after3 { get; set; }
        //[JsonProperty("Pai-1 Result After 6 Months")] public string BIO_PAI1_result_after6 { get; set; }
        //[JsonProperty("Pai-1 Result After 9 Months")] public string BIO_PAI1_result_after9 { get; set; }
        //[JsonProperty("Pai-1 Result After 12 Months")] public string BIO_PAI1_result_after12 { get; set; }
        //[JsonProperty("Insulin Before Medication")] public string BIO_Insulin_before { get; set; }
        //[JsonProperty("Insulin Result After 3 Months")] public string BIO_Insulin_result_after3 { get; set; }
        //[JsonProperty("Insulin Result After 6 Months")] public string BIO_Insulin_result_after6 { get; set; }
        //[JsonProperty("Insulin Result After 9 Months")] public string BIO_Insulin_result_after9 { get; set; }
        //[JsonProperty("Insulin Result After 12 Months")] public string BIO_Insulin_result_after12 { get; set; }
        //[JsonProperty("Cortisol Before Medication")] public string BIO_Cortisol_before { get; set; }
        //[JsonProperty("Cortisol Result After 3 Months")] public string BIO_Cortisol_result_after3 { get; set; }
        //[JsonProperty("Cortisol Result After 6 Months")] public string BIO_Cortisol_result_after6 { get; set; }
        //[JsonProperty("Cortisol Result After 9 Months")] public string BIO_Cortisol_result_after9 { get; set; }
        //[JsonProperty("Cortisol Result After 12 Months")] public string BIO_Cortisol_result_after12 { get; set; }
        //[JsonProperty("T3 Before Medication")] public string BIO_T3_before { get; set; }
        //[JsonProperty("T3 Result After 3 Months")] public string BIO_T3_result_after3 { get; set; }
        //[JsonProperty("T3 Result After 6 Months")] public string BIO_T3_result_after6 { get; set; }
        //[JsonProperty("T3 Result After 9 Months")] public string BIO_T3_result_after9 { get; set; }
        //[JsonProperty("T3 Result After 12 Months")] public string BIO_T3_result_after12 { get; set; }
        //[JsonProperty("T4 Before Medication")] public string BIO_T4_before { get; set; }
        //[JsonProperty("T4 Result After 3 Months")] public string BIO_T4_result_after3 { get; set; }
        //[JsonProperty("T4 Result After 6 Months")] public string BIO_T4_result_after6 { get; set; }
        //[JsonProperty("T4 Result After 9 Months")] public string BIO_T4_result_after9 { get; set; }
        //[JsonProperty("T4 Result After 12 Months")] public string BIO_T4_result_after12 { get; set; }
        //[JsonProperty("Free T4 Before Medication")] public string BIO_FreeT4_before { get; set; }
        //[JsonProperty("Free T4 Result After 3 Months")] public string BIO_FreeT4_result_after3 { get; set; }
        //[JsonProperty("Free T4 Result After 6 Months")] public string BIO_FreeT4_result_after6 { get; set; }
        //[JsonProperty("Free T4 Result After 9 Months")] public string BIO_FreeT4_result_after9 { get; set; }
        //[JsonProperty("Free T4 Result After 12 Months")] public string BIO_FreeT4_result_after12 { get; set; }
        //[JsonProperty("Tsh Before Medication")] public string BIO_TSH_before { get; set; }
        //[JsonProperty("Tsh Result After 3 Months")] public string BIO_TSH_result_after3 { get; set; }
        //[JsonProperty("Tsh Result After 6 Months")] public string BIO_TSH_result_after6 { get; set; }
        //[JsonProperty("Tsh Result After 9 Months")] public string BIO_TSH_result_after9 { get; set; }
        //[JsonProperty("Tsh Result After 12 Months")] public string BIO_TSH_result_after12 { get; set; }
        //[JsonProperty("Parathyroid Hormone Before Medication")] public string BIO_parathyroid_before { get; set; }
        //[JsonProperty("Parathyroid Hormone Result After 3 Months")] public string BIO_parathyroid_result_after3 { get; set; }
        //[JsonProperty("Parathyroid Hormone Result After 6 Months")] public string BIO_parathyroid_result_after6 { get; set; }
        //[JsonProperty("Parathyroid Hormone Result After 9 Months")] public string BIO_parathyroid_result_after9 { get; set; }
        //[JsonProperty("Parathyroid Hormone Result After 12 Months")] public string BIO_parathyroid_result_after12 { get; set; }
        //[JsonProperty("Estrogen Before Medication")] public string BIO_Estrogen_before { get; set; }
        //[JsonProperty("Estrogen Result After 3 Months")] public string BIO_Estrogen_result_after3 { get; set; }
        //[JsonProperty("Estrogen Result After 6 Months")] public string BIO_Estrogen_result_after6 { get; set; }
        //[JsonProperty("Estrogen Result After 9 Months")] public string BIO_Estrogen_result_after9 { get; set; }
        //[JsonProperty("Estrogen Result After 12 Months")] public string BIO_Estrogen_result_after12 { get; set; }
        //[JsonProperty("Progesterone Before Medication")] public string BIO_Progesterone_before { get; set; }
        //[JsonProperty("Progesterone Result After 3 Months")] public string BIO_Progesterone_result_after3 { get; set; }
        //[JsonProperty("Progesterone Result After 6 Months")] public string BIO_Progesterone_result_after6 { get; set; }
        //[JsonProperty("Progesterone Result After 9 Months")] public string BIO_Progesterone_result_after9 { get; set; }
        //[JsonProperty("Progesterone Result After 12 Months")] public string BIO_Progesterone_result_after12 { get; set; }
        //[JsonProperty("Testosterone Before Medication")] public string BIO_Testosterone_before { get; set; }
        //[JsonProperty("Testosterone Result After 3 Months")] public string BIO_Testosterone_result_after3 { get; set; }
        //[JsonProperty("Testosterone Result After 6 Months")] public string BIO_Testosterone_result_after6 { get; set; }
        //[JsonProperty("Testosterone Result After 9 Months")] public string BIO_Testosterone_result_after9 { get; set; }
        //[JsonProperty("Testosterone Result After 12 Months")] public string BIO_Testosterone_result_after12 { get; set; }
        //[JsonProperty("Wbc Count Before Medication")] public string BIO_WBC_Count_before { get; set; }
        //[JsonProperty("Wbc Count Result After 3 Months")] public string BIO_WBC_Count_result_after3 { get; set; }
        //[JsonProperty("Wbc Count Result After 6 Months")] public string BIO_WBC_Count_result_after6 { get; set; }
        //[JsonProperty("Wbc Count Result After 9 Months")] public string BIO_WBC_Count_result_after9 { get; set; }
        //[JsonProperty("Wbc Count Result After 12 Months")] public string BIO_WBC_Count_result_after12 { get; set; }
        //[JsonProperty("Wbc Differential Count Before Medication")] public string BIO_WBC_DiffCount_before { get; set; }
        //[JsonProperty("Wbc Differential Count Result After 3 Months")] public string BIO_WBC_DiffCount_result_after3 { get; set; }
        //[JsonProperty("Wbc Differential Count Result After 6 Months")] public string BIO_WBC_DiffCount_result_after6 { get; set; }
        //[JsonProperty("Wbc Differentialcount Result After 9 Months")] public string BIO_WBC_DiffCount_result_after9 { get; set; }
        //[JsonProperty("Wbc Differential Count Result After 12 Months")] public string BIO_WBC_DiffCount_result_after12 { get; set; }
        //[JsonProperty("Rbc Count Before Medication")] public string BIO_RBC_Count_before { get; set; }
        //[JsonProperty("Rbc Count Result After 3 Months")] public string BIO_RBC_Count_result_after3 { get; set; }
        //[JsonProperty("Rbc Count Result After 6 Months")] public string BIO_RBC_Count_result_after6 { get; set; }
        //[JsonProperty("Rbc Count Result After 9 Months")] public string BIO_RBC_Count_result_after9 { get; set; }
        //[JsonProperty("Rbc Count Result After 12 Months")] public string BIO_RBC_Count_result_after12 { get; set; }
        //[JsonProperty("Haemoglobin Count Before Medication")] public string BIO_Haemoglobin_Count_before { get; set; }
        //[JsonProperty("Haemoglobin Count Result After 3 Months")] public string BIO_Haemoglobin_Count_result_after3 { get; set; }
        //[JsonProperty("Haemoglobin Count Result After 6 Months")] public string BIO_Haemoglobin_Count_result_after6 { get; set; }
        //[JsonProperty("Haemoglobin Count Result After 9 Months")] public string BIO_Haemoglobin_Count_result_after9 { get; set; }
        //[JsonProperty("Haemoglobin Count Result After 12 Months")] public string BIO_Haemoglobin_Count_result_after12 { get; set; }
        //[JsonProperty("Haematocrit Count Before Medication")] public string BIO_Haematocrit_Count_before { get; set; }
        //[JsonProperty("Haematocrit Count Result After 3 Months")] public string BIO_Haematocrit_Count_result_after3 { get; set; }
        //[JsonProperty("Haematocrit Count Result After 6 Months")] public string BIO_Haematocrit_Count_result_after6 { get; set; }
        //[JsonProperty("Haematocrit Count Result After 9 Months")] public string BIO_Haematocrit_Count_result_after9 { get; set; }
        //[JsonProperty("Haematocrit Count Result After 12 Months")] public string BIO_Haematocrit_Count_result_after12 { get; set; }
        //[JsonProperty("Ferritin Count Before Medication")] public string BIO_Ferritin_Count_before { get; set; }
        //[JsonProperty("Ferritin Count Result After 3 Months")] public string BIO_Ferritin_Count_result_after3 { get; set; }
        //[JsonProperty("Ferritin Count Result After 6 Months")] public string BIO_Ferritin_Count_result_after6 { get; set; }
        //[JsonProperty("Ferritin Count Result After 9 Months")] public string BIO_Ferritin_Count_result_after9 { get; set; }
        //[JsonProperty("Ferritin Count Result After 12 Months")] public string BIO_Ferritin_Count_result_after12 { get; set; }
        //[JsonProperty("Red Cell Distribution Width (Rdw) Count Before Medication")] public string BIO_RDW_Count_before { get; set; }
        //[JsonProperty("Red Cell Distribution Width (Rdw) Count Result After 3 Months")] public string BIO_RDW_Count_result_after3 { get; set; }
        //[JsonProperty("Red Cell Distribution Width (Rdw) Count Result After 6 Months")] public string BIO_RDW_Count_result_after6 { get; set; }
        //[JsonProperty("Red Cell Distribution Width (Rdw) Count Result After 9 Months")] public string BIO_RDW_Count_result_after9 { get; set; }
        //[JsonProperty("Red Cell Distribution Width (Rdw) Count Result After 12 Months")] public string BIO_RDW_Count_result_after12 { get; set; }
        //[JsonProperty("Red Blood Cell Indice Before Medication")] public string BIO_Redbloodcellindice_before { get; set; }
        //[JsonProperty("Red Blood Cell Indice Result After 3 Months")] public string BIO_Redbloodcellindice_result_after3 { get; set; }
        //[JsonProperty("Red Blood Cell Indice Result After 6 Months")] public string BIO_Redbloodcellindice_result_after6 { get; set; }
        //[JsonProperty("Red Blood Cell Indice Result After 9 Months")] public string BIO_Redbloodcellindice_result_after9 { get; set; }
        //[JsonProperty("Red Blood Cell Indice Result After 12 Months")] public string BIO_Redbloodcellindice_result_after12 { get; set; }
        //[JsonProperty("Mcv Before Medication")] public string BIO_MCV_before { get; set; }
        //[JsonProperty("Mcv Result After 3 Months")] public string BIO_MCV_result_after3 { get; set; }
        //[JsonProperty("Mcv Result After 6 Months")] public string BIO_MCV_result_after6 { get; set; }
        //[JsonProperty("Mcv Result After 9 Months")] public string BIO_MCV_result_after9 { get; set; }
        //[JsonProperty("Mcv Result After 12 Months")] public string BIO_MCV_result_after12 { get; set; }
        //[JsonProperty("Mch Before Medication")] public string BIO_MCH_before { get; set; }
        //[JsonProperty("Mch Result After 3 Months")] public string BIO_MCH_result_after3 { get; set; }
        //[JsonProperty("Mch Result After 6 Months")] public string BIO_MCH_result_after6 { get; set; }
        //[JsonProperty("Mch Result After 9 Months")] public string BIO_MCH_result_after9 { get; set; }
        //[JsonProperty("Mch Result After 12 Months")] public string BIO_MCH_result_after12 { get; set; }
        //[JsonProperty("Mchc Before Medication")] public string BIO_MCHC_before { get; set; }
        //[JsonProperty("Mchc Result After 3 Months")] public string BIO_MCHC_result_after3 { get; set; }
        //[JsonProperty("Mchc Result After 6 Months")] public string BIO_MCHC_result_after6 { get; set; }
        //[JsonProperty("Mchc Result After 9 Months")] public string BIO_MCHC_result_after9 { get; set; }
        //[JsonProperty("Mchc Result After 12 Months")] public string BIO_MCHC_result_after12 { get; set; }
        //[JsonProperty("Reticulocyte Before Medication")] public string BIO_Reticulocyte_before { get; set; }
        //[JsonProperty("Reticulocyte Result After 3 Months")] public string BIO_Reticulocyte_result_after3 { get; set; }
        //[JsonProperty("Reticulocyte Result After 6 Months")] public string BIO_Reticulocyte_result_after6 { get; set; }
        //[JsonProperty("Reticulocyte Result After 9 Months")] public string BIO_Reticulocyte_result_after9 { get; set; }
        //[JsonProperty("Reticulocyte Result After 12 Months")] public string BIO_Reticulocyte_result_after12 { get; set; }
        //[JsonProperty("Platelet (Thrombocyte) Count Before Medication")] public string BIO_Platelet_before { get; set; }
        //[JsonProperty("Platelet (Thrombocyte) Count Result After 3 Months")] public string BIO_Platelet_result_after3 { get; set; }
        //[JsonProperty("Platelet (Thrombocyte) Count Result After 6 Months")] public string BIO_Platelet_result_after6 { get; set; }
        //[JsonProperty("Platelet (Thrombocyte) Count Result After 9 Months")] public string BIO_Platelet_result_after9 { get; set; }
        //[JsonProperty("Platelet (Thrombocyte) Count Result After 12 Months")] public string BIO_Platelet_result_after12 { get; set; }
        //[JsonProperty("Mean Platelet (Mpv) Count Before Medication")] public string BIO_MPVPlatelet_before { get; set; }
        //[JsonProperty("Mean Platelet (Mpv) Count Result After 3 Months")] public string BIO_MPVPlatelet_result_after3 { get; set; }
        //[JsonProperty("Mean Platelet (Mpv) Count Result After 6 Months")] public string BIO_MPVPlatelet_result_after6 { get; set; }
        //[JsonProperty("Mean Platelet (Mpv) Count Result After 9 Months")] public string BIO_MPVPlatelet_result_after9 { get; set; }
        //[JsonProperty("Mean Platelet (Mpv) Count Result After 12 Months")] public string BIO_MPVPlatelet_result_after12 { get; set; }
        //[JsonProperty("Abeta 40 Before Medication")] public string BIO_Abeta40_before { get; set; }
        //[JsonProperty("Abeta 40 Result After 3 Months")] public string BIO_Abeta40_result_after3 { get; set; }
        //[JsonProperty("Abeta 40 Result After 6 Months")] public string BIO_Abeta40_result_after6 { get; set; }
        //[JsonProperty("Abeta 40 Result After 9 Months")] public string BIO_Abeta40_result_after9 { get; set; }
        //[JsonProperty("Abeta 40 Result After 12 Months")] public string BIO_Abeta40_result_after12 { get; set; }
        //[JsonProperty("Abeta 42 Before Medication")] public string BIO_Abeta42_before { get; set; }
        //[JsonProperty("Abeta 42 Result After 3 Months")] public string BIO_Abeta42_result_after3 { get; set; }
        //[JsonProperty("Abeta 42 Result After 6 Months")] public string BIO_Abeta42_result_after6 { get; set; }
        //[JsonProperty("Abeta 42 Result After 9 Months")] public string BIO_Abeta42_result_after9 { get; set; }
        //[JsonProperty("Abeta 42 Result After 12 Months")] public string BIO_Abeta42_result_after12 { get; set; }
        //[JsonProperty("Ttau Before Medication")] public string BIO_tTau_before { get; set; }
        //[JsonProperty("Ttau Result After 3 Months")] public string BIO_tTau_result_after3 { get; set; }
        //[JsonProperty("Ttau Result After 6 Months")] public string BIO_tTau_result_after6 { get; set; }
        //[JsonProperty("Ttau Result After 9 Months")] public string BIO_tTau_result_after9 { get; set; }
        //[JsonProperty("Ttau Result After 12 Months")] public string BIO_tTau_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Macroscopic Before Medication")] public string BIO_UTSmacroscopic_before { get; set; }
        //[JsonProperty("Urine Tests Macroscopic Result After 3 Months")] public string BIO_UTSmacroscopic_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Macroscopic Result After 6 Months")] public string BIO_UTSmacroscopic_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Macroscopic Result After 9 Months")] public string BIO_UTSmacroscopic_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Macroscopic Result After 12 Months")] public string BIO_UTSmacroscopic_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Ph Before Medication")] public string BIO_UTSpH_before { get; set; }
        //[JsonProperty("Urine Tests Ph Result After 3 Months")] public string BIO_UTSpH_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Ph Result After 6 Months")] public string BIO_UTSpH_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Ph Result After 9 Months")] public string BIO_UTSpH_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Ph Result After 12 Months")] public string BIO_UTSpH_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Glucose Before Medication")] public string BIO_UTSGlucose_before { get; set; }
        //[JsonProperty("Urine Tests Glucose Result After 3 Months")] public string BIO_UTSGlucose_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Glucose Result After 6 Months")] public string BIO_UTSGlucose_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Glucose Result After 9 Months")] public string BIO_UTSGlucose_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Glucose Result After 12 Months")] public string BIO_UTSGlucose_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Gravity Before Medication")] public string BIO_UTSGravity_before { get; set; }
        //[JsonProperty("Urine Tests Gravity Result After 3 Months")] public string BIO_UTSGravity_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Gravity Result After 6 Months")] public string BIO_UTSGravity_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Gravity Result After 9 Months")] public string BIO_UTSGravity_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Gravity Result After 12 Months")] public string BIO_UTSGravity_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Nitrite Before Medication")] public string BIO_UTSNitrite_before { get; set; }
        //[JsonProperty("Urine Tests Nitrite Result After 3 Months")] public string BIO_UTSNitrite_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Nitrite Result After 6 Months")] public string BIO_UTSNitrite_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Nitrite Result After 9 Months")] public string BIO_UTSNitrite_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Nitrite Result After 12 Months")] public string BIO_UTSNitrite_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Wbc Before Medication")] public string BIO_UTSWBC_before { get; set; }
        //[JsonProperty("Urine Tests Wbc Result After 3 Months")] public string BIO_UTSWBC_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Wbc Result After 6 Months")] public string BIO_UTSWBC_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Wbc Result After 9 Months")] public string BIO_UTSWBC_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Wbc Result After 12 Months")] public string BIO_UTSWBC_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Protein Before Medication")] public string BIO_UTSProtein_before { get; set; }
        //[JsonProperty("Urine Tests Protein Result After 3 Months")] public string BIO_UTSProtein_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Protein Result After 6 Months")] public string BIO_UTSProtein_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Protein Result After 9 Months")] public string BIO_UTSProtein_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Protein Result After 12 Months")] public string BIO_UTSProtein_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Bilirubin Before Medication")] public string BIO_UTSBilirubin_before { get; set; }
        //[JsonProperty("Urine Tests Bilirubin Result After 3 Months")] public string BIO_UTSBilirubin_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Bilirubin Result After 6 Months")] public string BIO_UTSBilirubin_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Bilirubin Result After 9 Months")] public string BIO_UTSBilirubin_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Bilirubin Result After 12 Months")] public string BIO_UTSBilirubin_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Blood Before Medication")] public string BIO_UTSBlood_before { get; set; }
        //[JsonProperty("Urine Tests Blood Result After 3 Months")] public string BIO_UTSBlood_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Blood Result After 6 Months")] public string BIO_UTSBlood_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Blood Result After 9 Months")] public string BIO_UTSBlood_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Blood Result After 12 Months")] public string BIO_UTSBlood_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Leukocyte Before Medication")] public string BIO_UTSLeukocyte_before { get; set; }
        //[JsonProperty("Urine Tests Leukocyte Result After 3 Months")] public string BIO_UTSLeukocyte_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Leukocyte Result After 6 Months")] public string BIO_UTSLeukocyte_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Leukocyte Result After 9 Months")] public string BIO_UTSLeukocyte_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Leukocyte Result After 12 Months")] public string BIO_UTSLeukocyte_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Cells) Before Medication")] public string BIO_UTSMicroscopy_cells_before { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Cells) Result After 3 Months")] public string BIO_UTSMicroscopy_cells_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Cells) Result After 6 Months")] public string BIO_UTSMicroscopy_cells_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Cells) Result After 9 Months")] public string BIO_UTSMicroscopy_cells_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Cells) Result After 12 Months")] public string BIO_UTSMicroscopy_cells_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Casts) Before Medication")] public string BIO_UTSMicroscopy_casts_before { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Casts) Result After 3 Months")] public string BIO_UTSMicroscopy_casts_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Casts) Result After 6 Months")] public string BIO_UTSMicroscopy_casts_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Casts) Result After 9 Months")] public string BIO_UTSMicroscopy_casts_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Casts) Result After 12 Months")] public string BIO_UTSMicroscopy_casts_result_after12 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Crystals) Before Medication")] public string BIO_UTSMicroscopy_crystals_before { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Crystals) Result After 3 Months")] public string BIO_UTSMicroscopy_crystals_result_after3 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Crystals) Result After 6 Months")] public string BIO_UTSMicroscopy_crystals_result_after6 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Crystals) Result After 9 Months")] public string BIO_UTSMicroscopy_crystals_result_after9 { get; set; }
        //[JsonProperty("Urine Tests Microscopy (Crystals) Result After 12 Months")] public string BIO_UTSMicroscopy_crystals_result_after12 { get; set; }
        //[JsonProperty("Cognitive Test Result_Time")] public string Cognitive_test_result_time { get; set; }
        //[JsonProperty("Laboratory Sample Type")] public string lab_sample_type { get; set; }
        //[JsonProperty("Laboratory Blood")] public string lab_blood { get; set; }
        //[JsonProperty("Laboratory Saliva")] public string lab_saliva { get; set; }
        //[JsonProperty("Laboratory Other")] public string lab_other { get; set; }
        //[JsonProperty("Laboratory Other Text")] public string lab_other_text { get; set; }
        //[JsonProperty("Laboratory Sample Date")] public string lab_sample_date { get; set; }
        //[JsonProperty("Laboratory Storage")] public string lab_sample_storage { get; set; }
        //[JsonProperty("Laboratory Sample Volume")] public string lab_sample_volume { get; set; }
        //[JsonProperty("Laboratory Project Code")] public string lab_project_code { get; set; }
        //[JsonProperty("Laboratory Comments")] public string lab_comments { get; set; }

        /////  addtional fields start 30/04/2020
        //[JsonProperty("health annual medical checkuptxtdateyear")]  public string health_annual_medical_checkuptxtdateyear { get; set; }
        //[JsonProperty("female pregnant when year")] public string female_pregnant_when_year { get; set; }
        //[JsonProperty("PPA vigorous physical activities hours")] public string PPA_vigorous_physical_activities_hours { get; set; }
        //[JsonProperty("PPA vigorous physical activities min")]  public string PPA_vigorous_physical_activities_min { get; set; }
        //[JsonProperty("PPA moderate physical activities hours")] public string PPA_moderate_physical_activities_hours { get; set; }
        //[JsonProperty("PPA moderate physical activities_min")] public string PPA_moderate_physical_activities_min { get; set; }
        //[JsonProperty("PPA walk days")]        public string PPA_walk_days { get; set; }
        //[JsonProperty("PPA walk time hours")] public string PPA_walk_time_hours { get; set; }
        //[JsonProperty("PPA walk time min")] public string PPA_walk_time_min { get; set; }
        //[JsonProperty("PPA sit hours")] public string PPA_sit_hours { get; set; }
        //[JsonProperty("PPA sit min")]        public string PPA_sit_min { get; set; }
        /////   addtional fields end
        /////   addional nadeem start
        /////   public string PSS_quit_smoking_days_txt { get; set; }
        //[JsonProperty("PSS quit smoking week txt")] public string PSS_quit_smoking_week_txt { get; set; }
        //[JsonProperty("PSS_quit_smoking_month_txt")] public string PSS_quit_smoking_month_txt { get; set; }
        //[JsonProperty("PSS quit smoking yrs txt")] public string PSS_quit_smoking_yrs_txt { get; set; }
        //[JsonProperty("PSS avg cigarettes perday194 txt")] public string PSS_avg_cigarettes_perday194_txt { get; set; }
        //[JsonProperty("PSS first smoke age694 txt")] public string PSS_first_smoke_age694_txt { get; set; }
        //[JsonProperty("PPA vigorous physical activities days")] public string PPA_vigorous_physical_activities_days { get; set; }
        //[JsonProperty("PPA work txt")] public string PPA_work_txt { get; set; }

        //[JsonProperty("donot take medication specify")] public string donot_take_medication_specify { get; set; }
        //[JsonProperty("donot take medication year")] public string donot_take_medication_year { get; set; }
        //[JsonProperty("COVID-19")] public string covid { get; set; }
        //public string flu { get; set; }

        //[JsonProperty("physical activity")] public string physical_activity { get; set; }
        //[JsonProperty("physical activity specify")] public string physical_activity_specify { get; set; }
        //[JsonProperty("physical activity year")] public string physical_activity_year { get; set; }
        //public string diet { get; set; }
        //[JsonProperty("diet specify")] public string diet_specify { get; set; }
        //[JsonProperty("diet specify year")] public string diet_specify_year { get; set; }
        //[JsonProperty("diet specify until year")] public string diet_specify_until_year { get; set; }
        //public string education { get; set; }
        //[JsonProperty("education specify")] public string education_specify { get; set; }
        //[JsonProperty("education specify year")] public string education_specify_year { get; set; }
        //[JsonProperty("education specify date")] public string education_specify_date { get; set; }

        //// maximum 1024 fields only
        ////public string metformin { get; set; }
        ////public string metformin_specify { get; set; }
        ////public string metformin_year { get; set; }
        ////public string metformin_current_dose { get; set; }
        ////public string antidiabetic { get; set; }
        ////public string antidiabetic_date { get; set; }
        ////public string antidiabetic_year { get; set; }
        ////public string antidiabetic_current_dose { get; set; }
        ////public string insulin { get; set; }
        ////public string insulin_specify { get; set; }
        ////public string insulin_date { get; set; }
        ////public string insulin_year { get; set; }
        ////public string insulin_current_dose { get; set; }
        ////public string others { get; set; }
        ////public string other_specify { get; set; }
        ////public string other_year { get; set; }
        ////public string none { get; set; }
        ////public string  other_txt { get; set; }
        ////public string complications_neuropathy_other { get; set; }
        ////public string complications_other_specify { get; set; }
        /////   addtional nadeem end

        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
