using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire3Repository : IGenericRepository<Questionnaire3>
    {
        //IEnumerable<Questionnaire3> GetAllIncludedData();
        IEnumerable<Questionnaire3> GetSampleID(Int32 SampleID);

    }
}
