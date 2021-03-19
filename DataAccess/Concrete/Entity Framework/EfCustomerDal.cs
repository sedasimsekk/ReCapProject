using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Customers
                             join u in context.Users 
                             on c.UserId equals u.UserId 
                             select new CustomerDetailDto 
                             {
                                 CustomerId=c.CustomerId,
                                 CustomerUserId=u.UserId,
                                 CustomerFirstName=u.FirstName,
                                 CustomerLastName=u.LastName,
                                 CustomerCompanyName=c.CompanyName,
                                 CustomerEmail=u.Email
                             };
                return result.ToList();
            }
        }
    }
}
