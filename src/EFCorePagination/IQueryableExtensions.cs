namespace EFCorePagination
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> data, int pageNumber, int pageSize)
        {
            return data
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        public static IQueryable<T> FirstPage<T>(this IQueryable<T> data, int pageSize)
        {
            return data.Take(pageSize);
        }

        public static IQueryable<T> LastPage<T>(this IQueryable<T> data, int pageSize)
        {
            var total = data.Count();

            return data
                .Skip(((total / pageSize) - 1) * pageSize)
                .Take(pageSize);
        }

        public static int CountOfPages<T>(this IQueryable<T> data, int pageSize)
        {
            var total = data.Count();

            return (total / pageSize) + ((total % pageSize) > 0 ? 1 : 0);
        }
    }
}
