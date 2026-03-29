//HintName: G.Models.IncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        MaxOutputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IncompleteDetailsReason value)
        {
            return value switch
            {
                IncompleteDetailsReason.ContentFilter => "content_filter",
                IncompleteDetailsReason.MaxOutputTokens => "max_output_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IncompleteDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => IncompleteDetailsReason.ContentFilter,
                "max_output_tokens" => IncompleteDetailsReason.MaxOutputTokens,
                _ => null,
            };
        }
    }
}