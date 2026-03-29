//HintName: G.Models.PostToolsExecuteProxyRequestMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The HTTP method to use for the request<br/>
    /// Example: GET
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolsExecuteProxyRequestMethod
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