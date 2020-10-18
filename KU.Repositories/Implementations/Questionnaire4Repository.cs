using KU.Repositories.Models;
using KU.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KU.Repositories.Implementations
{
    public class Questionnaire4Repository : GenericRepository<Questionnaire4>, IQuestionnaire4Repository
    {
        public Questionnaire4Repository(DbContext context) : base(context)
        { }

        

        public IEnumerable<Questionnaire4> GetSampleID(Int32 SavedFormID)

        {

            if (SavedFormID == 0)
            {


                return _appContext.Questionnaire4.FromSql("sp_getrecords {0},{1}", 5, 0).ToList();
                //return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data").ToList();


            }
            else
            {
                return _appContext.Questionnaire4.FromSql("sp_getrecords {0},{1},{2}", 5, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire3.FromSql("sp_Questionnaire3Data {0}", SavedFormID).ToList();

            }
        }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}

   