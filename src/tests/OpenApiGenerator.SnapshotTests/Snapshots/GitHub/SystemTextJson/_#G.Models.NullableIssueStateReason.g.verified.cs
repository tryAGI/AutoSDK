//HintName: G.Models.NullableIssueStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state
    /// <br/>Example: not_planned
    /// </summary>
    public enum NullableIssueStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Reopened,
        /// <summary>
        /// 
        /// </summary>
        NotPlanned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableIssueStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableIssueStateReason value)
        {
            return value switch
            {
                NullableIssueStateReason.Completed => "completed",
                NullableIssueStateReason.Reopened => "reopened",
                NullableIssueStateReason.NotPlanned => "not_planned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableIssueStateReason ToEnum(string value)
        {
            return value switch
            {
                "completed" => NullableIssueStateReason.Completed,
                "reopened" => NullableIssueStateReason.Reopened,
                "not_planned" => NullableIssueStateReason.NotPlanned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}