﻿using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
//namespace IC6.Xamarin.PictureUpload
    namespace KU.WebAPI.PictureUpload
{
    internal class ApiService : IApiService
    {
        private string url = "http://xxxxxxxxx/api/image/";


        public async Task UploadImageAsync(Stream image, string fileName)
        {
            
             
            HttpContent fileStreamContent = new StreamContent(image);
            fileStreamContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data") { Name = "file", FileName = fileName };
            fileStreamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
          
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(fileStreamContent);
               
                var response = await client.PostAsync(url, formData);

                return ;
            }
        }
    }
}