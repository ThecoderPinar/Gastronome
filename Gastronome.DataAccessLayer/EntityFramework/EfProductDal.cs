using Gastronome.DataAccessLayer.Abstract;
using Gastronome.DataAccessLayer.Context;
using Gastronome.DataAccessLayer.Repositories;
using Gastronome.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastronome.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(GastronomeContext context) : base(context)
        {
        }
    }
}
