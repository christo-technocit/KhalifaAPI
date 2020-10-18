using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire2Repository : IGenericRepository<Questionnaire2>
    {
        //IEnumerable<Questionnaire2> GetAllIncludedData();
     IEnumerable<Questionnaire2> GetSampleID(Int32 SampleID);

       
    }
}
