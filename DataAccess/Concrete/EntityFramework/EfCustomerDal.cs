using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Using.Core.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepostioryBase<Customer, ReCapDbContext>, ICustomerDal
    {
    }
}
