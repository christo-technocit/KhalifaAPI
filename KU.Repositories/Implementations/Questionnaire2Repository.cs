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
    class Questionnaire2Repository : GenericRepository<Questionnaire2>, IQuestionnaire2Repository
    {
        public Questionnaire2Repository(DbContext context) : base(context)
        { }

        //public IEnumerable<Questionnaire3> GetAllIncludedData()
        //{

        //    return _appContext.Questionnaire3
        //        .OrderBy(c => c.SampleID)

        //        .ToList();
        //}

        public IEnumerable<Questionnaire2> GetSampleID(Int32 SavedFormID)
        //   public List<Questionnaire2> GetSampleID(Int32 SavedFormID)
        {

            if (SavedFormID == 0)
            {

                //  return  await _appContext.Questionnaire2.FromSql("sp_getrecords {0},{1}", 2, 0).ToListAsync();
                return _appContext.Questionnaire2.FromSql("sp_getrecords {0},{1}", 2, 0).ToList();
                //return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data").ToList();


            }
            else
            {
                return _appContext.Questionnaire2.FromSql("sp_getrecords {0},{1},{2}", 2, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data {0}", SavedFormID).ToList();

            }
        }



        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}