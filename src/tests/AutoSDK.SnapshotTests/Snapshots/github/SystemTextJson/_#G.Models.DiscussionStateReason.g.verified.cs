//HintName: G.Models.DiscussionStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state<br/>
    /// Example: resolved
    /// </summary>
    public enum DiscussionStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        Duplicate,
        /// <summary>
        /// 
        /// </summary>
        Outdated,
        /// <summary>
        /// 
        /// </summary>
        Reopened,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscussionStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscussionStateReason value)
        {
            return value switch
            {
                DiscussionStateReason.Duplicate => "duplicate",
                DiscussionStateReason.Outdated => "outdated",
                DiscussionStateReason.Reopened => "reopened",
                DiscussionStateReason.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionStateReason? ToEnum(string value)
        {
            return value switch
            {
                "duplicate" => DiscussionStateReason.Duplicate,
                "outdated" => DiscussionStateReason.Outdated,
                "reopened" => DiscussionStateReason.Reopened,
                "resolved" => DiscussionStateReason.Resolved,
                _ => null,
            };
        }
    }
}