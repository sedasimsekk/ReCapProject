using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //bu classta tek parametreli olan constructırına bunu gonderdım 
        //bu sayede kendimizi tekrar etmemiş olduk Success=success; iki defa yazmamış olduk
        public Result(bool success,string message):this(success) 
        {
            Message = message; //set ettik
        }
        public Result(bool success) //sadece true false dondurmek isterse mesaj dondurmek istemezse bu constructor çalışıcak
        {
            Success = success; //set ettik
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
