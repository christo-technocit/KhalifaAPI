using AutoMapper;
using KU.Repositories;
using KU.Repositories.Models;
using KU.Services.Interfaces;
using KU.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KU.Services.Implementations
{
    public class FormService: IFormService 
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public FormService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IEnumerable<SavedFormViewModel> GetAllSavedForms()
        {
            var all = unitOfWork.SavedForms.GetAllIncludedData();
            
            return mapper.Map<IEnumerable<SavedFormViewModel>>(all);
        }
        public IEnumerable<Template> GetAllTemplates()
        {
            var all = unitOfWork.Templates.
                GetAllIncludedData();
       return mapper.Map<IEnumerable<Template>>(all);
        }

        public IEnumerable<CountryMaster> GetCountries(string CountryName)
        {
            var all = unitOfWork.CountryMaster.
                GetCountries(CountryName);
            return mapper.Map<IEnumerable<CountryMaster>>(all);
        }

        public CountryWrap GetCountries1(string CountryName)
        {
            var all = unitOfWork.CountryMaster.GetCountries(CountryName);
            return mapper.Map<CountryWrap>(new CountryWrap { result = all });
        }

        public IEnumerable<SavedFormViewModel> GetSavedFormByID(Int32 TemplateID, Int32 savedFormID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.SavedForms.GetSavedFormByID(TemplateID, savedFormID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<IEnumerable<SavedFormViewModel>>(all);
        }

        // user module begin
        public IEnumerable<Repositories.Models.ApplicationUsers> GetAllIncludedData(Int32 OrderBy, Int32 SortOrder, Int32 PageSize, Int32 PageNumber, string Filter)
        {
            var all = unitOfWork.ApplicationUsers.GetAllIncludedDatas(OrderBy, SortOrder, PageSize, PageNumber, Filter);

            return mapper.Map<IEnumerable<Repositories.Models.ApplicationUsers>>(all);
        }
        public IEnumerable<Repositories.Models.ApplicationUsers> CheckToken(string Token)
        {
            var all = unitOfWork.ApplicationUsers.CheckTokens(Token);
            return mapper.Map<IEnumerable<Repositories.Models.ApplicationUsers>>(all);
        }

        //public IEnumerable<ApplicationUsers> GetUser(string UserName, string Password)
        //{
        //    var all = unitOfWork.ApplicationUsers.GetUser(UserName, Password);
        //    return mapper.Map<IEnumerable<ApplicationUsers>>(all);
        //}

        // user module end

  

        public IEnumerable<FormAttributeValue> GetFormByID (Int32 savedFormID)
        {
            var all = unitOfWork.FormAttributeValues.GetFormByID(savedFormID);
            return mapper.Map<IEnumerable<FormAttributeValue>>(all);
        }
        public IEnumerable<FormAttributeValue_files> GetDocumentByID(Int32 savedFormID)
        {
            var all = unitOfWork.FormAttributeValue_files.GetDocumentByID(savedFormID);
            return mapper.Map<IEnumerable<FormAttributeValue_files>>(all);
        }



        public IEnumerable<FormAttributeValue> MoveImage(long SavedFormID, long FormAttributeID)
        {
            var all = unitOfWork.FormAttributeValues.MoveImage(SavedFormID, FormAttributeID);
           
            return mapper.Map<IEnumerable<FormAttributeValue>>(all);
          
        }
        //public IEnumerable<FormAttributeValue_files> UploadDocument(long FormAttributeValueID, long SavedFormID, string FormAttributeValue)
        //{
        //    var all = unitOfWork.FormAttributeValue_files.UploadDocument(FormAttributeValueID, SavedFormID, FormAttributeValue);
        //    return mapper.Map<IEnumerable<FormAttributeValue_files>>(all);
        //}

        public IEnumerable<FormAttribute> GetAttributeName(Int32 TemplateID, Int32 savedFormID)
        {
            var all = unitOfWork.FormAttributes.GetAttributeName(TemplateID, savedFormID);
            return mapper.Map<IEnumerable<FormAttribute>>(all);
        }
        public IEnumerable<FormAttribute> GetAttributeID(string TemplateID, string SectionID, String AttributeName)
        {
            var all = unitOfWork.FormAttributes.GetAttributeID(TemplateID, SectionID, AttributeName);
            return mapper.Map<IEnumerable<FormAttribute>>(all);
        }

        public FormAttributeWrap GetAttributeIDReports(string TemplateID, string SectionID, String AttributeName)
        {
            var all = unitOfWork.FormAttributes.GetAttributeIDReports(TemplateID, SectionID, AttributeName);
            return mapper.Map<FormAttributeWrap>(new FormAttributeWrap { result = all });
        }

        public IEnumerable<Questionnaire1> GetSampleID(Int32 SampleID, Int32 TemplateID)
        {
            var all = unitOfWork.questionnaire.GetSampleID(SampleID, TemplateID);
            return mapper.Map<IEnumerable<Questionnaire1>>(all);
        }

        public IEnumerable<Questionnaire3> GetSampleID3(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID3(SampleID);
            return mapper.Map<IEnumerable<Questionnaire3>>(all);
        }

        public IEnumerable<Questionnaire2> GetSampleID2(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID2(SampleID);
            return mapper.Map<IEnumerable<Questionnaire2>>(all);
        }

        //public IEnumerable<Questionnaire2section> GetSampleID2sec(Int32 SampleID)
        //{
        //    var all = unitOfWork.questionnaire2section.GetSampleID(SampleID);
        //    return mapper.Map<IEnumerable<Questionnaire2section>>(all);
        //}
        public IEnumerable<Questionnaire1> GetSampleID1(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID1(SampleID);
            return mapper.Map<IEnumerable<Questionnaire1>>(all);
        }

       // public TotalRecordsWrap GetReportTotal(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
      //  {
      //      var all = unitOfWork.questionnaire.GetReportTotal(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
      //      return mapper.Map<TotalRecordsWrap>(new TotalRecordsWrap { result = all });
      //  }
        public IEnumerable<TotalRecords> GetReportTotal(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
     
            var all = unitOfWork.questionnaire.GetReportTotal(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<IEnumerable<TotalRecords>>(all);
      
        }

        //public IEnumerable<Questionnaire> GetReport(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber)
        //{
        //    var all = unitOfWork.questionnaire.GetReport(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality , Gender, Diabetes,  SampleID, orderby, sortorder, pagesize, pagenumber);
        //    return mapper.Map<IEnumerable<Questionnaire>>(all);
        //}
        public QuestionnaireWrap GetReport(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap>(new QuestionnaireWrap { result = all });
        }
        //public Common GetReportaa(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        //{
        //    //Common common = new Common();
        //    //common.Questionnaire = new List<Questionnaire>();
        //    //common.Questionnaire2 = new List<Questionnaire2>();
        //    var all = unitOfWork.questionnaire.GetReportaa(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
        //    return mapper.Map<Common>(new Common { result = all });
        //}


        public QuestionnaireWrap2 GetReport2(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport2(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap2>(new QuestionnaireWrap2 { result = all });
        }

        public QuestionnaireWrap3 GetReport3(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport3(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap3>(new QuestionnaireWrap3 { result = all });
        }

        public QuestionnaireWrap4 GetReport4(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport4(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap4>(new QuestionnaireWrap4 { result = all });
        }
        public QuestionnaireWrap5 GetReport5(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport5(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap5>(new QuestionnaireWrap5 { result = all });
        }
        public QuestionnaireWrap6 GetReport6(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport6(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap6>(new QuestionnaireWrap6 { result = all });
        }
        public QuestionnaireWrap7 GetReport7(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport7(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap7>(new QuestionnaireWrap7 { result = all });
        }
        public QuestionnaireWrap8 GetReport8(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport8(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap8>(new QuestionnaireWrap8 { result = all });
        }
        //public IEnumerable<SP_GETDATA> GetReport(long TemplateID, string SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber)
        //{
        //    var all = unitOfWork.questionnaire.GetReport(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber);
        //    return mapper.Map<IEnumerable<SP_GETDATA>>(all);
        //}
        public QuestionnaireWrap9 GetReport9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport9(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap9>(new QuestionnaireWrap9 { result = all });
        }
        public QuestionnaireWrap9_9 GetReport9_9(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport9_9(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap9_9>(new QuestionnaireWrap9_9 { result = all });
        }


        public QuestionnaireWrap10 GetReport10(long TemplateID, long SectionID, string AttributeName, string BeginPeriod, string EndPeriod, string CollectedBy, string CollectedPoint, string Nationality, string Gender, string Diabetes, string SampleID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            var all = unitOfWork.questionnaire.GetReport10(TemplateID, SectionID, AttributeName, BeginPeriod, EndPeriod, CollectedBy, CollectedPoint, Nationality, Gender, Diabetes, SampleID, orderby, sortorder, pagesize, pagenumber, filter);
            return mapper.Map<QuestionnaireWrap10>(new QuestionnaireWrap10 { result = all });
        }


        public IEnumerable<Questionnaire4> GetSampleID4(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID4(SampleID);
            return mapper.Map<IEnumerable<Questionnaire4>>(all);
        }

        public IEnumerable<Questionnaire5> GetSampleID5(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID5(SampleID);
            return mapper.Map<IEnumerable<Questionnaire5>>(all);
        }

        public IEnumerable<Questionnaire6> GetSampleID6(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID6(SampleID);
            return mapper.Map<IEnumerable<Questionnaire6>>(all);
        }

        public IEnumerable<Questionnaire7> GetSampleID7(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID7(SampleID);
            return mapper.Map<IEnumerable<Questionnaire7>>(all);
        }

        public IEnumerable<Questionnaire8> GetSampleID8(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID8(SampleID);
            return mapper.Map<IEnumerable<Questionnaire8>>(all);
        }

        public IEnumerable<Questionnaire9> GetSampleID9(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID9(SampleID);
            return mapper.Map<IEnumerable<Questionnaire9>>(all);
        }
        public IEnumerable<Questionnaire9_9> GetSampleID9_9(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID9_9(SampleID);
            return mapper.Map<IEnumerable<Questionnaire9_9>>(all);
        }
        public IEnumerable<Questionnaire10> GetSampleID10(Int32 SampleID)
        {
            var all = unitOfWork.questionnaire.GetSampleID10(SampleID);
            return mapper.Map<IEnumerable<Questionnaire10>>(all);
        }



        // to print with result head
        //public TotalRecordsWrap GetTotal(Int32 TemplateID, Int32 PageSize, string SearchStr)
        //{
        //    var all = unitOfWork.totalRecords.GetTotal(TemplateID, PageSize, SearchStr);
        //    return mapper.Map<TotalRecordsWrap>(new TotalRecordsWrap { result = all });
        //}
        public IEnumerable<TotalRecords> GetTotal(Int32 TemplateID, Int32 PageSize, string SearchStr)
        {
            var all = unitOfWork.totalRecords.GetTotal(TemplateID, PageSize, SearchStr);
            return mapper.Map<IEnumerable<TotalRecords>>(all);
        }

        public long InsertSavedForm(SavedFormViewModel model)
        {
            var entity = mapper.Map<SavedForm>(model);
            unitOfWork.SavedForms.Add(entity);
            unitOfWork.SaveChanges();
            return entity.SavedFormID;
        }
        public long UpdateSavedForm(SavedFormViewModel model)
        {
            var entity = mapper.Map<SavedForm>(model);
            unitOfWork.SavedForms.Update(entity);
            unitOfWork.SaveChanges();
            return entity.SavedFormID;
        }

        public long DeleteSavedForm (SavedFormViewModel model)
        {
            var entity = mapper.Map<SavedForm>(model);
            unitOfWork.SavedForms.Remove(entity);
            unitOfWork.SaveChanges();
            return entity.SavedFormID;
        }

        //


        public bool InsertFormAttributeValues(List<FormAttributeValueViewModel> model)
        {
            var entities = mapper.Map<List<FormAttributeValue>>(model);
            unitOfWork.FormAttributeValues.AddRange(entities);
            unitOfWork.SaveChanges();
            return true;
        }
        public bool UpdateFormAttributeValues(List<FormAttributeValueViewModel> model)
        {
            var entities = mapper.Map<List<FormAttributeValue>>(model);

            unitOfWork.FormAttributeValues.UpdateRange(entities);

            unitOfWork.SaveChanges();
            return true;
        }
        public bool DeleteFormAttributeValues(List<FormAttributeValueViewModel> model)
        {
            var entities = mapper.Map<List<FormAttributeValue>>(model);

            unitOfWork.FormAttributeValues.RemoveRange(entities);

            unitOfWork.SaveChanges();
            return true;
        }


        public long InsertFormAttributeValue(FormAttributeValueViewModel model)
        {
            var entity = mapper.Map<FormAttributeValue>(model);
            unitOfWork.FormAttributeValues.Add(entity);
            unitOfWork.SaveChanges();
            return entity.SavedFormID;
        }
        public long UpdateFormAttributeValue(FormAttributeValueViewModel model)
        {
            var entity = mapper.Map<FormAttributeValue>(model);
            unitOfWork.FormAttributeValues.Update(entity);
            unitOfWork.SaveChanges();
            return entity.SavedFormID ;
        }

        

        public bool InsertFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model)
        {
            var entities = mapper.Map<List<FormAttributeValue_files>>(model);
            unitOfWork.FormAttributeValue_files.AddRange(entities);
            unitOfWork.SaveChanges();
            return true;
        }

        public bool UpdateFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model)
        {
            var entities = mapper.Map<List<FormAttributeValue_files>>(model);
            unitOfWork.FormAttributeValue_files.UpdateRange(entities);
            unitOfWork.SaveChanges();
            return true;
        }
        public bool DeleteFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model)
        {
            var entities = mapper.Map<List<FormAttributeValue_files>>(model);
            unitOfWork.FormAttributeValue_files.RemoveRange(entities);
            unitOfWork.SaveChanges();
            return true;
        }


    }
}
