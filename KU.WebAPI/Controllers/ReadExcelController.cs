using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
//namespace IC6.Xamarin.WebApi.Controllers


using System.Collections.Generic;

using System.Linq;

using KU.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using KU.Repositories.Models;
using System.Threading;
using OfficeOpenXml;
using KU.Services.Implementations;


using Microsoft.AspNetCore.Cors;
using KU.Repositories;
using KU.Services;

namespace KU.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Image")]
   // [ApiController]
    public class ReadExcelController : ControllerBase
    {


        private readonly IFormService FormService;
        readonly ILogger logger;
        private readonly IHostingEnvironment _environment;

        //public ReadExcelController(IHostingEnvironment environment, IFormService FormService, ILogger<ReadExcelController> logger)
        //{
        //    _environment = environment ?? throw new ArgumentNullException(nameof(environment));
        //    this.FormService = FormService;
        //    this.logger = logger;
        //}

        public ReadExcelController(IFormService formService, ILogger<FormController> logger)
        {
            this.FormService = formService;
            this.logger = logger;

        }

        // POST: api/Image
        [HttpPost("import")]
        public async Task<ReadExcelResponse<List<ReadExcel>>> Import(IFormFile formFile, CancellationToken cancellationToken)
        {
            if (formFile == null || formFile.Length <= 0)
            {
                return ReadExcelResponse<List<ReadExcel>>.GetResult(-1, "formfile is empty");
            }

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                return ReadExcelResponse<List<ReadExcel>>.GetResult(-1, "Not Support file extension");
            }

            var list = new List<ReadExcel>();

            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream, cancellationToken);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        list.Add(new ReadExcel
                        {
                            UserName = worksheet.Cells[row, 1].Value.ToString().Trim(),
                            Age = int.Parse(worksheet.Cells[row, 2].Value.ToString().Trim()),
                        });
                    }
                }
            }

            // add list to db ..  

           


            // here just read and return  


            return ReadExcelResponse<List<ReadExcel>>.GetResult(0, "OK", list);
        }


        // GET: api/forms
        [HttpPost("Addformattributevalue")]
        //[Authorize(Authorization.Policies.ViewAllCustomersPolicy)]
        public IActionResult AddFormAttributeValues(List<FormAttributeValueViewModel> model)
        {
            try
            {
                var status = FormService.InsertFormAttributeValues(model);
                
                return Ok(status);
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