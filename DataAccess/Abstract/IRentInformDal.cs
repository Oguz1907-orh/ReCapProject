using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IRentInformDal: IEntityRepository <RentInform>
    {
        bool CheckIfCarIsAvailable(int carId);
    }
}
