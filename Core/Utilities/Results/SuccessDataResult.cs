using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //data gönderen yapı için true default olarak göndermesini sağlayan yapı oluşturduk
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message) //mesaj ve datayı alıyor
        {

        }
        public SuccessDataResult(T data):base(data,true)//sadece data
        {

        }
        public SuccessDataResult(string message):base(default,true,message)//default olan data değeri ve mesaj
        {

        }
        public SuccessDataResult():base(default,true) //sadece default olan data 
        {

        }
    }
}
