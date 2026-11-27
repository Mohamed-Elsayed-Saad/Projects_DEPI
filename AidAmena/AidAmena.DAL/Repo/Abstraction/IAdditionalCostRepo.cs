using AidAmena.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Repo.Abstraction
{
    public interface IAdditionalCostRepo
    {
        (bool, string?) Create(AdditionalCost additionalCost);

        (bool, string?) Edit(AdditionalCost newAdditionalCost, int oldAdditionalCostId);

        (bool, string?, List<AdditionalCost>?) GetAll();

        (bool, string?, AdditionalCost?) GetById(int additionalCostId);

        (bool, string?) Delete(int additionalCostId);
    }
}
