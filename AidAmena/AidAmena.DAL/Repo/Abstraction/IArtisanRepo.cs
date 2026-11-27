using AidAmena.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Repo.Abstraction
{
    public interface IArtisanRepo
    {
        (bool, string?) Create(Artisan artisan);
        (bool, string?) Edit(Artisan newartisan, string oldartisanID);
        (bool, string?, List<Artisan>?) GetALL();
        (bool, string?, Artisan?) GetById(string ArtisanId);

        (bool, string) Delete(string ArtisanId);
    }
}
