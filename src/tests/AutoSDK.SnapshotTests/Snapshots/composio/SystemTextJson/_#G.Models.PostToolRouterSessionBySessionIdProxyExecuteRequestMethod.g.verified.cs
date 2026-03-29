//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the request<br/>
    /// Example: GET
    /// </summary>
    public enum PostToolRouterSessionBySessionIdProxyExecuteRequestMethod
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
    public static class PostToolRouterSessionBySessionIdProxyExecuteRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdProxyExecuteRequestMethod value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Delete => "DELETE",
                PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Get => "GET",
                PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Head => "HEAD",
                PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Patch => "PATCH",
                PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Post => "POST",
                PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Delete,
                "GET" => PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Get,
                "HEAD" => PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Head,
                "PATCH" => PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Patch,
                "POST" => PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Post,
                "PUT" => PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.Put,
                _ => null,
            };
        }
    }
}