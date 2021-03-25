using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Added(User user);
        IResult Deleted(User user);
        IResult Updated(User user);
        IDataResult<User> GetByUserId(int userId);
        IDataResult<User> GetByFırstName(string firstName);

    }
}
