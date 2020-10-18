using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire6Repository : IGenericRepository<Questionnaire6>
    {
        //    IEnumerable<Questionnaire4> GetAllIncludedData();
        IEnumerable<Questionnaire6> GetSampleID(Int32 SampleID);

    }
}