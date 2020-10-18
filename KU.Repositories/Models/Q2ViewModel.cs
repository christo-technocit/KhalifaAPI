using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace KU.Repositories.Models
{
    public class QuestionnaireWrap2
    {
        public QuestionnaireWrap2()
        {
            result = new List<Q2ViewModel>();

        }
        public IEnumerable<Q2ViewModel> result { get; set; }

    }
    public class Q2ViewModel
    {
        [Key]
        public string SavedFormID { get; set; }
        [JsonProperty("Depository ID")]  public string Depository_ID { get; set; }
        [JsonProperty("Sample")] public string Sample { get; set; }
        [JsonProperty("Collected By")] public string Collected_by { get; set; }
        [JsonProperty("Collected Date")] public string Collected_date { get; set; }
        [JsonProperty("Nrc Id")] public string nrc_id { get; set; }
        [JsonProperty("Dob")] public string dob { get; set; }
        [JsonProperty("Gender")] public string Gender { get; set; }
        [JsonProperty("Country")] public string country { get; set; }
        [JsonProperty("Maritalstatus")] public string MaritalStatus { get; set; }
        [JsonProperty("Placeofbirth")] public string PlaceOfBirth { get; set; }
        [JsonProperty("Employment Status")] public string employment_status { get; set; }
        [JsonProperty("Employment Status Others")] public string employment_status_others { get; set; }
        [JsonProperty("Employment Others Text")] public string employment_others_text { get; set; }
        [JsonProperty("Edulevel")] public string eduLevel { get; set; }
        [JsonProperty("Ethnicity Mixed Specify Text")] public string ethnicity_mixed_specify_text { get; set; }
        [JsonProperty("Ethnicity")] public string ethnicity { get; set; }
        [JsonProperty("Ethnicity Others Text")] public string ethnicity_others_text { get; set; }
        [JsonProperty("Inpatient Type")] public string inpatient_type { get; set; }
        [JsonProperty("Admission Status")] public string Admission_Status { get; set; }
        [JsonProperty("Method Adm")] public string method_adm { get; set; }
        [JsonProperty("Method Adm Others Text")] public string method_adm_others_text { get; set; }
        [JsonProperty("Participant Comments")] public string participant_comments { get; set; }
        [JsonProperty("Bodyweight")] public string BodyWeight { get; set; }
        [JsonProperty("Height")] public string Height { get; set; }
        [JsonProperty("Bodymass")] public string BodyMass { get; set; }
        [JsonProperty("Waist")] public string Waist { get; set; }
        [JsonProperty("Bloodpressuresystolic")] public string BloodPressureSystolic { get; set; }
        [JsonProperty("Bloodpressurediastolic")] public string BloodPressureDiastolic { get; set; }
        [JsonProperty("Walk")] public string Walk { get; set; }
        [JsonProperty("Walk Others Specify")] public string Walk_others_Specify { get; set; }
        [JsonProperty("Walk Ifyes")] public string Walk_IfYes { get; set; }
        [JsonProperty("Healthy")] public string Healthy { get; set; }
        [JsonProperty("Specifyhealthy")] public string SpecifyHealthy { get; set; }
        [JsonProperty("Smoking Status")] public string smoking_status { get; set; }
        [JsonProperty("Medical Condition")] public string medical_condition { get; set; }
        [JsonProperty("Medical Con")] public string medical_con { get; set; }
        [JsonProperty("Asthma Pre")] public string asthma_pre { get; set; }
        [JsonProperty("Asthma Post")] public string asthma_post { get; set; }
        [JsonProperty("Diabetes Circle")] public string diabetes_circle { get; set; }
        [JsonProperty("Diabetes Circle Type")] public string diabetes_circle_type { get; set; }
        [JsonProperty("Diabetes Pre")] public string diabetes_pre { get; set; }
        [JsonProperty("Diabetes Post")] public string diabetes_post { get; set; }
        [JsonProperty("Medical Heart")] public string medical_heart { get; set; }
        [JsonProperty("Medical Heart Pre")] public string medical_heart_pre { get; set; }
        [JsonProperty("Medical Heart Post")] public string medical_heart_post { get; set; }
        [JsonProperty("Medical High Pressure")] public string medical_high_pressure { get; set; }
        [JsonProperty("Medical High Pressure Pre")] public string medical_high_pressure_pre { get; set; }
        [JsonProperty("Medical High Pressure Post")] public string medical_high_pressure_post { get; set; }
        [JsonProperty("Medical Anemia")] public string medical_anemia { get; set; }
        [JsonProperty("Medical Anemia Pre")] public string medical_anemia_pre { get; set; }
        [JsonProperty("Medical Anemia Post")] public string medical_anemia_post { get; set; }
        [JsonProperty("Medical Ulcer")] public string medical_ulcer { get; set; }
        [JsonProperty("Medical Ulcer Pre")] public string medical_ulcer_pre { get; set; }
        [JsonProperty("Medical Ulcer Post")] public string medical_ulcer_post { get; set; }
        [JsonProperty("Medical Cancer")] public string medical_cancer { get; set; }
        [JsonProperty("Medical Cancer Pre")] public string medical_cancer_pre { get; set; }
        [JsonProperty("Medical Cancer Post")] public string medical_cancer_post { get; set; }
        [JsonProperty("Medical Kidney")] public string medical_kidney { get; set; }
        [JsonProperty("Medical Kidney Pre")] public string medical_kidney_pre { get; set; }
        [JsonProperty("Medical Kidney Post")] public string medical_kidney_post { get; set; }
        [JsonProperty("Medical Hepatitiscircle")] public string medical_HepatitisCircle { get; set; }
        [JsonProperty("Medical Hepatitiscircletype")] public string medical_HepatitisCircleType { get; set; }
        [JsonProperty("Medical Hepatitiscircle Pre")] public string medical_HepatitisCircle_pre { get; set; }
        [JsonProperty("Medical Hepatitiscircle Post")] public string medical_HepatitisCircle_post { get; set; }
        [JsonProperty("Medical Liver")] public string medical_liver { get; set; }
        [JsonProperty("Medical Liver Pre")] public string medical_liver_pre { get; set; }
        [JsonProperty("Medical Liver Post")] public string medical_liver_post { get; set; }
        [JsonProperty("Medical Seizures")] public string medical_Seizures { get; set; }
        [JsonProperty("Medical Seizures Pre")] public string medical_Seizures_pre { get; set; }
        [JsonProperty("Medical Seizures Post")] public string medical_Seizures_post { get; set; }
        [JsonProperty("Medical Gastro")] public string medical_gastro { get; set; }
        [JsonProperty("Medical Gastro Pre")] public string medical_gastro_pre { get; set; }
        [JsonProperty("Medical Gastro Post")] public string medical_gastro_post { get; set; }
        [JsonProperty("Medical Sinusitis")] public string medical_Sinusitis { get; set; }
        [JsonProperty("Medical Sinusitis Pre")] public string medical_Sinusitis_pre { get; set; }
        [JsonProperty("Medical Sinusitis Pre Post")] public string medical_Sinusitis_pre_post { get; set; }
        [JsonProperty("Medical Cough")] public string medical_cough { get; set; }
        [JsonProperty("Medical Cough Pre")] public string medical_cough_pre { get; set; }
        [JsonProperty("Medical Cough Post")] public string medical_cough_post { get; set; }
        [JsonProperty("Medical Skin")] public string medical_skin { get; set; }
        [JsonProperty("Medical Skin Pre")] public string medical_skin_pre { get; set; }
        [JsonProperty("Medical Skin Post")] public string medical_skin_post { get; set; }
        [JsonProperty("Medical Arthritis")] public string medical_Arthritis { get; set; }
        [JsonProperty("Medical Arthritis Pre")] public string medical_Arthritis_pre { get; set; }
        [JsonProperty("Medical Arthritis Post")] public string medical_Arthritis_post { get; set; }
        [JsonProperty("Medical Hallucination")] public string medical_hallucination { get; set; }
        [JsonProperty("Medical Hallucination Pre")] public string medical_hallucination_pre { get; set; }
        [JsonProperty("Medical Hallucination Post")] public string medical_hallucination_post { get; set; }
        [JsonProperty("Medical Depression")] public string medical_Depression { get; set; }
        [JsonProperty("Medical Depression Pre")] public string medical_Depression_pre { get; set; }
        [JsonProperty("Medical Depression Post")] public string medical_Depression_post { get; set; }
        [JsonProperty("Medical Hiv")] public string medical_hiv { get; set; }
        [JsonProperty("Medical Hiv Pre")] public string medical_hiv_pre { get; set; }
        [JsonProperty("Medical Hiv Post")] public string medical_hiv_post { get; set; }
        [JsonProperty("Medical Others")] public string medical_others { get; set; }
        [JsonProperty("Medical Others Specify")] public string medical_others_specify { get; set; }
        [JsonProperty("Medical Others Pre")] public string medical_others_pre { get; set; }
        [JsonProperty("Medical Others Post")] public string medical_others_post { get; set; }
        [JsonProperty("Allergies")] public string allergies { get; set; }
        [JsonProperty("All Specify")] public string all_specify { get; set; }
        [JsonProperty("Intolerance")] public string intolerance { get; set; }
        [JsonProperty("Intolerance Specify")] public string intolerance_specify { get; set; }
        [JsonProperty("Dependence Weight")] public string dependence_weight { get; set; }
        [JsonProperty("Reason Weight")] public string reason_weight { get; set; }
        [JsonProperty("Surgery")] public string surgery { get; set; }
        [JsonProperty("Ind Specify")] public string ind_specify { get; set; }
        [JsonProperty("Where Specify")] public string where_specify { get; set; }
        [JsonProperty("Reasaon Specify")] public string Reasaon_specify { get; set; }
        [JsonProperty("Medical Pain")] public string medical_pain { get; set; }
        [JsonProperty("When Specify")] public string when_specify { get; set; }
        [JsonProperty("Source Specify")] public string source_specify { get; set; }
        [JsonProperty("Medic Specify")] public string medic_specify { get; set; }
        [JsonProperty("Dur Specify")] public string dur_specify { get; set; }
        [JsonProperty("Medic Treatment")] public string medic_treatment { get; set; }
        [JsonProperty("Medic Treat Specify")] public string medic_treat_specify { get; set; }
        [JsonProperty("Substance")] public string substance { get; set; }
        [JsonProperty("Medhadone Used")] public string medhadone_used { get; set; }
        [JsonProperty("Methadone Symoron")] public string methadone_symoron { get; set; }
        [JsonProperty("Methadone Dolophine")] public string methadone_dolophine { get; set; }
        [JsonProperty("Methadone Amidone")] public string methadone_amidone { get; set; }
        [JsonProperty("Methadone Physeptone")] public string methadone_physeptone { get; set; }
        [JsonProperty("Methadone Heptadon")] public string methadone_heptadon { get; set; }
        [JsonProperty("Methadone Methadose")] public string methadone_methadose { get; set; }
        [JsonProperty("Methadone Disket")] public string methadone_disket { get; set; }
        [JsonProperty("Methadone Symoron First")] public string methadone_symoron_first { get; set; }
        [JsonProperty("Methadone Dolophine First")] public string methadone_dolophine_first { get; set; }
        [JsonProperty("Methadone Amidone First")] public string methadone_amidone_first { get; set; }
        [JsonProperty("Methadone Physeptone First")] public string methadone_physeptone_first { get; set; }
        [JsonProperty("Methadone Heptadon First")] public string methadone_heptadon_first { get; set; }
        [JsonProperty("Methadone Methadose First")] public string methadone_methadose_first { get; set; }
        [JsonProperty("Methadone Disket First")] public string methadone_disket_first { get; set; }
        [JsonProperty("Methadone Symoron Total")] public string methadone_symoron_total { get; set; }
        [JsonProperty("Methadone Dolophine Total")] public string methadone_dolophine_total { get; set; }
        [JsonProperty("Methadone Amidone Total")] public string methadone_amidone_total { get; set; }
        [JsonProperty("Methadone Physeptone Total")] public string methadone_physeptone_total { get; set; }
        [JsonProperty("Methadone Heptadon Total")] public string methadone_heptadon_total { get; set; }
        [JsonProperty("Methadone Methadose Total")] public string methadone_methadose_total { get; set; }
        [JsonProperty("Methadone Disket Total")] public string methadone_disket_total { get; set; }
        [JsonProperty("Methadone Symoron Amn")] public string methadone_symoron_amn { get; set; }
        [JsonProperty("Methadone Dolophine Amn")] public string methadone_dolophine_amn { get; set; }
        [JsonProperty("Methadone Amidone Amn")] public string methadone_amidone_amn { get; set; }
        [JsonProperty("Methadone Physeptone Amn")] public string methadone_physeptone_amn { get; set; }
        [JsonProperty("Methadone Heptadon Amn")] public string methadone_heptadon_amn { get; set; }
        [JsonProperty("Methadone Methadose Amn")] public string methadone_methadose_amn { get; set; }
        [JsonProperty("Methadone Disket Amn")] public string methadone_disket_amn { get; set; }
        [JsonProperty("Methadone Symoron Freq")] public string methadone_symoron_freq { get; set; }
        [JsonProperty("Methadone Dolophine Freq")] public string methadone_dolophine_freq { get; set; }
        [JsonProperty("Methadone Amidone Freq")] public string methadone_amidone_freq { get; set; }
        [JsonProperty("Methadone Physeptone Freq")] public string methadone_physeptone_freq { get; set; }
        [JsonProperty("Methadone Heptadon Freq")] public string methadone_heptadon_freq { get; set; }
        [JsonProperty("Methadone Methadose Freq")] public string methadone_methadose_freq { get; set; }
        [JsonProperty("Methadone Disket Freq")] public string methadone_disket_freq { get; set; }
        [JsonProperty("Methadone Symoron Admin")] public string methadone_symoron_admin { get; set; }
        [JsonProperty("Methadone Dolophine Admin")] public string methadone_dolophine_admin { get; set; }
        [JsonProperty("Methadone Amidone Admin")] public string methadone_amidone_admin { get; set; }
        [JsonProperty("Methadone Physeptone Admin")] public string methadone_physeptone_admin { get; set; }
        [JsonProperty("Methadone Heptadon Admin")] public string methadone_heptadon_admin { get; set; }
        [JsonProperty("Methadone Methadose Admin")] public string methadone_methadose_admin { get; set; }
        [JsonProperty("Methadone Disket Admin")] public string methadone_disket_admin { get; set; }
        [JsonProperty("Buprenorphine Used")] public string Buprenorphine_used { get; set; }
        [JsonProperty("Prescribed Subutex")] public string prescribed_subutex { get; set; }
        [JsonProperty("Prescribed Suboxone")] public string prescribed_suboxone { get; set; }
        [JsonProperty("Prescribed Buprenex")] public string prescribed_buprenex { get; set; }
        [JsonProperty("Prescribed Subutex First")] public string prescribed_subutex_first { get; set; }
        [JsonProperty("Prescribed Suboxone First")] public string prescribed_suboxone_first { get; set; }
        [JsonProperty("Prescribed Buprenex First")] public string prescribed_buprenex_first { get; set; }
        [JsonProperty("Prescribed Subutex Total")] public string prescribed_subutex_total { get; set; }
        [JsonProperty("Prescribed Suboxone Total")] public string prescribed_suboxone_total { get; set; }
        [JsonProperty("Prescribed Buprenex Total")] public string prescribed_buprenex_total { get; set; }
        [JsonProperty("Prescribed Subutex Amn")] public string prescribed_subutex_amn { get; set; }
        [JsonProperty("Prescribed Suboxone Amn")] public string prescribed_suboxone_amn { get; set; }
        [JsonProperty("Prescribed Buprenex Amn")] public string prescribed_buprenex_amn { get; set; }
        [JsonProperty("Prescribed Subutex Freq")] public string prescribed_subutex_freq { get; set; }
        [JsonProperty("Prescribed Suboxone Freq")] public string prescribed_suboxone_freq { get; set; }
        [JsonProperty("Prescribed Buprenex Freq")] public string prescribed_buprenex_freq { get; set; }
        [JsonProperty("Prescribed Subutex Admin")] public string prescribed_subutex_admin { get; set; }
        [JsonProperty("Prescribed Suboxone Admin")] public string prescribed_suboxone_admin { get; set; }
        [JsonProperty("Prescribed Buprenex Admin")] public string prescribed_buprenex_admin { get; set; }
        [JsonProperty("Opiates Used")] public string Opiates_used { get; set; }
        [JsonProperty("Opiates Heroin")] public string opiates_heroin { get; set; }
        [JsonProperty("Opiates Heroin First")] public string opiates_heroin_first { get; set; }
        [JsonProperty("Opiates Heroin Total")] public string opiates_heroin_total { get; set; }
        [JsonProperty("Opiates Heroin Amn")] public string opiates_heroin_amn { get; set; }
        [JsonProperty("Opiates Heroin Freq")] public string opiates_heroin_freq { get; set; }
        [JsonProperty("Opiates Heroin Admin")] public string opiates_heroin_admin { get; set; }
        [JsonProperty("Opiates Morphine")] public string opiates_morphine { get; set; }
        [JsonProperty("Opiates Morphine First")] public string opiates_morphine_first { get; set; }
        [JsonProperty("Opiates Morphine Total")] public string opiates_morphine_total { get; set; }
        [JsonProperty("Opiates Morphine Amn")] public string opiates_morphine_amn { get; set; }
        [JsonProperty("Opiates Morphine Freq")] public string opiates_morphine_freq { get; set; }
        [JsonProperty("Opiates Morphine Admin")] public string opiates_morphine_admin { get; set; }
        [JsonProperty("Opiates Codine")] public string opiates_codine { get; set; }
        [JsonProperty("Opiates Codine First")] public string opiates_codine_first { get; set; }
        [JsonProperty("Opiates Codine Total")] public string opiates_codine_total { get; set; }
        [JsonProperty("Opiates Codine Amn")] public string opiates_codine_amn { get; set; }
        [JsonProperty("Opiates Codine Freq")] public string opiates_codine_freq { get; set; }
        [JsonProperty("Opiates Codine Admin")] public string opiates_codine_admin { get; set; }
        [JsonProperty("Opiates Oxycodon")] public string opiates_oxycodon { get; set; }
        [JsonProperty("Opiates Oxycodon First")] public string opiates_oxycodon_first { get; set; }
        [JsonProperty("Opiates Oxycodon Total")] public string opiates_oxycodon_total { get; set; }
        [JsonProperty("Opiates Oxycodon Amn")] public string opiates_oxycodon_amn { get; set; }
        [JsonProperty("Opiates Oxycodon Freq")] public string opiates_oxycodon_freq { get; set; }
        [JsonProperty("Opiates Oxycodon Admin")] public string opiates_oxycodon_admin { get; set; }
        [JsonProperty("Opiates Oxymorphon")] public string opiates_oxymorphon { get; set; }
        [JsonProperty("Opiates Oxymorphon First")] public string opiates_oxymorphon_first { get; set; }
        [JsonProperty("Opiates Oxymorphon Total")] public string opiates_oxymorphon_total { get; set; }
        [JsonProperty("Opiates Oxymorphon Amn")] public string opiates_oxymorphon_amn { get; set; }
        [JsonProperty("Opiates Oxymorphon Freq")] public string opiates_oxymorphon_freq { get; set; }
        [JsonProperty("Opiates Oxymorphon Admin")] public string opiates_oxymorphon_admin { get; set; }
        [JsonProperty("Opiates Hydrocodon")] public string opiates_hydrocodon { get; set; }
        [JsonProperty("Opiates Hydrocodon First")] public string opiates_hydrocodon_first { get; set; }
        [JsonProperty("Opiates Hydrocodon Total")] public string opiates_hydrocodon_total { get; set; }
        [JsonProperty("Opiates Hydrocodon Amn")] public string opiates_hydrocodon_amn { get; set; }
        [JsonProperty("Opiates Hydrocodon Freq")] public string opiates_hydrocodon_freq { get; set; }
        [JsonProperty("Opiates Hydrocodon Admin")] public string opiates_hydrocodon_admin { get; set; }
        [JsonProperty("Opiates Hydromorphon")] public string opiates_hydromorphon { get; set; }
        [JsonProperty("Opiates Hydromorphon First")] public string opiates_hydromorphon_first { get; set; }
        [JsonProperty("Opiates Hydromorphon Total")] public string opiates_hydromorphon_total { get; set; }
        [JsonProperty("Opiates Hydromorphon Amn")] public string opiates_hydromorphon_amn { get; set; }
        [JsonProperty("Opiates Hydromorphon Freq")] public string opiates_hydromorphon_freq { get; set; }
        [JsonProperty("Opiates Hydromorphon Admin")] public string opiates_hydromorphon_admin { get; set; }
        [JsonProperty("Opiates Tramadol")] public string opiates_tramadol { get; set; }
        [JsonProperty("Opiates Tramadol First")] public string opiates_tramadol_first { get; set; }
        [JsonProperty("Opiates Tramadol Total")] public string opiates_tramadol_total { get; set; }
        [JsonProperty("Opiates Tramadol Amn")] public string opiates_tramadol_amn { get; set; }
        [JsonProperty("Opiates Tramadol Freq")] public string opiates_tramadol_freq { get; set; }
        [JsonProperty("Opiates Tramadol Admin")] public string opiates_tramadol_admin { get; set; }
        [JsonProperty("Tranquilizers Used")] public string tranquilizers_used { get; set; }
        [JsonProperty("Tranquilizers Valium")] public string tranquilizers_valium { get; set; }
        [JsonProperty("Tranquilizers Valium First")] public string tranquilizers_valium_first { get; set; }
        [JsonProperty("Tranquilizers Valium Total")] public string tranquilizers_valium_total { get; set; }
        [JsonProperty("Tranquilizers Valium Amn")] public string tranquilizers_valium_amn { get; set; }
        [JsonProperty("Tranquilizers Valium Freq")] public string tranquilizers_valium_freq { get; set; }
        [JsonProperty("Tranquilizers Valium Admin")] public string tranquilizers_valium_admin { get; set; }
        [JsonProperty("Tranquilizers Librium")] public string tranquilizers_librium { get; set; }
        [JsonProperty("Tranquilizers Librium First")] public string tranquilizers_librium_first { get; set; }
        [JsonProperty("Tranquilizers Librium Total")] public string tranquilizers_librium_total { get; set; }
        [JsonProperty("Tranquilizers Librium Amn")] public string tranquilizers_librium_amn { get; set; }
        [JsonProperty("Tranquilizers Librium Freq")] public string tranquilizers_librium_freq { get; set; }
        [JsonProperty("Tranquilizers Librium Admin")] public string tranquilizers_librium_admin { get; set; }
        [JsonProperty("Tranquilizers Halcion")] public string tranquilizers_halcion { get; set; }
        [JsonProperty("Tranquilizers Halcion First")] public string tranquilizers_halcion_first { get; set; }
        [JsonProperty("Tranquilizers Halcion Total")] public string tranquilizers_halcion_total { get; set; }
        [JsonProperty("Tranquilizers Halcion Amn")] public string tranquilizers_halcion_amn { get; set; }
        [JsonProperty("Tranquilizers Halcion Freq")] public string tranquilizers_halcion_freq { get; set; }
        [JsonProperty("Tranquilizers Halcion Admin")] public string tranquilizers_halcion_admin { get; set; }
        [JsonProperty("Tranquilizers Prosom")] public string tranquilizers_prosom { get; set; }
        [JsonProperty("Tranquilizers Prosom First")] public string tranquilizers_prosom_first { get; set; }
        [JsonProperty("Tranquilizers Prosom Total")] public string tranquilizers_prosom_total { get; set; }
        [JsonProperty("Tranquilizers Prosom Amn")] public string tranquilizers_prosom_amn { get; set; }
        [JsonProperty("Tranquilizers Prosom Freq")] public string tranquilizers_prosom_freq { get; set; }
        [JsonProperty("Tranquilizers Prosom Admin")] public string tranquilizers_prosom_admin { get; set; }
        [JsonProperty("Tranquilizers Xanax")] public string tranquilizers_xanax { get; set; }
        [JsonProperty("Tranquilizers Xanax First")] public string tranquilizers_xanax_first { get; set; }
        [JsonProperty("Tranquilizers Xanax Total")] public string tranquilizers_xanax_total { get; set; }
        [JsonProperty("Tranquilizers Xanax Amn")] public string tranquilizers_xanax_amn { get; set; }
        [JsonProperty("Tranquilizers Xanax Freq")] public string tranquilizers_xanax_freq { get; set; }
        [JsonProperty("Tranquilizers Xanax Admin")] public string tranquilizers_xanax_admin { get; set; }
        [JsonProperty("Tranquilizers Ativan")] public string tranquilizers_ativan { get; set; }
        [JsonProperty("Tranquilizers Ativan First")] public string tranquilizers_ativan_first { get; set; }
        [JsonProperty("Tranquilizers Ativan Total")] public string tranquilizers_ativan_total { get; set; }
        [JsonProperty("Tranquilizers Ativan Amn")] public string tranquilizers_ativan_amn { get; set; }
        [JsonProperty("Tranquilizers Ativan Freq")] public string tranquilizers_ativan_freq { get; set; }
        [JsonProperty("Tranquilizers Ativan Admin")] public string tranquilizers_ativan_admin { get; set; }
        [JsonProperty("Tranquilizers Klonopin")] public string tranquilizers_klonopin { get; set; }
        [JsonProperty("Tranquilizers Klonopin First")] public string tranquilizers_klonopin_first { get; set; }
        [JsonProperty("Tranquilizers Klonopin Total")] public string tranquilizers_klonopin_total { get; set; }
        [JsonProperty("Tranquilizers Klonopin Amn")] public string tranquilizers_klonopin_amn { get; set; }
        [JsonProperty("Tranquilizers Klonopin Freq")] public string tranquilizers_klonopin_freq { get; set; }
        [JsonProperty("Tranquilizers Klonopin Admin")] public string tranquilizers_klonopin_admin { get; set; }
        [JsonProperty("Tranquilizers Restoril")] public string tranquilizers_restoril { get; set; }
        [JsonProperty("Tranquilizers Restoril First")] public string tranquilizers_restoril_first { get; set; }
        [JsonProperty("Tranquilizers Restoril Total")] public string tranquilizers_restoril_total { get; set; }
        [JsonProperty("Tranquilizers Restoril Amn")] public string tranquilizers_restoril_amn { get; set; }
        [JsonProperty("Tranquilizers Restoril Freq")] public string tranquilizers_restoril_freq { get; set; }
        [JsonProperty("Tranquilizers Restoril Admin")] public string tranquilizers_restoril_admin { get; set; }
        [JsonProperty("Tranquilizers Rohypnol")] public string tranquilizers_rohypnol { get; set; }
        [JsonProperty("Tranquilizers Rohypnol First")] public string tranquilizers_rohypnol_first { get; set; }
        [JsonProperty("Tranquilizers Rohypnol Total")] public string tranquilizers_rohypnol_total { get; set; }
        [JsonProperty("Tranquilizers Rohypnol Amn")] public string tranquilizers_rohypnol_amn { get; set; }
        [JsonProperty("Tranquilizers Rohypnol Freq")] public string tranquilizers_rohypnol_freq { get; set; }
        [JsonProperty("Tranquilizers Rohypnol Admin")] public string tranquilizers_rohypnol_admin { get; set; }
        [JsonProperty("Tranquilizers Dalmane")] public string tranquilizers_dalmane { get; set; }
        [JsonProperty("Tranquilizers Dalmane First")] public string tranquilizers_dalmane_first { get; set; }
        [JsonProperty("Tranquilizers Dalmane Total")] public string tranquilizers_dalmane_total { get; set; }
        [JsonProperty("Tranquilizers Dalmane Amn")] public string tranquilizers_dalmane_amn { get; set; }
        [JsonProperty("Tranquilizers Dalmane Freq")] public string tranquilizers_dalmane_freq { get; set; }
        [JsonProperty("Tranquilizers Dalmane Admin")] public string tranquilizers_dalmane_admin { get; set; }
        [JsonProperty("Tranquilizers Imovane")] public string tranquilizers_imovane { get; set; }
        [JsonProperty("Tranquilizers Imovane First")] public string tranquilizers_imovane_first { get; set; }
        [JsonProperty("Tranquilizers Imovane Total")] public string tranquilizers_imovane_total { get; set; }
        [JsonProperty("Tranquilizers Imovane Amn")] public string tranquilizers_imovane_amn { get; set; }
        [JsonProperty("Tranquilizers Imovane Freq")] public string tranquilizers_imovane_freq { get; set; }
        [JsonProperty("Tranquilizers Imovane Admin")] public string tranquilizers_imovane_admin { get; set; }
        [JsonProperty("Tranquilizers Ambien")] public string tranquilizers_ambien { get; set; }
        [JsonProperty("Tranquilizers Ambien First")] public string tranquilizers_ambien_first { get; set; }
        [JsonProperty("Tranquilizers Ambien Total")] public string tranquilizers_ambien_total { get; set; }
        [JsonProperty("Tranquilizers Ambien Amn")] public string tranquilizers_ambien_amn { get; set; }
        [JsonProperty("Tranquilizers Ambien Freq")] public string tranquilizers_ambien_freq { get; set; }
        [JsonProperty("Tranquilizers Ambien Admin")] public string tranquilizers_ambien_admin { get; set; }
        [JsonProperty("Tranquilizers Lunesta")] public string tranquilizers_lunesta { get; set; }
        [JsonProperty("Tranquilizers Lunesta First")] public string tranquilizers_lunesta_first { get; set; }
        [JsonProperty("Tranquilizers Lunesta Total")] public string tranquilizers_lunesta_total { get; set; }
        [JsonProperty("Tranquilizers Lunesta Amn")] public string tranquilizers_lunesta_amn { get; set; }
        [JsonProperty("Tranquilizers Lunesta Freq")] public string tranquilizers_lunesta_freq { get; set; }
        [JsonProperty("Tranquilizers Lunesta Admin")] public string tranquilizers_lunesta_admin { get; set; }
        [JsonProperty("Tranquilizers Others")] public string tranquilizers_others { get; set; }
        [JsonProperty("Tranquilizers Others First")] public string tranquilizers_others_first { get; set; }
        [JsonProperty("Tranquilizers Others Total")] public string tranquilizers_others_total { get; set; }
        [JsonProperty("Tranquilizers Others Amn")] public string tranquilizers_others_amn { get; set; }
        [JsonProperty("Tranquilizers Others Freq")] public string tranquilizers_others_freq { get; set; }
        [JsonProperty("Tranquilizers Others Admin")] public string tranquilizers_others_admin { get; set; }
        [JsonProperty("Cannabis Used")] public string Cannabis_used { get; set; }
        [JsonProperty("Cannabis Marijuana")] public string Cannabis_marijuana { get; set; }
        [JsonProperty("Cannabis Hashish")] public string Cannabis_hashish { get; set; }
        [JsonProperty("Cannabis Dope")] public string Cannabis_dope { get; set; }
        [JsonProperty("Cannabis Synthetic")] public string Cannabis_synthetic { get; set; }
        [JsonProperty("Cannabis Marijuana First")] public string Cannabis_marijuana_first { get; set; }
        [JsonProperty("Cannabis Hashish First")] public string Cannabis_hashish_first { get; set; }
        [JsonProperty("Cannabis Dope First")] public string Cannabis_dope_first { get; set; }
        [JsonProperty("Cannabis Synthetic First")] public string Cannabis_synthetic_first { get; set; }
        [JsonProperty("Cannabis Marijuana Total")] public string Cannabis_marijuana_total { get; set; }
        [JsonProperty("Cannabis Hashish Total")] public string Cannabis_hashish_total { get; set; }
        [JsonProperty("Cannabis Dope Total")] public string Cannabis_dope_total { get; set; }
        [JsonProperty("Cannabis Synthetic Total")] public string Cannabis_synthetic_total { get; set; }
        [JsonProperty("Cannabis Marijuana Amn")] public string Cannabis_marijuana_amn { get; set; }
        [JsonProperty("Cannabis Hashish Amn")] public string Cannabis_hashish_amn { get; set; }
        [JsonProperty("Cannabis Dope Amn")] public string Cannabis_dope_amn { get; set; }
        [JsonProperty("Cannabis Synthetic Amn")] public string Cannabis_synthetic_amn { get; set; }
        [JsonProperty("Cannabis Marijuana Freq")] public string Cannabis_marijuana_freq { get; set; }
        [JsonProperty("Cannabis Hashish Freq")] public string Cannabis_hashish_freq { get; set; }
        [JsonProperty("Cannabis Dope Freq")] public string Cannabis_dope_freq { get; set; }
        [JsonProperty("Cannabis Synthetic Freq")] public string Cannabis_synthetic_freq { get; set; }
        [JsonProperty("Cannabis Marijuana Admin")] public string Cannabis_marijuana_admin { get; set; }
        [JsonProperty("Cannabis Hashish Admin")] public string Cannabis_hashish_admin { get; set; }
        [JsonProperty("Cannabis Dope Admin")] public string Cannabis_dope_admin { get; set; }
        [JsonProperty("Cannabis Synthetic Admin")] public string Cannabis_synthetic_admin { get; set; }
        [JsonProperty("Amphetamines Used")] public string amphetamines_used { get; set; }
        [JsonProperty("Amphetamines Amphetamine")] public string amphetamines_amphetamine { get; set; }
        [JsonProperty("Amphetamines Amphetamine First")] public string amphetamines_amphetamine_first { get; set; }
        [JsonProperty("Amphetamines Amphetamine Total")] public string amphetamines_amphetamine_total { get; set; }
        [JsonProperty("Amphetamines Amphetamine Amn")] public string amphetamines_amphetamine_amn { get; set; }
        [JsonProperty("Amphetamines Amphetamine Freq")] public string amphetamines_amphetamine_freq { get; set; }
        [JsonProperty("Amphetamines Amphetamine Admin")] public string amphetamines_amphetamine_admin { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Crystal")] public string amphetamines_methamphetamine_crystal { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Crystal First")] public string amphetamines_methamphetamine_crystal_first { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Crystal Total")] public string amphetamines_methamphetamine_crystal_total { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Crystal Amn")] public string amphetamines_methamphetamine_crystal_amn { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Crystal Freq")] public string amphetamines_methamphetamine_crystal_freq { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Crystal Admin")] public string amphetamines_methamphetamine_crystal_admin { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Hcl")] public string amphetamines_methamphetamine_hcl { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Hcl First")] public string amphetamines_methamphetamine_hcl_first { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Hcl Total")] public string amphetamines_methamphetamine_hcl_total { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Hcl Amn")] public string amphetamines_methamphetamine_hcl_amn { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Hcl Freq")] public string amphetamines_methamphetamine_hcl_freq { get; set; }
        [JsonProperty("Amphetamines Methamphetamine Hcl Admin")] public string amphetamines_methamphetamine_hcl_admin { get; set; }
        [JsonProperty("Amphetamines Dextroamphetamine")] public string amphetamines_dextroamphetamine { get; set; }
        [JsonProperty("Amphetamines Dextroamphetamine First")] public string amphetamines_dextroamphetamine_first { get; set; }
        [JsonProperty("Amphetamines Dextroamphetamine Total")] public string amphetamines_dextroamphetamine_total { get; set; }
        [JsonProperty("Amphetamines Dextroamphetamine Amn")] public string amphetamines_dextroamphetamine_amn { get; set; }
        [JsonProperty("Amphetamines Dextroamphetamine Freq")] public string amphetamines_dextroamphetamine_freq { get; set; }
        [JsonProperty("Amphetamines Dextroamphetamine Admin")] public string amphetamines_dextroamphetamine_admin { get; set; }
        [JsonProperty("Amphetamines Mdma")] public string amphetamines_mdma { get; set; }
        [JsonProperty("Amphetamines Mdma First")] public string amphetamines_mdma_first { get; set; }
        [JsonProperty("Amphetamines Mdma Total")] public string amphetamines_mdma_total { get; set; }
        [JsonProperty("Amphetamines Mdma Amn")] public string amphetamines_mdma_amn { get; set; }
        [JsonProperty("Amphetamines Mdma Freq")] public string amphetamines_mdma_freq { get; set; }
        [JsonProperty("Amphetamines Mdma Admin")] public string amphetamines_mdma_admin { get; set; }
        [JsonProperty("Cocaine Used")] public string cocaine_used { get; set; }
        [JsonProperty("Cocaine Coke")] public string cocaine_coke { get; set; }
        [JsonProperty("Cocaine Crack")] public string cocaine_crack { get; set; }
        [JsonProperty("Cocaine Snow")] public string cocaine_snow { get; set; }
        [JsonProperty("Cocaine Coke First")] public string cocaine_coke_first { get; set; }
        [JsonProperty("Cocaine Crack First")] public string cocaine_crack_first { get; set; }
        [JsonProperty("Cocaine Snow First")] public string cocaine_snow_first { get; set; }
        [JsonProperty("Cocaine Coke Total")] public string cocaine_coke_total { get; set; }
        [JsonProperty("Cocaine Crack Total")] public string cocaine_crack_total { get; set; }
        [JsonProperty("Cocaine Snow Total")] public string cocaine_snow_total { get; set; }
        [JsonProperty("Cocaine Coke Amn")] public string cocaine_coke_amn { get; set; }
        [JsonProperty("Cocaine Crack Amn")] public string cocaine_crack_amn { get; set; }
        [JsonProperty("Cocaine Snow Amn")] public string cocaine_snow_amn { get; set; }
        [JsonProperty("Cocaine Coke Freq")] public string cocaine_coke_freq { get; set; }
        [JsonProperty("Cocaine Crack Freq")] public string cocaine_crack_freq { get; set; }
        [JsonProperty("Cocaine Snow Freq")] public string cocaine_snow_freq { get; set; }
        [JsonProperty("Cocaine Coke Admin")] public string cocaine_coke_admin { get; set; }
        [JsonProperty("Cocaine Crack Admin")] public string cocaine_crack_admin { get; set; }
        [JsonProperty("Cocaine Snow Admin")] public string cocaine_snow_admin { get; set; }
        [JsonProperty("Hallucinogens Used")] public string Hallucinogens_used { get; set; }
        [JsonProperty("Hallucinogens Lsd")] public string hallucinogens_lsd { get; set; }
        [JsonProperty("Hallucinogens Mushroom")] public string hallucinogens_mushroom { get; set; }
        [JsonProperty("Hallucinogens Lsd First")] public string hallucinogens_lsd_first { get; set; }
        [JsonProperty("Hallucinogens Mushroom First")] public string hallucinogens_mushroom_first { get; set; }
        [JsonProperty("Hallucinogens Lsd Total")] public string hallucinogens_lsd_total { get; set; }
        [JsonProperty("Hallucinogens Mushroom Total")] public string hallucinogens_mushroom_total { get; set; }
        [JsonProperty("Hallucinogens Lsd Amn")] public string hallucinogens_lsd_amn { get; set; }
        [JsonProperty("Hallucinogens Mushroom Amn")] public string hallucinogens_mushroom_amn { get; set; }
        [JsonProperty("Hallucinogens Lsd Freq")] public string hallucinogens_lsd_freq { get; set; }
        [JsonProperty("Hallucinogens Mushroom Freq")] public string hallucinogens_mushroom_freq { get; set; }
        [JsonProperty("Hallucinogens Lsd Admin")] public string hallucinogens_lsd_admin { get; set; }
        [JsonProperty("Hallucinogens Mushroom Admin")] public string hallucinogens_mushroom_admin { get; set; }
        [JsonProperty("Inhalants Used")] public string Inhalants_used { get; set; }
        [JsonProperty("Inhalants Petrolume")] public string Inhalants_petrolume { get; set; }
        [JsonProperty("Inhalants Petrolume First")] public string Inhalants_petrolume_first { get; set; }
        [JsonProperty("Inhalants Petrolume Total")] public string Inhalants_petrolume_total { get; set; }
        [JsonProperty("Inhalants Petrolume Amn")] public string Inhalants_petrolume_amn { get; set; }
        [JsonProperty("Inhalants Petrolume Freq")] public string Inhalants_petrolume_freq { get; set; }
        [JsonProperty("Inhalants Petrolume Admin")] public string Inhalants_petrolume_admin { get; set; }
        [JsonProperty("Inhalants Toulene")] public string Inhalants_toulene { get; set; }
        [JsonProperty("Inhalants Toulene First")] public string Inhalants_toulene_first { get; set; }
        [JsonProperty("Inhalants Toulene Total")] public string Inhalants_toulene_total { get; set; }
        [JsonProperty("Inhalants Toulene Amn")] public string Inhalants_toulene_amn { get; set; }
        [JsonProperty("Inhalants Toulene Freq")] public string Inhalants_toulene_freq { get; set; }
        [JsonProperty("Inhalants Toulene Admin")] public string Inhalants_toulene_admin { get; set; }
        [JsonProperty("Inhalants Acetone")] public string Inhalants_acetone { get; set; }
        [JsonProperty("Inhalants Acetone First")] public string Inhalants_acetone_first { get; set; }
        [JsonProperty("Inhalants Acetone Total")] public string Inhalants_acetone_total { get; set; }
        [JsonProperty("Inhalants Acetone Amn")] public string Inhalants_acetone_amn { get; set; }
        [JsonProperty("Inhalants Acetone Freq")] public string Inhalants_acetone_freq { get; set; }
        [JsonProperty("Inhalants Acetone Admin")] public string Inhalants_acetone_admin { get; set; }
        [JsonProperty("Inhalants Aerosols")] public string Inhalants_aerosols { get; set; }
        [JsonProperty("Inhalants Aerosols First")] public string Inhalants_aerosols_first { get; set; }
        [JsonProperty("Inhalants Aerosols Total")] public string Inhalants_aerosols_total { get; set; }
        [JsonProperty("Inhalants Aerosols Amn")] public string Inhalants_aerosols_amn { get; set; }
        [JsonProperty("Inhalants Aerosols Freq")] public string Inhalants_aerosols_freq { get; set; }
        [JsonProperty("Inhalants Aerosols Admin")] public string Inhalants_aerosols_admin { get; set; }
        [JsonProperty("Inhalants Nitrites")] public string Inhalants_nitrites { get; set; }
        [JsonProperty("Inhalants Nitrites First")] public string Inhalants_nitrites_first { get; set; }
        [JsonProperty("Inhalants Nitrites Total")] public string Inhalants_nitrites_total { get; set; }
        [JsonProperty("Inhalants Nitrites Amn")] public string Inhalants_nitrites_amn { get; set; }
        [JsonProperty("Inhalants Nitrites Freq")] public string Inhalants_nitrites_freq { get; set; }
        [JsonProperty("Inhalants Nitrites Admin")] public string Inhalants_nitrites_admin { get; set; }
        [JsonProperty("Barbiturates Used")] public string Barbiturates_used { get; set; }
        [JsonProperty("Barbiturates Amobarbital")] public string Barbiturates_Amobarbital { get; set; }
        [JsonProperty("Barbiturates Amobarbital First")] public string Barbiturates_Amobarbital_first { get; set; }
        [JsonProperty("Barbiturates Amobarbital Total")] public string Barbiturates_Amobarbital_total { get; set; }
        [JsonProperty("Barbiturates Amobarbital Amn")] public string Barbiturates_Amobarbital_amn { get; set; }
        [JsonProperty("Barbiturates Amobarbital Freq")] public string Barbiturates_Amobarbital_freq { get; set; }
        [JsonProperty("Barbiturates Amobarbital Admin")] public string Barbiturates_Amobarbital_admin { get; set; }
        [JsonProperty("Barbiturates Pentobarbital")] public string Barbiturates_pentobarbital { get; set; }
        [JsonProperty("Barbiturates Pentobarbital First")] public string Barbiturates_pentobarbital_first { get; set; }
        [JsonProperty("Barbiturates Pentobarbital Total")] public string Barbiturates_pentobarbital_total { get; set; }
        [JsonProperty("Barbiturates Pentobarbital Amn")] public string Barbiturates_pentobarbital_amn { get; set; }
        [JsonProperty("Barbiturates Pentobarbital Freq")] public string Barbiturates_pentobarbital_freq { get; set; }
        [JsonProperty("Barbiturates Pentobarbital Admin")] public string Barbiturates_pentobarbital_admin { get; set; }
        [JsonProperty("Barbiturates Nembutal")] public string Barbiturates_nembutal { get; set; }
        [JsonProperty("Barbiturates Nembutal First")] public string Barbiturates_nembutal_first { get; set; }
        [JsonProperty("Barbiturates Nembutal Total")] public string Barbiturates_nembutal_total { get; set; }
        [JsonProperty("Barbiturates Nembutal Amn")] public string Barbiturates_nembutal_amn { get; set; }
        [JsonProperty("Barbiturates Nembutal Freq")] public string Barbiturates_nembutal_freq { get; set; }
        [JsonProperty("Barbiturates Nembutal Admin")] public string Barbiturates_nembutal_admin { get; set; }
        [JsonProperty("Alcohol Used")] public string alcohol_used { get; set; }
        [JsonProperty("Alcohol Beer")] public string alcohol_beer { get; set; }
        [JsonProperty("Alcohol Wiseky")] public string alcohol_wiseky { get; set; }
        [JsonProperty("Alcohol Vodka")] public string alcohol_vodka { get; set; }
        [JsonProperty("Alcohol Tequila")] public string alcohol_tequila { get; set; }
        [JsonProperty("Alcohol Gin")] public string alcohol_gin { get; set; }
        [JsonProperty("Alcohol Rum")] public string alcohol_rum { get; set; }
        [JsonProperty("Alcohol Wines")] public string alcohol_wines { get; set; }
        [JsonProperty("Alcohol Beer First")] public string alcohol_beer_first { get; set; }
        [JsonProperty("Alcohol Wiseky First")] public string alcohol_wiseky_first { get; set; }
        [JsonProperty("Alcohol Vodka First")] public string alcohol_vodka_first { get; set; }
        [JsonProperty("Alcohol Tequila First")] public string alcohol_tequila_first { get; set; }
        [JsonProperty("Alcohol Gin First")] public string alcohol_gin_first { get; set; }
        [JsonProperty("Alcohol Rum First")] public string alcohol_rum_first { get; set; }
        [JsonProperty("Alcohol Wines First")] public string alcohol_wines_first { get; set; }
        [JsonProperty("Alcohol Beer Total")] public string alcohol_beer_total { get; set; }
        [JsonProperty("Alcohol Wiseky Total")] public string alcohol_wiseky_total { get; set; }
        [JsonProperty("Alcohol Vodka Total")] public string alcohol_vodka_total { get; set; }
        [JsonProperty("Alcohol Tequila Total")] public string alcohol_tequila_total { get; set; }
        [JsonProperty("Alcohol Gin Total")] public string alcohol_gin_total { get; set; }
        [JsonProperty("Alcohol Rum Total")] public string alcohol_rum_total { get; set; }
        [JsonProperty("Alcohol Wines Total")] public string alcohol_wines_total { get; set; }
        [JsonProperty("Alcohol Beer Amn")] public string alcohol_beer_amn { get; set; }
        [JsonProperty("Alcohol Wiseky Amn")] public string alcohol_wiseky_amn { get; set; }
        [JsonProperty("Alcohol Vodka Amn")] public string alcohol_vodka_amn { get; set; }
        [JsonProperty("Alcohol Tequila Amn")] public string alcohol_tequila_amn { get; set; }
        [JsonProperty("Alcohol Gin Amn")] public string alcohol_gin_amn { get; set; }
        [JsonProperty("Alcohol Rum Amn")] public string alcohol_rum_amn { get; set; }
        [JsonProperty("Alcohol Wines Amn")] public string alcohol_wines_amn { get; set; }
        [JsonProperty("Alcohol Beer Freq")] public string alcohol_beer_freq { get; set; }
        [JsonProperty("Alcohol Wiseky Freq")] public string alcohol_wiseky_freq { get; set; }
        [JsonProperty("Alcohol Vodka Freq")] public string alcohol_vodka_freq { get; set; }
        [JsonProperty("Alcohol Tequila Freq")] public string alcohol_tequila_freq { get; set; }
        [JsonProperty("Alcohol Gin Freq")] public string alcohol_gin_freq { get; set; }
        [JsonProperty("Alcohol Rum Freq")] public string alcohol_rum_freq { get; set; }
        [JsonProperty("Alcohol Wines Freq")] public string alcohol_wines_freq { get; set; }
        [JsonProperty("Alcohol Beer Admin")] public string alcohol_beer_admin { get; set; }
        [JsonProperty("Alcohol Wiseky Admin")] public string alcohol_wiseky_admin { get; set; }
        [JsonProperty("Alcohol Vodka Admin")] public string alcohol_vodka_admin { get; set; }
        [JsonProperty("Alcohol Tequila Admin")] public string alcohol_tequila_admin { get; set; }
        [JsonProperty("Alcohol Gin Admin")] public string alcohol_gin_admin { get; set; }
        [JsonProperty("Alcohol Rum Admin")] public string alcohol_rum_admin { get; set; }
        [JsonProperty("Alcohol Wines Admin")] public string alcohol_wines_admin { get; set; }
        [JsonProperty("Tobacco Used")] public string tobacco_used { get; set; }
        [JsonProperty("Tobacco Cigarette")] public string tobacco_cigarette { get; set; }
        [JsonProperty("Tobacco Cigar")] public string tobacco_cigar { get; set; }
        [JsonProperty("Tobacco Midwakh")] public string tobacco_midwakh { get; set; }
        [JsonProperty("Tobacco Shisha")] public string tobacco_shisha { get; set; }
        [JsonProperty("Tobacco Cigarette First")] public string tobacco_cigarette_first { get; set; }
        [JsonProperty("Tobacco Cigar First")] public string tobacco_cigar_first { get; set; }
        [JsonProperty("Tobacco Midwakh First")] public string tobacco_midwakh_first { get; set; }
        [JsonProperty("Tobacco Shisha First")] public string tobacco_shisha_first { get; set; }
        [JsonProperty("Tobacco Cigarette Total")] public string tobacco_cigarette_total { get; set; }
        [JsonProperty("Tobacco Cigar Total")] public string tobacco_cigar_total { get; set; }
        [JsonProperty("Tobacco Midwakh Total")] public string tobacco_midwakh_total { get; set; }
        [JsonProperty("Tobacco Shisha Total")] public string tobacco_shisha_total { get; set; }
        [JsonProperty("Tobacco Cigarette Amn")] public string tobacco_cigarette_amn { get; set; }
        [JsonProperty("Tobacco Cigar Amn")] public string tobacco_cigar_amn { get; set; }
        [JsonProperty("Tobacco Midwakh Amn")] public string tobacco_midwakh_amn { get; set; }
        [JsonProperty("Tobacco Shisha Amn")] public string tobacco_shisha_amn { get; set; }
        [JsonProperty("Tobacco Cigarette Freq")] public string tobacco_cigarette_freq { get; set; }
        [JsonProperty("Tobacco Cigar Freq")] public string tobacco_cigar_freq { get; set; }
        [JsonProperty("Tobacco Midwakh Freq")] public string tobacco_midwakh_freq { get; set; }
        [JsonProperty("Tobacco Shisha Freq")] public string tobacco_shisha_freq { get; set; }
        [JsonProperty("Tobacco Cigarette Admin")] public string tobacco_cigarette_admin { get; set; }
        [JsonProperty("Tobacco Cigar Admin")] public string tobacco_cigar_admin { get; set; }
        [JsonProperty("Tobacco Midwakh Admin")] public string tobacco_midwakh_admin { get; set; }
        [JsonProperty("Tobacco Shisha Admin")] public string tobacco_shisha_admin { get; set; }
        [JsonProperty("Substance Dependence His Others")] public string substance_dependence_his_others { get; set; }
        [JsonProperty("Prescribed Others State")] public string prescribed_others_state { get; set; }
        [JsonProperty("Prescribed Others First")] public string prescribed_others_first { get; set; }
        [JsonProperty("Prescribed Others Total")] public string prescribed_others_total { get; set; }
        [JsonProperty("Prescribed Others Amn")] public string prescribed_others_amn { get; set; }
        [JsonProperty("Prescribed Others Freq")] public string prescribed_others_freq { get; set; }
        [JsonProperty("Prescribed Others Admin")] public string prescribed_others_admin { get; set; }
        [JsonProperty("Sub Symptoms Seizures")] public string sub_symptoms_seizures { get; set; }
        [JsonProperty("Sub Symptoms Blackout")] public string sub_symptoms_blackout { get; set; }
        [JsonProperty("Sub Symptoms Hallucination")] public string sub_symptoms_hallucination { get; set; }
        [JsonProperty("Sub Symptoms Chest Pain")] public string sub_symptoms_chest_pain { get; set; }
        [JsonProperty("Sub Symptoms Sleep Dis")] public string sub_symptoms_sleep_dis { get; set; }
        [JsonProperty("Sub Symptoms Anxiety")] public string sub_symptoms_anxiety { get; set; }
        [JsonProperty("Sub Symptoms Nausea")] public string sub_symptoms_nausea { get; set; }
        [JsonProperty("Sub Symptoms Diarrhea")] public string sub_symptoms_Diarrhea { get; set; }
        [JsonProperty("Sub Symptoms Eating Problem")] public string sub_symptoms_eating_problem { get; set; }
        [JsonProperty("Sub Symptoms Fatigue")] public string sub_symptoms_fatigue { get; set; }
        [JsonProperty("Sub Symptoms Overdose")] public string sub_symptoms_overdose { get; set; }
        [JsonProperty("Sub Symptoms Headache")] public string sub_symptoms_headache { get; set; }
        [JsonProperty("Sub Symptoms Dizziness")] public string sub_symptoms_dizziness { get; set; }
        [JsonProperty("Sub Symptoms Paranoid")] public string sub_symptoms_paranoid { get; set; }
        [JsonProperty("Sub Symptoms Palpitation")] public string sub_symptoms_palpitation { get; set; }
        [JsonProperty("Sub Symptoms Uncontrollable")] public string sub_symptoms_uncontrollable { get; set; }
        [JsonProperty("Sub Symptoms Hyperactive")] public string sub_symptoms_hyperactive { get; set; }
        [JsonProperty("Sub Symptoms Vomitting")] public string sub_symptoms_vomitting { get; set; }
        [JsonProperty("Sub Symptoms Constipation")] public string sub_symptoms_constipation { get; set; }
        [JsonProperty("Sub Symptoms Urinating")] public string sub_symptoms_urinating { get; set; }
        [JsonProperty("Sub Symptoms Irritability")] public string sub_symptoms_irritability { get; set; }
        [JsonProperty("Sub Symptoms Others")] public string sub_symptoms_others { get; set; }
        [JsonProperty("Sub Symptoms Others Text")] public string sub_symptoms_others_text { get; set; }
        [JsonProperty("Substance Diagnosed")] public string substance_diagnosed { get; set; }
        [JsonProperty("Drug Dosage")] public string drug_dosage { get; set; }
        [JsonProperty("Sub Time Frame")] public string sub_time_frame { get; set; }
        [JsonProperty("Drug Sibling")] public string drug_sibling { get; set; }
        [JsonProperty("Sib Drug")] public string sib_drug { get; set; }
        [JsonProperty("Drug Mother")] public string drug_mother { get; set; }
        [JsonProperty("Mother Drug")] public string mother_drug { get; set; }
        [JsonProperty("Drug Father")] public string drug_father { get; set; }
        [JsonProperty("Father Drug")] public string father_drug { get; set; }
        [JsonProperty("Drug Others His")] public string drug_others_his { get; set; }
        [JsonProperty("Others Drug")] public string others_drug { get; set; }
        [JsonProperty("Medic Sib")] public string medic_sib { get; set; }
        [JsonProperty("Medic Drug")] public string medic_drug { get; set; }
        [JsonProperty("Medic Mother")] public string medic_mother { get; set; }
        [JsonProperty("Medic Mother Drug")] public string medic_mother_drug { get; set; }
        [JsonProperty("Medic Father")] public string medic_father { get; set; }
        [JsonProperty("Medic Father Drug")] public string medic_father_drug { get; set; }
        [JsonProperty("Medic Others His")] public string medic_others_his { get; set; }
        [JsonProperty("Medic Others Drug")] public string medic_others_drug { get; set; }
        [JsonProperty("Completed Fam")] public string completed_fam { get; set; }
        [JsonProperty("Completed Fam Reason")] public string completed_fam_reason { get; set; }
        [JsonProperty("Completed Fam Reason Other")] public string completed_fam_reason_other { get; set; }
        [JsonProperty("Addiction Treatment")] public string addiction_treatment { get; set; }
        [JsonProperty("Sub Treat Prescribed Times")] public string sub_treat_prescribed_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Star")] public string sub_treat_prescribed_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Finis")] public string sub_treat_prescribed_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Encoun")] public string sub_treat_prescribed_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Naltrexone Times")] public string sub_treat_prescribed_Naltrexone_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Naltrexone Star")] public string sub_treat_prescribed_Naltrexone_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Naltrexone Finis")] public string sub_treat_prescribed_Naltrexone_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Naltrexone Encoun")] public string sub_treat_prescribed_Naltrexone_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Buprenorphine Times")] public string sub_treat_prescribed_Buprenorphine_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Buprenorphine Star")] public string sub_treat_prescribed_Buprenorphine_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Buprenorphine Finis")] public string sub_treat_prescribed_Buprenorphine_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Buprenorphine Encoun")] public string sub_treat_prescribed_Buprenorphine_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Inpatient Times")] public string sub_treat_prescribed_Inpatient_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Inpatient Star")] public string sub_treat_prescribed_Inpatient_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Inpatient Finis")] public string sub_treat_prescribed_Inpatient_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Inpatient Encoun")] public string sub_treat_prescribed_Inpatient_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Rehab Times")] public string sub_treat_prescribed_rehab_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Rehab Star")] public string sub_treat_prescribed_rehab_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Rehab Finis")] public string sub_treat_prescribed_rehab_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Rehab Encoun")] public string sub_treat_prescribed_rehab_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Detox Times")] public string sub_treat_prescribed_outpatient_detox_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Detox Star")] public string sub_treat_prescribed_outpatient_detox_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Detox Finis")] public string sub_treat_prescribed_outpatient_detox_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Detox Encoun")] public string sub_treat_prescribed_outpatient_detox_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Counselling Times")] public string sub_treat_prescribed_outpatient_counselling_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Counselling Star")] public string sub_treat_prescribed_outpatient_counselling_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Counselling Finis")] public string sub_treat_prescribed_outpatient_counselling_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Outpatient Counselling Encoun")] public string sub_treat_prescribed_outpatient_counselling_encoun { get; set; }
        [JsonProperty("Sub Treat Prescribed Self Help Group Times")] public string sub_treat_prescribed_self_help_group_times { get; set; }
        [JsonProperty("Sub Treat Prescribed Self Help Group Star")] public string sub_treat_prescribed_self_help_group_star { get; set; }
        [JsonProperty("Sub Treat Prescribed Self Help Group Finis")] public string sub_treat_prescribed_self_help_group_finis { get; set; }
        [JsonProperty("Sub Treat Prescribed Self Help Group Encoun")] public string sub_treat_prescribed_self_help_group_encoun { get; set; }
        [JsonProperty("Sub Treatment Completed")] public string sub_treatment_completed { get; set; }
        [JsonProperty("Sub Treatment Recent Specify")] public string sub_treatment_recent_specify { get; set; }
        [JsonProperty("Sub Treatment Relapse")] public string sub_treatment_relapse { get; set; }
        [JsonProperty("Sub Treatment Relapse Specify")] public string sub_treatment_relapse_specify { get; set; }
        [JsonProperty("Relapse Period")] public string relapse_period { get; set; }
        [JsonProperty("Current Treat Readiness")] public string current_treat_readiness { get; set; }
        [JsonProperty("Risk Of Relapse")] public string risk_of_relapse { get; set; }
        [JsonProperty("Risk Of Relapse Specify")] public string risk_of_relapse_specify { get; set; }
        [JsonProperty("Opiate Methadon")] public string opiate_methadon { get; set; }
        [JsonProperty("Opiate Methadon Text")] public string opiate_methadon_text { get; set; }
        [JsonProperty("Opiate Clonide")] public string opiate_Clonide { get; set; }
        [JsonProperty("Opiate Clonide Text")] public string opiate_Clonide_text { get; set; }
        [JsonProperty("Opiate Bupemorphine")] public string opiate_Bupemorphine { get; set; }
        [JsonProperty("Opiate Bupemorphine Text")] public string opiate_Bupemorphine_text { get; set; }
        [JsonProperty("Opiate Suboxon")] public string opiate_suboxon { get; set; }
        [JsonProperty("Opiate Suboxon Text")] public string opiate_suboxon_text { get; set; }
        [JsonProperty("Opiate Naloxon")] public string opiate_Naloxon { get; set; }
        [JsonProperty("Opiate Naloxon Text")] public string opiate_Naloxon_text { get; set; }
        [JsonProperty("Opiate Naltrexon")] public string opiate_Naltrexon { get; set; }
        [JsonProperty("Opiate Naltrexon Text")] public string opiate_Naltrexon_text { get; set; }
        [JsonProperty("Opiate Naltrexon Xr")] public string opiate_Naltrexon_xr { get; set; }
        [JsonProperty("Opiate Naltrexon Xr Text")] public string opiate_Naltrexon_xr_text { get; set; }
        [JsonProperty("Opiate Lofex")] public string opiate_LOFex { get; set; }
        [JsonProperty("Opiate Lofex Text")] public string opiate_LOFex_text { get; set; }
        [JsonProperty("Opiate Others")] public string opiate_others { get; set; }
        [JsonProperty("Opiate Others Specify")] public string opiate_others_specify { get; set; }
        [JsonProperty("Opiate Others Text")] public string opiate_others_text { get; set; }
        [JsonProperty("Alcohol Acamprosate")] public string alcohol_acamprosate { get; set; }
        [JsonProperty("Alcohol Acamprosate Text")] public string alcohol_acamprosate_text { get; set; }
        [JsonProperty("Alcohol Disulfirm")] public string alcohol_disulfirm { get; set; }
        [JsonProperty("Alcohol Disulfirm Text")] public string alcohol_disulfirm_text { get; set; }
        [JsonProperty("Alcohol Naltrexon")] public string alcohol_naltrexon { get; set; }
        [JsonProperty("Alcohol Naltrexon Text")] public string alcohol_naltrexon_text { get; set; }
        [JsonProperty("Alcohol Naltrexon Xr")] public string alcohol_naltrexon_xr { get; set; }
        [JsonProperty("Alcohol Naltrexon Xr Text")] public string alcohol_naltrexon_xr_text { get; set; }
        [JsonProperty("Benzodiazphine Flumazenil")] public string Benzodiazphine_flumazenil { get; set; }
        [JsonProperty("Benzodiazphine Flumazenil Text")] public string Benzodiazphine_flumazenil_text { get; set; }
        [JsonProperty("Benzodiazphine Others")] public string Benzodiazphine_others { get; set; }
        [JsonProperty("Benzodiazphine Others Specify")] public string Benzodiazphine_others_specify { get; set; }
        [JsonProperty("Benzodiazphine Others Text")] public string Benzodiazphine_others_text { get; set; }
        [JsonProperty("Nicotine Vaenicline")] public string nicotine_vaenicline { get; set; }
        [JsonProperty("Nicotine Vaenicline Text")] public string nicotine_vaenicline_text { get; set; }
        [JsonProperty("Nicotine Bupropion")] public string nicotine_bupropion { get; set; }
        [JsonProperty("Nicotine Bupropion Text")] public string nicotine_bupropion_text { get; set; }
        [JsonProperty("Nicotine Nicotinnell")] public string nicotine_nicotinnell { get; set; }
        [JsonProperty("Nicotine Nicotinnell Text")] public string nicotine_nicotinnell_text { get; set; }
        [JsonProperty("Nicotine Nicotinnell Gum")] public string nicotine_nicotinnell_gum { get; set; }
        [JsonProperty("Nicotine Nicotinnell Gum Text")] public string nicotine_nicotinnell_gum_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic")] public string other_medic_antipsycotic { get; set; }
        [JsonProperty("Other Medic Antipsycotic Abilify Text")] public string other_medic_Antipsycotic_abilify_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Zebraxa Text")] public string other_medic_Antipsycotic_zebraxa_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Seriquol Text")] public string other_medic_Antipsycotic_seriquol_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Risperdal Text")] public string other_medic_Antipsycotic_risperdal_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Ziprasidone Text")] public string other_medic_Antipsycotic_ziprasidone_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Haldol Text")] public string other_medic_Antipsycotic_haldol_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Zuclopenthixol Text")] public string other_medic_Antipsycotic_zuclopenthixol_text { get; set; }
        [JsonProperty("Other Medic Antipsycotic Others Text")] public string other_medic_Antipsycotic_others_text { get; set; }
        [JsonProperty("Other Medic Antidepressants")] public string other_medic_Antidepressants { get; set; }
        [JsonProperty("Other Medic Antidepressants Amitryptyline Text")] public string other_medic_Antidepressants_amitryptyline_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Clomiparamine Text")] public string other_medic_Antidepressants_clomiparamine_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Fluxetine Text")] public string other_medic_Antidepressants_fluxetine_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Effexor Text")] public string other_medic_Antidepressants_effexor_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Seroxate Text")] public string other_medic_Antidepressants_seroxate_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Escitalopram Text")] public string other_medic_Antidepressants_escitalopram_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Sertraline Text")] public string other_medic_Antidepressants_sertraline_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Mirtazapine Text")] public string other_medic_Antidepressants_mirtazapine_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Bupropion Text")] public string other_medic_Antidepressants_bupropion_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Others Text")] public string other_medic_Antidepressants_others_text { get; set; }
        [JsonProperty("Other Medic Antidepressants Others Dose")] public string other_medic_Antidepressants_others_dose { get; set; }
        [JsonProperty("Other Medic Central Nervous")] public string other_medic_central_nervous { get; set; }
        [JsonProperty("Other Medic Central Nervous Text")] public string other_medic_central_nervous_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics")] public string other_medic_hypnotic_anxiolytics { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Imovane Text")] public string other_medic_hypnotic_anxiolytics_imovane_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Diazepam Text")] public string other_medic_hypnotic_anxiolytics_diazepam_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Librium Text")] public string other_medic_hypnotic_anxiolytics_librium_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Buspar Text")] public string other_medic_hypnotic_anxiolytics_buspar_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Alprazolam Text")] public string other_medic_hypnotic_anxiolytics_alprazolam_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Lorazepam Text")] public string other_medic_hypnotic_anxiolytics_lorazepam_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Hydroxyzine Text")] public string other_medic_hypnotic_anxiolytics_hydroxyzine_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Others Text")] public string other_medic_hypnotic_anxiolytics_others_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Anxiolytics Others Dose")] public string other_medic_hypnotic_anxiolytics_others_dose { get; set; }
        [JsonProperty("Other Medic Antiepileptics")] public string other_medic_Antiepileptics { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Carbamazepine Text")] public string other_medic_hypnotic_antiepileptics_carbamazepine_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Klonopin Text")] public string other_medic_hypnotic_antiepileptics_klonopin_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Gabapentin Text")] public string other_medic_hypnotic_antiepileptics_gabapentin_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Lamotrigine Text")] public string other_medic_hypnotic_antiepileptics_lamotrigine_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Topamax Text")] public string other_medic_hypnotic_antiepileptics_topamax_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Dilantin Text")] public string other_medic_hypnotic_antiepileptics_dilantin_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Epilim Text")] public string other_medic_hypnotic_antiepileptics_epilim_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Others Text")] public string other_medic_hypnotic_antiepileptics_others_text { get; set; }
        [JsonProperty("Other Medic Hypnotic Antiepileptics Others Dose")] public string other_medic_hypnotic_antiepileptics_others_dose { get; set; }
        [JsonProperty("Out Patient Healthy Diet")] public string out_patient_healthy_diet { get; set; }
        [JsonProperty("Follow Up Session Specify")] public string follow_up_session_specify { get; set; }
        [JsonProperty("Out Patient Treatment Response")] public string out_patient_treatment_response { get; set; }
        [JsonProperty("Att Treat How Long")] public string att_treat_how_long { get; set; }
        [JsonProperty("Att Treat Number Ses")] public string att_treat_number_ses { get; set; }
        [JsonProperty("Att Treat")] public string att_treat { get; set; }
        [JsonProperty("Att Treat How Many")] public string att_treat_how_many { get; set; }
        [JsonProperty("Test Sample Collected")] public string test_sample_collected { get; set; }
        [JsonProperty("Test Sample Collected Spec")] public string test_sample_collected_spec { get; set; }
        [JsonProperty("Amphetamines")] public string amphetamines { get; set; }
        [JsonProperty("Amphetamines Com")] public string amphetamines_com { get; set; }
        [JsonProperty("Barbiturates")] public string barbiturates { get; set; }
        [JsonProperty("Barbiturates Com")] public string barbiturates_com { get; set; }
        [JsonProperty("Test Benzodiazepines")] public string test_benzodiazepines { get; set; }
        [JsonProperty("Test Benzodiazepines Com")] public string test_benzodiazepines_com { get; set; }
        [JsonProperty("Test Cannainoids")] public string test_cannainoids { get; set; }
        [JsonProperty("Test Cannainoids Com")] public string test_cannainoids_com { get; set; }
        [JsonProperty("Test Cocaine")] public string test_cocaine { get; set; }
        [JsonProperty("Test Cocaine Com")] public string test_cocaine_com { get; set; }
        [JsonProperty("Test Methadone")] public string test_methadone { get; set; }
        [JsonProperty("Test Methadone Com")] public string test_methadone_com { get; set; }
        [JsonProperty("Test Phencyclidine")] public string test_phencyclidine { get; set; }
        [JsonProperty("Test Phencyclidine Com")] public string test_phencyclidine_com { get; set; }
        [JsonProperty("Test Propxyphene")] public string test_propxyphene { get; set; }
        [JsonProperty("Test Propxyphene Com")] public string test_propxyphene_com { get; set; }
        [JsonProperty("Test Opiate")] public string test_opiate { get; set; }
        [JsonProperty("Test Opiate Com")] public string test_opiate_com { get; set; }
        [JsonProperty("Test Target Drug Others Text")] public string test_target_drug_others_text { get; set; }
        [JsonProperty("Test Target Drug Others")] public string test_target_drug_others { get; set; }
        [JsonProperty("Test Target Drug Others Com")] public string test_target_drug_others_com { get; set; }
        [JsonProperty("Diabetesmellitus")] public string diabetesMellitus { get; set; }
        [JsonProperty("Diabetic")] public string diabetic { get; set; }
        [JsonProperty("Age")] public string age { get; set; }
        [JsonProperty("Dyslipidemia")] public string dyslipidemia { get; set; }
        [JsonProperty("Diabetes Com")] public string diabetes_com { get; set; }
        [JsonProperty("Spec App Retinopathy")] public string spec_app_retinopathy { get; set; }
        [JsonProperty("Spec App Neuropathy")] public string spec_app_neuropathy { get; set; }
        [JsonProperty("Neuropathy Other")] public string neuropathy_other { get; set; }
        [JsonProperty("Spec App Cva")] public string spec_app_cva { get; set; }
        [JsonProperty("Spec App Nephropathy")] public string spec_app_nephropathy { get; set; }
        [JsonProperty("Nephropathy Albuminuria Others")] public string nephropathy_albuminuria_others { get; set; }
        [JsonProperty("Nephropathy Egfr Others")] public string nephropathy_eGFR_others { get; set; }
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
        [JsonProperty("Fasting Glucose Coll Date")] public string fasting_glucose_coll_date { get; set; }
        [JsonProperty("Fasting Glucose Recentresult")] public string fasting_glucose_RecentResult { get; set; }
        [JsonProperty("Random Glucose Coll Date")] public string random_glucose_coll_date { get; set; }
        [JsonProperty("Random Glucose Recentresult")] public string random_glucose_RecentResult { get; set; }
        [JsonProperty("Glucose Tolerance Coll Date")] public string glucose_tolerance_coll_date { get; set; }
        [JsonProperty("Glucose Tolerance Recentresult")] public string glucose_tolerance_RecentResult { get; set; }
        [JsonProperty("Hba1C Coll Date")] public string hba1c_coll_date { get; set; }
        [JsonProperty("Hba1C Recentresult")] public string hba1c_RecentResult { get; set; }
        [JsonProperty("Total Cholesterol Coll Date")] public string total_cholesterol_coll_date { get; set; }
        [JsonProperty("Total Cholesterol Recentresult")] public string total_cholesterol_RecentResult { get; set; }
        [JsonProperty("Triglyceride Coll Date")] public string Triglyceride_coll_date { get; set; }
        [JsonProperty("Triglyceride Recentresult")] public string Triglyceride_RecentResult { get; set; }
        [JsonProperty("Hdl Coll Date")] public string HDL_coll_date { get; set; }
        [JsonProperty("Hdl Recentresult")] public string HDL_RecentResult { get; set; }
        [JsonProperty("Ldl Coll Date")] public string LDL_coll_date { get; set; }
        [JsonProperty("Ldl Recentresult")] public string LDL_RecentResult { get; set; }
        [JsonProperty("Microablumin Coll Date")] public string microablumin_coll_date { get; set; }
        [JsonProperty("Microablumin Recentresult")] public string microablumin_RecentResult { get; set; }
        [JsonProperty("Creatinine Coll Date")] public string creatinine_coll_date { get; set; }
        [JsonProperty("Creatinine Recentresult")] public string creatinine_RecentResult { get; set; }
        [JsonProperty("Urea Coll Date")] public string Urea_coll_date { get; set; }
        [JsonProperty("Urea Recentresult")] public string Urea_RecentResult { get; set; }
        [JsonProperty("Vitamind Coll Date")] public string vitamind_coll_date { get; set; }
        [JsonProperty("Vitamind Recentresult")] public string vitamind_RecentResult { get; set; }
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
        [JsonProperty("Diabetes Family His")] public string diabetes_family_his { get; set; }
        [JsonProperty("Diab Comp Family")] public string diab_comp_family { get; set; }
        [JsonProperty("Obesity Family His")] public string obesity_family_his { get; set; }
        [JsonProperty("Hypertension Family His")] public string hypertension_family_his { get; set; }
        [JsonProperty("Dyslip Family His")] public string dyslip_family_his { get; set; }
        [JsonProperty("Family Pedigree")] public string family_pedigree { get; set; }
        [JsonProperty("Profilepicture")] public string profilePicture { get; set; }
        [JsonProperty("Prescribed Others State 1")] public string prescribed_others_state_1 { get; set; }
        [JsonProperty("Prescribed Others First 1")] public string prescribed_others_first_1 { get; set; }
        [JsonProperty("Prescribed Others Total 1")] public string prescribed_others_total_1 { get; set; }
        [JsonProperty("Prescribed Others Amn 1")] public string prescribed_others_amn_1 { get; set; }
        [JsonProperty("Prescribed Others Freq 1")] public string prescribed_others_freq_1 { get; set; }
        [JsonProperty("Prescribed Others Admin 1")] public string prescribed_others_admin_1 { get; set; }
        [JsonProperty("Prescribed Others State 2")] public string prescribed_others_state_2 { get; set; }
        [JsonProperty("Prescribed Others First 2")] public string prescribed_others_first_2 { get; set; }
        [JsonProperty("Prescribed Others Total 2")] public string prescribed_others_total_2 { get; set; }
        [JsonProperty("Prescribed Others Amn 2")] public string prescribed_others_amn_2 { get; set; }
        [JsonProperty("Prescribed Others Freq 2")] public string prescribed_others_freq_2 { get; set; }
        [JsonProperty("Prescribed Others Admin 2")] public string prescribed_others_admin_2 { get; set; }
        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }

    }
}
