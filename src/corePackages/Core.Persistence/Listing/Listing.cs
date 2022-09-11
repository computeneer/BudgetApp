using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Listing
{
    public class Listing<T> : IListing<T>
    {
        public int Count { get; set; }

        public IList<T> Items {  get; set; }

        public Listing()
        {
            Items = new List<T>();
        }

        public Listing(IList<T> items)
        {
            Items = items;
            Count = items.Count;
        }
    }
}
