using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace KU.Repositories.Models
{
   // public class QuestionnaireWrap2
    //{
    //    public QuestionnaireWrap2()
    //    {
    //        result = new List<Questionnaire2>();

    //    }
    //    public IEnumerable<Questionnaire2> result { get; set; }

    //}
    public class Questionnaire2
    {
        [Key]
        public string SavedFormID { get; set; }
        public string Depository_ID { get; set; }

        public string Sample { get; set; }

        public string Collected_by { get; set; }

        public string Collected_date { get; set; }

        public string nrc_id { get; set; }

        public string dob { get; set; }

        public string Gender { get; set; }

        public string country { get; set; }

        public string MaritalStatus { get; set; }

        public string PlaceOfBirth { get; set; }

        public string employment_status { get; set; }

        public string employment_status_others { get; set; }

        public string employment_others_text { get; set; }

        public string eduLevel { get; set; }

        public string ethnicity_mixed_specify_text { get; set; }

        public string ethnicity { get; set; }

        public string ethnicity_others_text { get; set; }

        public string inpatient_type { get; set; }

        public string Admission_Status { get; set; }

        public string method_adm { get; set; }

        public string method_adm_others_text { get; set; }

        public string participant_comments { get; set; }

        public string BodyWeight { get; set; }

        public string Height { get; set; }

        public string BodyMass { get; set; }

        public string Waist { get; set; }

        public string BloodPressureSystolic { get; set; }

        public string BloodPressureDiastolic { get; set; }

        public string Walk { get; set; }

        public string Walk_others_Specify { get; set; }

        public string Walk_IfYes { get; set; }

        public string Healthy { get; set; }

        public string SpecifyHealthy { get; set; }

        public string smoking_status { get; set; }

        public string medical_condition { get; set; }

        public string medical_con { get; set; }

        public string asthma_pre { get; set; }

        public string asthma_post { get; set; }

        public string diabetes_circle { get; set; }

        public string diabetes_circle_type { get; set; }

        public string diabetes_pre { get; set; }

        public string diabetes_post { get; set; }

        public string medical_heart { get; set; }

        public string medical_heart_pre { get; set; }

        public string medical_heart_post { get; set; }

        public string medical_high_pressure { get; set; }

        public string medical_high_pressure_pre { get; set; }

        public string medical_high_pressure_post { get; set; }

        public string medical_anemia { get; set; }

        public string medical_anemia_pre { get; set; }

        public string medical_anemia_post { get; set; }

        public string medical_ulcer { get; set; }

        public string medical_ulcer_pre { get; set; }

        public string medical_ulcer_post { get; set; }

        public string medical_cancer { get; set; }

        public string medical_cancer_pre { get; set; }

        public string medical_cancer_post { get; set; }

        public string medical_kidney { get; set; }

        public string medical_kidney_pre { get; set; }

        public string medical_kidney_post { get; set; }

        public string medical_HepatitisCircle { get; set; }

        public string medical_HepatitisCircleType { get; set; }

        public string medical_HepatitisCircle_pre { get; set; }

        public string medical_HepatitisCircle_post { get; set; }

        public string medical_liver { get; set; }

        public string medical_liver_pre { get; set; }

        public string medical_liver_post { get; set; }

        public string medical_Seizures { get; set; }

        public string medical_Seizures_pre { get; set; }

        public string medical_Seizures_post { get; set; }

        public string medical_gastro { get; set; }

        public string medical_gastro_pre { get; set; }

        public string medical_gastro_post { get; set; }

        public string medical_Sinusitis { get; set; }

        public string medical_Sinusitis_pre { get; set; }

        public string medical_Sinusitis_pre_post { get; set; }

        public string medical_cough { get; set; }

        public string medical_cough_pre { get; set; }

        public string medical_cough_post { get; set; }

        public string medical_skin { get; set; }

        public string medical_skin_pre { get; set; }

        public string medical_skin_post { get; set; }

        public string medical_Arthritis { get; set; }

        public string medical_Arthritis_pre { get; set; }

        public string medical_Arthritis_post { get; set; }

        public string medical_hallucination { get; set; }

        public string medical_hallucination_pre { get; set; }

        public string medical_hallucination_post { get; set; }

        public string medical_Depression { get; set; }

        public string medical_Depression_pre { get; set; }

        public string medical_Depression_post { get; set; }

        public string medical_hiv { get; set; }

        public string medical_hiv_pre { get; set; }

        public string medical_hiv_post { get; set; }

        public string medical_others { get; set; }

        public string medical_others_specify { get; set; }

        public string medical_others_pre { get; set; }

        public string medical_others_post { get; set; }

        public string allergies { get; set; }

        public string all_specify { get; set; }

        public string intolerance { get; set; }

        public string intolerance_specify { get; set; }

        public string dependence_weight { get; set; }

        public string reason_weight { get; set; }

        public string surgery { get; set; }

        public string ind_specify { get; set; }

        public string where_specify { get; set; }

        public string Reasaon_specify { get; set; }

        public string medical_pain { get; set; }

        public string when_specify { get; set; }

        public string source_specify { get; set; }

        public string medic_specify { get; set; }

        public string dur_specify { get; set; }

        public string medic_treatment { get; set; }

        public string medic_treat_specify { get; set; }

        public string substance { get; set; }

        public string medhadone_used { get; set; }

        public string methadone_symoron { get; set; }

        public string methadone_dolophine { get; set; }

        public string methadone_amidone { get; set; }

        public string methadone_physeptone { get; set; }

        public string methadone_heptadon { get; set; }

        public string methadone_methadose { get; set; }

        public string methadone_disket { get; set; }

        public string methadone_symoron_first { get; set; }

        public string methadone_dolophine_first { get; set; }

        public string methadone_amidone_first { get; set; }

        public string methadone_physeptone_first { get; set; }

        public string methadone_heptadon_first { get; set; }

        public string methadone_methadose_first { get; set; }

        public string methadone_disket_first { get; set; }

        public string methadone_symoron_total { get; set; }

        public string methadone_dolophine_total { get; set; }

        public string methadone_amidone_total { get; set; }

        public string methadone_physeptone_total { get; set; }

        public string methadone_heptadon_total { get; set; }

        public string methadone_methadose_total { get; set; }

        public string methadone_disket_total { get; set; }

        public string methadone_symoron_amn { get; set; }

        public string methadone_dolophine_amn { get; set; }

        public string methadone_amidone_amn { get; set; }

        public string methadone_physeptone_amn { get; set; }

        public string methadone_heptadon_amn { get; set; }

        public string methadone_methadose_amn { get; set; }

        public string methadone_disket_amn { get; set; }

        public string methadone_symoron_freq { get; set; }

        public string methadone_dolophine_freq { get; set; }

        public string methadone_amidone_freq { get; set; }

        public string methadone_physeptone_freq { get; set; }

        public string methadone_heptadon_freq { get; set; }
        public string methadone_methadose_freq { get; set; }
        public string methadone_disket_freq { get; set; }
        public string methadone_symoron_admin { get; set; }
        public string methadone_dolophine_admin { get; set; }
        public string methadone_amidone_admin { get; set; }
        public string methadone_physeptone_admin { get; set; }
        public string methadone_heptadon_admin { get; set; }
        public string methadone_methadose_admin { get; set; }
        public string methadone_disket_admin { get; set; }
        public string Buprenorphine_used { get; set; }
        public string prescribed_subutex { get; set; }
        public string prescribed_suboxone { get; set; }
        public string prescribed_buprenex { get; set; }
        public string prescribed_subutex_first { get; set; }
        public string prescribed_suboxone_first { get; set; }
        public string prescribed_buprenex_first { get; set; }
        public string prescribed_subutex_total { get; set; }

        public string prescribed_suboxone_total { get; set; }

        public string prescribed_buprenex_total { get; set; }
        public string prescribed_subutex_amn { get; set; }
        public string prescribed_suboxone_amn { get; set; }
        public string prescribed_buprenex_amn { get; set; }
        public string prescribed_subutex_freq { get; set; }
        public string prescribed_suboxone_freq { get; set; }
        public string prescribed_buprenex_freq { get; set; }
        public string prescribed_subutex_admin { get; set; }
        public string prescribed_suboxone_admin { get; set; }
        public string prescribed_buprenex_admin { get; set; }
        public string Opiates_used { get; set; }
        public string opiates_heroin { get; set; }
        public string opiates_heroin_first { get; set; }
        public string opiates_heroin_total { get; set; }
        public string opiates_heroin_amn { get; set; }
        public string opiates_heroin_freq { get; set; }
        public string opiates_heroin_admin { get; set; }
        public string opiates_morphine { get; set; }
        public string opiates_morphine_first { get; set; }
        public string opiates_morphine_total { get; set; }
        public string opiates_morphine_amn { get; set; }
        public string opiates_morphine_freq { get; set; }
        public string opiates_morphine_admin { get; set; }
        public string opiates_codine { get; set; }
        public string opiates_codine_first { get; set; }
        public string opiates_codine_total { get; set; }
        public string opiates_codine_amn { get; set; }
        public string opiates_codine_freq { get; set; }
        public string opiates_codine_admin { get; set; }
        public string opiates_oxycodon { get; set; }
        public string opiates_oxycodon_first { get; set; }
        public string opiates_oxycodon_total { get; set; }
        public string opiates_oxycodon_amn { get; set; }
        public string opiates_oxycodon_freq { get; set; }
        public string opiates_oxycodon_admin { get; set; }
        public string opiates_oxymorphon { get; set; }
        public string opiates_oxymorphon_first { get; set; }
        public string opiates_oxymorphon_total { get; set; }
        public string opiates_oxymorphon_amn { get; set; }
        public string opiates_oxymorphon_freq { get; set; }
        public string opiates_oxymorphon_admin { get; set; }
        public string opiates_hydrocodon { get; set; }
        public string opiates_hydrocodon_first { get; set; }
        public string opiates_hydrocodon_total { get; set; }
        public string opiates_hydrocodon_amn { get; set; }
        public string opiates_hydrocodon_freq { get; set; }
        public string opiates_hydrocodon_admin { get; set; }
        public string opiates_hydromorphon { get; set; }
        public string opiates_hydromorphon_first { get; set; }
        public string opiates_hydromorphon_total { get; set; }
        public string opiates_hydromorphon_amn { get; set; }
        public string opiates_hydromorphon_freq { get; set; }
        public string opiates_hydromorphon_admin { get; set; }
        public string opiates_tramadol { get; set; }
        public string opiates_tramadol_first { get; set; }

        public string opiates_tramadol_total { get; set; }
        public string opiates_tramadol_amn { get; set; }
        public string opiates_tramadol_freq { get; set; }
        public string opiates_tramadol_admin { get; set; }
        public string tranquilizers_used { get; set; }
        public string tranquilizers_valium { get; set; }
        public string tranquilizers_valium_first { get; set; }
        public string tranquilizers_valium_total { get; set; }
        public string tranquilizers_valium_amn { get; set; }
        public string tranquilizers_valium_freq { get; set; }
        public string tranquilizers_valium_admin { get; set; }
        public string tranquilizers_librium { get; set; }
        public string tranquilizers_librium_first { get; set; }
        public string tranquilizers_librium_total { get; set; }
        public string tranquilizers_librium_amn { get; set; }
        public string tranquilizers_librium_freq { get; set; }
        public string tranquilizers_librium_admin { get; set; }
        public string tranquilizers_halcion { get; set; }
        public string tranquilizers_halcion_first { get; set; }
        public string tranquilizers_halcion_total { get; set; }
        public string tranquilizers_halcion_amn { get; set; }
        public string tranquilizers_halcion_freq { get; set; }
        public string tranquilizers_halcion_admin { get; set; }
        public string tranquilizers_prosom { get; set; }
        public string tranquilizers_prosom_first { get; set; }
        public string tranquilizers_prosom_total { get; set; }
        public string tranquilizers_prosom_amn { get; set; }
        public string tranquilizers_prosom_freq { get; set; }
        public string tranquilizers_prosom_admin { get; set; }
        public string tranquilizers_xanax { get; set; }
        public string tranquilizers_xanax_first { get; set; }
        public string tranquilizers_xanax_total { get; set; }
        public string tranquilizers_xanax_amn { get; set; }
        public string tranquilizers_xanax_freq { get; set; }
        public string tranquilizers_xanax_admin { get; set; }
        public string tranquilizers_ativan { get; set; }
        public string tranquilizers_ativan_first { get; set; }
        public string tranquilizers_ativan_total { get; set; }
        public string tranquilizers_ativan_amn { get; set; }
        public string tranquilizers_ativan_freq { get; set; }
        public string tranquilizers_ativan_admin { get; set; }
        public string tranquilizers_klonopin { get; set; }
        public string tranquilizers_klonopin_first { get; set; }
        public string tranquilizers_klonopin_total { get; set; }
        public string tranquilizers_klonopin_amn { get; set; }
        public string tranquilizers_klonopin_freq { get; set; }
        public string tranquilizers_klonopin_admin { get; set; }
        public string tranquilizers_restoril { get; set; }
        public string tranquilizers_restoril_first { get; set; }
        public string tranquilizers_restoril_total { get; set; }
        public string tranquilizers_restoril_amn { get; set; }
        public string tranquilizers_restoril_freq { get; set; }
        public string tranquilizers_restoril_admin { get; set; }
        public string tranquilizers_rohypnol { get; set; }
        public string tranquilizers_rohypnol_first { get; set; }
        public string tranquilizers_rohypnol_total { get; set; }
        public string tranquilizers_rohypnol_amn { get; set; }
        public string tranquilizers_rohypnol_freq { get; set; }
        public string tranquilizers_rohypnol_admin { get; set; }
        public string tranquilizers_dalmane { get; set; }
        public string tranquilizers_dalmane_first { get; set; }
        public string tranquilizers_dalmane_total { get; set; }
        public string tranquilizers_dalmane_amn { get; set; }
        public string tranquilizers_dalmane_freq { get; set; }
        public string tranquilizers_dalmane_admin { get; set; }
        public string tranquilizers_imovane { get; set; }
        public string tranquilizers_imovane_first { get; set; }
        public string tranquilizers_imovane_total { get; set; }
        public string tranquilizers_imovane_amn { get; set; }
        public string tranquilizers_imovane_freq { get; set; }
        public string tranquilizers_imovane_admin { get; set; }
        public string tranquilizers_ambien { get; set; }
        public string tranquilizers_ambien_first { get; set; }
        public string tranquilizers_ambien_total { get; set; }
        public string tranquilizers_ambien_amn { get; set; }
        public string tranquilizers_ambien_freq { get; set; }
        public string tranquilizers_ambien_admin { get; set; }
        public string tranquilizers_lunesta { get; set; }
        public string tranquilizers_lunesta_first { get; set; }
        public string tranquilizers_lunesta_total { get; set; }
        public string tranquilizers_lunesta_amn { get; set; }
        public string tranquilizers_lunesta_freq { get; set; }
        public string tranquilizers_lunesta_admin { get; set; }
        public string tranquilizers_others { get; set; }
        public string tranquilizers_others_first { get; set; }
        public string tranquilizers_others_total { get; set; }
        public string tranquilizers_others_amn { get; set; }
        public string tranquilizers_others_freq { get; set; }
        public string tranquilizers_others_admin { get; set; }
        public string Cannabis_used { get; set; }
        public string Cannabis_marijuana { get; set; }
        public string Cannabis_hashish { get; set; }
        public string Cannabis_dope { get; set; }
        public string Cannabis_synthetic { get; set; }
        public string Cannabis_marijuana_first { get; set; }
        public string Cannabis_hashish_first { get; set; }
        public string Cannabis_dope_first { get; set; }
        public string Cannabis_synthetic_first { get; set; }
        public string Cannabis_marijuana_total { get; set; }
        public string Cannabis_hashish_total { get; set; }
        public string Cannabis_dope_total { get; set; }
        public string Cannabis_synthetic_total { get; set; }
        public string Cannabis_marijuana_amn { get; set; }
        public string Cannabis_hashish_amn { get; set; }
        public string Cannabis_dope_amn { get; set; }
        public string Cannabis_synthetic_amn { get; set; }
        public string Cannabis_marijuana_freq { get; set; }
        public string Cannabis_hashish_freq { get; set; }
        public string Cannabis_dope_freq { get; set; }
        public string Cannabis_synthetic_freq { get; set; }
        public string Cannabis_marijuana_admin { get; set; }
        public string Cannabis_hashish_admin { get; set; }
        public string Cannabis_dope_admin { get; set; }
        public string Cannabis_synthetic_admin { get; set; }
        public string amphetamines_used { get; set; }
        public string amphetamines_amphetamine { get; set; }
        public string amphetamines_amphetamine_first { get; set; }
        public string amphetamines_amphetamine_total { get; set; }
        public string amphetamines_amphetamine_amn { get; set; }
        public string amphetamines_amphetamine_freq { get; set; }
        public string amphetamines_amphetamine_admin { get; set; }
        public string amphetamines_methamphetamine_crystal { get; set; }
        public string amphetamines_methamphetamine_crystal_first { get; set; }
        public string amphetamines_methamphetamine_crystal_total { get; set; }
        public string amphetamines_methamphetamine_crystal_amn { get; set; }
        public string amphetamines_methamphetamine_crystal_freq { get; set; }
        public string amphetamines_methamphetamine_crystal_admin { get; set; }
        public string amphetamines_methamphetamine_hcl { get; set; }
        public string amphetamines_methamphetamine_hcl_first { get; set; }
        public string amphetamines_methamphetamine_hcl_total { get; set; }
        public string amphetamines_methamphetamine_hcl_amn { get; set; }
        public string amphetamines_methamphetamine_hcl_freq { get; set; }
        public string amphetamines_methamphetamine_hcl_admin { get; set; }
        public string amphetamines_dextroamphetamine { get; set; }
        public string amphetamines_dextroamphetamine_first { get; set; }
        public string amphetamines_dextroamphetamine_total { get; set; }
        public string amphetamines_dextroamphetamine_amn { get; set; }
        public string amphetamines_dextroamphetamine_freq { get; set; }
        public string amphetamines_dextroamphetamine_admin { get; set; }
        public string amphetamines_mdma { get; set; }
        public string amphetamines_mdma_first { get; set; }
        public string amphetamines_mdma_total { get; set; }
        public string amphetamines_mdma_amn { get; set; }
        public string amphetamines_mdma_freq { get; set; }
        public string amphetamines_mdma_admin { get; set; }
        public string cocaine_used { get; set; }
        public string cocaine_coke { get; set; }
        public string cocaine_crack { get; set; }
        public string cocaine_snow { get; set; }
        public string cocaine_coke_first { get; set; }
        public string cocaine_crack_first { get; set; }
        public string cocaine_snow_first { get; set; }
        public string cocaine_coke_total { get; set; }
        public string cocaine_crack_total { get; set; }
        public string cocaine_snow_total { get; set; }
        public string cocaine_coke_amn { get; set; }
        public string cocaine_crack_amn { get; set; }
        public string cocaine_snow_amn { get; set; }
        public string cocaine_coke_freq { get; set; }
        public string cocaine_crack_freq { get; set; }
        public string cocaine_snow_freq { get; set; }
        public string cocaine_coke_admin { get; set; }
        public string cocaine_crack_admin { get; set; }
        public string cocaine_snow_admin { get; set; }
        public string Hallucinogens_used { get; set; }
        public string hallucinogens_lsd { get; set; }
        public string hallucinogens_mushroom { get; set; }
        public string hallucinogens_lsd_first { get; set; }
        public string hallucinogens_mushroom_first { get; set; }
        public string hallucinogens_lsd_total { get; set; }
        public string hallucinogens_mushroom_total { get; set; }
        public string hallucinogens_lsd_amn { get; set; }
        public string hallucinogens_mushroom_amn { get; set; }
        public string hallucinogens_lsd_freq { get; set; }
        public string hallucinogens_mushroom_freq { get; set; }
        public string hallucinogens_lsd_admin { get; set; }
        public string hallucinogens_mushroom_admin { get; set; }
        public string Inhalants_used { get; set; }
        public string Inhalants_petrolume { get; set; }
        public string Inhalants_petrolume_first { get; set; }
        public string Inhalants_petrolume_total { get; set; }
        public string Inhalants_petrolume_amn { get; set; }
        public string Inhalants_petrolume_freq { get; set; }
        public string Inhalants_petrolume_admin { get; set; }
        public string Inhalants_toulene { get; set; }
        public string Inhalants_toulene_first { get; set; }
        public string Inhalants_toulene_total { get; set; }
        public string Inhalants_toulene_amn { get; set; }
        public string Inhalants_toulene_freq { get; set; }
        public string Inhalants_toulene_admin { get; set; }
        public string Inhalants_acetone { get; set; }
        public string Inhalants_acetone_first { get; set; }
        public string Inhalants_acetone_total { get; set; }
        public string Inhalants_acetone_amn { get; set; }
        public string Inhalants_acetone_freq { get; set; }
        public string Inhalants_acetone_admin { get; set; }
        public string Inhalants_aerosols { get; set; }
        public string Inhalants_aerosols_first { get; set; }
        public string Inhalants_aerosols_total { get; set; }
        public string Inhalants_aerosols_amn { get; set; }
        public string Inhalants_aerosols_freq { get; set; }
        public string Inhalants_aerosols_admin { get; set; }
        public string Inhalants_nitrites { get; set; }
        public string Inhalants_nitrites_first { get; set; }
        public string Inhalants_nitrites_total { get; set; }
        public string Inhalants_nitrites_amn { get; set; }
        public string Inhalants_nitrites_freq { get; set; }
        public string Inhalants_nitrites_admin { get; set; }
        public string Barbiturates_used { get; set; }
        public string Barbiturates_Amobarbital { get; set; }
        public string Barbiturates_Amobarbital_first { get; set; }
        public string Barbiturates_Amobarbital_total { get; set; }
        public string Barbiturates_Amobarbital_amn { get; set; }
        public string Barbiturates_Amobarbital_freq { get; set; }
        public string Barbiturates_Amobarbital_admin { get; set; }
        public string Barbiturates_pentobarbital { get; set; }
        public string Barbiturates_pentobarbital_first { get; set; }
        public string Barbiturates_pentobarbital_total { get; set; }
        public string Barbiturates_pentobarbital_amn { get; set; }
        public string Barbiturates_pentobarbital_freq { get; set; }
        public string Barbiturates_pentobarbital_admin { get; set; }
        public string Barbiturates_nembutal { get; set; }
        public string Barbiturates_nembutal_first { get; set; }
        public string Barbiturates_nembutal_total { get; set; }
        public string Barbiturates_nembutal_amn { get; set; }
        public string Barbiturates_nembutal_freq { get; set; }
        public string Barbiturates_nembutal_admin { get; set; }
        public string alcohol_used { get; set; }
        public string alcohol_beer { get; set; }
        public string alcohol_wiseky { get; set; }
        public string alcohol_vodka { get; set; }
        public string alcohol_tequila { get; set; }
        public string alcohol_gin { get; set; }
        public string alcohol_rum { get; set; }
        public string alcohol_wines { get; set; }
        public string alcohol_beer_first { get; set; }
        public string alcohol_wiseky_first { get; set; }
        public string alcohol_vodka_first { get; set; }
        public string alcohol_tequila_first { get; set; }
        public string alcohol_gin_first { get; set; }
        public string alcohol_rum_first { get; set; }
        public string alcohol_wines_first { get; set; }
        public string alcohol_beer_total { get; set; }
        public string alcohol_wiseky_total { get; set; }
        public string alcohol_vodka_total { get; set; }
        public string alcohol_tequila_total { get; set; }
        public string alcohol_gin_total { get; set; }
        public string alcohol_rum_total { get; set; }
        public string alcohol_wines_total { get; set; }
        public string alcohol_beer_amn { get; set; }
        public string alcohol_wiseky_amn { get; set; }
        public string alcohol_vodka_amn { get; set; }
        public string alcohol_tequila_amn { get; set; }
        public string alcohol_gin_amn { get; set; }
        public string alcohol_rum_amn { get; set; }
        public string alcohol_wines_amn { get; set; }
        public string alcohol_beer_freq { get; set; }
        public string alcohol_wiseky_freq { get; set; }
        public string alcohol_vodka_freq { get; set; }
        public string alcohol_tequila_freq { get; set; }
        public string alcohol_gin_freq { get; set; }
        public string alcohol_rum_freq { get; set; }
        public string alcohol_wines_freq { get; set; }
        public string alcohol_beer_admin { get; set; }
        public string alcohol_wiseky_admin { get; set; }
        public string alcohol_vodka_admin { get; set; }
        public string alcohol_tequila_admin { get; set; }
        public string alcohol_gin_admin { get; set; }
        public string alcohol_rum_admin { get; set; }
        public string alcohol_wines_admin { get; set; }
        public string tobacco_used { get; set; }
        public string tobacco_cigarette { get; set; }
        public string tobacco_cigar { get; set; }
        public string tobacco_midwakh { get; set; }
        public string tobacco_shisha { get; set; }
        public string tobacco_cigarette_first { get; set; }
        public string tobacco_cigar_first { get; set; }
        public string tobacco_midwakh_first { get; set; }
        public string tobacco_shisha_first { get; set; }
        public string tobacco_cigarette_total { get; set; }
        public string tobacco_cigar_total { get; set; }
        public string tobacco_midwakh_total { get; set; }
        public string tobacco_shisha_total { get; set; }
        public string tobacco_cigarette_amn { get; set; }
        public string tobacco_cigar_amn { get; set; }
        public string tobacco_midwakh_amn { get; set; }
        public string tobacco_shisha_amn { get; set; }
        public string tobacco_cigarette_freq { get; set; }
        public string tobacco_cigar_freq { get; set; }
        public string tobacco_midwakh_freq { get; set; }
        public string tobacco_shisha_freq { get; set; }
        public string tobacco_cigarette_admin { get; set; }
        public string tobacco_cigar_admin { get; set; }
        public string tobacco_midwakh_admin { get; set; }
        public string tobacco_shisha_admin { get; set; }
        public string substance_dependence_his_others { get; set; }
        public string prescribed_others_state { get; set; }
        public string prescribed_others_first { get; set; }
        public string prescribed_others_total { get; set; }
        public string prescribed_others_amn { get; set; }
        public string prescribed_others_freq { get; set; }
        public string prescribed_others_admin { get; set; }
        public string sub_symptoms_seizures { get; set; }
        public string sub_symptoms_blackout { get; set; }
        public string sub_symptoms_hallucination { get; set; }
        public string sub_symptoms_chest_pain { get; set; }
        public string sub_symptoms_sleep_dis { get; set; }
        public string sub_symptoms_anxiety { get; set; }
        public string sub_symptoms_nausea { get; set; }
        public string sub_symptoms_Diarrhea { get; set; }
        public string sub_symptoms_eating_problem { get; set; }
        public string sub_symptoms_fatigue { get; set; }
        public string sub_symptoms_overdose { get; set; }
        public string sub_symptoms_headache { get; set; }
        public string sub_symptoms_dizziness { get; set; }
        public string sub_symptoms_paranoid { get; set; }
        public string sub_symptoms_palpitation { get; set; }
        public string sub_symptoms_uncontrollable { get; set; }
        public string sub_symptoms_hyperactive { get; set; }
        public string sub_symptoms_vomitting { get; set; }
        public string sub_symptoms_constipation { get; set; }
        public string sub_symptoms_urinating { get; set; }
        public string sub_symptoms_irritability { get; set; }
        public string sub_symptoms_others { get; set; }
        public string sub_symptoms_others_text { get; set; }
        public string substance_diagnosed { get; set; }
        public string drug_dosage { get; set; }
        public string sub_time_frame { get; set; }
        public string drug_sibling { get; set; }
        public string sib_drug { get; set; }
        public string drug_mother { get; set; }
        public string mother_drug { get; set; }
        public string drug_father { get; set; }
        public string father_drug { get; set; }
        public string drug_others_his { get; set; }
        public string others_drug { get; set; }
        public string medic_sib { get; set; }
        public string medic_drug { get; set; }
        public string medic_mother { get; set; }
        public string medic_mother_drug { get; set; }
        public string medic_father { get; set; }
        public string medic_father_drug { get; set; }
        public string medic_others_his { get; set; }
        public string medic_others_drug { get; set; }
        public string completed_fam { get; set; }
        public string completed_fam_reason { get; set; }
        public string completed_fam_reason_other { get; set; }
        public string addiction_treatment { get; set; }
        public string sub_treat_prescribed_times { get; set; }
        public string sub_treat_prescribed_star { get; set; }
        public string sub_treat_prescribed_finis { get; set; }
        public string sub_treat_prescribed_encoun { get; set; }
        public string sub_treat_prescribed_Naltrexone_times { get; set; }
        public string sub_treat_prescribed_Naltrexone_star { get; set; }
        public string sub_treat_prescribed_Naltrexone_finis { get; set; }
        public string sub_treat_prescribed_Naltrexone_encoun { get; set; }
        public string sub_treat_prescribed_Buprenorphine_times { get; set; }
        public string sub_treat_prescribed_Buprenorphine_star { get; set; }
        public string sub_treat_prescribed_Buprenorphine_finis { get; set; }
        public string sub_treat_prescribed_Buprenorphine_encoun { get; set; }
        public string sub_treat_prescribed_Inpatient_times { get; set; }
        public string sub_treat_prescribed_Inpatient_star { get; set; }
        public string sub_treat_prescribed_Inpatient_finis { get; set; }
        public string sub_treat_prescribed_Inpatient_encoun { get; set; }
        public string sub_treat_prescribed_rehab_times { get; set; }
        public string sub_treat_prescribed_rehab_star { get; set; }
        public string sub_treat_prescribed_rehab_finis { get; set; }
        public string sub_treat_prescribed_rehab_encoun { get; set; }
        public string sub_treat_prescribed_outpatient_detox_times { get; set; }
        public string sub_treat_prescribed_outpatient_detox_star { get; set; }
        public string sub_treat_prescribed_outpatient_detox_finis { get; set; }
        public string sub_treat_prescribed_outpatient_detox_encoun { get; set; }
        public string sub_treat_prescribed_outpatient_counselling_times { get; set; }
        public string sub_treat_prescribed_outpatient_counselling_star { get; set; }
        public string sub_treat_prescribed_outpatient_counselling_finis { get; set; }
        public string sub_treat_prescribed_outpatient_counselling_encoun { get; set; }
        public string sub_treat_prescribed_self_help_group_times { get; set; }
        public string sub_treat_prescribed_self_help_group_star { get; set; }
        public string sub_treat_prescribed_self_help_group_finis { get; set; }
        public string sub_treat_prescribed_self_help_group_encoun { get; set; }
        public string sub_treatment_completed { get; set; }
        public string sub_treatment_recent_specify { get; set; }
        public string sub_treatment_relapse { get; set; }
        public string sub_treatment_relapse_specify { get; set; }
        public string relapse_period { get; set; }
        public string current_treat_readiness { get; set; }
        public string risk_of_relapse { get; set; }
        public string risk_of_relapse_specify { get; set; }
        public string opiate_methadon { get; set; }
        public string opiate_methadon_text { get; set; }
        public string opiate_Clonide { get; set; }
        public string opiate_Clonide_text { get; set; }
        public string opiate_Bupemorphine { get; set; }
        public string opiate_Bupemorphine_text { get; set; }
        public string opiate_suboxon { get; set; }
        public string opiate_suboxon_text { get; set; }
        public string opiate_Naloxon { get; set; }
        public string opiate_Naloxon_text { get; set; }
        public string opiate_Naltrexon { get; set; }
        public string opiate_Naltrexon_text { get; set; }
        public string opiate_Naltrexon_xr { get; set; }
        public string opiate_Naltrexon_xr_text { get; set; }
        public string opiate_LOFex { get; set; }
        public string opiate_LOFex_text { get; set; }
        public string opiate_others { get; set; }
        public string opiate_others_specify { get; set; }
        public string opiate_others_text { get; set; }
        public string alcohol_acamprosate { get; set; }
        public string alcohol_acamprosate_text { get; set; }
        public string alcohol_disulfirm { get; set; }
        public string alcohol_disulfirm_text { get; set; }
        public string alcohol_naltrexon { get; set; }
        public string alcohol_naltrexon_text { get; set; }
        public string alcohol_naltrexon_xr { get; set; }
        public string alcohol_naltrexon_xr_text { get; set; }
        public string Benzodiazphine_flumazenil { get; set; }
        public string Benzodiazphine_flumazenil_text { get; set; }
        public string Benzodiazphine_others { get; set; }
        public string Benzodiazphine_others_specify { get; set; }
        public string Benzodiazphine_others_text { get; set; }
        public string nicotine_vaenicline { get; set; }
        public string nicotine_vaenicline_text { get; set; }
        public string nicotine_bupropion { get; set; }
        public string nicotine_bupropion_text { get; set; }
        public string nicotine_nicotinnell { get; set; }
        public string nicotine_nicotinnell_text { get; set; }
        public string nicotine_nicotinnell_gum { get; set; }
        public string nicotine_nicotinnell_gum_text { get; set; }
        public string other_medic_antipsycotic { get; set; }
        public string other_medic_Antipsycotic_abilify_text { get; set; }
        public string other_medic_Antipsycotic_zebraxa_text { get; set; }
        public string other_medic_Antipsycotic_seriquol_text { get; set; }
        public string other_medic_Antipsycotic_risperdal_text { get; set; }
        public string other_medic_Antipsycotic_ziprasidone_text { get; set; }
        public string other_medic_Antipsycotic_haldol_text { get; set; }
        public string other_medic_Antipsycotic_zuclopenthixol_text { get; set; }
        public string other_medic_Antipsycotic_others_text { get; set; }
        public string other_medic_Antidepressants { get; set; }
        public string other_medic_Antidepressants_amitryptyline_text { get; set; }
        public string other_medic_Antidepressants_clomiparamine_text { get; set; }
        public string other_medic_Antidepressants_fluxetine_text { get; set; }
        public string other_medic_Antidepressants_effexor_text { get; set; }
        public string other_medic_Antidepressants_seroxate_text { get; set; }
        public string other_medic_Antidepressants_escitalopram_text { get; set; }
        public string other_medic_Antidepressants_sertraline_text { get; set; }
        public string other_medic_Antidepressants_mirtazapine_text { get; set; }
        public string other_medic_Antidepressants_bupropion_text { get; set; }
        public string other_medic_Antidepressants_others_text { get; set; }
        public string other_medic_Antidepressants_others_dose { get; set; }
        public string other_medic_central_nervous { get; set; }
        public string other_medic_central_nervous_text { get; set; }
        public string other_medic_hypnotic_anxiolytics { get; set; }
        public string other_medic_hypnotic_anxiolytics_imovane_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_diazepam_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_librium_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_buspar_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_alprazolam_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_lorazepam_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_hydroxyzine_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_others_text { get; set; }
        public string other_medic_hypnotic_anxiolytics_others_dose { get; set; }
        public string other_medic_Antiepileptics { get; set; }
        public string other_medic_hypnotic_antiepileptics_carbamazepine_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_klonopin_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_gabapentin_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_lamotrigine_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_topamax_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_dilantin_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_epilim_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_others_text { get; set; }
        public string other_medic_hypnotic_antiepileptics_others_dose { get; set; }
        public string out_patient_healthy_diet { get; set; }
        public string follow_up_session_specify { get; set; }
        public string out_patient_treatment_response { get; set; }
        public string att_treat_how_long { get; set; }
        public string att_treat_number_ses { get; set; }
        public string att_treat { get; set; }
        public string att_treat_how_many { get; set; }
        public string test_sample_collected { get; set; }
        public string test_sample_collected_spec { get; set; }
        public string amphetamines { get; set; }
        public string amphetamines_com { get; set; }
        public string barbiturates { get; set; }
        public string barbiturates_com { get; set; }
        public string test_benzodiazepines { get; set; }
        public string test_benzodiazepines_com { get; set; }
        public string test_cannainoids { get; set; }
        public string test_cannainoids_com { get; set; }
        public string test_cocaine { get; set; }
        public string test_cocaine_com { get; set; }
        public string test_methadone { get; set; }
        public string test_methadone_com { get; set; }
        public string test_phencyclidine { get; set; }
        public string test_phencyclidine_com { get; set; }
        public string test_propxyphene { get; set; }
        public string test_propxyphene_com { get; set; }
        public string test_opiate { get; set; }
        public string test_opiate_com { get; set; }
        public string test_target_drug_others_text { get; set; }
        public string test_target_drug_others { get; set; }
        public string test_target_drug_others_com { get; set; }
        public string diabetesMellitus { get; set; }
        public string diabetic { get; set; }
        public string age { get; set; }
        public string dyslipidemia { get; set; }
        public string diabetes_com { get; set; }
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
        public string fasting_glucose_coll_date { get; set; }
        public string fasting_glucose_RecentResult { get; set; }
        public string random_glucose_coll_date { get; set; }
        public string random_glucose_RecentResult { get; set; }
        public string glucose_tolerance_coll_date { get; set; }
        public string glucose_tolerance_RecentResult { get; set; }
        public string hba1c_coll_date { get; set; }
        public string hba1c_RecentResult { get; set; }
        public string total_cholesterol_coll_date { get; set; }
        public string total_cholesterol_RecentResult { get; set; }
        public string Triglyceride_coll_date { get; set; }
        public string Triglyceride_RecentResult { get; set; }
        public string HDL_coll_date { get; set; }
        public string HDL_RecentResult { get; set; }
        public string LDL_coll_date { get; set; }
        public string LDL_RecentResult { get; set; }
        public string microablumin_coll_date { get; set; }
        public string microablumin_RecentResult { get; set; }
        public string creatinine_coll_date { get; set; }
        public string creatinine_RecentResult { get; set; }
        public string Urea_coll_date { get; set; }
        public string Urea_RecentResult { get; set; }
        public string vitamind_coll_date { get; set; }
        public string vitamind_RecentResult { get; set; }
        public string inhibit_ace { get; set; }
        public string perindop { get; set; }
        public string captopril { get; set; }
        public string enalapril { get; set; }
        public string lisinop { get; set; }
        public string medications_others { get; set; }
        public string anti_hyper_arbs { get; set; }
        public string losartan { get; set; }
        public string Valsartan { get; set; }
        public string anti_dose { get; set; }
        public string beta_blockers { get; set; }
        public string atenolol { get; set; }
        public string bisopr { get; set; }
        public string beta_other_dose { get; set; }
        public string diurectics { get; set; }
        public string indapam { get; set; }
        public string hydroch { get; set; }
        public string fruse { get; set; }
        public string diur_others_dose { get; set; }
        public string CA_channel_blockers { get; set; }
        public string amlodip { get; set; }
        public string nifedip { get; set; }
        public string verapamil { get; set; }
        public string ca_channer_others { get; set; }
        public string others_oh { get; set; }
        public string methyldop { get; set; }
        public string anti_hyper_others_dose { get; set; }
        public string Anti_Dyslipidemia_statins { get; set; }
        public string simvast { get; set; }
        public string atorvast { get; set; }
        public string rosuvas { get; set; }
        public string Anti_Dyslipidemia_OtherD { get; set; }
        public string Anti_Dyslipidemia_fibrates { get; set; }
        public string gemfib { get; set; }
        public string fenofib { get; set; }
        public string fibrat1 { get; set; }
        public string fibrat2 { get; set; }
        public string Anti_Dyslipidemia_others { get; set; }
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
        public string pioglit { get; set; }
        public string anti_hyper_thiazolid_Other { get; set; }
        public string anti_hyper_meglitin { get; set; }
        public string anti_hyper_Nateglinide { get; set; }
        public string anti_hyper_repaglin { get; set; }
        public string anti_hyper_glucosid { get; set; }
        public string acarbose { get; set; }
        public string anti_hyper_dipeptidyl { get; set; }
        public string anti_hyper_sitaglip { get; set; }
        public string anti_hyper_vildaglip { get; set; }
        public string anti_hyper_saxaglip { get; set; }
        public string anti_hyper_linaglip { get; set; }
        public string anti_hyper_peptid_others { get; set; }
        public string pramlintide { get; set; }
        public string anti_hyper_other_peptid { get; set; }
        public string anti_hyper_incretinm { get; set; }
        public string anti_hyper_exenatide { get; set; }
        public string anti_hyper_liraglut { get; set; }
        public string exenatide_dose { get; set; }
        public string anti_hyper_insulin_lin { get; set; }
        public string lispro_dose { get; set; }
        public string aspart_dose { get; set; }
        public string glulisine_dose { get; set; }
        public string regular_dose { get; set; }
        public string nph_dose { get; set; }
        public string Detemir_Dose { get; set; }
        public string glargine { get; set; }
        public string anti_hyper_insulin_lin_combination { get; set; }
        public string suplements_vitamind3 { get; set; }
        public string suplements_OtherVit { get; set; }
        public string diabetes_family_his { get; set; }
        public string diab_comp_family { get; set; }
        public string obesity_family_his { get; set; }
        public string hypertension_family_his { get; set; }
        public string dyslip_family_his { get; set; }
        public string family_pedigree { get; set; }
        public string profilePicture { get; set; }
        public string prescribed_others_state_1 { get; set; }
        public string prescribed_others_first_1 { get; set; }
        public string prescribed_others_total_1 { get; set; }
        public string prescribed_others_amn_1 { get; set; }
        public string prescribed_others_freq_1 { get; set; }
        public string prescribed_others_admin_1 { get; set; }
        public string prescribed_others_state_2 { get; set; }
        public string prescribed_others_first_2 { get; set; }
        public string prescribed_others_total_2 { get; set; }
        public string prescribed_others_amn_2 { get; set; }
        public string prescribed_others_freq_2 { get; set; }
        public string prescribed_others_admin_2 { get; set; }
    }
}
