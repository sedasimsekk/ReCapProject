using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IDataResultın somut sınıfını yazdık 
    //base sınıfımız Resulta basarılı ve mesaj gonderdik veya sadece başarılı bu yüzden iki tane constructor kullandık.
    //generic sınıf olması onemli verinin ne olacagını bilmiyoruz çünkü
    public class DataResult<T>: Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data; //set ettik
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data; //set ettik
        }

        public T Data { get; }
    }
}
