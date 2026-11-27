using AidAmena.DAL.Entities;
using AidAmena.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Repo.Implemention
{
    public class ArtisanRepo : IArtisanRepo
    {
        public (bool, string?) Create(Artisan artisan)
        {
            throw new NotImplementedException();
        }

        public (bool, string) Delete(string ArtisanId)
        {
            throw new NotImplementedException();
        }

        public (bool, string?) Edit(Artisan newartisan, string oldartisanID)
        {
            throw new NotImplementedException();
        }

        public (bool, string?, List<Artisan>?) GetALL()
        {
            throw new NotImplementedException();
        }

        public (bool, string?, Artisan?) GetById(string ArtisanId)
        {
            throw new NotImplementedException();
        }
    }
}
