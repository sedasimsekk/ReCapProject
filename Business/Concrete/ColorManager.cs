using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public string Added(Color color)
        {
            if (color.ColorName.Length > 2)
            {
                _colorDal.Add(color);
                return "Eklendi";
            }
            else
            {
                return "Girilen isim ve fiyatı kontrol ediniz";
            }
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(c => c.Id == id);
        }


    }
}
