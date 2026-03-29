//HintName: G.Models.CreateTtsResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTtsResponseItemIn
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
    public static class CreateTtsResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTtsResponseItemIn value)
        {
            return value switch
            {
                CreateTtsResponseItemIn.Body => "body",
                CreateTtsResponseItemIn.Cookie => "cookie",
                CreateTtsResponseItemIn.Header => "header",
                CreateTtsResponseItemIn.Path => "path",
                CreateTtsResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTtsResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => CreateTtsResponseItemIn.Body,
                "cookie" => CreateTtsResponseItemIn.Cookie,
                "header" => CreateTtsResponseItemIn.Header,
                "path" => CreateTtsResponseItemIn.Path,
                "query" => CreateTtsResponseItemIn.Query,
                _ => null,
            };
        }
    }
}