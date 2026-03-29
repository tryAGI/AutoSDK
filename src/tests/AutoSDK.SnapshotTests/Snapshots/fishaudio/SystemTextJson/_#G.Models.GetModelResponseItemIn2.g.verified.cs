//HintName: G.Models.GetModelResponseItemIn2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelResponseItemIn2
    {
        /// <summary>
        /// 
        /// </summary>
        Body,
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Path,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelResponseItemIn2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelResponseItemIn2 value)
        {
            return value switch
            {
                GetModelResponseItemIn2.Body => "body",
                GetModelResponseItemIn2.Cookie => "cookie",
                GetModelResponseItemIn2.Header => "header",
                GetModelResponseItemIn2.Path => "path",
                GetModelResponseItemIn2.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelResponseItemIn2? ToEnum(string value)
        {
            return value switch
            {
                "body" => GetModelResponseItemIn2.Body,
                "cookie" => GetModelResponseItemIn2.Cookie,
                "header" => GetModelResponseItemIn2.Header,
                "path" => GetModelResponseItemIn2.Path,
                "query" => GetModelResponseItemIn2.Query,
                _ => null,
            };
        }
    }
}