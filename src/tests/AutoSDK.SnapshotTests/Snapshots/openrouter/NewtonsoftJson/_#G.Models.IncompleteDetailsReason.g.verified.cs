//HintName: G.Models.IncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_filter")]
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_output_tokens")]
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