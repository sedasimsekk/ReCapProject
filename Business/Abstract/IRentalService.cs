using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalsByCarId(int carId);
        IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId);
        IResult Added(Rental rental);
        IResult Updated(Rental rental);
        IResult CheckReturnDate(int carId);
        IResult UpdateReturnDate(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<Rental> GetByRentalId(int rentalId);
    }
}
