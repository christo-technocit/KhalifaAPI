using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
     public class QuestionnaireWrap10
    {
       public QuestionnaireWrap10()
        {
           result = new List<Q10ViewModel>();

        }
        public IEnumerable<Q10ViewModel> result { get; set; }

    }
    public class Q10ViewModel
    {
        [Key]
        public string savedformID { get; set; }
        [JsonProperty("Sample Id")] public string sample { get; set; }
        [JsonProperty("COVID19 ID")] public string COVID19_ID { get; set; }
        [JsonProperty("Depository Id")] public string depository_ID { get; set; }
        [JsonProperty("Project Title")] public string projecttitle { get; set; }
        [JsonProperty("Principal Investigator")] public string principalinvestigator { get; set; }
        [JsonProperty("Collection Point")] public string collection_point { get; set; }
        [JsonProperty("Collected By")] public string collected_by { get; set; }
        [JsonProperty("Date Of Collection")] public string collected_date { get; set; }
        [JsonProperty("Individual/Family")] public string indifamily { get; set; }
        [JsonProperty("Family Number")] public string family_number { get; set; }
        [JsonProperty("Father / Mother / Child<18 / Child >18")] public string family_yes { get; set; }
        [JsonProperty("Interpreted Used")] public string interpreted_used { get; set; }
        [JsonProperty("Interpreted Language")] public string interpreted_language { get; set; }
        [JsonProperty("Contact With Known Case")] public string interview_reason_contact_with_known_case { get; set; }
        [JsonProperty("Overseas Travel")] public string interview_reason_Overseas_travel { get; set; }
        [JsonProperty("Reported Recent Risk Exposure/Contact")] public string interview_reason_Reported_recent_risk_exposure_contact { get; set; }
        [JsonProperty("Occupational Exposure")] public string interview_reason_Occupational_exposure { get; set; }
        [JsonProperty("Symptomatic Of Disease")] public string interview_reason_Symptomatic_of_disease { get; set; }
        [JsonProperty("Interview Reason Other")] public string interview_reason_other { get; set; }
        [JsonProperty("Interview Reason Other Remarks")] public string interview_reason_other_remarks { get; set; }
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
        [JsonProperty("Address")] public string Address { get; set; }
        [JsonProperty("Address Type")] public string Address_type { get; set; }
        [JsonProperty("Address Type Other")] public string Address_type_other { get; set; }
        [JsonProperty("Marital Status")] public string maritalstatus { get; set; }
        [JsonProperty("Consanguineous")] public string marriage_con { get; set; }
        [JsonProperty("Number Of Children")] public string pers_NumberofChildren { get; set; }
        [JsonProperty("Boys")] public string pers_Boys { get; set; }
        [JsonProperty("Boys Ages")] public string pers_Boys_ages { get; set; }
        [JsonProperty("Girls")] public string pers_Girls { get; set; }
        [JsonProperty("Girls Ages")] public string pers_Girls_ages { get; set; }
        [JsonProperty("Number Of Wives")] public string pers_Numberofwives { get; set; }
        [JsonProperty("Highest Education Level")] public string eduLevel { get; set; }
        [JsonProperty("Current Employment Status")] public string employment_status { get; set; }
        [JsonProperty("Traveled Outside The Country In 14 Days")] public string TRP_traveled_outside { get; set; }
        [JsonProperty("Traveled Outside The Country")] public string TRP_traveled_outside_country { get; set; }
        [JsonProperty("Traveled Outside The City Region")] public string TRP_traveled_outside_city { get; set; }
        [JsonProperty("Flight No")] public string TRP_flight_no { get; set; }
        [JsonProperty("Seat No")] public string TRP_seat_no { get; set; }
        [JsonProperty("Arrival Date")] public string TRP_Arrival_Date { get; set; }
        [JsonProperty("Departure Date")] public string TRP_Departure_Date { get; set; }
        [JsonProperty("Travel With An Organized Tour")] public string TRP_travel_with_organized_tour { get; set; }
        [JsonProperty("Type Of Accommodation")] public string TRP_Type_of_accommodation { get; set; }
        [JsonProperty("Type Of Accommodation Other")] public string TRP_Type_of_accommodation_other { get; set; }
        [JsonProperty("Able To Enter Travel-Specific Details")] public string TRP_Able_to_enter_travel_specific_details { get; set; }
        [JsonProperty("Modes Of Transportation Airplane")] public string TRP_modes_of_transportation_Airplane { get; set; }
        [JsonProperty("Modes Of Transportation Ship/Boat/Ferry")] public string TRP_modes_of_transportation_Ship { get; set; }
        [JsonProperty("Modes Of Transportation Bus")] public string TRP_modes_of_transportation_Bus { get; set; }
        [JsonProperty("Modes Of Transportation Train")] public string TRP_modes_of_transportation_Train { get; set; }
        [JsonProperty("Modes Of Transportation Other")] public string TRP_modes_of_transportation_Other { get; set; }
        [JsonProperty("Modes Of Transportation Other Text")] public string TRP_modes_of_transportation_Other_text { get; set; }
        [JsonProperty("Transit/Stopover")] public string TRP_Transit_stopover { get; set; }
        [JsonProperty("Other Travel Information")] public string TRP_Other_travel_Information { get; set; }
        [JsonProperty("Other Travel Information Notes")] public string TRP_Other_travel_Information_Notes { get; set; }
        [JsonProperty("Other Travel Information 1 Date")] public string OTI_1_Date { get; set; }
        [JsonProperty("Other Travel Information 1 Seat / Cabin")] public string OTI_1_Seat_Cabin { get; set; }
        [JsonProperty("Other Travel Information 1 Carrier")] public string OTI_1_Carrier { get; set; }
        [JsonProperty("Other Travel Information 1 Departed From")] public string OTI_1_Departed_from { get; set; }
        [JsonProperty("Other Travel Information 1 Flight #")] public string OTI_1_Flight { get; set; }
        [JsonProperty("Other Travel Information 1 Arrived In")] public string OTI_1_Arrived_in { get; set; }
        [JsonProperty("Other Travel Information 2 Date")] public string OTI_2_Date { get; set; }
        [JsonProperty("Other Travel Information 2 Seat / Cabin")] public string OTI_2_Seat_Cabin { get; set; }
        [JsonProperty("Other Travel Information 2 Carrier")] public string OTI_2_Carrier { get; set; }
        [JsonProperty("Other Travel Information 2 Departed From")] public string OTI_2_Departed_from { get; set; }
        [JsonProperty("Other Travel Information 2 Flight #")] public string OTI_2_Flight { get; set; }
        [JsonProperty("Other Travel Information 2 Arrived In")] public string OTI_2_Arrived_in { get; set; }
        [JsonProperty("Other Travel Information 3 Date")] public string OTI_3_Date { get; set; }
        [JsonProperty("Other Travel Information 3 Seat / Cabin")] public string OTI_3_Seat_Cabin { get; set; }
        [JsonProperty("Other Travel Information 3 Carrier")] public string OTI_3_Carrier { get; set; }
        [JsonProperty("Other Travel Information 3 Departed From")] public string OTI_3_Departed_from { get; set; }
        [JsonProperty("Other Travel Information 3 Flight #")] public string OTI_3_Flight { get; set; }
        [JsonProperty("Other Travel Information 3 Arrived In")] public string OTI_3_Arrived_in { get; set; }
        [JsonProperty("Other Travel Information 4 Date")] public string OTI_4_Date { get; set; }
        [JsonProperty("Other Travel Information 4 Seat / Cabin")] public string OTI_4_Seat_Cabin { get; set; }
        [JsonProperty("Other Travel Information 4 Carrier")] public string OTI_4_Carrier { get; set; }
        [JsonProperty("Other Travel Information 4 Departed From")] public string OTI_4_Departed_from { get; set; }
        [JsonProperty("Other Travel Information 4 Flight #")] public string OTI_4_Flight { get; set; }
        [JsonProperty("Other Travel Information 4 Arrived In")] public string OTI_4_Arrived_in { get; set; }
        [JsonProperty("Contact With A Known Or Possible Covid-19 Case")] public string PRH_2D_contact_with_possible_COVID_19 { get; set; }
        [JsonProperty("Contact With A Known Or Possible Covid-19 Case Specify")] public string PRH_2D_contact_with_possible_COVID_19_specify { get; set; }
        [JsonProperty("Date Of Last Contact")] public string PRH_2D_Date_of_last_contact { get; set; }
        [JsonProperty("Likely Source Of Infection")] public string PRH_2D_Likely_source_of_infection { get; set; }
        [JsonProperty("Likely Source Of Infection Locally_Acquired_Details")] public string PRH_2D_Likely_source_of_infection_Locally_Acquired_Details { get; set; }
        [JsonProperty("Person Have Symptoms")] public string CP_3A_person_have_symptoms { get; set; }
        [JsonProperty("Person Have Symptoms Onset Date")] public string CP_3A_person_have_symptoms_onset_date { get; set; }
        [JsonProperty("Duration Symptoms")] public string CP_3A_duration_symptoms { get; set; }
        [JsonProperty("Acute Respiratory Distress Syndrome")] public string CP_3B_ARDS { get; set; }
        [JsonProperty("Acute Respiratory Distress Syndrome Onset Date")] public string CP_3B_ARDS_onset_date { get; set; }
        [JsonProperty("Ards Confirmed By X-Ray")] public string CP_3B_ARDS_XRay { get; set; }
        [JsonProperty("Diarrhea")] public string CP_3B_Diarrhea { get; set; }
        [JsonProperty("Diarrhea Onset Date")] public string CP_3B_Diarrhea_onset_date { get; set; }
        [JsonProperty("Loss Of Taste / Smell")] public string CP_3B_loss_of_Taste_Smell { get; set; }
        [JsonProperty("Loss Of Taste / Smell Onset Date")] public string CP_3B_loss_of_Taste_Smell_onset_date { get; set; }
        [JsonProperty("Fever")] public string CP_3B_Fever { get; set; }
        [JsonProperty("Fever High Temperature (Celsius)")] public string CP_3B_Fever_high_temperature { get; set; }
        [JsonProperty("Feverish Self Report")] public string CP_3B_feverish_selfreport { get; set; }
        [JsonProperty("Feverish Self Report Where & When")] public string CP_3B_feverish_selfreport_where_when { get; set; }
        [JsonProperty("Pneumonia")] public string CP_3B_Pneumonia { get; set; }
        [JsonProperty("Pneumonia Onset Date")] public string CP_3B_Pneumonia_onset_date { get; set; }
        [JsonProperty("Pneumonia Confirmed By X-Ray")] public string CP_3B_Pneumonia_XRay { get; set; }
        [JsonProperty("Arthralgia")] public string CP_3B_Arthralgia { get; set; }
        [JsonProperty("Arthralgia Onset Date")] public string CP_3B_Arthralgia_onset_date { get; set; }
        [JsonProperty("Cough")] public string CP_3B_Cough { get; set; }
        [JsonProperty("Cough Onset Date")] public string CP_3B_Cough_onset_date { get; set; }
        [JsonProperty("Conjunctivitis")] public string CP_3B_Conjunctivitis { get; set; }
        [JsonProperty("Conjunctivitis Onset Date")] public string CP_3B_Conjunctivitis_onset_date { get; set; }
        [JsonProperty("Fatigue")] public string CP_3B_Fatigue { get; set; }
        [JsonProperty("Fatigue Onset Date")] public string CP_3B_Fatigue_onset_date { get; set; }
        [JsonProperty("Chills Or Rigors")] public string CP_3B_Chills_rigors { get; set; }
        [JsonProperty("Chills Or Rigors Onset Date")] public string CP_3B_Chills_rigors_onset_date { get; set; }
        [JsonProperty("Headache")] public string CP_3B_Headache { get; set; }
        [JsonProperty("Headache Onset Date")] public string CP_3B_Headache_onset_date { get; set; }
        [JsonProperty("Malaise")] public string CP_3B_Malaise { get; set; }
        [JsonProperty("Malaise Onset Date")] public string CP_3B_Malaise_onset_date { get; set; }
        [JsonProperty("Myalgia")] public string CP_3B_Myalgia { get; set; }
        [JsonProperty("Myalgia Onset Date")] public string CP_3B_Myalgia_onset_date { get; set; }
        [JsonProperty("Nausea")] public string CP_3B_Nausea { get; set; }
        [JsonProperty("Nausea Onset Date")] public string CP_3B_Nausea_onset_date { get; set; }
        [JsonProperty("Pneumonitis")] public string CP_3B_Pneumonitis { get; set; }
        [JsonProperty("Pneumonitis Onset Date")] public string CP_3B_Pneumonitis_onset_date { get; set; }
        [JsonProperty("Rhinorrhea")] public string CP_3B_Rhinorrhea { get; set; }
        [JsonProperty("Rhinorrhea Onset Date")] public string CP_3B_Rhinorrhea_onset_date { get; set; }
        [JsonProperty("Shortness Of Breath")] public string CP_3B_Shortness_of_breath { get; set; }
        [JsonProperty("Shortness Of Breath Onset Date")] public string CP_3B_Shortness_of_breath_onset_date { get; set; }
        [JsonProperty("Sore Throat")] public string CP_3B_Sore_throat { get; set; }
        [JsonProperty("Sore Throat Onset Date")] public string CP_3B_Sore_throat_onset_date { get; set; }
        [JsonProperty("Runny Or Stuffy Nose")] public string CP_3B_Runny_stuffynose { get; set; }
        [JsonProperty("Runny Or Stuffy Nose Onset Date")] public string CP_3B_Runny_stuffynose_onset_date { get; set; }
        [JsonProperty("Muscle Or Body Aches Nose")] public string CP_3B_Muscle_bodyaches { get; set; }
        [JsonProperty("Muscle Or Body Aches Onset Date")] public string CP_3B_Muscle_bodyaches_onset_date { get; set; }
        [JsonProperty("Vomiting")] public string CP_3B_Vomiting { get; set; }
        [JsonProperty("Vomiting Onset Date")] public string CP_3B_Vomiting_onset_date { get; set; }
        [JsonProperty("Sneezing")] public string CP_3B_Sneezing { get; set; }
        [JsonProperty("Sneezing Onset Date")] public string CP_3B_Sneezing_onset_date { get; set; }
        [JsonProperty("Other Symptoms")] public string CP_3B_Other_symptoms { get; set; }
        [JsonProperty("Clinical Notes")] public string CP_3B_Clinical_notes { get; set; }
        [JsonProperty("Person Hospitalized")] public string CP_3C_person_hospitalized { get; set; }
        [JsonProperty("Person Hospitalized Phone Number Of Hospital")] public string CP_3C_person_hospitalized_phone_number_hospital { get; set; }
        [JsonProperty("Admitted To Icu/Hdu")] public string CP_3C_Admitted_ICU_HDU { get; set; }
        [JsonProperty(", Number Of Days  Admitted To Icu/Hdu")] public string CP_3C_Admitted_ICU_HDU_number_of_days { get; set; }
        [JsonProperty("Oxygen Therapy  Required")] public string CP_3C_Oxygen_Therapy_reqd { get; set; }
        [JsonProperty("Intubation Required")] public string CP_3C_Intubation_reqd { get; set; }
        [JsonProperty("Mechanical Incubation Required")] public string CP_3C_Mechanical_incubation_reqd { get; set; }
        [JsonProperty("Hospital Medical Record/Chart Number")] public string CP_3C_Hospital_medical_record_chart_number { get; set; }
        [JsonProperty("1 Medication Administered")] public string CP_3D_1_Medication_administered { get; set; }
        [JsonProperty("1 Dose")] public string CP_3D_1_Dose { get; set; }
        [JsonProperty("1 Comments")] public string CP_3D_1_Comments { get; set; }
        [JsonProperty("2 Medication Administered")] public string CP_3D_2_Medication_administered { get; set; }
        [JsonProperty("2 Dose")] public string CP_3D_2_Dose { get; set; }
        [JsonProperty("2 Comments")] public string CP_3D_2_Comments { get; set; }
        [JsonProperty("3 Medication Administered")] public string CP_3D_3_Medication_administered { get; set; }
        [JsonProperty("3 Dose")] public string CP_3D_3_Dose { get; set; }
        [JsonProperty("3 Comments")] public string CP_3D_3_Comments { get; set; }
        [JsonProperty("4 Medication Administered")] public string CP_3D_4_Medication_administered { get; set; }
        [JsonProperty("4 Dose")] public string CP_3D_4_Dose { get; set; }
        [JsonProperty("4 Comments")] public string CP_3D_4_Comments { get; set; }
        [JsonProperty("5 Medication Administered")] public string CP_3D_5_Medication_administered { get; set; }
        [JsonProperty("5 Dose")] public string CP_3D_5_Dose { get; set; }
        [JsonProperty("5 Comments")] public string CP_3D_5_Comments { get; set; }
        [JsonProperty("6 Medication Administered")] public string CP_3D_6_Medication_administered { get; set; }
        [JsonProperty("6 Dose")] public string CP_3D_6_Dose { get; set; }
        [JsonProperty("6 Comments")] public string CP_3D_6_Comments { get; set; }
        [JsonProperty("7 Medication Administered")] public string CP_3D_7_Medication_administered { get; set; }
        [JsonProperty("7 Dose")] public string CP_3D_7_Dose { get; set; }
        [JsonProperty("7 Comments")] public string CP_3D_7_Comments { get; set; }
        [JsonProperty("Outcome Of The Case")] public string CP_3E_outcome_of_the_case { get; set; }
        [JsonProperty("Outcome Of The Case Date Of Death:")] public string CP_3E_outcome_of_the_case_date_of_death { get; set; }
        [JsonProperty("Death Due To Covid-19")] public string CP_3E_death_due_to_COVID_19 { get; set; }
        [JsonProperty("Death Due To Other Cause")] public string CP_3E_death_due_to_other_cause { get; set; }
        [JsonProperty("No Risk Medical Conditions")] public string CP_3EE_No_risk_medical_conditions { get; set; }
        [JsonProperty("Cardiac Disease (Not Simple Hypertension)")] public string CP_3EE_Cardiac_disease { get; set; }
        [JsonProperty("Chronic Lung Disease")] public string CP_3EE_Chronic_lung_disease { get; set; }
        [JsonProperty("Haemoglobinopathies")] public string CP_3EE_Haemoglobinopathies { get; set; }
        [JsonProperty("Diabetes")] public string CP_3EE_Diabetes { get; set; }
        [JsonProperty("Diabetes Dialysis")] public string CP_3EE_Diabetes_dialysis { get; set; }
        [JsonProperty("Immunosuppressive Condition")] public string CP_3EE_Immunosuppressive_condition { get; set; }
        [JsonProperty("Immunosuppressive Condition Specify")] public string CP_3EE_Immunosuppressive_condition_specify { get; set; }
        [JsonProperty("Liver Disease")] public string CP_3EE_Liver_disease { get; set; }
        [JsonProperty("Metabolic  Disease")] public string CP_3EE_Metabolic_disease { get; set; }
        [JsonProperty("Neurological Disorder")] public string CP_3EE_Neurological_disorder { get; set; }
        [JsonProperty("Obesity")] public string CP_3EE_Obesity { get; set; }
        [JsonProperty("Renal Disease")] public string CP_3EE_Renal_disease { get; set; }
        [JsonProperty("Other Risk Medical Condition")] public string CP_3EE_Other_risk_medical_condition { get; set; }
        [JsonProperty("Other Risk Medical Condition Specify")] public string CP_3EE_Other_risk_medical_condition_specify { get; set; }
        [JsonProperty("Pre-Existing Conditions Notes")] public string CP_3EE_Notes { get; set; }
        [JsonProperty("Currently Pregnant Or Pregnant During The Illness")] public string CP_3F_currently_pregnant { get; set; }
        [JsonProperty("Number Of Weeks Gestation")] public string CP_3F_currently_pregnant_number_of_weeks_gestation { get; set; }
        [JsonProperty("Current Smoker")] public string CP_3F_current_smoker { get; set; }
        [JsonProperty("Howmany Years Current Smoker")] public string CP_3F_current_smoker_year { get; set; }
        [JsonProperty("Howmany Pack Per Week Current Smoker")] public string CP_3F_current_smoker_pack_per_Week { get; set; }
        [JsonProperty("Consume Alcohol")] public string CP_3F_consume_alcohol { get; set; }
        [JsonProperty("Consume Alcohol Drinks Per Week")] public string CP_3F_drinks_per_week { get; set; }
        [JsonProperty("Participants Blood Type")] public string PCI_4A_Participants_blood_type { get; set; }
        [JsonProperty("Participants Weight")] public string PCI_4A_Participants_Weight { get; set; }
        [JsonProperty("Participants Height")] public string PCI_4A_Participants_Height { get; set; }
        [JsonProperty("Hepatitis B Type")] public string PCI_4B_Hepatitis_B_type { get; set; }
        [JsonProperty("Hepatitis B Date Given")] public string PCI_4B_Hepatitis_B_date_given { get; set; }
        [JsonProperty("Hepatitis B Administered By")] public string PCI_4B_Hepatitis_B_administered_by { get; set; }
        [JsonProperty("Deptheria, Tetanus, Pertussis Type")] public string PCI_4B_Deptheria_Tetanus_Pertussis_type { get; set; }
        [JsonProperty("Deptheria, Tetanus, Pertussis Date Given")] public string PCI_4B_Deptheria_Tetanus_Pertussis_date_given { get; set; }
        [JsonProperty("Deptheria, Tetanus, Pertussis Administered By")] public string PCI_4B_Deptheria_Tetanus_Pertussis_administered_by { get; set; }
        [JsonProperty("Haemophilus Influenza Type B Type")] public string PCI_4B_Haemophilus_influenza_type_b_type { get; set; }
        [JsonProperty("Haemophilus Influenza Type B Date Given")] public string PCI_4B_Haemophilus_influenza_type_b_date_given { get; set; }
        [JsonProperty("Haemophilus Influenza Type B Administered By")] public string PCI_4B_Haemophilus_influenza_type_b_administered_by { get; set; }
        [JsonProperty("Pneumococcal Type")] public string PCI_4B_Pneumococcal_type { get; set; }
        [JsonProperty("Pneumococcal Date Given")] public string PCI_4B_Pneumococcal_date_given { get; set; }
        [JsonProperty("Pneumococcal Administered By")] public string PCI_4B_Pneumococcal_administered_by { get; set; }
        [JsonProperty("Polio Type")] public string PCI_4B_Polio_type { get; set; }
        [JsonProperty("Polio Date Given")] public string PCI_4B_Polio_date_given { get; set; }
        [JsonProperty("Polio Administered By")] public string PCI_4B_Polio_administered_by { get; set; }
        [JsonProperty("Rotavirus Type")] public string PCI_4B_Rotavirus_type { get; set; }
        [JsonProperty("Rotavirus Date Given")] public string PCI_4B_Rotavirus_date_given { get; set; }
        [JsonProperty("Rotavirus Administered By")] public string PCI_4B_Rotavirus_administered_by { get; set; }
        [JsonProperty("Measles, Mumps, & Rubella (Mmr, Mmrv) Type")] public string PCI_4B_Measles_type { get; set; }
        [JsonProperty("Measles, Mumps, & Rubella (Mmr, Mmrv) Date Given")] public string PCI_4B_Measles_date_given { get; set; }
        [JsonProperty("Measles, Mumps, & Rubella (Mmr, Mmrv) Administered By")] public string PCI_4B_Measles_administered_by { get; set; }
        [JsonProperty("Varicella (Chickenpox)(Var, Mmrv) Type")] public string PCI_4B_Varicella_type { get; set; }
        [JsonProperty("Varicella (Chickenpox)(Var, Mmrv) Date Given")] public string PCI_4B_Varicella_date_given { get; set; }
        [JsonProperty("Varicella (Chickenpox)(Var, Mmrv) Administered By")] public string PCI_4B_Varicella_administered_by { get; set; }
        [JsonProperty("Hepatitis A(Hepa, Hepa-Hepb) Type")] public string PCI_4B_Hepatitis_A_type { get; set; }
        [JsonProperty("Hepatitis A(Hepa, Hepa-Hepb) Date Given")] public string PCI_4B_Hepatitis_A_date_given { get; set; }
        [JsonProperty("Hepatitis A(Hepa, Hepa-Hepb) Administered By")] public string PCI_4B_Hepatitis_A_administered_by { get; set; }
        [JsonProperty("Meningococcal (Mcv4, Mpsv4) Type")] public string PCI_4B_Meningococcal_type { get; set; }
        [JsonProperty("Meningococcal (Mcv4, Mpsv4)  Date Given")] public string PCI_4B_Meningococcal_date_given { get; set; }
        [JsonProperty("Meningococcal (Mcv4, Mpsv4)  Administered By")] public string PCI_4B_Meningococcal_administered_by { get; set; }
        [JsonProperty("Human Papillomavirus (Hpv4, Hpv2) Type")] public string PCI_4B_Human_papillomavirus_type { get; set; }
        [JsonProperty("Human Papillomavirus (Hpv4, Hpv2)  Date Given")] public string PCI_4B_Human_papillomavirus_date_given { get; set; }
        [JsonProperty("Human Papillomavirus (Hpv4, Hpv2)  Administered By")] public string PCI_4B_Human_papillomavirus_administered_by { get; set; }
        [JsonProperty("Zoster (Shingles)  Type")] public string PCI_4B_Zoster_type { get; set; }
        [JsonProperty("Zoster (Shingles)  Date Given")] public string PCI_4B_Zoster_date_given { get; set; }
        [JsonProperty("Zoster (Shingles) Administered By")] public string PCI_4B_Zoster_administered_by { get; set; }
        [JsonProperty("Influenza (Yearly) (Tiv, Laiv)  Type")] public string PCI_4B_Influenza_type { get; set; }
        [JsonProperty("Influenza (Yearly) (Tiv, Laiv)  Date Given")] public string PCI_4B_Influenza_date_given { get; set; }
        [JsonProperty("Influenza (Yearly) (Tiv, Laiv) Administered By")] public string PCI_4B_Influenza_administered_by { get; set; }
        [JsonProperty("Bacillus Calmette–Guérin (Bcg) Vaccine  Type")] public string PCI_4B_Bacillus_Calmette_type { get; set; }
        [JsonProperty("Bacillus Calmette–Guérin (Bcg) Vaccine  Date Given")] public string PCI_4B_Bacillus_Calmette_date_given { get; set; }
        [JsonProperty("Bacillus Calmette–Guérin (Bcg) Vaccine Administered By")] public string PCI_4B_Bacillus_Calmette_administered_by { get; set; }
        [JsonProperty("Asthma (Wheezing) Yes/No")] public string PCI_4C_Asthma_wheezing_YesNo { get; set; }
        [JsonProperty("Asthma (Wheezing) Onset Age")] public string PCI_4C_Asthma_wheezing_OnsetAge { get; set; }
        [JsonProperty("Asthma (Wheezing) Severity")] public string PCI_4C_Asthma_wheezing_Severity { get; set; }
        [JsonProperty("Asthma (Wheezing) Comments")] public string PCI_4C_Asthma_wheezing_Comments { get; set; }
        [JsonProperty("Other Breathing Problems Yes/No")] public string PCI_4C_Other_breathing_problems_YesNo { get; set; }
        [JsonProperty("Other Breathing Problems Onset Age")] public string PCI_4C_Other_breathing_problems_OnsetAge { get; set; }
        [JsonProperty("Other Breathing Problems Severity")] public string PCI_4C_Other_breathing_problems_Severity { get; set; }
        [JsonProperty("Other Breathing Problems Comments")] public string PCI_4C_Other_breathing_problems_Comments { get; set; }
        [JsonProperty("Sinus Trouble Yes/No")] public string PCI_4C_Sinus_trouble_YesNo { get; set; }
        [JsonProperty("Sinus Trouble Onset Age")] public string PCI_4C_Sinus_trouble_OnsetAge { get; set; }
        [JsonProperty("Sinus Trouble Severity")] public string PCI_4C_Sinus_trouble_Severity { get; set; }
        [JsonProperty("Sinus Trouble Comments")] public string PCI_4C_Sinus_trouble_Comments { get; set; }
        [JsonProperty("Hay Fever (Runny, Stuffy, Itchy Nose; Sneezing) Yes/No")] public string PCI_4C_Hay_fever_YesNo { get; set; }
        [JsonProperty("Hay Fever (Runny, Stuffy, Itchy Nose; Sneezing) Onset Age")] public string PCI_4C_Hay_fever_OnsetAge { get; set; }
        [JsonProperty("Hay Fever (Runny, Stuffy, Itchy Nose; Sneezing) Severity")] public string PCI_4C_Hay_fever_Severity { get; set; }
        [JsonProperty("Hay Fever (Runny, Stuffy, Itchy Nose; Sneezing) Comments")] public string PCI_4C_Hay_fever_Comments { get; set; }
        [JsonProperty("Hives Or Swelling Yes/No")] public string PCI_4C_Hives_YesNo { get; set; }
        [JsonProperty("Hives Or Swelling Onset Age")] public string PCI_4C_Hives_OnsetAge { get; set; }
        [JsonProperty("Hives Or Swelling Severity")] public string PCI_4C_Hives_Severity { get; set; }
        [JsonProperty("Hives Or Swelling Comments")] public string PCI_4C_Hives_Comments { get; set; }
        [JsonProperty("Eczema Or Other Rashes Yes/No")] public string PCI_4C_Eczema_YesNo { get; set; }
        [JsonProperty("Eczema Or Other Rashes Onset Age")] public string PCI_4C_Eczema_OnsetAge { get; set; }
        [JsonProperty("Eczema Or Other Rashes Severity")] public string PCI_4C_Eczema_Severity { get; set; }
        [JsonProperty("Eczema Or Other Rashes Comments")] public string PCI_4C_Eczema_Comments { get; set; }
        [JsonProperty("Frequent Infections Yes/No")] public string PCI_4C_Frequent_infections_YesNo { get; set; }
        [JsonProperty("Frequent Infections Onset Age")] public string PCI_4C_Frequent_infections_OnsetAge { get; set; }
        [JsonProperty("Frequent Infections Severity")] public string PCI_4C_Frequent_infections_Severity { get; set; }
        [JsonProperty("Frequent Infections Comments")] public string PCI_4C_Frequent_infections_Comments { get; set; }
        [JsonProperty("Food Reactions Yes/No")] public string PCI_4C_Food_reactions_YesNo { get; set; }
        [JsonProperty("Food Reactions Onset Age")] public string PCI_4C_Food_reactions_OnsetAge { get; set; }
        [JsonProperty("Food Reactions Severity")] public string PCI_4C_Food_reactions_Severity { get; set; }
        [JsonProperty("Food Reactions Comments")] public string PCI_4C_Food_reactions_Comments { get; set; }
        [JsonProperty("Drug Reactions Yes/No")] public string PCI_4C_Drug_reactions_YesNo { get; set; }
        [JsonProperty("Drug Reactions Onset Age")] public string PCI_4C_Drug_reactions_OnsetAge { get; set; }
        [JsonProperty("Drug Reactions Severity")] public string PCI_4C_Drug_reactions_Severity { get; set; }
        [JsonProperty("Drug Reactions Comments")] public string PCI_4C_Drug_reactions_Comments { get; set; }
        [JsonProperty("Other Drug Reactions Yes/No")] public string PCI_4C_Others_YesNo { get; set; }
        [JsonProperty("Drug Reactions Name")] public string PCI_4C_Others_Name { get; set; }
        [JsonProperty("Other Drug Onset Age")] public string PCI_4C_Others_OnsetAge { get; set; }
        [JsonProperty("Other Drug Reactions Severity")] public string PCI_4C_Others_Severity { get; set; }
        [JsonProperty("Other Drug Reactions Comments")] public string PCI_4C_Others_Comments { get; set; }
        [JsonProperty("Viral Infection 1 Yes/No")] public string PCI_4D_1_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 1 Name")] public string PCI_4D_1_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 1 Year")] public string PCI_4D_1_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 1 Severity")] public string PCI_4D_1_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 1 Comments")] public string PCI_4D_1_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 2 Yes/No")] public string PCI_4D_2_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 2 Name")] public string PCI_4D_2_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 2 Year")] public string PCI_4D_2_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 2 Severity")] public string PCI_4D_2_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 2 Comments")] public string PCI_4D_2_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 3 Yes/No")] public string PCI_4D_3_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 3 Name")] public string PCI_4D_3_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 3 Year")] public string PCI_4D_3_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 3 Severity")] public string PCI_4D_3_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 3 Comments")] public string PCI_4D_3_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 4 Yes/No")] public string PCI_4D_4_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 4 Name")] public string PCI_4D_4_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 4 Year")] public string PCI_4D_4_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 4 Severity")] public string PCI_4D_4_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 4 Comments")] public string PCI_4D_4_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 5 Yes/No")] public string PCI_4D_5_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 5 Name")] public string PCI_4D_5_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 5 Year")] public string PCI_4D_5_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 5 Severity")] public string PCI_4D_5_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 5 Comments")] public string PCI_4D_5_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 6 Yes/No")] public string PCI_4D_6_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 6 Name")] public string PCI_4D_6_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 6 Year")] public string PCI_4D_6_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 6 Severity")] public string PCI_4D_6_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 6 Comments")] public string PCI_4D_6_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 7 Yes/No")] public string PCI_4D_7_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 7 Name")] public string PCI_4D_7_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 7 Year")] public string PCI_4D_7_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 7 Severity")] public string PCI_4D_7_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 7 Comments")] public string PCI_4D_7_Viral_Infection_Comments { get; set; }
        [JsonProperty("Viral Infection 8 Yes/No")] public string PCI_4D_8_Viral_Infection_YesNo { get; set; }
        [JsonProperty("Viral Infection 8 Name")] public string PCI_4D_8_Viral_Infection_Name { get; set; }
        [JsonProperty("Viral Infection 8 Year")] public string PCI_4D_8_Viral_Infection_year { get; set; }
        [JsonProperty("Viral Infection 8 Severity")] public string PCI_4D_8_Viral_Infection_Severity { get; set; }
        [JsonProperty("Viral Infection 8 Comments")] public string PCI_4D_8_Viral_Infection_Comments { get; set; }
        [JsonProperty("Case Present To A Hospital In The 14 Days Covid-19 Symptoms")] public string ES_5A_present_to_hospital_in_14_days_COVID_19_symptoms { get; set; }
        [JsonProperty("Case Present To A Hospital In The 14 Days Covid-19 Symptoms Date")] public string ES_5A_present_to_hospital_in_14_days_COVID_19_symptoms_date { get; set; }
        [JsonProperty("Case Present To A Hospital In The 14 Days Covid-19 Symptoms Detail Of Illness")] public string ES_5A_present_to_hospital_in_14_days_COVID_19_symptoms_detail_of_illness { get; set; }
        [JsonProperty("Case Present To A Hospital In The 14 Days Other Symptoms")] public string ES_5A_present_to_hospital_in_14_days_other_symptoms { get; set; }
        [JsonProperty("Case Present To A Hospital In The 14 Days Other Symptoms Date")] public string ES_5A_present_to_hospital_in_14_days_other_symptoms_date { get; set; }
        [JsonProperty("Case Present To A Hospital In The 14 Days Other Symptoms Detail Of Illness")] public string ES_5A_present_to_hospital_in_14_days_other_symptoms_detail_of_illness { get; set; }
        [JsonProperty("Case Present To A Other Healthcare Facility In The 14 Days Covid-19 Symptoms")] public string ES_5A_present_to_other_healthcare_facility_in_14_days_COVID_19_symptoms { get; set; }
        [JsonProperty("Case Present To A Other Healthcare Facility  In The 14 Days Covid-19 Symptoms Date")] public string ES_5A_present_to_other_healthcare_facility_in_14_days_COVID_19_symptoms_date { get; set; }
        [JsonProperty("Case Present To A Other Healthcare Facility  In The 14 Days Covid-19 Symptoms Detail Of Illness")] public string ES_5A_present_to_other_healthcare_facility_in_14_days_COVID_19_symptoms_detail_of_illness { get; set; }
        [JsonProperty("Work In Any Of The High-Risk Occupations")] public string PC_6A_work_in_highrisk_occupations { get; set; }
        [JsonProperty("Work In Any Of The High-Risk Occupations Others")] public string PC_6A_work_in_highrisk_occupations_others { get; set; }
        [JsonProperty("Work In Any Of The High-Risk Occupations Last Date")] public string PC_6A_work_in_highrisk_occupations_Last_date { get; set; }
        [JsonProperty("Infection Likely Acquired In The Workplace")] public string PC_6A_infection_likely_acquired_in_workplace { get; set; }
        [JsonProperty("Description Of Occupation")] public string PC_6A_Description_of_occupation { get; set; }
        [JsonProperty("Employer/Facility Details")] public string PC_6A_Employer_facility_details { get; set; }
        [JsonProperty("Employer/Facility Address")] public string PC_6A_Employer_facility_address { get; set; }
        [JsonProperty("Employer/Facility Emirates")] public string PC_6A_Employer_facility_emirates { get; set; }
        [JsonProperty("Employer/Facility Email")] public string PC_6A_Employer_facility_email { get; set; }
        [JsonProperty("Employer/Facility Phone No")] public string PC_6A_Employer_facility_phone { get; set; }
        [JsonProperty("Employer/Facility Contact Name")] public string PC_6A_Employer_facility_contact_name { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Doctor Room/Clinic/Emergency Department")] public string PC_6B_infectious_visited_venues_doctor { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Schools/University/Tafe")] public string PC_6B_infectious_visited_venues_Schools { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Aged-Care Facility/Assisted Living")] public string PC_6B_infectious_visited_venues_Aged_care_facility { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Transport (Plane/Train/Bus/Ship)")] public string PC_6B_infectious_visited_venues_Transport { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Concert Venue/Theatre/Conference")] public string PC_6B_infectious_visited_venues_Concert { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Office/Workplace")] public string PC_6B_infectious_visited_venues_Office { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Other Public Venue/Gathering")] public string PC_6B_infectious_visited_venues_other { get; set; }
        [JsonProperty("Infectious,  Visited  Venues Or Locations Other Public Venue/Gathering Details")] public string PC_6B_infectious_visited_venues_other_detail { get; set; }
        [JsonProperty("Infectious,  Close Contact")] public string PC_6C_infectious_close_contact { get; set; }
        [JsonProperty("Infectious,  Close Contact  Details")] public string PC_6C_infectious_close_contact_details { get; set; }
        [JsonProperty("Sample Type")] public string LD_7_sample_type { get; set; }
        [JsonProperty("Sample Type Other")] public string LD_7_sample_type_other { get; set; }
        [JsonProperty("Sample Received Date")] public string LD_7_sample_received_date { get; set; }
        [JsonProperty("Storage")] public string LD_7_storage { get; set; }
        [JsonProperty("Sample Volume")] public string LD_7_sample_volume { get; set; }
        [JsonProperty("Project Code")] public string LD_7_project_code { get; set; }
        [JsonProperty("Test Code")] public string LD_7_test_code { get; set; }
        [JsonProperty("Comments")] public string LD_7_comments { get; set; }
        [JsonProperty("Blood sample")] public string LD_7_blood { get; set; }
        [JsonProperty("Saliva sample")] public string LD_7_saliva { get; set; }
        [JsonProperty("Tissue sample")] public string LD_7_tissue { get; set; }
        [JsonProperty("sample other text")] public string LD_7_sample_type_other_txt { get; set; }

        // addidional fields 30/06/2020
        [JsonProperty("Antibiotics Past 3 Months")] public string MQ_Antibiotics { get; set; }
        [JsonProperty("Probiotics Before")] public string MQ_Probiotics { get; set; }
        [JsonProperty("Fibre Intake Fruit")] public string MQ_FibreIntake_Fruit { get; set; }
        [JsonProperty("Fibre Intake Vegetables")] public string MQ_FibreIntake_Vegetables { get; set; }
        [JsonProperty("Fibre Intake Wholemeal Breads")] public string MQ_FibreIntake_WholemealBreads { get; set; }
        [JsonProperty("Fibre Intake Nuts and Seeds")] public string MQ_FibreIntake_NutsSeeds { get; set; }
        [JsonProperty("Fibre Intake Legumes, Beans, Peas and Lentils")] public string MQ_FibreIntake_LegumesBeansPeasLentils { get; set; }
        [JsonProperty("Exercise")] public string MQ_Exercise { get; set; }
        [JsonProperty("Long Standing Suffereing")] public string MQ_LongStandingSuffering { get; set; }
        [JsonProperty("Long Standing Suffereing Specify")] public string MQ_LongStandingSuffering_Specify { get; set; }
        //
        // additional fields - instead of radio/ make check box 09/07/2020
        [JsonProperty("Long Standing Suffereing Hypertension")] public string MQ_LongStandingSuffering_Hypertension { get; set; }
        [JsonProperty("Long Standing Suffereing Cardiovascular disease")] public string MQ_LongStandingSuffering_CVD { get; set; }
        [JsonProperty("Long Standing Suffereing COPD")] public string MQ_LongStandingSuffering_COPD { get; set; }
        [JsonProperty("Long Standing Suffereing Asthma")] public string MQ_LongStandingSuffering_Asthma { get; set; }
        [JsonProperty("Long Standing Suffereing Others")] public string MQ_LongStandingSuffering_Others { get; set; }
        [JsonProperty("Long Standing Suffereing None")] public string MQ_LongStandingSuffering_None { get; set; }


        // 16/07/2020
        [JsonProperty("Immunization record")] public string PCI_4B_Immunization_record { get; set; }
        [JsonProperty("Allergies")] public string PCI_4C_Allergies { get; set; }
        [JsonProperty("Previous viral infections")] public string PCI_4D_Previous_viral_infections { get; set; }
    
        // 26/07/2020
        public string Severity { get; set; }
        public string Age { get; set; }

        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
}
