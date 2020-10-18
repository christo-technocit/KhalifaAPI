
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
   
    public class QuestionnaireWrap3
    {
        
        public QuestionnaireWrap3()
        {
            result = new List<Q3ViewModel>();

        }
        public IEnumerable<Q3ViewModel> result { get; set; }

    }


    public class Q3ViewModel
    {

        // [ScaffoldColumn(true)]
        [Key]
        public string SavedFormID { get; set; }
        [JsonProperty("Depository ID")] public string Depository_ID { get; set; }
        public string Sample { get; set; }
        [JsonProperty("Collected Date")]
        public string collected_date { get; set; }

        [JsonProperty("Collected Center")]
        public string Collected_Center { get; set; }

        [JsonProperty("Staff Name")]
        public string staff_name { get; set; }

        [JsonProperty("Staff Id")]
        public string staff_id { get; set; }

        [JsonProperty("Birth Date")]
        public string birth_date { get; set; }

        [JsonProperty("Birth Place")]
        public string birth_place { get; set; }

        [JsonProperty("Country")]
        public string country { get; set; }

        [JsonProperty("Mobile No")]
        public string Mobile_no { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Marital Status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("Consanguineous Marriage")]
        public string Consanguineous_Marriage { get; set; }

        [JsonProperty("No. of Wives")]
        public string NoOfWives { get; set; }

        [JsonProperty("No. of Children")]
        public string NoOfChildren { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Body Weight")]
        public string BodyWeight { get; set; }

        [JsonProperty("Height")]
        public string Height { get; set; }

        [JsonProperty("Body Mass")]
        public string BodyMass { get; set; }

        [JsonProperty("Waist")]
        public string Waist { get; set; }

        [JsonProperty("Blood Pressure")]
        public string BloodPressure { get; set; }

        [JsonProperty("Blood Pressure %")]
        public string BloodPressurePercentage { get; set; }

        [JsonProperty("Hypertension")]
        public string Hypertension { get; set; }

        [JsonProperty("Dyslipidemia")]
        public string Dyslipidemia { get; set; }

        [JsonProperty("Diabetis")]
        public string Diabetis { get; set; }

        [JsonProperty("Diabetis Type")]
        public string Diabetis_Type { get; set; }

        [JsonProperty("Age Of Diagnosis")]
        public string AgeOf_Diagnosis { get; set; }

        [JsonProperty("Diseases Other")]
        public string Diseases_Other { get; set; }

        public string Walk { get; set; }
        public string Gym { get; set; }
        public string Diet { get; set; }
        public string Breakfast { get; set; }
        public string Happy { get; set; }

        [JsonProperty("Smoking Status")]
        public string smoking_status { get; set; }

        public string FastFood { get; set; }
        public string SoftDrinks { get; set; }
        public string Satisfied { get; set; }
        public string Late { get; set; }

        [JsonProperty("Dinner Time")]
        public string Dinner_Time { get; set; }
  
        public string Overweight { get; set; }

        [JsonProperty("Vitamin D Deficiency")]
        public string VitaminD_Deficiency { get; set; }

        [JsonProperty("Vitamin D Supplement")]
        public string VitaminD_Supplement { get; set; }

        [JsonProperty("Vitamin D Supplement Dose")]
        public string VitaminD_Supplement_Dose { get; set; }

        [JsonProperty("Diabetes Family")]
        public string diabetes_family { get; set; }

        [JsonProperty("Obesity Family")]
        public string obesity_family { get; set; }

        [JsonProperty("Hypertension Family")]
        public string hypertension_family { get; set; }

        [JsonProperty("CVD Family")]
        public string cvd_family { get; set; }

        [JsonProperty("Dyslip Family")]
        public string dyslip_family { get; set; }

        [JsonProperty("Cancer in Family")]
        public string CancerIn_family { get; set; }

        [JsonProperty("Other Family")]
        public string Other_Family { get; set; }

        [JsonProperty("Lifestyle Comments")]
        public string LifeStyle_Comments { get; set; }

        public Int32 totalrecords { get; set; }
        public Int32 totalpages { get; set; }
    }
 
}
