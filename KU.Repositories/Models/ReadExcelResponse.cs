using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KU.Repositories.Models
{
    
    
    public class ReadExcelResponse<T>
    {
        public int Code { get; set; }

        public string Msg { get; set; }

        public T Data { get; set; }

        public static ReadExcelResponse<T> GetResult(int code, string msg, T data = default(T))
        {
            return new ReadExcelResponse<T>
            {
                Code = code,
                Msg = msg,
                Data = data
            };
        }
    }
}
