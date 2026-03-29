//HintName: G.Models.HiddenReasoningMessageState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HiddenReasoningMessageState
    {
        /// <summary>
        /// 
        /// </summary>
        Omitted,
        /// <summary>
        /// 
        /// </summary>
        Redacted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HiddenReasoningMessageStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HiddenReasoningMessageState value)
        {
            return value switch
            {
                HiddenReasoningMessageState.Omitted => "omitted",
                HiddenReasoningMessageState.Redacted => "redacted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HiddenReasoningMessageState? ToEnum(string value)
        {
            return value switch
            {
                "omitted" => HiddenReasoningMessageState.Omitted,
                "redacted" => HiddenReasoningMessageState.Redacted,
                _ => null,
            };
        }
    }
}