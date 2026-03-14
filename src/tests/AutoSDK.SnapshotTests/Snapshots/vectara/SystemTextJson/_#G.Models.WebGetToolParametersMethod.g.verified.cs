//HintName: G.Models.WebGetToolParametersMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HTTP method to use.
    /// </summary>
    public enum WebGetToolParametersMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Head,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebGetToolParametersMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebGetToolParametersMethod value)
        {
            return value switch
            {
                WebGetToolParametersMethod.Get => "GET",
                WebGetToolParametersMethod.Post => "POST",
                WebGetToolParametersMethod.Put => "PUT",
                WebGetToolParametersMethod.Delete => "DELETE",
                WebGetToolParametersMethod.Head => "HEAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebGetToolParametersMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => WebGetToolParametersMethod.Get,
                "POST" => WebGetToolParametersMethod.Post,
                "PUT" => WebGetToolParametersMethod.Put,
                "DELETE" => WebGetToolParametersMethod.Delete,
                "HEAD" => WebGetToolParametersMethod.Head,
                _ => null,
            };
        }
    }
}