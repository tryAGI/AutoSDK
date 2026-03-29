//HintName: G.Models.CreateModelResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelResponseItemIn
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
    public static class CreateModelResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelResponseItemIn value)
        {
            return value switch
            {
                CreateModelResponseItemIn.Body => "body",
                CreateModelResponseItemIn.Cookie => "cookie",
                CreateModelResponseItemIn.Header => "header",
                CreateModelResponseItemIn.Path => "path",
                CreateModelResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => CreateModelResponseItemIn.Body,
                "cookie" => CreateModelResponseItemIn.Cookie,
                "header" => CreateModelResponseItemIn.Header,
                "path" => CreateModelResponseItemIn.Path,
                "query" => CreateModelResponseItemIn.Query,
                _ => null,
            };
        }
    }
}