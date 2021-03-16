using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        //default olarak false göndermemize yarayan class
        //iki adet constructor mesaj alan ve almayan false döndürme
        //base sınıfa değerleri gönderdik buranın base sınıfı Result (inherit ettik)
        //hem bu sayede eğer bir yerde IResult döndürmek istersek ErrorResult da döndürebilicez çünkü base sınıf sayesinde IResult ErrorResultın referansını tutabildi.
        public ErrorResult(string message) : base(false, message)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
