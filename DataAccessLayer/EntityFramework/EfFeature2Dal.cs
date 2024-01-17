using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeature2Dal:GenericRepository<feature2>,Ifeature2Dal
    {
    }
}
