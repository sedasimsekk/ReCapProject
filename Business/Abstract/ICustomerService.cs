using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IResult Deleted(Customer customer);
        IResult Updated(Customer customer);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        IDataResult<Customer> GetByCustomerId(int customerId);
        IDataResult<Customer> GetByCustomerUserId(int customeruserid);
    }
}
