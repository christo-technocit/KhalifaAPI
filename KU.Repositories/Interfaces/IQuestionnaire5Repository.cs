using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire5Repository : IGenericRepository<Questionnaire5>
    {
        //    IEnumerable<Questionnaire4> GetAllIncludedData();
        IEnumerable<Questionnaire5> GetSampleID(Int32 SampleID);

    }
}