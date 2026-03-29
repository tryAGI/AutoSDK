//HintName: G.Models.LogRequestMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HTTP method<br/>
    /// Example: POST
    /// </summary>
    public enum LogRequestMethod
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
        Options,
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
    public static class LogRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogRequestMethod value)
        {
            return value switch
            {
                LogRequestMethod.Delete => "DELETE",
                LogRequestMethod.Get => "GET",
                LogRequestMethod.Head => "HEAD",
                LogRequestMethod.Options => "OPTIONS",
                LogRequestMethod.Patch => "PATCH",
                LogRequestMethod.Post => "POST",
                LogRequestMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => LogRequestMethod.Delete,
                "GET" => LogRequestMethod.Get,
                "HEAD" => LogRequestMethod.Head,
                "OPTIONS" => LogRequestMethod.Options,
                "PATCH" => LogRequestMethod.Patch,
                "POST" => LogRequestMethod.Post,
                "PUT" => LogRequestMethod.Put,
                _ => null,
            };
        }
    }
}