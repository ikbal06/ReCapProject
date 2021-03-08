﻿using Castle.DynamicProxy;
using Core.Utililies.Interceptors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Core.Aspects.Autofac.Transiction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (System.Exception e)
                {
                    transactionScope.Dispose();
                    throw;
                }
            }
        }
    }
}
