﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
   // public class QuestionnaireWrap10
    //{
    //    public QuestionnaireWrap10()
    //    {
    //        result = new List<Questionnaire10>();

    //    }
    //    public IEnumerable<Questionnaire10> result { get; set; }

    //}
    public class Questionnaire10
    {
        [Key]
        public string savedformID { get; set; }
        public string sample { get; set; }
        public string COVID19_ID { get; set; }
        public string depository_ID { get; set; }
        public string projecttitle { get; set; }
        public string principalinvestigator { get; set; }
        public string collection_point { get; set; }
        public string collected_by { get; set; }
        public string collected_date { get; set; }
        public string indifamily { get; set; }
        public string family_number { get; set; }
        public string family_yes { get; set; }
        public string interpreted_used { get; set; }
        public string interpreted_language { get; set; }
        public string interview_reason_contact_with_known_case { get; set; }
        public string interview_reason_Overseas_travel { get; set; }
        public string interview_reason_Reported_recent_risk_exposure_contact { get; set; }
        public string interview_reason_Occupational_exposure { get; set; }
        public string interview_reason_Symptomatic_of_disease { get; set; }
        public string interview_reason_other { get; set; }
        public string interview_reason_other_remarks { get; set; }
        public string per_firstname { get; set; }
        public string per_middlename { get; set; }
        public string per_lastname { get; set; }
        public string gender { get; set; }
        public string emiratesid { get; set; }
        public string nationality { get; set; }
        public string dob { get; set; }
        public string PlaceOfBirth { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string ethnicity { get; set; }
        public string ethnicity_mixed_specify_text { get; set; }
        public string ethnicity_others_text { get; set; }
        public string Address { get; set; }
        public string Address_type { get; set; }
        public string Address_type_other { get; set; }
        public string maritalstatus { get; set; }
        public string marriage_con { get; set; }
        public string pers_NumberofChildren { get; set; }
        public string pers_Boys { get; set; }
        public string pers_Boys_ages { get; set; }
        public string pers_Girls { get; set; }
        public string pers_Girls_ages { get; set; }
        public string pers_Numberofwives { get; set; }
        public string eduLevel { get; set; }
        public string employment_status { get; set; }
        public string TRP_traveled_outside { get; set; }
        public string TRP_traveled_outside_country { get; set; }
        public string TRP_traveled_outside_city { get; set; }
        public string TRP_flight_no { get; set; }
        public string TRP_seat_no { get; set; }
        public string TRP_Arrival_Date { get; set; }
        public string TRP_Departure_Date { get; set; }
        public string TRP_travel_with_organized_tour { get; set; }
        public string TRP_Type_of_accommodation { get; set; }
        public string TRP_Type_of_accommodation_other { get; set; }
        public string TRP_Able_to_enter_travel_specific_details { get; set; }
        public string TRP_modes_of_transportation_Airplane { get; set; }
        public string TRP_modes_of_transportation_Ship { get; set; }
        public string TRP_modes_of_transportation_Bus { get; set; }
        public string TRP_modes_of_transportation_Train { get; set; }
        public string TRP_modes_of_transportation_Other { get; set; }
        public string TRP_modes_of_transportation_Other_text { get; set; }
        public string TRP_Transit_stopover { get; set; }
        public string TRP_Other_travel_Information { get; set; }
        public string TRP_Other_travel_Information_Notes { get; set; }
        public string OTI_1_Date { get; set; }
        public string OTI_1_Seat_Cabin { get; set; }
        public string OTI_1_Carrier { get; set; }
        public string OTI_1_Departed_from { get; set; }
        public string OTI_1_Flight { get; set; }
        public string OTI_1_Arrived_in { get; set; }
        public string OTI_2_Date { get; set; }
        public string OTI_2_Seat_Cabin { get; set; }
        public string OTI_2_Carrier { get; set; }
        public string OTI_2_Departed_from { get; set; }
        public string OTI_2_Flight { get; set; }
        public string OTI_2_Arrived_in { get; set; }
        public string OTI_3_Date { get; set; }
        public string OTI_3_Seat_Cabin { get; set; }
        public string OTI_3_Carrier { get; set; }
        public string OTI_3_Departed_from { get; set; }
        public string OTI_3_Flight { get; set; }
        public string OTI_3_Arrived_in { get; set; }
        public string OTI_4_Date { get; set; }
        public string OTI_4_Seat_Cabin { get; set; }
        public string OTI_4_Carrier { get; set; }
        public string OTI_4_Departed_from { get; set; }
        public string OTI_4_Flight { get; set; }
        public string OTI_4_Arrived_in { get; set; }
        public string PRH_2D_contact_with_possible_COVID_19 { get; set; }
        public string PRH_2D_contact_with_possible_COVID_19_specify { get; set; }
        public string PRH_2D_Date_of_last_contact { get; set; }
        public string PRH_2D_Likely_source_of_infection { get; set; }
        public string PRH_2D_Likely_source_of_infection_Locally_Acquired_Details { get; set; }
        public string CP_3A_person_have_symptoms { get; set; }
        public string CP_3A_person_have_symptoms_onset_date { get; set; }
        public string CP_3A_duration_symptoms { get; set; }
        public string CP_3B_ARDS { get; set; }
        public string CP_3B_ARDS_onset_date { get; set; }
        public string CP_3B_ARDS_XRay { get; set; }
        public string CP_3B_Diarrhea { get; set; }
        public string CP_3B_Diarrhea_onset_date { get; set; }
        public string CP_3B_loss_of_Taste_Smell { get; set; }
        public string CP_3B_loss_of_Taste_Smell_onset_date { get; set; }
        public string CP_3B_Fever { get; set; }
        public string CP_3B_Fever_high_temperature { get; set; }
        public string CP_3B_feverish_selfreport { get; set; }
        public string CP_3B_feverish_selfreport_where_when { get; set; }
        public string CP_3B_Pneumonia { get; set; }
        public string CP_3B_Pneumonia_onset_date { get; set; }
        public string CP_3B_Pneumonia_XRay { get; set; }
        public string CP_3B_Arthralgia { get; set; }
        public string CP_3B_Arthralgia_onset_date { get; set; }
        public string CP_3B_Cough { get; set; }
        public string CP_3B_Cough_onset_date { get; set; }
        public string CP_3B_Conjunctivitis { get; set; }
        public string CP_3B_Conjunctivitis_onset_date { get; set; }
        public string CP_3B_Fatigue { get; set; }
        public string CP_3B_Fatigue_onset_date { get; set; }
        public string CP_3B_Chills_rigors { get; set; }
        public string CP_3B_Chills_rigors_onset_date { get; set; }
        public string CP_3B_Headache { get; set; }
        public string CP_3B_Headache_onset_date { get; set; }
        public string CP_3B_Malaise { get; set; }
        public string CP_3B_Malaise_onset_date { get; set; }
        public string CP_3B_Myalgia { get; set; }
        public string CP_3B_Myalgia_onset_date { get; set; }
        public string CP_3B_Nausea { get; set; }
        public string CP_3B_Nausea_onset_date { get; set; }
        public string CP_3B_Pneumonitis { get; set; }
        public string CP_3B_Pneumonitis_onset_date { get; set; }
        public string CP_3B_Rhinorrhea { get; set; }
        public string CP_3B_Rhinorrhea_onset_date { get; set; }
        public string CP_3B_Shortness_of_breath { get; set; }
        public string CP_3B_Shortness_of_breath_onset_date { get; set; }
        public string CP_3B_Sore_throat { get; set; }
        public string CP_3B_Sore_throat_onset_date { get; set; }
        public string CP_3B_Runny_stuffynose { get; set; }
        public string CP_3B_Runny_stuffynose_onset_date { get; set; }
        public string CP_3B_Muscle_bodyaches { get; set; }
        public string CP_3B_Muscle_bodyaches_onset_date { get; set; }
        public string CP_3B_Vomiting { get; set; }
        public string CP_3B_Vomiting_onset_date { get; set; }
        public string CP_3B_Sneezing { get; set; }
        public string CP_3B_Sneezing_onset_date { get; set; }
        public string CP_3B_Other_symptoms { get; set; }
        public string CP_3B_Clinical_notes { get; set; }
        public string CP_3C_person_hospitalized { get; set; }
        public string CP_3C_person_hospitalized_phone_number_hospital { get; set; }
        public string CP_3C_Admitted_ICU_HDU { get; set; }
        public string CP_3C_Admitted_ICU_HDU_number_of_days { get; set; }
        public string CP_3C_Oxygen_Therapy_reqd { get; set; }
        public string CP_3C_Intubation_reqd { get; set; }
        public string CP_3C_Mechanical_incubation_reqd { get; set; }
        public string CP_3C_Hospital_medical_record_chart_number { get; set; }
        public string CP_3D_1_Medication_administered { get; set; }
        public string CP_3D_1_Dose { get; set; }
        public string CP_3D_1_Comments { get; set; }
        public string CP_3D_2_Medication_administered { get; set; }
        public string CP_3D_2_Dose { get; set; }
        public string CP_3D_2_Comments { get; set; }
        public string CP_3D_3_Medication_administered { get; set; }
        public string CP_3D_3_Dose { get; set; }
        public string CP_3D_3_Comments { get; set; }
        public string CP_3D_4_Medication_administered { get; set; }
        public string CP_3D_4_Dose { get; set; }
        public string CP_3D_4_Comments { get; set; }
        public string CP_3D_5_Medication_administered { get; set; }
        public string CP_3D_5_Dose { get; set; }
        public string CP_3D_5_Comments { get; set; }
        public string CP_3D_6_Medication_administered { get; set; }
        public string CP_3D_6_Dose { get; set; }
        public string CP_3D_6_Comments { get; set; }
        public string CP_3D_7_Medication_administered { get; set; }
        public string CP_3D_7_Dose { get; set; }
        public string CP_3D_7_Comments { get; set; }
        public string CP_3E_outcome_of_the_case { get; set; }
        public string CP_3E_outcome_of_the_case_date_of_death { get; set; }
        public string CP_3E_death_due_to_COVID_19 { get; set; }
        public string CP_3E_death_due_to_other_cause { get; set; }
        public string CP_3EE_No_risk_medical_conditions { get; set; }
        public string CP_3EE_Cardiac_disease { get; set; }
        public string CP_3EE_Chronic_lung_disease { get; set; }
        public string CP_3EE_Haemoglobinopathies { get; set; }
        public string CP_3EE_Diabetes { get; set; }
        public string CP_3EE_Diabetes_dialysis { get; set; }
        public string CP_3EE_Immunosuppressive_condition { get; set; }
        public string CP_3EE_Immunosuppressive_condition_specify { get; set; }
        public string CP_3EE_Liver_disease { get; set; }
        public string CP_3EE_Metabolic_disease { get; set; }
        public string CP_3EE_Neurological_disorder { get; set; }
        public string CP_3EE_Obesity { get; set; }
        public string CP_3EE_Renal_disease { get; set; }
        public string CP_3EE_Other_risk_medical_condition { get; set; }
        public string CP_3EE_Other_risk_medical_condition_specify { get; set; }
        public string CP_3EE_Notes { get; set; }
        public string CP_3F_currently_pregnant { get; set; }
        public string CP_3F_currently_pregnant_number_of_weeks_gestation { get; set; }
        public string CP_3F_current_smoker { get; set; }
        public string CP_3F_current_smoker_year { get; set; }
        public string CP_3F_current_smoker_pack_per_Week { get; set; }
        public string CP_3F_consume_alcohol { get; set; }
        public string CP_3F_drinks_per_week { get; set; }
        public string PCI_4A_Participants_blood_type { get; set; }
        public string PCI_4A_Participants_Weight { get; set; }
        public string PCI_4A_Participants_Height { get; set; }
        public string PCI_4B_Hepatitis_B_type { get; set; }
        public string PCI_4B_Hepatitis_B_date_given { get; set; }
        public string PCI_4B_Hepatitis_B_administered_by { get; set; }
        public string PCI_4B_Deptheria_Tetanus_Pertussis_type { get; set; }
        public string PCI_4B_Deptheria_Tetanus_Pertussis_date_given { get; set; }
        public string PCI_4B_Deptheria_Tetanus_Pertussis_administered_by { get; set; }
        public string PCI_4B_Haemophilus_influenza_type_b_type { get; set; }
        public string PCI_4B_Haemophilus_influenza_type_b_date_given { get; set; }
        public string PCI_4B_Haemophilus_influenza_type_b_administered_by { get; set; }
        public string PCI_4B_Pneumococcal_type { get; set; }
        public string PCI_4B_Pneumococcal_date_given { get; set; }
        public string PCI_4B_Pneumococcal_administered_by { get; set; }
        public string PCI_4B_Polio_type { get; set; }
        public string PCI_4B_Polio_date_given { get; set; }
        public string PCI_4B_Polio_administered_by { get; set; }
        public string PCI_4B_Rotavirus_type { get; set; }
        public string PCI_4B_Rotavirus_date_given { get; set; }
        public string PCI_4B_Rotavirus_administered_by { get; set; }
        public string PCI_4B_Measles_type { get; set; }
        public string PCI_4B_Measles_date_given { get; set; }
        public string PCI_4B_Measles_administered_by { get; set; }
        public string PCI_4B_Varicella_type { get; set; }
        public string PCI_4B_Varicella_date_given { get; set; }
        public string PCI_4B_Varicella_administered_by { get; set; }
        public string PCI_4B_Hepatitis_A_type { get; set; }
        public string PCI_4B_Hepatitis_A_date_given { get; set; }
        public string PCI_4B_Hepatitis_A_administered_by { get; set; }
        public string PCI_4B_Meningococcal_type { get; set; }
        public string PCI_4B_Meningococcal_date_given { get; set; }
        public string PCI_4B_Meningococcal_administered_by { get; set; }
        public string PCI_4B_Human_papillomavirus_type { get; set; }
        public string PCI_4B_Human_papillomavirus_date_given { get; set; }
        public string PCI_4B_Human_papillomavirus_administered_by { get; set; }
        public string PCI_4B_Zoster_type { get; set; }
        public string PCI_4B_Zoster_date_given { get; set; }
        public string PCI_4B_Zoster_administered_by { get; set; }
        public string PCI_4B_Influenza_type { get; set; }
        public string PCI_4B_Influenza_date_given { get; set; }
        public string PCI_4B_Influenza_administered_by { get; set; }
        public string PCI_4B_Bacillus_Calmette_type { get; set; }
        public string PCI_4B_Bacillus_Calmette_date_given { get; set; }
        public string PCI_4B_Bacillus_Calmette_administered_by { get; set; }
        public string PCI_4C_Asthma_wheezing_YesNo { get; set; }
        public string PCI_4C_Asthma_wheezing_OnsetAge { get; set; }
        public string PCI_4C_Asthma_wheezing_Severity { get; set; }
        public string PCI_4C_Asthma_wheezing_Comments { get; set; }
        public string PCI_4C_Other_breathing_problems_YesNo { get; set; }
        public string PCI_4C_Other_breathing_problems_OnsetAge { get; set; }
        public string PCI_4C_Other_breathing_problems_Severity { get; set; }
        public string PCI_4C_Other_breathing_problems_Comments { get; set; }
        public string PCI_4C_Sinus_trouble_YesNo { get; set; }
        public string PCI_4C_Sinus_trouble_OnsetAge { get; set; }
        public string PCI_4C_Sinus_trouble_Severity { get; set; }
        public string PCI_4C_Sinus_trouble_Comments { get; set; }
        public string PCI_4C_Hay_fever_YesNo { get; set; }
        public string PCI_4C_Hay_fever_OnsetAge { get; set; }
        public string PCI_4C_Hay_fever_Severity { get; set; }
        public string PCI_4C_Hay_fever_Comments { get; set; }
        public string PCI_4C_Hives_YesNo { get; set; }
        public string PCI_4C_Hives_OnsetAge { get; set; }
        public string PCI_4C_Hives_Severity { get; set; }
        public string PCI_4C_Hives_Comments { get; set; }
        public string PCI_4C_Eczema_YesNo { get; set; }
        public string PCI_4C_Eczema_OnsetAge { get; set; }
        public string PCI_4C_Eczema_Severity { get; set; }
        public string PCI_4C_Eczema_Comments { get; set; }
        public string PCI_4C_Frequent_infections_YesNo { get; set; }
        public string PCI_4C_Frequent_infections_OnsetAge { get; set; }
        public string PCI_4C_Frequent_infections_Severity { get; set; }
        public string PCI_4C_Frequent_infections_Comments { get; set; }
        public string PCI_4C_Food_reactions_YesNo { get; set; }
        public string PCI_4C_Food_reactions_OnsetAge { get; set; }
        public string PCI_4C_Food_reactions_Severity { get; set; }
        public string PCI_4C_Food_reactions_Comments { get; set; }
        public string PCI_4C_Drug_reactions_YesNo { get; set; }
        public string PCI_4C_Drug_reactions_OnsetAge { get; set; }
        public string PCI_4C_Drug_reactions_Severity { get; set; }
        public string PCI_4C_Drug_reactions_Comments { get; set; }
        public string PCI_4C_Others_YesNo { get; set; }
        public string PCI_4C_Others_Name { get; set; }
        public string PCI_4C_Others_OnsetAge { get; set; }
        public string PCI_4C_Others_Severity { get; set; }
        public string PCI_4C_Others_Comments { get; set; }
        public string PCI_4D_1_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_1_Viral_Infection_Name { get; set; }
        public string PCI_4D_1_Viral_Infection_year { get; set; }
        public string PCI_4D_1_Viral_Infection_Severity { get; set; }
        public string PCI_4D_1_Viral_Infection_Comments { get; set; }
        public string PCI_4D_2_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_2_Viral_Infection_Name { get; set; }
        public string PCI_4D_2_Viral_Infection_year { get; set; }
        public string PCI_4D_2_Viral_Infection_Severity { get; set; }
        public string PCI_4D_2_Viral_Infection_Comments { get; set; }
        public string PCI_4D_3_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_3_Viral_Infection_Name { get; set; }
        public string PCI_4D_3_Viral_Infection_year { get; set; }
        public string PCI_4D_3_Viral_Infection_Severity { get; set; }
        public string PCI_4D_3_Viral_Infection_Comments { get; set; }
        public string PCI_4D_4_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_4_Viral_Infection_Name { get; set; }
        public string PCI_4D_4_Viral_Infection_year { get; set; }
        public string PCI_4D_4_Viral_Infection_Severity { get; set; }
        public string PCI_4D_4_Viral_Infection_Comments { get; set; }
        public string PCI_4D_5_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_5_Viral_Infection_Name { get; set; }
        public string PCI_4D_5_Viral_Infection_year { get; set; }
        public string PCI_4D_5_Viral_Infection_Severity { get; set; }
        public string PCI_4D_5_Viral_Infection_Comments { get; set; }
        public string PCI_4D_6_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_6_Viral_Infection_Name { get; set; }
        public string PCI_4D_6_Viral_Infection_year { get; set; }
        public string PCI_4D_6_Viral_Infection_Severity { get; set; }
        public string PCI_4D_6_Viral_Infection_Comments { get; set; }
        public string PCI_4D_7_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_7_Viral_Infection_Name { get; set; }
        public string PCI_4D_7_Viral_Infection_year { get; set; }
        public string PCI_4D_7_Viral_Infection_Severity { get; set; }
        public string PCI_4D_7_Viral_Infection_Comments { get; set; }
        public string PCI_4D_8_Viral_Infection_YesNo { get; set; }
        public string PCI_4D_8_Viral_Infection_Name { get; set; }
        public string PCI_4D_8_Viral_Infection_year { get; set; }
        public string PCI_4D_8_Viral_Infection_Severity { get; set; }
        public string PCI_4D_8_Viral_Infection_Comments { get; set; }
        public string ES_5A_present_to_hospital_in_14_days_COVID_19_symptoms { get; set; }
        public string ES_5A_present_to_hospital_in_14_days_COVID_19_symptoms_date { get; set; }
        public string ES_5A_present_to_hospital_in_14_days_COVID_19_symptoms_detail_of_illness { get; set; }
        public string ES_5A_present_to_hospital_in_14_days_other_symptoms { get; set; }
        public string ES_5A_present_to_hospital_in_14_days_other_symptoms_date { get; set; }
        public string ES_5A_present_to_hospital_in_14_days_other_symptoms_detail_of_illness { get; set; }
        public string ES_5A_present_to_other_healthcare_facility_in_14_days_COVID_19_symptoms { get; set; }
        public string ES_5A_present_to_other_healthcare_facility_in_14_days_COVID_19_symptoms_date { get; set; }
        public string ES_5A_present_to_other_healthcare_facility_in_14_days_COVID_19_symptoms_detail_of_illness { get; set; }
        public string PC_6A_work_in_highrisk_occupations { get; set; }
        public string PC_6A_work_in_highrisk_occupations_others { get; set; }
        public string PC_6A_work_in_highrisk_occupations_Last_date { get; set; }
        public string PC_6A_infection_likely_acquired_in_workplace { get; set; }
        public string PC_6A_Description_of_occupation { get; set; }
        public string PC_6A_Employer_facility_details { get; set; }
        public string PC_6A_Employer_facility_address { get; set; }
        public string PC_6A_Employer_facility_emirates { get; set; }
        public string PC_6A_Employer_facility_email { get; set; }
        public string PC_6A_Employer_facility_phone { get; set; }
        public string PC_6A_Employer_facility_contact_name { get; set; }
        public string PC_6B_infectious_visited_venues_doctor { get; set; }
        public string PC_6B_infectious_visited_venues_Schools { get; set; }
        public string PC_6B_infectious_visited_venues_Aged_care_facility { get; set; }
        public string PC_6B_infectious_visited_venues_Transport { get; set; }
        public string PC_6B_infectious_visited_venues_Concert { get; set; }
        public string PC_6B_infectious_visited_venues_Office { get; set; }
        public string PC_6B_infectious_visited_venues_other { get; set; }
        public string PC_6B_infectious_visited_venues_other_detail { get; set; }
        public string PC_6C_infectious_close_contact { get; set; }
        public string PC_6C_infectious_close_contact_details { get; set; }
        public string LD_7_sample_type { get; set; }
        public string LD_7_sample_type_other { get; set; }
        public string LD_7_sample_received_date { get; set; }
        public string LD_7_storage { get; set; }
        public string LD_7_sample_volume { get; set; }
        public string LD_7_project_code { get; set; }
        public string LD_7_test_code { get; set; }
        public string LD_7_comments { get; set; }

        // additional fields
        
        public string LD_7_blood { get; set; }
        public string LD_7_saliva { get; set; }
        public string LD_7_tissue { get; set; }
        public string LD_7_sample_type_other_txt { get; set; }

        // addidional fields 30/06/2020
        public string MQ_Antibiotics { get; set; }
        public string MQ_Probiotics { get; set; }
        public string MQ_FibreIntake_Fruit { get; set; }
        public string MQ_FibreIntake_Vegetables { get; set; }
        public string MQ_FibreIntake_WholemealBreads { get; set; }
        public string MQ_FibreIntake_NutsSeeds { get; set; }
        public string MQ_FibreIntake_LegumesBeansPeasLentils { get; set; }
        public string MQ_Exercise { get; set; }
        public string MQ_LongStandingSuffering { get; set; }
        public string MQ_LongStandingSuffering_Specify { get; set; }

        // additional fields - instead of radio/ make check box 09/07/2020
        public string MQ_LongStandingSuffering_Hypertension{ get; set; }
        public string MQ_LongStandingSuffering_CVD { get; set; }
        public string MQ_LongStandingSuffering_COPD { get; set; }
        public string MQ_LongStandingSuffering_Asthma { get; set; }
        public string MQ_LongStandingSuffering_Others { get; set; }
        public string MQ_LongStandingSuffering_None { get; set; }

        //16/07/2020
        public string PCI_4B_Immunization_record { get; set; }
        public string PCI_4C_Allergies { get; set; }
        public string PCI_4D_Previous_viral_infections { get; set; }

        // 26/07/2020
        public string Severity { get; set; }
        public string Age { get; set; }
    }
}
