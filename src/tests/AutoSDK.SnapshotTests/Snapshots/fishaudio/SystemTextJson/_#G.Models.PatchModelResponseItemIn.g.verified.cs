//HintName: G.Models.PatchModelResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchModelResponseItemIn
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
    public static class PatchModelResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchModelResponseItemIn value)
        {
            return value switch
            {
                PatchModelResponseItemIn.Body => "body",
                PatchModelResponseItemIn.Cookie => "cookie",
                PatchModelResponseItemIn.Header => "header",
                PatchModelResponseItemIn.Path => "path",
                PatchModelResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchModelResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => PatchModelResponseItemIn.Body,
                "cookie" => PatchModelResponseItemIn.Cookie,
                "header" => PatchModelResponseItemIn.Header,
                "path" => PatchModelResponseItemIn.Path,
                "query" => PatchModelResponseItemIn.Query,
                _ => null,
            };
        }
    }
}