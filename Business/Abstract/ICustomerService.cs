using Core.Utililies.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Using.Core.Entities;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int userId);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }
}
