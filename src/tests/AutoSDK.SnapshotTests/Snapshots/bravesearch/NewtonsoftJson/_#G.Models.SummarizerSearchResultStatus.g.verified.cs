//HintName: G.Models.SummarizerSearchResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the summarization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummarizerSearchResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial")]
        Partial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizerSearchResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizerSearchResultStatus value)
        {
            return value switch
            {
                SummarizerSearchResultStatus.Complete => "complete",
                SummarizerSearchResultStatus.Failed => "failed",
                SummarizerSearchResultStatus.Partial => "partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizerSearchResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => SummarizerSearchResultStatus.Complete,
                "failed" => SummarizerSearchResultStatus.Failed,
                "partial" => SummarizerSearchResultStatus.Partial,
                _ => null,
            };
        }
    }
}