using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotDetailsEFCore.Models
{
    public class LotType
    {
        public int LotTypeInd { get; set; }
        public string? LotTypeName { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
