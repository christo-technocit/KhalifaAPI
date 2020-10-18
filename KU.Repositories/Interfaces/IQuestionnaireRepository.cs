using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Repositories.Interfaces
{
    public interface IQuestionnaireRepository 
    {
        
        IEnumerable<Questionnaire1> GetAllIncludedData();
        IEnumerable<Questionnaire1> GetSampleID(Int32 SampleID, Int32 TemplateID);
        IEnumerable<Questionnaire1> GetSampleID1(Int32 SampleID);
        IEnumerable<Questionnaire2> GetSampleID2(Int32 SampleID);

        IEnumerable<Questionnaire3> GetSampleID3(Int32 SampleID);
        IEnumerable<Questionnaire4> GetSampleID4(Int32 SampleID);
        IEnumerable<Questionnaire5> GetSampleID5(Int32 SampleID);

        IEnumerable<Questionnaire6> GetSampleID6(Int32 SampleID);

        IEnumerable<Questionnaire7> GetSampleID7(Int32 SampleID);
        IEnumerable<Questionnaire8> GetSampleID8(Int32 SampleID);
        IEnumerable<Questionnaire9> GetSampleID9(Int32 SampleID);
        IEnumerable<Questionnaire9_9> GetSampleID9_9(Int32 SampleID);
        IEnumerable<Questionnaire10> GetSampleID10(Int32 SampleID);
        IEnumerable<TotalRecords> GetReportTotal(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q1ViewModel> GetReport(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
       // IEnumerable<Common> GetReportaa(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q2ViewModel> GetReport2(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q3ViewModel> GetReport3(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q4ViewModel> GetReport4(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q5ViewModel> GetReport5(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q6ViewModel> GetReport6(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q7ViewModel> GetReport7(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q8ViewModel> GetReport8(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        //IEnumerable<SP_GETDATA> GetReport(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber);
        IEnumerable<Q9ViewModel> GetReport9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q9_9ViewModel> GetReport9_9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<Q10ViewModel> GetReport10(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);

    }
}

