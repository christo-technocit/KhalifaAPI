
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;


namespace KU.Repositories.Models
{
   
    //public class QuestionnaireWrap3
    //{
        
    //    public QuestionnaireWrap3()
    //    {
    //        result = new List<Questionnaire3>();

    //    }
    //    public IEnumerable<Questionnaire3> result { get; set; }

    //}


    public class Questionnaire3
    {

        // [ScaffoldColumn(true)]
        [Key]
        public string SavedFormID { get; set; }
        public string Depository_ID { get; set; }
        public string Sample { get; set; }
        public string collected_date { get; set; }
        public string Collected_Center { get; set; }
        public string staff_name { get; set; }
        public string staff_id { get; set; }
        public string birth_date { get; set; }
        public string birth_place { get; set; }
        public string country { get; set; }
        public string Mobile_no { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Consanguineous_Marriage { get; set; }
        public string NoOfWives { get; set; }
        public string NoOfChildren { get; set; }
        public string Address { get; set; }
        public string BodyWeight { get; set; }
        public string Height { get; set; }
        public string BodyMass { get; set; }
        public string Waist { get; set; }
        public string BloodPressure { get; set; }
        public string BloodPressurePercentage { get; set; }
        public string Hypertension { get; set; }
        public string Dyslipidemia { get; set; }
        public string Diabetis { get; set; }
        public string Diabetis_Type { get; set; }
        public string AgeOf_Diagnosis { get; set; }
        public string Diseases_Other { get; set; }
        public string Walk { get; set; }
        public string Gym { get; set; }
        public string Diet { get; set; }
        public string Breakfast { get; set; }
        public string Happy { get; set; }
        public string smoking_status { get; set; }
        public string FastFood { get; set; }
        public string SoftDrinks { get; set; }
        public string Satisfied { get; set; }
        public string Late { get; set; }
        public string Dinner_Time { get; set; }
        public string Overweight { get; set; }
        public string VitaminD_Deficiency { get; set; }
        public string VitaminD_Supplement { get; set; }
        public string VitaminD_Supplement_Dose { get; set; }
        public string diabetes_family { get; set; }
        public string obesity_family { get; set; }
        public string hypertension_family { get; set; }
        public string cvd_family { get; set; }
        public string dyslip_family { get; set; }
        public string CancerIn_family { get; set; }
        public string Other_Family { get; set; }
        public string LifeStyle_Comments { get; set; }

    }
 
}
