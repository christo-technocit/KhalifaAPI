using KU.Repositories.Interfaces;
using KU.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KU.Repositories.Implementations
{
    public class Questionnaire8Repository : GenericRepository<Questionnaire8>, IQuestionnaire8Repository
    {
        public Questionnaire8Repository(DbContext context) : base(context)
        { }



        public IEnumerable<Questionnaire8> GetSampleID(Int32 SavedFormID)

        {

            if (SavedFormID == 0)
            {


                return _appContext.Questionnaire8.FromSql("sp_getrecords {0},{1}", 9, 0).ToList();
                //return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data").ToList();


            }
            else
            {
                return _appContext.Questionnaire8.FromSql("sp_getrecords {0},{1},{2}", 9, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data {0}", SavedFormID).ToList();

            }
        }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}

