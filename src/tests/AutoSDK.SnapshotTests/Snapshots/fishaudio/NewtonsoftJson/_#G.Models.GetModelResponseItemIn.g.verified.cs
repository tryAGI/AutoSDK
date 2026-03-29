//HintName: G.Models.GetModelResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetModelResponseItemIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="body")]
        Body,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cookie")]
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="header")]
        Header,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="path")]
        Path,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseItemIn value)
        {
            return value switch
            {
                GetModelResponseItemIn.Body => "body",
                GetModelResponseItemIn.Cookie => "cookie",
                GetModelResponseItemIn.Header => "header",
                GetModelResponseItemIn.Path => "path",
                GetModelResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => GetModelResponseItemIn.Body,
                "cookie" => GetModelResponseItemIn.Cookie,
                "header" => GetModelResponseItemIn.Header,
                "path" => GetModelResponseItemIn.Path,
                "query" => GetModelResponseItemIn.Query,
                _ => null,
            };
        }
    }
}