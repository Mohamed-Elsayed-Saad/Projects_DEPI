using AidAmena.DAL.Entities;
using AidAmena.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Repo.Implemention
{
    internal class AdditionalCostRepo : IAdditionalCostRepo
    {
        public (bool, string?) Create(AdditionalCost additionalCost)
        {
            throw new NotImplementedException();
        }

        public (bool, string?) Delete(int additionalCostId)
        {
            throw new NotImplementedException();
        }

        public (bool, string?) Edit(AdditionalCost newAdditionalCost, int oldAdditionalCostId)
        {
            throw new NotImplementedException();
        }

        public (bool, string?, List<AdditionalCost>?) GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool, string?, AdditionalCost?) GetById(int additionalCostId)
        {
            throw new NotImplementedException();
        }
    }
}
