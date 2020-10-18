using KU.Repositories.Interfaces;
using KU.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KU.Repositories.Implementations
{
    public class Questionnaire7Repository : GenericRepository<Questionnaire7>, IQuestionnaire7Repository
    {
        public Questionnaire7Repository(DbContext context) : base(context)
        { }



        public IEnumerable<Questionnaire7> GetSampleID(Int32 SavedFormID)

        {

            if (SavedFormID == 0)
            {


                return _appContext.Questionnaire7.FromSql("sp_getrecords {0},{1}", 8, 0).ToList();
                //return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data").ToList();


            }
            else
            {
                return _appContext.Questionnaire7.FromSql("sp_getrecords {0},{1},{2}", 8, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data {0}", SavedFormID).ToList();

            }
        }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}

