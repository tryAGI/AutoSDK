//HintName: G.Models.ApiRequestToolMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiRequestToolMethod
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
    public static class ApiRequestToolMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiRequestToolMethod value)
        {
            return value switch
            {
                ApiRequestToolMethod.Delete => "DELETE",
                ApiRequestToolMethod.Get => "GET",
                ApiRequestToolMethod.Patch => "PATCH",
                ApiRequestToolMethod.Post => "POST",
                ApiRequestToolMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiRequestToolMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ApiRequestToolMethod.Delete,
                "GET" => ApiRequestToolMethod.Get,
                "PATCH" => ApiRequestToolMethod.Patch,
                "POST" => ApiRequestToolMethod.Post,
                "PUT" => ApiRequestToolMethod.Put,
                _ => null,
            };
        }
    }
}