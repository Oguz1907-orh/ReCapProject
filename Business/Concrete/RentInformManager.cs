using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentInformManager : IRentInformService
    {
        IRentInformDal _rentinformDal;

        public RentInformManager(IRentInformDal rentinformDal)
        {
            _rentinformDal = rentinformDal;
        }

        [ValidationAspect(typeof(RentInformValidator))]
        public IResult Add(RentInform rentinform)
        {
            

            if (_rentinformDal.CheckIfCarIsAvailable(rentinform.CarId))
            {
                _rentinformDal.Add(rentinform);
                return new SuccessResult(Messages.RentInformAdded);
            }
            else
            {
                return new SuccessResult(Messages.CarIsNotAvailable);

            }
            
        }

        public IResult Delete(RentInform rentinform)
        {
            _rentinformDal.Delete(rentinform);
            return new SuccessResult(Messages.RentInformDeleted);
        }

        public IDataResult<List<RentInform>> GetAll()
        {
            return new SuccessDataResult<List<RentInform>>(_rentinformDal.GetAll());
        }

        public IDataResult<List<RentInform>> GetRentInformById(int rentInformId)
        {
            return new SuccessDataResult<List<RentInform>>(_rentinformDal.GetAll(r => r.Id == rentInformId));
        }

        public IResult Update(RentInform rentinform)
        {
            _rentinformDal.Update(rentinform);
            return new SuccessResult();
        }
    }
}
