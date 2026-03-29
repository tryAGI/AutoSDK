//HintName: G.Models.DeleteModelResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteModelResponseItemIn
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
    public static class DeleteModelResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteModelResponseItemIn value)
        {
            return value switch
            {
                DeleteModelResponseItemIn.Body => "body",
                DeleteModelResponseItemIn.Cookie => "cookie",
                DeleteModelResponseItemIn.Header => "header",
                DeleteModelResponseItemIn.Path => "path",
                DeleteModelResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteModelResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => DeleteModelResponseItemIn.Body,
                "cookie" => DeleteModelResponseItemIn.Cookie,
                "header" => DeleteModelResponseItemIn.Header,
                "path" => DeleteModelResponseItemIn.Path,
                "query" => DeleteModelResponseItemIn.Query,
                _ => null,
            };
        }
    }
}