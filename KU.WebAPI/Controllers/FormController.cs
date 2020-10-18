using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KU.Services.Interfaces;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;


namespace KU.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class FormController : ControllerBase
    {
        private readonly IFormService formService;
        readonly ILogger logger;

        public FormController(IFormService formService, ILogger<FormController> logger)
        {
            this.formService = formService;
            this.logger = logger;

        }

        //// GET: api/forms
        //[HttpGet("forms")]
        ////[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        //public IActionResult Get()
        //{
        //    var all = formService.GetAllSavedForms();
        //    return Ok(all);
        //   // var selectedform = formService.GetSavedFormByID(5,1234);
        //   // return Ok(selectedform);


        //}



        [HttpGet("listforms")]
        public IActionResult Get([FromQuery]Int32 templateID, Int32 SavedFormID, Int32 orderby, Int32 sortorder, Int32 pagesize, Int32 pagenumber, string filter)
        {
            try
            {
                var all = formService.GetSavedFormByID(templateID, SavedFormID, orderby, sortorder, pagesize, pagenumber, filter);

                return Ok(all);
            }
            catch (Exception ex)
            {
                 logger.LogError($"Something went wrong: {ex }");
                
                return StatusCode(500, ex.InnerException ) ;
               // return StatusCode(500, "Internal server error" );
                
            }
        }

        [HttpGet("formattributevalues")]
        public IActionResult Get([FromQuery] Int32 SavedFormID)
        {
            try
            { 
            var all = formService.GetFormByID(SavedFormID);
            return Ok(all);
                }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        //[HttpGet("formattribute")]
        //public IActionResult Get([FromQuery]Int32 templateID, Int32 FormAttributeid)
        //{
        //    var all = formService.GetAttributeName(templateID, FormAttributeid);

        //    return Ok(all);
        //}
        [HttpGet("formattribute")]
        public IActionResult GetAttributeID([FromQuery]string templateID, string SectionID, string AttributeName)
        {
            try
            {
                var all = formService.GetAttributeID(templateID, SectionID, AttributeName);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }
        [HttpGet("formattributeReports")]
        public IActionResult GetAttributeIDReports([FromQuery]string templateID, string SectionID, string AttributeName)
        {
            try
            {
                var all = formService.GetAttributeIDReports(templateID, SectionID, AttributeName);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        [HttpGet("Questionnaire")]
        public IActionResult GetSampleIDAll([FromQuery] Int32 SavedformID, Int32 TemplateID)
        {

            try
            {
               

                if (TemplateID == 1) { var all1 = formService.GetSampleID1(SavedformID); return Ok(all1); }
                if (TemplateID == 2) { var all2 = formService.GetSampleID2(SavedformID); return Ok(all2); }
                if (TemplateID == 4) { var all3 = formService.GetSampleID3(SavedformID); return Ok(all3); }
                if (TemplateID == 5) { var all4 = formService.GetSampleID4(SavedformID); return Ok(all4); }
                if (TemplateID == 6) { var all5 = formService.GetSampleID5(SavedformID); return Ok(all5); }
                if (TemplateID == 7) { var all6 = formService.GetSampleID6(SavedformID); return Ok(all6); }
                if (TemplateID == 8) { var all7 = formService.GetSampleID7(SavedformID); return Ok(all7); }
                if (TemplateID == 9) { var all8 = formService.GetSampleID8(SavedformID); return Ok(all8); }
                if (TemplateID == 10) { var all9 = formService.GetSampleID9(SavedformID); return Ok(all9); }
             //   if (TemplateID == 10 && SectionID == 9) { var all9_9 = formService.GetSampleID9_9(SavedformID); return Ok(all9_9); }
                if (TemplateID == 11) { var all10 = formService.GetSampleID10(SavedformID); return Ok(all10); }

                var all = formService.GetSampleID1(SavedformID);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }

        }
        [HttpGet("Questionnaire9")]
        public IActionResult GetSampleIDAll9([FromQuery] Int32 SavedformID)
        {

            try
            {

                var all = formService.GetSampleID9_9(SavedformID);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }

        }
        [HttpGet("Questionnaire1")]
        public IActionResult GetbySampleID1([FromQuery] Int32 SavedformID)
        {
            try
            {
                var all = formService.GetSampleID1(SavedformID);
                return Ok(all);
            }

            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        ////[HttpGet("Questionnaire2")]
        ////public IActionResult GetbySampleID2([FromQuery] Int32 SavedformID)
        ////{
        ////    var all = formService.GetSampleID2(SavedformID);

        ////    return Ok(all);
        ////}
        ////[HttpGet("Questionnaire2section")]

        [HttpGet("Questionnaire3")]
        public IActionResult GetbySampleID3([FromQuery] Int32 SavedformID)
        {
            try
            {
                var all = formService.GetSampleID3(SavedformID);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        //[HttpGet("Questionnaire4")]
        //      public IActionResult GetbySampleID4([FromQuery] Int32 SavedformID)
        //      {
        //          var all = formService.GetSampleID4(SavedformID);

        //          return Ok(all);
        //      }


        //      [HttpGet("Questionnaire5")]
        //      public IActionResult GetbySampleID5([FromQuery] Int32 SavedformID)
        //      {
        //          var all = formService.GetSampleID5(SavedformID);

        //          return Ok(all);
        //      }


        //      [HttpGet("Questionnaire6")]
        //      public IActionResult GetbySampleID6([FromQuery] Int32 SavedformID)
        //      {
        //          var all = formService.GetSampleID6(SavedformID);

        //          return Ok(all);
        //      }

        //      [HttpGet("Questionnaire7")]
        //      public IActionResult GetbySampleID7([FromQuery] Int32 SavedformID)
        //      {
        //          var all = formService.GetSampleID7(SavedformID);

        //          return Ok(all);
        //      }

        //      [HttpGet("Questionnaire8")]
        //      public IActionResult GetbySampleID8([FromQuery] Int32 SavedformID)
        //      {
        //          var all = formService.GetSampleID8(SavedformID);

        //          return Ok(all);
        //      }

        // GET: api/forms
        [HttpPost("AddForms")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult AddSavedForm(SavedFormViewModel model)
        {
            try
            {
                var id = formService.InsertSavedForm(model);
                return Ok(id);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }


        [HttpPost("UpdateForms")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult UpdateSavedForm(SavedFormViewModel model)
        {
            try
            {
                var id = formService.UpdateSavedForm(model);
                return Ok(id);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        [HttpPost("DeleteForms")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult DeleteSavedForm(SavedFormViewModel model)
        {
            try
            {
                var id = formService.DeleteSavedForm(model);
                return Ok(id);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

               

        // GET: api/forms
        [HttpPost("Addformattributevalue")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult AddFormAttributeValues(List<FormAttributeValueViewModel> model)
        {
            try
            {
                var status = formService.InsertFormAttributeValues(model);
                return Ok(status);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        // GET: api/forms
        [HttpPost("Updateformattributevalue")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult UpdateFormAttributevalues(List<FormAttributeValueViewModel> model)
        {
            try
            {
                var status = formService.UpdateFormAttributeValues(model);
                return Ok(status);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }
        // GET: api/forms
        [HttpPost("Deleteformattributevalue")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult DeleteFormAttributevalues(List<FormAttributeValueViewModel> model)
        {
            try
            {
                var status = formService.DeleteFormAttributeValues(model);
                return Ok(status);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        // GET: api/forms
        [HttpPost("Addformattributevaluesingle")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult AddFormAttributeValue(FormAttributeValueViewModel model, long FormAttributeID)
        {
            try
            {
                var id = formService.InsertFormAttributeValue(model);
                var all = formService.MoveImage(id, FormAttributeID);
                return Ok(id);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        // GET: api/forms
        [HttpPost("UpdateformattributevalueSingle")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult Updateformattributevalue(FormAttributeValueViewModel model, long FormAttributeID)
        {
            try
            {
                var id = formService.UpdateFormAttributeValue(model);
                var all = formService.MoveImage(id, FormAttributeID);
                return Ok(id);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }



        // GET: api/forms
        [HttpPost("AddDocuments")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult AddFormAttributeValues_files(List<FormAttributeValue_filesViewModel> model)
        {
            try
            {
                var status = formService.InsertFormAttributeValues_files(model);
                return Ok(status);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        // GET: api/forms
        [HttpPost("UpdateDocuments")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult UpdateFormAttributevalues_files(List<FormAttributeValue_filesViewModel> model)
        {
            try
            {
                var status = formService.UpdateFormAttributeValues_files(model);
                return Ok(status);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }
        // GET: api/forms
        [HttpPost("DeleteDocuments")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult DeleteFormAttributevalues_files(List<FormAttributeValue_filesViewModel> model)
        {
            try
            {
                var status = formService.DeleteFormAttributeValues_files(model);
                return Ok(status);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }
        [HttpGet("GetDocuments")]
        public IActionResult GetDocuments([FromQuery] Int32 SavedFormID)
        {
            try
            {
                var all = formService.GetDocumentByID(SavedFormID);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }


        // GET: api/form/Countries
        [HttpGet("Countries")]
        // [Authorize(Authorization.Policies.ViewAllUsersPolicy)]

        public IActionResult GetCountries(string CountryName)
        {
            try
            {
                var all = formService.GetCountries1(CountryName);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }


        // GET: api/form/templates
        [HttpGet("templates")]
        // [Authorize(Authorization.Policies.ViewAllUsersPolicy)]
        public IActionResult GetTemplates()
        {
            try
            {
                var all = formService.GetAllTemplates();
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }


        [HttpGet("totalrecords")]
        //[Authorize(Authorization.Policies.ViewAllUsersPolicy)]
        public IActionResult GetTotal([FromQuery] Int32 TemplateID, Int32 PageSize, string SearchStr)
        {
            try
            {
                var AuthID = Request.Headers["AuthID"];
                var AuthPwd = Request.Headers["AuthPwd"];
                var all = formService.GetTotal(TemplateID, PageSize, SearchStr);
                return Ok(all);
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

 [HttpGet("totalrecordswithAuth")]
  

        public IActionResult GetTotalAuth([FromQuery] Int32 TemplateID, Int32 PageSize, string SearchStr)
        {
            try
            {
                var AuthID = Request.Headers["AuthID"];

                //var AuthPwd = Request.Headers["AuthPwd"];

                //AuthID = "DAB4986CBE0B430C96A310BB7019D3C0";

                //var all = formService.GetUser(AuthID, AuthPwd);
                var all = formService.CheckToken(AuthID);

                if (all.FirstOrDefault().UserId == "")
                // if (all.FirstOrDefault().UserId != 0)
                {

                    var totalrec = formService.GetTotal(TemplateID, PageSize, SearchStr);
                    return Ok(totalrec);
                }
                else
                {
                    return Ok(all.FirstOrDefault().UserId);

                }
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }

        //[HttpGet ("ValidateUser")]
        //public IActionResult CheckUser([FromQuery] string UserName, string Password) 
        //{
        //    var all = formService.CheckUserID(UserName, Password);
        //    return Ok(all);
        //}
  
        [HttpGet ("MoveImage")]
            public IActionResult MoveImage (long SavedFormID, long FormAttributeID)
        {
            try
            {
                var all = formService.MoveImage(SavedFormID, FormAttributeID);
                return Ok(all);
            }
            catch (Exception ex)
            {
                
                logger.LogError($"Something went wrong: {ex }");
                return StatusCode(500, ex.InnerException);
                // return StatusCode(500, "Internal server error" );

            }
        }





    }
}