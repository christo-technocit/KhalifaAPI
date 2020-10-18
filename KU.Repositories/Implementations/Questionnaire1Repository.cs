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
    public class Questionnaire1Repository : GenericRepository<Questionnaire1>, IQuestionnaire1Repository
    {
        public Questionnaire1Repository(DbContext context) : base(context)
        { }

        public IEnumerable<Questionnaire1> GetAllIncludedData()
        {
            
            return _appContext.Questionnaire1
                .OrderBy(c => c.SavedFormID)
            
                .ToList();
        }

        public IEnumerable<Questionnaire1> GetSampleID(Int32 SavedFormID)
        
        {
            if (SavedFormID == 0)
            {
                 
                return _appContext.Questionnaire1.FromSql("sp_getrecords {0},{1},{2}", 1, 0, SavedFormID).ToList();
               // return _appContext.Questionnaire1.FromSql("sp_Questionnaire1Data").ToList();
    
                
            }
            else
            {

                return _appContext.Questionnaire1.FromSql("sp_getrecords {0},{1},{2}", 1, 0, SavedFormID).ToList();
               // return _appContext.Questionnaire1.FromSql("sp_Questionnaire1Data {0}",SampleID ).ToList();
                
     
            }
        }


        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
