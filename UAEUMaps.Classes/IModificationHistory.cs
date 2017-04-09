using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAEUMaps.Classes
{
    public interface IModificationHistory
    {
        string Created { get; set; }
        DateTime CreatedDate { get; set; }

        string Modified { get; set; }
        DateTime ModifiedDate  { get; set; }
        string Remarks { get; set; }

    }
}
