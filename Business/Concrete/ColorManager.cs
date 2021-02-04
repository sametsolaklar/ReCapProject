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
        public void Add(Color color)
        {
            var condition = color.ColorName;           
            if (condition.Length > 2)
            {
                _colorDal.Add(color);
            }
            else
            {
                Console.WriteLine("Koşul yerine getirilmedi. Lütfen tekrar deneyin.");
            }
            
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
