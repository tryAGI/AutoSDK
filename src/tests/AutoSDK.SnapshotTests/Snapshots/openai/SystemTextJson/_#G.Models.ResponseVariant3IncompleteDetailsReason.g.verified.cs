//HintName: G.Models.ResponseVariant3IncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason why the response is incomplete.
    /// </summary>
    public enum ResponseVariant3IncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        MaxOutputTokens,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant3IncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant3IncompleteDetailsReason value)
        {
            return value switch
            {
                ResponseVariant3IncompleteDetailsReason.MaxOutputTokens => "max_output_tokens",
                ResponseVariant3IncompleteDetailsReason.ContentFilter => "content_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant3IncompleteDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "max_output_tokens" => ResponseVariant3IncompleteDetailsReason.MaxOutputTokens,
                "content_filter" => ResponseVariant3IncompleteDetailsReason.ContentFilter,
                _ => null,
            };
        }
    }
}