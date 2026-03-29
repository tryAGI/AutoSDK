//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the request<br/>
    /// Example: GET
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionBySessionIdProxyExecuteRequestMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DELETE")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GET")]
        Get,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HEAD")]
        Head,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PATCH")]
        Patch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POST")]
        Post,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PUT")]
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