//HintName: G.Models.PostToolsExecuteProxyRequestMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the request<br/>
    /// Example: GET
    /// </summary>
    public enum PostToolsExecuteProxyRequestMethod
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
    public static class PostToolsExecuteProxyRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestMethod value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestMethod.Delete => "DELETE",
                PostToolsExecuteProxyRequestMethod.Get => "GET",
                PostToolsExecuteProxyRequestMethod.Head => "HEAD",
                PostToolsExecuteProxyRequestMethod.Patch => "PATCH",
                PostToolsExecuteProxyRequestMethod.Post => "POST",
                PostToolsExecuteProxyRequestMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PostToolsExecuteProxyRequestMethod.Delete,
                "GET" => PostToolsExecuteProxyRequestMethod.Get,
                "HEAD" => PostToolsExecuteProxyRequestMethod.Head,
                "PATCH" => PostToolsExecuteProxyRequestMethod.Patch,
                "POST" => PostToolsExecuteProxyRequestMethod.Post,
                "PUT" => PostToolsExecuteProxyRequestMethod.Put,
                _ => null,
            };
        }
    }
}