using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //default olarak true göndermemize yarayan class
        //iki adet constructor mesaj alan ve almayan true döndürme
        //base sınıfa değerleri gönderdik buranın base sınıfı Result (inherit ettik)
        //hem bu sayede eğer bir yerde IResult döndürmek istersek SuccessResult da döndürebilicez çünkü base sınıf sayesinde IResult SuccessResultın referansını tutabildi.
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {
                
        }

    }
}
