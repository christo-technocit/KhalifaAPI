using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire8Repository : IGenericRepository<Questionnaire8>
    {
        //    IEnumerable<Questionnaire4> GetAllIncludedData();
        IEnumerable<Questionnaire8> GetSampleID(Int32 SampleID);

    }
}