using KU.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Services.Interfaces
{
    public interface IFormService
    {
        // user module begin
        IEnumerable<ApplicationUsers> GetAllIncludedData(Int32 OrderBy, Int32 SortOrder, Int32 PageSize, Int32 PageNumber, string Filter);
        //   IEnumerable<ApplicationUsers> GetUser(string UserName, string Password);

        IEnumerable<ApplicationUsers> CheckToken(string token);

        // user module end
        IEnumerable<SavedFormViewModel> GetAllSavedForms();
        
        IEnumerable<Template> GetAllTemplates(string UserName);
        IEnumerable<CountryMaster> GetCountries(string CountryName);
        CountryWrap GetCountries1(string CountryName);
        IEnumerable<SavedFormViewModel> GetSavedFormByID(Int32 TemplateID, Int32 SavedFormID, Int32 orderby, Int32 sortorder ,Int32 pagesize, Int32 pagenumber, string filter);
        
        

        IEnumerable<FormAttributeValue> GetFormByID(Int32 SavedFormID);
        IEnumerable<FormAttributeValue_files> GetDocumentByID(Int32 SavedFormID);
    
        IEnumerable<FormAttributeValue> MoveImage(long SavedFormID, long FormAttributeID);
      //  IEnumerable<FormAttributeValue_files> UploadDocument(long FormAttributeValueID, long SavedFormID, string FormAttributeValue);

         // IEnumerable<SavedFormViewModel> GetFormByID(Int32 TemplateID, Int32 SavedFormID);

        IEnumerable <FormAttribute> GetAttributeName(Int32 templateid, Int32 savedFormID);
        IEnumerable<FormAttribute> GetAttributeID(string templateid, string SectionID, string AttributeName);
        FormAttributeWrap GetAttributeIDReports(string templateid, string SectionID, string AttributeName);

        IEnumerable<Questionnaire3> GetSampleID3(Int32 SampleID);
              IEnumerable<Questionnaire2> GetSampleID2(Int32 SampleID);
  //      IEnumerable<Questionnaire2section> GetSampleID2sec(Int32 SampleID);

    IEnumerable<Questionnaire4> GetSampleID4(Int32 SampleID);
        IEnumerable<Questionnaire5> GetSampleID5(Int32 SampleID);
        IEnumerable<Questionnaire6> GetSampleID6(Int32 SampleID);
        IEnumerable<Questionnaire7> GetSampleID7(Int32 SampleID);
        IEnumerable<Questionnaire8> GetSampleID8(Int32 SampleID);
        IEnumerable<Questionnaire9> GetSampleID9(Int32 SampleID);
        IEnumerable<Questionnaire9_9> GetSampleID9_9(Int32 SampleID);
        IEnumerable<Questionnaire10> GetSampleID10(Int32 SampleID);
        IEnumerable<Questionnaire12> GetSampleID12(Int32 SampleID);

        IEnumerable<Questionnaire1> GetSampleID1(Int32 SampleID);
        IEnumerable<Questionnaire1> GetSampleID(Int32 SampleID, Int32 TemplateID);
        //to print with result head
       // TotalRecordsWrap GetTotal(Int32 TemplateID, Int32 PageSize, String SearchStr);
         IEnumerable<TotalRecords> GetTotal(Int32 TemplateID, Int32 PageSize, String SearchStr);
        // IEnumerable<SP_GETDATA>  GetReport(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber);

        //TotalRecordsWrap GetReportTotal(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        IEnumerable<TotalRecords> GetReportTotal(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);

        //Common Procedure
        IEnumerable<GenericResult> GetRecords(Int32 TemplateID, Int32 SavedFormID, Int32 SectionID);
        GenericResultWrap GetReportCommon(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);

        QuestionnaireWrap GetReport(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
     //   Common GetReportaa(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap2 GetReport2(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap3 GetReport3(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap4 GetReport4(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap5 GetReport5(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap6 GetReport6(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap7 GetReport7(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap8 GetReport8(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        //  // IEnumerable<Questionnaire> GetReport(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber);
        QuestionnaireWrap9 GetReport9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap9_9 GetReport9_9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap10 GetReport10(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);
        QuestionnaireWrap12 GetReport12(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter);

        long InsertSavedForm(SavedFormViewModel model );
        long UpdateSavedForm(SavedFormViewModel model);
        long DeleteSavedForm(SavedFormViewModel model);

        bool InsertFormAttributeValues(List<FormAttributeValueViewModel> model);
        bool UpdateFormAttributeValues(List<FormAttributeValueViewModel> model);
        bool DeleteFormAttributeValues(List<FormAttributeValueViewModel> model);

        long InsertFormAttributeValue(FormAttributeValueViewModel model);
        long UpdateFormAttributeValue(FormAttributeValueViewModel model);
       

        bool InsertFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model);
        bool UpdateFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model);
        bool DeleteFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model);
    }
}
