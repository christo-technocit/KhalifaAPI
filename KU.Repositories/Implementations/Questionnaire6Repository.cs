using KU.Repositories.Interfaces;
using KU.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KU.Repositories.Implementations
{
    public class Questionnaire6Repository : GenericRepository<Questionnaire6>, IQuestionnaire6Repository
    {
        public Questionnaire6Repository(DbContext context) : base(context)
        { }



        public IEnumerable<Questionnaire6> GetSampleID(Int32 SavedFormID)

        {

            if (SavedFormID == 0)
            {


                return _appContext.Questionnaire6.FromSql("sp_getrecords {0},{1}", 7, 0).ToList();
                //return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data").ToList();


            }
            else
            {
                return _appContext.Questionnaire6.FromSql("sp_getrecords {0},{1},{2}", 7, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data {0}", SavedFormID).ToList();

            }
        }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}

