using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //data gönderen yapı için false default olarak göndermesini sağlayan yapı oluşturduk
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) //mesaj ve datayı alıyor
        {

        }
        public ErrorDataResult(T data) : base(data,false)//sadece data
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)//default olan data değeri ve mesaj
        {

        }
        public ErrorDataResult() : base(default,false) //sadece default olan data 
        {

        }
    }
}
