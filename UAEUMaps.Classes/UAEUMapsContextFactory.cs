using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAEUMaps.Classes
{
    public class UAEUMapsContextFactory : IDbContextFactory<MapsDbContext>
    {
        public MapsDbContext Create()
        {
            throw new NotImplementedException();
        }
    }
}
