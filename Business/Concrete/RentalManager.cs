using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Added(Rental rental)
        {
            var result = CheckReturnDate(rental.CarId);
            if(!result.Success)
            {
                return new ErrorResult(Messages.NotAddedRental);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetAll(r => r.CarId == carId && r.ReturnDate == null);
            if(result.Count>0)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IResult Deleted(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IDataResult<List<Rental>> GetRentalsByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        public IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId));
        }

        public IResult Updated(Rental rental)
        {
            var result = UpdateReturnDate(rental);
            if(result.Success)
            {
                _rentalDal.UpDate(rental);
                return new SuccessResult(Messages.ReturnDateUpdate);
            }
            return new ErrorResult(Messages.ReturnDateNotUpdate);
        }

        public IResult UpdateReturnDate(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId);
            if(result.ReturnDate==null)
            {
                return new SuccessResult();
            }
              return new ErrorResult();
            
        }
    }
}
