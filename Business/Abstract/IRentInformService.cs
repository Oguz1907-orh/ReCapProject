using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentInformService
    {
        IDataResult<List<RentInform>> GetAll();
        IDataResult<List<RentInform>> GetRentInformById(int rentInformId);
        IResult Add(RentInform rentinform);
        IResult Update(RentInform rentinform);
        IResult Delete(RentInform rentinform);
    }
}
