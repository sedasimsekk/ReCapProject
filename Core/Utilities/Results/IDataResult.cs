using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //hem veri hem mesaj hemde başarı dondürücek
    //mesaj ve başarı IResult içerisinde mevcut (dont repeat yourself-kendini tekrar etme) o yüzden onu kullanabilirim.
    //generic olmasının sebebi veri her şey olabilir.Data property'si de generic verilen veri kullanabilmesi adına 
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
