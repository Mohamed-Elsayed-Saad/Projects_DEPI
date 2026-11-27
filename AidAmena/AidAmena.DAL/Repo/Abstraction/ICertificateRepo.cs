using AidAmena.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Repo.Abstraction
{
    public interface ICertificateRepo
    {
        (bool, string?) Create(Certificate certificate);

        (bool, string?) Edit(Certificate newCertificate, int oldCertificateId);

        (bool, string?, List<Certificate>?) GetAll();

        (bool, string?, Certificate?) GetById(int certificateId);

        (bool, string?) Delete(int certificateId);
    }
}
