//HintName: G.Models.IssueStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state<br/>
    /// Example: not_planned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssueStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reopened")]
        Reopened,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_planned")]
        NotPlanned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssueStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueStateReason value)
        {
            return value switch
            {
                IssueStateReason.Completed => "completed",
                IssueStateReason.Reopened => "reopened",
                IssueStateReason.NotPlanned => "not_planned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueStateReason? ToEnum(string value)
        {
            return value switch
            {
                "completed" => IssueStateReason.Completed,
                "reopened" => IssueStateReason.Reopened,
                "not_planned" => IssueStateReason.NotPlanned,
                _ => null,
            };
        }
    }
}