//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant2State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant2State
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssueVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant2State value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant2State.Open => "open",
                WebhookIssueCommentCreatedIssueVariant2State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentCreatedIssueVariant2State.Open,
                "closed" => WebhookIssueCommentCreatedIssueVariant2State.Closed,
                _ => null,
            };
        }
    }
}