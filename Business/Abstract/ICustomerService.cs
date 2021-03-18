using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetCustomersByCompanyName(string companyName); 
        IResult Added(Customer customer);
        //IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Customer> GetByCustomerId(int customerId);
    }
}
