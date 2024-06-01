//HintName: G.Models.DiscussionStateReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the current state
    /// <br/>Example: resolved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiscussionStateReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outdated")]
        Outdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duplicate")]
        Duplicate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reopened")]
        Reopened,
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
                DiscussionStateReason.Resolved => "resolved",
                DiscussionStateReason.Outdated => "outdated",
                DiscussionStateReason.Duplicate => "duplicate",
                DiscussionStateReason.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionStateReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => DiscussionStateReason.Resolved,
                "outdated" => DiscussionStateReason.Outdated,
                "duplicate" => DiscussionStateReason.Duplicate,
                "reopened" => DiscussionStateReason.Reopened,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}