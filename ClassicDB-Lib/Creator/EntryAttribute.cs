using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicDB_Lib.Creator
{
    public sealed class DatabaseEntryAttribute : Attribute
    {
        public readonly bool IsMandatory;
        public DatabaseEntryAttribute(bool isMandatory)
        {
            IsMandatory = isMandatory;
        }   
    }
}
