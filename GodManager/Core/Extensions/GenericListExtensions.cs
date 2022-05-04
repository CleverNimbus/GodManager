using GodManager.Models;

namespace GodManager.Core.Extensions;
public static class GenericListExtensions
{
    public static void AddWithAutoID<T>(this IList<T> list, T entity) where T : BaseModel
    {
        var maxId = list.Max(t => t.ID);
        entity.ID = maxId + 1;
        list.Add(entity);
    }
}