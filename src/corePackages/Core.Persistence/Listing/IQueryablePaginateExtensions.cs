using Microsoft.EntityFrameworkCore;

namespace Core.Persistence.Listing;

public static class IQueryablePaginateExtensions
{

    public static IListing<T> ToIListing<T>(this IQueryable<T> source)
    {
        IList<T> list = source.ToList();

        IListing<T> result = new Listing<T>(list);
        return result;
    }

    public static async Task<IListing<T>> ToIListingAsync<T>(this IQueryable<T> source)
    {
        IList<T> list = await source.ToListAsync();
        IListing<T> result = new Listing<T>(list);
        return result;
    }
}