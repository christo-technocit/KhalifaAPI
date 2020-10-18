using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaire4Repository : IGenericRepository<Questionnaire4>
    {
    //    IEnumerable<Questionnaire4> GetAllIncludedData();
    IEnumerable<Questionnaire4> GetSampleID(Int32 SampleID);

}
}