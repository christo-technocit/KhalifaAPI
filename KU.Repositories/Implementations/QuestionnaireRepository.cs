using KU.Repositories.Interfaces;
using KU.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace KU.Repositories.Implementations
{
    public class QuestionnaireRepository : GenericRepository<QuestionnaireRepository>, IQuestionnaireRepository
    {
        public QuestionnaireRepository(DbContext context) : base(context)
        { }

        public IEnumerable<Questionnaire1> GetAllIncludedData()
        {
            return _appContext.Questionnaire1
                .OrderBy(c => c.SavedFormID)
                .ToList();
        }

        //Questionnaire All
        public IEnumerable<Questionnaire1> GetSampleID(Int32 SavedFormID, Int32 TemplateID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire1.FromSql("sp_getrecords {0},{1},{2}", TemplateID, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire1.FromSql("sp_Questionnaire1Data").ToList();
            }
            else
            {
                return _appContext.Questionnaire1.FromSql("sp_getrecords {0},{1},{2}", TemplateID, 0, SavedFormID).ToList();
                // return _appContext.Questionnaire1.FromSql("sp_Questionnaire1Data {0}",SampleID ).ToList();
            }
        }

        //Questionnaire 1
        public IEnumerable<Questionnaire1> GetSampleID1(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire1.FromSql("sp_getrecords {0},{1},{2}", 1, 0, SavedFormID).ToList();
            }
            else
            {
                return _appContext.Questionnaire1.FromSql("sp_getrecords {0},{1},{2}", 1, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 2
        public IEnumerable<Questionnaire2> GetSampleID2(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire2.FromSql("sp_getrecords {0},{1}", 2, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire2.FromSql("sp_getrecords {0},{1},{2}", 2, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 3
        public IEnumerable<Questionnaire3> GetSampleID3(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire3.FromSql("sp_getrecords {0},{1}", 4, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire3.FromSql("sp_getrecords {0},{1},{2}", 4, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 4
        public IEnumerable<Questionnaire4> GetSampleID4(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire4.FromSql("sp_getrecords {0},{1}", 5, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire4.FromSql("sp_getrecords {0},{1},{2}", 5, 0, SavedFormID).ToList();
            }
        }


        //Questionnaire 5
        public IEnumerable<Questionnaire5> GetSampleID5(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire5.FromSql("sp_getrecords {0},{1}", 6, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire5.FromSql("sp_getrecords {0},{1},{2}", 6, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 6
        public IEnumerable<Questionnaire6> GetSampleID6(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire6.FromSql("sp_getrecords {0},{1}", 7, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire6.FromSql("sp_getrecords {0},{1},{2}", 7, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 7
        public IEnumerable<Questionnaire7> GetSampleID7(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire7.FromSql("sp_getrecords {0},{1}", 8, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire7.FromSql("sp_getrecords {0},{1},{2}", 8, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 8
        public IEnumerable<Questionnaire8> GetSampleID8(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire8.FromSql("sp_getrecords {0},{1}", 9, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire8.FromSql("sp_getrecords {0},{1},{2}", 9, 0, SavedFormID).ToList();
            }
        }

        //Questionnaire 9  precision medicine- except section 9
        public IEnumerable<Questionnaire9> GetSampleID9(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire9.FromSql("sp_getrecords {0},{1}", 10, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire9.FromSql("sp_getrecords {0},{1},{2}", 10, 0, SavedFormID).ToList();
            }
        }
        //Questionnaire 9  precision medicine-  section 1 & 9
        public IEnumerable<Questionnaire9_9> GetSampleID9_9(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire9_9.FromSql("sp_getrecords {0},{1}", 10, 9).ToList();
            }
            else
            {
                return _appContext.Questionnaire9_9.FromSql("sp_getrecords {0},{1},{2}", 10, 9, SavedFormID).ToList();
            }
        }

        //Questionnaire 10 - COVID-19
        public IEnumerable<Questionnaire10> GetSampleID10(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire10.FromSql("sp_getrecords {0},{1}", 11, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire10.FromSql("sp_getrecords {0},{1},{2}", 11, 0, SavedFormID).ToList();
            }
        }

        //  Questionnaire 12 - COVID-19 V2
        public IEnumerable<Questionnaire12> GetSampleID12(Int32 SavedFormID)
        {
            if (SavedFormID == 0)
            {
                return _appContext.Questionnaire12.FromSql("sp_getrecords {0},{1}", 13, 0).ToList();
            }
            else
            {
                return _appContext.Questionnaire12.FromSql("sp_getrecords {0},{1},{2}", 13, 0, SavedFormID).ToList();
            }
        }


        public IEnumerable<Q1ViewModel> GetReport(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }
            if(SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

            //   if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }

            List<Q1ViewModel> TR = _appContext.Q1ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;


            //return _appContext.Questionnaire.
            //    FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID)

            //    ;


        }
 //       public IEnumerable<Common> GetReportaa(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality,string Gender, string Diabetes, string SampleID , Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
 //       {
 //           Common cm = new Common();
 //           cm.Questionnaire = new List<Questionnaire>();
 //           cm.Questionnaire2 = new List<Questionnaire2>();
 //           if (string.IsNullOrEmpty(filter))
 //           {
 //               filter = "";
 //           }
 //           if (SectionID is null) { SectionID = "0";  } 
 //           if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
 //           if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
 //           if (CollectedBy is null) { CollectedBy = ""; }
 //           if (CollectedPoint is null) { CollectedPoint = ""; }
 //           if (Gender is null) { Gender = ""; }
 //           if (Diabetes is null) { Diabetes = ""; }
 //           if (SampleID is null) { SampleID = ""; }

 //        //   if (pagenumber == 0) { pagenumber = 1; }
 //           if (pagesize == 0) { pagesize = 10; }
 //           if (orderby == 0) { orderby = 1; }

         
 //           List<Common> TR = _appContext.Common.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
 //.ToList();
 //           return TR;
 

 //           //return _appContext.Questionnaire.
 //           //    FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID)

 //           //    ;


 //       }

        public IEnumerable<Q2ViewModel> GetReport2(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if ( SectionID.ToString()  is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

         //   if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q2ViewModel> TR = _appContext.Q2ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID,filter)
              .ToList();
            return TR;

        }
        public IEnumerable<Q3ViewModel> GetReport3(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }
            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

          //  if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q3ViewModel> TR = _appContext.Q3ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID,filter)
              .ToList();
            return TR;

        }

        public IEnumerable<Q4ViewModel> GetReport4(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

          //  if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q4ViewModel> TR = _appContext.Q4ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID,filter)
              .ToList();
            return TR;

        }

        public IEnumerable<Q5ViewModel> GetReport5(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }
            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

           // if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q5ViewModel> TR = _appContext.Q5ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID,filter)
              .ToList();
            return TR;

        }
        public IEnumerable<Q6ViewModel> GetReport6(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

          //  if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q6ViewModel> TR = _appContext.Q6ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID,filter)
              .ToList();
            return TR;

        }
        public IEnumerable<Q7ViewModel> GetReport7(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }
            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

         //   if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q7ViewModel> TR = _appContext.Q7ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;

        }

        public IEnumerable<Q8ViewModel> GetReport8(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

           // if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q8ViewModel> TR = _appContext.Q8ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;

        }
        //precision medicine - except section 9 
        public IEnumerable<Q9ViewModel> GetReport9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

            // if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q9ViewModel> TR = _appContext.Q9ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;

        }
        //precision medicine - section 1 & 9 only
        public IEnumerable<Q9_9ViewModel> GetReport9_9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

            // if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q9_9ViewModel> TR = _appContext.Q9_9ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;

        }
        // COVID-19
        public IEnumerable<Q10ViewModel> GetReport10(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

            // if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q10ViewModel> TR = _appContext.Q10ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;

        }


        // COVID-19 V2
        public IEnumerable<Q12ViewModel> GetReport12(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }

            if (SectionID.ToString() is null) { SectionID = 0; }
            if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
            if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
            if (CollectedBy is null) { CollectedBy = ""; }
            if (CollectedPoint is null) { CollectedPoint = ""; }
            if (Gender is null) { Gender = ""; }
            if (Diabetes is null) { Diabetes = ""; }
            if (SampleID is null) { SampleID = ""; }

            // if (pagenumber == 0) { pagenumber = 1; }
            if (pagesize == 0) { pagesize = 10; }
            if (orderby == 0) { orderby = 1; }


            List<Q12ViewModel> TR = _appContext.Q12ViewModel.FromSql("SP_GETDATA {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
              .ToList();
            return TR;

        }


        public IEnumerable<TotalRecords> GetReportTotal(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
           

                if (string.IsNullOrEmpty(filter))
                {
                    filter = "";
                }
                if (SectionID is null) { SectionID = "0"; }
                if (BeginPeriod is null) { BeginPeriod = "2000-01-01"; }
                if (EndPeriod is null) { EndPeriod = DateTime.Now.ToString("yyyy-MM-dd"); }
                if (CollectedBy is null) { CollectedBy = ""; }
                if (CollectedPoint is null) { CollectedPoint = ""; }
                if (Gender is null) { Gender = ""; }
                if (Diabetes is null) { Diabetes = ""; }
                if (SampleID is null) { SampleID = ""; }

                // if (pagenumber == 0) { pagenumber = 1; }
                if (pagesize == 0) { pagesize = 10; }
                if (orderby == 0) { orderby = 1; }


                // List<TotalRecords> TR = _appContext.Totalrecords.FromSql("SP_GETDATA_Total {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter)
                //   .ToList();
                // return TR;

                return _appContext.Totalrecords.
                  FromSql("SP_GETDATA_Total {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}", orderby, sortorder, pagesize, pagenumber, TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, filter);
        }

        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;
    }
}
