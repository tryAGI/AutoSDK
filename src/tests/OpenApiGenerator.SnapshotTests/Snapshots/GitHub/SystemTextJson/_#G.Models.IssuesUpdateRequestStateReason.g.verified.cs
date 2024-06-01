//HintName: G.Models.IssuesUpdateRequestStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the state change. Ignored unless `state` is changed.
    /// <br/>Example: not_planned
    /// </summary>
    public enum IssuesUpdateRequestStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        NotPlanned,
        /// <summary>
        /// 
        /// </summary>
        Reopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesUpdateRequestStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateRequestStateReason value)
        {
            return value switch
            {
                IssuesUpdateRequestStateReason.Completed => "completed",
                IssuesUpdateRequestStateReason.NotPlanned => "not_planned",
                IssuesUpdateRequestStateReason.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateRequestStateReason ToEnum(string value)
        {
            return value switch
            {
                "completed" => IssuesUpdateRequestStateReason.Completed,
                "not_planned" => IssuesUpdateRequestStateReason.NotPlanned,
                "reopened" => IssuesUpdateRequestStateReason.Reopened,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}