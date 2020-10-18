using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire1Repository : IGenericRepository<Questionnaire1>
    {
        IEnumerable<Questionnaire1> GetAllIncludedData();
        IEnumerable<Questionnaire1> GetSampleID(Int32 SampleID);

    }
}
