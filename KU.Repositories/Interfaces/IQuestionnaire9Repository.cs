using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire10Repository : IGenericRepository<Questionnaire10>
    {
        //    IEnumerable<Questionnaire4> GetAllIncludedData();
        IEnumerable<Questionnaire10> GetSampleID(Int32 SampleID);

    }
}