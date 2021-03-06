﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetCarsByBrandId(int id);
        IResult Added(Brand brand);
        IResult Deleted(Brand brand);
        IResult Updated(Brand brand);
    }
}
