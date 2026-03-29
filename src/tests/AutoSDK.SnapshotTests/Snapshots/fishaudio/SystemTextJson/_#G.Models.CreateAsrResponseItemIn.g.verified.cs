//HintName: G.Models.CreateAsrResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAsrResponseItemIn
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
    public static class CreateAsrResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsrResponseItemIn value)
        {
            return value switch
            {
                CreateAsrResponseItemIn.Body => "body",
                CreateAsrResponseItemIn.Cookie => "cookie",
                CreateAsrResponseItemIn.Header => "header",
                CreateAsrResponseItemIn.Path => "path",
                CreateAsrResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsrResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => CreateAsrResponseItemIn.Body,
                "cookie" => CreateAsrResponseItemIn.Cookie,
                "header" => CreateAsrResponseItemIn.Header,
                "path" => CreateAsrResponseItemIn.Path,
                "query" => CreateAsrResponseItemIn.Query,
                _ => null,
            };
        }
    }
}