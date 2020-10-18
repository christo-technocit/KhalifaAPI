using KU.Repositories.Interfaces;
using KU.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KU.Repositories.Implementations
{
    public class Questionnaire3Repository : GenericRepository<Questionnaire3>, IQuestionnaire3Repository
    {
        public Questionnaire3Repository(DbContext context) : base(context)
        { }

        //public IEnumerable<Questionnaire3> GetAllIncludedData()
        //{
            
        //    return _appContext.Questionnaire3
        //        .OrderBy(c => c.SampleID)
            
        //        .ToList();
        //}

        public IEnumerable<Questionnaire3> GetSampleID(Int32 SavedFormID)
        
        {
           
            if (SavedFormID == 0)
            {

                
                    return _appContext.Questionnaire3.FromSql("sp_getrecords {0},{1}",4,0).ToList();
                //return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data").ToList();
                          
                
            }
            else
            {
                return _appContext.Questionnaire3.FromSql("sp_getrecords {0},{1},{2}", 4, 0, SavedFormID).ToList();
               // return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data {0}", SavedFormID).ToList();
  
            }
        }

           private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
