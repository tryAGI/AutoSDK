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
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Head,
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
    public static class WebGetToolParametersMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebGetToolParametersMethod value)
        {
            return value switch
            {
                WebGetToolParametersMethod.Delete => "DELETE",
                WebGetToolParametersMethod.Get => "GET",
                WebGetToolParametersMethod.Head => "HEAD",
                WebGetToolParametersMethod.Post => "POST",
                WebGetToolParametersMethod.Put => "PUT",
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
                "DELETE" => WebGetToolParametersMethod.Delete,
                "GET" => WebGetToolParametersMethod.Get,
                "HEAD" => WebGetToolParametersMethod.Head,
                "POST" => WebGetToolParametersMethod.Post,
                "PUT" => WebGetToolParametersMethod.Put,
                _ => null,
            };
        }
    }
}