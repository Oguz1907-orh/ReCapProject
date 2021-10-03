using Business.Constants;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;

namespace Business.Abstract
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetCustomerById(int CustomerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(cu => cu.CustomerId == CustomerId));
        }

        public IResult Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(CustomerValidator))]
        IResult Add(Customer customer)
        {
           
            return new SuccessResult(Messages.CustomerAdded);
        }

        IResult ICustomerService.Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.CustomerDeleted);
        }

        IResult ICustomerService.Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        IDataResult<List<Customer>> ICustomerService.GetAll()
        {
            throw new NotImplementedException();
        }

        

        
    }
}
