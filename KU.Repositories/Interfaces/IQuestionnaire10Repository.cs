using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire9Repository : IGenericRepository<Questionnaire9>
    {
        //    IEnumerable<Questionnaire4> GetAllIncludedData();
        IEnumerable<Questionnaire9> GetSampleID(Int32 SampleID);

    }
}