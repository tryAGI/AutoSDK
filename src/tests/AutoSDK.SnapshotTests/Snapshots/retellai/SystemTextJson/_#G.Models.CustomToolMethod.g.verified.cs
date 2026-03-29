//HintName: G.Models.CustomToolMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method to use for the request, default to POST.
    /// </summary>
    public enum CustomToolMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolMethod value)
        {
            return value switch
            {
                CustomToolMethod.Delete => "DELETE",
                CustomToolMethod.Get => "GET",
                CustomToolMethod.Patch => "PATCH",
                CustomToolMethod.Post => "POST",
                CustomToolMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => CustomToolMethod.Delete,
                "GET" => CustomToolMethod.Get,
                "PATCH" => CustomToolMethod.Patch,
                "POST" => CustomToolMethod.Post,
                "PUT" => CustomToolMethod.Put,
                _ => null,
            };
        }
    }
}