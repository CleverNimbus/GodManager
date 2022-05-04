using System.Text.Json;
using GodManager.Core.Exceptions;

namespace GodManager.Core.Extensions;
public static class ObjectExtensions
{
    //Clone an object using a JSON serialization and deserialization
    //TODO: Check a way to do this more efficiently
    public static T CloneWithJson<T>(this T source)
    {
        if (ReferenceEquals(source, null))
            throw new GodException("Object is null");

        try
        {
            return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(source));
        }
        catch (System.Exception ex)
        {
            throw new GodException("Json serialize error", ex);
        }        
    }
}