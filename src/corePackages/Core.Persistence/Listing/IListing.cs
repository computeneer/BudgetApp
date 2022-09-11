using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Listing
{
    public interface IListing<T>
    {
        int Count { get; }
        IList<T> Items { get; }
    }
}
