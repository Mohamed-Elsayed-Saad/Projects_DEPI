using AidAmena.DAL.Entities;
using AidAmena.DAL.Repo.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Repo.Implemention
{
    public class CertificateRepo : ICertificateRepo
    {
        public (bool, string?) Create(Certificate certificate)
        {
            throw new NotImplementedException();
        }

        public (bool, string?) Delete(int certificateId)
        {
            throw new NotImplementedException();
        }

        public (bool, string?) Edit(Certificate newCertificate, int oldCertificateId)
        {
            throw new NotImplementedException();
        }

        public (bool, string?, List<Certificate>?) GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool, string?, Certificate?) GetById(int certificateId)
        {
            throw new NotImplementedException();
        }
    }
}
